using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037F RID: 895
	public class UndergroundMerchant : Merchant
	{
		// Token: 0x060045FB RID: 17915 RVA: 0x00022181 File Offset: 0x00020381
		// Note: this type is marked as 'beforefieldinit'.
		static UndergroundMerchant()
		{
			Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "UndergroundMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr);
			UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr, 100671895);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00158200 File Offset: 0x00156400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndergroundMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000221BA File Offset: 0x000203BA
		public UndergroundMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
