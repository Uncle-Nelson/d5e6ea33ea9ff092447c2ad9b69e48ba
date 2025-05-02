using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EA RID: 1258
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x06006F02 RID: 28418 RVA: 0x001EA728 File Offset: 0x001E8928
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCamera()
		{
			Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr);
			VehicleCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "followDelta");
			VehicleCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMinLimit");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideTime");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideReturnTime");
			VehicleCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "xSpeed");
			VehicleCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "ySpeed");
			VehicleCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMaxLimit");
			VehicleCamera.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "vehicle");
			VehicleCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraOrigin");
			VehicleCamera.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lateralOffset");
			VehicleCamera.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "verticalOffset");
			VehicleCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraReversed");
			VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			VehicleCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "orbitDistance");
			VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastFrameCameraOffset");
			VehicleCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastManualOffset");
			VehicleCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "targetTransform");
			VehicleCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraDolly");
			VehicleCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "x");
			VehicleCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "y");
			VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677324);
			VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677325);
			VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677326);
			VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677327);
			VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677328);
			VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677329);
			VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677330);
			VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677331);
			VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677332);
			VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677333);
			VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677334);
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06006F03 RID: 28419 RVA: 0x001EA9C4 File Offset: 0x001E8BC4
		public unsafe Transform cam
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 220668, RefRangeEnd = 220683, XrefRangeStart = 220662, XrefRangeEnd = 220668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x001EAA04 File Offset: 0x001E8C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220683, XrefRangeEnd = 220752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x001EAA40 File Offset: 0x001E8C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220752, XrefRangeEnd = 220770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x001EAA74 File Offset: 0x001E8C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220786, RefRangeEnd = 220787, XrefRangeStart = 220770, XrefRangeEnd = 220786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x001EAAB0 File Offset: 0x001E8CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220787, XrefRangeEnd = 220798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnteredVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x001EAAF4 File Offset: 0x001E8CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220798, XrefRangeEnd = 220813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x001EAB28 File Offset: 0x001E8D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220914, RefRangeEnd = 220915, XrefRangeStart = 220813, XrefRangeEnd = 220914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x001EAB64 File Offset: 0x001E8D64
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x001EABC0 File Offset: 0x001E8DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220915, XrefRangeEnd = 220922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x001EABFC File Offset: 0x001E8DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220949, RefRangeEnd = 220952, XrefRangeStart = 220922, XrefRangeEnd = 220949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x001EAC48 File Offset: 0x001E8E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220957, RefRangeEnd = 220958, XrefRangeStart = 220952, XrefRangeEnd = 220957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x000348BA File Offset: 0x00032ABA
		public VehicleCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x001EAC84 File Offset: 0x001E8E84
		// (set) Token: 0x06006F10 RID: 28432 RVA: 0x000348C3 File Offset: 0x00032AC3
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06006F11 RID: 28433 RVA: 0x001EACA0 File Offset: 0x001E8EA0
		// (set) Token: 0x06006F12 RID: 28434 RVA: 0x000348D1 File Offset: 0x00032AD1
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x001EACBC File Offset: 0x001E8EBC
		// (set) Token: 0x06006F14 RID: 28436 RVA: 0x000348DF File Offset: 0x00032ADF
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x001EACD8 File Offset: 0x001E8ED8
		// (set) Token: 0x06006F16 RID: 28438 RVA: 0x000348ED File Offset: 0x00032AED
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06006F17 RID: 28439 RVA: 0x001EACF4 File Offset: 0x001E8EF4
		// (set) Token: 0x06006F18 RID: 28440 RVA: 0x000348FB File Offset: 0x00032AFB
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x001EAD10 File Offset: 0x001E8F10
		// (set) Token: 0x06006F1A RID: 28442 RVA: 0x00034909 File Offset: 0x00032B09
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x001EAD2C File Offset: 0x001E8F2C
		// (set) Token: 0x06006F1C RID: 28444 RVA: 0x00034917 File Offset: 0x00032B17
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06006F1D RID: 28445 RVA: 0x001EAD48 File Offset: 0x001E8F48
		// (set) Token: 0x06006F1E RID: 28446 RVA: 0x00034925 File Offset: 0x00032B25
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06006F1F RID: 28447 RVA: 0x001EAD78 File Offset: 0x001E8F78
		// (set) Token: 0x06006F20 RID: 28448 RVA: 0x00034944 File Offset: 0x00032B44
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06006F21 RID: 28449 RVA: 0x001EADA8 File Offset: 0x001E8FA8
		// (set) Token: 0x06006F22 RID: 28450 RVA: 0x00034963 File Offset: 0x00032B63
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06006F23 RID: 28451 RVA: 0x001EADD0 File Offset: 0x001E8FD0
		// (set) Token: 0x06006F24 RID: 28452 RVA: 0x0003497E File Offset: 0x00032B7E
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06006F25 RID: 28453 RVA: 0x001EADF8 File Offset: 0x001E8FF8
		// (set) Token: 0x06006F26 RID: 28454 RVA: 0x00034999 File Offset: 0x00032B99
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x001EAE20 File Offset: 0x001E9020
		// (set) Token: 0x06006F28 RID: 28456 RVA: 0x000349B4 File Offset: 0x00032BB4
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06006F29 RID: 28457 RVA: 0x001EAE48 File Offset: 0x001E9048
		// (set) Token: 0x06006F2A RID: 28458 RVA: 0x000349CF File Offset: 0x00032BCF
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06006F2B RID: 28459 RVA: 0x001EAE70 File Offset: 0x001E9070
		// (set) Token: 0x06006F2C RID: 28460 RVA: 0x000349EA File Offset: 0x00032BEA
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06006F2D RID: 28461 RVA: 0x001EAE98 File Offset: 0x001E9098
		// (set) Token: 0x06006F2E RID: 28462 RVA: 0x00034A05 File Offset: 0x00032C05
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x001EAEC0 File Offset: 0x001E90C0
		// (set) Token: 0x06006F30 RID: 28464 RVA: 0x00034A20 File Offset: 0x00032C20
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x001EAEF0 File Offset: 0x001E90F0
		// (set) Token: 0x06006F32 RID: 28466 RVA: 0x00034A3F File Offset: 0x00032C3F
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06006F33 RID: 28467 RVA: 0x001EAF20 File Offset: 0x001E9120
		// (set) Token: 0x06006F34 RID: 28468 RVA: 0x00034A5E File Offset: 0x00032C5E
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x001EAF48 File Offset: 0x001E9148
		// (set) Token: 0x06006F36 RID: 28470 RVA: 0x00034A79 File Offset: 0x00032C79
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x04004BED RID: 19437
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x04004BEE RID: 19438
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004BEF RID: 19439
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x04004BF0 RID: 19440
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x04004BF1 RID: 19441
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004BF2 RID: 19442
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004BF3 RID: 19443
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004BF4 RID: 19444
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004BF5 RID: 19445
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004BF6 RID: 19446
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004BF7 RID: 19447
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x04004BF8 RID: 19448
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x04004BF9 RID: 19449
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x04004BFA RID: 19450
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x04004BFB RID: 19451
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04004BFC RID: 19452
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04004BFD RID: 19453
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04004BFE RID: 19454
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04004BFF RID: 19455
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04004C00 RID: 19456
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004C01 RID: 19457
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04004C02 RID: 19458
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004C03 RID: 19459
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04004C04 RID: 19460
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004C05 RID: 19461
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04004C06 RID: 19462
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_0;

		// Token: 0x04004C07 RID: 19463
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004C08 RID: 19464
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004C09 RID: 19465
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x04004C0A RID: 19466
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x04004C0B RID: 19467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
