using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000778 RID: 1912
	[Serializable]
	public class MapRegionData : Il2CppSystem.Object
	{
		// Token: 0x0600B534 RID: 46388 RVA: 0x002D13F4 File Offset: 0x002CF5F4
		// Note: this type is marked as 'beforefieldinit'.
		static MapRegionData()
		{
			Il2CppClassPointerStore<MapRegionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapRegionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr);
			MapRegionData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Region");
			MapRegionData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Name");
			MapRegionData.NativeFieldInfoPtr_RankRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RankRequirement");
			MapRegionData.NativeFieldInfoPtr_StartingNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "StartingNPCs");
			MapRegionData.NativeFieldInfoPtr_RegionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionSprite");
			MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionDeliveryLocations");
			MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685585);
			MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685586);
			MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685587);
			MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100685588);
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600B535 RID: 46389 RVA: 0x002D14EC File Offset: 0x002CF6EC
		public unsafe bool IsUnlocked
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310313, XrefRangeStart = 310305, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x002D1528 File Offset: 0x002CF728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310342, RefRangeEnd = 310343, XrefRangeStart = 310313, XrefRangeEnd = 310342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x002D1568 File Offset: 0x002CF768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310344, RefRangeEnd = 310346, XrefRangeStart = 310343, XrefRangeEnd = 310344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x002D159C File Offset: 0x002CF79C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x00058E55 File Offset: 0x00057055
		public MapRegionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600B53A RID: 46394 RVA: 0x002D15D8 File Offset: 0x002CF7D8
		// (set) Token: 0x0600B53B RID: 46395 RVA: 0x00058E5E File Offset: 0x0005705E
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600B53C RID: 46396 RVA: 0x002D1600 File Offset: 0x002CF800
		// (set) Token: 0x0600B53D RID: 46397 RVA: 0x00058E79 File Offset: 0x00057079
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x002D1628 File Offset: 0x002CF828
		// (set) Token: 0x0600B53F RID: 46399 RVA: 0x00058E98 File Offset: 0x00057098
		public unsafe FullRank RankRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement)) = value;
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600B540 RID: 46400 RVA: 0x002D1650 File Offset: 0x002CF850
		// (set) Token: 0x0600B541 RID: 46401 RVA: 0x00058EB3 File Offset: 0x000570B3
		public unsafe Il2CppReferenceArray<NPC> StartingNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600B542 RID: 46402 RVA: 0x002D1680 File Offset: 0x002CF880
		// (set) Token: 0x0600B543 RID: 46403 RVA: 0x00058ED2 File Offset: 0x000570D2
		public unsafe Sprite RegionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600B544 RID: 46404 RVA: 0x002D16B0 File Offset: 0x002CF8B0
		// (set) Token: 0x0600B545 RID: 46405 RVA: 0x00058EF1 File Offset: 0x000570F1
		public unsafe Il2CppReferenceArray<DeliveryLocation> RegionDeliveryLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A25 RID: 31269
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x04007A26 RID: 31270
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04007A27 RID: 31271
		private static readonly IntPtr NativeFieldInfoPtr_RankRequirement;

		// Token: 0x04007A28 RID: 31272
		private static readonly IntPtr NativeFieldInfoPtr_StartingNPCs;

		// Token: 0x04007A29 RID: 31273
		private static readonly IntPtr NativeFieldInfoPtr_RegionSprite;

		// Token: 0x04007A2A RID: 31274
		private static readonly IntPtr NativeFieldInfoPtr_RegionDeliveryLocations;

		// Token: 0x04007A2B RID: 31275
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

		// Token: 0x04007A2C RID: 31276
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0;

		// Token: 0x04007A2D RID: 31277
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_0;

		// Token: 0x04007A2E RID: 31278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFB RID: 3067
		[ObfuscatedName("ScheduleOne.Map.MapRegionData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFD8 RID: 57304 RVA: 0x0034BAEC File Offset: 0x00349CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr);
				MapRegionData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9");
				MapRegionData.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9__8_0");
				MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100685590);
				MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100685591);
			}

			// Token: 0x0600DFD9 RID: 57305 RVA: 0x0034BB68 File Offset: 0x00349D68
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFDA RID: 57306 RVA: 0x0034BBA4 File Offset: 0x00349DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310304, XrefRangeEnd = 310305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomUnscheduledDeliveryLocation_b__8_0(DeliveryLocation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFDB RID: 57307 RVA: 0x0006D28B File Offset: 0x0006B48B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x0034BBF4 File Offset: 0x00349DF4
			// (set) Token: 0x0600DFDD RID: 57309 RVA: 0x0006D294 File Offset: 0x0006B494
			public unsafe static MapRegionData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapRegionData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x0034BC1C File Offset: 0x00349E1C
			// (set) Token: 0x0600DFDF RID: 57311 RVA: 0x0006D2A6 File Offset: 0x0006B4A6
			public unsafe static Func<DeliveryLocation, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryLocation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095EB RID: 38379
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095EC RID: 38380
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040095ED RID: 38381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095EE RID: 38382
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0;
		}
	}
}
