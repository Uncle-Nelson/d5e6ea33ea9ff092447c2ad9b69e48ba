using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A21 RID: 2593
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x060045F6 RID: 17910 RVA: 0x0012596C File Offset: 0x00123B6C
		public void UpdateStatus()
		{
			float b = 0f;
			this.animateText = false;
			PlayerCrimeData.EPursuitLevel currentPursuitLevel = Player.Local.CrimeData.CurrentPursuitLevel;
			this.InvestigatingMask.gameObject.SetActive(currentPursuitLevel == PlayerCrimeData.EPursuitLevel.Investigating);
			this.UnderArrestMask.gameObject.SetActive(currentPursuitLevel == PlayerCrimeData.EPursuitLevel.Arresting);
			this.WantedMask.gameObject.SetActive(currentPursuitLevel == PlayerCrimeData.EPursuitLevel.NonLethal);
			this.WantedDeadMask.gameObject.SetActive(currentPursuitLevel == PlayerCrimeData.EPursuitLevel.Lethal);
			this.BodysearchLabel.SetActive(currentPursuitLevel == PlayerCrimeData.EPursuitLevel.None && Player.Local.CrimeData.BodySearchPending);
			if (currentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				b = 0.6f;
				if (Player.Local.CrimeData.TimeSinceSighted < 3f)
				{
					b = 1f;
					this.animateText = true;
					if (this.routine == null)
					{
						this.routine = base.StartCoroutine(this.Routine());
					}
				}
			}
			else if (Player.Local.CrimeData.BodySearchPending)
			{
				b = 1f;
			}
			float fillAmount = 1f - Mathf.Clamp01((Player.Local.CrimeData.TimeSinceSighted - 3f) / Player.Local.CrimeData.GetSearchTime());
			this.InvestigatingMask.fillAmount = fillAmount;
			this.UnderArrestMask.fillAmount = fillAmount;
			this.WantedMask.fillAmount = fillAmount;
			this.WantedDeadMask.fillAmount = fillAmount;
			this.CrimeStatusGroup.alpha = Mathf.Lerp(this.CrimeStatusGroup.alpha, b, Time.deltaTime);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00125AE7 File Offset: 0x00123CE7
		private void OnDestroy()
		{
			if (this.routine != null && Singleton<CoroutineService>.InstanceExists)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.Routine());
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00125B08 File Offset: 0x00123D08
		private IEnumerator Routine()
		{
			this.CrimeStatusContainer.localScale = Vector3.one * 0.75f;
			for (;;)
			{
				if (!this.animateText)
				{
					yield return new WaitForEndOfFrame();
				}
				else
				{
					float lerpTime = 1.5f;
					float t = 0f;
					while (t < lerpTime)
					{
						t += Time.deltaTime;
						this.CrimeStatusContainer.localScale = Vector3.one * Mathf.Lerp(0.75f, 1f, (Mathf.Sin(t / lerpTime * 2f * 3.1415927f) + 1f) / 2f);
						yield return new WaitForEndOfFrame();
					}
				}
			}
			yield break;
		}

		// Token: 0x04003385 RID: 13189
		public const float SmallTextSize = 0.75f;

		// Token: 0x04003386 RID: 13190
		public const float LargeTextSize = 1f;

		// Token: 0x04003387 RID: 13191
		[Header("References")]
		public RectTransform CrimeStatusContainer;

		// Token: 0x04003388 RID: 13192
		public CanvasGroup CrimeStatusGroup;

		// Token: 0x04003389 RID: 13193
		public GameObject BodysearchLabel;

		// Token: 0x0400338A RID: 13194
		public Image InvestigatingMask;

		// Token: 0x0400338B RID: 13195
		public Image UnderArrestMask;

		// Token: 0x0400338C RID: 13196
		public Image WantedMask;

		// Token: 0x0400338D RID: 13197
		public Image WantedDeadMask;

		// Token: 0x0400338E RID: 13198
		public GameObject ArrestProgressContainer;

		// Token: 0x0400338F RID: 13199
		private bool animateText;

		// Token: 0x04003390 RID: 13200
		private Coroutine routine;
	}
}
