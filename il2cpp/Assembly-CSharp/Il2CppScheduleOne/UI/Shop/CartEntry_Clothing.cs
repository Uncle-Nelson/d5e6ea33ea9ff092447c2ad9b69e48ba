using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000707 RID: 1799
	public class CartEntry_Clothing : CartEntry
	{
		// Token: 0x0600A1C1 RID: 41409 RVA: 0x0028AE20 File Offset: 0x00289020
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry_Clothing()
		{
			Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry_Clothing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr);
			CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683088);
			CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683089);
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x0028AE78 File Offset: 0x00289078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284331, XrefRangeEnd = 284345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x0028AEB4 File Offset: 0x002890B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry_Clothing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x0004F967 File Offset: 0x0004DB67
		public CartEntry_Clothing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006C72 RID: 27762
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0;

		// Token: 0x04006C73 RID: 27763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
