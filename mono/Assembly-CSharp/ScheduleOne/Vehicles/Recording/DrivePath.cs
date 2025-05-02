using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	// Token: 0x020007E1 RID: 2017
	[CreateAssetMenu(fileName = "DrivePath", menuName = "ScriptableObjects/DrivePath", order = 1)]
	[Serializable]
	public class DrivePath : ScriptableObject
	{
		// Token: 0x040027BE RID: 10174
		public int fps = 24;

		// Token: 0x040027BF RID: 10175
		public List<VehicleKeyFrame> keyframes = new List<VehicleKeyFrame>();
	}
}
