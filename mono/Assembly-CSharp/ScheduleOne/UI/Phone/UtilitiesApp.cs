using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Money;
using ScheduleOne.Property;
using ScheduleOne.Property.Utilities.Power;
using ScheduleOne.Property.Utilities.Water;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A98 RID: 2712
	public class UtilitiesApp : App<UtilitiesApp>
	{
		// Token: 0x060048F1 RID: 18673 RVA: 0x00131F40 File Offset: 0x00130140
		protected override void Awake()
		{
			base.Awake();
			this.water_Cost.text = "Cost per litre: $" + WaterManager.pricePerL.ToString();
			this.electricity_Cost.text = "Cost per kWh $" + PowerManager.pricePerkWh.ToString();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.RefreshShownValues));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Combine(instance2.onDayPass, new Action(this.OnDayPass));
			PropertyDropdown propertyDropdown = this.propertySelector;
			propertyDropdown.onSelectionChanged = (Action)Delegate.Combine(propertyDropdown.onSelectionChanged, new Action(this.RefreshShownValues));
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00132008 File Offset: 0x00130208
		protected override void OnDestroy()
		{
			base.OnDestroy();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.RefreshShownValues));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Remove(instance2.onDayPass, new Action(this.OnDayPass));
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00132069 File Offset: 0x00130269
		protected override void Update()
		{
			base.Update();
			if (base.isOpen)
			{
				this.selectedProperty = this.propertySelector.selectedProperty;
			}
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0013208C File Offset: 0x0013028C
		protected virtual void RefreshShownValues()
		{
			if (!base.isOpen)
			{
				return;
			}
			this.selectedProperty = this.propertySelector.selectedProperty;
			this.water_Usage.text = "Water usage: " + this.Round(Singleton<WaterManager>.Instance.GetTotalUsage(), 1f).ToString() + " litres";
			this.water_Total.text = "Total cost: " + MoneyManager.FormatAmount(this.Round(Singleton<WaterManager>.Instance.GetTotalUsage() * WaterManager.pricePerL, 2f), true, false);
			this.electricity_Usage.text = "Electricity usage: " + this.Round(Singleton<PowerManager>.Instance.GetTotalUsage(), 2f).ToString() + " kWh";
			this.electricity_Total.text = "Total cost: " + MoneyManager.FormatAmount(this.Round(Singleton<PowerManager>.Instance.GetTotalUsage() * PowerManager.pricePerkWh, 2f), true, false);
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void OnDayPass()
		{
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x0013218F File Offset: 0x0013038F
		private float Round(float n, float decimals)
		{
			return Mathf.Round(n * Mathf.Pow(10f, decimals)) / Mathf.Pow(10f, decimals);
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x001321AF File Offset: 0x001303AF
		public override void SetOpen(bool open)
		{
			base.SetOpen(open);
			if (open)
			{
				this.RefreshShownValues();
			}
		}

		// Token: 0x0400360E RID: 13838
		[Header("References")]
		[SerializeField]
		protected Text water_Usage;

		// Token: 0x0400360F RID: 13839
		[SerializeField]
		protected Text water_Cost;

		// Token: 0x04003610 RID: 13840
		[SerializeField]
		protected Text water_Total;

		// Token: 0x04003611 RID: 13841
		[SerializeField]
		protected Text electricity_Usage;

		// Token: 0x04003612 RID: 13842
		[SerializeField]
		protected Text electricity_Cost;

		// Token: 0x04003613 RID: 13843
		[SerializeField]
		protected Text electricity_Total;

		// Token: 0x04003614 RID: 13844
		[SerializeField]
		protected Text dumpster_Count;

		// Token: 0x04003615 RID: 13845
		[SerializeField]
		protected Text dumpster_EmptyCost;

		// Token: 0x04003616 RID: 13846
		[SerializeField]
		protected Text dumpster_Total;

		// Token: 0x04003617 RID: 13847
		[SerializeField]
		protected Button dumpsterButton;

		// Token: 0x04003618 RID: 13848
		[SerializeField]
		protected PropertyDropdown propertySelector;

		// Token: 0x04003619 RID: 13849
		private Property selectedProperty;
	}
}
