using System;
using System.Collections.Generic;
using ScheduleOne.Construction;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000826 RID: 2086
	public class PowerManager : Singleton<PowerManager>
	{
		// Token: 0x06003911 RID: 14609 RVA: 0x000F1628 File Offset: 0x000EF828
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Combine(instance2.onDayPass, new Action(this.DayPass));
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x000F1687 File Offset: 0x000EF887
		private void MinPass()
		{
			this.usageThisMinute = 0f;
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x000F1694 File Offset: 0x000EF894
		private void DayPass()
		{
			this.usageAtTime.Clear();
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x000F16A4 File Offset: 0x000EF8A4
		public float GetTotalUsage()
		{
			float num = 0f;
			foreach (int key in this.usageAtTime.Keys)
			{
				num += this.usageAtTime[key];
			}
			return num;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x000F170C File Offset: 0x000EF90C
		public void ConsumePower(float kwh)
		{
			this.usageThisMinute += kwh;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x000F171C File Offset: 0x000EF91C
		public PowerLine CreatePowerLine(PowerNode nodeA, PowerNode nodeB, Property p)
		{
			if (!PowerLine.CanNodesBeConnected(nodeA, nodeB))
			{
				Console.LogWarning("Nodes can't be connected!", null);
				return null;
			}
			PowerLine component = Singleton<ConstructionManager>.Instance.CreateConstructable("Utilities/PowerLine/PowerLine").GetComponent<PowerLine>();
			component.transform.SetParent(p.Container.transform);
			component.InitializePowerLine(nodeA, nodeB);
			return component;
		}

		// Token: 0x04002955 RID: 10581
		[Header("Prefabs")]
		public GameObject powerLineSegmentPrefab;

		// Token: 0x04002956 RID: 10582
		public static float pricePerkWh = 0.25f;

		// Token: 0x04002957 RID: 10583
		private Dictionary<int, float> usageAtTime = new Dictionary<int, float>();

		// Token: 0x04002958 RID: 10584
		private float usageThisMinute;
	}
}
