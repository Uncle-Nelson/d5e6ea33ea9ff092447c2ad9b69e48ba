using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048A RID: 1162
	public class ConstructStart_PowerLine : ConstructStart_Base
	{
		// Token: 0x060064B6 RID: 25782 RVA: 0x0002F9E0 File Offset: 0x0002DBE0
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_PowerLine()
		{
			Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr);
			ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr, 100676056);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x001C7704 File Offset: 0x001C5904
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x0002FA19 File Offset: 0x0002DC19
		public ConstructStart_PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044B8 RID: 17592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
