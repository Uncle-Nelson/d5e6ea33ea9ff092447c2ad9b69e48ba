using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BE RID: 958
	public class LevelManager : NetworkSingleton<LevelManager>
	{
		// Token: 0x06004A79 RID: 19065 RVA: 0x00169298 File Offset: 0x00167498
		// Note: this type is marked as 'beforefieldinit'.
		static LevelManager()
		{
			Il2CppClassPointerStore<LevelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "LevelManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager>.NativeClassPtr);
			LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "TIERS_PER_RANK");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MIN");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MAX");
			LevelManager.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Rank>k__BackingField");
			LevelManager.NativeFieldInfoPtr_rankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "rankCount");
			LevelManager.NativeFieldInfoPtr__Tier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Tier>k__BackingField");
			LevelManager.NativeFieldInfoPtr__XP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<XP>k__BackingField");
			LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<TotalXP>k__BackingField");
			LevelManager.NativeFieldInfoPtr_onRankUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "onRankUp");
			LevelManager.NativeFieldInfoPtr_Unlockables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "Unlockables");
			LevelManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "loader");
			LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672526);
			LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672527);
			LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672528);
			LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672529);
			LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672530);
			LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672531);
			LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672532);
			LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672533);
			LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672534);
			LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672535);
			LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672536);
			LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672537);
			LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672538);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672539);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672540);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672541);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672542);
			LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672543);
			LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672544);
			LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672545);
			LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672546);
			LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672547);
			LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672548);
			LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672549);
			LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672550);
			LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672551);
			LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672552);
			LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672553);
			LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672554);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672555);
			LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672556);
			LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672557);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672558);
			LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672559);
			LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672560);
			LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672561);
			LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672562);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672563);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672564);
			LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672565);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672566);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672567);
			LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672568);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672569);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672570);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672571);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672572);
			LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672573);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672574);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672575);
			LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672576);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672577);
			LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672578);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672579);
			LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672580);
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x00169854 File Offset: 0x00167A54
		// (set) Token: 0x06004A7B RID: 19067 RVA: 0x00169890 File Offset: 0x00167A90
		public unsafe ERank Rank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x001698D0 File Offset: 0x00167AD0
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x0016990C File Offset: 0x00167B0C
		public unsafe int Tier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x0016994C File Offset: 0x00167B4C
		// (set) Token: 0x06004A7F RID: 19071 RVA: 0x00169988 File Offset: 0x00167B88
		public unsafe int XP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x001699C8 File Offset: 0x00167BC8
		// (set) Token: 0x06004A81 RID: 19073 RVA: 0x00169A04 File Offset: 0x00167C04
		public unsafe int TotalXP
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60914, RefRangeEnd = 60954, XrefRangeStart = 60914, XrefRangeEnd = 60954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x00169A44 File Offset: 0x00167C44
		public unsafe float XPToNextTier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164122, XrefRangeEnd = 164124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x00169A80 File Offset: 0x00167C80
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164124, XrefRangeEnd = 164126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x00169AB8 File Offset: 0x00167CB8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164126, XrefRangeEnd = 164128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00169AF0 File Offset: 0x00167CF0
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93787, RefRangeEnd = 93788, XrefRangeStart = 93787, XrefRangeEnd = 93788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004A86 RID: 19078 RVA: 0x00169B30 File Offset: 0x00167D30
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x00169B6C File Offset: 0x00167D6C
		// (set) Token: 0x06004A88 RID: 19080 RVA: 0x00169BAC File Offset: 0x00167DAC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x00169BF0 File Offset: 0x00167DF0
		// (set) Token: 0x06004A8A RID: 19082 RVA: 0x00169C30 File Offset: 0x00167E30
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004A8B RID: 19083 RVA: 0x00169C74 File Offset: 0x00167E74
		// (set) Token: 0x06004A8C RID: 19084 RVA: 0x00169CB0 File Offset: 0x00167EB0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00169CF0 File Offset: 0x00167EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164128, XrefRangeEnd = 164143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00169D2C File Offset: 0x00167F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164143, XrefRangeEnd = 164146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00169D68 File Offset: 0x00167F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164146, XrefRangeEnd = 164148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00169DB8 File Offset: 0x00167FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164148, XrefRangeEnd = 164154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00169DF4 File Offset: 0x00167FF4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 164174, RefRangeEnd = 164184, XrefRangeStart = 164154, XrefRangeEnd = 164174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00169E34 File Offset: 0x00168034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164184, XrefRangeEnd = 164204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXPLocal(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00169E74 File Offset: 0x00168074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164257, RefRangeEnd = 164260, XrefRangeStart = 164204, XrefRangeEnd = 164257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00169EF0 File Offset: 0x001680F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164260, XrefRangeEnd = 164280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTierNetworked(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00169F3C File Offset: 0x0016813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164280, XrefRangeEnd = 164282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00169F70 File Offset: 0x00168170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164282, XrefRangeEnd = 164286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00169FB4 File Offset: 0x001681B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164286, RefRangeEnd = 164291, XrefRangeStart = 164286, XrefRangeEnd = 164286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00169FF0 File Offset: 0x001681F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164325, RefRangeEnd = 164327, XrefRangeStart = 164291, XrefRangeEnd = 164325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnlockable(Unlockable unlockable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x0016A034 File Offset: 0x00168234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164346, RefRangeEnd = 164347, XrefRangeStart = 164327, XrefRangeEnd = 164346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalXPForRank(FullRank fullrank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fullrank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x0016A080 File Offset: 0x00168280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164367, RefRangeEnd = 164368, XrefRangeStart = 164347, XrefRangeEnd = 164367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank(int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x0016A0CC File Offset: 0x001682CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 164371, RefRangeEnd = 164377, XrefRangeStart = 164368, XrefRangeEnd = 164371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXPForTier(ERank rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x0016A118 File Offset: 0x00168318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164378, RefRangeEnd = 164379, XrefRangeStart = 164377, XrefRangeEnd = 164378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetOrderLimitMultiplier(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x0016A158 File Offset: 0x00168358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164379, RefRangeEnd = 164380, XrefRangeStart = 164379, XrefRangeEnd = 164379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRankOrderLimitMultiplier(ERank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x0016A198 File Offset: 0x00168398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164380, XrefRangeEnd = 164407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x0016A1D4 File Offset: 0x001683D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164407, XrefRangeEnd = 164442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x0016A210 File Offset: 0x00168410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164442, XrefRangeEnd = 164445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x0016A24C File Offset: 0x0016844C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x0016A288 File Offset: 0x00168488
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 164174, RefRangeEnd = 164184, XrefRangeStart = 164174, XrefRangeEnd = 164184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x0016A2C8 File Offset: 0x001684C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x0016A308 File Offset: 0x00168508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164445, XrefRangeEnd = 164459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x0016A36C File Offset: 0x0016856C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x0016A3AC File Offset: 0x001685AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164510, RefRangeEnd = 164511, XrefRangeStart = 164459, XrefRangeEnd = 164510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x0016A3EC File Offset: 0x001685EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164511, XrefRangeEnd = 164515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x0016A43C File Offset: 0x0016863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164515, XrefRangeEnd = 164540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x0016A4B8 File Offset: 0x001686B8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0016A534 File Offset: 0x00168734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164540, XrefRangeEnd = 164549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0016A584 File Offset: 0x00168784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164549, XrefRangeEnd = 164565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x0016A600 File Offset: 0x00168800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164565, XrefRangeEnd = 164574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0016A650 File Offset: 0x00168850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0016A69C File Offset: 0x0016889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164574, XrefRangeEnd = 164587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0016A6E8 File Offset: 0x001688E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164587, XrefRangeEnd = 164603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x0016A738 File Offset: 0x00168938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164603, XrefRangeEnd = 164617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00023EC3 File Offset: 0x000220C3
		public LevelManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x0016A774 File Offset: 0x00168974
		// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x00023ECC File Offset: 0x000220CC
		public unsafe static int TIERS_PER_RANK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&value));
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x0016A790 File Offset: 0x00168990
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x00023EDA File Offset: 0x000220DA
		public unsafe static int XP_PER_TIER_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x0016A7AC File Offset: 0x001689AC
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x00023EE8 File Offset: 0x000220E8
		public unsafe static int XP_PER_TIER_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x0016A7C8 File Offset: 0x001689C8
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x00023EF6 File Offset: 0x000220F6
		public unsafe ERank _Rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField)) = value;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x0016A7F0 File Offset: 0x001689F0
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x00023F11 File Offset: 0x00022111
		public unsafe int rankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount)) = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x0016A818 File Offset: 0x00168A18
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x00023F2C File Offset: 0x0002212C
		public unsafe int _Tier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x0016A840 File Offset: 0x00168A40
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00023F47 File Offset: 0x00022147
		public unsafe int _XP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField)) = value;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x0016A868 File Offset: 0x00168A68
		// (set) Token: 0x06004AC1 RID: 19137 RVA: 0x00023F62 File Offset: 0x00022162
		public unsafe int _TotalXP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField)) = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0016A890 File Offset: 0x00168A90
		// (set) Token: 0x06004AC3 RID: 19139 RVA: 0x00023F7D File Offset: 0x0002217D
		public unsafe Action<FullRank, FullRank> onRankUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FullRank, FullRank>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x0016A8C0 File Offset: 0x00168AC0
		// (set) Token: 0x06004AC5 RID: 19141 RVA: 0x00023F9C File Offset: 0x0002219C
		public unsafe Dictionary<FullRank, List<Unlockable>> Unlockables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FullRank, List<Unlockable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x0016A8F0 File Offset: 0x00168AF0
		// (set) Token: 0x06004AC7 RID: 19143 RVA: 0x00023FBB File Offset: 0x000221BB
		public unsafe RankLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x0016A920 File Offset: 0x00168B20
		// (set) Token: 0x06004AC9 RID: 19145 RVA: 0x00023FDA File Offset: 0x000221DA
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x0016A950 File Offset: 0x00168B50
		// (set) Token: 0x06004ACB RID: 19147 RVA: 0x00023FF9 File Offset: 0x000221F9
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x0016A980 File Offset: 0x00168B80
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x00024018 File Offset: 0x00022218
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x0016A9A8 File Offset: 0x00168BA8
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x00024033 File Offset: 0x00022233
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x0016A9D0 File Offset: 0x00168BD0
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x0002404E File Offset: 0x0002224E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeFieldInfoPtr_TIERS_PER_RANK;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MIN;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MAX;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeFieldInfoPtr_rankCount;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeFieldInfoPtr__Tier_k__BackingField;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeFieldInfoPtr__XP_k__BackingField;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeFieldInfoPtr__TotalXP_k__BackingField;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeFieldInfoPtr_onRankUp;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeFieldInfoPtr_Unlockables;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_ERank_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr_get_Tier_Public_get_Int32_0;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr_get_XP_Public_get_Int32_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003261 RID: 12897
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTier_Private_Void_0;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000988 RID: 2440
		[ObfuscatedName("ScheduleOne.Levelling.LevelManager+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Object
		{
			// Token: 0x0600CA5A RID: 51802 RVA: 0x0030F090 File Offset: 0x0030D290
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr);
				LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, "unlockable");
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672581);
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672582);
			}

			// Token: 0x0600CA5B RID: 51803 RVA: 0x0030F0F8 File Offset: 0x0030D2F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA5C RID: 51804 RVA: 0x0030F134 File Offset: 0x0030D334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164118, XrefRangeEnd = 164122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddUnlockable_b__0(Unlockable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA5D RID: 51805 RVA: 0x0006262F File Offset: 0x0006082F
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F0F RID: 16143
			// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x0030F184 File Offset: 0x0030D384
			// (set) Token: 0x0600CA5F RID: 51807 RVA: 0x00062638 File Offset: 0x00060838
			public unsafe Unlockable unlockable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Unlockable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088E0 RID: 35040
			private static readonly IntPtr NativeFieldInfoPtr_unlockable;

			// Token: 0x040088E1 RID: 35041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088E2 RID: 35042
			private static readonly IntPtr NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0;
		}
	}
}
