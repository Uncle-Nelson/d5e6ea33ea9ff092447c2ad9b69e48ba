using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000690 RID: 1680
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000C3365 File Offset: 0x000C1565
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x000C336D File Offset: 0x000C156D
		public bool IsOpen { get; protected set; }

		// Token: 0x06002E8F RID: 11919 RVA: 0x000C3376 File Offset: 0x000C1576
		public virtual void Opened(EDoorSide openSide)
		{
			this.IsOpen = true;
			this.Move();
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000C3385 File Offset: 0x000C1585
		public virtual void Closed()
		{
			this.IsOpen = false;
			this.Move();
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000C3394 File Offset: 0x000C1594
		private void Move()
		{
			if (this.MoveRoutine != null)
			{
				base.StopCoroutine(this.MoveRoutine);
			}
			this.MoveRoutine = base.StartCoroutine(this.<Move>g__Move|12_0());
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000C33CF File Offset: 0x000C15CF
		[CompilerGenerated]
		private IEnumerator <Move>g__Move|12_0()
		{
			Vector3 start = this.DoorTransform.position;
			Vector3 end = this.IsOpen ? this.OpenPosition.position : this.ClosedPosition.position;
			for (float i = 0f; i < this.SlideDuration; i += Time.deltaTime)
			{
				this.DoorTransform.position = Vector3.Lerp(start, end, this.SlideCurve.Evaluate(i / this.SlideDuration));
				yield return new WaitForEndOfFrame();
			}
			this.DoorTransform.position = end;
			this.MoveRoutine = null;
			yield break;
		}

		// Token: 0x0400210F RID: 8463
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x04002110 RID: 8464
		public Transform ClosedPosition;

		// Token: 0x04002111 RID: 8465
		public Transform OpenPosition;

		// Token: 0x04002112 RID: 8466
		public float SlideDuration = 3f;

		// Token: 0x04002113 RID: 8467
		public AnimationCurve SlideCurve;

		// Token: 0x04002114 RID: 8468
		private Coroutine MoveRoutine;
	}
}
