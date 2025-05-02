using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000B9 RID: 185
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001314A File Offset: 0x0001134A
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00013152 File Offset: 0x00011352
		public DitheringModel.Settings settings
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

		// Token: 0x06000322 RID: 802 RVA: 0x0001315B File Offset: 0x0001135B
		public override void Reset()
		{
			this.m_Settings = DitheringModel.Settings.defaultSettings;
		}

		// Token: 0x040003FF RID: 1023
		[SerializeField]
		private DitheringModel.Settings m_Settings = DitheringModel.Settings.defaultSettings;

		// Token: 0x020000BA RID: 186
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000324 RID: 804 RVA: 0x0001317C File Offset: 0x0001137C
			public static DitheringModel.Settings defaultSettings
			{
				get
				{
					return default(DitheringModel.Settings);
				}
			}
		}
	}
}
