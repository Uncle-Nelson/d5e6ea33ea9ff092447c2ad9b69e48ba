using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029B RID: 667
	public class MixingStationData : GridItemData
	{
		// Token: 0x060030D0 RID: 12496 RVA: 0x0010B8A4 File Offset: 0x00109AA4
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationData()
		{
			Il2CppClassPointerStore<MixingStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr);
			MixingStationData.NativeFieldInfoPtr_ProductContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "ProductContents");
			MixingStationData.NativeFieldInfoPtr_MixerContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "MixerContents");
			MixingStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "OutputContents");
			MixingStationData.NativeFieldInfoPtr_CurrentMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixOperation");
			MixingStationData.NativeFieldInfoPtr_CurrentMixTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixTime");
			MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, 100668819);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0010B94C File Offset: 0x00109B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131050, RefRangeEnd = 131052, XrefRangeStart = 131040, XrefRangeEnd = 131050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productContents);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixerContents);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMixOperation);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMixTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0001A049 File Offset: 0x00018249
		public MixingStationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0010BA40 File Offset: 0x00109C40
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x0001A052 File Offset: 0x00018252
		public unsafe ItemSet ProductContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0010BA70 File Offset: 0x00109C70
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x0001A071 File Offset: 0x00018271
		public unsafe ItemSet MixerContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0010BAA0 File Offset: 0x00109CA0
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x0001A090 File Offset: 0x00018290
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0010BAD0 File Offset: 0x00109CD0
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x0001A0AF File Offset: 0x000182AF
		public unsafe MixOperation CurrentMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x0010BB00 File Offset: 0x00109D00
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x0001A0CE File Offset: 0x000182CE
		public unsafe int CurrentMixTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime)) = value;
			}
		}

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_ProductContents;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_MixerContents;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMixOperation;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMixTime;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0;
	}
}
