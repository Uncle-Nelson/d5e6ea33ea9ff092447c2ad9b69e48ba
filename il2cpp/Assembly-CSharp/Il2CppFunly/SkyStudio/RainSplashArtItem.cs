using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E1 RID: 225
	public class RainSplashArtItem : SpriteArtItem
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x000A91EC File Offset: 0x000A73EC
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashArtItem()
		{
			Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr);
			RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, "intensityMultiplier");
			RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, "scaleMultiplier");
			RainSplashArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr, 100665365);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000A9258 File Offset: 0x000A7458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88932, XrefRangeEnd = 88933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000AF9A File Offset: 0x0000919A
		public RainSplashArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000A9294 File Offset: 0x000A7494
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000AFA3 File Offset: 0x000091A3
		public unsafe float intensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_intensityMultiplier)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000A92BC File Offset: 0x000A74BC
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000AFBE File Offset: 0x000091BE
		public unsafe float scaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashArtItem.NativeFieldInfoPtr_scaleMultiplier)) = value;
			}
		}

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr_scaleMultiplier;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
