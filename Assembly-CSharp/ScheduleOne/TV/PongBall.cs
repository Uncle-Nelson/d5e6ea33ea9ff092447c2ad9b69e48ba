using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x0200029A RID: 666
	public class PongBall : MonoBehaviour
	{
		// Token: 0x06000DD5 RID: 3541 RVA: 0x000045B1 File Offset: 0x000027B1
		private void FixedUpdate()
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0003DC94 File Offset: 0x0003BE94
		private void OnCollisionEnter(Collision collision)
		{
			if (collision.collider.gameObject.name == "LeftGoal")
			{
				this.Game.GoalHit(Pong.ESide.Left);
			}
			else if (collision.collider.gameObject.name == "RightGoal")
			{
				this.Game.GoalHit(Pong.ESide.Right);
			}
			if (this.RB.velocity.y < 0.1f && collision.collider.GetComponent<PongPaddle>() != null)
			{
				float magnitude = this.RB.velocity.magnitude;
				this.RB.AddForce(new Vector3(0f, Random.Range(-this.RandomForce, this.RandomForce), 0f), 2);
				this.RB.velocity = this.RB.velocity.normalized * magnitude;
			}
			if (this.onHit != null)
			{
				this.onHit.Invoke();
			}
		}

		// Token: 0x04000E76 RID: 3702
		public Pong Game;

		// Token: 0x04000E77 RID: 3703
		public RectTransform Rect;

		// Token: 0x04000E78 RID: 3704
		public Rigidbody RB;

		// Token: 0x04000E79 RID: 3705
		public float RandomForce = 0.5f;

		// Token: 0x04000E7A RID: 3706
		public UnityEvent onHit;
	}
}
