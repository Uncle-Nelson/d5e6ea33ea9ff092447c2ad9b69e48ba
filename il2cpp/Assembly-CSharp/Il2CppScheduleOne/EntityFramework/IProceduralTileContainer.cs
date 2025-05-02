using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FF RID: 1023
	public class IProceduralTileContainer : Il2CppObjectBase
	{
		// Token: 0x060055BE RID: 21950 RVA: 0x00029124 File Offset: 0x00027324
		// Note: this type is marked as 'beforefieldinit'.
		static IProceduralTileContainer()
		{
			Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "IProceduralTileContainer");
			IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr, 100673992);
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x00190D40 File Offset: 0x0018EF40
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00029153 File Offset: 0x00027353
		public IProceduralTileContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0;
	}
}
