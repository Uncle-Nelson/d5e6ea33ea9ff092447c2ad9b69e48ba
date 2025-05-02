using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E2 RID: 226
	public class RainSplashArtSet : SpriteArtSet
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x000A92E4 File Offset: 0x000A74E4
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashArtSet()
		{
			Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr);
			RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr, "rainSplashArtItems");
			RainSplashArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr, 100665366);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000A933C File Offset: 0x000A753C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0000AFD9 File Offset: 0x000091D9
		public RainSplashArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000A9378 File Offset: 0x000A7578
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0000AFE2 File Offset: 0x000091E2
		public unsafe List<RainSplashArtItem> rainSplashArtItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RainSplashArtItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtSet.NativeFieldInfoPtr_rainSplashArtItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_rainSplashArtItems;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
