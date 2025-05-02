using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DF RID: 223
	public class LightningArtItem : SpriteArtItem
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x000A8F74 File Offset: 0x000A7174
		// Note: this type is marked as 'beforefieldinit'.
		static LightningArtItem()
		{
			Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr);
			LightningArtItem.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "alignment");
			LightningArtItem.NativeFieldInfoPtr_thunderSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "thunderSound");
			LightningArtItem.NativeFieldInfoPtr_strikeProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "strikeProbability");
			LightningArtItem.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "size");
			LightningArtItem.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "intensity");
			LightningArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, 100665363);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000A901C File Offset: 0x000A721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88931, XrefRangeEnd = 88932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000AEDE File Offset: 0x000090DE
		public LightningArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000A9058 File Offset: 0x000A7258
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000AEE7 File Offset: 0x000090E7
		public unsafe LightningArtItem.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000A9080 File Offset: 0x000A7280
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000AF02 File Offset: 0x00009102
		public unsafe AudioClip thunderSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_thunderSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_thunderSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000A90B0 File Offset: 0x000A72B0
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000AF21 File Offset: 0x00009121
		public unsafe float strikeProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_strikeProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_strikeProbability)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000A90D8 File Offset: 0x000A72D8
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0000AF3C File Offset: 0x0000913C
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000A9100 File Offset: 0x000A7300
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x0000AF57 File Offset: 0x00009157
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_thunderSound;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr_strikeProbability;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084F RID: 2127
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x04008247 RID: 33351
			ScaleToFit,
			// Token: 0x04008248 RID: 33352
			TopAlign
		}
	}
}
