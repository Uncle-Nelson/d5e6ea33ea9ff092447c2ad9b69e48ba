using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055B RID: 1371
	public class PlantGrowthStage : MonoBehaviour
	{
		// Token: 0x060078AE RID: 30894 RVA: 0x00209AA0 File Offset: 0x00207CA0
		// Note: this type is marked as 'beforefieldinit'.
		static PlantGrowthStage()
		{
			Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantGrowthStage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr);
			PlantGrowthStage.NativeFieldInfoPtr_GrowthSites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, "GrowthSites");
			PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, 100678436);
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00209AF8 File Offset: 0x00207CF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantGrowthStage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00039455 File Offset: 0x00037655
		public PlantGrowthStage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x00209B34 File Offset: 0x00207D34
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x0003945E File Offset: 0x0003765E
		public unsafe Il2CppReferenceArray<Transform> GrowthSites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005238 RID: 21048
		private static readonly IntPtr NativeFieldInfoPtr_GrowthSites;

		// Token: 0x04005239 RID: 21049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
