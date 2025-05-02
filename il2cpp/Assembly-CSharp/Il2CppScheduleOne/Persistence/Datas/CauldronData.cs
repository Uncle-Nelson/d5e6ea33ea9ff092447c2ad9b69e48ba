using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000295 RID: 661
	public class CauldronData : GridItemData
	{
		// Token: 0x0600308A RID: 12426 RVA: 0x0010AB80 File Offset: 0x00108D80
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronData()
		{
			Il2CppClassPointerStore<CauldronData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronData>.NativeClassPtr);
			CauldronData.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Ingredients");
			CauldronData.NativeFieldInfoPtr_Liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Liquid");
			CauldronData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Output");
			CauldronData.NativeFieldInfoPtr_RemainingCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "RemainingCookTime");
			CauldronData.NativeFieldInfoPtr_InputQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "InputQuality");
			CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, 100668813);
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0010AC28 File Offset: 0x00108E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130991, RefRangeEnd = 130992, XrefRangeStart = 130982, XrefRangeEnd = 130991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(liquid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingCookTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x00019D19 File Offset: 0x00017F19
		public CauldronData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x0010AD18 File Offset: 0x00108F18
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x00019D22 File Offset: 0x00017F22
		public unsafe ItemSet Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x0010AD48 File Offset: 0x00108F48
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x00019D41 File Offset: 0x00017F41
		public unsafe ItemSet Liquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0010AD78 File Offset: 0x00108F78
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x00019D60 File Offset: 0x00017F60
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0010ADA8 File Offset: 0x00108FA8
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x00019D7F File Offset: 0x00017F7F
		public unsafe int RemainingCookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime)) = value;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x0010ADD0 File Offset: 0x00108FD0
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x00019D9A File Offset: 0x00017F9A
		public unsafe EQuality InputQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality)) = value;
			}
		}

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_Liquid;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeFieldInfoPtr_RemainingCookTime;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_InputQuality;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0;
	}
}
