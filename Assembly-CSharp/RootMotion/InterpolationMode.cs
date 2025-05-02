using System;

namespace RootMotion
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public enum InterpolationMode
	{
		// Token: 0x040000B0 RID: 176
		None,
		// Token: 0x040000B1 RID: 177
		InOutCubic,
		// Token: 0x040000B2 RID: 178
		InOutQuintic,
		// Token: 0x040000B3 RID: 179
		InOutSine,
		// Token: 0x040000B4 RID: 180
		InQuintic,
		// Token: 0x040000B5 RID: 181
		InQuartic,
		// Token: 0x040000B6 RID: 182
		InCubic,
		// Token: 0x040000B7 RID: 183
		InQuadratic,
		// Token: 0x040000B8 RID: 184
		InElastic,
		// Token: 0x040000B9 RID: 185
		InElasticSmall,
		// Token: 0x040000BA RID: 186
		InElasticBig,
		// Token: 0x040000BB RID: 187
		InSine,
		// Token: 0x040000BC RID: 188
		InBack,
		// Token: 0x040000BD RID: 189
		OutQuintic,
		// Token: 0x040000BE RID: 190
		OutQuartic,
		// Token: 0x040000BF RID: 191
		OutCubic,
		// Token: 0x040000C0 RID: 192
		OutInCubic,
		// Token: 0x040000C1 RID: 193
		OutInQuartic,
		// Token: 0x040000C2 RID: 194
		OutElastic,
		// Token: 0x040000C3 RID: 195
		OutElasticSmall,
		// Token: 0x040000C4 RID: 196
		OutElasticBig,
		// Token: 0x040000C5 RID: 197
		OutSine,
		// Token: 0x040000C6 RID: 198
		OutBack,
		// Token: 0x040000C7 RID: 199
		OutBackCubic,
		// Token: 0x040000C8 RID: 200
		OutBackQuartic,
		// Token: 0x040000C9 RID: 201
		BackInCubic,
		// Token: 0x040000CA RID: 202
		BackInQuartic
	}
}
