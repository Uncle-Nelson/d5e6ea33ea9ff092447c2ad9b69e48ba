using System;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D5 RID: 2005
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x060036D0 RID: 14032 RVA: 0x000E6E00 File Offset: 0x000E5000
		public virtual void OnVehicleStart()
		{
			ParticleSystem[] array = this.exhaustFX;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Play();
			}
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000E6E2C File Offset: 0x000E502C
		public virtual void OnVehicleStop()
		{
			ParticleSystem[] array = this.exhaustFX;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Stop();
			}
		}

		// Token: 0x04002756 RID: 10070
		public ParticleSystem[] exhaustFX;
	}
}
