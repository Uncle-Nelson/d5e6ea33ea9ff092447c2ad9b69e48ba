using System;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D3 RID: 211
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000364 RID: 868
		public abstract CameraEvent GetCameraEvent();

		// Token: 0x06000365 RID: 869
		public abstract string GetName();

		// Token: 0x06000366 RID: 870
		public abstract void PopulateCommandBuffer(CommandBuffer cb);
	}
}
