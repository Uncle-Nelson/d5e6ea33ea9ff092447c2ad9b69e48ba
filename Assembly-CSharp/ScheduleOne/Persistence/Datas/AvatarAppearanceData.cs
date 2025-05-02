using System;
using ScheduleOne.AvatarFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		// Token: 0x06001534 RID: 5428 RVA: 0x0005F480 File Offset: 0x0005D680
		public AvatarAppearanceData(AvatarSettings avatarSettings)
		{
			this.AvatarSettings = avatarSettings;
		}

		// Token: 0x0400136B RID: 4971
		public AvatarSettings AvatarSettings;
	}
}
