using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Equipping;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000527 RID: 1319
	public class Flashlight : Equippable_Viewmodel
	{
		// Token: 0x060075F5 RID: 30197 RVA: 0x00037DA3 File Offset: 0x00035FA3
		// Note: this type is marked as 'beforefieldinit'.
		static Flashlight()
		{
			Il2CppClassPointerStore<Flashlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "Flashlight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flashlight>.NativeClassPtr);
			Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flashlight>.NativeClassPtr, 100678162);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00201D58 File Offset: 0x001FFF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flashlight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flashlight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00037DDC File Offset: 0x00035FDC
		public Flashlight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050A0 RID: 20640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
