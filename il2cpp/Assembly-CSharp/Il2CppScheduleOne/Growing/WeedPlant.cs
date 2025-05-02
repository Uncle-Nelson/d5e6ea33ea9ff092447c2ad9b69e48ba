using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000560 RID: 1376
	public class WeedPlant : Plant
	{
		// Token: 0x060078E6 RID: 30950 RVA: 0x0020A410 File Offset: 0x00208610
		// Note: this type is marked as 'beforefieldinit'.
		static WeedPlant()
		{
			Il2CppClassPointerStore<WeedPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "WeedPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr);
			WeedPlant.NativeFieldInfoPtr_BranchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, "BranchPrefab");
			WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678456);
			WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678457);
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x0020A47C File Offset: 0x0020867C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232892, XrefRangeEnd = 232898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0020A4D4 File Offset: 0x002086D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00039641 File Offset: 0x00037841
		public WeedPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x0020A510 File Offset: 0x00208710
		// (set) Token: 0x060078EB RID: 30955 RVA: 0x0003964A File Offset: 0x0003784A
		public unsafe PlantHarvestable BranchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005256 RID: 21078
		private static readonly IntPtr NativeFieldInfoPtr_BranchPrefab;

		// Token: 0x04005257 RID: 21079
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005258 RID: 21080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
