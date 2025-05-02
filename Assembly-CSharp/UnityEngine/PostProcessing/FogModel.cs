using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000BE RID: 190
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001324F File Offset: 0x0001144F
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00013257 File Offset: 0x00011457
		public FogModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00013260 File Offset: 0x00011460
		public override void Reset()
		{
			this.m_Settings = FogModel.Settings.defaultSettings;
		}

		// Token: 0x0400040F RID: 1039
		[SerializeField]
		private FogModel.Settings m_Settings = FogModel.Settings.defaultSettings;

		// Token: 0x020000BF RID: 191
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600032E RID: 814 RVA: 0x00013280 File Offset: 0x00011480
			public static FogModel.Settings defaultSettings
			{
				get
				{
					return new FogModel.Settings
					{
						excludeSkybox = true
					};
				}
			}

			// Token: 0x04000410 RID: 1040
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;
		}
	}
}
