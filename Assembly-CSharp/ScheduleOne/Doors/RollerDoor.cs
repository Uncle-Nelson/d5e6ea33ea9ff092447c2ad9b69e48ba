using System;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068E RID: 1678
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000C3140 File Offset: 0x000C1340
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x000C3148 File Offset: 0x000C1348
		public bool IsOpen { get; protected set; } = true;

		// Token: 0x06002E85 RID: 11909 RVA: 0x000C3151 File Offset: 0x000C1351
		private void Awake()
		{
			this.Door.localPosition = (this.IsOpen ? this.LocalPos_Open : this.LocalPos_Closed);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000C3174 File Offset: 0x000C1374
		private void LateUpdate()
		{
			this.timeSinceValueChange += Time.deltaTime;
			if (this.timeSinceValueChange < this.LerpTime)
			{
				Vector3 b = this.IsOpen ? this.LocalPos_Open : this.LocalPos_Closed;
				this.Door.localPosition = Vector3.Lerp(this.startPos, b, this.timeSinceValueChange / this.LerpTime);
			}
			else
			{
				this.Door.localPosition = (this.IsOpen ? this.LocalPos_Open : this.LocalPos_Closed);
			}
			if (this.Blocker != null)
			{
				this.Blocker.gameObject.SetActive(!this.IsOpen);
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000C3226 File Offset: 0x000C1426
		public void Open()
		{
			if (this.IsOpen)
			{
				return;
			}
			if (!this.CanOpen())
			{
				return;
			}
			this.IsOpen = true;
			this.timeSinceValueChange = 0f;
			this.startPos = this.Door.localPosition;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000C325D File Offset: 0x000C145D
		public void Close()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.IsOpen = false;
			this.timeSinceValueChange = 0f;
			this.startPos = this.Door.localPosition;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000022C9 File Offset: 0x000004C9
		protected virtual bool CanOpen()
		{
			return true;
		}

		// Token: 0x04002104 RID: 8452
		[Header("Settings")]
		public Transform Door;

		// Token: 0x04002105 RID: 8453
		public Vector3 LocalPos_Open;

		// Token: 0x04002106 RID: 8454
		public Vector3 LocalPos_Closed;

		// Token: 0x04002107 RID: 8455
		public float LerpTime = 1f;

		// Token: 0x04002108 RID: 8456
		public GameObject Blocker;

		// Token: 0x04002109 RID: 8457
		private Vector3 startPos = Vector3.zero;

		// Token: 0x0400210A RID: 8458
		private float timeSinceValueChange;
	}
}
