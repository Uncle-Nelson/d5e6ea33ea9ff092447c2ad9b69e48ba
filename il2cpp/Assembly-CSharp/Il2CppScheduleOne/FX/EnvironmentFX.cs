using System;
using Il2CppAtmosphericHeightFog;
using Il2CppFunly.SkyStudio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppVolumetricFogAndMist2;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F7 RID: 1015
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x0018BADC File Offset: 0x00189CDC
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentFX()
		{
			Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "EnvironmentFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr);
			EnvironmentFX.NativeFieldInfoPtr_windZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "windZone");
			EnvironmentFX.NativeFieldInfoPtr_timeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "timeOfDayController");
			EnvironmentFX.NativeFieldInfoPtr_HeightFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFog");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFog");
			EnvironmentFX.NativeFieldInfoPtr_SunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "SunLight");
			EnvironmentFX.NativeFieldInfoPtr_MoonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "MoonLight");
			EnvironmentFX.NativeFieldInfoPtr_fogColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceCurve");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogColor");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogDirectionalIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogColor");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "godRayIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_contrastCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contrastCurve");
			EnvironmentFX.NativeFieldInfoPtr_contractMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contractMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_saturationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationCurve");
			EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_grassMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassMat");
			EnvironmentFX.NativeFieldInfoPtr_grassColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeMat");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeColorCurve");
			EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "environmentalBrightnessCurve");
			EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "bloomThreshholdCurve");
			EnvironmentFX.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "started");
			EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "FogEndDistanceController");
			EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673807);
			EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673808);
			EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673809);
			EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673810);
			EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673811);
			EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673812);
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x0018BDC8 File Offset: 0x00189FC8
		public unsafe float normalizedEnvironmentalBrightness
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 180011, RefRangeEnd = 180014, XrefRangeStart = 180002, XrefRangeEnd = 180011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0018BE04 File Offset: 0x0018A004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180014, XrefRangeEnd = 180032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x0018BE40 File Offset: 0x0018A040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180032, XrefRangeEnd = 180042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x0018BE74 File Offset: 0x0018A074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180088, RefRangeEnd = 180089, XrefRangeStart = 180042, XrefRangeEnd = 180088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0018BEA8 File Offset: 0x0018A0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180089, XrefRangeEnd = 180092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x0018BEE4 File Offset: 0x0018A0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180092, XrefRangeEnd = 180095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x0002856F File Offset: 0x0002676F
		public EnvironmentFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x0018BF20 File Offset: 0x0018A120
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x00028578 File Offset: 0x00026778
		public unsafe WindZone windZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x0018BF50 File Offset: 0x0018A150
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x00028597 File Offset: 0x00026797
		public unsafe TimeOfDayController timeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x0018BF80 File Offset: 0x0018A180
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x000285B6 File Offset: 0x000267B6
		public unsafe HeightFogGlobal HeightFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeightFogGlobal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x0018BFB0 File Offset: 0x0018A1B0
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x000285D5 File Offset: 0x000267D5
		public unsafe VolumetricFog VolumetricFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x0018BFE0 File Offset: 0x0018A1E0
		// (set) Token: 0x06005460 RID: 21600 RVA: 0x000285F4 File Offset: 0x000267F4
		public unsafe Light SunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x0018C010 File Offset: 0x0018A210
		// (set) Token: 0x06005462 RID: 21602 RVA: 0x00028613 File Offset: 0x00026813
		public unsafe Light MoonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x0018C040 File Offset: 0x0018A240
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x00028632 File Offset: 0x00026832
		public unsafe Gradient fogColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x0018C070 File Offset: 0x0018A270
		// (set) Token: 0x06005466 RID: 21606 RVA: 0x00028651 File Offset: 0x00026851
		public unsafe AnimationCurve fogEndDistanceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x0018C0A0 File Offset: 0x0018A2A0
		// (set) Token: 0x06005468 RID: 21608 RVA: 0x00028670 File Offset: 0x00026870
		public unsafe float fogEndDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier)) = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x0018C0C8 File Offset: 0x0018A2C8
		// (set) Token: 0x0600546A RID: 21610 RVA: 0x0002868B File Offset: 0x0002688B
		public unsafe Gradient HeightFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x0018C0F8 File Offset: 0x0018A2F8
		// (set) Token: 0x0600546C RID: 21612 RVA: 0x000286AA File Offset: 0x000268AA
		public unsafe AnimationCurve HeightFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x0018C128 File Offset: 0x0018A328
		// (set) Token: 0x0600546E RID: 21614 RVA: 0x000286C9 File Offset: 0x000268C9
		public unsafe float HeightFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x0018C150 File Offset: 0x0018A350
		// (set) Token: 0x06005470 RID: 21616 RVA: 0x000286E4 File Offset: 0x000268E4
		public unsafe AnimationCurve HeightFogDirectionalIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06005471 RID: 21617 RVA: 0x0018C180 File Offset: 0x0018A380
		// (set) Token: 0x06005472 RID: 21618 RVA: 0x00028703 File Offset: 0x00026903
		public unsafe Gradient VolumetricFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x0018C1B0 File Offset: 0x0018A3B0
		// (set) Token: 0x06005474 RID: 21620 RVA: 0x00028722 File Offset: 0x00026922
		public unsafe AnimationCurve VolumetricFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x0018C1E0 File Offset: 0x0018A3E0
		// (set) Token: 0x06005476 RID: 21622 RVA: 0x00028741 File Offset: 0x00026941
		public unsafe float VolumetricFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x0018C208 File Offset: 0x0018A408
		// (set) Token: 0x06005478 RID: 21624 RVA: 0x0002875C File Offset: 0x0002695C
		public unsafe AnimationCurve godRayIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x0018C238 File Offset: 0x0018A438
		// (set) Token: 0x0600547A RID: 21626 RVA: 0x0002877B File Offset: 0x0002697B
		public unsafe AnimationCurve contrastCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x0018C268 File Offset: 0x0018A468
		// (set) Token: 0x0600547C RID: 21628 RVA: 0x0002879A File Offset: 0x0002699A
		public unsafe float contractMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier)) = value;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x0018C290 File Offset: 0x0018A490
		// (set) Token: 0x0600547E RID: 21630 RVA: 0x000287B5 File Offset: 0x000269B5
		public unsafe AnimationCurve saturationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x0018C2C0 File Offset: 0x0018A4C0
		// (set) Token: 0x06005480 RID: 21632 RVA: 0x000287D4 File Offset: 0x000269D4
		public unsafe float saturationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier)) = value;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x0018C2E8 File Offset: 0x0018A4E8
		// (set) Token: 0x06005482 RID: 21634 RVA: 0x000287EF File Offset: 0x000269EF
		public unsafe Material grassMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06005483 RID: 21635 RVA: 0x0018C318 File Offset: 0x0018A518
		// (set) Token: 0x06005484 RID: 21636 RVA: 0x0002880E File Offset: 0x00026A0E
		public unsafe Gradient grassColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x0018C348 File Offset: 0x0018A548
		// (set) Token: 0x06005486 RID: 21638 RVA: 0x0002882D File Offset: 0x00026A2D
		public unsafe Material distanceTreeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x0018C378 File Offset: 0x0018A578
		// (set) Token: 0x06005488 RID: 21640 RVA: 0x0002884C File Offset: 0x00026A4C
		public unsafe AnimationCurve distanceTreeColorCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x0018C3A8 File Offset: 0x0018A5A8
		// (set) Token: 0x0600548A RID: 21642 RVA: 0x0002886B File Offset: 0x00026A6B
		public unsafe AnimationCurve environmentalBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0018C3D8 File Offset: 0x0018A5D8
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x0002888A File Offset: 0x00026A8A
		public unsafe AnimationCurve bloomThreshholdCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x0018C408 File Offset: 0x0018A608
		// (set) Token: 0x0600548E RID: 21646 RVA: 0x000288A9 File Offset: 0x00026AA9
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x0018C430 File Offset: 0x0018A630
		// (set) Token: 0x06005490 RID: 21648 RVA: 0x000288C4 File Offset: 0x00026AC4
		public unsafe FloatSmoother FogEndDistanceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeFieldInfoPtr_windZone;

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDayController;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeFieldInfoPtr_HeightFog;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFog;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeFieldInfoPtr_SunLight;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeFieldInfoPtr_MoonLight;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeFieldInfoPtr_fogColorGradient;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceCurve;

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceMultiplier;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogColor;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityCurve;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityMultiplier;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogColor;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityCurve;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityMultiplier;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeFieldInfoPtr_godRayIntensityCurve;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeFieldInfoPtr_contrastCurve;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeFieldInfoPtr_contractMultiplier;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeFieldInfoPtr_saturationCurve;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeFieldInfoPtr_saturationMultiplier;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeFieldInfoPtr_grassMat;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeFieldInfoPtr_grassColorGradient;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeMat;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeColorCurve;

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeFieldInfoPtr_environmentalBrightnessCurve;

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeFieldInfoPtr_bloomThreshholdCurve;

		// Token: 0x04003938 RID: 14648
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04003939 RID: 14649
		private static readonly IntPtr NativeFieldInfoPtr_FogEndDistanceController;

		// Token: 0x0400393A RID: 14650
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0;

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
