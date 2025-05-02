using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F8 RID: 1272
	public class VehicleRecorder : MonoBehaviour
	{
		// Token: 0x06007090 RID: 28816 RVA: 0x001EEE94 File Offset: 0x001ED094
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecorder()
		{
			Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr);
			VehicleRecorder.NativeFieldInfoPtr_frameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "frameRate");
			VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "IS_RECORDING");
			VehicleRecorder.NativeFieldInfoPtr_keyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "keyFrames");
			VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "vehicleToRecord");
			VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "timeSinceKeyFrame");
			VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677440);
			VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677441);
			VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677442);
			VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677443);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x001EEF78 File Offset: 0x001ED178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221743, XrefRangeEnd = 221770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x001EEFB4 File Offset: 0x001ED1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221830, RefRangeEnd = 221831, XrefRangeStart = 221770, XrefRangeEnd = 221830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame Capture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame>(intPtr3) : null;
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x001EEFF4 File Offset: 0x001ED1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221831, XrefRangeEnd = 221846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame.WheelTransform>(intPtr3) : null;
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x001EF044 File Offset: 0x001ED244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221846, XrefRangeEnd = 221854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecorder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x00035710 File Offset: 0x00033910
		public VehicleRecorder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06007096 RID: 28822 RVA: 0x001EF080 File Offset: 0x001ED280
		// (set) Token: 0x06007097 RID: 28823 RVA: 0x00035719 File Offset: 0x00033919
		public unsafe static int frameRate
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&value));
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06007098 RID: 28824 RVA: 0x001EF09C File Offset: 0x001ED29C
		// (set) Token: 0x06007099 RID: 28825 RVA: 0x00035727 File Offset: 0x00033927
		public unsafe bool IS_RECORDING
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING)) = value;
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600709A RID: 28826 RVA: 0x001EF0C4 File Offset: 0x001ED2C4
		// (set) Token: 0x0600709B RID: 28827 RVA: 0x00035742 File Offset: 0x00033942
		public unsafe List<VehicleKeyFrame> keyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600709C RID: 28828 RVA: 0x001EF0F4 File Offset: 0x001ED2F4
		// (set) Token: 0x0600709D RID: 28829 RVA: 0x00035761 File Offset: 0x00033961
		public unsafe LandVehicle vehicleToRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600709E RID: 28830 RVA: 0x001EF124 File Offset: 0x001ED324
		// (set) Token: 0x0600709F RID: 28831 RVA: 0x00035780 File Offset: 0x00033980
		public unsafe float timeSinceKeyFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame)) = value;
			}
		}

		// Token: 0x04004CDE RID: 19678
		private static readonly IntPtr NativeFieldInfoPtr_frameRate;

		// Token: 0x04004CDF RID: 19679
		private static readonly IntPtr NativeFieldInfoPtr_IS_RECORDING;

		// Token: 0x04004CE0 RID: 19680
		private static readonly IntPtr NativeFieldInfoPtr_keyFrames;

		// Token: 0x04004CE1 RID: 19681
		private static readonly IntPtr NativeFieldInfoPtr_vehicleToRecord;

		// Token: 0x04004CE2 RID: 19682
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceKeyFrame;

		// Token: 0x04004CE3 RID: 19683
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004CE4 RID: 19684
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0;

		// Token: 0x04004CE5 RID: 19685
		private static readonly IntPtr NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0;

		// Token: 0x04004CE6 RID: 19686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
