using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200084F RID: 2127
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x06003A54 RID: 14932 RVA: 0x000F689C File Offset: 0x000F4A9C
		private void Start()
		{
			TimeZoneInfo sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
			DateTime dateTime = new DateTime(this.Year, this.Month, this.Day, this.Hour, this.Minute, this.Second, DateTimeKind.Unspecified);
			this.targetPDTDate = TimeZoneInfo.ConvertTimeToUtc(dateTime, sourceTimeZone);
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x000F68ED File Offset: 0x000F4AED
		private void Update()
		{
			this.UpdateCountdown();
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x000F68F8 File Offset: 0x000F4AF8
		private void UpdateCountdown()
		{
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan = this.targetPDTDate - utcNow;
			if (timeSpan.TotalSeconds > 0.0)
			{
				this.TimeLabel.text = this.FormatTime(timeSpan);
				return;
			}
			this.TimeLabel.text = "Now available!";
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x000F6950 File Offset: 0x000F4B50
		private string FormatTime(TimeSpan timeSpan)
		{
			return string.Concat(new string[]
			{
				timeSpan.Days.ToString(),
				" days, ",
				timeSpan.Hours.ToString(),
				" hours, ",
				timeSpan.Minutes.ToString(),
				" minutes"
			});
		}

		// Token: 0x040029FD RID: 10749
		public TextMeshProUGUI TimeLabel;

		// Token: 0x040029FE RID: 10750
		[Header("Date Setting")]
		public int Year = 2025;

		// Token: 0x040029FF RID: 10751
		public int Month = 3;

		// Token: 0x04002A00 RID: 10752
		public int Day = 24;

		// Token: 0x04002A01 RID: 10753
		public int Hour = 16;

		// Token: 0x04002A02 RID: 10754
		public int Minute;

		// Token: 0x04002A03 RID: 10755
		public int Second;

		// Token: 0x04002A04 RID: 10756
		private DateTime targetPDTDate;
	}
}
