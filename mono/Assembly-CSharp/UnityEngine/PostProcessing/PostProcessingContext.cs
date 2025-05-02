using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D5 RID: 213
	public class PostProcessingContext
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000141FB File Offset: 0x000123FB
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00014203 File Offset: 0x00012403
		public bool interrupted { get; private set; }

		// Token: 0x0600036C RID: 876 RVA: 0x0001420C File Offset: 0x0001240C
		public void Interrupt()
		{
			this.interrupted = true;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00014215 File Offset: 0x00012415
		public PostProcessingContext Reset()
		{
			this.profile = null;
			this.camera = null;
			this.materialFactory = null;
			this.renderTextureFactory = null;
			this.interrupted = false;
			return this;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0001423B File Offset: 0x0001243B
		public bool isGBufferAvailable
		{
			get
			{
				return this.camera.actualRenderingPath == RenderingPath.DeferredShading;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0001424B File Offset: 0x0001244B
		public bool isHdr
		{
			get
			{
				return this.camera.allowHDR;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00014258 File Offset: 0x00012458
		public int width
		{
			get
			{
				return this.camera.pixelWidth;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00014265 File Offset: 0x00012465
		public int height
		{
			get
			{
				return this.camera.pixelHeight;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00014272 File Offset: 0x00012472
		public Rect viewport
		{
			get
			{
				return this.camera.rect;
			}
		}

		// Token: 0x04000460 RID: 1120
		public PostProcessingProfile profile;

		// Token: 0x04000461 RID: 1121
		public Camera camera;

		// Token: 0x04000462 RID: 1122
		public MaterialFactory materialFactory;

		// Token: 0x04000463 RID: 1123
		public RenderTextureFactory renderTextureFactory;
	}
}
