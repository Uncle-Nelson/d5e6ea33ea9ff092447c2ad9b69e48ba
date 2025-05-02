using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E0 RID: 224
	public class LightningArtSet : SpriteArtSet
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x000A9128 File Offset: 0x000A7328
		// Note: this type is marked as 'beforefieldinit'.
		static LightningArtSet()
		{
			Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr);
			LightningArtSet.NativeFieldInfoPtr_lightingStyleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr, "lightingStyleItems");
			LightningArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr, 100665364);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000A9180 File Offset: 0x000A7380
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0000AF72 File Offset: 0x00009172
		public LightningArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000A91BC File Offset: 0x000A73BC
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x0000AF7B File Offset: 0x0000917B
		public unsafe List<LightningArtItem> lightingStyleItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtSet.NativeFieldInfoPtr_lightingStyleItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningArtItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtSet.NativeFieldInfoPtr_lightingStyleItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr_lightingStyleItems;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
