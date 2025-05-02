using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000451 RID: 1105
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x06005FE1 RID: 24545 RVA: 0x001B79A0 File Offset: 0x001B5BA0
		// Note: this type is marked as 'beforefieldinit'.
		static BirdsEyeView()
		{
			Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "BirdsEyeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr);
			BirdsEyeView.NativeFieldInfoPtr_bounds_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Min");
			BirdsEyeView.NativeFieldInfoPtr_bounds_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Max");
			BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "lateralMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "scrollMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetFollowSpeed");
			BirdsEyeView.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "xSpeed");
			BirdsEyeView.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "ySpeed");
			BirdsEyeView.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMinLimit");
			BirdsEyeView.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMaxLimit");
			BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "rotationOriginPoint");
			BirdsEyeView.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "distance");
			BirdsEyeView.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "prevDistance");
			BirdsEyeView.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "x");
			BirdsEyeView.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "y");
			BirdsEyeView.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetTransform");
			BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<isEnabled>k__BackingField");
			BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "originSlideRoutine");
			BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675519);
			BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675520);
			BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675521);
			BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675522);
			BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675523);
			BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675524);
			BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675525);
			BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675526);
			BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675527);
			BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675528);
			BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675529);
			BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675530);
			BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675531);
			BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675532);
			BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675533);
			BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675534);
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x001B7C64 File Offset: 0x001B5E64
		public unsafe Transform playerCam
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 198852, RefRangeEnd = 198859, XrefRangeStart = 198846, XrefRangeEnd = 198852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x001B7CA4 File Offset: 0x001B5EA4
		// (set) Token: 0x06005FE4 RID: 24548 RVA: 0x001B7CE0 File Offset: 0x001B5EE0
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x001B7D20 File Offset: 0x001B5F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198859, XrefRangeEnd = 198876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x001B7D5C File Offset: 0x001B5F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198876, XrefRangeEnd = 198879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x001B7D98 File Offset: 0x001B5F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198879, XrefRangeEnd = 198880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x001B7DD4 File Offset: 0x001B5FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198880, XrefRangeEnd = 198893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(Vector3 startPosition, Quaternion startRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x001B7E20 File Offset: 0x001B6020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198902, RefRangeEnd = 198903, XrefRangeStart = 198893, XrefRangeEnd = 198902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable(bool reenableCameraLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableCameraLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x001B7E60 File Offset: 0x001B6060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198928, RefRangeEnd = 198929, XrefRangeStart = 198903, XrefRangeEnd = 198928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLateralMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x001B7E94 File Offset: 0x001B6094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198943, RefRangeEnd = 198944, XrefRangeStart = 198929, XrefRangeEnd = 198943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x001B7EC8 File Offset: 0x001B60C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198976, RefRangeEnd = 198977, XrefRangeStart = 198944, XrefRangeEnd = 198976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x001B7EFC File Offset: 0x001B60FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198991, RefRangeEnd = 198992, XrefRangeStart = 198977, XrefRangeEnd = 198991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x001B7F30 File Offset: 0x001B6130
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x001B7F8C File Offset: 0x001B618C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198992, XrefRangeEnd = 198994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelOriginSlide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x001B7FC0 File Offset: 0x001B61C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199019, RefRangeEnd = 199020, XrefRangeStart = 198994, XrefRangeEnd = 199019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDistance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x001B801C File Offset: 0x001B621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199020, XrefRangeEnd = 199025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BirdsEyeView() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x0002D411 File Offset: 0x0002B611
		public BirdsEyeView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x001B8058 File Offset: 0x001B6258
		// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x0002D41A File Offset: 0x0002B61A
		public unsafe Vector3 bounds_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min)) = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x001B8080 File Offset: 0x001B6280
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x0002D435 File Offset: 0x0002B635
		public unsafe Vector3 bounds_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max)) = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x001B80A8 File Offset: 0x001B62A8
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x0002D450 File Offset: 0x0002B650
		public unsafe float lateralMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed)) = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x001B80D0 File Offset: 0x001B62D0
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x0002D46B File Offset: 0x0002B66B
		public unsafe float scrollMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed)) = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x001B80F8 File Offset: 0x001B62F8
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x0002D486 File Offset: 0x0002B686
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x001B8120 File Offset: 0x001B6320
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x0002D4A1 File Offset: 0x0002B6A1
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x001B8148 File Offset: 0x001B6348
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06006001 RID: 24577 RVA: 0x001B8170 File Offset: 0x001B6370
		// (set) Token: 0x06006002 RID: 24578 RVA: 0x0002D4D7 File Offset: 0x0002B6D7
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x001B8198 File Offset: 0x001B6398
		// (set) Token: 0x06006004 RID: 24580 RVA: 0x0002D4F2 File Offset: 0x0002B6F2
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x001B81C0 File Offset: 0x001B63C0
		// (set) Token: 0x06006006 RID: 24582 RVA: 0x0002D50D File Offset: 0x0002B70D
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x001B81E8 File Offset: 0x001B63E8
		// (set) Token: 0x06006008 RID: 24584 RVA: 0x0002D528 File Offset: 0x0002B728
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x001B8210 File Offset: 0x001B6410
		// (set) Token: 0x0600600A RID: 24586 RVA: 0x0002D543 File Offset: 0x0002B743
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x0600600B RID: 24587 RVA: 0x001B8238 File Offset: 0x001B6438
		// (set) Token: 0x0600600C RID: 24588 RVA: 0x0002D55E File Offset: 0x0002B75E
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x0600600D RID: 24589 RVA: 0x001B8260 File Offset: 0x001B6460
		// (set) Token: 0x0600600E RID: 24590 RVA: 0x0002D579 File Offset: 0x0002B779
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600600F RID: 24591 RVA: 0x001B8288 File Offset: 0x001B6488
		// (set) Token: 0x06006010 RID: 24592 RVA: 0x0002D594 File Offset: 0x0002B794
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06006011 RID: 24593 RVA: 0x001B82B8 File Offset: 0x001B64B8
		// (set) Token: 0x06006012 RID: 24594 RVA: 0x0002D5B3 File Offset: 0x0002B7B3
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x001B82E0 File Offset: 0x001B64E0
		// (set) Token: 0x06006014 RID: 24596 RVA: 0x0002D5CE File Offset: 0x0002B7CE
		public unsafe Coroutine originSlideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400417E RID: 16766
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Min;

		// Token: 0x0400417F RID: 16767
		private static readonly IntPtr NativeFieldInfoPtr_bounds_Max;

		// Token: 0x04004180 RID: 16768
		private static readonly IntPtr NativeFieldInfoPtr_lateralMovementSpeed;

		// Token: 0x04004181 RID: 16769
		private static readonly IntPtr NativeFieldInfoPtr_scrollMovementSpeed;

		// Token: 0x04004182 RID: 16770
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x04004183 RID: 16771
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004184 RID: 16772
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004185 RID: 16773
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004186 RID: 16774
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004187 RID: 16775
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x04004188 RID: 16776
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004189 RID: 16777
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x0400418A RID: 16778
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400418B RID: 16779
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400418C RID: 16780
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x0400418D RID: 16781
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x0400418E RID: 16782
		private static readonly IntPtr NativeFieldInfoPtr_originSlideRoutine;

		// Token: 0x0400418F RID: 16783
		private static readonly IntPtr NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0;

		// Token: 0x04004190 RID: 16784
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x04004191 RID: 16785
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04004192 RID: 16786
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004193 RID: 16787
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004194 RID: 16788
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004195 RID: 16789
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004196 RID: 16790
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_Boolean_0;

		// Token: 0x04004197 RID: 16791
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0;

		// Token: 0x04004198 RID: 16792
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0;

		// Token: 0x04004199 RID: 16793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x0400419A RID: 16794
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x0400419B RID: 16795
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x0400419C RID: 16796
		private static readonly IntPtr NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0;

		// Token: 0x0400419D RID: 16797
		private static readonly IntPtr NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0;

		// Token: 0x0400419E RID: 16798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A0F RID: 2575
		[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEBB RID: 52923 RVA: 0x0031B6B0 File Offset: 0x003198B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr);
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "position");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "time");
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675535);
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675536);
			}

			// Token: 0x0600CEBC RID: 52924 RVA: 0x0031B740 File Offset: 0x00319940
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEBD RID: 52925 RVA: 0x0031B77C File Offset: 0x0031997C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198841, XrefRangeEnd = 198846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CEBE RID: 52926 RVA: 0x000648AD File Offset: 0x00062AAD
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004049 RID: 16457
			// (get) Token: 0x0600CEBF RID: 52927 RVA: 0x0031B7BC File Offset: 0x003199BC
			// (set) Token: 0x0600CEC0 RID: 52928 RVA: 0x000648B6 File Offset: 0x00062AB6
			public unsafe BirdsEyeView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700404A RID: 16458
			// (get) Token: 0x0600CEC1 RID: 52929 RVA: 0x0031B7EC File Offset: 0x003199EC
			// (set) Token: 0x0600CEC2 RID: 52930 RVA: 0x000648D5 File Offset: 0x00062AD5
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0600CEC3 RID: 52931 RVA: 0x0031B814 File Offset: 0x00319A14
			// (set) Token: 0x0600CEC4 RID: 52932 RVA: 0x000648F0 File Offset: 0x00062AF0
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008B82 RID: 35714
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B83 RID: 35715
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008B84 RID: 35716
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008B85 RID: 35717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B86 RID: 35718
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C56 RID: 3158
			[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0+<<SlideCameraOrigin>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E368 RID: 58216 RVA: 0x00356140 File Offset: 0x00354340
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique()
				{
					Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<<SlideCameraOrigin>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>1__state");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>2__current");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>4__this");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<i>5__3");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675537);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675538);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675539);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675540);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675541);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675542);
				}

				// Token: 0x0600E369 RID: 58217 RVA: 0x00356248 File Offset: 0x00354448
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E36A RID: 58218 RVA: 0x00356290 File Offset: 0x00354490
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E36B RID: 58219 RVA: 0x003562C4 File Offset: 0x003544C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198825, XrefRangeEnd = 198836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004691 RID: 18065
				// (get) Token: 0x0600E36C RID: 58220 RVA: 0x00356300 File Offset: 0x00354500
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E36D RID: 58221 RVA: 0x00356340 File Offset: 0x00354540
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198836, XrefRangeEnd = 198841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004692 RID: 18066
				// (get) Token: 0x0600E36E RID: 58222 RVA: 0x00356374 File Offset: 0x00354574
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E36F RID: 58223 RVA: 0x0006ED52 File Offset: 0x0006CF52
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700468C RID: 18060
				// (get) Token: 0x0600E370 RID: 58224 RVA: 0x003563B4 File Offset: 0x003545B4
				// (set) Token: 0x0600E371 RID: 58225 RVA: 0x0006ED5B File Offset: 0x0006CF5B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700468D RID: 18061
				// (get) Token: 0x0600E372 RID: 58226 RVA: 0x003563DC File Offset: 0x003545DC
				// (set) Token: 0x0600E373 RID: 58227 RVA: 0x0006ED76 File Offset: 0x0006CF76
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700468E RID: 18062
				// (get) Token: 0x0600E374 RID: 58228 RVA: 0x0035640C File Offset: 0x0035460C
				// (set) Token: 0x0600E375 RID: 58229 RVA: 0x0006ED95 File Offset: 0x0006CF95
				public unsafe BirdsEyeView.__c__DisplayClass33_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView.__c__DisplayClass33_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700468F RID: 18063
				// (get) Token: 0x0600E376 RID: 58230 RVA: 0x0035643C File Offset: 0x0035463C
				// (set) Token: 0x0600E377 RID: 58231 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17004690 RID: 18064
				// (get) Token: 0x0600E378 RID: 58232 RVA: 0x00356464 File Offset: 0x00354664
				// (set) Token: 0x0600E379 RID: 58233 RVA: 0x0006EDCF File Offset: 0x0006CFCF
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400982E RID: 38958
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400982F RID: 38959
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009830 RID: 38960
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009831 RID: 38961
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x04009832 RID: 38962
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009833 RID: 38963
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009834 RID: 38964
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009835 RID: 38965
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009836 RID: 38966
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009837 RID: 38967
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009838 RID: 38968
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
