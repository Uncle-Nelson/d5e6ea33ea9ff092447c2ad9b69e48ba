using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000559 RID: 1369
	public class CocaPlant : Plant
	{
		// Token: 0x0600786F RID: 30831 RVA: 0x00208DDC File Offset: 0x00206FDC
		// Note: this type is marked as 'beforefieldinit'.
		static CocaPlant()
		{
			Il2CppClassPointerStore<CocaPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "CocaPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr);
			CocaPlant.NativeFieldInfoPtr_Harvestable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, "Harvestable");
			CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678415);
			CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678416);
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00208E48 File Offset: 0x00207048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232574, XrefRangeEnd = 232580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x00208EA0 File Offset: 0x002070A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232580, XrefRangeEnd = 232581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x0003920E File Offset: 0x0003740E
		public CocaPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06007873 RID: 30835 RVA: 0x00208EDC File Offset: 0x002070DC
		// (set) Token: 0x06007874 RID: 30836 RVA: 0x00039217 File Offset: 0x00037417
		public unsafe PlantHarvestable Harvestable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005210 RID: 21008
		private static readonly IntPtr NativeFieldInfoPtr_Harvestable;

		// Token: 0x04005211 RID: 21009
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005212 RID: 21010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
