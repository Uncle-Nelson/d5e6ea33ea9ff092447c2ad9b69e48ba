using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000297 RID: 663
	public class DryingRackData : GridItemData
	{
		// Token: 0x060030A8 RID: 12456 RVA: 0x0010B0FC File Offset: 0x001092FC
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackData()
		{
			Il2CppClassPointerStore<DryingRackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr);
			DryingRackData.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Input");
			DryingRackData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Output");
			DryingRackData.NativeFieldInfoPtr_DryingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "DryingOperations");
			DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, 100668815);
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0010B17C File Offset: 0x0010937C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131012, RefRangeEnd = 131013, XrefRangeStart = 131002, XrefRangeEnd = 131012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, Il2CppReferenceArray<DryingOperation> dryingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dryingOperations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00019E87 File Offset: 0x00018087
		public DryingRackData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x0010B24C File Offset: 0x0010944C
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00019E90 File Offset: 0x00018090
		public unsafe ItemSet Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0010B27C File Offset: 0x0010947C
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00019EAF File Offset: 0x000180AF
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x0010B2AC File Offset: 0x001094AC
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00019ECE File Offset: 0x000180CE
		public unsafe Il2CppReferenceArray<DryingOperation> DryingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_Input;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr_DryingOperations;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0;
	}
}
