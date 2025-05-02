using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058F RID: 1423
	public class MethStationItem : StationItem
	{
		// Token: 0x06007D2F RID: 32047 RVA: 0x002191EC File Offset: 0x002173EC
		// Note: this type is marked as 'beforefieldinit'.
		static MethStationItem()
		{
			Il2CppClassPointerStore<MethStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "MethStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr);
			MethStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, "Visuals");
			MethStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, 100678969);
			MethStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, 100678970);
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x00219258 File Offset: 0x00217458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237925, XrefRangeEnd = 237932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x002192A8 File Offset: 0x002174A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x0003B747 File Offset: 0x00039947
		public MethStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x06007D33 RID: 32051 RVA: 0x002192E4 File Offset: 0x002174E4
		// (set) Token: 0x06007D34 RID: 32052 RVA: 0x0003B750 File Offset: 0x00039950
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400552F RID: 21807
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005530 RID: 21808
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x04005531 RID: 21809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
