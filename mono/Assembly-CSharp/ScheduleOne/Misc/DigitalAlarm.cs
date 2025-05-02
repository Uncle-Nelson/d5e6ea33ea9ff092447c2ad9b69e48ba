using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C07 RID: 3079
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x06005696 RID: 22166 RVA: 0x0016C1A2 File Offset: 0x0016A3A2
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x0016C1CA File Offset: 0x0016A3CA
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.Instance != null)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x0016C200 File Offset: 0x0016A400
		public void SetScreenLit(bool lit)
		{
			Material[] materials = this.ScreenMesh.materials;
			materials[this.ScreenMeshMaterialIndex] = (lit ? this.ScreenOnMat : this.ScreenOffMat);
			this.ScreenMesh.materials = materials;
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x0016C23E File Offset: 0x0016A43E
		public void DisplayText(string text)
		{
			this.ScreenText.text = text;
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x0016C24C File Offset: 0x0016A44C
		public void DisplayMinutes(int mins)
		{
			int num = mins / 60;
			mins %= 60;
			this.DisplayText(string.Format("{0:D2}:{1:D2}", num, mins));
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x0016C280 File Offset: 0x0016A480
		private void MinPass()
		{
			if (this.DisplayCurrentTime)
			{
				this.DisplayText(TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, false));
			}
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x0016C2A4 File Offset: 0x0016A4A4
		private void FixedUpdate()
		{
			if (this.FlashScreen)
			{
				float num = Mathf.Sin(Time.timeSinceLevelLoad * 4f);
				this.SetScreenLit(num > 0f);
			}
		}

		// Token: 0x04003FF6 RID: 16374
		public const float FLASH_FREQUENCY = 4f;

		// Token: 0x04003FF7 RID: 16375
		public MeshRenderer ScreenMesh;

		// Token: 0x04003FF8 RID: 16376
		public int ScreenMeshMaterialIndex;

		// Token: 0x04003FF9 RID: 16377
		public TextMeshPro ScreenText;

		// Token: 0x04003FFA RID: 16378
		public bool FlashScreen;

		// Token: 0x04003FFB RID: 16379
		[Header("Settings")]
		public bool DisplayCurrentTime;

		// Token: 0x04003FFC RID: 16380
		public Material ScreenOffMat;

		// Token: 0x04003FFD RID: 16381
		public Material ScreenOnMat;
	}
}
