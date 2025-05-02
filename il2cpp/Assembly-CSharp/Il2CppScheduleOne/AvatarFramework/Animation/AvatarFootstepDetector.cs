using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060B RID: 1547
	public class AvatarFootstepDetector : MonoBehaviour
	{
		// Token: 0x060088C3 RID: 35011 RVA: 0x0023FBE8 File Offset: 0x0023DDE8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarFootstepDetector()
		{
			Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarFootstepDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr);
			AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "MAX_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GROUND_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "Avatar");
			AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "ReferencePoint");
			AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "LeftBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_RightBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "RightBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "StepThreshold");
			AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GroundDetectionMask");
			AvatarFootstepDetector.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "leftDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "rightDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "onStep");
			AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680352);
			AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680353);
			AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680354);
			AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680355);
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x0023FD44 File Offset: 0x0023DF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253126, XrefRangeEnd = 253149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x0023FD78 File Offset: 0x0023DF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253153, RefRangeEnd = 253154, XrefRangeStart = 253149, XrefRangeEnd = 253153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x0023FDAC File Offset: 0x0023DFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253166, RefRangeEnd = 253167, XrefRangeStart = 253154, XrefRangeEnd = 253166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x0023FDF8 File Offset: 0x0023DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253167, XrefRangeEnd = 253175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarFootstepDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x000413C4 File Offset: 0x0003F5C4
		public AvatarFootstepDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060088C9 RID: 35017 RVA: 0x0023FE34 File Offset: 0x0023E034
		// (set) Token: 0x060088CA RID: 35018 RVA: 0x000413CD File Offset: 0x0003F5CD
		public unsafe static float MAX_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x0023FE50 File Offset: 0x0023E050
		// (set) Token: 0x060088CC RID: 35020 RVA: 0x000413DB File Offset: 0x0003F5DB
		public unsafe static float GROUND_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x0023FE6C File Offset: 0x0023E06C
		// (set) Token: 0x060088CE RID: 35022 RVA: 0x000413E9 File Offset: 0x0003F5E9
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x0023FE9C File Offset: 0x0023E09C
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x00041408 File Offset: 0x0003F608
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x0023FECC File Offset: 0x0023E0CC
		// (set) Token: 0x060088D2 RID: 35026 RVA: 0x00041427 File Offset: 0x0003F627
		public unsafe Transform LeftBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x0023FEFC File Offset: 0x0023E0FC
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x00041446 File Offset: 0x0003F646
		public unsafe Transform RightBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x0023FF2C File Offset: 0x0023E12C
		// (set) Token: 0x060088D6 RID: 35030 RVA: 0x00041465 File Offset: 0x0003F665
		public unsafe float StepThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold)) = value;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060088D7 RID: 35031 RVA: 0x0023FF54 File Offset: 0x0023E154
		// (set) Token: 0x060088D8 RID: 35032 RVA: 0x00041480 File Offset: 0x0003F680
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060088D9 RID: 35033 RVA: 0x0023FF7C File Offset: 0x0023E17C
		// (set) Token: 0x060088DA RID: 35034 RVA: 0x0004149B File Offset: 0x0003F69B
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x060088DB RID: 35035 RVA: 0x0023FFA4 File Offset: 0x0023E1A4
		// (set) Token: 0x060088DC RID: 35036 RVA: 0x000414B6 File Offset: 0x0003F6B6
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x060088DD RID: 35037 RVA: 0x0023FFCC File Offset: 0x0023E1CC
		// (set) Token: 0x060088DE RID: 35038 RVA: 0x000414D1 File Offset: 0x0003F6D1
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005CEE RID: 23790
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DETECTION_RANGE;

		// Token: 0x04005CEF RID: 23791
		private static readonly IntPtr NativeFieldInfoPtr_GROUND_DETECTION_RANGE;

		// Token: 0x04005CF0 RID: 23792
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005CF1 RID: 23793
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x04005CF2 RID: 23794
		private static readonly IntPtr NativeFieldInfoPtr_LeftBone;

		// Token: 0x04005CF3 RID: 23795
		private static readonly IntPtr NativeFieldInfoPtr_RightBone;

		// Token: 0x04005CF4 RID: 23796
		private static readonly IntPtr NativeFieldInfoPtr_StepThreshold;

		// Token: 0x04005CF5 RID: 23797
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04005CF6 RID: 23798
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x04005CF7 RID: 23799
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x04005CF8 RID: 23800
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x04005CF9 RID: 23801
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005CFA RID: 23802
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x04005CFB RID: 23803
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x04005CFC RID: 23804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
