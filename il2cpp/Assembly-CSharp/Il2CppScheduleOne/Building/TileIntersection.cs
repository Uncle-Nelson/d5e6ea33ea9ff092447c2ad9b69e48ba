using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BD RID: 1213
	public class TileIntersection : Object
	{
		// Token: 0x06006A32 RID: 27186 RVA: 0x001DAF6C File Offset: 0x001D916C
		// Note: this type is marked as 'beforefieldinit'.
		static TileIntersection()
		{
			Il2CppClassPointerStore<TileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "TileIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr);
			TileIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "footprint");
			TileIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "tile");
			TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100676786);
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x001DAFD8 File Offset: 0x001D91D8
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00032249 File Offset: 0x00030449
		public TileIntersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06006A35 RID: 27189 RVA: 0x001DB014 File Offset: 0x001D9214
		// (set) Token: 0x06006A36 RID: 27190 RVA: 0x00032252 File Offset: 0x00030452
		public unsafe FootprintTile footprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x001DB044 File Offset: 0x001D9244
		// (set) Token: 0x06006A38 RID: 27192 RVA: 0x00032271 File Offset: 0x00030471
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048B9 RID: 18617
		private static readonly IntPtr NativeFieldInfoPtr_footprint;

		// Token: 0x040048BA RID: 18618
		private static readonly IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x040048BB RID: 18619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
