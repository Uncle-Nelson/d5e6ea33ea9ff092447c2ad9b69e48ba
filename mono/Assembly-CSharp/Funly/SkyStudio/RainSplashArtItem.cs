using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200018E RID: 398
	[CreateAssetMenu(fileName = "rainSplashArtItem.asset", menuName = "Sky Studio/Rain/Rain Splash Art Item")]
	public class RainSplashArtItem : SpriteArtItem
	{
		// Token: 0x04000930 RID: 2352
		[Range(0f, 1f)]
		public float intensityMultiplier = 1f;

		// Token: 0x04000931 RID: 2353
		[Range(0f, 1f)]
		public float scaleMultiplier = 1f;
	}
}
