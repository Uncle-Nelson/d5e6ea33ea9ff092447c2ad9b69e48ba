using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x0200014F RID: 335
	public static class SRPHelper
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001CB49 File Offset: 0x0001AD49
		public static string renderPipelineScriptingDefineSymbolAsString
		{
			get
			{
				return "VLB_URP";
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001CB50 File Offset: 0x0001AD50
		public static RenderPipeline projectRenderPipeline
		{
			get
			{
				if (!SRPHelper.m_IsRenderPipelineCached)
				{
					SRPHelper.m_RenderPipelineCached = SRPHelper.ComputeRenderPipeline();
					SRPHelper.m_IsRenderPipelineCached = true;
				}
				return SRPHelper.m_RenderPipelineCached;
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001CB70 File Offset: 0x0001AD70
		private static RenderPipeline ComputeRenderPipeline()
		{
			RenderPipelineAsset renderPipelineAsset = GraphicsSettings.renderPipelineAsset;
			if (renderPipelineAsset)
			{
				string text = renderPipelineAsset.GetType().ToString();
				if (text.Contains("Universal"))
				{
					return RenderPipeline.URP;
				}
				if (text.Contains("Lightweight"))
				{
					return RenderPipeline.URP;
				}
				if (text.Contains("HD"))
				{
					return RenderPipeline.HDRP;
				}
			}
			return RenderPipeline.BuiltIn;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001CBC5 File Offset: 0x0001ADC5
		public static bool IsUsingCustomRenderPipeline()
		{
			return RenderPipelineManager.currentPipeline != null || GraphicsSettings.renderPipelineAsset != null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001CBDB File Offset: 0x0001ADDB
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			if (SRPHelper.IsUsingCustomRenderPipeline())
			{
				RenderPipelineManager.beginCameraRendering -= cb;
				RenderPipelineManager.beginCameraRendering += cb;
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			if (SRPHelper.IsUsingCustomRenderPipeline())
			{
				RenderPipelineManager.beginCameraRendering -= cb;
			}
		}

		// Token: 0x0400074A RID: 1866
		private static bool m_IsRenderPipelineCached;

		// Token: 0x0400074B RID: 1867
		private static RenderPipeline m_RenderPipelineCached;
	}
}
