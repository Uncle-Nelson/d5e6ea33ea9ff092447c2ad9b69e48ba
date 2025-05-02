using System;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043E RID: 1086
	[Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x00060510 File Offset: 0x0005E710
		public VehicleData(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col)
		{
			this.GUID = guid.ToString();
			this.VehicleCode = code;
			this.Position = pos;
			this.Rotation = rot;
			this.Color = col.ToString();
		}

		// Token: 0x0400147D RID: 5245
		public string GUID;

		// Token: 0x0400147E RID: 5246
		public string VehicleCode;

		// Token: 0x0400147F RID: 5247
		public Vector3 Position;

		// Token: 0x04001480 RID: 5248
		public Quaternion Rotation;

		// Token: 0x04001481 RID: 5249
		public string Color;
	}
}
