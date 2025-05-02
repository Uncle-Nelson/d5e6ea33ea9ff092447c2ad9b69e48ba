using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037D RID: 893
	public class GeneralStoreMerchant : Merchant
	{
		// Token: 0x060045EA RID: 17898 RVA: 0x000220C2 File Offset: 0x000202C2
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralStoreMerchant()
		{
			Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "GeneralStoreMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr);
			GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr, 100671890);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00157F64 File Offset: 0x00156164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157881, XrefRangeEnd = 157886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralStoreMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x000220FB File Offset: 0x000202FB
		public GeneralStoreMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
