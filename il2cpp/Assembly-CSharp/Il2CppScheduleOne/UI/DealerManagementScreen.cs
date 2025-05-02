using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000632 RID: 1586
	public class DealerManagementScreen : Singleton<DealerManagementScreen>
	{
		// Token: 0x06008C26 RID: 35878 RVA: 0x0004327F File Offset: 0x0004147F
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementScreen()
		{
			Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealerManagementScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr);
			DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr, 100680705);
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x00249DB0 File Offset: 0x00247FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256551, XrefRangeEnd = 256554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x000432B8 File Offset: 0x000414B8
		public DealerManagementScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005F03 RID: 24323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
