using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A4 RID: 2212
	public class PalletSlot : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x000FC931 File Offset: 0x000FAB31
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x000FC939 File Offset: 0x000FAB39
		public Guid GUID { get; protected set; }

		// Token: 0x06003BF4 RID: 15348 RVA: 0x000FC942 File Offset: 0x000FAB42
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x000FC951 File Offset: 0x000FAB51
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x000FC959 File Offset: 0x000FAB59
		public Pallet occupant { get; protected set; }

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000FC962 File Offset: 0x000FAB62
		public void SetOccupant(Pallet _occupant)
		{
			this.occupant = _occupant;
			if (this.occupant != null)
			{
				if (this.onPalletAdded != null)
				{
					this.onPalletAdded();
					return;
				}
			}
			else if (this.onPalletRemoved != null)
			{
				this.onPalletRemoved();
			}
		}

		// Token: 0x04002B4D RID: 11085
		public Action onPalletAdded;

		// Token: 0x04002B4E RID: 11086
		public Action onPalletRemoved;
	}
}
