using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D6 RID: 982
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x06004BA7 RID: 19367 RVA: 0x0016D3F4 File Offset: 0x0016B5F4
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewManager()
		{
			Il2CppClassPointerStore<CurfewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr);
			CurfewManager.NativeFieldInfoPtr_WARNING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "WARNING_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_START_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_END_TIME");
			CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsEnabled>k__BackingField");
			CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsCurrentlyActive>k__BackingField");
			CurfewManager.NativeFieldInfoPtr_VMSBoards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "VMSBoards");
			CurfewManager.NativeFieldInfoPtr_CurfewWarningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewWarningSound");
			CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewAlarmSound");
			CurfewManager.NativeFieldInfoPtr_onCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewEnabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewDisabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewHint");
			CurfewManager.NativeFieldInfoPtr_onCurfewWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewWarning");
			CurfewManager.NativeFieldInfoPtr_warningPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "warningPlayed");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672662);
			CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672663);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672664);
			CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672665);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672666);
			CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672667);
			CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672668);
			CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672669);
			CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672670);
			CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672671);
			CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672672);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672673);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672674);
			CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672675);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672676);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672677);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672678);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672679);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672680);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672681);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672682);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672683);
			CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672684);
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x0016D71C File Offset: 0x0016B91C
		// (set) Token: 0x06004BA9 RID: 19369 RVA: 0x0016D758 File Offset: 0x0016B958
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x0016D798 File Offset: 0x0016B998
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x0016D7D4 File Offset: 0x0016B9D4
		public unsafe bool IsCurrentlyActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x0016D814 File Offset: 0x0016BA14
		public unsafe bool IsCurrentlyActiveWithTolerance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165035, RefRangeEnd = 165036, XrefRangeStart = 165034, XrefRangeEnd = 165035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0016D850 File Offset: 0x0016BA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165036, XrefRangeEnd = 165058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x0016D88C File Offset: 0x0016BA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165058, XrefRangeEnd = 165060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x0016D8DC File Offset: 0x0016BADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165086, RefRangeEnd = 165088, XrefRangeStart = 165060, XrefRangeEnd = 165086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x0016D920 File Offset: 0x0016BB20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165106, RefRangeEnd = 165108, XrefRangeStart = 165088, XrefRangeEnd = 165106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x0016D954 File Offset: 0x0016BB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165108, XrefRangeEnd = 165114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x0016D988 File Offset: 0x0016BB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165114, XrefRangeEnd = 165117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0016D9C4 File Offset: 0x0016BBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165117, XrefRangeEnd = 165139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x0016DA00 File Offset: 0x0016BC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165139, XrefRangeEnd = 165142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x0016DA3C File Offset: 0x0016BC3C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x0016DA78 File Offset: 0x0016BC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165142, XrefRangeEnd = 165160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0016DABC File Offset: 0x0016BCBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165164, RefRangeEnd = 165166, XrefRangeStart = 165160, XrefRangeEnd = 165164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0016DB00 File Offset: 0x0016BD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165166, XrefRangeEnd = 165168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x0016DB50 File Offset: 0x0016BD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165168, XrefRangeEnd = 165186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x0016DB94 File Offset: 0x0016BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165186, XrefRangeEnd = 165189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x0016DBE4 File Offset: 0x0016BDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165106, RefRangeEnd = 165108, XrefRangeStart = 165106, XrefRangeEnd = 165108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x0016DC18 File Offset: 0x0016BE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165189, XrefRangeEnd = 165193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x0016DC4C File Offset: 0x0016BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165193, XrefRangeEnd = 165198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x0016DC9C File Offset: 0x0016BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165198, XrefRangeEnd = 165201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x0002462E File Offset: 0x0002282E
		public CurfewManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x0016DCD8 File Offset: 0x0016BED8
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x00024637 File Offset: 0x00022837
		public unsafe static int WARNING_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x0016DCF4 File Offset: 0x0016BEF4
		// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x00024645 File Offset: 0x00022845
		public unsafe static int CURFEW_START_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x0016DD10 File Offset: 0x0016BF10
		// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x00024653 File Offset: 0x00022853
		public unsafe static int CURFEW_END_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x0016DD2C File Offset: 0x0016BF2C
		// (set) Token: 0x06004BC7 RID: 19399 RVA: 0x00024661 File Offset: 0x00022861
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x0016DD54 File Offset: 0x0016BF54
		// (set) Token: 0x06004BC9 RID: 19401 RVA: 0x0002467C File Offset: 0x0002287C
		public unsafe bool _IsCurrentlyActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x0016DD7C File Offset: 0x0016BF7C
		// (set) Token: 0x06004BCB RID: 19403 RVA: 0x00024697 File Offset: 0x00022897
		public unsafe Il2CppReferenceArray<VMSBoard> VMSBoards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VMSBoard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x0016DDAC File Offset: 0x0016BFAC
		// (set) Token: 0x06004BCD RID: 19405 RVA: 0x000246B6 File Offset: 0x000228B6
		public unsafe AudioSourceController CurfewWarningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x0016DDDC File Offset: 0x0016BFDC
		// (set) Token: 0x06004BCF RID: 19407 RVA: 0x000246D5 File Offset: 0x000228D5
		public unsafe AudioSourceController CurfewAlarmSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x0016DE0C File Offset: 0x0016C00C
		// (set) Token: 0x06004BD1 RID: 19409 RVA: 0x000246F4 File Offset: 0x000228F4
		public unsafe UnityEvent onCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x0016DE3C File Offset: 0x0016C03C
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x00024713 File Offset: 0x00022913
		public unsafe UnityEvent onCurfewDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x0016DE6C File Offset: 0x0016C06C
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x00024732 File Offset: 0x00022932
		public unsafe UnityEvent onCurfewHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0016DE9C File Offset: 0x0016C09C
		// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x00024751 File Offset: 0x00022951
		public unsafe UnityEvent onCurfewWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0016DECC File Offset: 0x0016C0CC
		// (set) Token: 0x06004BD9 RID: 19417 RVA: 0x00024770 File Offset: 0x00022970
		public unsafe bool warningPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed)) = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0016DEF4 File Offset: 0x0016C0F4
		// (set) Token: 0x06004BDB RID: 19419 RVA: 0x0002478B File Offset: 0x0002298B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0016DF1C File Offset: 0x0016C11C
		// (set) Token: 0x06004BDD RID: 19421 RVA: 0x000247A6 File Offset: 0x000229A6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeFieldInfoPtr_WARNING_TIME;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_START_TIME;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_END_TIME;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeFieldInfoPtr_VMSBoards;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeFieldInfoPtr_CurfewWarningSound;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeFieldInfoPtr_CurfewAlarmSound;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewEnabled;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewDisabled;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewHint;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewWarning;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeFieldInfoPtr_warningPlayed;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
