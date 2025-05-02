using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E8 RID: 1512
	public static class ItemQuality : Il2CppSystem.Object
	{
		// Token: 0x06008401 RID: 33793 RVA: 0x00230F28 File Offset: 0x0022F128
		// Note: this type is marked as 'beforefieldinit'.
		static ItemQuality()
		{
			Il2CppClassPointerStore<ItemQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr);
			ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Threshold");
			ItemQuality.NativeFieldInfoPtr_Premium_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Threshold");
			ItemQuality.NativeFieldInfoPtr_Standard_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Threshold");
			ItemQuality.NativeFieldInfoPtr_Poor_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Threshold");
			ItemQuality.NativeFieldInfoPtr_Heavenly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Color");
			ItemQuality.NativeFieldInfoPtr_Premium_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Color");
			ItemQuality.NativeFieldInfoPtr_Standard_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Color");
			ItemQuality.NativeFieldInfoPtr_Poor_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Color");
			ItemQuality.NativeFieldInfoPtr_Trash_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Trash_Color");
			ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100679807);
			ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100679808);
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x00231034 File Offset: 0x0022F234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248111, RefRangeEnd = 248113, XrefRangeStart = 248111, XrefRangeEnd = 248111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetQuality(float qualityScalar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qualityScalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x00231074 File Offset: 0x0022F274
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 248120, RefRangeEnd = 248126, XrefRangeStart = 248113, XrefRangeEnd = 248120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x0003EB01 File Offset: 0x0003CD01
		public ItemQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x002310B4 File Offset: 0x0022F2B4
		// (set) Token: 0x06008406 RID: 33798 RVA: 0x0003EB0A File Offset: 0x0003CD0A
		public unsafe static float Heavenly_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x06008407 RID: 33799 RVA: 0x002310D0 File Offset: 0x0022F2D0
		// (set) Token: 0x06008408 RID: 33800 RVA: 0x0003EB18 File Offset: 0x0003CD18
		public unsafe static float Premium_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x002310EC File Offset: 0x0022F2EC
		// (set) Token: 0x0600840A RID: 33802 RVA: 0x0003EB26 File Offset: 0x0003CD26
		public unsafe static float Standard_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600840B RID: 33803 RVA: 0x00231108 File Offset: 0x0022F308
		// (set) Token: 0x0600840C RID: 33804 RVA: 0x0003EB34 File Offset: 0x0003CD34
		public unsafe static float Poor_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600840D RID: 33805 RVA: 0x00231124 File Offset: 0x0022F324
		// (set) Token: 0x0600840E RID: 33806 RVA: 0x0003EB42 File Offset: 0x0003CD42
		public unsafe static Color Heavenly_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&value));
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600840F RID: 33807 RVA: 0x00231140 File Offset: 0x0022F340
		// (set) Token: 0x06008410 RID: 33808 RVA: 0x0003EB50 File Offset: 0x0003CD50
		public unsafe static Color Premium_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&value));
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x06008411 RID: 33809 RVA: 0x0023115C File Offset: 0x0022F35C
		// (set) Token: 0x06008412 RID: 33810 RVA: 0x0003EB5E File Offset: 0x0003CD5E
		public unsafe static Color Standard_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&value));
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06008413 RID: 33811 RVA: 0x00231178 File Offset: 0x0022F378
		// (set) Token: 0x06008414 RID: 33812 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		public unsafe static Color Poor_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&value));
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x06008415 RID: 33813 RVA: 0x00231194 File Offset: 0x0022F394
		// (set) Token: 0x06008416 RID: 33814 RVA: 0x0003EB7A File Offset: 0x0003CD7A
		public unsafe static Color Trash_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&value));
			}
		}

		// Token: 0x040059DE RID: 23006
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Threshold;

		// Token: 0x040059DF RID: 23007
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Threshold;

		// Token: 0x040059E0 RID: 23008
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Threshold;

		// Token: 0x040059E1 RID: 23009
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Threshold;

		// Token: 0x040059E2 RID: 23010
		private static readonly IntPtr NativeFieldInfoPtr_Heavenly_Color;

		// Token: 0x040059E3 RID: 23011
		private static readonly IntPtr NativeFieldInfoPtr_Premium_Color;

		// Token: 0x040059E4 RID: 23012
		private static readonly IntPtr NativeFieldInfoPtr_Standard_Color;

		// Token: 0x040059E5 RID: 23013
		private static readonly IntPtr NativeFieldInfoPtr_Poor_Color;

		// Token: 0x040059E6 RID: 23014
		private static readonly IntPtr NativeFieldInfoPtr_Trash_Color;

		// Token: 0x040059E7 RID: 23015
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0;

		// Token: 0x040059E8 RID: 23016
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0;
	}
}
