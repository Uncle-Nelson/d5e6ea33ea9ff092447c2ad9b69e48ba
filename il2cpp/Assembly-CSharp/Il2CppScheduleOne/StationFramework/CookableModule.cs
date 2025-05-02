using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000587 RID: 1415
	public class CookableModule : ItemModule
	{
		// Token: 0x06007CA3 RID: 31907 RVA: 0x0021785C File Offset: 0x00215A5C
		// Note: this type is marked as 'beforefieldinit'.
		static CookableModule()
		{
			Il2CppClassPointerStore<CookableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CookableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookableModule>.NativeClassPtr);
			CookableModule.NativeFieldInfoPtr_CookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookTime");
			CookableModule.NativeFieldInfoPtr_CookType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookType");
			CookableModule.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "Product");
			CookableModule.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductQuantity");
			CookableModule.NativeFieldInfoPtr_ProductShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductShardPrefab");
			CookableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "LiquidColor");
			CookableModule.NativeFieldInfoPtr_SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "SolidColor");
			CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, 100678908);
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x0021792C File Offset: 0x00215B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237584, XrefRangeEnd = 237585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0003B280 File Offset: 0x00039480
		public CookableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06007CA6 RID: 31910 RVA: 0x00217968 File Offset: 0x00215B68
		// (set) Token: 0x06007CA7 RID: 31911 RVA: 0x0003B289 File Offset: 0x00039489
		public unsafe int CookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime)) = value;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06007CA8 RID: 31912 RVA: 0x00217990 File Offset: 0x00215B90
		// (set) Token: 0x06007CA9 RID: 31913 RVA: 0x0003B2A4 File Offset: 0x000394A4
		public unsafe CookableModule.ECookableType CookType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType)) = value;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06007CAA RID: 31914 RVA: 0x002179B8 File Offset: 0x00215BB8
		// (set) Token: 0x06007CAB RID: 31915 RVA: 0x0003B2BF File Offset: 0x000394BF
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06007CAC RID: 31916 RVA: 0x002179E8 File Offset: 0x00215BE8
		// (set) Token: 0x06007CAD RID: 31917 RVA: 0x0003B2DE File Offset: 0x000394DE
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06007CAE RID: 31918 RVA: 0x00217A10 File Offset: 0x00215C10
		// (set) Token: 0x06007CAF RID: 31919 RVA: 0x0003B2F9 File Offset: 0x000394F9
		public unsafe Rigidbody ProductShardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06007CB0 RID: 31920 RVA: 0x00217A40 File Offset: 0x00215C40
		// (set) Token: 0x06007CB1 RID: 31921 RVA: 0x0003B318 File Offset: 0x00039518
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x00217A68 File Offset: 0x00215C68
		// (set) Token: 0x06007CB3 RID: 31923 RVA: 0x0003B333 File Offset: 0x00039533
		public unsafe Color SolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor)) = value;
			}
		}

		// Token: 0x040054DB RID: 21723
		private static readonly IntPtr NativeFieldInfoPtr_CookTime;

		// Token: 0x040054DC RID: 21724
		private static readonly IntPtr NativeFieldInfoPtr_CookType;

		// Token: 0x040054DD RID: 21725
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040054DE RID: 21726
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x040054DF RID: 21727
		private static readonly IntPtr NativeFieldInfoPtr_ProductShardPrefab;

		// Token: 0x040054E0 RID: 21728
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040054E1 RID: 21729
		private static readonly IntPtr NativeFieldInfoPtr_SolidColor;

		// Token: 0x040054E2 RID: 21730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB5 RID: 2741
		[OriginalName("Assembly-CSharp.dll", "", "ECookableType")]
		public enum ECookableType
		{
			// Token: 0x04008EA3 RID: 36515
			Liquid,
			// Token: 0x04008EA4 RID: 36516
			Solid
		}
	}
}
