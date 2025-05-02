using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000AF RID: 175
	public static class ShaderProperties : Object
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x0009A4B4 File Offset: 0x000986B4
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			ShaderProperties.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeRadius");
			ShaderProperties.NativeFieldInfoPtr_ConeGeomProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeGeomProps");
			ShaderProperties.NativeFieldInfoPtr_ColorFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorFlat");
			ShaderProperties.NativeFieldInfoPtr_DistanceFallOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceFallOff");
			ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseVelocityAndScale");
			ShaderProperties.NativeFieldInfoPtr_NoiseParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseParam");
			ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorGradientMatrix");
			ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "LocalToWorldMatrix");
			ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "WorldToLocalMatrix");
			ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendSrcFactor");
			ShaderProperties.NativeFieldInfoPtr_BlendDstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendDstFactor");
			ShaderProperties.NativeFieldInfoPtr_ZTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ZTest");
			ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ParticlesTintColor");
			ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HDRPExposureWeight");
			ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalUsesReversedZBuffer");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseTex3D");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseCustomTime");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringFactor");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringNoiseTex");
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00008660 File Offset: 0x00006860
		public ShaderProperties(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0009A660 File Offset: 0x00098860
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00008669 File Offset: 0x00006869
		public unsafe static int ConeRadius
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0009A67C File Offset: 0x0009887C
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00008677 File Offset: 0x00006877
		public unsafe static int ConeGeomProps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0009A698 File Offset: 0x00098898
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00008685 File Offset: 0x00006885
		public unsafe static int ColorFlat
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0009A6B4 File Offset: 0x000988B4
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00008693 File Offset: 0x00006893
		public unsafe static int DistanceFallOff
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0009A6D0 File Offset: 0x000988D0
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x000086A1 File Offset: 0x000068A1
		public unsafe static int NoiseVelocityAndScale
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0009A6EC File Offset: 0x000988EC
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x000086AF File Offset: 0x000068AF
		public unsafe static int NoiseParam
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0009A708 File Offset: 0x00098908
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000086BD File Offset: 0x000068BD
		public unsafe static int ColorGradientMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0009A724 File Offset: 0x00098924
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x000086CB File Offset: 0x000068CB
		public unsafe static int LocalToWorldMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0009A740 File Offset: 0x00098940
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x000086D9 File Offset: 0x000068D9
		public unsafe static int WorldToLocalMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0009A75C File Offset: 0x0009895C
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x000086E7 File Offset: 0x000068E7
		public unsafe static int BlendSrcFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0009A778 File Offset: 0x00098978
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x000086F5 File Offset: 0x000068F5
		public unsafe static int BlendDstFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0009A794 File Offset: 0x00098994
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00008703 File Offset: 0x00006903
		public unsafe static int ZTest
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0009A7B0 File Offset: 0x000989B0
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00008711 File Offset: 0x00006911
		public unsafe static int ParticlesTintColor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0009A7CC File Offset: 0x000989CC
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x0000871F File Offset: 0x0000691F
		public unsafe static int HDRPExposureWeight
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0009A7E8 File Offset: 0x000989E8
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x0000872D File Offset: 0x0000692D
		public unsafe static int GlobalUsesReversedZBuffer
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0009A804 File Offset: 0x00098A04
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0000873B File Offset: 0x0000693B
		public unsafe static int GlobalNoiseTex3D
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0009A820 File Offset: 0x00098A20
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00008749 File Offset: 0x00006949
		public unsafe static int GlobalNoiseCustomTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0009A83C File Offset: 0x00098A3C
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00008757 File Offset: 0x00006957
		public unsafe static int GlobalDitheringFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0009A858 File Offset: 0x00098A58
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00008765 File Offset: 0x00006965
		public unsafe static int GlobalDitheringNoiseTex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&value));
			}
		}

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_ConeRadius;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_ConeGeomProps;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_ColorFlat;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_DistanceFallOff;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityAndScale;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_NoiseParam;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrix;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_LocalToWorldMatrix;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_WorldToLocalMatrix;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_BlendSrcFactor;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_BlendDstFactor;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_ZTest;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_ParticlesTintColor;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeight;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_GlobalUsesReversedZBuffer;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseTex3D;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseCustomTime;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringFactor;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringNoiseTex;

		// Token: 0x0200083A RID: 2106
		public static class SD : Object
		{
			// Token: 0x0600BF4E RID: 48974 RVA: 0x002EE8C8 File Offset: 0x002ECAC8
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr);
				ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FadeOutFactor");
				ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "ConeSlopeCosSin");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaInside");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaOutside");
				ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AttenuationLerpLinearQuad");
				ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DistanceCamClipping");
				ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FresnelPow");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareBehind");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareFrontal");
				ShaderProperties.SD.NativeFieldInfoPtr_DrawCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DrawCap");
				ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DepthBlendDistance");
				ShaderProperties.SD.NativeFieldInfoPtr_CameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "CameraParams");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneWS");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneProps");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthTexture");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthProps");
				ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "LocalForwardDirection");
				ShaderProperties.SD.NativeFieldInfoPtr_TiltVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "TiltVector");
				ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AdditionalClippingPlaneWS");
			}

			// Token: 0x0600BF4F RID: 48975 RVA: 0x0005D822 File Offset: 0x0005BA22
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B7A RID: 15226
			// (get) Token: 0x0600BF50 RID: 48976 RVA: 0x002EEA70 File Offset: 0x002ECC70
			// (set) Token: 0x0600BF51 RID: 48977 RVA: 0x0005D82B File Offset: 0x0005BA2B
			public unsafe static int FadeOutFactor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&value));
				}
			}

			// Token: 0x17003B7B RID: 15227
			// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x002EEA8C File Offset: 0x002ECC8C
			// (set) Token: 0x0600BF53 RID: 48979 RVA: 0x0005D839 File Offset: 0x0005BA39
			public unsafe static int ConeSlopeCosSin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&value));
				}
			}

			// Token: 0x17003B7C RID: 15228
			// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x002EEAA8 File Offset: 0x002ECCA8
			// (set) Token: 0x0600BF55 RID: 48981 RVA: 0x0005D847 File Offset: 0x0005BA47
			public unsafe static int AlphaInside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&value));
				}
			}

			// Token: 0x17003B7D RID: 15229
			// (get) Token: 0x0600BF56 RID: 48982 RVA: 0x002EEAC4 File Offset: 0x002ECCC4
			// (set) Token: 0x0600BF57 RID: 48983 RVA: 0x0005D855 File Offset: 0x0005BA55
			public unsafe static int AlphaOutside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&value));
				}
			}

			// Token: 0x17003B7E RID: 15230
			// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x002EEAE0 File Offset: 0x002ECCE0
			// (set) Token: 0x0600BF59 RID: 48985 RVA: 0x0005D863 File Offset: 0x0005BA63
			public unsafe static int AttenuationLerpLinearQuad
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&value));
				}
			}

			// Token: 0x17003B7F RID: 15231
			// (get) Token: 0x0600BF5A RID: 48986 RVA: 0x002EEAFC File Offset: 0x002ECCFC
			// (set) Token: 0x0600BF5B RID: 48987 RVA: 0x0005D871 File Offset: 0x0005BA71
			public unsafe static int DistanceCamClipping
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&value));
				}
			}

			// Token: 0x17003B80 RID: 15232
			// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x002EEB18 File Offset: 0x002ECD18
			// (set) Token: 0x0600BF5D RID: 48989 RVA: 0x0005D87F File Offset: 0x0005BA7F
			public unsafe static int FresnelPow
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
				}
			}

			// Token: 0x17003B81 RID: 15233
			// (get) Token: 0x0600BF5E RID: 48990 RVA: 0x002EEB34 File Offset: 0x002ECD34
			// (set) Token: 0x0600BF5F RID: 48991 RVA: 0x0005D88D File Offset: 0x0005BA8D
			public unsafe static int GlareBehind
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&value));
				}
			}

			// Token: 0x17003B82 RID: 15234
			// (get) Token: 0x0600BF60 RID: 48992 RVA: 0x002EEB50 File Offset: 0x002ECD50
			// (set) Token: 0x0600BF61 RID: 48993 RVA: 0x0005D89B File Offset: 0x0005BA9B
			public unsafe static int GlareFrontal
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&value));
				}
			}

			// Token: 0x17003B83 RID: 15235
			// (get) Token: 0x0600BF62 RID: 48994 RVA: 0x002EEB6C File Offset: 0x002ECD6C
			// (set) Token: 0x0600BF63 RID: 48995 RVA: 0x0005D8A9 File Offset: 0x0005BAA9
			public unsafe static int DrawCap
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&value));
				}
			}

			// Token: 0x17003B84 RID: 15236
			// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x002EEB88 File Offset: 0x002ECD88
			// (set) Token: 0x0600BF65 RID: 48997 RVA: 0x0005D8B7 File Offset: 0x0005BAB7
			public unsafe static int DepthBlendDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17003B85 RID: 15237
			// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x002EEBA4 File Offset: 0x002ECDA4
			// (set) Token: 0x0600BF67 RID: 48999 RVA: 0x0005D8C5 File Offset: 0x0005BAC5
			public unsafe static int CameraParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&value));
				}
			}

			// Token: 0x17003B86 RID: 15238
			// (get) Token: 0x0600BF68 RID: 49000 RVA: 0x002EEBC0 File Offset: 0x002ECDC0
			// (set) Token: 0x0600BF69 RID: 49001 RVA: 0x0005D8D3 File Offset: 0x0005BAD3
			public unsafe static int DynamicOcclusionClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x17003B87 RID: 15239
			// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x002EEBDC File Offset: 0x002ECDDC
			// (set) Token: 0x0600BF6B RID: 49003 RVA: 0x0005D8E1 File Offset: 0x0005BAE1
			public unsafe static int DynamicOcclusionClippingPlaneProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&value));
				}
			}

			// Token: 0x17003B88 RID: 15240
			// (get) Token: 0x0600BF6C RID: 49004 RVA: 0x002EEBF8 File Offset: 0x002ECDF8
			// (set) Token: 0x0600BF6D RID: 49005 RVA: 0x0005D8EF File Offset: 0x0005BAEF
			public unsafe static int DynamicOcclusionDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B89 RID: 15241
			// (get) Token: 0x0600BF6E RID: 49006 RVA: 0x002EEC14 File Offset: 0x002ECE14
			// (set) Token: 0x0600BF6F RID: 49007 RVA: 0x0005D8FD File Offset: 0x0005BAFD
			public unsafe static int DynamicOcclusionDepthProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&value));
				}
			}

			// Token: 0x17003B8A RID: 15242
			// (get) Token: 0x0600BF70 RID: 49008 RVA: 0x002EEC30 File Offset: 0x002ECE30
			// (set) Token: 0x0600BF71 RID: 49009 RVA: 0x0005D90B File Offset: 0x0005BB0B
			public unsafe static int LocalForwardDirection
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&value));
				}
			}

			// Token: 0x17003B8B RID: 15243
			// (get) Token: 0x0600BF72 RID: 49010 RVA: 0x002EEC4C File Offset: 0x002ECE4C
			// (set) Token: 0x0600BF73 RID: 49011 RVA: 0x0005D919 File Offset: 0x0005BB19
			public unsafe static int TiltVector
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&value));
				}
			}

			// Token: 0x17003B8C RID: 15244
			// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x002EEC68 File Offset: 0x002ECE68
			// (set) Token: 0x0600BF75 RID: 49013 RVA: 0x0005D927 File Offset: 0x0005BB27
			public unsafe static int AdditionalClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x040081A1 RID: 33185
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutFactor;

			// Token: 0x040081A2 RID: 33186
			private static readonly IntPtr NativeFieldInfoPtr_ConeSlopeCosSin;

			// Token: 0x040081A3 RID: 33187
			private static readonly IntPtr NativeFieldInfoPtr_AlphaInside;

			// Token: 0x040081A4 RID: 33188
			private static readonly IntPtr NativeFieldInfoPtr_AlphaOutside;

			// Token: 0x040081A5 RID: 33189
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLerpLinearQuad;

			// Token: 0x040081A6 RID: 33190
			private static readonly IntPtr NativeFieldInfoPtr_DistanceCamClipping;

			// Token: 0x040081A7 RID: 33191
			private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

			// Token: 0x040081A8 RID: 33192
			private static readonly IntPtr NativeFieldInfoPtr_GlareBehind;

			// Token: 0x040081A9 RID: 33193
			private static readonly IntPtr NativeFieldInfoPtr_GlareFrontal;

			// Token: 0x040081AA RID: 33194
			private static readonly IntPtr NativeFieldInfoPtr_DrawCap;

			// Token: 0x040081AB RID: 33195
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x040081AC RID: 33196
			private static readonly IntPtr NativeFieldInfoPtr_CameraParams;

			// Token: 0x040081AD RID: 33197
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS;

			// Token: 0x040081AE RID: 33198
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps;

			// Token: 0x040081AF RID: 33199
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthTexture;

			// Token: 0x040081B0 RID: 33200
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthProps;

			// Token: 0x040081B1 RID: 33201
			private static readonly IntPtr NativeFieldInfoPtr_LocalForwardDirection;

			// Token: 0x040081B2 RID: 33202
			private static readonly IntPtr NativeFieldInfoPtr_TiltVector;

			// Token: 0x040081B3 RID: 33203
			private static readonly IntPtr NativeFieldInfoPtr_AdditionalClippingPlaneWS;
		}

		// Token: 0x0200083B RID: 2107
		public static class HD : Object
		{
			// Token: 0x0600BF76 RID: 49014 RVA: 0x002EEC84 File Offset: 0x002ECE84
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr);
				ShaderProperties.HD.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Intensity");
				ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "SideSoftness");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardOS");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardWS");
				ShaderProperties.HD.NativeFieldInfoPtr_TransformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "TransformScale");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowDepthTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowProps");
				ShaderProperties.HD.NativeFieldInfoPtr_Jittering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Jittering");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieProperties");
				ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookiePosAndScale");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalCameraBlendingDistance");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalJitteringNoiseTex");
			}

			// Token: 0x0600BF77 RID: 49015 RVA: 0x0005D935 File Offset: 0x0005BB35
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B8D RID: 15245
			// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x002EEDB4 File Offset: 0x002ECFB4
			// (set) Token: 0x0600BF79 RID: 49017 RVA: 0x0005D93E File Offset: 0x0005BB3E
			public unsafe static int Intensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&value));
				}
			}

			// Token: 0x17003B8E RID: 15246
			// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x002EEDD0 File Offset: 0x002ECFD0
			// (set) Token: 0x0600BF7B RID: 49019 RVA: 0x0005D94C File Offset: 0x0005BB4C
			public unsafe static int SideSoftness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&value));
				}
			}

			// Token: 0x17003B8F RID: 15247
			// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x002EEDEC File Offset: 0x002ECFEC
			// (set) Token: 0x0600BF7D RID: 49021 RVA: 0x0005D95A File Offset: 0x0005BB5A
			public unsafe static int CameraForwardOS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&value));
				}
			}

			// Token: 0x17003B90 RID: 15248
			// (get) Token: 0x0600BF7E RID: 49022 RVA: 0x002EEE08 File Offset: 0x002ED008
			// (set) Token: 0x0600BF7F RID: 49023 RVA: 0x0005D968 File Offset: 0x0005BB68
			public unsafe static int CameraForwardWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&value));
				}
			}

			// Token: 0x17003B91 RID: 15249
			// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x002EEE24 File Offset: 0x002ED024
			// (set) Token: 0x0600BF81 RID: 49025 RVA: 0x0005D976 File Offset: 0x0005BB76
			public unsafe static int TransformScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&value));
				}
			}

			// Token: 0x17003B92 RID: 15250
			// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x002EEE40 File Offset: 0x002ED040
			// (set) Token: 0x0600BF83 RID: 49027 RVA: 0x0005D984 File Offset: 0x0005BB84
			public unsafe static int ShadowDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B93 RID: 15251
			// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x002EEE5C File Offset: 0x002ED05C
			// (set) Token: 0x0600BF85 RID: 49029 RVA: 0x0005D992 File Offset: 0x0005BB92
			public unsafe static int ShadowProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&value));
				}
			}

			// Token: 0x17003B94 RID: 15252
			// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x002EEE78 File Offset: 0x002ED078
			// (set) Token: 0x0600BF87 RID: 49031 RVA: 0x0005D9A0 File Offset: 0x0005BBA0
			public unsafe static int Jittering
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&value));
				}
			}

			// Token: 0x17003B95 RID: 15253
			// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x002EEE94 File Offset: 0x002ED094
			// (set) Token: 0x0600BF89 RID: 49033 RVA: 0x0005D9AE File Offset: 0x0005BBAE
			public unsafe static int CookieTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B96 RID: 15254
			// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x002EEEB0 File Offset: 0x002ED0B0
			// (set) Token: 0x0600BF8B RID: 49035 RVA: 0x0005D9BC File Offset: 0x0005BBBC
			public unsafe static int CookieProperties
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&value));
				}
			}

			// Token: 0x17003B97 RID: 15255
			// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x002EEECC File Offset: 0x002ED0CC
			// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x0005D9CA File Offset: 0x0005BBCA
			public unsafe static int CookiePosAndScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&value));
				}
			}

			// Token: 0x17003B98 RID: 15256
			// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x002EEEE8 File Offset: 0x002ED0E8
			// (set) Token: 0x0600BF8F RID: 49039 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
			public unsafe static int GlobalCameraBlendingDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&value));
				}
			}

			// Token: 0x17003B99 RID: 15257
			// (get) Token: 0x0600BF90 RID: 49040 RVA: 0x002EEF04 File Offset: 0x002ED104
			// (set) Token: 0x0600BF91 RID: 49041 RVA: 0x0005D9E6 File Offset: 0x0005BBE6
			public unsafe static int GlobalJitteringNoiseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&value));
				}
			}

			// Token: 0x040081B4 RID: 33204
			private static readonly IntPtr NativeFieldInfoPtr_Intensity;

			// Token: 0x040081B5 RID: 33205
			private static readonly IntPtr NativeFieldInfoPtr_SideSoftness;

			// Token: 0x040081B6 RID: 33206
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardOS;

			// Token: 0x040081B7 RID: 33207
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardWS;

			// Token: 0x040081B8 RID: 33208
			private static readonly IntPtr NativeFieldInfoPtr_TransformScale;

			// Token: 0x040081B9 RID: 33209
			private static readonly IntPtr NativeFieldInfoPtr_ShadowDepthTexture;

			// Token: 0x040081BA RID: 33210
			private static readonly IntPtr NativeFieldInfoPtr_ShadowProps;

			// Token: 0x040081BB RID: 33211
			private static readonly IntPtr NativeFieldInfoPtr_Jittering;

			// Token: 0x040081BC RID: 33212
			private static readonly IntPtr NativeFieldInfoPtr_CookieTexture;

			// Token: 0x040081BD RID: 33213
			private static readonly IntPtr NativeFieldInfoPtr_CookieProperties;

			// Token: 0x040081BE RID: 33214
			private static readonly IntPtr NativeFieldInfoPtr_CookiePosAndScale;

			// Token: 0x040081BF RID: 33215
			private static readonly IntPtr NativeFieldInfoPtr_GlobalCameraBlendingDistance;

			// Token: 0x040081C0 RID: 33216
			private static readonly IntPtr NativeFieldInfoPtr_GlobalJitteringNoiseTex;
		}
	}
}
