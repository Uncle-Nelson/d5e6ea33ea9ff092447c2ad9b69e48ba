using System;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002D2 RID: 722
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06000F9F RID: 3999 RVA: 0x00045A28 File Offset: 0x00043C28
		private void Awake()
		{
			this.skateboard = base.GetComponent<Skateboard>();
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00045A38 File Offset: 0x00043C38
		private void LateUpdate()
		{
			Vector3 euler = new Vector3(0f, 0f, this.skateboard.CurrentSteerInput * -this.MaxBoardLean);
			this.Board.localRotation = Quaternion.Lerp(this.Board.localRotation, Quaternion.Euler(euler), Time.deltaTime * this.BoardLeanRate);
		}

		// Token: 0x0400104C RID: 4172
		[Header("Settings")]
		public float MaxBoardLean = 8f;

		// Token: 0x0400104D RID: 4173
		public float BoardLeanRate = 2f;

		// Token: 0x0400104E RID: 4174
		[Header("References")]
		public Transform Board;

		// Token: 0x0400104F RID: 4175
		private Skateboard skateboard;
	}
}
