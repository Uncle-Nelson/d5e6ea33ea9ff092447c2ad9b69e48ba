using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077C RID: 1916
	public class Map : Singleton<Map>
	{
		// Token: 0x0600B592 RID: 46482 RVA: 0x002D2344 File Offset: 0x002D0544
		// Note: this type is marked as 'beforefieldinit'.
		static Map()
		{
			Il2CppClassPointerStore<Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map>.NativeClassPtr);
			Map.NativeFieldInfoPtr_Regions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "Regions");
			Map.NativeFieldInfoPtr_PoliceStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "PoliceStation");
			Map.NativeFieldInfoPtr_MedicalCentre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "MedicalCentre");
			Map.NativeFieldInfoPtr_TreeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "TreeBounds");
			Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685610);
			Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685611);
			Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685612);
			Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685613);
			Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685614);
			Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685615);
			Map.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100685616);
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x002D2450 File Offset: 0x002D0650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310442, XrefRangeEnd = 310502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x002D248C File Offset: 0x002D068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310502, XrefRangeEnd = 310536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B595 RID: 46485 RVA: 0x002D24C8 File Offset: 0x002D06C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310536, XrefRangeEnd = 310554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B596 RID: 46486 RVA: 0x002D2504 File Offset: 0x002D0704
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 310568, RefRangeEnd = 310574, XrefRangeStart = 310554, XrefRangeEnd = 310568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData GetRegionData(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapRegionData>(intPtr3) : null;
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x002D2550 File Offset: 0x002D0750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310574, XrefRangeEnd = 310585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x002D2584 File Offset: 0x002D0784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310585, XrefRangeEnd = 310596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x002D25D0 File Offset: 0x002D07D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310596, XrefRangeEnd = 310599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Map() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x00059203 File Offset: 0x00057403
		public Map(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600B59B RID: 46491 RVA: 0x002D260C File Offset: 0x002D080C
		// (set) Token: 0x0600B59C RID: 46492 RVA: 0x0005920C File Offset: 0x0005740C
		public unsafe Il2CppReferenceArray<MapRegionData> Regions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapRegionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B59D RID: 46493 RVA: 0x002D263C File Offset: 0x002D083C
		// (set) Token: 0x0600B59E RID: 46494 RVA: 0x0005922B File Offset: 0x0005742B
		public unsafe PoliceStation PoliceStation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B59F RID: 46495 RVA: 0x002D266C File Offset: 0x002D086C
		// (set) Token: 0x0600B5A0 RID: 46496 RVA: 0x0005924A File Offset: 0x0005744A
		public unsafe MedicalCentre MedicalCentre
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MedicalCentre>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B5A1 RID: 46497 RVA: 0x002D269C File Offset: 0x002D089C
		// (set) Token: 0x0600B5A2 RID: 46498 RVA: 0x00059269 File Offset: 0x00057469
		public unsafe Transform TreeBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A5B RID: 31323
		private static readonly IntPtr NativeFieldInfoPtr_Regions;

		// Token: 0x04007A5C RID: 31324
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStation;

		// Token: 0x04007A5D RID: 31325
		private static readonly IntPtr NativeFieldInfoPtr_MedicalCentre;

		// Token: 0x04007A5E RID: 31326
		private static readonly IntPtr NativeFieldInfoPtr_TreeBounds;

		// Token: 0x04007A5F RID: 31327
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A60 RID: 31328
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A61 RID: 31329
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007A62 RID: 31330
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0;

		// Token: 0x04007A63 RID: 31331
		private static readonly IntPtr NativeMethodInfoPtr_GameLoaded_Private_Void_0;

		// Token: 0x04007A64 RID: 31332
		private static readonly IntPtr NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0;

		// Token: 0x04007A65 RID: 31333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFC RID: 3068
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE0 RID: 57312 RVA: 0x0034BC44 File Offset: 0x00349E44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr);
				Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100685617);
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100685618);
			}

			// Token: 0x0600DFE1 RID: 57313 RVA: 0x0034BCAC File Offset: 0x00349EAC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE2 RID: 57314 RVA: 0x0034BCE8 File Offset: 0x00349EE8
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFE3 RID: 57315 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x0034BD38 File Offset: 0x00349F38
			// (set) Token: 0x0600DFE5 RID: 57317 RVA: 0x0006D2C1 File Offset: 0x0006B4C1
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040095EF RID: 38383
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040095F0 RID: 38384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095F1 RID: 38385
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0;
		}

		// Token: 0x02000BFD RID: 3069
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE6 RID: 57318 RVA: 0x0034BD60 File Offset: 0x00349F60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr);
				Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100685619);
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100685620);
			}

			// Token: 0x0600DFE7 RID: 57319 RVA: 0x0034BDC8 File Offset: 0x00349FC8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE8 RID: 57320 RVA: 0x0034BE04 File Offset: 0x0034A004
			[CallerCount(0)]
			public unsafe bool _GetRegionData_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFE9 RID: 57321 RVA: 0x0006D2DC File Offset: 0x0006B4DC
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004561 RID: 17761
			// (get) Token: 0x0600DFEA RID: 57322 RVA: 0x0034BE54 File Offset: 0x0034A054
			// (set) Token: 0x0600DFEB RID: 57323 RVA: 0x0006D2E5 File Offset: 0x0006B4E5
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040095F2 RID: 38386
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040095F3 RID: 38387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095F4 RID: 38388
			private static readonly IntPtr NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0;
		}
	}
}
