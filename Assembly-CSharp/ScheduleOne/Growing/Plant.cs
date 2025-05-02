using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Object;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Growing
{
	// Token: 0x02000882 RID: 2178
	public class Plant : MonoBehaviour
	{
		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x000F86FA File Offset: 0x000F68FA
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x000F8702 File Offset: 0x000F6902
		public Pot Pot { get; protected set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x000F870B File Offset: 0x000F690B
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x000F8713 File Offset: 0x000F6913
		public float NormalizedGrowthProgress { get; protected set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x000F871C File Offset: 0x000F691C
		public bool IsFullyGrown
		{
			get
			{
				return this.NormalizedGrowthProgress >= 1f;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x000F872E File Offset: 0x000F692E
		public PlantGrowthStage FinalGrowthStage
		{
			get
			{
				return this.GrowthStages[this.GrowthStages.Length - 1];
			}
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x000F8744 File Offset: 0x000F6944
		public virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
			this.Pot = pot.GetComponent<Pot>();
			if (this.Pot == null)
			{
				Console.LogWarning("Plant.Initialize: pot is null", null);
				return;
			}
			if (yieldLevel > 0f)
			{
				this.YieldLevel = yieldLevel;
			}
			else
			{
				this.YieldLevel = this.BaseYieldLevel;
			}
			if (qualityLevel > 0f)
			{
				this.QualityLevel = qualityLevel;
			}
			else
			{
				this.QualityLevel = this.BaseQualityLevel;
			}
			for (int i = 0; i < this.FinalGrowthStage.GrowthSites.Length; i++)
			{
				this.SetHarvestableActive(i, false);
			}
			this.SetNormalizedGrowthProgress(growthProgress);
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x000F87DC File Offset: 0x000F69DC
		public virtual void Destroy(bool dropScraps = false)
		{
			this.DestroySound.transform.SetParent(NetworkSingleton<GameManager>.Instance.Temp.transform);
			this.DestroySound.PlayOneShot(false);
			Object.Destroy(this.DestroySound, 1f);
			if (dropScraps && this.PlantScrapPrefab != null)
			{
				int num = Random.Range(1, 2);
				for (int i = 0; i < num; i++)
				{
					Vector3 a = this.Pot.LeafDropPoint.forward;
					a += new Vector3(0f, Random.Range(-0.2f, 0.2f), 0f);
					NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.PlantScrapPrefab.ID, this.Pot.LeafDropPoint.position + a * 0.2f, Random.rotation, a * 0.5f, "", false);
				}
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x000F88E4 File Offset: 0x000F6AE4
		public virtual void MinPass()
		{
			if (this.NormalizedGrowthProgress >= 1f)
			{
				return;
			}
			if (NetworkSingleton<TimeManager>.Instance.IsEndOfDay)
			{
				return;
			}
			float num = 1f / ((float)this.GrowthTime * 60f);
			num *= this.Pot.GetAdditiveGrowthMultiplier();
			float num2;
			num *= this.Pot.GetAverageLightExposure(out num2);
			num *= this.Pot.GrowSpeedMultiplier;
			num *= num2;
			if (GameManager.IS_TUTORIAL)
			{
				num *= 0.3f;
			}
			if (this.Pot.NormalizedWaterLevel <= 0f || this.Pot.NormalizedWaterLevel > 1f)
			{
				num *= 0f;
			}
			this.SetNormalizedGrowthProgress(this.NormalizedGrowthProgress + num);
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x000F899C File Offset: 0x000F6B9C
		public virtual void SetNormalizedGrowthProgress(float progress)
		{
			progress = Mathf.Clamp(progress, 0f, 1f);
			float normalizedGrowthProgress = this.NormalizedGrowthProgress;
			this.NormalizedGrowthProgress = progress;
			this.UpdateVisuals();
			if (this.NormalizedGrowthProgress >= 1f && normalizedGrowthProgress < 1f)
			{
				this.GrowthDone();
			}
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x000F89EC File Offset: 0x000F6BEC
		protected virtual void UpdateVisuals()
		{
			int num = Mathf.FloorToInt(this.NormalizedGrowthProgress * (float)this.GrowthStages.Length);
			for (int i = 0; i < this.GrowthStages.Length; i++)
			{
				this.GrowthStages[i].gameObject.SetActive(i + 1 == num);
			}
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000F8A3A File Offset: 0x000F6C3A
		public virtual void SetHarvestableActive(int index, bool active)
		{
			this.FinalGrowthStage.GrowthSites[index].gameObject.SetActive(active);
			this.ActiveHarvestables.Remove(index);
			if (active)
			{
				this.ActiveHarvestables.Add(index);
			}
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x000F8A70 File Offset: 0x000F6C70
		public bool IsHarvestableActive(int index)
		{
			return this.ActiveHarvestables.Contains(index);
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x000F8A80 File Offset: 0x000F6C80
		private void GrowthDone()
		{
			if (InstanceFinder.IsServer)
			{
				if (!this.Pot.IsSpawned)
				{
					Console.LogError("Pot not spawned!", null);
					return;
				}
				int num = Mathf.RoundToInt((float)this.FinalGrowthStage.GrowthSites.Length * this.YieldLevel * this.Pot.YieldMultiplier);
				num = Mathf.Clamp(num, 1, this.FinalGrowthStage.GrowthSites.Length);
				foreach (int harvestableIndex in this.GenerateUniqueIntegers(0, this.FinalGrowthStage.GrowthSites.Length - 1, num))
				{
					this.Pot.SendHarvestableActive(harvestableIndex, true);
				}
			}
			if (this.FullyGrownParticles != null)
			{
				this.FullyGrownParticles.Play();
			}
			if (this.onGrowthDone != null)
			{
				this.onGrowthDone.Invoke();
			}
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x000F8B78 File Offset: 0x000F6D78
		private List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			List<int> list = new List<int>();
			if (max - min + 1 < count)
			{
				Debug.LogWarning("Range is too small to generate the requested number of unique integers.");
				return null;
			}
			List<int> list2 = new List<int>();
			for (int i = min; i <= max; i++)
			{
				list2.Add(i);
			}
			for (int j = 0; j < count; j++)
			{
				int index = Random.Range(0, list2.Count);
				list.Add(list2[index]);
				list2.RemoveAt(index);
			}
			return list;
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x000F8BE9 File Offset: 0x000F6DE9
		public void SetVisible(bool vis)
		{
			this.VisualsContainer.gameObject.SetActive(vis);
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x000F8BFC File Offset: 0x000F6DFC
		public virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			Console.LogError("Plant.GetHarvestedProduct: This method should be overridden by a subclass.", null);
			return null;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x000F8C0A File Offset: 0x000F6E0A
		public PlantData GetPlantData()
		{
			return new PlantData(this.SeedDefinition.ID, this.NormalizedGrowthProgress, this.YieldLevel, this.QualityLevel, this.ActiveHarvestables.ToArray());
		}

		// Token: 0x04002A94 RID: 10900
		[Header("References")]
		public Transform VisualsContainer;

		// Token: 0x04002A95 RID: 10901
		public PlantGrowthStage[] GrowthStages;

		// Token: 0x04002A96 RID: 10902
		public Collider Collider;

		// Token: 0x04002A97 RID: 10903
		public AudioSourceController SnipSound;

		// Token: 0x04002A98 RID: 10904
		public AudioSourceController DestroySound;

		// Token: 0x04002A99 RID: 10905
		public ParticleSystem FullyGrownParticles;

		// Token: 0x04002A9A RID: 10906
		[Header("Settings")]
		public SeedDefinition SeedDefinition;

		// Token: 0x04002A9B RID: 10907
		public int GrowthTime = 48;

		// Token: 0x04002A9C RID: 10908
		public float BaseYieldLevel = 0.6f;

		// Token: 0x04002A9D RID: 10909
		public float BaseQualityLevel = 0.4f;

		// Token: 0x04002A9E RID: 10910
		public string HarvestTarget = "buds";

		// Token: 0x04002A9F RID: 10911
		[Header("Trash")]
		public TrashItem PlantScrapPrefab;

		// Token: 0x04002AA0 RID: 10912
		public UnityEvent onGrowthDone;

		// Token: 0x04002AA1 RID: 10913
		[Header("Plant data")]
		public float YieldLevel;

		// Token: 0x04002AA2 RID: 10914
		public float QualityLevel;

		// Token: 0x04002AA3 RID: 10915
		[HideInInspector]
		public List<int> ActiveHarvestables = new List<int>();
	}
}
