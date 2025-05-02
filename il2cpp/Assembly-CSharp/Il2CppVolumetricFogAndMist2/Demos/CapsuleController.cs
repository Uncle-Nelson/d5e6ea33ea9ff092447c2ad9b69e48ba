using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVolumetricFogAndMist2.Demos
{
	// Token: 0x020000BF RID: 191
	public class CapsuleController : MonoBehaviour
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x0009E264 File Offset: 0x0009C464
		// Note: this type is marked as 'beforefieldinit'.
		static CapsuleController()
		{
			Il2CppClassPointerStore<CapsuleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VolumetricFogAndMist2.Demos", "CapsuleController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr);
			CapsuleController.NativeFieldInfoPtr_fogVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "fogVolume");
			CapsuleController.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "moveSpeed");
			CapsuleController.NativeFieldInfoPtr_fogHoleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "fogHoleRadius");
			CapsuleController.NativeFieldInfoPtr_clearDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "clearDuration");
			CapsuleController.NativeFieldInfoPtr_distanceCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "distanceCheck");
			CapsuleController.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, "lastPos");
			CapsuleController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, 100665033);
			CapsuleController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr, 100665034);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0009E334 File Offset: 0x0009C534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85692, XrefRangeEnd = 85713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CapsuleController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0009E368 File Offset: 0x0009C568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85713, XrefRangeEnd = 85714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CapsuleController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CapsuleController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CapsuleController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00008DD6 File Offset: 0x00006FD6
		public CapsuleController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0009E3A4 File Offset: 0x0009C5A4
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00008DDF File Offset: 0x00006FDF
		public unsafe VolumetricFog fogVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_fogVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_fogVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0009E3D4 File Offset: 0x0009C5D4
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00008DFE File Offset: 0x00006FFE
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0009E3FC File Offset: 0x0009C5FC
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00008E19 File Offset: 0x00007019
		public unsafe float fogHoleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_fogHoleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_fogHoleRadius)) = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0009E424 File Offset: 0x0009C624
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00008E34 File Offset: 0x00007034
		public unsafe float clearDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_clearDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_clearDuration)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0009E44C File Offset: 0x0009C64C
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00008E4F File Offset: 0x0000704F
		public unsafe float distanceCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_distanceCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_distanceCheck)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0009E474 File Offset: 0x0009C674
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00008E6A File Offset: 0x0000706A
		public unsafe Vector3 lastPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_lastPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CapsuleController.NativeFieldInfoPtr_lastPos)) = value;
			}
		}

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_fogVolume;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr_fogHoleRadius;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr_clearDuration;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr_distanceCheck;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_lastPos;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
