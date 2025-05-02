using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A7 RID: 1447
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06007E88 RID: 32392 RVA: 0x0021D6C0 File Offset: 0x0021B8C0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductIconManager()
		{
			Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductIconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr);
			ProductIconManager.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "icons");
			ProductIconManager.NativeFieldInfoPtr_IconGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconGenerator");
			ProductIconManager.NativeFieldInfoPtr_IconContainerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconContainerPath");
			ProductIconManager.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Products");
			ProductIconManager.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Packaging");
			ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679118);
			ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679119);
			ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679120);
			ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679121);
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0021D7A4 File Offset: 0x0021B9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239392, RefRangeEnd = 239394, XrefRangeStart = 239372, XrefRangeEnd = 239392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0021D814 File Offset: 0x0021BA14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239427, RefRangeEnd = 239430, XrefRangeStart = 239394, XrefRangeEnd = 239427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GenerateIcons(string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0021D864 File Offset: 0x0021BA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239430, XrefRangeEnd = 239432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0021D8C8 File Offset: 0x0021BAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239432, XrefRangeEnd = 239446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductIconManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0003C224 File Offset: 0x0003A424
		public ProductIconManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x0021D904 File Offset: 0x0021BB04
		// (set) Token: 0x06007E8F RID: 32399 RVA: 0x0003C22D File Offset: 0x0003A42D
		public unsafe List<ProductIconManager.ProductIcon> icons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductIconManager.ProductIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x0021D934 File Offset: 0x0021BB34
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x0003C24C File Offset: 0x0003A44C
		public unsafe IconGenerator IconGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x0021D964 File Offset: 0x0021BB64
		// (set) Token: 0x06007E93 RID: 32403 RVA: 0x0003C26B File Offset: 0x0003A46B
		public unsafe string IconContainerPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconContainerPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06007E94 RID: 32404 RVA: 0x0021D98C File Offset: 0x0021BB8C
		// (set) Token: 0x06007E95 RID: 32405 RVA: 0x0003C28A File Offset: 0x0003A48A
		public unsafe Il2CppReferenceArray<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06007E96 RID: 32406 RVA: 0x0021D9BC File Offset: 0x0021BBBC
		// (set) Token: 0x06007E97 RID: 32407 RVA: 0x0003C2A9 File Offset: 0x0003A4A9
		public unsafe Il2CppReferenceArray<PackagingDefinition> Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400561C RID: 22044
		private static readonly IntPtr NativeFieldInfoPtr_icons;

		// Token: 0x0400561D RID: 22045
		private static readonly IntPtr NativeFieldInfoPtr_IconGenerator;

		// Token: 0x0400561E RID: 22046
		private static readonly IntPtr NativeFieldInfoPtr_IconContainerPath;

		// Token: 0x0400561F RID: 22047
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04005620 RID: 22048
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04005621 RID: 22049
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0;

		// Token: 0x04005622 RID: 22050
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0;

		// Token: 0x04005623 RID: 22051
		private static readonly IntPtr NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0;

		// Token: 0x04005624 RID: 22052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC9 RID: 2761
		[Serializable]
		public class ProductIcon : Il2CppSystem.Object
		{
			// Token: 0x0600D44D RID: 54349 RVA: 0x0032AC84 File Offset: 0x00328E84
			// Note: this type is marked as 'beforefieldinit'.
			static ProductIcon()
			{
				Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "ProductIcon");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr);
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "ProductID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "PackagingID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "Icon");
				ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, 100679122);
			}

			// Token: 0x0600D44E RID: 54350 RVA: 0x0032AD00 File Offset: 0x00328F00
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D44F RID: 54351 RVA: 0x00067528 File Offset: 0x00065728
			public ProductIcon(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D0 RID: 16848
			// (get) Token: 0x0600D450 RID: 54352 RVA: 0x0032AD3C File Offset: 0x00328F3C
			// (set) Token: 0x0600D451 RID: 54353 RVA: 0x00067531 File Offset: 0x00065731
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041D1 RID: 16849
			// (get) Token: 0x0600D452 RID: 54354 RVA: 0x0032AD64 File Offset: 0x00328F64
			// (set) Token: 0x0600D453 RID: 54355 RVA: 0x00067550 File Offset: 0x00065750
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041D2 RID: 16850
			// (get) Token: 0x0600D454 RID: 54356 RVA: 0x0032AD8C File Offset: 0x00328F8C
			// (set) Token: 0x0600D455 RID: 54357 RVA: 0x0006756F File Offset: 0x0006576F
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EF1 RID: 36593
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04008EF2 RID: 36594
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04008EF3 RID: 36595
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04008EF4 RID: 36596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ACA RID: 2762
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D456 RID: 54358 RVA: 0x0032ADBC File Offset: 0x00328FBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, "packagingID");
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679123);
				ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr, 100679124);
			}

			// Token: 0x0600D457 RID: 54359 RVA: 0x0032AE38 File Offset: 0x00329038
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D458 RID: 54360 RVA: 0x0032AE74 File Offset: 0x00329074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239371, XrefRangeEnd = 239372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIcon_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass6_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D459 RID: 54361 RVA: 0x0006758E File Offset: 0x0006578E
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D3 RID: 16851
			// (get) Token: 0x0600D45A RID: 54362 RVA: 0x0032AEC4 File Offset: 0x003290C4
			// (set) Token: 0x0600D45B RID: 54363 RVA: 0x00067597 File Offset: 0x00065797
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041D4 RID: 16852
			// (get) Token: 0x0600D45C RID: 54364 RVA: 0x0032AEEC File Offset: 0x003290EC
			// (set) Token: 0x0600D45D RID: 54365 RVA: 0x000675B6 File Offset: 0x000657B6
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass6_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EF5 RID: 36597
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04008EF6 RID: 36598
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04008EF7 RID: 36599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EF8 RID: 36600
			private static readonly IntPtr NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0;
		}

		// Token: 0x02000ACB RID: 2763
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D45E RID: 54366 RVA: 0x0032AF14 File Offset: 0x00329114
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679125);
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679126);
			}

			// Token: 0x0600D45F RID: 54367 RVA: 0x0032AF7C File Offset: 0x0032917C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D460 RID: 54368 RVA: 0x0032AFB8 File Offset: 0x003291B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateIcons_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D461 RID: 54369 RVA: 0x000675D5 File Offset: 0x000657D5
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D5 RID: 16853
			// (get) Token: 0x0600D462 RID: 54370 RVA: 0x0032B008 File Offset: 0x00329208
			// (set) Token: 0x0600D463 RID: 54371 RVA: 0x000675DE File Offset: 0x000657DE
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EF9 RID: 36601
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04008EFA RID: 36602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EFB RID: 36603
			private static readonly IntPtr NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0;
		}
	}
}
