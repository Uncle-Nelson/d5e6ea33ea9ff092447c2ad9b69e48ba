using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C2 RID: 1218
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x06006AC2 RID: 27330 RVA: 0x001DC99C File Offset: 0x001DAB9C
		// Note: this type is marked as 'beforefieldinit'.
		static CornerObstacle()
		{
			Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "CornerObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr);
			CornerObstacle.NativeFieldInfoPtr_obstacleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "obstacleEnabled");
			CornerObstacle.NativeFieldInfoPtr_parentFootprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "parentFootprint");
			CornerObstacle.NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "coordinates");
			CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676832);
			CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676833);
			CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676834);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x001DCA44 File Offset: 0x001DAC44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215463, RefRangeEnd = 215465, XrefRangeStart = 215433, XrefRangeEnd = 215463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr3) : null;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x001DCA94 File Offset: 0x001DAC94
		[CallerCount(0)]
		public unsafe bool ApproxEquals(float a, float b, float precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001DCAFC File Offset: 0x001DACFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215465, XrefRangeEnd = 215468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0003278D File Offset: 0x0003098D
		public CornerObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x001DCB38 File Offset: 0x001DAD38
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x00032796 File Offset: 0x00030996
		public unsafe bool obstacleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled)) = value;
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x001DCB60 File Offset: 0x001DAD60
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x000327B1 File Offset: 0x000309B1
		public unsafe FootprintTile parentFootprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x001DCB90 File Offset: 0x001DAD90
		// (set) Token: 0x06006ACC RID: 27340 RVA: 0x000327D0 File Offset: 0x000309D0
		public unsafe Vector2 coordinates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates)) = value;
			}
		}

		// Token: 0x04004912 RID: 18706
		private static readonly IntPtr NativeFieldInfoPtr_obstacleEnabled;

		// Token: 0x04004913 RID: 18707
		private static readonly IntPtr NativeFieldInfoPtr_parentFootprint;

		// Token: 0x04004914 RID: 18708
		private static readonly IntPtr NativeFieldInfoPtr_coordinates;

		// Token: 0x04004915 RID: 18709
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0;

		// Token: 0x04004916 RID: 18710
		private static readonly IntPtr NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0;

		// Token: 0x04004917 RID: 18711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
