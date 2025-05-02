using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.HandheldBin;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BA RID: 1466
	public class Equippable_Bin : Equippable_Viewmodel
	{
		// Token: 0x060080A3 RID: 32931 RVA: 0x00226030 File Offset: 0x00224230
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Bin()
		{
			Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr);
			Equippable_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, "bin");
			Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, 100679438);
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x00226088 File Offset: 0x00224288
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244704, RefRangeEnd = 244712, XrefRangeStart = 244704, XrefRangeEnd = 244712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x0003D083 File Offset: 0x0003B283
		public Equippable_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x002260C4 File Offset: 0x002242C4
		// (set) Token: 0x060080A7 RID: 32935 RVA: 0x0003D08C File Offset: 0x0003B28C
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400579D RID: 22429
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x0400579E RID: 22430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
