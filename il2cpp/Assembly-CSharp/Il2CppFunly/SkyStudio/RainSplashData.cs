using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012B RID: 299
	public class RainSplashData : BaseSpriteItemData
	{
		// Token: 0x06001989 RID: 6537 RVA: 0x000C065C File Offset: 0x000BE85C
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashData()
		{
			Il2CppClassPointerStore<RainSplashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashData>.NativeClassPtr);
			RainSplashData.NativeFieldInfoPtr_depthTextureUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashData>.NativeClassPtr, "depthTextureUV");
			RainSplashData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashData>.NativeClassPtr, 100666015);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000C06B4 File Offset: 0x000BE8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0000E8BC File Offset: 0x0000CABC
		public RainSplashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x000C06F0 File Offset: 0x000BE8F0
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
		public unsafe Vector2 depthTextureUV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashData.NativeFieldInfoPtr_depthTextureUV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashData.NativeFieldInfoPtr_depthTextureUV)) = value;
			}
		}

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_depthTextureUV;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
