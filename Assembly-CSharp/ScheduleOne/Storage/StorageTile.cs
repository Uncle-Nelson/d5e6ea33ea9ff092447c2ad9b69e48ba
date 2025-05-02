using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B0 RID: 2224
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x000FEAD6 File Offset: 0x000FCCD6
		public StorageGrid _ownerGrid
		{
			get
			{
				return this.ownerGrid;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x000FEADE File Offset: 0x000FCCDE
		// (set) Token: 0x06003C7B RID: 15483 RVA: 0x000FEAE6 File Offset: 0x000FCCE6
		public StoredItem occupant { get; protected set; }

		// Token: 0x06003C7C RID: 15484 RVA: 0x000FEAEF File Offset: 0x000FCCEF
		public void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
			this.x = _x;
			this.y = _y;
			this.ownerGrid = _ownerGrid;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x000FEB07 File Offset: 0x000FCD07
		public void SetOccupant(StoredItem occ)
		{
			if (occ != null && this.occupant != null)
			{
				Console.LogWarning("SetOccupant called by there is an existing occupant. Existing occupant should be dealt with before calling this.", null);
			}
			this.occupant = occ;
			if (this.onOccupantChanged != null)
			{
				this.onOccupantChanged();
			}
		}

		// Token: 0x04002B78 RID: 11128
		public int x;

		// Token: 0x04002B79 RID: 11129
		public int y;

		// Token: 0x04002B7A RID: 11130
		[SerializeField]
		public StorageGrid ownerGrid;

		// Token: 0x04002B7B RID: 11131
		public Action onOccupantChanged;
	}
}
