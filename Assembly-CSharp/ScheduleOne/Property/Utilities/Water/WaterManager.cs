using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000824 RID: 2084
	public class WaterManager : Singleton<WaterManager>
	{
		// Token: 0x060038F7 RID: 14583 RVA: 0x000F0C14 File Offset: 0x000EEE14
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Combine(instance2.onDayPass, new Action(this.DayPass));
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000F0C73 File Offset: 0x000EEE73
		private void MinPass()
		{
			this.usageThisMinute = 0f;
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x000F0C80 File Offset: 0x000EEE80
		private void DayPass()
		{
			this.usageAtTime.Clear();
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x000F0C90 File Offset: 0x000EEE90
		public float GetTotalUsage()
		{
			float num = 0f;
			foreach (int key in this.usageAtTime.Keys)
			{
				num += this.usageAtTime[key];
			}
			return num;
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000F0CF8 File Offset: 0x000EEEF8
		public void ConsumeWater(float litres)
		{
			this.usageThisMinute += litres;
		}

		// Token: 0x04002945 RID: 10565
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject waterPipePrefab;

		// Token: 0x04002946 RID: 10566
		public static float pricePerL = 0.1f;

		// Token: 0x04002947 RID: 10567
		private Dictionary<int, float> usageAtTime = new Dictionary<int, float>();

		// Token: 0x04002948 RID: 10568
		private float usageThisMinute;
	}
}
