using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000358 RID: 856
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x06004199 RID: 16793 RVA: 0x00148B88 File Offset: 0x00146D88
		// Note: this type is marked as 'beforefieldinit'.
		static FleeBehaviour()
		{
			Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FleeBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr);
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MIN");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MAX");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_SPEED");
			FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<EntityToFlee>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeMode>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeOrigin>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "currentFleeTarget");
			FleeBehaviour.NativeFieldInfoPtr_nextVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "nextVO");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671275);
			FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671276);
			FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671277);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671278);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671279);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671280);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671281);
			FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671282);
			FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671283);
			FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671284);
			FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671285);
			FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671286);
			FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671287);
			FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671288);
			FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671289);
			FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671290);
			FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671291);
			FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671292);
			FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671293);
			FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671294);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671295);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671296);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671297);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671298);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671299);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671300);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671301);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671302);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671303);
			FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671304);
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x00148ED8 File Offset: 0x001470D8
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x00148F18 File Offset: 0x00147118
		public unsafe NetworkObject EntityToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115213, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x00148F5C File Offset: 0x0014715C
		public unsafe Vector3 PointToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00148F98 File Offset: 0x00147198
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00148FD4 File Offset: 0x001471D4
		public unsafe FleeBehaviour.EFleeMode FleeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x00149014 File Offset: 0x00147214
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x00149050 File Offset: 0x00147250
		public unsafe Vector3 FleeOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00149090 File Offset: 0x00147290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151582, XrefRangeEnd = 151603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntityToFlee(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x001490D4 File Offset: 0x001472D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151603, XrefRangeEnd = 151625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointToFlee(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x00149114 File Offset: 0x00147314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151625, XrefRangeEnd = 151631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00149150 File Offset: 0x00147350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151631, XrefRangeEnd = 151633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x0014918C File Offset: 0x0014738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151633, XrefRangeEnd = 151640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001491C8 File Offset: 0x001473C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151640, XrefRangeEnd = 151642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00149204 File Offset: 0x00147404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151657, RefRangeEnd = 151659, XrefRangeStart = 151642, XrefRangeEnd = 151657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFlee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00149238 File Offset: 0x00147438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151659, XrefRangeEnd = 151667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00149274 File Offset: 0x00147474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151667, XrefRangeEnd = 151674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x001492B0 File Offset: 0x001474B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151681, RefRangeEnd = 151683, XrefRangeStart = 151674, XrefRangeEnd = 151681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x001492E4 File Offset: 0x001474E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151686, RefRangeEnd = 151687, XrefRangeStart = 151683, XrefRangeEnd = 151686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00149318 File Offset: 0x00147518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151738, RefRangeEnd = 151739, XrefRangeStart = 151687, XrefRangeEnd = 151738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFleePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x00149354 File Offset: 0x00147554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151739, XrefRangeEnd = 151744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FleeBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x00149390 File Offset: 0x00147590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151744, XrefRangeEnd = 151758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x001493CC File Offset: 0x001475CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00149408 File Offset: 0x00147608
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00149444 File Offset: 0x00147644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151758, XrefRangeEnd = 151777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x00149488 File Offset: 0x00147688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151777, XrefRangeEnd = 151778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x001494CC File Offset: 0x001476CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151778, XrefRangeEnd = 151782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0014951C File Offset: 0x0014771C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151782, XrefRangeEnd = 151803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0014955C File Offset: 0x0014775C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x0014959C File Offset: 0x0014779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151803, XrefRangeEnd = 151808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x001495EC File Offset: 0x001477EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000204A1 File Offset: 0x0001E6A1
		public FleeBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x00149628 File Offset: 0x00147828
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x000204AA File Offset: 0x0001E6AA
		public unsafe static float FLEE_DIST_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&value));
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x00149644 File Offset: 0x00147844
		// (set) Token: 0x060041BC RID: 16828 RVA: 0x000204B8 File Offset: 0x0001E6B8
		public unsafe static float FLEE_DIST_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&value));
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x00149660 File Offset: 0x00147860
		// (set) Token: 0x060041BE RID: 16830 RVA: 0x000204C6 File Offset: 0x0001E6C6
		public unsafe static float FLEE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060041BF RID: 16831 RVA: 0x0014967C File Offset: 0x0014787C
		// (set) Token: 0x060041C0 RID: 16832 RVA: 0x000204D4 File Offset: 0x0001E6D4
		public unsafe NetworkObject _EntityToFlee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x001496AC File Offset: 0x001478AC
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x000204F3 File Offset: 0x0001E6F3
		public unsafe FleeBehaviour.EFleeMode _FleeMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x001496D4 File Offset: 0x001478D4
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x0002050E File Offset: 0x0001E70E
		public unsafe Vector3 _FleeOrigin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField)) = value;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x001496FC File Offset: 0x001478FC
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x00020529 File Offset: 0x0001E729
		public unsafe Vector3 currentFleeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget)) = value;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x00149724 File Offset: 0x00147924
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x00020544 File Offset: 0x0001E744
		public unsafe float nextVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO)) = value;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x0014974C File Offset: 0x0014794C
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x0002055F File Offset: 0x0001E75F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x00149774 File Offset: 0x00147974
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x0002057A File Offset: 0x0001E77A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MIN;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MAX;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_SPEED;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeFieldInfoPtr__EntityToFlee_k__BackingField;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeFieldInfoPtr__FleeMode_k__BackingField;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeFieldInfoPtr__FleeOrigin_k__BackingField;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeFieldInfoPtr_currentFleeTarget;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeFieldInfoPtr_nextVO;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_StartFlee_Private_Void_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_Flee_Private_Void_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200095D RID: 2397
		[OriginalName("Assembly-CSharp.dll", "", "EFleeMode")]
		public enum EFleeMode
		{
			// Token: 0x04008809 RID: 34825
			Entity,
			// Token: 0x0400880A RID: 34826
			Point
		}
	}
}
