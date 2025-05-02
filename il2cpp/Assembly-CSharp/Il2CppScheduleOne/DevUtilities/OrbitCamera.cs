using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000461 RID: 1121
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06006159 RID: 24921 RVA: 0x001BC23C File Offset: 0x001BA43C
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitCamera()
		{
			Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OrbitCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
			OrbitCamera.NativeFieldInfoPtr_cameraStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraStartPoint");
			OrbitCamera.NativeFieldInfoPtr_centrePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "centrePoint");
			OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetFollowSpeed");
			OrbitCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMinLimit");
			OrbitCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMaxLimit");
			OrbitCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "xSpeed");
			OrbitCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "ySpeed");
			OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "<isEnabled>k__BackingField");
			OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "rotationOriginPoint");
			OrbitCamera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "distance");
			OrbitCamera.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "prevDistance");
			OrbitCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "x");
			OrbitCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "y");
			OrbitCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetTransform");
			OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675665);
			OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675666);
			OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675667);
			OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675668);
			OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675669);
			OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675670);
			OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675671);
			OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675672);
			OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675673);
			OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675674);
			OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675675);
			OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675676);
			OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100675677);
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600615A RID: 24922 RVA: 0x001BC488 File Offset: 0x001BA688
		// (set) Token: 0x0600615B RID: 24923 RVA: 0x001BC4C4 File Offset: 0x001BA6C4
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600615C RID: 24924 RVA: 0x001BC504 File Offset: 0x001BA704
		public unsafe Transform cam
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 200730, RefRangeEnd = 200736, XrefRangeStart = 200724, XrefRangeEnd = 200730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x001BC544 File Offset: 0x001BA744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200736, XrefRangeEnd = 200750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x001BC580 File Offset: 0x001BA780
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x001BC5BC File Offset: 0x001BA7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200750, XrefRangeEnd = 200751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x001BC5F8 File Offset: 0x001BA7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200751, XrefRangeEnd = 200752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x001BC634 File Offset: 0x001BA834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200774, RefRangeEnd = 200775, XrefRangeStart = 200752, XrefRangeEnd = 200774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x001BC668 File Offset: 0x001BA868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200784, RefRangeEnd = 200786, XrefRangeStart = 200775, XrefRangeEnd = 200784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x001BC69C File Offset: 0x001BA89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200815, RefRangeEnd = 200816, XrefRangeStart = 200786, XrefRangeEnd = 200815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x001BC6D0 File Offset: 0x001BA8D0
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x001BC72C File Offset: 0x001BA92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200830, RefRangeEnd = 200831, XrefRangeStart = 200816, XrefRangeEnd = 200830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x001BC760 File Offset: 0x001BA960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200831, XrefRangeEnd = 200834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x0002E054 File Offset: 0x0002C254
		public OrbitCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x001BC79C File Offset: 0x001BA99C
		// (set) Token: 0x06006169 RID: 24937 RVA: 0x0002E05D File Offset: 0x0002C25D
		public unsafe Transform cameraStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x0600616A RID: 24938 RVA: 0x001BC7CC File Offset: 0x001BA9CC
		// (set) Token: 0x0600616B RID: 24939 RVA: 0x0002E07C File Offset: 0x0002C27C
		public unsafe Transform centrePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x001BC7FC File Offset: 0x001BA9FC
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x0002E09B File Offset: 0x0002C29B
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x001BC824 File Offset: 0x001BAA24
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x0002E0B6 File Offset: 0x0002C2B6
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x001BC84C File Offset: 0x001BAA4C
		// (set) Token: 0x06006171 RID: 24945 RVA: 0x0002E0D1 File Offset: 0x0002C2D1
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x001BC874 File Offset: 0x001BAA74
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x0002E0EC File Offset: 0x0002C2EC
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x001BC890 File Offset: 0x001BAA90
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x0002E0FA File Offset: 0x0002C2FA
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x001BC8AC File Offset: 0x001BAAAC
		// (set) Token: 0x06006177 RID: 24951 RVA: 0x0002E108 File Offset: 0x0002C308
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x001BC8D4 File Offset: 0x001BAAD4
		// (set) Token: 0x06006179 RID: 24953 RVA: 0x0002E123 File Offset: 0x0002C323
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x001BC8FC File Offset: 0x001BAAFC
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x0002E13E File Offset: 0x0002C33E
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600617C RID: 24956 RVA: 0x001BC924 File Offset: 0x001BAB24
		// (set) Token: 0x0600617D RID: 24957 RVA: 0x0002E159 File Offset: 0x0002C359
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600617E RID: 24958 RVA: 0x001BC94C File Offset: 0x001BAB4C
		// (set) Token: 0x0600617F RID: 24959 RVA: 0x0002E174 File Offset: 0x0002C374
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06006180 RID: 24960 RVA: 0x001BC974 File Offset: 0x001BAB74
		// (set) Token: 0x06006181 RID: 24961 RVA: 0x0002E18F File Offset: 0x0002C38F
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x001BC99C File Offset: 0x001BAB9C
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x0002E1AA File Offset: 0x0002C3AA
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeFieldInfoPtr_cameraStartPoint;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeFieldInfoPtr_centrePoint;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Protected_get_Transform_0;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
