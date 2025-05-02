using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D8 RID: 984
	public class LawController : Singleton<LawController>
	{
		// Token: 0x06004BEE RID: 19438 RVA: 0x0016E1F0 File Offset: 0x0016C3F0
		// Note: this type is marked as 'beforefieldinit'.
		static LawController()
		{
			Il2CppClassPointerStore<LawController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawController>.NativeClassPtr);
			LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "DAILY_INTENSITY_DRAIN");
			LawController.NativeFieldInfoPtr_LE_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "LE_Intensity");
			LawController.NativeFieldInfoPtr_internalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "internalLawIntensity");
			LawController.NativeFieldInfoPtr_MondaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "MondaySettings");
			LawController.NativeFieldInfoPtr_TuesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "TuesdaySettings");
			LawController.NativeFieldInfoPtr_WednesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "WednesdaySettings");
			LawController.NativeFieldInfoPtr_ThursdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "ThursdaySettings");
			LawController.NativeFieldInfoPtr_FridaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "FridaySettings");
			LawController.NativeFieldInfoPtr_SaturdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SaturdaySettings");
			LawController.NativeFieldInfoPtr_SundaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SundaySettings");
			LawController.NativeFieldInfoPtr_IntensityIncreasePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "IntensityIncreasePerDay");
			LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverrideSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverriddenSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			LawController.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "loader");
			LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LawController.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<HasChanged>k__BackingField");
			LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672689);
			LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672690);
			LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672691);
			LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672692);
			LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672693);
			LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672694);
			LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672695);
			LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672696);
			LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672697);
			LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672698);
			LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672699);
			LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672700);
			LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672701);
			LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672702);
			LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672703);
			LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672704);
			LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672705);
			LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672706);
			LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672707);
			LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672708);
			LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672709);
			LawController.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672710);
			LawController.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672711);
			LawController.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672712);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672713);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672714);
			LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672715);
			LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672716);
			LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672717);
			LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672718);
			LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672719);
			LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672720);
			LawController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672721);
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x0016E61C File Offset: 0x0016C81C
		// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x0016E658 File Offset: 0x0016C858
		public unsafe bool OverrideSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0016E698 File Offset: 0x0016C898
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x0016E6D8 File Offset: 0x0016C8D8
		public unsafe LawActivitySettings OverriddenSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22968, RefRangeEnd = 22969, XrefRangeStart = 22968, XrefRangeEnd = 22969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0016E71C File Offset: 0x0016C91C
		// (set) Token: 0x06004BF4 RID: 19444 RVA: 0x0016E75C File Offset: 0x0016C95C
		public unsafe LawActivitySettings CurrentSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45803, RefRangeEnd = 45804, XrefRangeStart = 45803, XrefRangeEnd = 45804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165250, XrefRangeEnd = 165251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0016E7A0 File Offset: 0x0016C9A0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165251, XrefRangeEnd = 165253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x0016E7D8 File Offset: 0x0016C9D8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165253, XrefRangeEnd = 165255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x0016E810 File Offset: 0x0016CA10
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x0016E850 File Offset: 0x0016CA50
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x0016E88C File Offset: 0x0016CA8C
		// (set) Token: 0x06004BFA RID: 19450 RVA: 0x0016E8CC File Offset: 0x0016CACC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95750, RefRangeEnd = 95751, XrefRangeStart = 95750, XrefRangeEnd = 95751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x0016E910 File Offset: 0x0016CB10
		// (set) Token: 0x06004BFC RID: 19452 RVA: 0x0016E950 File Offset: 0x0016CB50
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31093, RefRangeEnd = 31100, XrefRangeStart = 31093, XrefRangeEnd = 31100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165255, XrefRangeEnd = 165256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x0016E994 File Offset: 0x0016CB94
		// (set) Token: 0x06004BFE RID: 19454 RVA: 0x0016E9D0 File Offset: 0x0016CBD0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x0016EA10 File Offset: 0x0016CC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165256, XrefRangeEnd = 165259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x0016EA4C File Offset: 0x0016CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165259, XrefRangeEnd = 165265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x0016EA88 File Offset: 0x0016CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165265, XrefRangeEnd = 165327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0016EAC4 File Offset: 0x0016CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165327, XrefRangeEnd = 165381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0016EB00 File Offset: 0x0016CD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165381, XrefRangeEnd = 165390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x0016EB34 File Offset: 0x0016CD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165390, XrefRangeEnd = 165395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x0016EB68 File Offset: 0x0016CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0016EB9C File Offset: 0x0016CD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165395, XrefRangeEnd = 165399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x0016EBD0 File Offset: 0x0016CDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165400, RefRangeEnd = 165402, XrefRangeStart = 165399, XrefRangeEnd = 165400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x0016EC10 File Offset: 0x0016CE10
		[CallerCount(0)]
		public unsafe LawActivitySettings GetSettings(EDay day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x0016EC5C File Offset: 0x0016CE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165402, XrefRangeEnd = 165403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSetings(LawActivitySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x0016ECA0 File Offset: 0x0016CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165403, XrefRangeEnd = 165404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x0016ECD4 File Offset: 0x0016CED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165404, XrefRangeEnd = 165407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternalIntensity(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0016ED14 File Offset: 0x0016CF14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165410, RefRangeEnd = 165411, XrefRangeStart = 165407, XrefRangeEnd = 165410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternalIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0016ED54 File Offset: 0x0016CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165411, XrefRangeEnd = 165416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0016ED98 File Offset: 0x0016CF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165419, RefRangeEnd = 165420, XrefRangeStart = 165416, XrefRangeEnd = 165419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(LawData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x0016EDDC File Offset: 0x0016CFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165420, XrefRangeEnd = 165440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00024865 File Offset: 0x00022A65
		public LawController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0016EE18 File Offset: 0x0016D018
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x0002486E File Offset: 0x00022A6E
		public unsafe static float DAILY_INTENSITY_DRAIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&value));
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0016EE34 File Offset: 0x0016D034
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x0002487C File Offset: 0x00022A7C
		public unsafe int LE_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity)) = value;
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0016EE5C File Offset: 0x0016D05C
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x00024897 File Offset: 0x00022A97
		public unsafe float internalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity)) = value;
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0016EE84 File Offset: 0x0016D084
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x000248B2 File Offset: 0x00022AB2
		public unsafe LawActivitySettings MondaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0016EEB4 File Offset: 0x0016D0B4
		// (set) Token: 0x06004C1A RID: 19482 RVA: 0x000248D1 File Offset: 0x00022AD1
		public unsafe LawActivitySettings TuesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0016EEE4 File Offset: 0x0016D0E4
		// (set) Token: 0x06004C1C RID: 19484 RVA: 0x000248F0 File Offset: 0x00022AF0
		public unsafe LawActivitySettings WednesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x0016EF14 File Offset: 0x0016D114
		// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0002490F File Offset: 0x00022B0F
		public unsafe LawActivitySettings ThursdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x0016EF44 File Offset: 0x0016D144
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x0002492E File Offset: 0x00022B2E
		public unsafe LawActivitySettings FridaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0016EF74 File Offset: 0x0016D174
		// (set) Token: 0x06004C22 RID: 19490 RVA: 0x0002494D File Offset: 0x00022B4D
		public unsafe LawActivitySettings SaturdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x0016EFA4 File Offset: 0x0016D1A4
		// (set) Token: 0x06004C24 RID: 19492 RVA: 0x0002496C File Offset: 0x00022B6C
		public unsafe LawActivitySettings SundaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x0016EFD4 File Offset: 0x0016D1D4
		// (set) Token: 0x06004C26 RID: 19494 RVA: 0x0002498B File Offset: 0x00022B8B
		public unsafe float IntensityIncreasePerDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay)) = value;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x0016EFFC File Offset: 0x0016D1FC
		// (set) Token: 0x06004C28 RID: 19496 RVA: 0x000249A6 File Offset: 0x00022BA6
		public unsafe bool _OverrideSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004C29 RID: 19497 RVA: 0x0016F024 File Offset: 0x0016D224
		// (set) Token: 0x06004C2A RID: 19498 RVA: 0x000249C1 File Offset: 0x00022BC1
		public unsafe LawActivitySettings _OverriddenSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x0016F054 File Offset: 0x0016D254
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x000249E0 File Offset: 0x00022BE0
		public unsafe LawActivitySettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x0016F084 File Offset: 0x0016D284
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x000249FF File Offset: 0x00022BFF
		public unsafe LawLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0016F0B4 File Offset: 0x0016D2B4
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x00024A1E File Offset: 0x00022C1E
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x0016F0E4 File Offset: 0x0016D2E4
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x00024A3D File Offset: 0x00022C3D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x0016F114 File Offset: 0x0016D314
		// (set) Token: 0x06004C34 RID: 19508 RVA: 0x00024A5C File Offset: 0x00022C5C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x0400332B RID: 13099
		private static readonly IntPtr NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN;

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeFieldInfoPtr_LE_Intensity;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeFieldInfoPtr_internalLawIntensity;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeFieldInfoPtr_MondaySettings;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeFieldInfoPtr_TuesdaySettings;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeFieldInfoPtr_WednesdaySettings;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeFieldInfoPtr_ThursdaySettings;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeFieldInfoPtr_FridaySettings;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeFieldInfoPtr_SaturdaySettings;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeFieldInfoPtr_SundaySettings;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeFieldInfoPtr_IntensityIncreasePerDay;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeFieldInfoPtr__OverrideSettings_k__BackingField;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenSettings_k__BackingField;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_LawData_0;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
