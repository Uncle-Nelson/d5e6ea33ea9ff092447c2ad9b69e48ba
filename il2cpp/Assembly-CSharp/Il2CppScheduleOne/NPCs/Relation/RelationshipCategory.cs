using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F1 RID: 753
	public class RelationshipCategory : Il2CppSystem.Object
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x0012966C File Offset: 0x0012786C
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipCategory()
		{
			Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "RelationshipCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr);
			RelationshipCategory.NativeFieldInfoPtr_Hostile_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Hostile_Color");
			RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Unfriendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Neutral_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Neutral_Color");
			RelationshipCategory.NativeFieldInfoPtr_Friendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Friendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Loyal_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Loyal_Color");
			RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669906);
			RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669907);
			RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669908);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0012973C File Offset: 0x0012793C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141715, RefRangeEnd = 141718, XrefRangeStart = 141715, XrefRangeEnd = 141715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERelationshipCategory GetCategory(float delta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0012977C File Offset: 0x0012797C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141726, RefRangeEnd = 141728, XrefRangeStart = 141718, XrefRangeEnd = 141726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(ERelationshipCategory category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x001297BC File Offset: 0x001279BC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0001D489 File Offset: 0x0001B689
		public RelationshipCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x001297F8 File Offset: 0x001279F8
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x0001D492 File Offset: 0x0001B692
		public unsafe static Color32 Hostile_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&value));
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00129814 File Offset: 0x00127A14
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x0001D4A0 File Offset: 0x0001B6A0
		public unsafe static Color32 Unfriendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&value));
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x00129830 File Offset: 0x00127A30
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x0001D4AE File Offset: 0x0001B6AE
		public unsafe static Color32 Neutral_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&value));
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x0012984C File Offset: 0x00127A4C
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x0001D4BC File Offset: 0x0001B6BC
		public unsafe static Color32 Friendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&value));
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x00129868 File Offset: 0x00127A68
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0001D4CA File Offset: 0x0001B6CA
		public unsafe static Color32 Loyal_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&value));
			}
		}

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr_Hostile_Color;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr_Unfriendly_Color;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeFieldInfoPtr_Neutral_Color;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeFieldInfoPtr_Friendly_Color;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeFieldInfoPtr_Loyal_Color;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
