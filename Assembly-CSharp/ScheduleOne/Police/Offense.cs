using System;
using System.Collections.Generic;

namespace ScheduleOne.Police
{
	// Token: 0x02000333 RID: 819
	public class Offense
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
		public Offense(List<Offense.Charge> _charges)
		{
			this.charges.AddRange(_charges);
		}

		// Token: 0x04001176 RID: 4470
		public List<Offense.Charge> charges = new List<Offense.Charge>();

		// Token: 0x04001177 RID: 4471
		public List<string> penalties = new List<string>();

		// Token: 0x02000334 RID: 820
		public class Charge
		{
			// Token: 0x06001202 RID: 4610 RVA: 0x0004E6EA File Offset: 0x0004C8EA
			public Charge(string _chargeName, int _crimeIndex, int _quantity)
			{
				this.chargeName = _chargeName;
				this.crimeIndex = _crimeIndex;
				this.quantity = _quantity;
			}

			// Token: 0x04001178 RID: 4472
			public string chargeName = "<ChargeName>";

			// Token: 0x04001179 RID: 4473
			public int crimeIndex = 1;

			// Token: 0x0400117A RID: 4474
			public int quantity = 1;
		}
	}
}
