using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000190 RID: 400
	public class SpriteArtItem : ScriptableObject
	{
		// Token: 0x04000933 RID: 2355
		public Mesh mesh;

		// Token: 0x04000934 RID: 2356
		public Material material;

		// Token: 0x04000935 RID: 2357
		public int rows;

		// Token: 0x04000936 RID: 2358
		public int columns;

		// Token: 0x04000937 RID: 2359
		public int totalFrames;

		// Token: 0x04000938 RID: 2360
		public int animateSpeed;

		// Token: 0x04000939 RID: 2361
		[Tooltip("Color that will be multiplied against the base lightning bolt text color")]
		public Color tintColor = Color.white;
	}
}
