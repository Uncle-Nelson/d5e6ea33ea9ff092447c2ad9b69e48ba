using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000AE RID: 174
	public static class ShaderKeywords : Object
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x0009A3B4 File Offset: 0x000985B4
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "AlphaAsBlack");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixLow");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixHigh");
			ShaderKeywords.NativeFieldInfoPtr_Noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "Noise3D");
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0000860F File Offset: 0x0000680F
		public ShaderKeywords(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0009A434 File Offset: 0x00098634
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00008618 File Offset: 0x00006818
		public unsafe static string AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0009A454 File Offset: 0x00098654
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0000862A File Offset: 0x0000682A
		public unsafe static string ColorGradientMatrixLow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0009A474 File Offset: 0x00098674
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0000863C File Offset: 0x0000683C
		public unsafe static string ColorGradientMatrixHigh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0009A494 File Offset: 0x00098694
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0000864E File Offset: 0x0000684E
		public unsafe static string Noise3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_AlphaAsBlack;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixLow;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixHigh;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_Noise3D;

		// Token: 0x02000838 RID: 2104
		public static class SD : Object
		{
			// Token: 0x0600BF33 RID: 48947 RVA: 0x002EE5E8 File Offset: 0x002EC7E8
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr);
				ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "DepthBlend");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionClippingPlane");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionDepthTexture");
				ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "MeshSkewing");
				ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "ShaderAccuracyHigh");
			}

			// Token: 0x0600BF34 RID: 48948 RVA: 0x0005D74A File Offset: 0x0005B94A
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B6F RID: 15215
			// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x002EE678 File Offset: 0x002EC878
			// (set) Token: 0x0600BF36 RID: 48950 RVA: 0x0005D753 File Offset: 0x0005B953
			public unsafe static string DepthBlend
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B70 RID: 15216
			// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x002EE698 File Offset: 0x002EC898
			// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x0005D765 File Offset: 0x0005B965
			public unsafe static string OcclusionClippingPlane
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B71 RID: 15217
			// (get) Token: 0x0600BF39 RID: 48953 RVA: 0x002EE6B8 File Offset: 0x002EC8B8
			// (set) Token: 0x0600BF3A RID: 48954 RVA: 0x0005D777 File Offset: 0x0005B977
			public unsafe static string OcclusionDepthTexture
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B72 RID: 15218
			// (get) Token: 0x0600BF3B RID: 48955 RVA: 0x002EE6D8 File Offset: 0x002EC8D8
			// (set) Token: 0x0600BF3C RID: 48956 RVA: 0x0005D789 File Offset: 0x0005B989
			public unsafe static string MeshSkewing
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B73 RID: 15219
			// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x002EE6F8 File Offset: 0x002EC8F8
			// (set) Token: 0x0600BF3E RID: 48958 RVA: 0x0005D79B File Offset: 0x0005B99B
			public unsafe static string ShaderAccuracyHigh
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008195 RID: 33173
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlend;

			// Token: 0x04008196 RID: 33174
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionClippingPlane;

			// Token: 0x04008197 RID: 33175
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionDepthTexture;

			// Token: 0x04008198 RID: 33176
			private static readonly IntPtr NativeFieldInfoPtr_MeshSkewing;

			// Token: 0x04008199 RID: 33177
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyHigh;
		}

		// Token: 0x02000839 RID: 2105
		public static class HD : Object
		{
			// Token: 0x0600BF3F RID: 48959 RVA: 0x002EE718 File Offset: 0x002EC918
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr);
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationLinear");
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationQuad");
				ShaderKeywords.HD.NativeFieldInfoPtr_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "Shadow");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieSingleChannel");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieRGBA");
				ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "RaymarchingStepCount");
				ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, 100664898);
			}

			// Token: 0x0600BF40 RID: 48960 RVA: 0x002EE7D0 File Offset: 0x002EC9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84382, XrefRangeEnd = 84386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetRaymarchingQuality(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BF41 RID: 48961 RVA: 0x0005D7AD File Offset: 0x0005B9AD
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B74 RID: 15220
			// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x002EE808 File Offset: 0x002ECA08
			// (set) Token: 0x0600BF43 RID: 48963 RVA: 0x0005D7B6 File Offset: 0x0005B9B6
			public unsafe static string AttenuationLinear
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B75 RID: 15221
			// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x002EE828 File Offset: 0x002ECA28
			// (set) Token: 0x0600BF45 RID: 48965 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
			public unsafe static string AttenuationQuad
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B76 RID: 15222
			// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x002EE848 File Offset: 0x002ECA48
			// (set) Token: 0x0600BF47 RID: 48967 RVA: 0x0005D7DA File Offset: 0x0005B9DA
			public unsafe static string Shadow
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B77 RID: 15223
			// (get) Token: 0x0600BF48 RID: 48968 RVA: 0x002EE868 File Offset: 0x002ECA68
			// (set) Token: 0x0600BF49 RID: 48969 RVA: 0x0005D7EC File Offset: 0x0005B9EC
			public unsafe static string CookieSingleChannel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B78 RID: 15224
			// (get) Token: 0x0600BF4A RID: 48970 RVA: 0x002EE888 File Offset: 0x002ECA88
			// (set) Token: 0x0600BF4B RID: 48971 RVA: 0x0005D7FE File Offset: 0x0005B9FE
			public unsafe static string CookieRGBA
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B79 RID: 15225
			// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x002EE8A8 File Offset: 0x002ECAA8
			// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x0005D810 File Offset: 0x0005BA10
			public unsafe static string RaymarchingStepCount
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400819A RID: 33178
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLinear;

			// Token: 0x0400819B RID: 33179
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationQuad;

			// Token: 0x0400819C RID: 33180
			private static readonly IntPtr NativeFieldInfoPtr_Shadow;

			// Token: 0x0400819D RID: 33181
			private static readonly IntPtr NativeFieldInfoPtr_CookieSingleChannel;

			// Token: 0x0400819E RID: 33182
			private static readonly IntPtr NativeFieldInfoPtr_CookieRGBA;

			// Token: 0x0400819F RID: 33183
			private static readonly IntPtr NativeFieldInfoPtr_RaymarchingStepCount;

			// Token: 0x040081A0 RID: 33184
			private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0;
		}
	}
}
