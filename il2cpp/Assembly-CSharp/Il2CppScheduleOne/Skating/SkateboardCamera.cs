using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A7 RID: 423
	public class SkateboardCamera : NetworkBehaviour
	{
		// Token: 0x060023BF RID: 9151 RVA: 0x000DF9A0 File Offset: 0x000DDBA0
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardCamera()
		{
			Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr);
			SkateboardCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "followDelta");
			SkateboardCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMinLimit");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideTime");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideReturnTime");
			SkateboardCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "xSpeed");
			SkateboardCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "ySpeed");
			SkateboardCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMaxLimit");
			SkateboardCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraOrigin");
			SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraFollowSpeed");
			SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "HorizontalOffset");
			SkateboardCamera.NativeFieldInfoPtr_VerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "VerticalOffset");
			SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraDownAngle");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MinSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MaxSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplierChangeRate");
			SkateboardCamera.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "board");
			SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "currentFovMultiplier");
			SkateboardCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraReversed");
			SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "orbitDistance");
			SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastFrameCameraOffset");
			SkateboardCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastManualOffset");
			SkateboardCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "targetTransform");
			SkateboardCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraDolly");
			SkateboardCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "x");
			SkateboardCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "y");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667273);
			SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667274);
			SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667275);
			SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667276);
			SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667277);
			SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667278);
			SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667279);
			SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667280);
			SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667281);
			SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667282);
			SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667283);
			SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667284);
			SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667285);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667286);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667287);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667288);
			SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667289);
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000DFD68 File Offset: 0x000DDF68
		public unsafe Transform cam
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 112700, RefRangeEnd = 112713, XrefRangeStart = 112694, XrefRangeEnd = 112700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000DFDA8 File Offset: 0x000DDFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112713, XrefRangeEnd = 112714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000DFDE4 File Offset: 0x000DDFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112714, XrefRangeEnd = 112717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000DFE20 File Offset: 0x000DE020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112717, XrefRangeEnd = 112725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000DFE54 File Offset: 0x000DE054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112725, XrefRangeEnd = 112731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000DFE88 File Offset: 0x000DE088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112731, XrefRangeEnd = 112735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000DFEBC File Offset: 0x000DE0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112735, XrefRangeEnd = 112743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000DFEF0 File Offset: 0x000DE0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112837, RefRangeEnd = 112838, XrefRangeStart = 112743, XrefRangeEnd = 112837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x000DFF24 File Offset: 0x000DE124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112854, RefRangeEnd = 112855, XrefRangeStart = 112838, XrefRangeEnd = 112854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x000DFF58 File Offset: 0x000DE158
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000DFFB4 File Offset: 0x000DE1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112866, RefRangeEnd = 112867, XrefRangeStart = 112855, XrefRangeEnd = 112866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000DFFF0 File Offset: 0x000DE1F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112894, RefRangeEnd = 112897, XrefRangeStart = 112867, XrefRangeEnd = 112894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000E003C File Offset: 0x000DE23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112897, XrefRangeEnd = 112902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000E0078 File Offset: 0x000DE278
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000E00B4 File Offset: 0x000DE2B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112902, RefRangeEnd = 112903, XrefRangeStart = 112902, XrefRangeEnd = 112902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000E00F0 File Offset: 0x000DE2F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000E012C File Offset: 0x000DE32C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112932, RefRangeEnd = 112933, XrefRangeStart = 112903, XrefRangeEnd = 112932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000141AB File Offset: 0x000123AB
		public SkateboardCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000E0160 File Offset: 0x000DE360
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000141B4 File Offset: 0x000123B4
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000E017C File Offset: 0x000DE37C
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x000141C2 File Offset: 0x000123C2
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000E0198 File Offset: 0x000DE398
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x000141D0 File Offset: 0x000123D0
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000E01B4 File Offset: 0x000DE3B4
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x000141DE File Offset: 0x000123DE
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x000E01D0 File Offset: 0x000DE3D0
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x000141EC File Offset: 0x000123EC
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x000E01EC File Offset: 0x000DE3EC
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x000141FA File Offset: 0x000123FA
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000E0208 File Offset: 0x000DE408
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x00014208 File Offset: 0x00012408
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000E0224 File Offset: 0x000DE424
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x00014216 File Offset: 0x00012416
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000E0254 File Offset: 0x000DE454
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00014235 File Offset: 0x00012435
		public unsafe float CameraFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed)) = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000E027C File Offset: 0x000DE47C
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x00014250 File Offset: 0x00012450
		public unsafe float HorizontalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000E02A4 File Offset: 0x000DE4A4
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0001426B File Offset: 0x0001246B
		public unsafe float VerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000E02CC File Offset: 0x000DE4CC
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x00014286 File Offset: 0x00012486
		public unsafe float CameraDownAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle)) = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000E02F4 File Offset: 0x000DE4F4
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x000142A1 File Offset: 0x000124A1
		public unsafe float FOVMultiplier_MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed)) = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000E031C File Offset: 0x000DE51C
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x000142BC File Offset: 0x000124BC
		public unsafe float FOVMultiplier_MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed)) = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000E0344 File Offset: 0x000DE544
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x000142D7 File Offset: 0x000124D7
		public unsafe float FOVMultiplierChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate)) = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000E036C File Offset: 0x000DE56C
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x000142F2 File Offset: 0x000124F2
		public unsafe Skateboard board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000E039C File Offset: 0x000DE59C
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00014311 File Offset: 0x00012511
		public unsafe float currentFovMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier)) = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000E03C4 File Offset: 0x000DE5C4
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x0001432C File Offset: 0x0001252C
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000E03EC File Offset: 0x000DE5EC
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00014347 File Offset: 0x00012547
		public unsafe bool cameraAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted)) = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000E0414 File Offset: 0x000DE614
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x00014362 File Offset: 0x00012562
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x000E043C File Offset: 0x000DE63C
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x0001437D File Offset: 0x0001257D
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000E0464 File Offset: 0x000DE664
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x00014398 File Offset: 0x00012598
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000E048C File Offset: 0x000DE68C
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x000143B3 File Offset: 0x000125B3
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000E04B4 File Offset: 0x000DE6B4
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x000143CE File Offset: 0x000125CE
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x000E04E4 File Offset: 0x000DE6E4
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x000143ED File Offset: 0x000125ED
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000E0514 File Offset: 0x000DE714
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x0001440C File Offset: 0x0001260C
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000E053C File Offset: 0x000DE73C
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x00014427 File Offset: 0x00012627
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x000E0564 File Offset: 0x000DE764
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x00014442 File Offset: 0x00012642
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x000E058C File Offset: 0x000DE78C
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x0001445D File Offset: 0x0001265D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_CameraFollowSpeed;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalOffset;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeFieldInfoPtr_VerticalOffset;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_CameraDownAngle;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MinSpeed;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MaxSpeed;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplierChangeRate;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_board;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_currentFovMultiplier;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_cameraAdjusted;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_1;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamera_Private_Void_1;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Private_Void_1;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
