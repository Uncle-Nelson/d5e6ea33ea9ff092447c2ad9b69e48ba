using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000578 RID: 1400
	[Serializable]
	public sealed class CoordinateStorageTilePair : ValueType
	{
		// Token: 0x06007B40 RID: 31552 RVA: 0x00212E34 File Offset: 0x00211034
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr);
			CoordinateStorageTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "coord");
			CoordinateStorageTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0003A7E0 File Offset: 0x000389E0
		public CoordinateStorageTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0003A7E9 File Offset: 0x000389E9
		public CoordinateStorageTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06007B43 RID: 31555 RVA: 0x00212E8C File Offset: 0x0021108C
		// (set) Token: 0x06007B44 RID: 31556 RVA: 0x0003A7FB File Offset: 0x000389FB
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06007B45 RID: 31557 RVA: 0x00212EBC File Offset: 0x002110BC
		// (set) Token: 0x06007B46 RID: 31558 RVA: 0x0003A81A File Offset: 0x00038A1A
		public unsafe StorageTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053EF RID: 21487
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040053F0 RID: 21488
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
