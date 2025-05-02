using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000565 RID: 1381
	public class FunctionalCocaine : FunctionalProduct
	{
		// Token: 0x0600792B RID: 31019 RVA: 0x0003986D File Offset: 0x00037A6D
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalCocaine()
		{
			Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalCocaine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr);
			FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr, 100678487);
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x0020B270 File Offset: 0x00209470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233026, XrefRangeEnd = 233027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalCocaine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x000398A6 File Offset: 0x00037AA6
		public FunctionalCocaine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005280 RID: 21120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
