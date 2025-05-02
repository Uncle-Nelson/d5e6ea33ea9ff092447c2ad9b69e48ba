using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055C RID: 1372
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x060078B3 RID: 30899 RVA: 0x00209B64 File Offset: 0x00207D64
		// Note: this type is marked as 'beforefieldinit'.
		static PlantHarvestable()
		{
			Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantHarvestable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr);
			PlantHarvestable.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "Product");
			PlantHarvestable.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "ProductQuantity");
			PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678437);
			PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678438);
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x00209BE4 File Offset: 0x00207DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232751, XrefRangeEnd = 232834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Harvest(bool giveProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref giveProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x00209C30 File Offset: 0x00207E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232834, XrefRangeEnd = 232835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x0003947D File Offset: 0x0003767D
		public PlantHarvestable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x00209C6C File Offset: 0x00207E6C
		// (set) Token: 0x060078B8 RID: 30904 RVA: 0x00039486 File Offset: 0x00037686
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x060078B9 RID: 30905 RVA: 0x00209C9C File Offset: 0x00207E9C
		// (set) Token: 0x060078BA RID: 30906 RVA: 0x000394A5 File Offset: 0x000376A5
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x0400523A RID: 21050
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x0400523B RID: 21051
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x0400523C RID: 21052
		private static readonly IntPtr NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400523D RID: 21053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
