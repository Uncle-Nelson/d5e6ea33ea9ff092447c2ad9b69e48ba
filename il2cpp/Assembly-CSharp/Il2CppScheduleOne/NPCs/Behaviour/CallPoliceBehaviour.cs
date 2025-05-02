using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000343 RID: 835
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06003DFC RID: 15868 RVA: 0x0013A958 File Offset: 0x00138B58
		// Note: this type is marked as 'beforefieldinit'.
		static CallPoliceBehaviour()
		{
			Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CallPoliceBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr);
			CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CALL_POLICE_TIME");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhoneCallPopup");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhonePrefab");
			CallPoliceBehaviour.NativeFieldInfoPtr_CallSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CallSound");
			CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "currentCallTime");
			CallPoliceBehaviour.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "Target");
			CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "ReportedCrime");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670548);
			CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670549);
			CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670550);
			CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670551);
			CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670552);
			CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670553);
			CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670554);
			CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670555);
			CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670556);
			CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670557);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670558);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670559);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670560);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670561);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670562);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670563);
			CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670564);
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x0013AB90 File Offset: 0x00138D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145672, XrefRangeEnd = 145693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0013ABCC File Offset: 0x00138DCC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkObject player, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0013AC20 File Offset: 0x00138E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145693, XrefRangeEnd = 145701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x0013AC5C File Offset: 0x00138E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145701, XrefRangeEnd = 145709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x0013AC98 File Offset: 0x00138E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145709, XrefRangeEnd = 145717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x0013ACD4 File Offset: 0x00138ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145717, XrefRangeEnd = 145742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0013AD10 File Offset: 0x00138F10
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x0013AD44 File Offset: 0x00138F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145742, XrefRangeEnd = 145763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x0013AD78 File Offset: 0x00138F78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145767, RefRangeEnd = 145770, XrefRangeStart = 145763, XrefRangeEnd = 145767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x0013ADB4 File Offset: 0x00138FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145770, XrefRangeEnd = 145771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallPoliceBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x0013ADF0 File Offset: 0x00138FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145771, XrefRangeEnd = 145779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x0013AE2C File Offset: 0x0013902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145779, XrefRangeEnd = 145780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x0013AE68 File Offset: 0x00139068
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0013AEA4 File Offset: 0x001390A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145780, XrefRangeEnd = 145798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x0013AED8 File Offset: 0x001390D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145816, RefRangeEnd = 145819, XrefRangeStart = 145798, XrefRangeEnd = 145816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0013AF0C File Offset: 0x0013910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145819, XrefRangeEnd = 145822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x0013AF5C File Offset: 0x0013915C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145822, XrefRangeEnd = 145823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0001F344 File Offset: 0x0001D544
		public CallPoliceBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x0013AF98 File Offset: 0x00139198
		// (set) Token: 0x06003E10 RID: 15888 RVA: 0x0001F34D File Offset: 0x0001D54D
		public unsafe static float CALL_POLICE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x0013AFB4 File Offset: 0x001391B4
		// (set) Token: 0x06003E12 RID: 15890 RVA: 0x0001F35B File Offset: 0x0001D55B
		public unsafe WorldspacePopup PhoneCallPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x0013AFE4 File Offset: 0x001391E4
		// (set) Token: 0x06003E14 RID: 15892 RVA: 0x0001F37A File Offset: 0x0001D57A
		public unsafe AvatarEquippable PhonePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x0013B014 File Offset: 0x00139214
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x0001F399 File Offset: 0x0001D599
		public unsafe AudioSourceController CallSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x0013B044 File Offset: 0x00139244
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		public unsafe float currentCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003E19 RID: 15897 RVA: 0x0013B06C File Offset: 0x0013926C
		// (set) Token: 0x06003E1A RID: 15898 RVA: 0x0001F3D3 File Offset: 0x0001D5D3
		public unsafe Player Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x0013B09C File Offset: 0x0013929C
		// (set) Token: 0x06003E1C RID: 15900 RVA: 0x0001F3F2 File Offset: 0x0001D5F2
		public unsafe Crime ReportedCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Crime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x0013B0CC File Offset: 0x001392CC
		// (set) Token: 0x06003E1E RID: 15902 RVA: 0x0001F411 File Offset: 0x0001D611
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x0013B0F4 File Offset: 0x001392F4
		// (set) Token: 0x06003E20 RID: 15904 RVA: 0x0001F42C File Offset: 0x0001D62C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeFieldInfoPtr_CALL_POLICE_TIME;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeFieldInfoPtr_PhoneCallPopup;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeFieldInfoPtr_PhonePrefab;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeFieldInfoPtr_CallSound;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeFieldInfoPtr_currentCallTime;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeFieldInfoPtr_ReportedCrime;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCall_Private_Void_0;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
