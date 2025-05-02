using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D2 RID: 210
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000141BD File Offset: 0x000123BD
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000141C5 File Offset: 0x000123C5
		public T model { get; internal set; }

		// Token: 0x06000361 RID: 865 RVA: 0x000141CE File Offset: 0x000123CE
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
			this.context = pcontext;
			this.model = pmodel;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000141DE File Offset: 0x000123DE
		public override PostProcessingModel GetModel()
		{
			return this.model;
		}
	}
}
