using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E3 RID: 483
	[RequireComponent(typeof(MeshRenderer))]
	public class WeatherEnclosure : MonoBehaviour
	{
		// Token: 0x04000BAA RID: 2986
		public Vector2 nearTextureTiling = new Vector3(1f, 1f);

		// Token: 0x04000BAB RID: 2987
		public Vector2 farTextureTiling = new Vector2(1f, 1f);
	}
}
