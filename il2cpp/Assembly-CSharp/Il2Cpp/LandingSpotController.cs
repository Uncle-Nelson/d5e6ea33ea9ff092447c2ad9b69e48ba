using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003D RID: 61
	public class LandingSpotController : MonoBehaviour
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x0007EEE0 File Offset: 0x0007D0E0
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpotController()
		{
			Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpotController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr);
			LandingSpotController.NativeFieldInfoPtr__randomRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_randomRotate");
			LandingSpotController.NativeFieldInfoPtr__autoCatchDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoCatchDelay");
			LandingSpotController.NativeFieldInfoPtr__autoDismountDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoDismountDelay");
			LandingSpotController.NativeFieldInfoPtr__maxBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_maxBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__minBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_minBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__takeClosest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_takeClosest");
			LandingSpotController.NativeFieldInfoPtr__flock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_flock");
			LandingSpotController.NativeFieldInfoPtr__landOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landOnStart");
			LandingSpotController.NativeFieldInfoPtr__soarLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_soarLand");
			LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_onlyBirdsAbove");
			LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingTurnSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__featherPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_featherPS");
			LandingSpotController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_thisT");
			LandingSpotController.NativeFieldInfoPtr__activeLandingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_activeLandingSpots");
			LandingSpotController.NativeFieldInfoPtr__snapLandDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_snapLandDistance");
			LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landedRotateSpeed");
			LandingSpotController.NativeFieldInfoPtr__gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_gizmoSize");
			LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663715);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663716);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663717);
			LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663718);
			LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663719);
			LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663720);
			LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663721);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0007F104 File Offset: 0x0007D304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74689, XrefRangeEnd = 74725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0007F138 File Offset: 0x0007D338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74742, RefRangeEnd = 74744, XrefRangeStart = 74725, XrefRangeEnd = 74742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0007F16C File Offset: 0x0007D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74744, XrefRangeEnd = 74761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0007F1B8 File Offset: 0x0007D3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74761, XrefRangeEnd = 74776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LandAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0007F1EC File Offset: 0x0007D3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74776, XrefRangeEnd = 74781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLandOnStart(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0007F238 File Offset: 0x0007D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74781, XrefRangeEnd = 74786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLand(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0007F284 File Offset: 0x0007D484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74786, XrefRangeEnd = 74787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpotController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004FC0 File Offset: 0x000031C0
		public LandingSpotController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0007F2C0 File Offset: 0x0007D4C0
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00004FC9 File Offset: 0x000031C9
		public unsafe bool _randomRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0007F2E8 File Offset: 0x0007D4E8
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00004FE4 File Offset: 0x000031E4
		public unsafe Vector2 _autoCatchDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0007F310 File Offset: 0x0007D510
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00004FFF File Offset: 0x000031FF
		public unsafe Vector2 _autoDismountDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0007F338 File Offset: 0x0007D538
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x0000501A File Offset: 0x0000321A
		public unsafe float _maxBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0007F360 File Offset: 0x0007D560
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00005035 File Offset: 0x00003235
		public unsafe float _minBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0007F388 File Offset: 0x0007D588
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00005050 File Offset: 0x00003250
		public unsafe bool _takeClosest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000506B File Offset: 0x0000326B
		public unsafe FlockController _flock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0007F3E0 File Offset: 0x0007D5E0
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000508A File Offset: 0x0000328A
		public unsafe bool _landOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0007F408 File Offset: 0x0007D608
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000050A5 File Offset: 0x000032A5
		public unsafe bool _soarLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand)) = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0007F430 File Offset: 0x0007D630
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x000050C0 File Offset: 0x000032C0
		public unsafe bool _onlyBirdsAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove)) = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0007F458 File Offset: 0x0007D658
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000050DB File Offset: 0x000032DB
		public unsafe float _landingSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier)) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0007F480 File Offset: 0x0007D680
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x000050F6 File Offset: 0x000032F6
		public unsafe float _landingTurnSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00005111 File Offset: 0x00003311
		public unsafe Transform _featherPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0007F4D8 File Offset: 0x0007D6D8
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00005130 File Offset: 0x00003330
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0007F508 File Offset: 0x0007D708
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0000514F File Offset: 0x0000334F
		public unsafe int _activeLandingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0007F530 File Offset: 0x0007D730
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000516A File Offset: 0x0000336A
		public unsafe float _snapLandDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0007F558 File Offset: 0x0007D758
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00005185 File Offset: 0x00003385
		public unsafe float _landedRotateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0007F580 File Offset: 0x0007D780
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x000051A0 File Offset: 0x000033A0
		public unsafe float _gizmoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize)) = value;
			}
		}

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr__randomRotate;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr__autoCatchDelay;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr__autoDismountDelay;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr__maxBirdDistance;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr__minBirdDistance;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr__takeClosest;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr__flock;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr__landOnStart;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr__soarLand;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr__onlyBirdsAbove;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr__landingSpeedModifier;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr__landingTurnSpeedModifier;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr__featherPS;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr__activeLandingSpots;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr__snapLandDistance;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr__landedRotateSpeed;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr__gizmoSize;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_LandAll_Public_Void_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B5 RID: 1973
		[ObfuscatedName("LandingSpotController+<InstantLand>d__23")]
		public sealed class _InstantLand_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600B9E5 RID: 47589 RVA: 0x002E204C File Offset: 0x002E024C
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLand_d__23()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLand>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr);
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "delay");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663722);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663723);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663724);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663725);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663726);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663727);
			}

			// Token: 0x0600B9E6 RID: 47590 RVA: 0x002E2140 File Offset: 0x002E0340
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLand_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9E7 RID: 47591 RVA: 0x002E2188 File Offset: 0x002E0388
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9E8 RID: 47592 RVA: 0x002E21BC File Offset: 0x002E03BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74665, XrefRangeEnd = 74672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003960 RID: 14688
			// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002E21F8 File Offset: 0x002E03F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9EA RID: 47594 RVA: 0x002E2238 File Offset: 0x002E0438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74672, XrefRangeEnd = 74677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003961 RID: 14689
			// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x002E226C File Offset: 0x002E046C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9EC RID: 47596 RVA: 0x0005AE2D File Offset: 0x0005902D
			public _InstantLand_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700395C RID: 14684
			// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x002E22AC File Offset: 0x002E04AC
			// (set) Token: 0x0600B9EE RID: 47598 RVA: 0x0005AE36 File Offset: 0x00059036
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700395D RID: 14685
			// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x002E22D4 File Offset: 0x002E04D4
			// (set) Token: 0x0600B9F0 RID: 47600 RVA: 0x0005AE51 File Offset: 0x00059051
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700395E RID: 14686
			// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x002E2304 File Offset: 0x002E0504
			// (set) Token: 0x0600B9F2 RID: 47602 RVA: 0x0005AE70 File Offset: 0x00059070
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700395F RID: 14687
			// (get) Token: 0x0600B9F3 RID: 47603 RVA: 0x002E232C File Offset: 0x002E052C
			// (set) Token: 0x0600B9F4 RID: 47604 RVA: 0x0005AE8B File Offset: 0x0005908B
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D61 RID: 32097
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D62 RID: 32098
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D63 RID: 32099
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04007D64 RID: 32100
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D65 RID: 32101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D66 RID: 32102
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D67 RID: 32103
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D68 RID: 32104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D69 RID: 32105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D6A RID: 32106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007B6 RID: 1974
		[ObfuscatedName("LandingSpotController+<InstantLandOnStart>d__22")]
		public sealed class _InstantLandOnStart_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600B9F5 RID: 47605 RVA: 0x002E235C File Offset: 0x002E055C
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLandOnStart_d__22()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLandOnStart>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr);
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "delay");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663728);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663729);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663730);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663731);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663732);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663733);
			}

			// Token: 0x0600B9F6 RID: 47606 RVA: 0x002E2450 File Offset: 0x002E0650
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLandOnStart_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9F7 RID: 47607 RVA: 0x002E2498 File Offset: 0x002E0698
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9F8 RID: 47608 RVA: 0x002E24CC File Offset: 0x002E06CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74677, XrefRangeEnd = 74684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003966 RID: 14694
			// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x002E2508 File Offset: 0x002E0708
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9FA RID: 47610 RVA: 0x002E2548 File Offset: 0x002E0748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74684, XrefRangeEnd = 74689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003967 RID: 14695
			// (get) Token: 0x0600B9FB RID: 47611 RVA: 0x002E257C File Offset: 0x002E077C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9FC RID: 47612 RVA: 0x0005AEAA File Offset: 0x000590AA
			public _InstantLandOnStart_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003962 RID: 14690
			// (get) Token: 0x0600B9FD RID: 47613 RVA: 0x002E25BC File Offset: 0x002E07BC
			// (set) Token: 0x0600B9FE RID: 47614 RVA: 0x0005AEB3 File Offset: 0x000590B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003963 RID: 14691
			// (get) Token: 0x0600B9FF RID: 47615 RVA: 0x002E25E4 File Offset: 0x002E07E4
			// (set) Token: 0x0600BA00 RID: 47616 RVA: 0x0005AECE File Offset: 0x000590CE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003964 RID: 14692
			// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x002E2614 File Offset: 0x002E0814
			// (set) Token: 0x0600BA02 RID: 47618 RVA: 0x0005AEED File Offset: 0x000590ED
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003965 RID: 14693
			// (get) Token: 0x0600BA03 RID: 47619 RVA: 0x002E263C File Offset: 0x002E083C
			// (set) Token: 0x0600BA04 RID: 47620 RVA: 0x0005AF08 File Offset: 0x00059108
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D6B RID: 32107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D6C RID: 32108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D6D RID: 32109
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04007D6E RID: 32110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D6F RID: 32111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D70 RID: 32112
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D71 RID: 32113
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D72 RID: 32114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D73 RID: 32115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D74 RID: 32116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
