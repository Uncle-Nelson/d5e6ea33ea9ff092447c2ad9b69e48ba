using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public class SpherePoint
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x0002DCC9 File Offset: 0x0002BEC9
		public SpherePoint(float horizontalRotation, float verticalRotation)
		{
			this.horizontalRotation = horizontalRotation;
			this.verticalRotation = verticalRotation;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002DCE0 File Offset: 0x0002BEE0
		public SpherePoint(Vector3 worldDirection)
		{
			Vector2 vector = SphereUtility.DirectionToSphericalCoordinate(worldDirection);
			this.horizontalRotation = vector.x;
			this.verticalRotation = vector.y;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002DD14 File Offset: 0x0002BF14
		public void SetFromWorldDirection(Vector3 worldDirection)
		{
			Vector2 vector = SphereUtility.DirectionToSphericalCoordinate(worldDirection);
			this.horizontalRotation = vector.x;
			this.verticalRotation = vector.y;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002DD40 File Offset: 0x0002BF40
		public Vector3 GetWorldDirection()
		{
			return SphereUtility.SphericalCoordinateToDirection(new Vector2(this.horizontalRotation, this.verticalRotation));
		}

		// Token: 0x04000B4F RID: 2895
		public float horizontalRotation;

		// Token: 0x04000B50 RID: 2896
		public float verticalRotation;

		// Token: 0x04000B51 RID: 2897
		public const float MinHorizontalRotation = -3.1415927f;

		// Token: 0x04000B52 RID: 2898
		public const float MaxHorizontalRotation = 3.1415927f;

		// Token: 0x04000B53 RID: 2899
		public const float MinVerticalRotation = -1.5707964f;

		// Token: 0x04000B54 RID: 2900
		public const float MaxVerticalRotation = 1.5707964f;
	}
}
