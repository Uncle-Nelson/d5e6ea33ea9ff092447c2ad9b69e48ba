using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005CF RID: 1487
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x06008317 RID: 33559 RVA: 0x0022DE4C File Offset: 0x0022C04C
		// Note: this type is marked as 'beforefieldinit'.
		static SoilDefinition()
		{
			Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SoilDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr);
			SoilDefinition.NativeFieldInfoPtr_SoilQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "SoilQuality");
			SoilDefinition.NativeFieldInfoPtr_DrySoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "DrySoilMat");
			SoilDefinition.NativeFieldInfoPtr_WetSoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "WetSoilMat");
			SoilDefinition.NativeFieldInfoPtr_ParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "ParticleColor");
			SoilDefinition.NativeFieldInfoPtr_Uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "Uses");
			SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, 100679703);
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x0022DEF4 File Offset: 0x0022C0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247346, XrefRangeEnd = 247347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0003E4BD File Offset: 0x0003C6BD
		public SoilDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600831A RID: 33562 RVA: 0x0022DF30 File Offset: 0x0022C130
		// (set) Token: 0x0600831B RID: 33563 RVA: 0x0003E4C6 File Offset: 0x0003C6C6
		public unsafe SoilDefinition.ESoilQuality SoilQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality)) = value;
			}
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x0022DF58 File Offset: 0x0022C158
		// (set) Token: 0x0600831D RID: 33565 RVA: 0x0003E4E1 File Offset: 0x0003C6E1
		public unsafe Material DrySoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600831E RID: 33566 RVA: 0x0022DF88 File Offset: 0x0022C188
		// (set) Token: 0x0600831F RID: 33567 RVA: 0x0003E500 File Offset: 0x0003C700
		public unsafe Material WetSoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0022DFB8 File Offset: 0x0022C1B8
		// (set) Token: 0x06008321 RID: 33569 RVA: 0x0003E51F File Offset: 0x0003C71F
		public unsafe Color ParticleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor)) = value;
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x0022DFE0 File Offset: 0x0022C1E0
		// (set) Token: 0x06008323 RID: 33571 RVA: 0x0003E53A File Offset: 0x0003C73A
		public unsafe int Uses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses)) = value;
			}
		}

		// Token: 0x04005938 RID: 22840
		private static readonly IntPtr NativeFieldInfoPtr_SoilQuality;

		// Token: 0x04005939 RID: 22841
		private static readonly IntPtr NativeFieldInfoPtr_DrySoilMat;

		// Token: 0x0400593A RID: 22842
		private static readonly IntPtr NativeFieldInfoPtr_WetSoilMat;

		// Token: 0x0400593B RID: 22843
		private static readonly IntPtr NativeFieldInfoPtr_ParticleColor;

		// Token: 0x0400593C RID: 22844
		private static readonly IntPtr NativeFieldInfoPtr_Uses;

		// Token: 0x0400593D RID: 22845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE5 RID: 2789
		[OriginalName("Assembly-CSharp.dll", "", "ESoilQuality")]
		public enum ESoilQuality
		{
			// Token: 0x04008F7E RID: 36734
			Basic,
			// Token: 0x04008F7F RID: 36735
			Premium
		}
	}
}
