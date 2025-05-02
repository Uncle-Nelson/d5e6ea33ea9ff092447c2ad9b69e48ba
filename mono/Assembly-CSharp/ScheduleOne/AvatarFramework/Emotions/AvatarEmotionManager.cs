using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000987 RID: 2439
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x001155A6 File Offset: 0x001137A6
		// (set) Token: 0x06004228 RID: 16936 RVA: 0x001155AE File Offset: 0x001137AE
		public string CurrentEmotion { get; protected set; } = "Neutral";

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x001155B7 File Offset: 0x001137B7
		// (set) Token: 0x0600422A RID: 16938 RVA: 0x001155BF File Offset: 0x001137BF
		public AvatarEmotionPreset CurrentEmotionPreset { get; protected set; }

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x001155C8 File Offset: 0x001137C8
		public bool IsSwitchingEmotion
		{
			get
			{
				return this.emotionLerpRoutine != null;
			}
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x001155D4 File Offset: 0x001137D4
		private void Start()
		{
			this.neutralPreset = this.EmotionPresetList.Find((AvatarEmotionPreset x) => x.PresetName == "Neutral");
			this.AddEmotionOverride("Neutral", "base_emotion", 0f, -1);
			base.InvokeRepeating("UpdateEmotion", 0f, 0.25f);
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Update()
		{
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0011563C File Offset: 0x0011383C
		public void UpdateEmotion()
		{
			if (PlayerSingleton<PlayerCamera>.InstanceExists && Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) > 30f)
			{
				return;
			}
			EmotionOverride highestPriorityOverride = this.GetHighestPriorityOverride();
			if (highestPriorityOverride == null)
			{
				return;
			}
			if (highestPriorityOverride != this.activeEmotionOverride)
			{
				this.activeEmotionOverride = highestPriorityOverride;
				this.LerpEmotion(this.GetEmotion(highestPriorityOverride.Emotion), 0.2f);
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x001156AC File Offset: 0x001138AC
		public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
			this.neutralPreset = this.EmotionPresetList.Find((AvatarEmotionPreset x) => x.PresetName == "Neutral");
			if (this.neutralPreset == null)
			{
				Debug.LogError("Could not find neutral preset");
				return;
			}
			this.neutralPreset.FaceTexture = faceTex;
			this.neutralPreset.BrowAngleChange_R = restingBrowAngle;
			this.neutralPreset.BrowAngleChange_L = restingBrowAngle;
			this.neutralPreset.BrowHeightChange_L = restingBrowHeight;
			this.neutralPreset.BrowHeightChange_R = restingBrowHeight;
			this.neutralPreset.LeftEyeRestingState = leftEyelidConfig;
			this.neutralPreset.RightEyeRestingState = rightEyelidConfig;
			if (this.CurrentEmotionPreset == this.neutralPreset)
			{
				this.SetEmotion(this.neutralPreset);
			}
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x0011576C File Offset: 0x0011396C
		public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
			AvatarEmotionManager.<>c__DisplayClass25_0 CS$<>8__locals1 = new AvatarEmotionManager.<>c__DisplayClass25_0();
			CS$<>8__locals1.overrideLabel = overrideLabel;
			CS$<>8__locals1.duration = duration;
			CS$<>8__locals1.<>4__this = this;
			EmotionOverride emotionOverride = this.overrideStack.Find((EmotionOverride x) => x.Label.ToLower() == CS$<>8__locals1.overrideLabel.ToLower());
			if (emotionOverride != null)
			{
				emotionOverride.Emotion = emotionName;
				emotionOverride.Priority = priority;
				if (emotionOverride == this.activeEmotionOverride)
				{
					this.activeEmotionOverride = null;
				}
			}
			else
			{
				emotionOverride = new EmotionOverride(emotionName, CS$<>8__locals1.overrideLabel, priority);
				this.overrideStack.Add(emotionOverride);
			}
			this.ClearRemovalRoutine(CS$<>8__locals1.overrideLabel);
			if (CS$<>8__locals1.duration > 0f)
			{
				Coroutine value = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<AddEmotionOverride>g__RemoveEmotionAfterDuration|1());
				this.emotionRemovalRoutines.Add(CS$<>8__locals1.overrideLabel.ToLower(), value);
			}
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x0011582C File Offset: 0x00113A2C
		public void RemoveEmotionOverride(string label)
		{
			this.ClearRemovalRoutine(label);
			EmotionOverride emotionOverride = this.overrideStack.Find((EmotionOverride x) => x.Label.ToLower() == label.ToLower());
			if (emotionOverride == null)
			{
				return;
			}
			this.overrideStack.Remove(emotionOverride);
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0011587C File Offset: 0x00113A7C
		public void ClearOverrides()
		{
			EmotionOverride[] array = this.overrideStack.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i].Label == "base_emotion"))
				{
					this.RemoveEmotionOverride(array[i].Label);
				}
			}
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x001158C8 File Offset: 0x00113AC8
		private void ClearRemovalRoutine(string label)
		{
			label = label.ToLower();
			if (this.emotionRemovalRoutines.ContainsKey(label))
			{
				if (this.emotionRemovalRoutines[label] != null)
				{
					base.StopCoroutine(this.emotionRemovalRoutines[label]);
				}
				this.emotionRemovalRoutines.Remove(label);
			}
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x00115918 File Offset: 0x00113B18
		public EmotionOverride GetHighestPriorityOverride()
		{
			return (from x in this.overrideStack
			orderby x.Priority descending
			select x).ToList<EmotionOverride>().FirstOrDefault<EmotionOverride>();
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x00115950 File Offset: 0x00113B50
		private void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
			AvatarEmotionManager.<>c__DisplayClass30_0 CS$<>8__locals1 = new AvatarEmotionManager.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.preset = preset;
			CS$<>8__locals1.animationTime = animationTime;
			if (this.CurrentEmotionPreset == null)
			{
				this.SetEmotion(CS$<>8__locals1.preset);
				return;
			}
			if (this.emotionLerpRoutine != null)
			{
				base.StopCoroutine(this.emotionLerpRoutine);
			}
			this.emotionLerpRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<LerpEmotion>g__Routine|0());
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001159B8 File Offset: 0x00113BB8
		private void SetEmotion(AvatarEmotionPreset preset)
		{
			this.CurrentEmotionPreset = preset;
			this.Avatar.SetFaceTexture(preset.FaceTexture, Color.black);
			this.EyeController.SetLeftEyeRestingLidState(preset.LeftEyeRestingState);
			this.EyeController.SetRightEyeRestingLidState(preset.RightEyeRestingState);
			this.EyeController.LeftRestingEyeState = preset.LeftEyeRestingState;
			this.EyeController.RightRestingEyeState = preset.RightEyeRestingState;
			this.EyebrowController.SetLeftBrowRestingHeight(preset.BrowHeightChange_L);
			this.EyebrowController.SetRightBrowRestingHeight(preset.BrowHeightChange_R);
			this.EyebrowController.leftBrow.SetRestingAngle(preset.BrowAngleChange_L);
			this.EyebrowController.rightBrow.SetRestingAngle(preset.BrowAngleChange_R);
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00115A74 File Offset: 0x00113C74
		public bool HasEmotion(string emotion)
		{
			return this.GetEmotion(emotion) != null;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00115A80 File Offset: 0x00113C80
		public AvatarEmotionPreset GetEmotion(string emotion)
		{
			return this.EmotionPresetList.Find((AvatarEmotionPreset x) => x.PresetName.ToLower() == emotion.ToLower());
		}

		// Token: 0x04002FC8 RID: 12232
		public const float MAX_UPDATE_DISTANCE = 30f;

		// Token: 0x04002FCB RID: 12235
		[Header("Settings")]
		public List<AvatarEmotionPreset> EmotionPresetList = new List<AvatarEmotionPreset>();

		// Token: 0x04002FCC RID: 12236
		[Header("References")]
		public Avatar Avatar;

		// Token: 0x04002FCD RID: 12237
		public EyeController EyeController;

		// Token: 0x04002FCE RID: 12238
		public EyebrowController EyebrowController;

		// Token: 0x04002FCF RID: 12239
		private EmotionOverride activeEmotionOverride;

		// Token: 0x04002FD0 RID: 12240
		private List<EmotionOverride> overrideStack = new List<EmotionOverride>();

		// Token: 0x04002FD1 RID: 12241
		private AvatarEmotionPreset neutralPreset;

		// Token: 0x04002FD2 RID: 12242
		private Coroutine emotionLerpRoutine;

		// Token: 0x04002FD3 RID: 12243
		private Dictionary<string, Coroutine> emotionRemovalRoutines = new Dictionary<string, Coroutine>();

		// Token: 0x04002FD4 RID: 12244
		private int tempIndex;
	}
}
