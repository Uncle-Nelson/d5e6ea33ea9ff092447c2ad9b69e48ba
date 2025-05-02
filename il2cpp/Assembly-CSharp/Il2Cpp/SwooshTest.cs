using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000040 RID: 64
	public class SwooshTest : MonoBehaviour
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x0007F8B4 File Offset: 0x0007DAB4
		// Note: this type is marked as 'beforefieldinit'.
		static SwooshTest()
		{
			Il2CppClassPointerStore<SwooshTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwooshTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr);
			SwooshTest.NativeFieldInfoPtr__animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_animation");
			SwooshTest.NativeFieldInfoPtr__animationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_animationState");
			SwooshTest.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_start");
			SwooshTest.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_end");
			SwooshTest.NativeFieldInfoPtr__startN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_startN");
			SwooshTest.NativeFieldInfoPtr__endN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_endN");
			SwooshTest.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_time");
			SwooshTest.NativeFieldInfoPtr__prevTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_prevTime");
			SwooshTest.NativeFieldInfoPtr__prevAnimTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_prevAnimTime");
			SwooshTest.NativeFieldInfoPtr__trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_trail");
			SwooshTest.NativeFieldInfoPtr__firstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, "_firstFrame");
			SwooshTest.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663739);
			SwooshTest.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663740);
			SwooshTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr, 100663741);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0007F9FC File Offset: 0x0007DBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74801, XrefRangeEnd = 74809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0007FA30 File Offset: 0x0007DC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74809, XrefRangeEnd = 74812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0007FA64 File Offset: 0x0007DC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74812, XrefRangeEnd = 74813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwooshTest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwooshTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwooshTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005258 File Offset: 0x00003458
		public SwooshTest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00005261 File Offset: 0x00003461
		public unsafe AnimationClip _animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0007FAD0 File Offset: 0x0007DCD0
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00005280 File Offset: 0x00003480
		public unsafe AnimationState _animationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animationState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__animationState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0007FB00 File Offset: 0x0007DD00
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0000529F File Offset: 0x0000349F
		public unsafe int _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__start)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0007FB28 File Offset: 0x0007DD28
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x000052BA File Offset: 0x000034BA
		public unsafe int _end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__end)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0007FB50 File Offset: 0x0007DD50
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000052D5 File Offset: 0x000034D5
		public unsafe float _startN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__startN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__startN)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0007FB78 File Offset: 0x0007DD78
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x000052F0 File Offset: 0x000034F0
		public unsafe float _endN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__endN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__endN)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0007FBA0 File Offset: 0x0007DDA0
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0000530B File Offset: 0x0000350B
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0007FBC8 File Offset: 0x0007DDC8
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00005326 File Offset: 0x00003526
		public unsafe float _prevTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevTime)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0007FBF0 File Offset: 0x0007DDF0
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00005341 File Offset: 0x00003541
		public unsafe float _prevAnimTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevAnimTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__prevAnimTime)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0007FC18 File Offset: 0x0007DE18
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0000535C File Offset: 0x0000355C
		public unsafe MeleeWeaponTrail _trail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__trail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeleeWeaponTrail>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__trail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0007FC48 File Offset: 0x0007DE48
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0000537B File Offset: 0x0000357B
		public unsafe bool _firstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__firstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwooshTest.NativeFieldInfoPtr__firstFrame)) = value;
			}
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr__animation;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr__animationState;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr__end;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr__startN;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr__endN;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr__prevTime;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr__prevAnimTime;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr__trail;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr__firstFrame;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
