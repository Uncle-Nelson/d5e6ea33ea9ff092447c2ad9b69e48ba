using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004F RID: 79
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x00082F88 File Offset: 0x00081188
		// Note: this type is marked as 'beforefieldinit'.
		static BloomComponent()
		{
			Il2CppClassPointerStore<BloomComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BloomComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr);
			BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "k_MaxPyramidBlurLevel");
			BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "m_BlurBuffer1");
			BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "m_BlurBuffer2");
			BloomComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663881);
			BloomComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663882);
			BloomComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663883);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00083030 File Offset: 0x00081230
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75931, XrefRangeEnd = 75932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0008306C File Offset: 0x0008126C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76029, RefRangeEnd = 76030, XrefRangeStart = 75932, XrefRangeEnd = 76029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(autoExposure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000830D4 File Offset: 0x000812D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76040, RefRangeEnd = 76041, XrefRangeStart = 76030, XrefRangeEnd = 76040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00005AD5 File Offset: 0x00003CD5
		public BloomComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00083110 File Offset: 0x00081310
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00005ADE File Offset: 0x00003CDE
		public unsafe static int k_MaxPyramidBlurLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel, (void*)(&value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0008312C File Offset: 0x0008132C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00005AEC File Offset: 0x00003CEC
		public unsafe Il2CppReferenceArray<RenderTexture> m_BlurBuffer1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0008315C File Offset: 0x0008135C
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00005B0B File Offset: 0x00003D0B
		public unsafe Il2CppReferenceArray<RenderTexture> m_BlurBuffer2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxPyramidBlurLevel;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_m_BlurBuffer1;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_m_BlurBuffer2;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C6 RID: 1990
		public static class Uniforms : Object
		{
			// Token: 0x0600BAF1 RID: 47857 RVA: 0x002E4D00 File Offset: 0x002E2F00
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr);
				BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_AutoExposure");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Threshold");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Curve");
				BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_PrefilterOffs");
				BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_SampleScale");
				BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_BaseTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_BloomTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_Settings");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_DirtTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_DirtIntensity");
			}

			// Token: 0x0600BAF2 RID: 47858 RVA: 0x0005B819 File Offset: 0x00059A19
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039C0 RID: 14784
			// (get) Token: 0x0600BAF3 RID: 47859 RVA: 0x002E4DF4 File Offset: 0x002E2FF4
			// (set) Token: 0x0600BAF4 RID: 47860 RVA: 0x0005B822 File Offset: 0x00059A22
			public unsafe static int _AutoExposure
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&value));
				}
			}

			// Token: 0x170039C1 RID: 14785
			// (get) Token: 0x0600BAF5 RID: 47861 RVA: 0x002E4E10 File Offset: 0x002E3010
			// (set) Token: 0x0600BAF6 RID: 47862 RVA: 0x0005B830 File Offset: 0x00059A30
			public unsafe static int _Threshold
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold, (void*)(&value));
				}
			}

			// Token: 0x170039C2 RID: 14786
			// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x002E4E2C File Offset: 0x002E302C
			// (set) Token: 0x0600BAF8 RID: 47864 RVA: 0x0005B83E File Offset: 0x00059A3E
			public unsafe static int _Curve
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Curve, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Curve, (void*)(&value));
				}
			}

			// Token: 0x170039C3 RID: 14787
			// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x002E4E48 File Offset: 0x002E3048
			// (set) Token: 0x0600BAFA RID: 47866 RVA: 0x0005B84C File Offset: 0x00059A4C
			public unsafe static int _PrefilterOffs
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs, (void*)(&value));
				}
			}

			// Token: 0x170039C4 RID: 14788
			// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x002E4E64 File Offset: 0x002E3064
			// (set) Token: 0x0600BAFC RID: 47868 RVA: 0x0005B85A File Offset: 0x00059A5A
			public unsafe static int _SampleScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale, (void*)(&value));
				}
			}

			// Token: 0x170039C5 RID: 14789
			// (get) Token: 0x0600BAFD RID: 47869 RVA: 0x002E4E80 File Offset: 0x002E3080
			// (set) Token: 0x0600BAFE RID: 47870 RVA: 0x0005B868 File Offset: 0x00059A68
			public unsafe static int _BaseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex, (void*)(&value));
				}
			}

			// Token: 0x170039C6 RID: 14790
			// (get) Token: 0x0600BAFF RID: 47871 RVA: 0x002E4E9C File Offset: 0x002E309C
			// (set) Token: 0x0600BB00 RID: 47872 RVA: 0x0005B876 File Offset: 0x00059A76
			public unsafe static int _BloomTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex, (void*)(&value));
				}
			}

			// Token: 0x170039C7 RID: 14791
			// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x002E4EB8 File Offset: 0x002E30B8
			// (set) Token: 0x0600BB02 RID: 47874 RVA: 0x0005B884 File Offset: 0x00059A84
			public unsafe static int _Bloom_Settings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings, (void*)(&value));
				}
			}

			// Token: 0x170039C8 RID: 14792
			// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x002E4ED4 File Offset: 0x002E30D4
			// (set) Token: 0x0600BB04 RID: 47876 RVA: 0x0005B892 File Offset: 0x00059A92
			public unsafe static int _Bloom_DirtTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex, (void*)(&value));
				}
			}

			// Token: 0x170039C9 RID: 14793
			// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x002E4EF0 File Offset: 0x002E30F0
			// (set) Token: 0x0600BB06 RID: 47878 RVA: 0x0005B8A0 File Offset: 0x00059AA0
			public unsafe static int _Bloom_DirtIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity, (void*)(&value));
				}
			}

			// Token: 0x04007E11 RID: 32273
			private static readonly IntPtr NativeFieldInfoPtr__AutoExposure;

			// Token: 0x04007E12 RID: 32274
			private static readonly IntPtr NativeFieldInfoPtr__Threshold;

			// Token: 0x04007E13 RID: 32275
			private static readonly IntPtr NativeFieldInfoPtr__Curve;

			// Token: 0x04007E14 RID: 32276
			private static readonly IntPtr NativeFieldInfoPtr__PrefilterOffs;

			// Token: 0x04007E15 RID: 32277
			private static readonly IntPtr NativeFieldInfoPtr__SampleScale;

			// Token: 0x04007E16 RID: 32278
			private static readonly IntPtr NativeFieldInfoPtr__BaseTex;

			// Token: 0x04007E17 RID: 32279
			private static readonly IntPtr NativeFieldInfoPtr__BloomTex;

			// Token: 0x04007E18 RID: 32280
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_Settings;

			// Token: 0x04007E19 RID: 32281
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_DirtTex;

			// Token: 0x04007E1A RID: 32282
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_DirtIntensity;
		}
	}
}
