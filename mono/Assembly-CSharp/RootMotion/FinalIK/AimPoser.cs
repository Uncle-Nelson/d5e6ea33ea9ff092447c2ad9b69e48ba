using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000072 RID: 114
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		public AimPoser.Pose GetPose(Vector3 localDirection)
		{
			if (this.poses.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < this.poses.Length - 1; i++)
			{
				if (this.poses[i].IsInDirection(localDirection))
				{
					return this.poses[i];
				}
			}
			return this.poses[this.poses.Length - 1];
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001F71C File Offset: 0x0001D91C
		public void SetPoseActive(AimPoser.Pose pose)
		{
			for (int i = 0; i < this.poses.Length; i++)
			{
				this.poses[i].SetAngleBuffer((this.poses[i] == pose) ? this.angleBuffer : 0f);
			}
		}

		// Token: 0x04000398 RID: 920
		public float angleBuffer = 5f;

		// Token: 0x04000399 RID: 921
		public AimPoser.Pose[] poses = new AimPoser.Pose[0];

		// Token: 0x02000109 RID: 265
		[Serializable]
		public class Pose
		{
			// Token: 0x060007C0 RID: 1984 RVA: 0x00033834 File Offset: 0x00031A34
			public bool IsInDirection(Vector3 d)
			{
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.yaw <= 0f || this.pitch <= 0f)
				{
					return false;
				}
				if (this.yaw < 180f)
				{
					Vector3 forward = new Vector3(this.direction.x, 0f, this.direction.z);
					if (forward == Vector3.zero)
					{
						forward = Vector3.forward;
					}
					if (Vector3.Angle(new Vector3(d.x, 0f, d.z), forward) > this.yaw + this.angleBuffer)
					{
						return false;
					}
				}
				if (this.pitch >= 180f)
				{
					return true;
				}
				float num = Vector3.Angle(Vector3.up, this.direction);
				return Mathf.Abs(Vector3.Angle(Vector3.up, d) - num) < this.pitch + this.angleBuffer;
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00033921 File Offset: 0x00031B21
			public void SetAngleBuffer(float value)
			{
				this.angleBuffer = value;
			}

			// Token: 0x040007BC RID: 1980
			public bool visualize = true;

			// Token: 0x040007BD RID: 1981
			public string name;

			// Token: 0x040007BE RID: 1982
			public Vector3 direction;

			// Token: 0x040007BF RID: 1983
			public float yaw = 75f;

			// Token: 0x040007C0 RID: 1984
			public float pitch = 45f;

			// Token: 0x040007C1 RID: 1985
			private float angleBuffer;
		}
	}
}
