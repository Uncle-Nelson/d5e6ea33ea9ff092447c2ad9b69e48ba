using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x02000538 RID: 1336
	public class Listener : MonoBehaviour
	{
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x000862AF File Offset: 0x000844AF
		// (set) Token: 0x0600209B RID: 8347 RVA: 0x000862B7 File Offset: 0x000844B7
		public float SquaredHearingRange { get; protected set; }

		// Token: 0x0600209C RID: 8348 RVA: 0x000862C0 File Offset: 0x000844C0
		public void Awake()
		{
			this.SquaredHearingRange = Mathf.Pow(this.Sensitivity, 2f);
			if (this.HearingOrigin == null)
			{
				this.HearingOrigin = base.transform;
			}
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000862F2 File Offset: 0x000844F2
		public void OnEnable()
		{
			if (!Listener.listeners.Contains(this))
			{
				Listener.listeners.Add(this);
			}
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0008630C File Offset: 0x0008450C
		public void OnDisable()
		{
			Listener.listeners.Remove(this);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0008631A File Offset: 0x0008451A
		public void Notify(NoiseEvent nEvent)
		{
			if (this.onNoiseHeard != null)
			{
				this.onNoiseHeard(nEvent);
			}
		}

		// Token: 0x04001930 RID: 6448
		public static List<Listener> listeners = new List<Listener>();

		// Token: 0x04001931 RID: 6449
		[Header("Settings")]
		[Range(0.1f, 5f)]
		public float Sensitivity = 1f;

		// Token: 0x04001932 RID: 6450
		public Transform HearingOrigin;

		// Token: 0x04001934 RID: 6452
		public Listener.HearingEvent onNoiseHeard;

		// Token: 0x02000539 RID: 1337
		// (Invoke) Token: 0x060020A3 RID: 8355
		public delegate void HearingEvent(NoiseEvent nEvent);
	}
}
