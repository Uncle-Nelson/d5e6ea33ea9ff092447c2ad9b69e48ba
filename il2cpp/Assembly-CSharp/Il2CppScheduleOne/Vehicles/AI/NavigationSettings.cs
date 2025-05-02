using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FE RID: 1278
	public class NavigationSettings : Object
	{
		// Token: 0x060070DA RID: 28890 RVA: 0x001EFB50 File Offset: 0x001EDD50
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSettings()
		{
			Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr);
			NavigationSettings.NativeFieldInfoPtr_endAtRoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "endAtRoad");
			NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "ensureProximityToGraph");
			NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "teleportToGraphIfCalculationFails");
			NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, 100677467);
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x001EFBD0 File Offset: 0x001EDDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222031, XrefRangeEnd = 222032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x00035999 File Offset: 0x00033B99
		public NavigationSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x001EFC0C File Offset: 0x001EDE0C
		// (set) Token: 0x060070DE RID: 28894 RVA: 0x000359A2 File Offset: 0x00033BA2
		public unsafe bool endAtRoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad)) = value;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x001EFC34 File Offset: 0x001EDE34
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x000359BD File Offset: 0x00033BBD
		public unsafe bool ensureProximityToGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph)) = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x001EFC5C File Offset: 0x001EDE5C
		// (set) Token: 0x060070E2 RID: 28898 RVA: 0x000359D8 File Offset: 0x00033BD8
		public unsafe bool teleportToGraphIfCalculationFails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails)) = value;
			}
		}

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeFieldInfoPtr_endAtRoad;

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeFieldInfoPtr_ensureProximityToGraph;

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeFieldInfoPtr_teleportToGraphIfCalculationFails;

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
