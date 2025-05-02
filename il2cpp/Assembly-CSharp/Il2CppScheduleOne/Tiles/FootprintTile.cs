using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019A RID: 410
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x060021C3 RID: 8643 RVA: 0x000DA12C File Offset: 0x000D832C
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintTile()
		{
			Il2CppClassPointerStore<FootprintTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "FootprintTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr);
			FootprintTile.NativeFieldInfoPtr_tileAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileAppearance");
			FootprintTile.NativeFieldInfoPtr_tileDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileDetector");
			FootprintTile.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "X");
			FootprintTile.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Y");
			FootprintTile.NativeFieldInfoPtr_RequiredOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "RequiredOffset");
			FootprintTile.NativeFieldInfoPtr_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Corners");
			FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "<MatchedStandardTile>k__BackingField");
			FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667111);
			FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667112);
			FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667113);
			FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667114);
			FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667115);
			FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100667116);
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x000DA260 File Offset: 0x000D8460
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x000DA2A0 File Offset: 0x000D84A0
		public unsafe Tile MatchedStandardTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110783, XrefRangeEnd = 110784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000DA2E4 File Offset: 0x000D84E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110784, XrefRangeEnd = 110786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000DA320 File Offset: 0x000D8520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Tile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000DA370 File Offset: 0x000D8570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110858, RefRangeEnd = 110859, XrefRangeStart = 110786, XrefRangeEnd = 110858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(proposedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000DA3C0 File Offset: 0x000D85C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110859, XrefRangeEnd = 110867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00012D69 File Offset: 0x00010F69
		public FootprintTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000DA3FC File Offset: 0x000D85FC
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00012D72 File Offset: 0x00010F72
		public unsafe TileAppearance tileAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000DA42C File Offset: 0x000D862C
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00012D91 File Offset: 0x00010F91
		public unsafe TileDetector tileDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000DA45C File Offset: 0x000D865C
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00012DB0 File Offset: 0x00010FB0
		public unsafe int X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000DA484 File Offset: 0x000D8684
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00012DCB File Offset: 0x00010FCB
		public unsafe int Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000DA4AC File Offset: 0x000D86AC
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00012DE6 File Offset: 0x00010FE6
		public unsafe float RequiredOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset)) = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000DA4D4 File Offset: 0x000D86D4
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00012E01 File Offset: 0x00011001
		public unsafe List<CornerObstacle> Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CornerObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000DA504 File Offset: 0x000D8704
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00012E20 File Offset: 0x00011020
		public unsafe Tile _MatchedStandardTile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeFieldInfoPtr_tileAppearance;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeFieldInfoPtr_tileDetector;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr_RequiredOffset;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeFieldInfoPtr_Corners;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeFieldInfoPtr__MatchedStandardTile_k__BackingField;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
