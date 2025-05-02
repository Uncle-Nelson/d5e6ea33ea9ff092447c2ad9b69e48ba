using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F4 RID: 1268
	public class Wheel : MonoBehaviour
	{
		// Token: 0x06006FF4 RID: 28660 RVA: 0x001ED5F8 File Offset: 0x001EB7F8
		// Note: this type is marked as 'beforefieldinit'.
		static Wheel()
		{
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Wheel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
			Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SIDEWAY_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "FORWARD_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DRIFT_AUDIO_THRESHOLD");
			Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "MIN_SPEED_FOR_DRIFT");
			Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "WHEEL_ANIMATION_DISTANCE");
			Wheel.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DEBUG_MODE");
			Wheel.NativeFieldInfoPtr_wheelModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelModel");
			Wheel.NativeFieldInfoPtr_modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "modelContainer");
			Wheel.NativeFieldInfoPtr_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelCollider");
			Wheel.NativeFieldInfoPtr_axleConnectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "axleConnectionPoint");
			Wheel.NativeFieldInfoPtr_staticCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "staticCollider");
			Wheel.NativeFieldInfoPtr_DriftParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticles");
			Wheel.NativeFieldInfoPtr_DriftParticlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticlesEnabled");
			Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "ForwardStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SidewayStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_DriftAudioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioEnabled");
			Wheel.NativeFieldInfoPtr_DriftAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioSource");
			Wheel.NativeFieldInfoPtr_defaultForwardStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultForwardStiffness");
			Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultSidewaysStiffness");
			Wheel.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<isStatic>k__BackingField");
			Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<IsDrifting>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftTime>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftIntensity>k__BackingField");
			Wheel.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "vehicle");
			Wheel.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "lastFramePosition");
			Wheel.NativeFieldInfoPtr_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelData");
			Wheel.NativeFieldInfoPtr_forwardCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "forwardCurve");
			Wheel.NativeFieldInfoPtr_sidewaysCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "sidewaysCurve");
			Wheel.NativeFieldInfoPtr_wheelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelTransform");
			Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677407);
			Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677408);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677409);
			Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677410);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677411);
			Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677412);
			Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677413);
			Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677414);
			Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677415);
			Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677416);
			Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677417);
			Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677418);
			Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677419);
			Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677420);
			Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677421);
			Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677422);
			Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677423);
			Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677424);
			Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677425);
			Wheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677426);
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x001ED9FC File Offset: 0x001EBBFC
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x001EDA38 File Offset: 0x001EBC38
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x001EDA78 File Offset: 0x001EBC78
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x001EDAB4 File Offset: 0x001EBCB4
		public unsafe bool IsDrifting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x001EDAF4 File Offset: 0x001EBCF4
		public unsafe bool IsDrifting_Smoothed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06006FFA RID: 28666 RVA: 0x001EDB30 File Offset: 0x001EBD30
		// (set) Token: 0x06006FFB RID: 28667 RVA: 0x001EDB6C File Offset: 0x001EBD6C
		public unsafe float DriftTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006FFC RID: 28668 RVA: 0x001EDBAC File Offset: 0x001EBDAC
		// (set) Token: 0x06006FFD RID: 28669 RVA: 0x001EDBE8 File Offset: 0x001EBDE8
		public unsafe float DriftIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x001EDC28 File Offset: 0x001EBE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221550, XrefRangeEnd = 221561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x001EDC64 File Offset: 0x001EBE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221561, XrefRangeEnd = 221562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x001EDCA0 File Offset: 0x001EBEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221562, XrefRangeEnd = 221605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x001EDCD4 File Offset: 0x001EBED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221636, RefRangeEnd = 221637, XrefRangeStart = 221605, XrefRangeEnd = 221636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDrifting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x001EDD08 File Offset: 0x001EBF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221637, XrefRangeEnd = 221639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x001EDD3C File Offset: 0x001EBF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221639, XrefRangeEnd = 221643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x001EDD70 File Offset: 0x001EBF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221643, XrefRangeEnd = 221650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x001EDDA4 File Offset: 0x001EBFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221650, XrefRangeEnd = 221652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x001EDDF0 File Offset: 0x001EBFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221652, XrefRangeEnd = 221655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroundWheelModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x001EDE24 File Offset: 0x001EC024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221656, RefRangeEnd = 221657, XrefRangeStart = 221655, XrefRangeEnd = 221656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWheelGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x001EDE60 File Offset: 0x001EC060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221657, XrefRangeEnd = 221660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wheel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x000350B9 File Offset: 0x000332B9
		public Wheel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x001EDE9C File Offset: 0x001EC09C
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x000350C2 File Offset: 0x000332C2
		public unsafe static float SIDEWAY_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x001EDEB8 File Offset: 0x001EC0B8
		// (set) Token: 0x0600700D RID: 28685 RVA: 0x000350D0 File Offset: 0x000332D0
		public unsafe static float FORWARD_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x001EDED4 File Offset: 0x001EC0D4
		// (set) Token: 0x0600700F RID: 28687 RVA: 0x000350DE File Offset: 0x000332DE
		public unsafe static float DRIFT_AUDIO_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06007010 RID: 28688 RVA: 0x001EDEF0 File Offset: 0x001EC0F0
		// (set) Token: 0x06007011 RID: 28689 RVA: 0x000350EC File Offset: 0x000332EC
		public unsafe static float MIN_SPEED_FOR_DRIFT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&value));
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x001EDF0C File Offset: 0x001EC10C
		// (set) Token: 0x06007013 RID: 28691 RVA: 0x000350FA File Offset: 0x000332FA
		public unsafe static float WHEEL_ANIMATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x001EDF28 File Offset: 0x001EC128
		// (set) Token: 0x06007015 RID: 28693 RVA: 0x00035108 File Offset: 0x00033308
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06007016 RID: 28694 RVA: 0x001EDF50 File Offset: 0x001EC150
		// (set) Token: 0x06007017 RID: 28695 RVA: 0x00035123 File Offset: 0x00033323
		public unsafe Transform wheelModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x001EDF80 File Offset: 0x001EC180
		// (set) Token: 0x06007019 RID: 28697 RVA: 0x00035142 File Offset: 0x00033342
		public unsafe Transform modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x001EDFB0 File Offset: 0x001EC1B0
		// (set) Token: 0x0600701B RID: 28699 RVA: 0x00035161 File Offset: 0x00033361
		public unsafe WheelCollider wheelCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x001EDFE0 File Offset: 0x001EC1E0
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x00035180 File Offset: 0x00033380
		public unsafe Transform axleConnectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x001EE010 File Offset: 0x001EC210
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x0003519F File Offset: 0x0003339F
		public unsafe Collider staticCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x001EE040 File Offset: 0x001EC240
		// (set) Token: 0x06007021 RID: 28705 RVA: 0x000351BE File Offset: 0x000333BE
		public unsafe ParticleSystem DriftParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06007022 RID: 28706 RVA: 0x001EE070 File Offset: 0x001EC270
		// (set) Token: 0x06007023 RID: 28707 RVA: 0x000351DD File Offset: 0x000333DD
		public unsafe bool DriftParticlesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled)) = value;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x001EE098 File Offset: 0x001EC298
		// (set) Token: 0x06007025 RID: 28709 RVA: 0x000351F8 File Offset: 0x000333F8
		public unsafe float ForwardStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06007026 RID: 28710 RVA: 0x001EE0C0 File Offset: 0x001EC2C0
		// (set) Token: 0x06007027 RID: 28711 RVA: 0x00035213 File Offset: 0x00033413
		public unsafe float SidewayStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x001EE0E8 File Offset: 0x001EC2E8
		// (set) Token: 0x06007029 RID: 28713 RVA: 0x0003522E File Offset: 0x0003342E
		public unsafe bool DriftAudioEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled)) = value;
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x001EE110 File Offset: 0x001EC310
		// (set) Token: 0x0600702B RID: 28715 RVA: 0x00035249 File Offset: 0x00033449
		public unsafe AudioSourceController DriftAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x001EE140 File Offset: 0x001EC340
		// (set) Token: 0x0600702D RID: 28717 RVA: 0x00035268 File Offset: 0x00033468
		public unsafe float defaultForwardStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness)) = value;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x001EE168 File Offset: 0x001EC368
		// (set) Token: 0x0600702F RID: 28719 RVA: 0x00035283 File Offset: 0x00033483
		public unsafe float defaultSidewaysStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness)) = value;
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x001EE190 File Offset: 0x001EC390
		// (set) Token: 0x06007031 RID: 28721 RVA: 0x0003529E File Offset: 0x0003349E
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06007032 RID: 28722 RVA: 0x001EE1B8 File Offset: 0x001EC3B8
		// (set) Token: 0x06007033 RID: 28723 RVA: 0x000352B9 File Offset: 0x000334B9
		public unsafe bool _IsDrifting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField)) = value;
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06007034 RID: 28724 RVA: 0x001EE1E0 File Offset: 0x001EC3E0
		// (set) Token: 0x06007035 RID: 28725 RVA: 0x000352D4 File Offset: 0x000334D4
		public unsafe float _DriftTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x001EE208 File Offset: 0x001EC408
		// (set) Token: 0x06007037 RID: 28727 RVA: 0x000352EF File Offset: 0x000334EF
		public unsafe float _DriftIntensity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField)) = value;
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06007038 RID: 28728 RVA: 0x001EE230 File Offset: 0x001EC430
		// (set) Token: 0x06007039 RID: 28729 RVA: 0x0003530A File Offset: 0x0003350A
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x001EE260 File Offset: 0x001EC460
		// (set) Token: 0x0600703B RID: 28731 RVA: 0x00035329 File Offset: 0x00033529
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x001EE288 File Offset: 0x001EC488
		// (set) Token: 0x0600703D RID: 28733 RVA: 0x00035344 File Offset: 0x00033544
		public WheelHit wheelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData);
				return new WheelHit(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x001EE2B8 File Offset: 0x001EC4B8
		// (set) Token: 0x0600703F RID: 28735 RVA: 0x00035372 File Offset: 0x00033572
		public unsafe WheelFrictionCurve forwardCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve)) = value;
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x001EE2E0 File Offset: 0x001EC4E0
		// (set) Token: 0x06007041 RID: 28737 RVA: 0x0003538D File Offset: 0x0003358D
		public unsafe WheelFrictionCurve sidewaysCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve)) = value;
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x001EE308 File Offset: 0x001EC508
		// (set) Token: 0x06007043 RID: 28739 RVA: 0x000353A8 File Offset: 0x000335A8
		public unsafe Transform wheelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C84 RID: 19588
		private static readonly IntPtr NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD;

		// Token: 0x04004C85 RID: 19589
		private static readonly IntPtr NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD;

		// Token: 0x04004C86 RID: 19590
		private static readonly IntPtr NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD;

		// Token: 0x04004C87 RID: 19591
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT;

		// Token: 0x04004C88 RID: 19592
		private static readonly IntPtr NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE;

		// Token: 0x04004C89 RID: 19593
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004C8A RID: 19594
		private static readonly IntPtr NativeFieldInfoPtr_wheelModel;

		// Token: 0x04004C8B RID: 19595
		private static readonly IntPtr NativeFieldInfoPtr_modelContainer;

		// Token: 0x04004C8C RID: 19596
		private static readonly IntPtr NativeFieldInfoPtr_wheelCollider;

		// Token: 0x04004C8D RID: 19597
		private static readonly IntPtr NativeFieldInfoPtr_axleConnectionPoint;

		// Token: 0x04004C8E RID: 19598
		private static readonly IntPtr NativeFieldInfoPtr_staticCollider;

		// Token: 0x04004C8F RID: 19599
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticles;

		// Token: 0x04004C90 RID: 19600
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticlesEnabled;

		// Token: 0x04004C91 RID: 19601
		private static readonly IntPtr NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake;

		// Token: 0x04004C92 RID: 19602
		private static readonly IntPtr NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake;

		// Token: 0x04004C93 RID: 19603
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioEnabled;

		// Token: 0x04004C94 RID: 19604
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioSource;

		// Token: 0x04004C95 RID: 19605
		private static readonly IntPtr NativeFieldInfoPtr_defaultForwardStiffness;

		// Token: 0x04004C96 RID: 19606
		private static readonly IntPtr NativeFieldInfoPtr_defaultSidewaysStiffness;

		// Token: 0x04004C97 RID: 19607
		private static readonly IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004C98 RID: 19608
		private static readonly IntPtr NativeFieldInfoPtr__IsDrifting_k__BackingField;

		// Token: 0x04004C99 RID: 19609
		private static readonly IntPtr NativeFieldInfoPtr__DriftTime_k__BackingField;

		// Token: 0x04004C9A RID: 19610
		private static readonly IntPtr NativeFieldInfoPtr__DriftIntensity_k__BackingField;

		// Token: 0x04004C9B RID: 19611
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C9C RID: 19612
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004C9D RID: 19613
		private static readonly IntPtr NativeFieldInfoPtr_wheelData;

		// Token: 0x04004C9E RID: 19614
		private static readonly IntPtr NativeFieldInfoPtr_forwardCurve;

		// Token: 0x04004C9F RID: 19615
		private static readonly IntPtr NativeFieldInfoPtr_sidewaysCurve;

		// Token: 0x04004CA0 RID: 19616
		private static readonly IntPtr NativeFieldInfoPtr_wheelTransform;

		// Token: 0x04004CA1 RID: 19617
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004CA2 RID: 19618
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004CA3 RID: 19619
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0;

		// Token: 0x04004CA4 RID: 19620
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0;

		// Token: 0x04004CA5 RID: 19621
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0;

		// Token: 0x04004CA6 RID: 19622
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0;

		// Token: 0x04004CA7 RID: 19623
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0;

		// Token: 0x04004CA8 RID: 19624
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0;

		// Token: 0x04004CA9 RID: 19625
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0;

		// Token: 0x04004CAA RID: 19626
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004CAB RID: 19627
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004CAC RID: 19628
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004CAD RID: 19629
		private static readonly IntPtr NativeMethodInfoPtr_CheckDrifting_Private_Void_0;

		// Token: 0x04004CAE RID: 19630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0;

		// Token: 0x04004CAF RID: 19631
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0;

		// Token: 0x04004CB0 RID: 19632
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFriction_Private_Void_0;

		// Token: 0x04004CB1 RID: 19633
		private static readonly IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004CB2 RID: 19634
		private static readonly IntPtr NativeMethodInfoPtr_GroundWheelModel_Private_Void_0;

		// Token: 0x04004CB3 RID: 19635
		private static readonly IntPtr NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0;

		// Token: 0x04004CB4 RID: 19636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
