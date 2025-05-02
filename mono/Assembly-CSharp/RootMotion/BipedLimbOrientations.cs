using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class BipedLimbOrientations
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00004A96 File Offset: 0x00002C96
		public BipedLimbOrientations(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg)
		{
			this.leftArm = leftArm;
			this.rightArm = rightArm;
			this.leftLeg = leftLeg;
			this.rightLeg = rightLeg;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004ABC File Offset: 0x00002CBC
		public static BipedLimbOrientations UMA
		{
			get
			{
				return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004B20 File Offset: 0x00002D20
		public static BipedLimbOrientations MaxBiped
		{
			get
			{
				return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
			}
		}

		// Token: 0x04000083 RID: 131
		public BipedLimbOrientations.LimbOrientation leftArm;

		// Token: 0x04000084 RID: 132
		public BipedLimbOrientations.LimbOrientation rightArm;

		// Token: 0x04000085 RID: 133
		public BipedLimbOrientations.LimbOrientation leftLeg;

		// Token: 0x04000086 RID: 134
		public BipedLimbOrientations.LimbOrientation rightLeg;

		// Token: 0x020000CF RID: 207
		[Serializable]
		public class LimbOrientation
		{
			// Token: 0x06000661 RID: 1633 RVA: 0x0002B209 File Offset: 0x00029409
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
				this.upperBoneForwardAxis = upperBoneForwardAxis;
				this.lowerBoneForwardAxis = lowerBoneForwardAxis;
				this.lastBoneLeftAxis = lastBoneLeftAxis;
			}

			// Token: 0x040005F9 RID: 1529
			public Vector3 upperBoneForwardAxis;

			// Token: 0x040005FA RID: 1530
			public Vector3 lowerBoneForwardAxis;

			// Token: 0x040005FB RID: 1531
			public Vector3 lastBoneLeftAxis;
		}
	}
}
