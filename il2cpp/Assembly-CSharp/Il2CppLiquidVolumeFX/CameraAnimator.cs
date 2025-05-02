using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CA RID: 202
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x0009FFE8 File Offset: 0x0009E1E8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraAnimator()
		{
			Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "CameraAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr);
			CameraAnimator.NativeFieldInfoPtr_baseHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "baseHeight");
			CameraAnimator.NativeFieldInfoPtr_speedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "speedY");
			CameraAnimator.NativeFieldInfoPtr_speedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "speedX");
			CameraAnimator.NativeFieldInfoPtr_distAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "distAcceleration");
			CameraAnimator.NativeFieldInfoPtr_distSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "distSpeed");
			CameraAnimator.NativeFieldInfoPtr_lookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "lookAt");
			CameraAnimator.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "y");
			CameraAnimator.NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "dy");
			CameraAnimator.NativeFieldInfoPtr_distDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "distDirection");
			CameraAnimator.NativeFieldInfoPtr_distSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, "distSum");
			CameraAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100665073);
			CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100665074);
			CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr, 100665075);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000A011C File Offset: 0x0009E31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86082, XrefRangeEnd = 86084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000A0150 File Offset: 0x0009E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86084, XrefRangeEnd = 86114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000A0184 File Offset: 0x0009E384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86114, XrefRangeEnd = 86115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0000960C File Offset: 0x0000780C
		public CameraAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000A01C0 File Offset: 0x0009E3C0
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00009615 File Offset: 0x00007815
		public unsafe float baseHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_baseHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_baseHeight)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x000A01E8 File Offset: 0x0009E3E8
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00009630 File Offset: 0x00007830
		public unsafe float speedY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_speedY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_speedY)) = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000A0210 File Offset: 0x0009E410
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0000964B File Offset: 0x0000784B
		public unsafe float speedX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_speedX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_speedX)) = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x000A0238 File Offset: 0x0009E438
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00009666 File Offset: 0x00007866
		public unsafe float distAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distAcceleration)) = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000A0260 File Offset: 0x0009E460
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00009681 File Offset: 0x00007881
		public unsafe float distSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distSpeed)) = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000A0288 File Offset: 0x0009E488
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0000969C File Offset: 0x0000789C
		public unsafe Vector3 lookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_lookAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_lookAt)) = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000A02B0 File Offset: 0x0009E4B0
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x000096B7 File Offset: 0x000078B7
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x000096D2 File Offset: 0x000078D2
		public unsafe float dy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_dy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_dy)) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000A0300 File Offset: 0x0009E500
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000096ED File Offset: 0x000078ED
		public unsafe float distDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distDirection)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000A0328 File Offset: 0x0009E528
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00009708 File Offset: 0x00007908
		public unsafe float distSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraAnimator.NativeFieldInfoPtr_distSum)) = value;
			}
		}

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr_baseHeight;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_speedY;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_speedX;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_distAcceleration;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_distSpeed;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_lookAt;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_dy;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeFieldInfoPtr_distDirection;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_distSum;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
