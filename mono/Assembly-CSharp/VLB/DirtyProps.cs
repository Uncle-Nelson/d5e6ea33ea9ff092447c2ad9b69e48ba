using System;

namespace VLB
{
	// Token: 0x0200010C RID: 268
	[Flags]
	public enum DirtyProps
	{
		// Token: 0x040005D1 RID: 1489
		None = 0,
		// Token: 0x040005D2 RID: 1490
		Intensity = 2,
		// Token: 0x040005D3 RID: 1491
		HDRPExposureWeight = 4,
		// Token: 0x040005D4 RID: 1492
		ColorMode = 8,
		// Token: 0x040005D5 RID: 1493
		Color = 16,
		// Token: 0x040005D6 RID: 1494
		BlendingMode = 32,
		// Token: 0x040005D7 RID: 1495
		Cone = 64,
		// Token: 0x040005D8 RID: 1496
		SideSoftness = 128,
		// Token: 0x040005D9 RID: 1497
		Attenuation = 256,
		// Token: 0x040005DA RID: 1498
		Dimensions = 512,
		// Token: 0x040005DB RID: 1499
		RaymarchingQuality = 1024,
		// Token: 0x040005DC RID: 1500
		Jittering = 2048,
		// Token: 0x040005DD RID: 1501
		NoiseMode = 4096,
		// Token: 0x040005DE RID: 1502
		NoiseIntensity = 8192,
		// Token: 0x040005DF RID: 1503
		NoiseVelocityAndScale = 16384,
		// Token: 0x040005E0 RID: 1504
		CookieProps = 32768,
		// Token: 0x040005E1 RID: 1505
		ShadowProps = 65536,
		// Token: 0x040005E2 RID: 1506
		AllWithoutMaterialChange = 125142,
		// Token: 0x040005E3 RID: 1507
		OnlyMaterialChangeOnly = 5928,
		// Token: 0x040005E4 RID: 1508
		All = 131070
	}
}
