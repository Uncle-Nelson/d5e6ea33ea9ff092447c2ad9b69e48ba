using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AB RID: 1451
	public static class ProductQuantities : Object
	{
		// Token: 0x06007FAD RID: 32685 RVA: 0x00223310 File Offset: 0x00221510
		// Note: this type is marked as 'beforefieldinit'.
		static ProductQuantities()
		{
			Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductQuantities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr);
			ProductQuantities.NativeFieldInfoPtr_BagQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BagQuantity");
			ProductQuantities.NativeFieldInfoPtr_JarQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "JarQuantity");
			ProductQuantities.NativeFieldInfoPtr_BrickQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BrickQuantity");
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x0003C7AA File Offset: 0x0003A9AA
		public ProductQuantities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06007FAF RID: 32687 RVA: 0x0022337C File Offset: 0x0022157C
		// (set) Token: 0x06007FB0 RID: 32688 RVA: 0x0003C7B3 File Offset: 0x0003A9B3
		public unsafe static int BagQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06007FB1 RID: 32689 RVA: 0x00223398 File Offset: 0x00221598
		// (set) Token: 0x06007FB2 RID: 32690 RVA: 0x0003C7C1 File Offset: 0x0003A9C1
		public unsafe static int JarQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x06007FB3 RID: 32691 RVA: 0x002233B4 File Offset: 0x002215B4
		// (set) Token: 0x06007FB4 RID: 32692 RVA: 0x0003C7CF File Offset: 0x0003A9CF
		public unsafe static int BrickQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&value));
			}
		}

		// Token: 0x04005709 RID: 22281
		private static readonly IntPtr NativeFieldInfoPtr_BagQuantity;

		// Token: 0x0400570A RID: 22282
		private static readonly IntPtr NativeFieldInfoPtr_JarQuantity;

		// Token: 0x0400570B RID: 22283
		private static readonly IntPtr NativeFieldInfoPtr_BrickQuantity;
	}
}
