using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012D RID: 301
	public class WeatherDepthCamera : MonoBehaviour
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x000C0FB4 File Offset: 0x000BF1B4
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherDepthCamera()
		{
			Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherDepthCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr);
			WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "m_DepthCamera");
			WeatherDepthCamera.NativeFieldInfoPtr_depthShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "depthShader");
			WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "overheadDepthTexture");
			WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "renderFrameInterval");
			WeatherDepthCamera.NativeFieldInfoPtr_textureResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "textureResolution");
			WeatherDepthCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666029);
			WeatherDepthCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666030);
			WeatherDepthCamera.NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666031);
			WeatherDepthCamera.NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666032);
			WeatherDepthCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666033);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000C10AC File Offset: 0x000BF2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96648, XrefRangeEnd = 96654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000C10E0 File Offset: 0x000BF2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96654, XrefRangeEnd = 96658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000C1114 File Offset: 0x000BF314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96693, RefRangeEnd = 96694, XrefRangeStart = 96658, XrefRangeEnd = 96693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOverheadCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000C1148 File Offset: 0x000BF348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96719, RefRangeEnd = 96720, XrefRangeStart = 96694, XrefRangeEnd = 96719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRenderTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000C117C File Offset: 0x000BF37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96720, XrefRangeEnd = 96721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherDepthCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0000EA7B File Offset: 0x0000CC7B
		public WeatherDepthCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x000C11B8 File Offset: 0x000BF3B8
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x000C11E8 File Offset: 0x000BF3E8
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000EAA3 File Offset: 0x0000CCA3
		public unsafe Shader depthShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_depthShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_depthShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x000C1218 File Offset: 0x000BF418
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000EAC2 File Offset: 0x0000CCC2
		public unsafe RenderTexture overheadDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x000C1248 File Offset: 0x000BF448
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000EAE1 File Offset: 0x0000CCE1
		public unsafe int renderFrameInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000C1270 File Offset: 0x000BF470
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		public unsafe int textureResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_textureResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_textureResolution)) = value;
			}
		}

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_depthShader;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_overheadDepthTexture;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_renderFrameInterval;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_textureResolution;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
