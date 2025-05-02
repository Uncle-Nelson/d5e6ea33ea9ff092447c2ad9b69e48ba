using System;
using Il2CppAmplifyColor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000004 RID: 4
	public class AmplifyColorRenderMask : MonoBehaviour
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00073284 File Offset: 0x00071484
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyColorRenderMask()
		{
			Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmplifyColorRenderMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr);
			AmplifyColorRenderMask.NativeFieldInfoPtr_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "ClearColor");
			AmplifyColorRenderMask.NativeFieldInfoPtr_RenderLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "RenderLayers");
			AmplifyColorRenderMask.NativeFieldInfoPtr_DebugMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "DebugMask");
			AmplifyColorRenderMask.NativeFieldInfoPtr_referenceCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "referenceCamera");
			AmplifyColorRenderMask.NativeFieldInfoPtr_maskCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "maskCamera");
			AmplifyColorRenderMask.NativeFieldInfoPtr_colorEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "colorEffect");
			AmplifyColorRenderMask.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "width");
			AmplifyColorRenderMask.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "height");
			AmplifyColorRenderMask.NativeFieldInfoPtr_maskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "maskTexture");
			AmplifyColorRenderMask.NativeFieldInfoPtr_colorMaskShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "colorMaskShader");
			AmplifyColorRenderMask.NativeFieldInfoPtr_singlePassStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, "singlePassStereo");
			AmplifyColorRenderMask.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663341);
			AmplifyColorRenderMask.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663342);
			AmplifyColorRenderMask.NativeMethodInfoPtr_DestroyCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663343);
			AmplifyColorRenderMask.NativeMethodInfoPtr_DestroyRenderTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663344);
			AmplifyColorRenderMask.NativeMethodInfoPtr_UpdateRenderTextures_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663345);
			AmplifyColorRenderMask.NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663346);
			AmplifyColorRenderMask.NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663347);
			AmplifyColorRenderMask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr, 100663348);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00073430 File Offset: 0x00071630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71040, XrefRangeEnd = 71086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00073464 File Offset: 0x00071664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71086, XrefRangeEnd = 71097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00073498 File Offset: 0x00071698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71097, XrefRangeEnd = 71106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_DestroyCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000734CC File Offset: 0x000716CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71115, RefRangeEnd = 71117, XrefRangeStart = 71106, XrefRangeEnd = 71115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyRenderTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_DestroyRenderTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00073500 File Offset: 0x00071700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71153, RefRangeEnd = 71154, XrefRangeStart = 71117, XrefRangeEnd = 71153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRenderTextures(bool singlePassStereo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref singlePassStereo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_UpdateRenderTextures_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00073540 File Offset: 0x00071740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71154, XrefRangeEnd = 71163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00073574 File Offset: 0x00071774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71163, XrefRangeEnd = 71224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000735A8 File Offset: 0x000717A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71224, XrefRangeEnd = 71229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmplifyColorRenderMask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyColorRenderMask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyColorRenderMask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000027F6 File Offset: 0x000009F6
		public AmplifyColorRenderMask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000735E4 File Offset: 0x000717E4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000027FF File Offset: 0x000009FF
		public unsafe Color ClearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_ClearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_ClearColor)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0007360C File Offset: 0x0007180C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000281A File Offset: 0x00000A1A
		public unsafe Il2CppStructArray<RenderLayer> RenderLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_RenderLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderLayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_RenderLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0007363C File Offset: 0x0007183C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002839 File Offset: 0x00000A39
		public unsafe bool DebugMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_DebugMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_DebugMask)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00073664 File Offset: 0x00071864
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002854 File Offset: 0x00000A54
		public unsafe Camera referenceCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_referenceCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_referenceCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00073694 File Offset: 0x00071894
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe Camera maskCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_maskCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_maskCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000736C4 File Offset: 0x000718C4
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002892 File Offset: 0x00000A92
		public unsafe AmplifyColorEffect colorEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_colorEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_colorEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000736F4 File Offset: 0x000718F4
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000028B1 File Offset: 0x00000AB1
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0007371C File Offset: 0x0007191C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000028CC File Offset: 0x00000ACC
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00073744 File Offset: 0x00071944
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000028E7 File Offset: 0x00000AE7
		public unsafe RenderTexture maskTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_maskTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_maskTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00073774 File Offset: 0x00071974
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002906 File Offset: 0x00000B06
		public unsafe Shader colorMaskShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_colorMaskShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_colorMaskShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000737A4 File Offset: 0x000719A4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002925 File Offset: 0x00000B25
		public unsafe bool singlePassStereo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_singlePassStereo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyColorRenderMask.NativeFieldInfoPtr_singlePassStereo)) = value;
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_ClearColor;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_RenderLayers;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_DebugMask;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_referenceCamera;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_maskCamera;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_colorEffect;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_maskTexture;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_colorMaskShader;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_singlePassStereo;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_DestroyCamera_Private_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_DestroyRenderTextures_Private_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRenderTextures_Private_Void_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
