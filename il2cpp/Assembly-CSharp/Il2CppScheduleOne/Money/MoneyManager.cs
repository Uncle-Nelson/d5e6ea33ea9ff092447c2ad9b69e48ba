using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000727 RID: 1831
	public class MoneyManager : NetworkSingleton<MoneyManager>
	{
		// Token: 0x0600A51D RID: 42269 RVA: 0x00295738 File Offset: 0x00293938
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyManager()
		{
			Il2CppClassPointerStore<MoneyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "MoneyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr);
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR");
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR_DARKER");
			MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ONLINE_BALANCE_COLOR");
			MoneyManager.NativeFieldInfoPtr_ledger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ledger");
			MoneyManager.NativeFieldInfoPtr_onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onlineBalance");
			MoneyManager.NativeFieldInfoPtr_lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LastCalculatedNetworth>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_CashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "CashSound");
			MoneyManager.NativeFieldInfoPtr_moneyChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "moneyChangePrefab");
			MoneyManager.NativeFieldInfoPtr_cashChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "cashChangePrefab");
			MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "LaunderingNotificationIcon");
			MoneyManager.NativeFieldInfoPtr_onNetworthCalculation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onNetworthCalculation");
			MoneyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "loader");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___onlineBalance");
			MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683471);
			MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683472);
			MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683473);
			MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683474);
			MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683475);
			MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683476);
			MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683477);
			MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683478);
			MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683479);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683480);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683481);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683482);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683483);
			MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683484);
			MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683485);
			MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683486);
			MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683487);
			MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683488);
			MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683489);
			MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683490);
			MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683491);
			MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683492);
			MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683493);
			MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683494);
			MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683495);
			MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683496);
			MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683497);
			MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683498);
			MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683499);
			MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683500);
			MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683501);
			MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683502);
			MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683503);
			MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683504);
			MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683505);
			MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683506);
			MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683507);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683508);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683509);
			MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683510);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683511);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683512);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683513);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683514);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683515);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683516);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683517);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683518);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683519);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683520);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683521);
			MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683522);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683523);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683524);
			MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683525);
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x00295D44 File Offset: 0x00293F44
		public unsafe float LifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59144, RefRangeEnd = 59145, XrefRangeStart = 59144, XrefRangeEnd = 59145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A51F RID: 42271 RVA: 0x00295D80 File Offset: 0x00293F80
		// (set) Token: 0x0600A520 RID: 42272 RVA: 0x00295DBC File Offset: 0x00293FBC
		public unsafe float LastCalculatedNetworth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A521 RID: 42273 RVA: 0x00295DFC File Offset: 0x00293FFC
		public unsafe float cashBalance
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 288730, RefRangeEnd = 288757, XrefRangeStart = 288729, XrefRangeEnd = 288730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x00295E38 File Offset: 0x00294038
		public unsafe CashInstance cashInstance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 288761, RefRangeEnd = 288767, XrefRangeStart = 288757, XrefRangeEnd = 288761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A523 RID: 42275 RVA: 0x00295E78 File Offset: 0x00294078
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288767, XrefRangeEnd = 288769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A524 RID: 42276 RVA: 0x00295EB0 File Offset: 0x002940B0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288769, XrefRangeEnd = 288771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x00295EE8 File Offset: 0x002940E8
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x00295F28 File Offset: 0x00294128
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A527 RID: 42279 RVA: 0x00295F64 File Offset: 0x00294164
		// (set) Token: 0x0600A528 RID: 42280 RVA: 0x00295FA4 File Offset: 0x002941A4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115214, RefRangeEnd = 115215, XrefRangeStart = 115214, XrefRangeEnd = 115215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A529 RID: 42281 RVA: 0x00295FE8 File Offset: 0x002941E8
		// (set) Token: 0x0600A52A RID: 42282 RVA: 0x00296028 File Offset: 0x00294228
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86730, RefRangeEnd = 86731, XrefRangeStart = 86730, XrefRangeEnd = 86731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A52B RID: 42283 RVA: 0x0029606C File Offset: 0x0029426C
		// (set) Token: 0x0600A52C RID: 42284 RVA: 0x002960A8 File Offset: 0x002942A8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x002960E8 File Offset: 0x002942E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288771, XrefRangeEnd = 288774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x00296124 File Offset: 0x00294324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288774, XrefRangeEnd = 288780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x00296160 File Offset: 0x00294360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288780, XrefRangeEnd = 288832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x0029619C File Offset: 0x0029439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288832, XrefRangeEnd = 288841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x002961D8 File Offset: 0x002943D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288841, XrefRangeEnd = 288848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x00296214 File Offset: 0x00294414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288848, XrefRangeEnd = 288896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x00296250 File Offset: 0x00294450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288896, XrefRangeEnd = 288903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x00296284 File Offset: 0x00294484
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x002962B8 File Offset: 0x002944B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288903, XrefRangeEnd = 288931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x002962EC File Offset: 0x002944EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288939, RefRangeEnd = 288942, XrefRangeStart = 288931, XrefRangeEnd = 288939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance GetCashInstance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x00296338 File Offset: 0x00294538
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 288967, RefRangeEnd = 288979, XrefRangeStart = 288942, XrefRangeEnd = 288967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x002963AC File Offset: 0x002945AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288992, RefRangeEnd = 288994, XrefRangeStart = 288979, XrefRangeEnd = 288992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x00296420 File Offset: 0x00294620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288994, XrefRangeEnd = 288999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x00296470 File Offset: 0x00294670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289018, RefRangeEnd = 289019, XrefRangeStart = 288999, XrefRangeEnd = 289018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLifetimeEarnings(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x002964B0 File Offset: 0x002946B0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 289069, RefRangeEnd = 289093, XrefRangeStart = 289019, XrefRangeEnd = 289069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visualizeChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playCashSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x0029650C File Offset: 0x0029470C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289093, XrefRangeEnd = 289098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x0029655C File Offset: 0x0029475C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 289129, RefRangeEnd = 289237, XrefRangeStart = 289098, XrefRangeEnd = 289129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showDecimals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x002965B0 File Offset: 0x002947B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289237, XrefRangeEnd = 289250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x002965F4 File Offset: 0x002947F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289275, RefRangeEnd = 289276, XrefRangeStart = 289250, XrefRangeEnd = 289275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoneyData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x00296638 File Offset: 0x00294838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289276, XrefRangeEnd = 289290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNetworthAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x0029666C File Offset: 0x0029486C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289294, RefRangeEnd = 289296, XrefRangeStart = 289290, XrefRangeEnd = 289294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetWorth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x002966A8 File Offset: 0x002948A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289296, XrefRangeEnd = 289323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x002966E4 File Offset: 0x002948E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289323, XrefRangeEnd = 289369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x00296720 File Offset: 0x00294920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289369, XrefRangeEnd = 289372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x0029675C File Offset: 0x0029495C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x00296798 File Offset: 0x00294998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289372, XrefRangeEnd = 289385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x0029680C File Offset: 0x00294A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288992, RefRangeEnd = 288994, XrefRangeStart = 288992, XrefRangeEnd = 288994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x00296880 File Offset: 0x00294A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289385, XrefRangeEnd = 289392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x002968E4 File Offset: 0x00294AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288992, RefRangeEnd = 288994, XrefRangeStart = 288992, XrefRangeEnd = 288994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x00296958 File Offset: 0x00294B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289463, RefRangeEnd = 289464, XrefRangeStart = 289392, XrefRangeEnd = 289463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x002969CC File Offset: 0x00294BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289464, XrefRangeEnd = 289470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x00296A1C File Offset: 0x00294C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289018, RefRangeEnd = 289019, XrefRangeStart = 289018, XrefRangeEnd = 289019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x00296A5C File Offset: 0x00294C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289470, XrefRangeEnd = 289486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x00296A9C File Offset: 0x00294C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289486, XrefRangeEnd = 289504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A54F RID: 42319 RVA: 0x00296B00 File Offset: 0x00294D00
		// (set) Token: 0x0600A550 RID: 42320 RVA: 0x00296B3C File Offset: 0x00294D3C
		public unsafe float SyncAccessor_onlineBalance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289512, RefRangeEnd = 289513, XrefRangeStart = 289504, XrefRangeEnd = 289512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x00296B88 File Offset: 0x00294D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289513, XrefRangeEnd = 289517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Money_MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A552 RID: 42322 RVA: 0x00296BFC File Offset: 0x00294DFC
		// (set) Token: 0x0600A553 RID: 42323 RVA: 0x00296C38 File Offset: 0x00294E38
		public unsafe float SyncAccessor_lifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59144, RefRangeEnd = 59145, XrefRangeStart = 59144, XrefRangeEnd = 59145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289517, XrefRangeEnd = 289525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x00296C84 File Offset: 0x00294E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289525, XrefRangeEnd = 289528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x00051601 File Offset: 0x0004F801
		public MoneyManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A556 RID: 42326 RVA: 0x00296CC0 File Offset: 0x00294EC0
		// (set) Token: 0x0600A557 RID: 42327 RVA: 0x0005160A File Offset: 0x0004F80A
		public unsafe static string MONEY_TEXT_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x00296CE0 File Offset: 0x00294EE0
		// (set) Token: 0x0600A559 RID: 42329 RVA: 0x0005161C File Offset: 0x0004F81C
		public unsafe static string MONEY_TEXT_COLOR_DARKER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A55A RID: 42330 RVA: 0x00296D00 File Offset: 0x00294F00
		// (set) Token: 0x0600A55B RID: 42331 RVA: 0x0005162E File Offset: 0x0004F82E
		public unsafe static string ONLINE_BALANCE_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x00296D20 File Offset: 0x00294F20
		// (set) Token: 0x0600A55D RID: 42333 RVA: 0x00051640 File Offset: 0x0004F840
		public unsafe List<Transaction> ledger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transaction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600A55E RID: 42334 RVA: 0x00296D50 File Offset: 0x00294F50
		// (set) Token: 0x0600A55F RID: 42335 RVA: 0x0005165F File Offset: 0x0004F85F
		public unsafe float onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance)) = value;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x00296D78 File Offset: 0x00294F78
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x0005167A File Offset: 0x0004F87A
		public unsafe float lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings)) = value;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x00296DA0 File Offset: 0x00294FA0
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x00051695 File Offset: 0x0004F895
		public unsafe float _LastCalculatedNetworth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField)) = value;
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x00296DC8 File Offset: 0x00294FC8
		// (set) Token: 0x0600A565 RID: 42341 RVA: 0x000516B0 File Offset: 0x0004F8B0
		public unsafe AudioSourceController CashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600A566 RID: 42342 RVA: 0x00296DF8 File Offset: 0x00294FF8
		// (set) Token: 0x0600A567 RID: 42343 RVA: 0x000516CF File Offset: 0x0004F8CF
		public unsafe GameObject moneyChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x00296E28 File Offset: 0x00295028
		// (set) Token: 0x0600A569 RID: 42345 RVA: 0x000516EE File Offset: 0x0004F8EE
		public unsafe GameObject cashChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A56A RID: 42346 RVA: 0x00296E58 File Offset: 0x00295058
		// (set) Token: 0x0600A56B RID: 42347 RVA: 0x0005170D File Offset: 0x0004F90D
		public unsafe Sprite LaunderingNotificationIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x00296E88 File Offset: 0x00295088
		// (set) Token: 0x0600A56D RID: 42349 RVA: 0x0005172C File Offset: 0x0004F92C
		public unsafe Action<MoneyManager.FloatContainer> onNetworthCalculation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoneyManager.FloatContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x00296EB8 File Offset: 0x002950B8
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x0005174B File Offset: 0x0004F94B
		public unsafe MoneyLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoneyLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A570 RID: 42352 RVA: 0x00296EE8 File Offset: 0x002950E8
		// (set) Token: 0x0600A571 RID: 42353 RVA: 0x0005176A File Offset: 0x0004F96A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A572 RID: 42354 RVA: 0x00296F18 File Offset: 0x00295118
		// (set) Token: 0x0600A573 RID: 42355 RVA: 0x00051789 File Offset: 0x0004F989
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A574 RID: 42356 RVA: 0x00296F48 File Offset: 0x00295148
		// (set) Token: 0x0600A575 RID: 42357 RVA: 0x000517A8 File Offset: 0x0004F9A8
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A576 RID: 42358 RVA: 0x00296F70 File Offset: 0x00295170
		// (set) Token: 0x0600A577 RID: 42359 RVA: 0x000517C3 File Offset: 0x0004F9C3
		public unsafe SyncVar<float> syncVar___onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A578 RID: 42360 RVA: 0x00296FA0 File Offset: 0x002951A0
		// (set) Token: 0x0600A579 RID: 42361 RVA: 0x000517E2 File Offset: 0x0004F9E2
		public unsafe SyncVar<float> syncVar___lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x00296FD0 File Offset: 0x002951D0
		// (set) Token: 0x0600A57B RID: 42363 RVA: 0x00051801 File Offset: 0x0004FA01
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A57C RID: 42364 RVA: 0x00296FF8 File Offset: 0x002951F8
		// (set) Token: 0x0600A57D RID: 42365 RVA: 0x0005181C File Offset: 0x0004FA1C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006EB1 RID: 28337
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR;

		// Token: 0x04006EB2 RID: 28338
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER;

		// Token: 0x04006EB3 RID: 28339
		private static readonly IntPtr NativeFieldInfoPtr_ONLINE_BALANCE_COLOR;

		// Token: 0x04006EB4 RID: 28340
		private static readonly IntPtr NativeFieldInfoPtr_ledger;

		// Token: 0x04006EB5 RID: 28341
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalance;

		// Token: 0x04006EB6 RID: 28342
		private static readonly IntPtr NativeFieldInfoPtr_lifetimeEarnings;

		// Token: 0x04006EB7 RID: 28343
		private static readonly IntPtr NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField;

		// Token: 0x04006EB8 RID: 28344
		private static readonly IntPtr NativeFieldInfoPtr_CashSound;

		// Token: 0x04006EB9 RID: 28345
		private static readonly IntPtr NativeFieldInfoPtr_moneyChangePrefab;

		// Token: 0x04006EBA RID: 28346
		private static readonly IntPtr NativeFieldInfoPtr_cashChangePrefab;

		// Token: 0x04006EBB RID: 28347
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingNotificationIcon;

		// Token: 0x04006EBC RID: 28348
		private static readonly IntPtr NativeFieldInfoPtr_onNetworthCalculation;

		// Token: 0x04006EBD RID: 28349
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04006EBE RID: 28350
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04006EBF RID: 28351
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04006EC0 RID: 28352
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04006EC1 RID: 28353
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___onlineBalance;

		// Token: 0x04006EC2 RID: 28354
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___lifetimeEarnings;

		// Token: 0x04006EC3 RID: 28355
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006EC4 RID: 28356
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006EC5 RID: 28357
		private static readonly IntPtr NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0;

		// Token: 0x04006EC6 RID: 28358
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0;

		// Token: 0x04006EC7 RID: 28359
		private static readonly IntPtr NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0;

		// Token: 0x04006EC8 RID: 28360
		private static readonly IntPtr NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0;

		// Token: 0x04006EC9 RID: 28361
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0;

		// Token: 0x04006ECA RID: 28362
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006ECB RID: 28363
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006ECC RID: 28364
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04006ECD RID: 28365
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006ECE RID: 28366
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006ECF RID: 28367
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006ED0 RID: 28368
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006ED1 RID: 28369
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006ED2 RID: 28370
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006ED3 RID: 28371
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04006ED4 RID: 28372
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006ED5 RID: 28373
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04006ED6 RID: 28374
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04006ED7 RID: 28375
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04006ED8 RID: 28376
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04006ED9 RID: 28377
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04006EDA RID: 28378
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04006EDB RID: 28379
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006EDC RID: 28380
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04006EDD RID: 28381
		private static readonly IntPtr NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0;

		// Token: 0x04006EDE RID: 28382
		private static readonly IntPtr NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0;

		// Token: 0x04006EDF RID: 28383
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EE0 RID: 28384
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04006EE1 RID: 28385
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0;

		// Token: 0x04006EE2 RID: 28386
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04006EE3 RID: 28387
		private static readonly IntPtr NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04006EE4 RID: 28388
		private static readonly IntPtr NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0;

		// Token: 0x04006EE5 RID: 28389
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04006EE6 RID: 28390
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_MoneyData_0;

		// Token: 0x04006EE7 RID: 28391
		private static readonly IntPtr NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0;

		// Token: 0x04006EE8 RID: 28392
		private static readonly IntPtr NativeMethodInfoPtr_GetNetWorth_Public_Single_0;

		// Token: 0x04006EE9 RID: 28393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006EEA RID: 28394
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006EEB RID: 28395
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006EEC RID: 28396
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006EED RID: 28397
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EEE RID: 28398
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0;

		// Token: 0x04006EEF RID: 28399
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006EF0 RID: 28400
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EF1 RID: 28401
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EF2 RID: 28402
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006EF3 RID: 28403
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0;

		// Token: 0x04006EF4 RID: 28404
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0;

		// Token: 0x04006EF5 RID: 28405
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006EF6 RID: 28406
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0;

		// Token: 0x04006EF7 RID: 28407
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0;

		// Token: 0x04006EF8 RID: 28408
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04006EF9 RID: 28409
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0;

		// Token: 0x04006EFA RID: 28410
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0;

		// Token: 0x04006EFB RID: 28411
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BCB RID: 3019
		public class FloatContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DE09 RID: 56841 RVA: 0x0034674C File Offset: 0x0034494C
			// Note: this type is marked as 'beforefieldinit'.
			static FloatContainer()
			{
				Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "FloatContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr);
				MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, "<value>k__BackingField");
				MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683526);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683527);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683528);
				MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683529);
			}

			// Token: 0x170044CB RID: 17611
			// (get) Token: 0x0600DE0A RID: 56842 RVA: 0x003467DC File Offset: 0x003449DC
			// (set) Token: 0x0600DE0B RID: 56843 RVA: 0x00346818 File Offset: 0x00344A18
			public unsafe float value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 29950, RefRangeEnd = 29954, XrefRangeStart = 29950, XrefRangeEnd = 29954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600DE0C RID: 56844 RVA: 0x00346858 File Offset: 0x00344A58
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118757, RefRangeEnd = 118763, XrefRangeStart = 118757, XrefRangeEnd = 118763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangeValue(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE0D RID: 56845 RVA: 0x00346898 File Offset: 0x00344A98
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE0E RID: 56846 RVA: 0x0006C3B3 File Offset: 0x0006A5B3
			public FloatContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044CA RID: 17610
			// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x003468D4 File Offset: 0x00344AD4
			// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x0006C3BC File Offset: 0x0006A5BC
			public unsafe float _value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField)) = value;
				}
			}

			// Token: 0x040094AE RID: 38062
			private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

			// Token: 0x040094AF RID: 38063
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

			// Token: 0x040094B0 RID: 38064
			private static readonly IntPtr NativeMethodInfoPtr_set_value_Private_set_Void_Single_0;

			// Token: 0x040094B1 RID: 38065
			private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0;

			// Token: 0x040094B2 RID: 38066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BCC RID: 3020
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowCashChange>d__58")]
		public sealed class _ShowCashChange_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600DE11 RID: 56849 RVA: 0x003468FC File Offset: 0x00344AFC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowCashChange_d__58()
			{
				Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowCashChange>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr);
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683530);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683531);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683532);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683533);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683534);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683535);
			}

			// Token: 0x0600DE12 RID: 56850 RVA: 0x00346A40 File Offset: 0x00344C40
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowCashChange_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE13 RID: 56851 RVA: 0x00346A88 File Offset: 0x00344C88
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE14 RID: 56852 RVA: 0x00346ABC File Offset: 0x00344CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288671, XrefRangeEnd = 288695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044D4 RID: 17620
			// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x00346AF8 File Offset: 0x00344CF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE16 RID: 56854 RVA: 0x00346B38 File Offset: 0x00344D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288695, XrefRangeEnd = 288700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044D5 RID: 17621
			// (get) Token: 0x0600DE17 RID: 56855 RVA: 0x00346B6C File Offset: 0x00344D6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE18 RID: 56856 RVA: 0x0006C3D7 File Offset: 0x0006A5D7
			public _ShowCashChange_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044CC RID: 17612
			// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x00346BAC File Offset: 0x00344DAC
			// (set) Token: 0x0600DE1A RID: 56858 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044CD RID: 17613
			// (get) Token: 0x0600DE1B RID: 56859 RVA: 0x00346BD4 File Offset: 0x00344DD4
			// (set) Token: 0x0600DE1C RID: 56860 RVA: 0x0006C3FB File Offset: 0x0006A5FB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CE RID: 17614
			// (get) Token: 0x0600DE1D RID: 56861 RVA: 0x00346C04 File Offset: 0x00344E04
			// (set) Token: 0x0600DE1E RID: 56862 RVA: 0x0006C41A File Offset: 0x0006A61A
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CF RID: 17615
			// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x00346C34 File Offset: 0x00344E34
			// (set) Token: 0x0600DE20 RID: 56864 RVA: 0x0006C439 File Offset: 0x0006A639
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D0 RID: 17616
			// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x00346C64 File Offset: 0x00344E64
			// (set) Token: 0x0600DE22 RID: 56866 RVA: 0x0006C458 File Offset: 0x0006A658
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x170044D1 RID: 17617
			// (get) Token: 0x0600DE23 RID: 56867 RVA: 0x00346C8C File Offset: 0x00344E8C
			// (set) Token: 0x0600DE24 RID: 56868 RVA: 0x0006C473 File Offset: 0x0006A673
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170044D2 RID: 17618
			// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x00346CB4 File Offset: 0x00344EB4
			// (set) Token: 0x0600DE26 RID: 56870 RVA: 0x0006C48E File Offset: 0x0006A68E
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x170044D3 RID: 17619
			// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x00346CDC File Offset: 0x00344EDC
			// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x0006C4A9 File Offset: 0x0006A6A9
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040094B3 RID: 38067
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094B4 RID: 38068
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094B5 RID: 38069
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x040094B6 RID: 38070
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x040094B7 RID: 38071
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x040094B8 RID: 38072
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040094B9 RID: 38073
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x040094BA RID: 38074
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040094BB RID: 38075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094BC RID: 38076
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094BD RID: 38077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094BE RID: 38078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094BF RID: 38079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094C0 RID: 38080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BCD RID: 3021
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowOnlineBalanceChange>d__55")]
		public sealed class _ShowOnlineBalanceChange_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600DE29 RID: 56873 RVA: 0x00346D04 File Offset: 0x00344F04
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnlineBalanceChange_d__55()
			{
				Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowOnlineBalanceChange>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683536);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683537);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683538);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683539);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683540);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683541);
			}

			// Token: 0x0600DE2A RID: 56874 RVA: 0x00346E48 File Offset: 0x00345048
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnlineBalanceChange_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2B RID: 56875 RVA: 0x00346E90 File Offset: 0x00345090
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x00346EC4 File Offset: 0x003450C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288700, XrefRangeEnd = 288724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044DE RID: 17630
			// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x00346F00 File Offset: 0x00345100
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE2E RID: 56878 RVA: 0x00346F40 File Offset: 0x00345140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288724, XrefRangeEnd = 288729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044DF RID: 17631
			// (get) Token: 0x0600DE2F RID: 56879 RVA: 0x00346F74 File Offset: 0x00345174
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE30 RID: 56880 RVA: 0x0006C4C4 File Offset: 0x0006A6C4
			public _ShowOnlineBalanceChange_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D6 RID: 17622
			// (get) Token: 0x0600DE31 RID: 56881 RVA: 0x00346FB4 File Offset: 0x003451B4
			// (set) Token: 0x0600DE32 RID: 56882 RVA: 0x0006C4CD File Offset: 0x0006A6CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0600DE33 RID: 56883 RVA: 0x00346FDC File Offset: 0x003451DC
			// (set) Token: 0x0600DE34 RID: 56884 RVA: 0x0006C4E8 File Offset: 0x0006A6E8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D8 RID: 17624
			// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x0034700C File Offset: 0x0034520C
			// (set) Token: 0x0600DE36 RID: 56886 RVA: 0x0006C507 File Offset: 0x0006A707
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D9 RID: 17625
			// (get) Token: 0x0600DE37 RID: 56887 RVA: 0x0034703C File Offset: 0x0034523C
			// (set) Token: 0x0600DE38 RID: 56888 RVA: 0x0006C526 File Offset: 0x0006A726
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DA RID: 17626
			// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x0034706C File Offset: 0x0034526C
			// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x0006C545 File Offset: 0x0006A745
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0600DE3B RID: 56891 RVA: 0x00347094 File Offset: 0x00345294
			// (set) Token: 0x0600DE3C RID: 56892 RVA: 0x0006C560 File Offset: 0x0006A760
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170044DC RID: 17628
			// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x003470BC File Offset: 0x003452BC
			// (set) Token: 0x0600DE3E RID: 56894 RVA: 0x0006C57B File Offset: 0x0006A77B
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x170044DD RID: 17629
			// (get) Token: 0x0600DE3F RID: 56895 RVA: 0x003470E4 File Offset: 0x003452E4
			// (set) Token: 0x0600DE40 RID: 56896 RVA: 0x0006C596 File Offset: 0x0006A796
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040094C1 RID: 38081
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094C2 RID: 38082
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094C3 RID: 38083
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x040094C4 RID: 38084
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x040094C5 RID: 38085
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x040094C6 RID: 38086
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040094C7 RID: 38087
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x040094C8 RID: 38088
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040094C9 RID: 38089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094CA RID: 38090
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094CB RID: 38091
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094CC RID: 38092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094CD RID: 38093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094CE RID: 38094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
