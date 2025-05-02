using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0001427F File Offset: 0x0001247F
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00014287 File Offset: 0x00012487
		public bool enabled
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
				if (value)
				{
					this.OnValidate();
				}
			}
		}

		// Token: 0x06000376 RID: 886
		public abstract void Reset();

		// Token: 0x06000377 RID: 887 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void OnValidate()
		{
		}

		// Token: 0x04000465 RID: 1125
		[SerializeField]
		[GetSet("enabled")]
		private bool m_Enabled;
	}
}
