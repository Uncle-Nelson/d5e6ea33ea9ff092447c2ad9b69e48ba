using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000670 RID: 1648
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x06009310 RID: 37648 RVA: 0x0025E300 File Offset: 0x0025C500
		// Note: this type is marked as 'beforefieldinit'.
		static UISpawner()
		{
			Il2CppClassPointerStore<UISpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UISpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpawner>.NativeClassPtr);
			UISpawner.NativeFieldInfoPtr_SpawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnArea");
			UISpawner.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "Prefabs");
			UISpawner.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinInterval");
			UISpawner.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxInterval");
			UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnRateMultiplier");
			UISpawner.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinScale");
			UISpawner.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxScale");
			UISpawner.NativeFieldInfoPtr_UniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "UniformScale");
			UISpawner.NativeFieldInfoPtr_nextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "nextSpawnTime");
			UISpawner.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "OnSpawn");
			UISpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681536);
			UISpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681537);
			UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681538);
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x0025E434 File Offset: 0x0025C634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265286, XrefRangeEnd = 265288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x0025E468 File Offset: 0x0025C668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265288, XrefRangeEnd = 265317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x0025E49C File Offset: 0x0025C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265317, XrefRangeEnd = 265322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISpawner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x0004736E File Offset: 0x0004556E
		public UISpawner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x0025E4D8 File Offset: 0x0025C6D8
		// (set) Token: 0x06009316 RID: 37654 RVA: 0x00047377 File Offset: 0x00045577
		public unsafe RectTransform SpawnArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x0025E508 File Offset: 0x0025C708
		// (set) Token: 0x06009318 RID: 37656 RVA: 0x00047396 File Offset: 0x00045596
		public unsafe Il2CppReferenceArray<GameObject> Prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x06009319 RID: 37657 RVA: 0x0025E538 File Offset: 0x0025C738
		// (set) Token: 0x0600931A RID: 37658 RVA: 0x000473B5 File Offset: 0x000455B5
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600931B RID: 37659 RVA: 0x0025E560 File Offset: 0x0025C760
		// (set) Token: 0x0600931C RID: 37660 RVA: 0x000473D0 File Offset: 0x000455D0
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600931D RID: 37661 RVA: 0x0025E588 File Offset: 0x0025C788
		// (set) Token: 0x0600931E RID: 37662 RVA: 0x000473EB File Offset: 0x000455EB
		public unsafe float SpawnRateMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier)) = value;
			}
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600931F RID: 37663 RVA: 0x0025E5B0 File Offset: 0x0025C7B0
		// (set) Token: 0x06009320 RID: 37664 RVA: 0x00047406 File Offset: 0x00045606
		public unsafe Vector2 MinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale)) = value;
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x06009321 RID: 37665 RVA: 0x0025E5D8 File Offset: 0x0025C7D8
		// (set) Token: 0x06009322 RID: 37666 RVA: 0x00047421 File Offset: 0x00045621
		public unsafe Vector2 MaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale)) = value;
			}
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x0025E600 File Offset: 0x0025C800
		// (set) Token: 0x06009324 RID: 37668 RVA: 0x0004743C File Offset: 0x0004563C
		public unsafe bool UniformScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale)) = value;
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x0025E628 File Offset: 0x0025C828
		// (set) Token: 0x06009326 RID: 37670 RVA: 0x00047457 File Offset: 0x00045657
		public unsafe float nextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime)) = value;
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x06009327 RID: 37671 RVA: 0x0025E650 File Offset: 0x0025C850
		// (set) Token: 0x06009328 RID: 37672 RVA: 0x00047472 File Offset: 0x00045672
		public unsafe UnityEvent<GameObject> OnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400634E RID: 25422
		private static readonly IntPtr NativeFieldInfoPtr_SpawnArea;

		// Token: 0x0400634F RID: 25423
		private static readonly IntPtr NativeFieldInfoPtr_Prefabs;

		// Token: 0x04006350 RID: 25424
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04006351 RID: 25425
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04006352 RID: 25426
		private static readonly IntPtr NativeFieldInfoPtr_SpawnRateMultiplier;

		// Token: 0x04006353 RID: 25427
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x04006354 RID: 25428
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x04006355 RID: 25429
		private static readonly IntPtr NativeFieldInfoPtr_UniformScale;

		// Token: 0x04006356 RID: 25430
		private static readonly IntPtr NativeFieldInfoPtr_nextSpawnTime;

		// Token: 0x04006357 RID: 25431
		private static readonly IntPtr NativeFieldInfoPtr_OnSpawn;

		// Token: 0x04006358 RID: 25432
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006359 RID: 25433
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400635A RID: 25434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
