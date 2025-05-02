using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Materials;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A8 RID: 1960
	public class FootstepSounds : MonoBehaviour
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x000E00D8 File Offset: 0x000DE2D8
		private void Start()
		{
			foreach (FootstepSounds.FootstepSoundGroup footstepSoundGroup in this.soundGroups)
			{
				foreach (FootstepSounds.FootstepSoundGroup.MaterialType materialType in footstepSoundGroup.appliesTo)
				{
					if (!this.materialFootstepSounds.ContainsKey(materialType.type))
					{
						this.materialFootstepSounds.Add(materialType.type, footstepSoundGroup);
					}
				}
			}
			foreach (object obj in Enum.GetValues(typeof(EMaterialType)))
			{
				EMaterialType key = (EMaterialType)obj;
				if (!this.materialFootstepSounds.ContainsKey(key))
				{
					Console.Log("No footstep sounds for material type: " + key.ToString() + "\n Assigning to default group.", null);
					this.materialFootstepSounds.Add(key, this.soundGroups[0]);
				}
			}
			for (int i = 0; i < this.sources.Count; i++)
			{
				this.sources[i].AudioSource.enabled = false;
				this.sources[i].enabled = false;
			}
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000E0268 File Offset: 0x000DE468
		private void Update()
		{
			this.lastStepTime += Time.deltaTime;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000E027C File Offset: 0x000DE47C
		public void Step(EMaterialType materialType, float hardness)
		{
			FootstepSounds.<>c__DisplayClass8_0 CS$<>8__locals1 = new FootstepSounds.<>c__DisplayClass8_0();
			if (this.lastStepTime < 0.15f)
			{
				return;
			}
			this.lastStepTime = 0f;
			CS$<>8__locals1.source = this.GetFreeSource();
			if (CS$<>8__locals1.source == null)
			{
				Console.LogWarning("No free audio sources available for footstep sound.", null);
				return;
			}
			FootstepSounds.FootstepSoundGroup footstepSoundGroup = this.materialFootstepSounds[materialType];
			CS$<>8__locals1.source.AudioSource.clip = footstepSoundGroup.clips[Random.Range(0, footstepSoundGroup.clips.Count)];
			CS$<>8__locals1.source.AudioSource.pitch = Random.Range(footstepSoundGroup.PitchMin, footstepSoundGroup.PitchMax);
			CS$<>8__locals1.source.SetVolume(footstepSoundGroup.Volume * hardness);
			CS$<>8__locals1.source.AudioSource.enabled = true;
			CS$<>8__locals1.source.enabled = true;
			CS$<>8__locals1.source.Play();
			base.StartCoroutine(CS$<>8__locals1.<Step>g__DisableSource|0());
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000E0370 File Offset: 0x000DE570
		public AudioSourceController GetFreeSource()
		{
			return this.sources.FirstOrDefault((AudioSourceController source) => !source.enabled);
		}

		// Token: 0x04002640 RID: 9792
		public const float COOLDOWN_TIME = 0.15f;

		// Token: 0x04002641 RID: 9793
		public List<AudioSourceController> sources = new List<AudioSourceController>();

		// Token: 0x04002642 RID: 9794
		public List<FootstepSounds.FootstepSoundGroup> soundGroups = new List<FootstepSounds.FootstepSoundGroup>();

		// Token: 0x04002643 RID: 9795
		private Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds = new Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup>();

		// Token: 0x04002644 RID: 9796
		private float lastStepTime;

		// Token: 0x020007A9 RID: 1961
		[Serializable]
		public class FootstepSoundGroup
		{
			// Token: 0x04002645 RID: 9797
			public string name;

			// Token: 0x04002646 RID: 9798
			public List<AudioClip> clips = new List<AudioClip>();

			// Token: 0x04002647 RID: 9799
			public List<FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo = new List<FootstepSounds.FootstepSoundGroup.MaterialType>();

			// Token: 0x04002648 RID: 9800
			public float PitchMin = 0.9f;

			// Token: 0x04002649 RID: 9801
			public float PitchMax = 1.1f;

			// Token: 0x0400264A RID: 9802
			public float Volume = 0.5f;

			// Token: 0x020007AA RID: 1962
			[Serializable]
			public class MaterialType
			{
				// Token: 0x0400264B RID: 9803
				public EMaterialType type;
			}
		}
	}
}
