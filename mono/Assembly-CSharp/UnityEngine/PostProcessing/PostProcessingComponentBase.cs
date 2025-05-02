using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D1 RID: 209
	public abstract class PostProcessingComponentBase
	{
		// Token: 0x06000359 RID: 857 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600035A RID: 858
		public abstract bool active { get; }

		// Token: 0x0600035B RID: 859 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void OnEnable()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void OnDisable()
		{
		}

		// Token: 0x0600035D RID: 861
		public abstract PostProcessingModel GetModel();

		// Token: 0x0400045E RID: 1118
		public PostProcessingContext context;
	}
}
