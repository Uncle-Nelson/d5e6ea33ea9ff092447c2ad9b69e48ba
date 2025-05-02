using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000196 RID: 406
	[Serializable]
	public sealed class CoordinateTilePair : ValueType
	{
		// Token: 0x060021A4 RID: 8612 RVA: 0x000D9D44 File Offset: 0x000D7F44
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateTilePair()
		{
			Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr);
			CoordinateTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "coord");
			CoordinateTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00012BFC File Offset: 0x00010DFC
		public CoordinateTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00012C05 File Offset: 0x00010E05
		public CoordinateTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x000D9D9C File Offset: 0x000D7F9C
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00012C17 File Offset: 0x00010E17
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x000D9DCC File Offset: 0x000D7FCC
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00012C36 File Offset: 0x00010E36
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
