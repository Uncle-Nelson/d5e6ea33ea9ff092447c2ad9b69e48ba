using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200013C RID: 316
	public class LUTBlending : MonoBehaviour
	{
		// Token: 0x06001A54 RID: 6740 RVA: 0x000C2DB8 File Offset: 0x000C0FB8
		// Note: this type is marked as 'beforefieldinit'.
		static LUTBlending()
		{
			Il2CppClassPointerStore<LUTBlending>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "LUTBlending");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr);
			LUTBlending.NativeFieldInfoPtr_LUT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1");
			LUTBlending.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2");
			LUTBlending.NativeFieldInfoPtr_LUT1Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1Intensity");
			LUTBlending.NativeFieldInfoPtr_LUT2Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2Intensity");
			LUTBlending.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "phase");
			LUTBlending.NativeFieldInfoPtr_lerpShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpShader");
			LUTBlending.NativeFieldInfoPtr_oldPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "oldPhase");
			LUTBlending.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "rt");
			LUTBlending.NativeFieldInfoPtr_lerpMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpMat");
			LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666092);
			LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666093);
			LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666094);
			LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666095);
			LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666096);
			LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666097);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000C2F14 File Offset: 0x000C1114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97149, XrefRangeEnd = 97150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000C2F48 File Offset: 0x000C1148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97150, XrefRangeEnd = 97151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000C2F7C File Offset: 0x000C117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97151, XrefRangeEnd = 97156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000C2FB0 File Offset: 0x000C11B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000C2FE4 File Offset: 0x000C11E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97207, RefRangeEnd = 97210, XrefRangeStart = 97156, XrefRangeEnd = 97207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeautifyLUT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000C3018 File Offset: 0x000C1218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97210, XrefRangeEnd = 97211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LUTBlending() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000EEBD File Offset: 0x0000D0BD
		public LUTBlending(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x000C3054 File Offset: 0x000C1254
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000EEC6 File Offset: 0x0000D0C6
		public unsafe Texture2D LUT1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x000C3084 File Offset: 0x000C1284
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000EEE5 File Offset: 0x0000D0E5
		public unsafe Texture2D LUT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x000C30B4 File Offset: 0x000C12B4
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000EF04 File Offset: 0x0000D104
		public unsafe float LUT1Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity)) = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000C30DC File Offset: 0x000C12DC
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000EF1F File Offset: 0x0000D11F
		public unsafe float LUT2Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity)) = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000C3104 File Offset: 0x000C1304
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000EF3A File Offset: 0x0000D13A
		public unsafe float phase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase)) = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000C312C File Offset: 0x000C132C
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000EF55 File Offset: 0x0000D155
		public unsafe Shader lerpShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000C315C File Offset: 0x000C135C
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000EF74 File Offset: 0x0000D174
		public unsafe float oldPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase)) = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x000C3184 File Offset: 0x000C1384
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000EF8F File Offset: 0x0000D18F
		public unsafe RenderTexture rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x000C31B4 File Offset: 0x000C13B4
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000EFAE File Offset: 0x0000D1AE
		public unsafe Material lerpMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_LUT1;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr_LUT2;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr_LUT1Intensity;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_LUT2Intensity;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_phase;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_lerpShader;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr_oldPhase;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr_lerpMat;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000859 RID: 2137
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600C075 RID: 49269 RVA: 0x002F0F54 File Offset: 0x002EF154
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr);
				LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "LUT2");
				LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "Phase");
			}

			// Token: 0x0600C076 RID: 49270 RVA: 0x0005E04A File Offset: 0x0005C24A
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BEF RID: 15343
			// (get) Token: 0x0600C077 RID: 49271 RVA: 0x002F0FA8 File Offset: 0x002EF1A8
			// (set) Token: 0x0600C078 RID: 49272 RVA: 0x0005E053 File Offset: 0x0005C253
			public unsafe static int LUT2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&value));
				}
			}

			// Token: 0x17003BF0 RID: 15344
			// (get) Token: 0x0600C079 RID: 49273 RVA: 0x002F0FC4 File Offset: 0x002EF1C4
			// (set) Token: 0x0600C07A RID: 49274 RVA: 0x0005E061 File Offset: 0x0005C261
			public unsafe static int Phase
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&value));
				}
			}

			// Token: 0x0400826A RID: 33386
			private static readonly IntPtr NativeFieldInfoPtr_LUT2;

			// Token: 0x0400826B RID: 33387
			private static readonly IntPtr NativeFieldInfoPtr_Phase;
		}
	}
}
