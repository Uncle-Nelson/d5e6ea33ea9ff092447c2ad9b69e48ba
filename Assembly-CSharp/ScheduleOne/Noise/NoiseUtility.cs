using System;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x0200053C RID: 1340
	public static class NoiseUtility
	{
		// Token: 0x060020A7 RID: 8359 RVA: 0x00086374 File Offset: 0x00084574
		public static void EmitNoise(Vector3 origin, ENoiseType type, float range, GameObject source = null)
		{
			NoiseEvent nEvent = new NoiseEvent(origin, range, type, source);
			for (int i = 0; i < Listener.listeners.Count; i++)
			{
				if (Listener.listeners[i].enabled && Vector3.Magnitude(origin - Listener.listeners[i].HearingOrigin.position) <= Listener.listeners[i].Sensitivity * range)
				{
					Listener.listeners[i].Notify(nEvent);
				}
			}
		}
	}
}
