using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000669 RID: 1641
	[CreateAssetMenu(fileName = "CustomerData", menuName = "ScriptableObjects/CustomerData", order = 1)]
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x06002CDE RID: 11486 RVA: 0x000BA958 File Offset: 0x000B8B58
		public static float GetQualityScalar(EQuality quality)
		{
			switch (quality)
			{
			case EQuality.Trash:
				return 0f;
			case EQuality.Poor:
				return 0.25f;
			case EQuality.Standard:
				return 0.5f;
			case EQuality.Premium:
				return 0.75f;
			case EQuality.Heavenly:
				return 1f;
			default:
				return 0f;
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000BA9A4 File Offset: 0x000B8BA4
		public List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			float t = Mathf.Max(dependence, normalizedRelationship);
			int num = Mathf.RoundToInt(Mathf.Lerp((float)this.MinOrdersPerWeek, (float)this.MaxOrdersPerWeek, t));
			int preferredOrderDay = (int)this.PreferredOrderDay;
			int num2 = Mathf.RoundToInt(7f / (float)num);
			num2 = Mathf.Max(num2, 1);
			List<EDay> list = new List<EDay>();
			for (int i = 0; i < 7; i += num2)
			{
				list.Add((EDay)((i + preferredOrderDay) % 7));
			}
			return list;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000BAA16 File Offset: 0x000B8C16
		public float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			return Mathf.Lerp(this.MinWeeklySpend, this.MaxWeeklySpend, normalizedRelationship) * LevelManager.GetOrderLimitMultiplier(NetworkSingleton<LevelManager>.Instance.GetFullRank());
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000BAA3C File Offset: 0x000B8C3C
		[Button]
		public void RandomizeAffinities()
		{
			this.DefaultAffinityData = new CustomerAffinityData();
			List<EDrugType> list = Enum.GetValues(typeof(EDrugType)).Cast<EDrugType>().ToList<EDrugType>();
			for (int i = 0; i < list.Count; i++)
			{
				this.DefaultAffinityData.ProductAffinities.Add(new ProductTypeAffinity
				{
					DrugType = list[i],
					Affinity = 0f
				});
			}
			for (int j = 0; j < this.DefaultAffinityData.ProductAffinities.Count; j++)
			{
				this.DefaultAffinityData.ProductAffinities[j].Affinity = Random.Range(-1f, 1f);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000BAAEC File Offset: 0x000B8CEC
		[Button]
		public void RandomizeProperties()
		{
			string[] array = new string[]
			{
				"Properties/Tier1",
				"Properties/Tier2",
				"Properties/Tier3",
				"Properties/Tier4",
				"Properties/Tier5"
			};
			List<Property> list = new List<Property>();
			foreach (string text in array)
			{
				list.AddRange(Resources.LoadAll<Property>(text));
			}
			this.PreferredProperties.Clear();
			for (int j = 0; j < 3; j++)
			{
				int index = Random.Range(0, list.Count);
				this.PreferredProperties.Add(list[index]);
				list.RemoveAt(index);
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000BAB90 File Offset: 0x000B8D90
		[Button]
		public void RandomizeTiming()
		{
			this.PreferredOrderDay = (EDay)Random.Range(0, 7);
			int num = Random.Range(420, 1440);
			num = Mathf.RoundToInt((float)num / 15f) * 15;
			this.OrderTime = TimeManager.Get24HourTimeFromMinSum(num);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000BABD7 File Offset: 0x000B8DD7
		[Button]
		public void ClearInvalid()
		{
			while (this.DefaultAffinityData.ProductAffinities.Count > 3)
			{
				this.DefaultAffinityData.ProductAffinities.RemoveAt(this.DefaultAffinityData.ProductAffinities.Count - 1);
			}
		}

		// Token: 0x04001FED RID: 8173
		public CustomerAffinityData DefaultAffinityData;

		// Token: 0x04001FEE RID: 8174
		[Header("Preferred Properties - Properties the customer prefers in a product.")]
		public List<Property> PreferredProperties = new List<Property>();

		// Token: 0x04001FEF RID: 8175
		[Header("Spending Behaviour")]
		public float MinWeeklySpend = 200f;

		// Token: 0x04001FF0 RID: 8176
		public float MaxWeeklySpend = 500f;

		// Token: 0x04001FF1 RID: 8177
		[Range(0f, 7f)]
		public int MinOrdersPerWeek = 1;

		// Token: 0x04001FF2 RID: 8178
		[Range(0f, 7f)]
		public int MaxOrdersPerWeek = 5;

		// Token: 0x04001FF3 RID: 8179
		[Header("Timing Settings")]
		public int OrderTime = 1200;

		// Token: 0x04001FF4 RID: 8180
		public EDay PreferredOrderDay;

		// Token: 0x04001FF5 RID: 8181
		[Header("Standards")]
		public ECustomerStandard Standards = ECustomerStandard.Moderate;

		// Token: 0x04001FF6 RID: 8182
		[Header("Direct approaching")]
		public bool CanBeDirectlyApproached = true;

		// Token: 0x04001FF7 RID: 8183
		public bool GuaranteeFirstSampleSuccess;

		// Token: 0x04001FF8 RID: 8184
		[Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
		[Range(0f, 5f)]
		public float MinMutualRelationRequirement = 3f;

		// Token: 0x04001FF9 RID: 8185
		[Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
		[Range(0f, 5f)]
		public float MaxMutualRelationRequirement = 5f;

		// Token: 0x04001FFA RID: 8186
		[Tooltip("If direct approach fails, whats the chance the police will be called?")]
		[Range(0f, 1f)]
		public float CallPoliceChance = 0.5f;

		// Token: 0x04001FFB RID: 8187
		[Header("Dependence")]
		[Tooltip("How quickly the customer builds dependence")]
		[Range(0f, 2f)]
		public float DependenceMultiplier = 1f;

		// Token: 0x04001FFC RID: 8188
		[Tooltip("The customer's starting (and lowest possible) dependence level")]
		[Range(0f, 1f)]
		public float BaseAddiction;

		// Token: 0x04001FFD RID: 8189
		public Action onChanged;
	}
}
