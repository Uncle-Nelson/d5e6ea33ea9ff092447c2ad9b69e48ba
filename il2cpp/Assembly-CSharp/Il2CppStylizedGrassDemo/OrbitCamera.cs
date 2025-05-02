using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C3 RID: 195
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x0009EED8 File Offset: 0x0009D0D8
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitCamera()
		{
			Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "OrbitCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
			OrbitCamera.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "pivot");
			OrbitCamera.NativeFieldInfoPtr_enableMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "enableMouse");
			OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "idleRotationSpeed");
			OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "lookSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "moveSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "scrollSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cam");
			OrbitCamera.NativeFieldInfoPtr_cameraRotSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotSide");
			OrbitCamera.NativeFieldInfoPtr_cameraRotUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotUp");
			OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotSideCur");
			OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotUpCur");
			OrbitCamera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "distance");
			OrbitCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665045);
			OrbitCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665046);
			OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0009F034 File Offset: 0x0009D234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85812, XrefRangeEnd = 85824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0009F068 File Offset: 0x0009D268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85824, XrefRangeEnd = 85870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0009F09C File Offset: 0x0009D29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85870, XrefRangeEnd = 85871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000091A8 File Offset: 0x000073A8
		public OrbitCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0009F0D8 File Offset: 0x0009D2D8
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000091B1 File Offset: 0x000073B1
		public unsafe Transform pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_pivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_pivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0009F108 File Offset: 0x0009D308
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x000091D0 File Offset: 0x000073D0
		public unsafe bool enableMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_enableMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_enableMouse)) = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0009F130 File Offset: 0x0009D330
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x000091EB File Offset: 0x000073EB
		public unsafe float idleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0009F158 File Offset: 0x0009D358
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00009206 File Offset: 0x00007406
		public unsafe float lookSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0009F180 File Offset: 0x0009D380
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00009221 File Offset: 0x00007421
		public unsafe float moveSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0009F1A8 File Offset: 0x0009D3A8
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x0000923C File Offset: 0x0000743C
		public unsafe float scrollSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0009F1D0 File Offset: 0x0009D3D0
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00009257 File Offset: 0x00007457
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0009F200 File Offset: 0x0009D400
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00009276 File Offset: 0x00007476
		public unsafe float cameraRotSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSide)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0009F228 File Offset: 0x0009D428
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00009291 File Offset: 0x00007491
		public unsafe float cameraRotUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUp)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0009F250 File Offset: 0x0009D450
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x000092AC File Offset: 0x000074AC
		public unsafe float cameraRotSideCur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur)) = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0009F278 File Offset: 0x0009D478
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000092C7 File Offset: 0x000074C7
		public unsafe float cameraRotUpCur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0009F2A0 File Offset: 0x0009D4A0
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000092E2 File Offset: 0x000074E2
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

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_enableMouse;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_idleRotationSpeed;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_lookSmoothSpeed;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_moveSmoothSpeed;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_scrollSmoothSpeed;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotSide;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotUp;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotSideCur;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotUpCur;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
