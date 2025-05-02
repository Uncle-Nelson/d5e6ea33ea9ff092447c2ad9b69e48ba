using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityTemplateProjects
{
	// Token: 0x02000079 RID: 121
	public class SimpleCameraController : MonoBehaviour
	{
		// Token: 0x06000888 RID: 2184 RVA: 0x0008AB2C File Offset: 0x00088D2C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCameraController()
		{
			Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityTemplateProjects", "SimpleCameraController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr);
			SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_TargetCameraState");
			SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_InterpolatingCameraState");
			SimpleCameraController.NativeFieldInfoPtr_boost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "boost");
			SimpleCameraController.NativeFieldInfoPtr_positionLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "positionLerpTime");
			SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "mouseSensitivityCurve");
			SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "rotationLerpTime");
			SimpleCameraController.NativeFieldInfoPtr_invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "invertY");
			SimpleCameraController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664203);
			SimpleCameraController.NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664204);
			SimpleCameraController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664205);
			SimpleCameraController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664206);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0008AC38 File Offset: 0x00088E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79239, XrefRangeEnd = 79244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0008AC6C File Offset: 0x00088E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79262, RefRangeEnd = 79263, XrefRangeStart = 79244, XrefRangeEnd = 79262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetInputTranslationDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0008ACA8 File Offset: 0x00088EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79263, XrefRangeEnd = 79300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0008ACDC File Offset: 0x00088EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79300, XrefRangeEnd = 79320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCameraController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000069EB File Offset: 0x00004BEB
		public SimpleCameraController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0008AD18 File Offset: 0x00088F18
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x000069F4 File Offset: 0x00004BF4
		public unsafe SimpleCameraController.CameraState m_TargetCameraState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCameraController.CameraState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0008AD48 File Offset: 0x00088F48
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00006A13 File Offset: 0x00004C13
		public unsafe SimpleCameraController.CameraState m_InterpolatingCameraState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCameraController.CameraState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0008AD78 File Offset: 0x00088F78
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00006A32 File Offset: 0x00004C32
		public unsafe float boost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_boost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_boost)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0008ADA0 File Offset: 0x00088FA0
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00006A4D File Offset: 0x00004C4D
		public unsafe float positionLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_positionLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_positionLerpTime)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0008ADC8 File Offset: 0x00088FC8
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00006A68 File Offset: 0x00004C68
		public unsafe AnimationCurve mouseSensitivityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0008ADF8 File Offset: 0x00088FF8
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00006A87 File Offset: 0x00004C87
		public unsafe float rotationLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0008AE20 File Offset: 0x00089020
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00006AA2 File Offset: 0x00004CA2
		public unsafe bool invertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_invertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_invertY)) = value;
			}
		}

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetCameraState;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_m_InterpolatingCameraState;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_boost;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_positionLerpTime;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_mouseSensitivityCurve;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_rotationLerpTime;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_invertY;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200080D RID: 2061
		public class CameraState : Il2CppSystem.Object
		{
			// Token: 0x0600BD0E RID: 48398 RVA: 0x002E942C File Offset: 0x002E762C
			// Note: this type is marked as 'beforefieldinit'.
			static CameraState()
			{
				Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "CameraState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr);
				SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "yaw");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "pitch");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "roll");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "x");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "y");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "z");
				SimpleCameraController.CameraState.NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664207);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664208);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664209);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664210);
				SimpleCameraController.CameraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664211);
			}

			// Token: 0x0600BD0F RID: 48399 RVA: 0x002E9534 File Offset: 0x002E7734
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79222, RefRangeEnd = 79224, XrefRangeStart = 79216, XrefRangeEnd = 79222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFromTransform(Transform t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD10 RID: 48400 RVA: 0x002E9578 File Offset: 0x002E7778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79224, XrefRangeEnd = 79226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Translate(Vector3 translation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref translation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD11 RID: 48401 RVA: 0x002E95B8 File Offset: 0x002E77B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79236, RefRangeEnd = 79237, XrefRangeStart = 79226, XrefRangeEnd = 79236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LerpTowards(SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionLerpPct;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationLerpPct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD12 RID: 48402 RVA: 0x002E9618 File Offset: 0x002E7818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79237, XrefRangeEnd = 79239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTransform(Transform t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD13 RID: 48403 RVA: 0x002E965C File Offset: 0x002E785C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD14 RID: 48404 RVA: 0x0005C89E File Offset: 0x0005AA9E
			public CameraState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A9C RID: 15004
			// (get) Token: 0x0600BD15 RID: 48405 RVA: 0x002E9698 File Offset: 0x002E7898
			// (set) Token: 0x0600BD16 RID: 48406 RVA: 0x0005C8A7 File Offset: 0x0005AAA7
			public unsafe float yaw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw)) = value;
				}
			}

			// Token: 0x17003A9D RID: 15005
			// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x002E96C0 File Offset: 0x002E78C0
			// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x0005C8C2 File Offset: 0x0005AAC2
			public unsafe float pitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch)) = value;
				}
			}

			// Token: 0x17003A9E RID: 15006
			// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x002E96E8 File Offset: 0x002E78E8
			// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x0005C8DD File Offset: 0x0005AADD
			public unsafe float roll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_roll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_roll)) = value;
				}
			}

			// Token: 0x17003A9F RID: 15007
			// (get) Token: 0x0600BD1B RID: 48411 RVA: 0x002E9710 File Offset: 0x002E7910
			// (set) Token: 0x0600BD1C RID: 48412 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
			public unsafe float x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17003AA0 RID: 15008
			// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x002E9738 File Offset: 0x002E7938
			// (set) Token: 0x0600BD1E RID: 48414 RVA: 0x0005C913 File Offset: 0x0005AB13
			public unsafe float y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17003AA1 RID: 15009
			// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x002E9760 File Offset: 0x002E7960
			// (set) Token: 0x0600BD20 RID: 48416 RVA: 0x0005C92E File Offset: 0x0005AB2E
			public unsafe float z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400801E RID: 32798
			private static readonly IntPtr NativeFieldInfoPtr_yaw;

			// Token: 0x0400801F RID: 32799
			private static readonly IntPtr NativeFieldInfoPtr_pitch;

			// Token: 0x04008020 RID: 32800
			private static readonly IntPtr NativeFieldInfoPtr_roll;

			// Token: 0x04008021 RID: 32801
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008022 RID: 32802
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008023 RID: 32803
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04008024 RID: 32804
			private static readonly IntPtr NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0;

			// Token: 0x04008025 RID: 32805
			private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

			// Token: 0x04008026 RID: 32806
			private static readonly IntPtr NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0;

			// Token: 0x04008027 RID: 32807
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0;

			// Token: 0x04008028 RID: 32808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
