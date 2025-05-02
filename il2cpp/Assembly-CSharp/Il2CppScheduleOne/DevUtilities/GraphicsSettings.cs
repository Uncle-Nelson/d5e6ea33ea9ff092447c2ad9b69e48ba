using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000473 RID: 1139
	[Serializable]
	public class GraphicsSettings : Object
	{
		// Token: 0x0600626A RID: 25194 RVA: 0x001BF8C0 File Offset: 0x001BDAC0
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GraphicsQuality");
			GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "AntiAliasingMode");
			GraphicsSettings.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "FOV");
			GraphicsSettings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "SSAO");
			GraphicsSettings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GodRays");
			GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100675776);
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x001BF968 File Offset: 0x001BDB68
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x0002E867 File Offset: 0x0002CA67
		public GraphicsSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x001BF9A4 File Offset: 0x001BDBA4
		// (set) Token: 0x0600626E RID: 25198 RVA: 0x0002E870 File Offset: 0x0002CA70
		public unsafe GraphicsSettings.EGraphicsQuality GraphicsQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality)) = value;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600626F RID: 25199 RVA: 0x001BF9CC File Offset: 0x001BDBCC
		// (set) Token: 0x06006270 RID: 25200 RVA: 0x0002E88B File Offset: 0x0002CA8B
		public unsafe GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode)) = value;
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x001BF9F4 File Offset: 0x001BDBF4
		// (set) Token: 0x06006272 RID: 25202 RVA: 0x0002E8A6 File Offset: 0x0002CAA6
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06006273 RID: 25203 RVA: 0x001BFA1C File Offset: 0x001BDC1C
		// (set) Token: 0x06006274 RID: 25204 RVA: 0x0002E8C1 File Offset: 0x0002CAC1
		public unsafe bool SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO)) = value;
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06006275 RID: 25205 RVA: 0x001BFA44 File Offset: 0x001BDC44
		// (set) Token: 0x06006276 RID: 25206 RVA: 0x0002E8DC File Offset: 0x0002CADC
		public unsafe bool GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays)) = value;
			}
		}

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsQuality;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeFieldInfoPtr_AntiAliasingMode;

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A1E RID: 2590
		[OriginalName("Assembly-CSharp.dll", "", "EAntiAliasingMode")]
		public enum EAntiAliasingMode
		{
			// Token: 0x04008BB7 RID: 35767
			Off,
			// Token: 0x04008BB8 RID: 35768
			FXAA,
			// Token: 0x04008BB9 RID: 35769
			SMAA
		}

		// Token: 0x02000A1F RID: 2591
		[OriginalName("Assembly-CSharp.dll", "", "EGraphicsQuality")]
		public enum EGraphicsQuality
		{
			// Token: 0x04008BBB RID: 35771
			Low,
			// Token: 0x04008BBC RID: 35772
			Medium,
			// Token: 0x04008BBD RID: 35773
			High,
			// Token: 0x04008BBE RID: 35774
			Ultra
		}
	}
}
