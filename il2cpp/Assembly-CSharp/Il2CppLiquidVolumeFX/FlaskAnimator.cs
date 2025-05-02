using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CD RID: 205
	public class FlaskAnimator : MonoBehaviour
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x000A060C File Offset: 0x0009E80C
		// Note: this type is marked as 'beforefieldinit'.
		static FlaskAnimator()
		{
			Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "FlaskAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr);
			FlaskAnimator.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "speed");
			FlaskAnimator.NativeFieldInfoPtr_initialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "initialPosition");
			FlaskAnimator.NativeFieldInfoPtr_finalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "finalPosition");
			FlaskAnimator.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "duration");
			FlaskAnimator.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "delay");
			FlaskAnimator.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "level");
			FlaskAnimator.NativeFieldInfoPtr_minRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "minRange");
			FlaskAnimator.NativeFieldInfoPtr_maxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "maxRange");
			FlaskAnimator.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "acceleration");
			FlaskAnimator.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "rotationSpeed");
			FlaskAnimator.NativeFieldInfoPtr_alphaDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "alphaDuration");
			FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "finalRefractionBlur");
			FlaskAnimator.NativeFieldInfoPtr_liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "liquid");
			FlaskAnimator.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, "direction");
			FlaskAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665080);
			FlaskAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665081);
			FlaskAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000A0790 File Offset: 0x0009E990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86192, XrefRangeEnd = 86198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000A07C4 File Offset: 0x0009E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86198, XrefRangeEnd = 86222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000A07F8 File Offset: 0x0009E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86222, XrefRangeEnd = 86227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlaskAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlaskAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlaskAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000097BC File Offset: 0x000079BC
		public FlaskAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000A0834 File Offset: 0x0009EA34
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x000097C5 File Offset: 0x000079C5
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000A085C File Offset: 0x0009EA5C
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x000097E0 File Offset: 0x000079E0
		public unsafe Vector3 initialPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_initialPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_initialPosition)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000A0884 File Offset: 0x0009EA84
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x000097FB File Offset: 0x000079FB
		public unsafe Vector3 finalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalPosition)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x000A08AC File Offset: 0x0009EAAC
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00009816 File Offset: 0x00007A16
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000A08D4 File Offset: 0x0009EAD4
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00009831 File Offset: 0x00007A31
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000A08FC File Offset: 0x0009EAFC
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x0000984C File Offset: 0x00007A4C
		public unsafe float level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000A0924 File Offset: 0x0009EB24
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00009867 File Offset: 0x00007A67
		public unsafe float minRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_minRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_minRange)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000A094C File Offset: 0x0009EB4C
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00009882 File Offset: 0x00007A82
		public unsafe float maxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_maxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_maxRange)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000A0974 File Offset: 0x0009EB74
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0000989D File Offset: 0x00007A9D
		public unsafe float acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_acceleration)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000A099C File Offset: 0x0009EB9C
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x000098B8 File Offset: 0x00007AB8
		public unsafe float rotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_rotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_rotationSpeed)) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000A09C4 File Offset: 0x0009EBC4
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x000098D3 File Offset: 0x00007AD3
		public unsafe float alphaDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_alphaDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_alphaDuration)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x000A09EC File Offset: 0x0009EBEC
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x000098EE File Offset: 0x00007AEE
		public unsafe float finalRefractionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_finalRefractionBlur)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x000A0A14 File Offset: 0x0009EC14
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00009909 File Offset: 0x00007B09
		public unsafe LiquidVolume liquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_liquid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x000A0A44 File Offset: 0x0009EC44
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00009928 File Offset: 0x00007B28
		public unsafe float direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlaskAnimator.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_initialPosition;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_finalPosition;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_minRange;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_maxRange;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_acceleration;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_alphaDuration;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_finalRefractionBlur;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_liquid;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
