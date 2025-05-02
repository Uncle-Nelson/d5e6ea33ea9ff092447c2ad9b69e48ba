using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000513 RID: 1299
	public class RV : Property
	{
		// Token: 0x06007368 RID: 29544 RVA: 0x001F7E90 File Offset: 0x001F6090
		// Note: this type is marked as 'beforefieldinit'.
		static RV()
		{
			Il2CppClassPointerStore<RV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "RV");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV>.NativeClassPtr);
			RV.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "ModelContainer");
			RV.NativeFieldInfoPtr_FXContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "FXContainer");
			RV.NativeFieldInfoPtr_onSetExploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "onSetExploded");
			RV.NativeFieldInfoPtr___isExploded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "<_isExploded>k__BackingField");
			RV.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677795);
			RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677796);
			RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677797);
			RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677798);
			RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677799);
			RV.NativeMethodInfoPtr_Ransack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677800);
			RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677801);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677802);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677803);
			RV.NativeMethodInfoPtr_OnSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677804);
			RV.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677805);
			RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677806);
			RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677807);
			RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677808);
			RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677809);
			RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677810);
			RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677811);
			RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677812);
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06007369 RID: 29545 RVA: 0x001F80A0 File Offset: 0x001F62A0
		// (set) Token: 0x0600736A RID: 29546 RVA: 0x001F80DC File Offset: 0x001F62DC
		public unsafe bool _isExploded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x001F811C File Offset: 0x001F631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225968, XrefRangeEnd = 225984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x001F8158 File Offset: 0x001F6358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225984, XrefRangeEnd = 225985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x001F81A8 File Offset: 0x001F63A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225985, XrefRangeEnd = 226080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x001F81DC File Offset: 0x001F63DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226133, RefRangeEnd = 226134, XrefRangeStart = 226080, XrefRangeEnd = 226133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ransack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_Ransack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x001F8210 File Offset: 0x001F6410
		[CallerCount(0)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x001F8258 File Offset: 0x001F6458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226134, XrefRangeEnd = 226152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x001F829C File Offset: 0x001F649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226152, XrefRangeEnd = 226153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x001F82D0 File Offset: 0x001F64D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226153, XrefRangeEnd = 226159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_OnSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x001F8304 File Offset: 0x001F6504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226159, XrefRangeEnd = 226163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RV() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x001F8340 File Offset: 0x001F6540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226163, XrefRangeEnd = 226171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x001F837C File Offset: 0x001F657C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x001F83B8 File Offset: 0x001F65B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x001F83F4 File Offset: 0x001F65F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x001F8438 File Offset: 0x001F6638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x001F847C File Offset: 0x001F667C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226171, XrefRangeEnd = 226174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x001F84CC File Offset: 0x001F66CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00036E0B File Offset: 0x0003500B
		public RV(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x001F8508 File Offset: 0x001F6708
		// (set) Token: 0x0600737D RID: 29565 RVA: 0x00036E14 File Offset: 0x00035014
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x001F8538 File Offset: 0x001F6738
		// (set) Token: 0x0600737F RID: 29567 RVA: 0x00036E33 File Offset: 0x00035033
		public unsafe Transform FXContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x001F8568 File Offset: 0x001F6768
		// (set) Token: 0x06007381 RID: 29569 RVA: 0x00036E52 File Offset: 0x00035052
		public unsafe UnityEvent onSetExploded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06007382 RID: 29570 RVA: 0x001F8598 File Offset: 0x001F6798
		// (set) Token: 0x06007383 RID: 29571 RVA: 0x00036E71 File Offset: 0x00035071
		public unsafe bool __isExploded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x001F85C0 File Offset: 0x001F67C0
		// (set) Token: 0x06007385 RID: 29573 RVA: 0x00036E8C File Offset: 0x0003508C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06007386 RID: 29574 RVA: 0x001F85E8 File Offset: 0x001F67E8
		// (set) Token: 0x06007387 RID: 29575 RVA: 0x00036EA7 File Offset: 0x000350A7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004EC7 RID: 20167
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04004EC8 RID: 20168
		private static readonly IntPtr NativeFieldInfoPtr_FXContainer;

		// Token: 0x04004EC9 RID: 20169
		private static readonly IntPtr NativeFieldInfoPtr_onSetExploded;

		// Token: 0x04004ECA RID: 20170
		private static readonly IntPtr NativeFieldInfoPtr___isExploded_k__BackingField;

		// Token: 0x04004ECB RID: 20171
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004ECC RID: 20172
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004ECD RID: 20173
		private static readonly IntPtr NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0;

		// Token: 0x04004ECE RID: 20174
		private static readonly IntPtr NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0;

		// Token: 0x04004ECF RID: 20175
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004ED0 RID: 20176
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004ED1 RID: 20177
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004ED2 RID: 20178
		private static readonly IntPtr NativeMethodInfoPtr_Ransack_Public_Void_0;

		// Token: 0x04004ED3 RID: 20179
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04004ED4 RID: 20180
		private static readonly IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0;

		// Token: 0x04004ED5 RID: 20181
		private static readonly IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_0;

		// Token: 0x04004ED6 RID: 20182
		private static readonly IntPtr NativeMethodInfoPtr_OnSleep_Private_Void_0;

		// Token: 0x04004ED7 RID: 20183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004ED8 RID: 20184
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004ED9 RID: 20185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004EDA RID: 20186
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004EDB RID: 20187
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04004EDC RID: 20188
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04004EDD RID: 20189
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004EDE RID: 20190
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A8C RID: 2700
		[ObfuscatedName("ScheduleOne.Property.RV+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D25F RID: 53855 RVA: 0x00325570 File Offset: 0x00323770
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RV.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RV>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV.__c>.NativeClassPtr);
				RV.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9");
				RV.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_0");
				RV.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_1");
				RV.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_2");
				RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677814);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677815);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677816);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677817);
			}

			// Token: 0x0600D260 RID: 53856 RVA: 0x0032563C File Offset: 0x0032383C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D261 RID: 53857 RVA: 0x00325678 File Offset: 0x00323878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225962, XrefRangeEnd = 225963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D262 RID: 53858 RVA: 0x003256C8 File Offset: 0x003238C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225963, XrefRangeEnd = 225964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__9_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D263 RID: 53859 RVA: 0x00325718 File Offset: 0x00323918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225964, XrefRangeEnd = 225968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_2(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D264 RID: 53860 RVA: 0x000666CF File Offset: 0x000648CF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004146 RID: 16710
			// (get) Token: 0x0600D265 RID: 53861 RVA: 0x00325768 File Offset: 0x00323968
			// (set) Token: 0x0600D266 RID: 53862 RVA: 0x000666D8 File Offset: 0x000648D8
			public unsafe static RV.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004147 RID: 16711
			// (get) Token: 0x0600D267 RID: 53863 RVA: 0x00325790 File Offset: 0x00323990
			// (set) Token: 0x0600D268 RID: 53864 RVA: 0x000666EA File Offset: 0x000648EA
			public unsafe static Func<BuildableItem, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004148 RID: 16712
			// (get) Token: 0x0600D269 RID: 53865 RVA: 0x003257B8 File Offset: 0x003239B8
			// (set) Token: 0x0600D26A RID: 53866 RVA: 0x000666FC File Offset: 0x000648FC
			public unsafe static Func<BuildableItem, Pot> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004149 RID: 16713
			// (get) Token: 0x0600D26B RID: 53867 RVA: 0x003257E0 File Offset: 0x003239E0
			// (set) Token: 0x0600D26C RID: 53868 RVA: 0x0006670E File Offset: 0x0006490E
			public unsafe static Predicate<Additive> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DE0 RID: 36320
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DE1 RID: 36321
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008DE2 RID: 36322
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04008DE3 RID: 36323
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04008DE4 RID: 36324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DE5 RID: 36325
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DE6 RID: 36326
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DE7 RID: 36327
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0;
		}
	}
}
