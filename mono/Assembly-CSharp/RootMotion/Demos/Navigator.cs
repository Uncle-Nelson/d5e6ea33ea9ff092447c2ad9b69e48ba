using System;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	// Token: 0x020000C8 RID: 200
	[Serializable]
	public class Navigator
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0002ADA1 File Offset: 0x00028FA1
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0002ADA9 File Offset: 0x00028FA9
		public Vector3 normalizedDeltaPosition { get; private set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0002ADB2 File Offset: 0x00028FB2
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x0002ADBA File Offset: 0x00028FBA
		public Navigator.State state { get; private set; }

		// Token: 0x06000654 RID: 1620 RVA: 0x0002ADC4 File Offset: 0x00028FC4
		public void Initiate(Transform transform)
		{
			this.transform = transform;
			this.path = new NavMeshPath();
			this.initiated = true;
			this.cornerIndex = 0;
			this.corners = new Vector3[0];
			this.state = Navigator.State.Idle;
			this.lastTargetPosition = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0002AE20 File Offset: 0x00029020
		public void Update(Vector3 targetPosition)
		{
			if (!this.initiated)
			{
				Debug.LogError("Trying to update an uninitiated Navigator.");
				return;
			}
			switch (this.state)
			{
			case Navigator.State.Idle:
				if (this.activeTargetSeeking && Time.time > this.nextPathTime)
				{
					this.CalculatePath(targetPosition);
				}
				break;
			case Navigator.State.Seeking:
				this.normalizedDeltaPosition = Vector3.zero;
				if (this.path.status == NavMeshPathStatus.PathComplete)
				{
					this.corners = this.path.corners;
					this.cornerIndex = 0;
					if (this.corners.Length == 0)
					{
						Debug.LogWarning("Zero Corner Path", this.transform);
						this.Stop();
					}
					else
					{
						this.state = Navigator.State.OnPath;
					}
				}
				if (this.path.status == NavMeshPathStatus.PathPartial)
				{
					Debug.LogWarning("Path Partial", this.transform);
				}
				if (this.path.status == NavMeshPathStatus.PathInvalid)
				{
					Debug.LogWarning("Path Invalid", this.transform);
					return;
				}
				break;
			case Navigator.State.OnPath:
				if (this.activeTargetSeeking && Time.time > this.nextPathTime && this.HorDistance(targetPosition, this.lastTargetPosition) > this.recalculateOnPathDistance)
				{
					this.CalculatePath(targetPosition);
					return;
				}
				if (this.cornerIndex < this.corners.Length)
				{
					Vector3 a = this.corners[this.cornerIndex] - this.transform.position;
					a.y = 0f;
					float magnitude = a.magnitude;
					if (magnitude > 0f)
					{
						this.normalizedDeltaPosition = a / a.magnitude;
					}
					else
					{
						this.normalizedDeltaPosition = Vector3.zero;
					}
					if (magnitude < this.cornerRadius)
					{
						this.cornerIndex++;
						if (this.cornerIndex >= this.corners.Length)
						{
							this.Stop();
							return;
						}
					}
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0002AFDD File Offset: 0x000291DD
		private void CalculatePath(Vector3 targetPosition)
		{
			if (this.Find(targetPosition))
			{
				this.lastTargetPosition = targetPosition;
				this.state = Navigator.State.Seeking;
			}
			else
			{
				this.Stop();
			}
			this.nextPathTime = Time.time + this.nextPathInterval;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002B010 File Offset: 0x00029210
		private bool Find(Vector3 targetPosition)
		{
			if (this.HorDistance(this.transform.position, targetPosition) < this.cornerRadius * 2f)
			{
				return false;
			}
			if (NavMesh.CalculatePath(this.transform.position, targetPosition, -1, this.path))
			{
				return true;
			}
			NavMeshHit navMeshHit = default(NavMeshHit);
			return NavMesh.SamplePosition(targetPosition, out navMeshHit, this.maxSampleDistance, -1) && NavMesh.CalculatePath(this.transform.position, navMeshHit.position, -1, this.path);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0002B097 File Offset: 0x00029297
		private void Stop()
		{
			this.state = Navigator.State.Idle;
			this.normalizedDeltaPosition = Vector3.zero;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0002B0AB File Offset: 0x000292AB
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return Vector2.Distance(new Vector2(p1.x, p1.z), new Vector2(p2.x, p2.z));
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002B0D4 File Offset: 0x000292D4
		public void Visualize()
		{
			if (this.state == Navigator.State.Idle)
			{
				Gizmos.color = Color.gray;
			}
			if (this.state == Navigator.State.Seeking)
			{
				Gizmos.color = Color.red;
			}
			if (this.state == Navigator.State.OnPath)
			{
				Gizmos.color = Color.green;
			}
			if (this.corners.Length != 0 && this.state == Navigator.State.OnPath && this.cornerIndex == 0)
			{
				Gizmos.DrawLine(this.transform.position, this.corners[0]);
			}
			for (int i = 0; i < this.corners.Length; i++)
			{
				Gizmos.DrawSphere(this.corners[i], 0.1f);
			}
			if (this.corners.Length > 1)
			{
				for (int j = 0; j < this.corners.Length - 1; j++)
				{
					Gizmos.DrawLine(this.corners[j], this.corners[j + 1]);
				}
			}
			Gizmos.color = Color.white;
		}

		// Token: 0x040005CD RID: 1485
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		// Token: 0x040005CE RID: 1486
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius = 0.5f;

		// Token: 0x040005CF RID: 1487
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance = 1f;

		// Token: 0x040005D0 RID: 1488
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance = 5f;

		// Token: 0x040005D1 RID: 1489
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval = 3f;

		// Token: 0x040005D4 RID: 1492
		private Transform transform;

		// Token: 0x040005D5 RID: 1493
		private int cornerIndex;

		// Token: 0x040005D6 RID: 1494
		private Vector3[] corners = new Vector3[0];

		// Token: 0x040005D7 RID: 1495
		private NavMeshPath path;

		// Token: 0x040005D8 RID: 1496
		private Vector3 lastTargetPosition;

		// Token: 0x040005D9 RID: 1497
		private bool initiated;

		// Token: 0x040005DA RID: 1498
		private float nextPathTime;

		// Token: 0x0200012F RID: 303
		public enum State
		{
			// Token: 0x040008A0 RID: 2208
			Idle,
			// Token: 0x040008A1 RID: 2209
			Seeking,
			// Token: 0x040008A2 RID: 2210
			OnPath
		}
	}
}
