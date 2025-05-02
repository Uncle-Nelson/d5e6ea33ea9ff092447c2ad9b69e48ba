using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000454 RID: 1108
	public class CoroutineService : Singleton<CoroutineService>
	{
		// Token: 0x0600604A RID: 24650 RVA: 0x0002D84E File Offset: 0x0002BA4E
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineService()
		{
			Il2CppClassPointerStore<CoroutineService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CoroutineService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr);
			CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr, 100675550);
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x001B8ABC File Offset: 0x001B6CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199122, XrefRangeEnd = 199125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoroutineService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x0002D887 File Offset: 0x0002BA87
		public CoroutineService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041BB RID: 16827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
