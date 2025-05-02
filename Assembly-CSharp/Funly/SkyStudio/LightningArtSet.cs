using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200018D RID: 397
	[CreateAssetMenu(fileName = "LightningArtSet.asset", menuName = "Sky Studio/Lightning/Lightning Art Set")]
	public class LightningArtSet : SpriteArtSet
	{
		// Token: 0x0400092F RID: 2351
		[Tooltip("List of lighting bolt art that will be used for customization.")]
		public List<LightningArtItem> lightingStyleItems;
	}
}
