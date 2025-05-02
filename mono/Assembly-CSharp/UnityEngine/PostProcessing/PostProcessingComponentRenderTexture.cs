using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D4 RID: 212
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000368 RID: 872 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Prepare(Material material)
		{
		}
	}
}
