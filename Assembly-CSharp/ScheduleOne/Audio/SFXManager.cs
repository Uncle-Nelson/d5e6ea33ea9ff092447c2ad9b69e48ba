using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B8 RID: 1976
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06003583 RID: 13699 RVA: 0x000E0D44 File Offset: 0x000DEF44
		public void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (Vector3.Distance(position, PlayerSingleton<PlayerCamera>.Instance.transform.position) > 40f)
			{
				Console.LogWarning("Impact sound too far away", null);
				return;
			}
			SFXManager.ImpactType impactType = this.ImpactTypes.Find((SFXManager.ImpactType x) => x.Material == material);
			if (impactType == null)
			{
				Console.LogWarning("No impact type found for material: " + material.ToString(), null);
				return;
			}
			AudioSourceController source = this.GetSource();
			if (source == null)
			{
				Console.LogWarning("No source available", null);
				return;
			}
			source.transform.position = position;
			float num = Mathf.Clamp01(momentum / 100f);
			source.PitchMultiplier = Mathf.Lerp(impactType.MaxPitch, impactType.MinPitch, num);
			source.VolumeMultiplier = Mathf.Lerp(impactType.MinVolume, impactType.MaxVolume, Mathf.Sqrt(num));
			source.AudioSource.clip = impactType.Clips[Random.Range(0, impactType.Clips.Length)];
			source.Play();
			this.soundsInUse.Add(source);
			this.soundPool.Remove(source);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x000E0E74 File Offset: 0x000DF074
		private void FixedUpdate()
		{
			for (int i = this.soundsInUse.Count - 1; i >= 0; i--)
			{
				if (!this.soundsInUse[i].isPlaying)
				{
					this.soundPool.Add(this.soundsInUse[i]);
					this.soundsInUse.RemoveAt(i);
				}
			}
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x000E0ECF File Offset: 0x000DF0CF
		private AudioSourceController GetSource()
		{
			if (this.soundPool.Count == 0)
			{
				Console.Log("No more sources available", null);
				return null;
			}
			return this.soundPool[0];
		}

		// Token: 0x04002679 RID: 9849
		public const float MAX_PLAYER_DISTANCE = 40f;

		// Token: 0x0400267A RID: 9850
		public const float SQR_MAX_PLAYER_DISTANCE = 1600f;

		// Token: 0x0400267B RID: 9851
		public List<SFXManager.ImpactType> ImpactTypes = new List<SFXManager.ImpactType>();

		// Token: 0x0400267C RID: 9852
		[SerializeField]
		private List<AudioSourceController> soundPool = new List<AudioSourceController>();

		// Token: 0x0400267D RID: 9853
		private List<AudioSourceController> soundsInUse = new List<AudioSourceController>();

		// Token: 0x020007B9 RID: 1977
		[Serializable]
		public class ImpactType
		{
			// Token: 0x0400267E RID: 9854
			public ImpactSoundEntity.EMaterial Material;

			// Token: 0x0400267F RID: 9855
			public float MinVolume;

			// Token: 0x04002680 RID: 9856
			public float MaxVolume;

			// Token: 0x04002681 RID: 9857
			public float MinPitch;

			// Token: 0x04002682 RID: 9858
			public float MaxPitch;

			// Token: 0x04002683 RID: 9859
			public AudioClip[] Clips;
		}
	}
}
