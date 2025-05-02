using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x0200096C RID: 2412
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x0600419C RID: 16796 RVA: 0x00113B10 File Offset: 0x00111D10
		public void ApplySettings(AvatarSettings settings)
		{
			this.SetLeftBrowRestingHeight(settings.EyebrowRestingHeight);
			this.SetRightBrowRestingHeight(settings.EyebrowRestingHeight);
			this.leftBrow.SetScale(settings.EyebrowScale);
			this.rightBrow.SetScale(settings.EyebrowScale);
			this.leftBrow.SetThickness(settings.EyebrowThickness);
			this.rightBrow.SetThickness(settings.EyebrowThickness);
			this.leftBrow.SetRestingAngle(settings.EyebrowRestingAngle);
			this.rightBrow.SetRestingAngle(settings.EyebrowRestingAngle);
			this.leftBrow.SetColor(settings.HairColor);
			this.rightBrow.SetColor(settings.HairColor);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00113BBD File Offset: 0x00111DBD
		public void SetLeftBrowRestingHeight(float normalizedHeight)
		{
			this.leftBrow.SetRestingHeight(normalizedHeight);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00113BCB File Offset: 0x00111DCB
		public void SetRightBrowRestingHeight(float normalizedHeight)
		{
			this.rightBrow.SetRestingHeight(normalizedHeight);
		}

		// Token: 0x04002F2A RID: 12074
		[Header("References")]
		public Eyebrow leftBrow;

		// Token: 0x04002F2B RID: 12075
		public Eyebrow rightBrow;
	}
}
