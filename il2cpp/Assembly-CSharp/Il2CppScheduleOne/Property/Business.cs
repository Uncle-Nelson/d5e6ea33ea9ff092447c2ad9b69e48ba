using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050B RID: 1291
	public class Business : Property
	{
		// Token: 0x06007233 RID: 29235 RVA: 0x001F3818 File Offset: 0x001F1A18
		// Note: this type is marked as 'beforefieldinit'.
		static Business()
		{
			Il2CppClassPointerStore<Business>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Business");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business>.NativeClassPtr);
			Business.NativeFieldInfoPtr_Businesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "Businesses");
			Business.NativeFieldInfoPtr_UnownedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "UnownedBusinesses");
			Business.NativeFieldInfoPtr_OwnedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "OwnedBusinesses");
			Business.NativeFieldInfoPtr_LaunderCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderCapacity");
			Business.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderingOperations");
			Business.NativeFieldInfoPtr_onOperationStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationStarted");
			Business.NativeFieldInfoPtr_onOperationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationFinished");
			Business.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "loader");
			Business.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677614);
			Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677615);
			Business.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677616);
			Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677617);
			Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677618);
			Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677619);
			Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677620);
			Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677621);
			Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677622);
			Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677623);
			Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677624);
			Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677625);
			Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677626);
			Business.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677627);
			Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677628);
			Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677629);
			Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677630);
			Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677631);
			Business.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677632);
			Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677634);
			Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677635);
			Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677636);
			Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677637);
			Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677638);
			Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677639);
			Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677640);
			Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677641);
			Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677642);
			Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677643);
			Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677644);
			Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677645);
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06007234 RID: 29236 RVA: 0x001F3B7C File Offset: 0x001F1D7C
		public unsafe float currentLaunderTotal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 224043, RefRangeEnd = 224054, XrefRangeStart = 224025, XrefRangeEnd = 224043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x001F3BB8 File Offset: 0x001F1DB8
		public unsafe float appliedLaunderLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 224055, RefRangeEnd = 224056, XrefRangeStart = 224054, XrefRangeEnd = 224055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x001F3BF4 File Offset: 0x001F1DF4
		public new unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224056, XrefRangeEnd = 224058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x001F3C2C File Offset: 0x001F1E2C
		public new unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x001F3C6C File Offset: 0x001F1E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224058, XrefRangeEnd = 224059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x001F3CA8 File Offset: 0x001F1EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224059, XrefRangeEnd = 224094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x001F3CE4 File Offset: 0x001F1EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224094, XrefRangeEnd = 224109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x001F3D20 File Offset: 0x001F1F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224109, XrefRangeEnd = 224115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x001F3D70 File Offset: 0x001F1F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224115, XrefRangeEnd = 224124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x001F3DC0 File Offset: 0x001F1FC0
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x001F3DFC File Offset: 0x001F1FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224124, XrefRangeEnd = 224136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinsPass(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x001F3E48 File Offset: 0x001F2048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224136, XrefRangeEnd = 224160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsPassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsPassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x001F3E88 File Offset: 0x001F2088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224160, XrefRangeEnd = 224199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x001F3ECC File Offset: 0x001F20CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224199, XrefRangeEnd = 224223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(BusinessData businessData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(businessData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x001F3F2C File Offset: 0x001F212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224223, XrefRangeEnd = 224241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x001F3F68 File Offset: 0x001F2168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224262, RefRangeEnd = 224263, XrefRangeStart = 224241, XrefRangeEnd = 224262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x001F3FB4 File Offset: 0x001F21B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224298, RefRangeEnd = 224301, XrefRangeStart = 224263, XrefRangeEnd = 224298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x001F4014 File Offset: 0x001F2214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224352, RefRangeEnd = 224353, XrefRangeStart = 224301, XrefRangeEnd = 224352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteOperation(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x001F4058 File Offset: 0x001F2258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224353, XrefRangeEnd = 224369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Business() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x001F4094 File Offset: 0x001F2294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224369, XrefRangeEnd = 224390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x001F40D0 File Offset: 0x001F22D0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x001F410C File Offset: 0x001F230C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x001F4148 File Offset: 0x001F2348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224262, RefRangeEnd = 224263, XrefRangeStart = 224262, XrefRangeEnd = 224263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x001F4194 File Offset: 0x001F2394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224390, XrefRangeEnd = 224391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x001F41E0 File Offset: 0x001F23E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224391, XrefRangeEnd = 224396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x001F4244 File Offset: 0x001F2444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224396, XrefRangeEnd = 224408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x001F42A4 File Offset: 0x001F24A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224424, RefRangeEnd = 224426, XrefRangeStart = 224408, XrefRangeEnd = 224424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x001F4304 File Offset: 0x001F2504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224426, XrefRangeEnd = 224432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x001F4354 File Offset: 0x001F2554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224432, XrefRangeEnd = 224453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x001F43B4 File Offset: 0x001F25B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224453, XrefRangeEnd = 224458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x001F4404 File Offset: 0x001F2604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224478, RefRangeEnd = 224479, XrefRangeStart = 224458, XrefRangeEnd = 224478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x000365BD File Offset: 0x000347BD
		public Business(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06007254 RID: 29268 RVA: 0x001F4440 File Offset: 0x001F2640
		// (set) Token: 0x06007255 RID: 29269 RVA: 0x000365C6 File Offset: 0x000347C6
		public unsafe static List<Business> Businesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_Businesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_Businesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x001F4468 File Offset: 0x001F2668
		// (set) Token: 0x06007257 RID: 29271 RVA: 0x000365D8 File Offset: 0x000347D8
		public unsafe static List<Business> UnownedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_UnownedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_UnownedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06007258 RID: 29272 RVA: 0x001F4490 File Offset: 0x001F2690
		// (set) Token: 0x06007259 RID: 29273 RVA: 0x000365EA File Offset: 0x000347EA
		public unsafe static List<Business> OwnedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_OwnedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_OwnedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600725A RID: 29274 RVA: 0x001F44B8 File Offset: 0x001F26B8
		// (set) Token: 0x0600725B RID: 29275 RVA: 0x000365FC File Offset: 0x000347FC
		public unsafe float LaunderCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity)) = value;
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x001F44E0 File Offset: 0x001F26E0
		// (set) Token: 0x0600725D RID: 29277 RVA: 0x00036617 File Offset: 0x00034817
		public unsafe List<LaunderingOperation> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600725E RID: 29278 RVA: 0x001F4510 File Offset: 0x001F2710
		// (set) Token: 0x0600725F RID: 29279 RVA: 0x00036636 File Offset: 0x00034836
		public unsafe static Action<LaunderingOperation> onOperationStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x001F4538 File Offset: 0x001F2738
		// (set) Token: 0x06007261 RID: 29281 RVA: 0x00036648 File Offset: 0x00034848
		public unsafe static Action<LaunderingOperation> onOperationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x001F4560 File Offset: 0x001F2760
		// (set) Token: 0x06007263 RID: 29283 RVA: 0x0003665A File Offset: 0x0003485A
		public new unsafe BusinessLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06007264 RID: 29284 RVA: 0x001F4590 File Offset: 0x001F2790
		// (set) Token: 0x06007265 RID: 29285 RVA: 0x00036679 File Offset: 0x00034879
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06007266 RID: 29286 RVA: 0x001F45B8 File Offset: 0x001F27B8
		// (set) Token: 0x06007267 RID: 29287 RVA: 0x00036694 File Offset: 0x00034894
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004DEB RID: 19947
		private static readonly IntPtr NativeFieldInfoPtr_Businesses;

		// Token: 0x04004DEC RID: 19948
		private static readonly IntPtr NativeFieldInfoPtr_UnownedBusinesses;

		// Token: 0x04004DED RID: 19949
		private static readonly IntPtr NativeFieldInfoPtr_OwnedBusinesses;

		// Token: 0x04004DEE RID: 19950
		private static readonly IntPtr NativeFieldInfoPtr_LaunderCapacity;

		// Token: 0x04004DEF RID: 19951
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04004DF0 RID: 19952
		private static readonly IntPtr NativeFieldInfoPtr_onOperationStarted;

		// Token: 0x04004DF1 RID: 19953
		private static readonly IntPtr NativeFieldInfoPtr_onOperationFinished;

		// Token: 0x04004DF2 RID: 19954
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004DF3 RID: 19955
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004DF4 RID: 19956
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004DF5 RID: 19957
		private static readonly IntPtr NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0;

		// Token: 0x04004DF6 RID: 19958
		private static readonly IntPtr NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0;

		// Token: 0x04004DF7 RID: 19959
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004DF8 RID: 19960
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004DF9 RID: 19961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004DFA RID: 19962
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04004DFB RID: 19963
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04004DFC RID: 19964
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0;

		// Token: 0x04004DFD RID: 19965
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004DFE RID: 19966
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04004DFF RID: 19967
		private static readonly IntPtr NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004E00 RID: 19968
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x04004E01 RID: 19969
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04004E02 RID: 19970
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0;

		// Token: 0x04004E03 RID: 19971
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1;

		// Token: 0x04004E04 RID: 19972
		private static readonly IntPtr NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0;

		// Token: 0x04004E05 RID: 19973
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E06 RID: 19974
		private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0;

		// Token: 0x04004E07 RID: 19975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E08 RID: 19976
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0;

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A83 RID: 2691
		[ObfuscatedName("ScheduleOne.Property.Business+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D211 RID: 53777 RVA: 0x00324624 File Offset: 0x00322824
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Business.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Business>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business.__c>.NativeClassPtr);
				Business.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9");
				Business.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9__8_0");
				Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677647);
				Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677648);
			}

			// Token: 0x0600D212 RID: 53778 RVA: 0x003246A0 File Offset: 0x003228A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D213 RID: 53779 RVA: 0x003246DC File Offset: 0x003228DC
			[CallerCount(0)]
			public unsafe float _get_currentLaunderTotal_b__8_0(LaunderingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D214 RID: 53780 RVA: 0x000664F7 File Offset: 0x000646F7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004136 RID: 16694
			// (get) Token: 0x0600D215 RID: 53781 RVA: 0x0032472C File Offset: 0x0032292C
			// (set) Token: 0x0600D216 RID: 53782 RVA: 0x00066500 File Offset: 0x00064700
			public unsafe static Business.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004137 RID: 16695
			// (get) Token: 0x0600D217 RID: 53783 RVA: 0x00324754 File Offset: 0x00322954
			// (set) Token: 0x0600D218 RID: 53784 RVA: 0x00066512 File Offset: 0x00064712
			public unsafe static Func<LaunderingOperation, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LaunderingOperation, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DB5 RID: 36277
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DB6 RID: 36278
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008DB7 RID: 36279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB8 RID: 36280
			private static readonly IntPtr NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0;
		}
	}
}
