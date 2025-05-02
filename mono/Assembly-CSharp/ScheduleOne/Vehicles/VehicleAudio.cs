using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D1 RID: 2001
	public class VehicleAudio : MonoBehaviour
	{
		// Token: 0x060036BA RID: 14010 RVA: 0x000E6530 File Offset: 0x000E4730
		protected virtual void Awake()
		{
			if (this.Vehicle != null)
			{
				this.Vehicle.onVehicleStart.AddListener(new UnityAction(this.EngineStart));
				this.Vehicle.onVehicleStop.AddListener(new UnityAction(this.EngineStart));
			}
			if (this.Lights != null)
			{
				this.Lights.onHeadlightsOn.AddListener(new UnityAction(this.HeadlightsToggledOn));
				this.Lights.onHeadlightsOff.AddListener(new UnityAction(this.HeadlightsToggledOff));
			}
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void EngineStart()
		{
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void EngineStop()
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void HeadlightsToggledOn()
		{
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void HeadlightsToggledOff()
		{
		}

		// Token: 0x04002738 RID: 10040
		[Header("Refererences")]
		public LandVehicle Vehicle;

		// Token: 0x04002739 RID: 10041
		public VehicleLights Lights;

		// Token: 0x0400273A RID: 10042
		[Header("Sounds")]
		public AudioSource EngineStartSound;

		// Token: 0x0400273B RID: 10043
		public AudioSource EngineStopSound;

		// Token: 0x0400273C RID: 10044
		public AudioSource HeadlightsOnSound;

		// Token: 0x0400273D RID: 10045
		public AudioSource HeadlightsOffSound;

		// Token: 0x0400273E RID: 10046
		public AudioSource HornSound;
	}
}
