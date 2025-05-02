using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200018B RID: 395
	[CreateAssetMenu(fileName = "lightningArtItem.asset", menuName = "Sky Studio/Lightning/Lightning Art Item")]
	public class LightningArtItem : SpriteArtItem
	{
		// Token: 0x04000927 RID: 2343
		[Tooltip("Adjust how the lightning bolt is positioned inside the spawn area container.")]
		public LightningArtItem.Alignment alignment;

		// Token: 0x04000928 RID: 2344
		[Tooltip("Thunder sound clip to play when this lighting bolt is rendered.")]
		public AudioClip thunderSound;

		// Token: 0x04000929 RID: 2345
		[Tooltip("Probability adjustment for this specific lightning bolt. This value is multiplied against the global lightning probability.")]
		[Range(0f, 1f)]
		public float strikeProbability = 1f;

		// Token: 0x0400092A RID: 2346
		[Range(0f, 60f)]
		[Tooltip("Size of the lighting bolt.")]
		public float size = 20f;

		// Token: 0x0400092B RID: 2347
		[Range(0f, 1f)]
		[Tooltip("The blending weight of the additive lighting bolt effect")]
		public float intensity = 1f;

		// Token: 0x0200018C RID: 396
		public enum Alignment
		{
			// Token: 0x0400092D RID: 2349
			ScaleToFit,
			// Token: 0x0400092E RID: 2350
			TopAlign
		}
	}
}
