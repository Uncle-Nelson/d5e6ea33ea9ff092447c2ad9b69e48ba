using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x02000560 RID: 1376
	public class VendorZone : MonoBehaviour
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x0008A376 File Offset: 0x00088576
		public bool isOpen
		{
			get
			{
				return NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.openTime, this.closeTime);
			}
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0008A38E File Offset: 0x0008858E
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPassed));
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0008A3B6 File Offset: 0x000885B6
		private void MinPassed()
		{
			if (this.isOpen)
			{
				this.SetDoorsActive(false);
				return;
			}
			if (!this.IsPlayerWithinVendorZone())
			{
				this.SetDoorsActive(true);
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0008A3D8 File Offset: 0x000885D8
		private bool IsPlayerWithinVendorZone()
		{
			return this.zoneCollider.bounds.Contains(PlayerSingleton<PlayerMovement>.Instance.transform.position);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0008A408 File Offset: 0x00088608
		private void SetDoorsActive(bool a)
		{
			for (int i = 0; i < this.doors.Count; i++)
			{
				this.doors[i].SetActive(a);
			}
		}

		// Token: 0x040019C8 RID: 6600
		[Header("References")]
		[SerializeField]
		protected BoxCollider zoneCollider;

		// Token: 0x040019C9 RID: 6601
		[SerializeField]
		protected List<GameObject> doors = new List<GameObject>();

		// Token: 0x040019CA RID: 6602
		[Header("Settings")]
		[SerializeField]
		protected int openTime = 600;

		// Token: 0x040019CB RID: 6603
		[SerializeField]
		protected int closeTime = 1800;
	}
}
