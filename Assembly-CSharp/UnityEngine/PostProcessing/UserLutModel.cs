using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001347E File Offset: 0x0001167E
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00013486 File Offset: 0x00011686
		public UserLutModel.Settings settings
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

		// Token: 0x06000340 RID: 832 RVA: 0x0001348F File Offset: 0x0001168F
		public override void Reset()
		{
			this.m_Settings = UserLutModel.Settings.defaultSettings;
		}

		// Token: 0x04000431 RID: 1073
		[SerializeField]
		private UserLutModel.Settings m_Settings = UserLutModel.Settings.defaultSettings;

		// Token: 0x020000CC RID: 204
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000342 RID: 834 RVA: 0x000134B0 File Offset: 0x000116B0
			public static UserLutModel.Settings defaultSettings
			{
				get
				{
					return new UserLutModel.Settings
					{
						lut = null,
						contribution = 1f
					};
				}
			}

			// Token: 0x04000432 RID: 1074
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			// Token: 0x04000433 RID: 1075
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;
		}
	}
}
