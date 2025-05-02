using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000035 RID: 53
	public class SmoothCameraOrbit : MonoBehaviour
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0007BBD0 File Offset: 0x00079DD0
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothCameraOrbit()
		{
			Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmoothCameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr);
			SmoothCameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "target");
			SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "targetOffset");
			SmoothCameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "distance");
			SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "maxDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "minDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "xSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "ySpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yMinLimit");
			SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yMaxLimit");
			SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "zoomRate");
			SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "panSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "zoomDampening");
			SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "autoRotate");
			SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "autoRotateSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_xDeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "xDeg");
			SmoothCameraOrbit.NativeFieldInfoPtr_yDeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yDeg");
			SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "currentDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "desiredDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "currentRotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "desiredRotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "rotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "position");
			SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "idleTimer");
			SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "idleSmooth");
			SmoothCameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663646);
			SmoothCameraOrbit.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663647);
			SmoothCameraOrbit.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663648);
			SmoothCameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663649);
			SmoothCameraOrbit.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663650);
			SmoothCameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663651);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0007BE58 File Offset: 0x0007A058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73745, XrefRangeEnd = 73746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0007BE8C File Offset: 0x0007A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0007BEC0 File Offset: 0x0007A0C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73786, RefRangeEnd = 73788, XrefRangeStart = 73746, XrefRangeEnd = 73786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0007BEF4 File Offset: 0x0007A0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73788, XrefRangeEnd = 73828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0007BF28 File Offset: 0x0007A128
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0007BF84 File Offset: 0x0007A184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73828, XrefRangeEnd = 73829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothCameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000417E File Offset: 0x0000237E
		public SmoothCameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0007BFC0 File Offset: 0x0007A1C0
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00004187 File Offset: 0x00002387
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0007BFF0 File Offset: 0x0007A1F0
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000041A6 File Offset: 0x000023A6
		public unsafe Vector3 targetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0007C018 File Offset: 0x0007A218
		// (set) Token: 0x060003BC RID: 956 RVA: 0x000041C1 File Offset: 0x000023C1
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0007C040 File Offset: 0x0007A240
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000041DC File Offset: 0x000023DC
		public unsafe float maxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0007C068 File Offset: 0x0007A268
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x000041F7 File Offset: 0x000023F7
		public unsafe float minDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_minDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_minDistance)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0007C090 File Offset: 0x0007A290
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00004212 File Offset: 0x00002412
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000422D File Offset: 0x0000242D
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00004248 File Offset: 0x00002448
		public unsafe int yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0007C108 File Offset: 0x0007A308
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00004263 File Offset: 0x00002463
		public unsafe int yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0007C130 File Offset: 0x0007A330
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000427E File Offset: 0x0000247E
		public unsafe int zoomRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0007C158 File Offset: 0x0007A358
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00004299 File Offset: 0x00002499
		public unsafe float panSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0007C180 File Offset: 0x0007A380
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000042B4 File Offset: 0x000024B4
		public unsafe float zoomDampening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000042CF File Offset: 0x000024CF
		public unsafe float autoRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000042EA File Offset: 0x000024EA
		public unsafe float autoRotateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00004305 File Offset: 0x00002505
		public unsafe float xDeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xDeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xDeg)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0007C220 File Offset: 0x0007A420
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00004320 File Offset: 0x00002520
		public unsafe float yDeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yDeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yDeg)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0007C248 File Offset: 0x0007A448
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0000433B File Offset: 0x0000253B
		public unsafe float currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0007C270 File Offset: 0x0007A470
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00004356 File Offset: 0x00002556
		public unsafe float desiredDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0007C298 File Offset: 0x0007A498
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00004371 File Offset: 0x00002571
		public unsafe Quaternion currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0007C2C0 File Offset: 0x0007A4C0
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000438C File Offset: 0x0000258C
		public unsafe Quaternion desiredRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0007C2E8 File Offset: 0x0007A4E8
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000043A7 File Offset: 0x000025A7
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0007C310 File Offset: 0x0007A510
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000043C2 File Offset: 0x000025C2
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0007C338 File Offset: 0x0007A538
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000043DD File Offset: 0x000025DD
		public unsafe float idleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0007C360 File Offset: 0x0007A560
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000043F8 File Offset: 0x000025F8
		public unsafe float idleSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth)) = value;
			}
		}

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_targetOffset;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_minDistance;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_zoomRate;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_panSpeed;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_zoomDampening;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_autoRotate;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_autoRotateSpeed;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_xDeg;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_yDeg;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_desiredDistance;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_desiredRotation;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_idleTimer;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_idleSmooth;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
