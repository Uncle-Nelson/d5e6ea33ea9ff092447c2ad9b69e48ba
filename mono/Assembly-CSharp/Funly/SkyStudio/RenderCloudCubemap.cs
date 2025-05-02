using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D0 RID: 464
	[RequireComponent(typeof(Camera))]
	public class RenderCloudCubemap : MonoBehaviour
	{
		// Token: 0x04000B3D RID: 2877
		public const string kDefaultFilenamePrefix = "CloudCubemap";

		// Token: 0x04000B3E RID: 2878
		[Tooltip("Filename of the final output cubemap asset. It will be written to the same directory as the current scene.")]
		public string filenamePrefix = "CloudCubemap";

		// Token: 0x04000B3F RID: 2879
		[Tooltip("Resolution of each face of the cubemap.")]
		public int faceWidth = 1024;

		// Token: 0x04000B40 RID: 2880
		[Tooltip("Format for the exported cubemap. RGBColor (Additive texture), RGBAColor (Color with alpha channel), RGBANormal (Normal lighting data encoded).")]
		public RenderCloudCubemap.CubemapTextureFormat textureFormat = RenderCloudCubemap.CubemapTextureFormat.RGBALit;

		// Token: 0x04000B41 RID: 2881
		public bool exportFaces;

		// Token: 0x020001D1 RID: 465
		public enum CubemapTextureFormat
		{
			// Token: 0x04000B43 RID: 2883
			RGBColor,
			// Token: 0x04000B44 RID: 2884
			RGBAColor,
			// Token: 0x04000B45 RID: 2885
			RGBALit
		}
	}
}
