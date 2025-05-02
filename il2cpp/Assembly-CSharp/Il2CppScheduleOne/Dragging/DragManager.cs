using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x0200041F RID: 1055
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x06005CC2 RID: 23746 RVA: 0x001ACCDC File Offset: 0x001AAEDC
		// Note: this type is marked as 'beforefieldinit'.
		static DragManager()
		{
			Il2CppClassPointerStore<DragManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "DragManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragManager>.NativeClassPtr);
			DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DRAGGABLE_OFFSET");
			DragManager.NativeFieldInfoPtr_ThrowSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowSound");
			DragManager.NativeFieldInfoPtr_DragForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DragForce");
			DragManager.NativeFieldInfoPtr_DampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DampingFactor");
			DragManager.NativeFieldInfoPtr_TorqueForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueForce");
			DragManager.NativeFieldInfoPtr_TorqueDampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueDampingFactor");
			DragManager.NativeFieldInfoPtr_ThrowForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowForce");
			DragManager.NativeFieldInfoPtr_MassInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "MassInfluence");
			DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "<CurrentDraggable>k__BackingField");
			DragManager.NativeFieldInfoPtr_AllDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "AllDraggables");
			DragManager.NativeFieldInfoPtr_lastThrownDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastThrownDraggable");
			DragManager.NativeFieldInfoPtr_lastHeldDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastHeldDraggable");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675116);
			DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675117);
			DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675118);
			DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675119);
			DragManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675120);
			DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675121);
			DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675122);
			DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675123);
			DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675124);
			DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675125);
			DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675126);
			DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675127);
			DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675128);
			DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675129);
			DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675130);
			DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675131);
			DragManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675132);
			DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675133);
			DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675134);
			DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675135);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675136);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675137);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675138);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675139);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675140);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675141);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675142);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675143);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675144);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675145);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675146);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675147);
			DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675148);
			DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675149);
			DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675150);
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x001AD0E0 File Offset: 0x001AB2E0
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x001AD120 File Offset: 0x001AB320
		public unsafe Draggable CurrentDraggable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x001AD164 File Offset: 0x001AB364
		public unsafe bool IsDragging
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 195271, RefRangeEnd = 195274, XrefRangeStart = 195267, XrefRangeEnd = 195271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x001AD1A0 File Offset: 0x001AB3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195274, XrefRangeEnd = 195302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x001AD1F0 File Offset: 0x001AB3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195302, XrefRangeEnd = 195382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x001AD224 File Offset: 0x001AB424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195382, XrefRangeEnd = 195396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x001AD258 File Offset: 0x001AB458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195424, RefRangeEnd = 195426, XrefRangeStart = 195396, XrefRangeEnd = 195424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x001AD294 File Offset: 0x001AB494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195432, RefRangeEnd = 195433, XrefRangeStart = 195426, XrefRangeEnd = 195432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDraggable(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x001AD2D8 File Offset: 0x001AB4D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195439, RefRangeEnd = 195440, XrefRangeStart = 195433, XrefRangeEnd = 195439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x001AD31C File Offset: 0x001AB51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195457, RefRangeEnd = 195458, XrefRangeStart = 195440, XrefRangeEnd = 195457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x001AD360 File Offset: 0x001AB560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195472, RefRangeEnd = 195474, XrefRangeStart = 195458, XrefRangeEnd = 195472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x001AD3C4 File Offset: 0x001AB5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195474, XrefRangeEnd = 195488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x001AD428 File Offset: 0x001AB628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195506, RefRangeEnd = 195508, XrefRangeStart = 195488, XrefRangeEnd = 195506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x001AD468 File Offset: 0x001AB668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195508, XrefRangeEnd = 195511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x001AD4D4 File Offset: 0x001AB6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195511, XrefRangeEnd = 195512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x001AD554 File Offset: 0x001AB754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195523, RefRangeEnd = 195525, XrefRangeStart = 195512, XrefRangeEnd = 195523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x001AD590 File Offset: 0x001AB790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195525, XrefRangeEnd = 195535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x001AD5CC File Offset: 0x001AB7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195535, XrefRangeEnd = 195570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x001AD608 File Offset: 0x001AB808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195570, XrefRangeEnd = 195573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x001AD644 File Offset: 0x001AB844
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x001AD680 File Offset: 0x001AB880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195472, RefRangeEnd = 195474, XrefRangeStart = 195472, XrefRangeEnd = 195474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x001AD6E4 File Offset: 0x001AB8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x001AD748 File Offset: 0x001AB948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195573, XrefRangeEnd = 195593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x001AD7AC File Offset: 0x001AB9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x001AD810 File Offset: 0x001ABA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195622, RefRangeEnd = 195623, XrefRangeStart = 195593, XrefRangeEnd = 195622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x001AD874 File Offset: 0x001ABA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195623, XrefRangeEnd = 195630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x001AD8C4 File Offset: 0x001ABAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195658, RefRangeEnd = 195660, XrefRangeStart = 195630, XrefRangeEnd = 195658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x001AD930 File Offset: 0x001ABB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195660, XrefRangeEnd = 195662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x001AD99C File Offset: 0x001ABB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195662, XrefRangeEnd = 195675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x001ADA00 File Offset: 0x001ABC00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195703, RefRangeEnd = 195708, XrefRangeStart = 195675, XrefRangeEnd = 195703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x001ADA80 File Offset: 0x001ABC80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 195738, RefRangeEnd = 195745, XrefRangeStart = 195708, XrefRangeEnd = 195738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x001ADB00 File Offset: 0x001ABD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195745, XrefRangeEnd = 195757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x001ADB50 File Offset: 0x001ABD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195785, RefRangeEnd = 195787, XrefRangeStart = 195757, XrefRangeEnd = 195785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x001ADBD0 File Offset: 0x001ABDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195787, XrefRangeEnd = 195799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x001ADC20 File Offset: 0x001ABE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195799, XrefRangeEnd = 195802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x0002BBF8 File Offset: 0x00029DF8
		public DragManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x001ADC5C File Offset: 0x001ABE5C
		// (set) Token: 0x06005CE8 RID: 23784 RVA: 0x0002BC01 File Offset: 0x00029E01
		public unsafe static float DRAGGABLE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x001ADC78 File Offset: 0x001ABE78
		// (set) Token: 0x06005CEA RID: 23786 RVA: 0x0002BC0F File Offset: 0x00029E0F
		public unsafe AudioSourceController ThrowSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x001ADCA8 File Offset: 0x001ABEA8
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x0002BC2E File Offset: 0x00029E2E
		public unsafe float DragForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce)) = value;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x001ADCD0 File Offset: 0x001ABED0
		// (set) Token: 0x06005CEE RID: 23790 RVA: 0x0002BC49 File Offset: 0x00029E49
		public unsafe float DampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor)) = value;
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x001ADCF8 File Offset: 0x001ABEF8
		// (set) Token: 0x06005CF0 RID: 23792 RVA: 0x0002BC64 File Offset: 0x00029E64
		public unsafe float TorqueForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce)) = value;
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x001ADD20 File Offset: 0x001ABF20
		// (set) Token: 0x06005CF2 RID: 23794 RVA: 0x0002BC7F File Offset: 0x00029E7F
		public unsafe float TorqueDampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor)) = value;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x001ADD48 File Offset: 0x001ABF48
		// (set) Token: 0x06005CF4 RID: 23796 RVA: 0x0002BC9A File Offset: 0x00029E9A
		public unsafe float ThrowForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce)) = value;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06005CF5 RID: 23797 RVA: 0x001ADD70 File Offset: 0x001ABF70
		// (set) Token: 0x06005CF6 RID: 23798 RVA: 0x0002BCB5 File Offset: 0x00029EB5
		public unsafe float MassInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence)) = value;
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x001ADD98 File Offset: 0x001ABF98
		// (set) Token: 0x06005CF8 RID: 23800 RVA: 0x0002BCD0 File Offset: 0x00029ED0
		public unsafe Draggable _CurrentDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x001ADDC8 File Offset: 0x001ABFC8
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x0002BCEF File Offset: 0x00029EEF
		public unsafe List<Draggable> AllDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06005CFB RID: 23803 RVA: 0x001ADDF8 File Offset: 0x001ABFF8
		// (set) Token: 0x06005CFC RID: 23804 RVA: 0x0002BD0E File Offset: 0x00029F0E
		public unsafe Draggable lastThrownDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005CFD RID: 23805 RVA: 0x001ADE28 File Offset: 0x001AC028
		// (set) Token: 0x06005CFE RID: 23806 RVA: 0x0002BD2D File Offset: 0x00029F2D
		public unsafe Draggable lastHeldDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06005CFF RID: 23807 RVA: 0x001ADE58 File Offset: 0x001AC058
		// (set) Token: 0x06005D00 RID: 23808 RVA: 0x0002BD4C File Offset: 0x00029F4C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x001ADE80 File Offset: 0x001AC080
		// (set) Token: 0x06005D02 RID: 23810 RVA: 0x0002BD67 File Offset: 0x00029F67
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003F71 RID: 16241
		private static readonly IntPtr NativeFieldInfoPtr_DRAGGABLE_OFFSET;

		// Token: 0x04003F72 RID: 16242
		private static readonly IntPtr NativeFieldInfoPtr_ThrowSound;

		// Token: 0x04003F73 RID: 16243
		private static readonly IntPtr NativeFieldInfoPtr_DragForce;

		// Token: 0x04003F74 RID: 16244
		private static readonly IntPtr NativeFieldInfoPtr_DampingFactor;

		// Token: 0x04003F75 RID: 16245
		private static readonly IntPtr NativeFieldInfoPtr_TorqueForce;

		// Token: 0x04003F76 RID: 16246
		private static readonly IntPtr NativeFieldInfoPtr_TorqueDampingFactor;

		// Token: 0x04003F77 RID: 16247
		private static readonly IntPtr NativeFieldInfoPtr_ThrowForce;

		// Token: 0x04003F78 RID: 16248
		private static readonly IntPtr NativeFieldInfoPtr_MassInfluence;

		// Token: 0x04003F79 RID: 16249
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDraggable_k__BackingField;

		// Token: 0x04003F7A RID: 16250
		private static readonly IntPtr NativeFieldInfoPtr_AllDraggables;

		// Token: 0x04003F7B RID: 16251
		private static readonly IntPtr NativeFieldInfoPtr_lastThrownDraggable;

		// Token: 0x04003F7C RID: 16252
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldDraggable;

		// Token: 0x04003F7D RID: 16253
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003F7E RID: 16254
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003F7F RID: 16255
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0;

		// Token: 0x04003F80 RID: 16256
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04003F85 RID: 16261
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0;

		// Token: 0x04003F86 RID: 16262
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0;

		// Token: 0x04003F89 RID: 16265
		private static readonly IntPtr NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F8A RID: 16266
		private static readonly IntPtr NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F8B RID: 16267
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0;

		// Token: 0x04003F8C RID: 16268
		private static readonly IntPtr NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0;

		// Token: 0x04003F8F RID: 16271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003F91 RID: 16273
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003F92 RID: 16274
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003F93 RID: 16275
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F94 RID: 16276
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F95 RID: 16277
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F96 RID: 16278
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F97 RID: 16279
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F98 RID: 16280
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F99 RID: 16281
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F9A RID: 16282
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F9B RID: 16283
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F9C RID: 16284
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F9D RID: 16285
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F9E RID: 16286
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F9F RID: 16287
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003FA0 RID: 16288
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FA1 RID: 16289
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
