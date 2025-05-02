using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000452 RID: 1106
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x06006015 RID: 24597 RVA: 0x001B8310 File Offset: 0x001B6510
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOrbit()
		{
			Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr);
			CameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "target");
			CameraOrbit.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "cam");
			CameraOrbit.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "raycaster");
			CameraOrbit.NativeFieldInfoPtr_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "LookAt");
			CameraOrbit.NativeFieldInfoPtr_targetdistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetdistance");
			CameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "xSpeed");
			CameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ySpeed");
			CameraOrbit.NativeFieldInfoPtr_sideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "sideOffset");
			CameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMinLimit");
			CameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMaxLimit");
			CameraOrbit.NativeFieldInfoPtr_distanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMin");
			CameraOrbit.NativeFieldInfoPtr_distanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMax");
			CameraOrbit.NativeFieldInfoPtr_ScrollSensativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ScrollSensativity");
			CameraOrbit.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "rb");
			CameraOrbit.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "x");
			CameraOrbit.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "y");
			CameraOrbit.NativeFieldInfoPtr_targetx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetx");
			CameraOrbit.NativeFieldInfoPtr_targety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targety");
			CameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distance");
			CameraOrbit.NativeFieldInfoPtr_hoveringUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "hoveringUI");
			CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675543);
			CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675544);
			CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675545);
			CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675546);
			CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675547);
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x001B8534 File Offset: 0x001B6734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199025, XrefRangeEnd = 199036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x001B8568 File Offset: 0x001B6768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199036, XrefRangeEnd = 199055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x001B859C File Offset: 0x001B679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199055, XrefRangeEnd = 199118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x001B85D0 File Offset: 0x001B67D0
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x001B862C File Offset: 0x001B682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199118, XrefRangeEnd = 199119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x0002D5ED File Offset: 0x0002B7ED
		public CameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x001B8668 File Offset: 0x001B6868
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x0002D5F6 File Offset: 0x0002B7F6
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x001B8698 File Offset: 0x001B6898
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x0002D615 File Offset: 0x0002B815
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06006020 RID: 24608 RVA: 0x001B86C8 File Offset: 0x001B68C8
		// (set) Token: 0x06006021 RID: 24609 RVA: 0x0002D634 File Offset: 0x0002B834
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x001B86F8 File Offset: 0x001B68F8
		// (set) Token: 0x06006023 RID: 24611 RVA: 0x0002D653 File Offset: 0x0002B853
		public unsafe AvatarLookController LookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x001B8728 File Offset: 0x001B6928
		// (set) Token: 0x06006025 RID: 24613 RVA: 0x0002D672 File Offset: 0x0002B872
		public unsafe float targetdistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance)) = value;
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x001B8750 File Offset: 0x001B6950
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x0002D68D File Offset: 0x0002B88D
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x001B8778 File Offset: 0x001B6978
		// (set) Token: 0x06006029 RID: 24617 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x0600602A RID: 24618 RVA: 0x001B87A0 File Offset: 0x001B69A0
		// (set) Token: 0x0600602B RID: 24619 RVA: 0x0002D6C3 File Offset: 0x0002B8C3
		public unsafe float sideOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset)) = value;
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x001B87C8 File Offset: 0x001B69C8
		// (set) Token: 0x0600602D RID: 24621 RVA: 0x0002D6DE File Offset: 0x0002B8DE
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x0600602E RID: 24622 RVA: 0x001B87F0 File Offset: 0x001B69F0
		// (set) Token: 0x0600602F RID: 24623 RVA: 0x0002D6F9 File Offset: 0x0002B8F9
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x001B8818 File Offset: 0x001B6A18
		// (set) Token: 0x06006031 RID: 24625 RVA: 0x0002D714 File Offset: 0x0002B914
		public unsafe float distanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin)) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x001B8840 File Offset: 0x001B6A40
		// (set) Token: 0x06006033 RID: 24627 RVA: 0x0002D72F File Offset: 0x0002B92F
		public unsafe float distanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax)) = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06006034 RID: 24628 RVA: 0x001B8868 File Offset: 0x001B6A68
		// (set) Token: 0x06006035 RID: 24629 RVA: 0x0002D74A File Offset: 0x0002B94A
		public unsafe float ScrollSensativity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity)) = value;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06006036 RID: 24630 RVA: 0x001B8890 File Offset: 0x001B6A90
		// (set) Token: 0x06006037 RID: 24631 RVA: 0x0002D765 File Offset: 0x0002B965
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06006038 RID: 24632 RVA: 0x001B88C0 File Offset: 0x001B6AC0
		// (set) Token: 0x06006039 RID: 24633 RVA: 0x0002D784 File Offset: 0x0002B984
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x0600603A RID: 24634 RVA: 0x001B88E8 File Offset: 0x001B6AE8
		// (set) Token: 0x0600603B RID: 24635 RVA: 0x0002D79F File Offset: 0x0002B99F
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x0600603C RID: 24636 RVA: 0x001B8910 File Offset: 0x001B6B10
		// (set) Token: 0x0600603D RID: 24637 RVA: 0x0002D7BA File Offset: 0x0002B9BA
		public unsafe float targetx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx)) = value;
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x001B8938 File Offset: 0x001B6B38
		// (set) Token: 0x0600603F RID: 24639 RVA: 0x0002D7D5 File Offset: 0x0002B9D5
		public unsafe float targety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety)) = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x001B8960 File Offset: 0x001B6B60
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x0002D7F0 File Offset: 0x0002B9F0
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x001B8988 File Offset: 0x001B6B88
		// (set) Token: 0x06006043 RID: 24643 RVA: 0x0002D80B File Offset: 0x0002BA0B
		public unsafe bool hoveringUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI)) = value;
			}
		}

		// Token: 0x0400419F RID: 16799
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040041A0 RID: 16800
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040041A1 RID: 16801
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x040041A2 RID: 16802
		private static readonly IntPtr NativeFieldInfoPtr_LookAt;

		// Token: 0x040041A3 RID: 16803
		private static readonly IntPtr NativeFieldInfoPtr_targetdistance;

		// Token: 0x040041A4 RID: 16804
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040041A5 RID: 16805
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040041A6 RID: 16806
		private static readonly IntPtr NativeFieldInfoPtr_sideOffset;

		// Token: 0x040041A7 RID: 16807
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040041A8 RID: 16808
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040041A9 RID: 16809
		private static readonly IntPtr NativeFieldInfoPtr_distanceMin;

		// Token: 0x040041AA RID: 16810
		private static readonly IntPtr NativeFieldInfoPtr_distanceMax;

		// Token: 0x040041AB RID: 16811
		private static readonly IntPtr NativeFieldInfoPtr_ScrollSensativity;

		// Token: 0x040041AC RID: 16812
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040041AD RID: 16813
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040041AE RID: 16814
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040041AF RID: 16815
		private static readonly IntPtr NativeFieldInfoPtr_targetx;

		// Token: 0x040041B0 RID: 16816
		private static readonly IntPtr NativeFieldInfoPtr_targety;

		// Token: 0x040041B1 RID: 16817
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040041B2 RID: 16818
		private static readonly IntPtr NativeFieldInfoPtr_hoveringUI;

		// Token: 0x040041B3 RID: 16819
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040041B4 RID: 16820
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040041B5 RID: 16821
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040041B6 RID: 16822
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040041B7 RID: 16823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
