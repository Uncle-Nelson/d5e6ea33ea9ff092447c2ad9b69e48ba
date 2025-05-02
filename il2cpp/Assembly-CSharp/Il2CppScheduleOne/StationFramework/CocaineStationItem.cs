using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000586 RID: 1414
	public class CocaineStationItem : StationItem
	{
		// Token: 0x06007C9D RID: 31901 RVA: 0x00217734 File Offset: 0x00215934
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineStationItem()
		{
			Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CocaineStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr);
			CocaineStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, "Visuals");
			CocaineStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, 100678906);
			CocaineStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, 100678907);
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x002177A0 File Offset: 0x002159A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237577, XrefRangeEnd = 237584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x002177F0 File Offset: 0x002159F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x0003B258 File Offset: 0x00039458
		public CocaineStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06007CA1 RID: 31905 RVA: 0x0021782C File Offset: 0x00215A2C
		// (set) Token: 0x06007CA2 RID: 31906 RVA: 0x0003B261 File Offset: 0x00039461
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054D8 RID: 21720
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040054D9 RID: 21721
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040054DA RID: 21722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
