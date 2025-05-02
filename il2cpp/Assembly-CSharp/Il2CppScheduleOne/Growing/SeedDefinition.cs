using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055E RID: 1374
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x060078C7 RID: 30919 RVA: 0x00209E90 File Offset: 0x00208090
		// Note: this type is marked as 'beforefieldinit'.
		static SeedDefinition()
		{
			Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr);
			SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "FunctionSeedPrefab");
			SeedDefinition.NativeFieldInfoPtr_PlantPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "PlantPrefab");
			SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, 100678441);
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x00209EFC File Offset: 0x002080FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232837, XrefRangeEnd = 232838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x0003952C File Offset: 0x0003772C
		public SeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x00209F38 File Offset: 0x00208138
		// (set) Token: 0x060078CB RID: 30923 RVA: 0x00039535 File Offset: 0x00037735
		public unsafe FunctionalSeed FunctionSeedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x00209F68 File Offset: 0x00208168
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x00039554 File Offset: 0x00037754
		public unsafe Plant PlantPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005244 RID: 21060
		private static readonly IntPtr NativeFieldInfoPtr_FunctionSeedPrefab;

		// Token: 0x04005245 RID: 21061
		private static readonly IntPtr NativeFieldInfoPtr_PlantPrefab;

		// Token: 0x04005246 RID: 21062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
