using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057E RID: 1406
	[Serializable]
	public sealed class CoordinateStorageFootprintTilePair : ValueType
	{
		// Token: 0x06007BB6 RID: 31670 RVA: 0x002147B4 File Offset: 0x002129B4
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr);
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x0003AB71 File Offset: 0x00038D71
		public CoordinateStorageFootprintTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x0003AB7A File Offset: 0x00038D7A
		public CoordinateStorageFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x0021480C File Offset: 0x00212A0C
		// (set) Token: 0x06007BBA RID: 31674 RVA: 0x0003AB8C File Offset: 0x00038D8C
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0021483C File Offset: 0x00212A3C
		// (set) Token: 0x06007BBC RID: 31676 RVA: 0x0003ABAB File Offset: 0x00038DAB
		public unsafe FootprintTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400543D RID: 21565
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400543E RID: 21566
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
