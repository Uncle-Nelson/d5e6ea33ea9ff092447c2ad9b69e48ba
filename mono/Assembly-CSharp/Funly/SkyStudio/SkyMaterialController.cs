using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001C8 RID: 456
	public class SkyMaterialController
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0002A563 File Offset: 0x00028763
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0002A56B File Offset: 0x0002876B
		public Material SkyboxMaterial
		{
			get
			{
				return this._skyboxMaterial;
			}
			set
			{
				this._skyboxMaterial = value;
				RenderSettings.skybox = this._skyboxMaterial;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002A57F File Offset: 0x0002877F
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0002A587 File Offset: 0x00028787
		public Color SkyColor
		{
			get
			{
				return this._skyColor;
			}
			set
			{
				this._skyColor = value;
				this.SkyboxMaterial.SetColor("_GradientSkyUpperColor", this._skyColor);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002A5A6 File Offset: 0x000287A6
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0002A5AE File Offset: 0x000287AE
		public Color SkyMiddleColor
		{
			get
			{
				return this._skyMiddleColor;
			}
			set
			{
				this._skyMiddleColor = value;
				this.SkyboxMaterial.SetColor("_GradientSkyMiddleColor", this._skyMiddleColor);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0002A5CD File Offset: 0x000287CD
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0002A5D5 File Offset: 0x000287D5
		public Color HorizonColor
		{
			get
			{
				return this._horizonColor;
			}
			set
			{
				this._horizonColor = value;
				this.SkyboxMaterial.SetColor("_GradientSkyLowerColor", this._horizonColor);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002A5F4 File Offset: 0x000287F4
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0002A5FC File Offset: 0x000287FC
		public float GradientFadeBegin
		{
			get
			{
				return this._gradientFadeBegin;
			}
			set
			{
				this._gradientFadeBegin = value;
				this.ApplyGradientValuesOnMaterial();
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002A60B File Offset: 0x0002880B
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0002A613 File Offset: 0x00028813
		public float GradientFadeLength
		{
			get
			{
				return this._gradientFadeLength;
			}
			set
			{
				this._gradientFadeLength = value;
				this.ApplyGradientValuesOnMaterial();
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002A622 File Offset: 0x00028822
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0002A62A File Offset: 0x0002882A
		public float SkyMiddlePosition
		{
			get
			{
				return this._skyMiddlePosition;
			}
			set
			{
				this._skyMiddlePosition = value;
				this.SkyboxMaterial.SetFloat("_GradientFadeMiddlePosition", this._skyMiddlePosition);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002A649 File Offset: 0x00028849
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0002A651 File Offset: 0x00028851
		public Cubemap BackgroundCubemap
		{
			get
			{
				return this._backgroundCubemap;
			}
			set
			{
				this._backgroundCubemap = value;
				this.SkyboxMaterial.SetTexture("_MainTex", this._backgroundCubemap);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0002A670 File Offset: 0x00028870
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0002A678 File Offset: 0x00028878
		public float StarFadeBegin
		{
			get
			{
				return this._starFadeBegin;
			}
			set
			{
				this._starFadeBegin = value;
				this.ApplyStarFadeValuesOnMaterial();
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002A687 File Offset: 0x00028887
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0002A68F File Offset: 0x0002888F
		public float StarFadeLength
		{
			get
			{
				return this._starFadeLength;
			}
			set
			{
				this._starFadeLength = value;
				this.ApplyStarFadeValuesOnMaterial();
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002A69E File Offset: 0x0002889E
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0002A6A6 File Offset: 0x000288A6
		public float HorizonDistanceScale
		{
			get
			{
				return this._horizonDistanceScale;
			}
			set
			{
				this._horizonDistanceScale = value;
				this.SkyboxMaterial.SetFloat("_HorizonScaleFactor", this._horizonDistanceScale);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002A6C5 File Offset: 0x000288C5
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0002A6CD File Offset: 0x000288CD
		public Texture StarBasicCubemap
		{
			get
			{
				return this._starBasicCubemap;
			}
			set
			{
				this._starBasicCubemap = value;
				this.SkyboxMaterial.SetTexture("_StarBasicCubemap", this._starBasicCubemap);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002A6EC File Offset: 0x000288EC
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0002A6F4 File Offset: 0x000288F4
		public float StarBasicTwinkleSpeed
		{
			get
			{
				return this._starBasicTwinkleSpeed;
			}
			set
			{
				this._starBasicTwinkleSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarBasicTwinkleSpeed", this._starBasicTwinkleSpeed);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002A713 File Offset: 0x00028913
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x0002A71B File Offset: 0x0002891B
		public float StarBasicTwinkleAmount
		{
			get
			{
				return this._starBasicTwinkleAmount;
			}
			set
			{
				this._starBasicTwinkleAmount = value;
				this.SkyboxMaterial.SetFloat("_StarBasicTwinkleAmount", this._starBasicTwinkleAmount);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002A73A File Offset: 0x0002893A
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x0002A742 File Offset: 0x00028942
		public float StarBasicOpacity
		{
			get
			{
				return this._starBasicOpacity;
			}
			set
			{
				this._starBasicOpacity = value;
				this.SkyboxMaterial.SetFloat("_StarBasicOpacity", this._starBasicOpacity);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002A761 File Offset: 0x00028961
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0002A769 File Offset: 0x00028969
		public Color StarBasicTintColor
		{
			get
			{
				return this._starBasicTintColor;
			}
			set
			{
				this._starBasicTintColor = value;
				this.SkyboxMaterial.SetColor("_StarBasicTintColor", this._starBasicTintColor);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002A788 File Offset: 0x00028988
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0002A790 File Offset: 0x00028990
		public float StarBasicExponent
		{
			get
			{
				return this._starBasicExponent;
			}
			set
			{
				this._starBasicExponent = value;
				this.SkyboxMaterial.SetFloat("_StarBasicExponent", this._starBasicExponent);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002A7AF File Offset: 0x000289AF
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0002A7B7 File Offset: 0x000289B7
		public float StarBasicIntensity
		{
			get
			{
				return this._starBasicIntensity;
			}
			set
			{
				this._starBasicIntensity = value;
				this.SkyboxMaterial.SetFloat("_StarBasicHDRBoost", this._starBasicIntensity);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002A7D6 File Offset: 0x000289D6
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002A7DE File Offset: 0x000289DE
		public Texture StarLayer1Texture
		{
			get
			{
				return this._starLayer1Texture;
			}
			set
			{
				this._starLayer1Texture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer1Tex", this._starLayer1Texture);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002A7FD File Offset: 0x000289FD
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0002A805 File Offset: 0x00028A05
		public Texture2D StarLayer1DataTexture
		{
			get
			{
				return this._starLayer1DataTexture;
			}
			set
			{
				this._starLayer1DataTexture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer1DataTex", value);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002A81F File Offset: 0x00028A1F
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0002A827 File Offset: 0x00028A27
		public Color StarLayer1Color
		{
			get
			{
				return this._starLayer1Color;
			}
			set
			{
				this._starLayer1Color = value;
				this.SkyboxMaterial.SetColor("_StarLayer1Color", this._starLayer1Color);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002A846 File Offset: 0x00028A46
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x0002A84E File Offset: 0x00028A4E
		public float StarLayer1MaxRadius
		{
			get
			{
				return this._starLayer1MaxRadius;
			}
			set
			{
				this._starLayer1MaxRadius = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1MaxRadius", this._starLayer1MaxRadius);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002A86D File Offset: 0x00028A6D
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x0002A875 File Offset: 0x00028A75
		public float StarLayer1TwinkleAmount
		{
			get
			{
				return this._starLayer1TwinkleAmount;
			}
			set
			{
				this._starLayer1TwinkleAmount = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1TwinkleAmount", this._starLayer1TwinkleAmount);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002A894 File Offset: 0x00028A94
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0002A89C File Offset: 0x00028A9C
		public float StarLayer1TwinkleSpeed
		{
			get
			{
				return this._starLayer1TwinkleSpeed;
			}
			set
			{
				this._starLayer1TwinkleSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1TwinkleSpeed", this._starLayer1TwinkleSpeed);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002A8BB File Offset: 0x00028ABB
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0002A8C3 File Offset: 0x00028AC3
		public float StarLayer1RotationSpeed
		{
			get
			{
				return this._starLayer1RotationSpeed;
			}
			set
			{
				this._starLayer1RotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1RotationSpeed", this._starLayer1RotationSpeed);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0002A8E2 File Offset: 0x00028AE2
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0002A8EA File Offset: 0x00028AEA
		public float StarLayer1EdgeFeathering
		{
			get
			{
				return this._starLayer1EdgeFeathering;
			}
			set
			{
				this._starLayer1EdgeFeathering = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1EdgeFade", this._starLayer1EdgeFeathering);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0002A909 File Offset: 0x00028B09
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0002A911 File Offset: 0x00028B11
		public float StarLayer1BloomFilterBoost
		{
			get
			{
				return this._starLayer1BloomFilterBoost;
			}
			set
			{
				this._starLayer1BloomFilterBoost = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1HDRBoost", this._starLayer1BloomFilterBoost);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002A930 File Offset: 0x00028B30
		public void SetStarLayer1SpriteDimensions(int columns, int rows)
		{
			this._starLayer1SpriteDimensions.x = (float)columns;
			this._starLayer1SpriteDimensions.y = (float)rows;
			this.SkyboxMaterial.SetVector("_StarLayer1SpriteDimensions", this._starLayer1SpriteDimensions);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0002A962 File Offset: 0x00028B62
		public Vector2 GetStarLayer1SpriteDimensions()
		{
			return new Vector2(this._starLayer1SpriteDimensions.x, this._starLayer1SpriteDimensions.y);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002A97F File Offset: 0x00028B7F
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0002A987 File Offset: 0x00028B87
		public int StarLayer1SpriteItemCount
		{
			get
			{
				return this._starLayer1SpriteItemCount;
			}
			set
			{
				this._starLayer1SpriteItemCount = value;
				this.SkyboxMaterial.SetInt("_StarLayer1SpriteItemCount", this._starLayer1SpriteItemCount);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002A9A6 File Offset: 0x00028BA6
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0002A9AE File Offset: 0x00028BAE
		public float StarLayer1SpriteAnimationSpeed
		{
			get
			{
				return this._starLayer1SpriteAnimationSpeed;
			}
			set
			{
				this._starLayer1SpriteAnimationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer1SpriteAnimationSpeed", this._starLayer1SpriteAnimationSpeed);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002A9CD File Offset: 0x00028BCD
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0002A9D5 File Offset: 0x00028BD5
		public Texture StarLayer2Texture
		{
			get
			{
				return this._starLayer2Texture;
			}
			set
			{
				this._starLayer2Texture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer2Tex", this._starLayer2Texture);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0002A9FC File Offset: 0x00028BFC
		public Texture2D StarLayer2DataTexture
		{
			get
			{
				return this._starLayer2DataTexture;
			}
			set
			{
				this._starLayer2DataTexture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer2DataTex", value);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002AA16 File Offset: 0x00028C16
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x0002AA1E File Offset: 0x00028C1E
		public Color StarLayer2Color
		{
			get
			{
				return this._starLayer2Color;
			}
			set
			{
				this._starLayer2Color = value;
				this.SkyboxMaterial.SetColor("_StarLayer2Color", this._starLayer2Color);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002AA3D File Offset: 0x00028C3D
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x0002AA45 File Offset: 0x00028C45
		public float StarLayer2MaxRadius
		{
			get
			{
				return this._starLayer2MaxRadius;
			}
			set
			{
				this._starLayer2MaxRadius = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2MaxRadius", this._starLayer2MaxRadius);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002AA64 File Offset: 0x00028C64
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x0002AA6C File Offset: 0x00028C6C
		public float StarLayer2TwinkleAmount
		{
			get
			{
				return this._starLayer2TwinkleAmount;
			}
			set
			{
				this._starLayer2TwinkleAmount = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2TwinkleAmount", this._starLayer2TwinkleAmount);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002AA8B File Offset: 0x00028C8B
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0002AA93 File Offset: 0x00028C93
		public float StarLayer2TwinkleSpeed
		{
			get
			{
				return this._starLayer2TwinkleSpeed;
			}
			set
			{
				this._starLayer2TwinkleSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2TwinkleSpeed", this._starLayer2TwinkleSpeed);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002AAB2 File Offset: 0x00028CB2
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x0002AABA File Offset: 0x00028CBA
		public float StarLayer2RotationSpeed
		{
			get
			{
				return this._starLayer2RotationSpeed;
			}
			set
			{
				this._starLayer2RotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2RotationSpeed", this._starLayer2RotationSpeed);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002AAD9 File Offset: 0x00028CD9
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0002AAE1 File Offset: 0x00028CE1
		public float StarLayer2EdgeFeathering
		{
			get
			{
				return this._starLayer2EdgeFeathering;
			}
			set
			{
				this._starLayer2EdgeFeathering = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2EdgeFade", this._starLayer2EdgeFeathering);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002AB00 File Offset: 0x00028D00
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0002AB08 File Offset: 0x00028D08
		public float StarLayer2BloomFilterBoost
		{
			get
			{
				return this._starLayer2BloomFilterBoost;
			}
			set
			{
				this._starLayer2BloomFilterBoost = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2HDRBoost", this._starLayer2BloomFilterBoost);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002AB27 File Offset: 0x00028D27
		public void SetStarLayer2SpriteDimensions(int columns, int rows)
		{
			this._starLayer2SpriteDimensions.x = (float)columns;
			this._starLayer2SpriteDimensions.y = (float)rows;
			this.SkyboxMaterial.SetVector("_StarLayer2SpriteDimensions", this._starLayer2SpriteDimensions);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002AB59 File Offset: 0x00028D59
		public Vector2 GetStarLayer2SpriteDimensions()
		{
			return new Vector2(this._starLayer2SpriteDimensions.x, this._starLayer2SpriteDimensions.y);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002AB76 File Offset: 0x00028D76
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0002AB7E File Offset: 0x00028D7E
		public int StarLayer2SpriteItemCount
		{
			get
			{
				return this._starLayer2SpriteItemCount;
			}
			set
			{
				this._starLayer2SpriteItemCount = value;
				this.SkyboxMaterial.SetInt("_StarLayer2SpriteItemCount", this._starLayer2SpriteItemCount);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002AB9D File Offset: 0x00028D9D
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002ABA5 File Offset: 0x00028DA5
		public float StarLayer2SpriteAnimationSpeed
		{
			get
			{
				return this._starLayer2SpriteAnimationSpeed;
			}
			set
			{
				this._starLayer2SpriteAnimationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer2SpriteAnimationSpeed", this._starLayer2SpriteAnimationSpeed);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002ABC4 File Offset: 0x00028DC4
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0002ABCC File Offset: 0x00028DCC
		public Texture StarLayer3Texture
		{
			get
			{
				return this._starLayer3Texture;
			}
			set
			{
				this._starLayer3Texture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer3Tex", this._starLayer3Texture);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002ABEB File Offset: 0x00028DEB
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0002ABF3 File Offset: 0x00028DF3
		public Texture2D StarLayer3DataTexture
		{
			get
			{
				return this._starLayer3DataTexture;
			}
			set
			{
				this._starLayer3DataTexture = value;
				this.SkyboxMaterial.SetTexture("_StarLayer3DataTex", value);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002AC0D File Offset: 0x00028E0D
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002AC15 File Offset: 0x00028E15
		public Color StarLayer3Color
		{
			get
			{
				return this._starLayer3Color;
			}
			set
			{
				this._starLayer3Color = value;
				this.SkyboxMaterial.SetColor("_StarLayer3Color", this._starLayer3Color);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002AC34 File Offset: 0x00028E34
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0002AC3C File Offset: 0x00028E3C
		public float StarLayer3MaxRadius
		{
			get
			{
				return this._starLayer3MaxRadius;
			}
			set
			{
				this._starLayer3MaxRadius = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3MaxRadius", this._starLayer3MaxRadius);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002AC5B File Offset: 0x00028E5B
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0002AC63 File Offset: 0x00028E63
		public float StarLayer3TwinkleAmount
		{
			get
			{
				return this._starLayer3TwinkleAmount;
			}
			set
			{
				this._starLayer3TwinkleAmount = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3TwinkleAmount", this._starLayer3TwinkleAmount);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002AC82 File Offset: 0x00028E82
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0002AC8A File Offset: 0x00028E8A
		public float StarLayer3TwinkleSpeed
		{
			get
			{
				return this._starLayer3TwinkleSpeed;
			}
			set
			{
				this._starLayer3TwinkleSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3TwinkleSpeed", this._starLayer3TwinkleSpeed);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002ACA9 File Offset: 0x00028EA9
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0002ACB1 File Offset: 0x00028EB1
		public float StarLayer3RotationSpeed
		{
			get
			{
				return this._starLayer3RotationSpeed;
			}
			set
			{
				this._starLayer3RotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3RotationSpeed", this._starLayer3RotationSpeed);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0002ACD0 File Offset: 0x00028ED0
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		public float StarLayer3EdgeFeathering
		{
			get
			{
				return this._starLayer3EdgeFeathering;
			}
			set
			{
				this._starLayer3EdgeFeathering = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3EdgeFade", this._starLayer3EdgeFeathering);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0002ACF7 File Offset: 0x00028EF7
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0002ACFF File Offset: 0x00028EFF
		public float StarLayer3BloomFilterBoost
		{
			get
			{
				return this._starLayer3BloomFilterBoost;
			}
			set
			{
				this._starLayer3BloomFilterBoost = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3HDRBoost", this._starLayer3BloomFilterBoost);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002AD1E File Offset: 0x00028F1E
		public void SetStarLayer3SpriteDimensions(int columns, int rows)
		{
			this._starLayer3SpriteDimensions.x = (float)columns;
			this._starLayer3SpriteDimensions.y = (float)rows;
			this.SkyboxMaterial.SetVector("_StarLayer3SpriteDimensions", this._starLayer3SpriteDimensions);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0002AD50 File Offset: 0x00028F50
		public Vector2 GetStarLayer3SpriteDimensions()
		{
			return new Vector2(this._starLayer3SpriteDimensions.x, this._starLayer3SpriteDimensions.y);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0002AD6D File Offset: 0x00028F6D
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x0002AD75 File Offset: 0x00028F75
		public int StarLayer3SpriteItemCount
		{
			get
			{
				return this._starLayer3SpriteItemCount;
			}
			set
			{
				this._starLayer3SpriteItemCount = value;
				this.SkyboxMaterial.SetInt("_StarLayer3SpriteItemCount", this._starLayer3SpriteItemCount);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0002AD94 File Offset: 0x00028F94
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0002AD9C File Offset: 0x00028F9C
		public float StarLayer3SpriteAnimationSpeed
		{
			get
			{
				return this._starLayer3SpriteAnimationSpeed;
			}
			set
			{
				this._starLayer3SpriteAnimationSpeed = value;
				this.SkyboxMaterial.SetFloat("_StarLayer3SpriteAnimationSpeed", this._starLayer3SpriteAnimationSpeed);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0002ADBB File Offset: 0x00028FBB
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0002ADC3 File Offset: 0x00028FC3
		public Texture MoonTexture
		{
			get
			{
				return this._moonTexture;
			}
			set
			{
				this._moonTexture = value;
				this.SkyboxMaterial.SetTexture("_MoonTex", this._moonTexture);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0002ADE2 File Offset: 0x00028FE2
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0002ADEA File Offset: 0x00028FEA
		public float MoonRotationSpeed
		{
			get
			{
				return this._moonRotationSpeed;
			}
			set
			{
				this._moonRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_MoonRotationSpeed", this._moonRotationSpeed);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0002AE09 File Offset: 0x00029009
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x0002AE11 File Offset: 0x00029011
		public Color MoonColor
		{
			get
			{
				return this._moonColor;
			}
			set
			{
				this._moonColor = value;
				this.SkyboxMaterial.SetColor("_MoonColor", this._moonColor);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0002AE30 File Offset: 0x00029030
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0002AE38 File Offset: 0x00029038
		public Vector3 MoonDirection
		{
			get
			{
				return this._moonDirection;
			}
			set
			{
				this._moonDirection = value.normalized;
				this.SkyboxMaterial.SetVector("_MoonPosition", this._moonDirection);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002AE62 File Offset: 0x00029062
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0002AE6A File Offset: 0x0002906A
		public Matrix4x4 MoonWorldToLocalMatrix
		{
			get
			{
				return this._moonWorldToLocalMatrix;
			}
			set
			{
				this._moonWorldToLocalMatrix = value;
				this.SkyboxMaterial.SetMatrix("_MoonWorldToLocalMat", this._moonWorldToLocalMatrix);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002AE89 File Offset: 0x00029089
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0002AE91 File Offset: 0x00029091
		public float MoonSize
		{
			get
			{
				return this._moonSize;
			}
			set
			{
				this._moonSize = value;
				this.SkyboxMaterial.SetFloat("_MoonRadius", this._moonSize);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002AEB0 File Offset: 0x000290B0
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0002AEB8 File Offset: 0x000290B8
		public float MoonEdgeFeathering
		{
			get
			{
				return this._moonEdgeFeathering;
			}
			set
			{
				this._moonEdgeFeathering = value;
				this.SkyboxMaterial.SetFloat("_MoonEdgeFade", this._moonEdgeFeathering);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0002AED7 File Offset: 0x000290D7
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0002AEDF File Offset: 0x000290DF
		public float MoonBloomFilterBoost
		{
			get
			{
				return this._moonBloomFilterBoost;
			}
			set
			{
				this._moonBloomFilterBoost = value;
				this.SkyboxMaterial.SetFloat("_MoonHDRBoost", this._moonBloomFilterBoost);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002AEFE File Offset: 0x000290FE
		public void SetMoonSpriteDimensions(int columns, int rows)
		{
			this._moonSpriteDimensions.x = (float)columns;
			this._moonSpriteDimensions.y = (float)rows;
			this.SkyboxMaterial.SetVector("_MoonSpriteDimensions", this._moonSpriteDimensions);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002AF30 File Offset: 0x00029130
		public Vector2 GetMoonSpriteDimensions()
		{
			return new Vector2(this._moonSpriteDimensions.x, this._moonSpriteDimensions.y);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002AF4D File Offset: 0x0002914D
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0002AF55 File Offset: 0x00029155
		public int MoonSpriteItemCount
		{
			get
			{
				return this._moonSpriteItemCount;
			}
			set
			{
				this._moonSpriteItemCount = value;
				this.SkyboxMaterial.SetInt("_MoonSpriteItemCount", this._moonSpriteItemCount);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002AF74 File Offset: 0x00029174
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0002AF7C File Offset: 0x0002917C
		public float MoonSpriteAnimationSpeed
		{
			get
			{
				return this._moonSpriteAnimationSpeed;
			}
			set
			{
				this._moonSpriteAnimationSpeed = value;
				this.SkyboxMaterial.SetFloat("_MoonSpriteAnimationSpeed", this._moonSpriteAnimationSpeed);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002AF9B File Offset: 0x0002919B
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0002AFA3 File Offset: 0x000291A3
		public float MoonAlpha
		{
			get
			{
				return this._moonAlpha;
			}
			set
			{
				this._moonAlpha = value;
				this.SkyboxMaterial.SetFloat("_MoonAlpha", this._moonAlpha);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0002AFC2 File Offset: 0x000291C2
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0002AFCA File Offset: 0x000291CA
		public Texture SunTexture
		{
			get
			{
				return this._sunTexture;
			}
			set
			{
				this._sunTexture = value;
				this.SkyboxMaterial.SetTexture("_SunTex", this._sunTexture);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002AFE9 File Offset: 0x000291E9
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0002AFF1 File Offset: 0x000291F1
		public Color SunColor
		{
			get
			{
				return this._sunColor;
			}
			set
			{
				this._sunColor = value;
				this.SkyboxMaterial.SetColor("_SunColor", this._sunColor);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0002B010 File Offset: 0x00029210
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0002B018 File Offset: 0x00029218
		public float SunRotationSpeed
		{
			get
			{
				return this._sunRotationSpeed;
			}
			set
			{
				this._sunRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_SunRotationSpeed", this._sunRotationSpeed);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0002B037 File Offset: 0x00029237
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0002B03F File Offset: 0x0002923F
		public Vector3 SunDirection
		{
			get
			{
				return this._sunDirection;
			}
			set
			{
				this._sunDirection = value.normalized;
				this.SkyboxMaterial.SetVector("_SunPosition", this._sunDirection);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002B069 File Offset: 0x00029269
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0002B071 File Offset: 0x00029271
		public Matrix4x4 SunWorldToLocalMatrix
		{
			get
			{
				return this._sunWorldToLocalMatrix;
			}
			set
			{
				this._sunWorldToLocalMatrix = value;
				this.SkyboxMaterial.SetMatrix("_SunWorldToLocalMat", this._sunWorldToLocalMatrix);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002B090 File Offset: 0x00029290
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0002B098 File Offset: 0x00029298
		public float SunSize
		{
			get
			{
				return this._sunSize;
			}
			set
			{
				this._sunSize = value;
				this.SkyboxMaterial.SetFloat("_SunRadius", this._sunSize);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002B0B7 File Offset: 0x000292B7
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0002B0BF File Offset: 0x000292BF
		public float SunEdgeFeathering
		{
			get
			{
				return this._sunEdgeFeathering;
			}
			set
			{
				this._sunEdgeFeathering = value;
				this.SkyboxMaterial.SetFloat("_SunEdgeFade", this._sunEdgeFeathering);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002B0DE File Offset: 0x000292DE
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0002B0E6 File Offset: 0x000292E6
		public float SunBloomFilterBoost
		{
			get
			{
				return this._sunBloomFilterBoost;
			}
			set
			{
				this._sunBloomFilterBoost = value;
				this.SkyboxMaterial.SetFloat("_SunHDRBoost", this._sunBloomFilterBoost);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002B105 File Offset: 0x00029305
		public void SetSunSpriteDimensions(int columns, int rows)
		{
			this._sunSpriteDimensions.x = (float)columns;
			this._sunSpriteDimensions.y = (float)rows;
			this.SkyboxMaterial.SetVector("_SunSpriteDimensions", this._sunSpriteDimensions);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002B137 File Offset: 0x00029337
		public Vector2 GetSunSpriteDimensions()
		{
			return new Vector2(this._sunSpriteDimensions.x, this._sunSpriteDimensions.y);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002B154 File Offset: 0x00029354
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0002B15C File Offset: 0x0002935C
		public int SunSpriteItemCount
		{
			get
			{
				return this._sunSpriteItemCount;
			}
			set
			{
				this._sunSpriteItemCount = value;
				this.SkyboxMaterial.SetInt("_SunSpriteItemCount", this._sunSpriteItemCount);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0002B17B File Offset: 0x0002937B
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0002B183 File Offset: 0x00029383
		public float SunSpriteAnimationSpeed
		{
			get
			{
				return this._sunSpriteAnimationSpeed;
			}
			set
			{
				this._sunSpriteAnimationSpeed = value;
				this.SkyboxMaterial.SetFloat("_SunSpriteAnimationSpeed", this._sunSpriteAnimationSpeed);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0002B1A2 File Offset: 0x000293A2
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x0002B1AA File Offset: 0x000293AA
		public float SunAlpha
		{
			get
			{
				return this._sunAlpha;
			}
			set
			{
				this._sunAlpha = value;
				this.SkyboxMaterial.SetFloat("_SunAlpha", this._sunAlpha);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0002B1C9 File Offset: 0x000293C9
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0002B1D1 File Offset: 0x000293D1
		public float CloudBegin
		{
			get
			{
				return this._cloudBegin;
			}
			set
			{
				this._cloudBegin = value;
				this.SkyboxMaterial.SetFloat("_CloudBegin", this._cloudBegin);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0002B1F0 File Offset: 0x000293F0
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0002B1F8 File Offset: 0x000293F8
		public float CloudTextureTiling
		{
			get
			{
				return this._cloudTextureTiling;
			}
			set
			{
				this._cloudTextureTiling = value;
				this.SkyboxMaterial.SetFloat("_CloudTextureTiling", this._cloudTextureTiling);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002B217 File Offset: 0x00029417
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0002B21F File Offset: 0x0002941F
		public Color CloudColor
		{
			get
			{
				return this._cloudColor;
			}
			set
			{
				this._cloudColor = value;
				this.SkyboxMaterial.SetColor("_CloudColor", this._cloudColor);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0002B23E File Offset: 0x0002943E
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0002B25A File Offset: 0x0002945A
		public Texture CloudTexture
		{
			get
			{
				if (!(this._cloudTexture != null))
				{
					return Texture2D.blackTexture;
				}
				return this._cloudTexture;
			}
			set
			{
				this._cloudTexture = value;
				this.SkyboxMaterial.SetTexture("_CloudNoiseTexture", this._cloudTexture);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002B279 File Offset: 0x00029479
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0002B295 File Offset: 0x00029495
		public Texture ArtCloudCustomTexture
		{
			get
			{
				if (!(this._artCloudCustomTexture != null))
				{
					return Texture2D.blackTexture;
				}
				return this._artCloudCustomTexture;
			}
			set
			{
				this._artCloudCustomTexture = value;
				this.SkyboxMaterial.SetTexture("_ArtCloudCustomTexture", this._artCloudCustomTexture);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0002B2B4 File Offset: 0x000294B4
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0002B2BC File Offset: 0x000294BC
		public float CloudDensity
		{
			get
			{
				return this._cloudDensity;
			}
			set
			{
				this._cloudDensity = value;
				this.SkyboxMaterial.SetFloat("_CloudDensity", this._cloudDensity);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002B2DB File Offset: 0x000294DB
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0002B2E3 File Offset: 0x000294E3
		public float CloudSpeed
		{
			get
			{
				return this._cloudSpeed;
			}
			set
			{
				this._cloudSpeed = value;
				this.SkyboxMaterial.SetFloat("_CloudSpeed", this._cloudSpeed);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002B302 File Offset: 0x00029502
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0002B30A File Offset: 0x0002950A
		public float CloudDirection
		{
			get
			{
				return this._cloudDirection;
			}
			set
			{
				this._cloudDirection = value;
				this.SkyboxMaterial.SetFloat("_CloudDirection", this._cloudDirection);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002B329 File Offset: 0x00029529
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0002B331 File Offset: 0x00029531
		public float CloudHeight
		{
			get
			{
				return this._cloudHeight;
			}
			set
			{
				this._cloudHeight = value;
				this.SkyboxMaterial.SetFloat("_CloudHeight", this._cloudHeight);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002B350 File Offset: 0x00029550
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0002B358 File Offset: 0x00029558
		public Color CloudColor1
		{
			get
			{
				return this._cloudColor1;
			}
			set
			{
				this._cloudColor1 = value;
				this.SkyboxMaterial.SetColor("_CloudColor1", this._cloudColor1);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002B377 File Offset: 0x00029577
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002B37F File Offset: 0x0002957F
		public Color CloudColor2
		{
			get
			{
				return this._cloudColor2;
			}
			set
			{
				this._cloudColor2 = value;
				this.SkyboxMaterial.SetColor("_CloudColor2", this._cloudColor2);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002B39E File Offset: 0x0002959E
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0002B3A6 File Offset: 0x000295A6
		public float CloudFadePosition
		{
			get
			{
				return this._cloudFadePosition;
			}
			set
			{
				this._cloudFadePosition = value;
				this.SkyboxMaterial.SetFloat("_CloudFadePosition", this._cloudFadePosition);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002B3C5 File Offset: 0x000295C5
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0002B3CD File Offset: 0x000295CD
		public float CloudFadeAmount
		{
			get
			{
				return this._cloudFadeAmount;
			}
			set
			{
				this._cloudFadeAmount = value;
				this.SkyboxMaterial.SetFloat("_CloudFadeAmount", this._cloudFadeAmount);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002B3EC File Offset: 0x000295EC
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0002B3F4 File Offset: 0x000295F4
		public float CloudAlpha
		{
			get
			{
				return this._cloudAlpha;
			}
			set
			{
				this._cloudAlpha = value;
				this.SkyboxMaterial.SetFloat("_CloudAlpha", this._cloudAlpha);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002B413 File Offset: 0x00029613
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0002B41B File Offset: 0x0002961B
		public Texture CloudCubemap
		{
			get
			{
				return this._cloudCubemap;
			}
			set
			{
				this._cloudCubemap = value;
				this.SkyboxMaterial.SetTexture("_CloudCubemapTexture", this._cloudCubemap);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002B43A File Offset: 0x0002963A
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0002B442 File Offset: 0x00029642
		public float CloudCubemapRotationSpeed
		{
			get
			{
				return this._cloudCubemapRotationSpeed;
			}
			set
			{
				this._cloudCubemapRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapRotationSpeed", this._cloudCubemapRotationSpeed);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002B461 File Offset: 0x00029661
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0002B469 File Offset: 0x00029669
		public Texture CloudCubemapDoubleLayerCustomTexture
		{
			get
			{
				return this._cloudCubemapDoubleLayerCustomTexture;
			}
			set
			{
				this._cloudCubemapDoubleLayerCustomTexture = value;
				this.SkyboxMaterial.SetTexture("_CloudCubemapDoubleTexture", this._cloudCubemapDoubleLayerCustomTexture);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0002B488 File Offset: 0x00029688
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0002B490 File Offset: 0x00029690
		public float CloudCubemapDoubleLayerRotationSpeed
		{
			get
			{
				return this._cloudCubemapDoubleLayerRotationSpeed;
			}
			set
			{
				this._cloudCubemapDoubleLayerRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapDoubleLayerRotationSpeed", this._cloudCubemapDoubleLayerRotationSpeed);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002B4AF File Offset: 0x000296AF
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0002B4B7 File Offset: 0x000296B7
		public float CloudCubemapDoubleLayerHeight
		{
			get
			{
				return this._cloudCubemapDoubleLayerHeight;
			}
			set
			{
				this._cloudCubemapDoubleLayerHeight = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapDoubleLayerHeight", this._cloudCubemapDoubleLayerHeight);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0002B4D6 File Offset: 0x000296D6
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x0002B4DE File Offset: 0x000296DE
		public Color CloudCubemapDoubleLayerTintColor
		{
			get
			{
				return this._cloudCubemapDoubleLayerTintColor;
			}
			set
			{
				this._cloudCubemapDoubleLayerTintColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapDoubleLayerTintColor", this._cloudCubemapDoubleLayerTintColor);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002B4FD File Offset: 0x000296FD
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002B505 File Offset: 0x00029705
		public Color CloudCubemapTintColor
		{
			get
			{
				return this._cloudCubemapTintColor;
			}
			set
			{
				this._cloudCubemapTintColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapTintColor", this._cloudCubemapTintColor);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002B524 File Offset: 0x00029724
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0002B52C File Offset: 0x0002972C
		public float CloudCubemapHeight
		{
			get
			{
				return this._cloudCubemapHeight;
			}
			set
			{
				this._cloudCubemapHeight = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapHeight", this._cloudCubemapHeight);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0002B413 File Offset: 0x00029613
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0002B54B File Offset: 0x0002974B
		public Texture CloudCubemapNormalTexture
		{
			get
			{
				return this._cloudCubemap;
			}
			set
			{
				this._cloudCubemapNormalTexture = value;
				this.SkyboxMaterial.SetTexture("_CloudCubemapNormalTexture", this._cloudCubemapNormalTexture);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002B56A File Offset: 0x0002976A
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0002B572 File Offset: 0x00029772
		public Color CloudCubemapNormalLitColor
		{
			get
			{
				return this._cloudCubemapNormalLitColor;
			}
			set
			{
				this._cloudCubemapNormalLitColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapNormalLitColor", this._cloudCubemapNormalLitColor);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002B591 File Offset: 0x00029791
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0002B599 File Offset: 0x00029799
		public Color CloudCubemapNormalShadowColor
		{
			get
			{
				return this._cloudCubemapNormalShadowColor;
			}
			set
			{
				this._cloudCubemapNormalShadowColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapNormalShadowColor", this._cloudCubemapNormalShadowColor);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002B5B8 File Offset: 0x000297B8
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0002B5C0 File Offset: 0x000297C0
		public float CloudCubemapNormalRotationSpeed
		{
			get
			{
				return this._cloudCubemapNormalRotationSpeed;
			}
			set
			{
				this._cloudCubemapNormalRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapNormalRotationSpeed", this._cloudCubemapNormalRotationSpeed);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0002B5DF File Offset: 0x000297DF
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0002B5E7 File Offset: 0x000297E7
		public float CloudCubemapNormalHeight
		{
			get
			{
				return this._cloudCubemapNormalHeight;
			}
			set
			{
				this._cloudCubemapNormalHeight = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapNormalHeight", this._cloudCubemapNormalHeight);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002B606 File Offset: 0x00029806
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0002B60E File Offset: 0x0002980E
		public float CloudCubemapNormalAmbientIntensity
		{
			get
			{
				return this._cloudCubemapNormalAmbientItensity;
			}
			set
			{
				this._cloudCubemapNormalAmbientItensity = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapNormalAmbientIntensity", this._cloudCubemapNormalAmbientItensity);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002B62D File Offset: 0x0002982D
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0002B635 File Offset: 0x00029835
		public Texture CloudCubemapNormalDoubleLayerCustomTexture
		{
			get
			{
				return this._cloudCubemapNormalDoubleLayerCustomTexture;
			}
			set
			{
				this._cloudCubemapNormalDoubleLayerCustomTexture = value;
				this.SkyboxMaterial.SetTexture("_CloudCubemapNormalDoubleTexture", this._cloudCubemapNormalDoubleLayerCustomTexture);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002B654 File Offset: 0x00029854
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0002B65C File Offset: 0x0002985C
		public float CloudCubemapNormalDoubleLayerRotationSpeed
		{
			get
			{
				return this._cloudCubemapNormalDoubleLayerRotationSpeed;
			}
			set
			{
				this._cloudCubemapNormalDoubleLayerRotationSpeed = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapNormalDoubleLayerRotationSpeed", this._cloudCubemapNormalDoubleLayerRotationSpeed);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002B4AF File Offset: 0x000296AF
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0002B67B File Offset: 0x0002987B
		public float CloudCubemapNormalDoubleLayerHeight
		{
			get
			{
				return this._cloudCubemapDoubleLayerHeight;
			}
			set
			{
				this._cloudCubemapNormalDoubleLayerHeight = value;
				this.SkyboxMaterial.SetFloat("_CloudCubemapNormalDoubleLayerHeight", this._cloudCubemapNormalDoubleLayerHeight);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002B69A File Offset: 0x0002989A
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0002B6A2 File Offset: 0x000298A2
		public Color CloudCubemapNormalDoubleLayerLitColor
		{
			get
			{
				return this._cloudCubemapNormalDoubleLayerLitColor;
			}
			set
			{
				this._cloudCubemapNormalDoubleLayerLitColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapNormalDoubleLitColor", this._cloudCubemapNormalDoubleLayerLitColor);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002B6C1 File Offset: 0x000298C1
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0002B6C9 File Offset: 0x000298C9
		public Color CloudCubemapNormalDoubleLayerShadowColor
		{
			get
			{
				return this._cloudCubemapNormalDoubleLayerShadowColor;
			}
			set
			{
				this._cloudCubemapNormalDoubleLayerShadowColor = value;
				this.SkyboxMaterial.SetColor("_CloudCubemapNormalDoubleShadowColor", this._cloudCubemapNormalDoubleLayerShadowColor);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002B6E8 File Offset: 0x000298E8
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0002B6F0 File Offset: 0x000298F0
		public Vector3 CloudCubemapNormalLightDirection
		{
			get
			{
				return this._cloudCubemapNormalLightDirection;
			}
			set
			{
				this._cloudCubemapNormalLightDirection = value;
				this.SkyboxMaterial.SetVector("_CloudCubemapNormalToLight", this._cloudCubemapNormalLightDirection);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002B714 File Offset: 0x00029914
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0002B71C File Offset: 0x0002991C
		public Color FogColor
		{
			get
			{
				return this._fogColor;
			}
			set
			{
				this._fogColor = value;
				this.SkyboxMaterial.SetColor("_HorizonFogColor", this._fogColor);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002B73B File Offset: 0x0002993B
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0002B743 File Offset: 0x00029943
		public float FogDensity
		{
			get
			{
				return this._fogDensity;
			}
			set
			{
				this._fogDensity = value;
				this.SkyboxMaterial.SetFloat("_HorizonFogDensity", this._fogDensity);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0002B762 File Offset: 0x00029962
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0002B76A File Offset: 0x0002996A
		public float FogHeight
		{
			get
			{
				return this._fogHeight;
			}
			set
			{
				this._fogHeight = value;
				this.SkyboxMaterial.SetFloat("_HorizonFogLength", this._fogHeight);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002B78C File Offset: 0x0002998C
		private void ApplyGradientValuesOnMaterial()
		{
			float value = Mathf.Clamp(this._gradientFadeBegin + this._gradientFadeLength, -1f, 1f);
			this.SkyboxMaterial.SetFloat("_GradientFadeBegin", this._gradientFadeBegin);
			this.SkyboxMaterial.SetFloat("_GradientFadeEnd", value);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002B7E0 File Offset: 0x000299E0
		private void ApplyStarFadeValuesOnMaterial()
		{
			float value = Mathf.Clamp(this._starFadeBegin + this._starFadeLength, -1f, 1f);
			this.SkyboxMaterial.SetFloat("_StarFadeBegin", this._starFadeBegin);
			this.SkyboxMaterial.SetFloat("_StarFadeEnd", value);
		}

		// Token: 0x04000AB9 RID: 2745
		[SerializeField]
		private Material _skyboxMaterial;

		// Token: 0x04000ABA RID: 2746
		[SerializeField]
		private Color _skyColor = ColorHelper.ColorWithHex(2892384U);

		// Token: 0x04000ABB RID: 2747
		[SerializeField]
		private Color _skyMiddleColor = Color.white;

		// Token: 0x04000ABC RID: 2748
		[SerializeField]
		private Color _horizonColor = ColorHelper.ColorWithHex(14928002U);

		// Token: 0x04000ABD RID: 2749
		[SerializeField]
		[Range(-1f, 1f)]
		private float _gradientFadeBegin;

		// Token: 0x04000ABE RID: 2750
		[SerializeField]
		[Range(0f, 2f)]
		private float _gradientFadeLength = 1f;

		// Token: 0x04000ABF RID: 2751
		[SerializeField]
		[Range(0f, 1f)]
		private float _skyMiddlePosition = 0.5f;

		// Token: 0x04000AC0 RID: 2752
		[SerializeField]
		private Cubemap _backgroundCubemap;

		// Token: 0x04000AC1 RID: 2753
		[SerializeField]
		[Range(-1f, 1f)]
		private float _starFadeBegin = 0.067f;

		// Token: 0x04000AC2 RID: 2754
		[SerializeField]
		[Range(0f, 2f)]
		private float _starFadeLength = 0.36f;

		// Token: 0x04000AC3 RID: 2755
		[SerializeField]
		[Range(0f, 1f)]
		private float _horizonDistanceScale = 0.7f;

		// Token: 0x04000AC4 RID: 2756
		[SerializeField]
		private Texture _starBasicCubemap;

		// Token: 0x04000AC5 RID: 2757
		[SerializeField]
		private float _starBasicTwinkleSpeed;

		// Token: 0x04000AC6 RID: 2758
		[SerializeField]
		private float _starBasicTwinkleAmount;

		// Token: 0x04000AC7 RID: 2759
		[SerializeField]
		private float _starBasicOpacity;

		// Token: 0x04000AC8 RID: 2760
		[SerializeField]
		private Color _starBasicTintColor;

		// Token: 0x04000AC9 RID: 2761
		[SerializeField]
		private float _starBasicExponent;

		// Token: 0x04000ACA RID: 2762
		[SerializeField]
		private float _starBasicIntensity;

		// Token: 0x04000ACB RID: 2763
		[SerializeField]
		private Texture _starLayer1Texture;

		// Token: 0x04000ACC RID: 2764
		[SerializeField]
		private Texture2D _starLayer1DataTexture;

		// Token: 0x04000ACD RID: 2765
		[SerializeField]
		private Color _starLayer1Color;

		// Token: 0x04000ACE RID: 2766
		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer1MaxRadius = 0.007f;

		// Token: 0x04000ACF RID: 2767
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer1TwinkleAmount = 0.7f;

		// Token: 0x04000AD0 RID: 2768
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer1TwinkleSpeed = 0.7f;

		// Token: 0x04000AD1 RID: 2769
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer1RotationSpeed = 0.7f;

		// Token: 0x04000AD2 RID: 2770
		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer1EdgeFeathering = 0.2f;

		// Token: 0x04000AD3 RID: 2771
		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer1BloomFilterBoost;

		// Token: 0x04000AD4 RID: 2772
		[SerializeField]
		private Vector4 _starLayer1SpriteDimensions = Vector4.zero;

		// Token: 0x04000AD5 RID: 2773
		[SerializeField]
		private int _starLayer1SpriteItemCount = 1;

		// Token: 0x04000AD6 RID: 2774
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer1SpriteAnimationSpeed = 1f;

		// Token: 0x04000AD7 RID: 2775
		[SerializeField]
		private Texture _starLayer2Texture;

		// Token: 0x04000AD8 RID: 2776
		[SerializeField]
		private Texture2D _starLayer2DataTexture;

		// Token: 0x04000AD9 RID: 2777
		[SerializeField]
		private Color _starLayer2Color;

		// Token: 0x04000ADA RID: 2778
		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer2MaxRadius = 0.007f;

		// Token: 0x04000ADB RID: 2779
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer2TwinkleAmount = 0.7f;

		// Token: 0x04000ADC RID: 2780
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer2TwinkleSpeed = 0.7f;

		// Token: 0x04000ADD RID: 2781
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer2RotationSpeed = 0.7f;

		// Token: 0x04000ADE RID: 2782
		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer2EdgeFeathering = 0.2f;

		// Token: 0x04000ADF RID: 2783
		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer2BloomFilterBoost;

		// Token: 0x04000AE0 RID: 2784
		[SerializeField]
		private Vector4 _starLayer2SpriteDimensions = Vector4.zero;

		// Token: 0x04000AE1 RID: 2785
		[SerializeField]
		private int _starLayer2SpriteItemCount = 1;

		// Token: 0x04000AE2 RID: 2786
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer2SpriteAnimationSpeed = 1f;

		// Token: 0x04000AE3 RID: 2787
		[SerializeField]
		private Texture _starLayer3Texture;

		// Token: 0x04000AE4 RID: 2788
		[SerializeField]
		private Texture2D _starLayer3DataTexture;

		// Token: 0x04000AE5 RID: 2789
		[SerializeField]
		private Color _starLayer3Color;

		// Token: 0x04000AE6 RID: 2790
		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer3MaxRadius = 0.007f;

		// Token: 0x04000AE7 RID: 2791
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer3TwinkleAmount = 0.7f;

		// Token: 0x04000AE8 RID: 2792
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer3TwinkleSpeed = 0.7f;

		// Token: 0x04000AE9 RID: 2793
		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer3RotationSpeed = 0.7f;

		// Token: 0x04000AEA RID: 2794
		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer3EdgeFeathering = 0.2f;

		// Token: 0x04000AEB RID: 2795
		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer3BloomFilterBoost;

		// Token: 0x04000AEC RID: 2796
		[SerializeField]
		private Vector4 _starLayer3SpriteDimensions = Vector4.zero;

		// Token: 0x04000AED RID: 2797
		[SerializeField]
		private int _starLayer3SpriteItemCount = 1;

		// Token: 0x04000AEE RID: 2798
		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer3SpriteAnimationSpeed = 1f;

		// Token: 0x04000AEF RID: 2799
		[SerializeField]
		private Texture _moonTexture;

		// Token: 0x04000AF0 RID: 2800
		[SerializeField]
		private float _moonRotationSpeed;

		// Token: 0x04000AF1 RID: 2801
		[SerializeField]
		private Color _moonColor = Color.white;

		// Token: 0x04000AF2 RID: 2802
		[SerializeField]
		private Vector3 _moonDirection = Vector3.right;

		// Token: 0x04000AF3 RID: 2803
		[SerializeField]
		private Matrix4x4 _moonWorldToLocalMatrix = Matrix4x4.identity;

		// Token: 0x04000AF4 RID: 2804
		[SerializeField]
		[Range(0f, 1f)]
		private float _moonSize = 0.1f;

		// Token: 0x04000AF5 RID: 2805
		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _moonEdgeFeathering = 0.085f;

		// Token: 0x04000AF6 RID: 2806
		[SerializeField]
		[Range(1f, 10f)]
		private float _moonBloomFilterBoost = 1f;

		// Token: 0x04000AF7 RID: 2807
		[SerializeField]
		private Vector4 _moonSpriteDimensions = Vector4.zero;

		// Token: 0x04000AF8 RID: 2808
		[SerializeField]
		private int _moonSpriteItemCount = 1;

		// Token: 0x04000AF9 RID: 2809
		[SerializeField]
		[Range(0f, 1f)]
		private float _moonSpriteAnimationSpeed = 1f;

		// Token: 0x04000AFA RID: 2810
		[SerializeField]
		[Range(0f, 1f)]
		private float _moonAlpha = 1f;

		// Token: 0x04000AFB RID: 2811
		[SerializeField]
		private Texture _sunTexture;

		// Token: 0x04000AFC RID: 2812
		[SerializeField]
		private Color _sunColor = Color.white;

		// Token: 0x04000AFD RID: 2813
		[SerializeField]
		private float _sunRotationSpeed;

		// Token: 0x04000AFE RID: 2814
		[SerializeField]
		private Vector3 _sunDirection = Vector3.right;

		// Token: 0x04000AFF RID: 2815
		[SerializeField]
		private Matrix4x4 _sunWorldToLocalMatrix = Matrix4x4.identity;

		// Token: 0x04000B00 RID: 2816
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunSize = 0.1f;

		// Token: 0x04000B01 RID: 2817
		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _sunEdgeFeathering = 0.085f;

		// Token: 0x04000B02 RID: 2818
		[SerializeField]
		[Range(1f, 10f)]
		private float _sunBloomFilterBoost = 1f;

		// Token: 0x04000B03 RID: 2819
		[SerializeField]
		private Vector4 _sunSpriteDimensions = Vector4.zero;

		// Token: 0x04000B04 RID: 2820
		[SerializeField]
		private int _sunSpriteItemCount = 1;

		// Token: 0x04000B05 RID: 2821
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunSpriteAnimationSpeed = 1f;

		// Token: 0x04000B06 RID: 2822
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunAlpha = 1f;

		// Token: 0x04000B07 RID: 2823
		[SerializeField]
		[Range(-1f, 1f)]
		private float _cloudBegin = 0.2f;

		// Token: 0x04000B08 RID: 2824
		private float _cloudTextureTiling;

		// Token: 0x04000B09 RID: 2825
		[SerializeField]
		private Color _cloudColor = Color.white;

		// Token: 0x04000B0A RID: 2826
		[SerializeField]
		private Texture _cloudTexture;

		// Token: 0x04000B0B RID: 2827
		[SerializeField]
		private Texture _artCloudCustomTexture;

		// Token: 0x04000B0C RID: 2828
		[SerializeField]
		private float _cloudDensity;

		// Token: 0x04000B0D RID: 2829
		[SerializeField]
		private float _cloudSpeed;

		// Token: 0x04000B0E RID: 2830
		[SerializeField]
		private float _cloudDirection;

		// Token: 0x04000B0F RID: 2831
		[SerializeField]
		private float _cloudHeight;

		// Token: 0x04000B10 RID: 2832
		[SerializeField]
		private Color _cloudColor1 = Color.white;

		// Token: 0x04000B11 RID: 2833
		[SerializeField]
		private Color _cloudColor2 = Color.white;

		// Token: 0x04000B12 RID: 2834
		[SerializeField]
		private float _cloudFadePosition;

		// Token: 0x04000B13 RID: 2835
		[SerializeField]
		private float _cloudFadeAmount = 0.5f;

		// Token: 0x04000B14 RID: 2836
		[SerializeField]
		private float _cloudAlpha = 1f;

		// Token: 0x04000B15 RID: 2837
		[SerializeField]
		private Texture _cloudCubemap;

		// Token: 0x04000B16 RID: 2838
		[SerializeField]
		private float _cloudCubemapRotationSpeed;

		// Token: 0x04000B17 RID: 2839
		[SerializeField]
		private Texture _cloudCubemapDoubleLayerCustomTexture;

		// Token: 0x04000B18 RID: 2840
		[SerializeField]
		private float _cloudCubemapDoubleLayerRotationSpeed;

		// Token: 0x04000B19 RID: 2841
		[SerializeField]
		private float _cloudCubemapDoubleLayerHeight;

		// Token: 0x04000B1A RID: 2842
		[SerializeField]
		private Color _cloudCubemapDoubleLayerTintColor = Color.white;

		// Token: 0x04000B1B RID: 2843
		[SerializeField]
		private Color _cloudCubemapTintColor = Color.white;

		// Token: 0x04000B1C RID: 2844
		[SerializeField]
		private float _cloudCubemapHeight;

		// Token: 0x04000B1D RID: 2845
		[SerializeField]
		private Texture _cloudCubemapNormalTexture;

		// Token: 0x04000B1E RID: 2846
		[SerializeField]
		private Color _cloudCubemapNormalLitColor = Color.white;

		// Token: 0x04000B1F RID: 2847
		[SerializeField]
		private Color _cloudCubemapNormalShadowColor = Color.gray;

		// Token: 0x04000B20 RID: 2848
		[SerializeField]
		private float _cloudCubemapNormalRotationSpeed;

		// Token: 0x04000B21 RID: 2849
		[SerializeField]
		private float _cloudCubemapNormalHeight;

		// Token: 0x04000B22 RID: 2850
		[SerializeField]
		private float _cloudCubemapNormalAmbientItensity;

		// Token: 0x04000B23 RID: 2851
		[SerializeField]
		private Texture _cloudCubemapNormalDoubleLayerCustomTexture;

		// Token: 0x04000B24 RID: 2852
		[SerializeField]
		private float _cloudCubemapNormalDoubleLayerRotationSpeed;

		// Token: 0x04000B25 RID: 2853
		[SerializeField]
		private float _cloudCubemapNormalDoubleLayerHeight;

		// Token: 0x04000B26 RID: 2854
		[SerializeField]
		private Color _cloudCubemapNormalDoubleLayerLitColor = Color.white;

		// Token: 0x04000B27 RID: 2855
		[SerializeField]
		private Color _cloudCubemapNormalDoubleLayerShadowColor = Color.gray;

		// Token: 0x04000B28 RID: 2856
		[SerializeField]
		private Vector3 _cloudCubemapNormalLightDirection = new Vector3(0f, 1f, 0f);

		// Token: 0x04000B29 RID: 2857
		[SerializeField]
		private Color _fogColor = Color.white;

		// Token: 0x04000B2A RID: 2858
		[SerializeField]
		private float _fogDensity = 0.12f;

		// Token: 0x04000B2B RID: 2859
		[SerializeField]
		private float _fogHeight = 0.12f;
	}
}
