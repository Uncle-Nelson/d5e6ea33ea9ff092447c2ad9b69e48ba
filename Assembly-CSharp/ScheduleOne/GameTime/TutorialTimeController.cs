using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002B2 RID: 690
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x06000ED2 RID: 3794 RVA: 0x00041A4B File Offset: 0x0003FC4B
		private void Awake()
		{
			TimeManager.onSleepStart = (Action)Delegate.Combine(TimeManager.onSleepStart, new Action(this.IncrementKeyframe));
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00041A6D File Offset: 0x0003FC6D
		private void OnDestroy()
		{
			TimeManager.onSleepStart = (Action)Delegate.Remove(TimeManager.onSleepStart, new Action(this.IncrementKeyframe));
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00041A90 File Offset: 0x0003FC90
		private void Update()
		{
			if (this.disabled)
			{
				return;
			}
			TutorialTimeController.KeyFrame keyFrame = this.KeyFrames[this.currentKeyFrameIndex];
			float time = Mathf.Clamp01(Mathf.InverseLerp((float)this.GetCurrentKeyFrameStart(), (float)keyFrame.Time, (float)NetworkSingleton<TimeManager>.Instance.CurrentTime));
			float timeProgressionMultiplier = this.TimeProgressionCurve.Evaluate(time) * keyFrame.SpeedMultiplier;
			NetworkSingleton<TimeManager>.Instance.TimeProgressionMultiplier = timeProgressionMultiplier;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00041AFB File Offset: 0x0003FCFB
		private int GetCurrentKeyFrameStart()
		{
			if (this.currentKeyFrameIndex > 0)
			{
				return this.KeyFrames[this.currentKeyFrameIndex - 1].Time;
			}
			return NetworkSingleton<TimeManager>.Instance.DefaultTime;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00041B2C File Offset: 0x0003FD2C
		[Button]
		public void IncrementKeyframe()
		{
			Console.Log("Incrementing keyframe to " + (this.currentKeyFrameIndex + 1).ToString(), null);
			this.currentKeyFrameIndex = Mathf.Clamp(this.currentKeyFrameIndex + 1, 0, this.KeyFrames.Length - 1);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00041B77 File Offset: 0x0003FD77
		public void Disable()
		{
			NetworkSingleton<TimeManager>.Instance.TimeProgressionMultiplier = 1f;
			base.enabled = false;
			this.disabled = true;
		}

		// Token: 0x04000F45 RID: 3909
		public AnimationCurve TimeProgressionCurve;

		// Token: 0x04000F46 RID: 3910
		public TutorialTimeController.KeyFrame[] KeyFrames;

		// Token: 0x04000F47 RID: 3911
		[SerializeField]
		private int currentKeyFrameIndex;

		// Token: 0x04000F48 RID: 3912
		private bool disabled;

		// Token: 0x020002B3 RID: 691
		[Serializable]
		public struct KeyFrame
		{
			// Token: 0x04000F49 RID: 3913
			public int Time;

			// Token: 0x04000F4A RID: 3914
			public float SpeedMultiplier;

			// Token: 0x04000F4B RID: 3915
			public string Note;
		}
	}
}
