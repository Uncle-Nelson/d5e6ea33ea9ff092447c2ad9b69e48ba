using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D9 RID: 217
	public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature
	{
		// Token: 0x060011A6 RID: 4518 RVA: 0x000A7F4C File Offset: 0x000A614C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeDepthPrePassRenderFeature()
		{
			Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidVolumeDepthPrePassRenderFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr);
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvBackRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvFrontRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "shader");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "installed");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "mat");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "backPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "frontPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "interleavedRendering");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "renderPassEvent");
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665314);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665315);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665316);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665317);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665318);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665319);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665320);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100665321);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000A80D0 File Offset: 0x000A62D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88328, RefRangeEnd = 88329, XrefRangeStart = 88311, XrefRangeEnd = 88328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000A8108 File Offset: 0x000A6308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88346, RefRangeEnd = 88348, XrefRangeStart = 88329, XrefRangeEnd = 88346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000A8140 File Offset: 0x000A6340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88365, RefRangeEnd = 88366, XrefRangeStart = 88348, XrefRangeEnd = 88365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000A8178 File Offset: 0x000A6378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88383, RefRangeEnd = 88385, XrefRangeStart = 88366, XrefRangeEnd = 88383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x000A81B0 File Offset: 0x000A63B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88385, XrefRangeEnd = 88402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000A81E4 File Offset: 0x000A63E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88402, XrefRangeEnd = 88427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000A8220 File Offset: 0x000A6420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88427, XrefRangeEnd = 88443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000A8280 File Offset: 0x000A6480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88443, XrefRangeEnd = 88444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeDepthPrePassRenderFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0000AC5B File Offset: 0x00008E5B
		public LiquidVolumeDepthPrePassRenderFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x000A82BC File Offset: 0x000A64BC
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0000AC64 File Offset: 0x00008E64
		public unsafe static List<LiquidVolume> lvBackRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x000A82E4 File Offset: 0x000A64E4
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x0000AC76 File Offset: 0x00008E76
		public unsafe static List<LiquidVolume> lvFrontRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000A830C File Offset: 0x000A650C
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0000AC88 File Offset: 0x00008E88
		public unsafe Shader shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000A833C File Offset: 0x000A653C
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		public unsafe static bool installed
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000A8358 File Offset: 0x000A6558
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0000ACB5 File Offset: 0x00008EB5
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000A8388 File Offset: 0x000A6588
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000A83B8 File Offset: 0x000A65B8
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000ACF3 File Offset: 0x00008EF3
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000A83E8 File Offset: 0x000A65E8
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000AD12 File Offset: 0x00008F12
		public unsafe bool interleavedRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000A8410 File Offset: 0x000A6610
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0000AD2D File Offset: 0x00008F2D
		public unsafe RenderPassEvent renderPassEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent)) = value;
			}
		}

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_lvBackRenderers;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_lvFrontRenderers;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_shader;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_installed;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_backPass;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_frontPass;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_renderPassEvent;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084B RID: 2123
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600C02F RID: 49199 RVA: 0x002F0304 File Offset: 0x002EE504
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "FlaskThickness");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "ForcedInvisible");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "SKW_FP_RENDER_TEXTURE");
			}

			// Token: 0x0600C030 RID: 49200 RVA: 0x0005DE2C File Offset: 0x0005C02C
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BD9 RID: 15321
			// (get) Token: 0x0600C031 RID: 49201 RVA: 0x002F03BC File Offset: 0x002EE5BC
			// (set) Token: 0x0600C032 RID: 49202 RVA: 0x0005DE35 File Offset: 0x0005C035
			public unsafe static string RTBackBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BDA RID: 15322
			// (get) Token: 0x0600C033 RID: 49203 RVA: 0x002F03DC File Offset: 0x002EE5DC
			// (set) Token: 0x0600C034 RID: 49204 RVA: 0x0005DE47 File Offset: 0x0005C047
			public unsafe static int RTBackBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&value));
				}
			}

			// Token: 0x17003BDB RID: 15323
			// (get) Token: 0x0600C035 RID: 49205 RVA: 0x002F03F8 File Offset: 0x002EE5F8
			// (set) Token: 0x0600C036 RID: 49206 RVA: 0x0005DE55 File Offset: 0x0005C055
			public unsafe static string RTFrontBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BDC RID: 15324
			// (get) Token: 0x0600C037 RID: 49207 RVA: 0x002F0418 File Offset: 0x002EE618
			// (set) Token: 0x0600C038 RID: 49208 RVA: 0x0005DE67 File Offset: 0x0005C067
			public unsafe static int RTFrontBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&value));
				}
			}

			// Token: 0x17003BDD RID: 15325
			// (get) Token: 0x0600C039 RID: 49209 RVA: 0x002F0434 File Offset: 0x002EE634
			// (set) Token: 0x0600C03A RID: 49210 RVA: 0x0005DE75 File Offset: 0x0005C075
			public unsafe static int FlaskThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&value));
				}
			}

			// Token: 0x17003BDE RID: 15326
			// (get) Token: 0x0600C03B RID: 49211 RVA: 0x002F0450 File Offset: 0x002EE650
			// (set) Token: 0x0600C03C RID: 49212 RVA: 0x0005DE83 File Offset: 0x0005C083
			public unsafe static int ForcedInvisible
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&value));
				}
			}

			// Token: 0x17003BDF RID: 15327
			// (get) Token: 0x0600C03D RID: 49213 RVA: 0x002F046C File Offset: 0x002EE66C
			// (set) Token: 0x0600C03E RID: 49214 RVA: 0x0005DE91 File Offset: 0x0005C091
			public unsafe static string SKW_FP_RENDER_TEXTURE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008222 RID: 33314
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBufferName;

			// Token: 0x04008223 RID: 33315
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBuffer;

			// Token: 0x04008224 RID: 33316
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBufferName;

			// Token: 0x04008225 RID: 33317
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBuffer;

			// Token: 0x04008226 RID: 33318
			private static readonly IntPtr NativeFieldInfoPtr_FlaskThickness;

			// Token: 0x04008227 RID: 33319
			private static readonly IntPtr NativeFieldInfoPtr_ForcedInvisible;

			// Token: 0x04008228 RID: 33320
			private static readonly IntPtr NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE;
		}

		// Token: 0x0200084C RID: 2124
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x0400822A RID: 33322
			BackBuffer,
			// Token: 0x0400822B RID: 33323
			FrontBuffer
		}

		// Token: 0x0200084D RID: 2125
		public class DepthPass : ScriptableRenderPass
		{
			// Token: 0x0600C03F RID: 49215 RVA: 0x002F048C File Offset: 0x002EE68C
			// Note: this type is marked as 'beforefieldinit'.
			static DepthPass()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "DepthPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "profilerTag");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "mat");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetNameId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetRT");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "lvRenderers");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "renderer");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "interleavedRendering");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "currentCameraPosition");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passData");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665324);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665325);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665326);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665327);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665328);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665329);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100665330);
			}

			// Token: 0x0600C040 RID: 49216 RVA: 0x002F060C File Offset: 0x002EE80C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88205, RefRangeEnd = 88207, XrefRangeStart = 88176, XrefRangeEnd = 88205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DepthPass(Material mat, LiquidVolumeDepthPrePassRenderFeature.Pass pass, RenderPassEvent renderPassEvent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassEvent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C041 RID: 49217 RVA: 0x002F0674 File Offset: 0x002EE874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88207, XrefRangeEnd = 88208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Setup(LiquidVolumeDepthPrePassRenderFeature feature, ScriptableRenderer renderer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C042 RID: 49218 RVA: 0x002F06C8 File Offset: 0x002EE8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88208, XrefRangeEnd = 88230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int SortByDistanceToCamera(LiquidVolume lv1, LiquidVolume lv2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv1);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lv2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C043 RID: 49219 RVA: 0x002F0728 File Offset: 0x002EE928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88230, XrefRangeEnd = 88239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C044 RID: 49220 RVA: 0x002F0784 File Offset: 0x002EE984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88239, XrefRangeEnd = 88259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref context;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C045 RID: 49221 RVA: 0x002F07E0 File Offset: 0x002EE9E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88306, RefRangeEnd = 88307, XrefRangeStart = 88259, XrefRangeEnd = 88306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ExecutePass(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(passData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C046 RID: 49222 RVA: 0x002F0818 File Offset: 0x002EEA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88307, XrefRangeEnd = 88311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CleanUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C047 RID: 49223 RVA: 0x0005DEA3 File Offset: 0x0005C0A3
			public DepthPass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE0 RID: 15328
			// (get) Token: 0x0600C048 RID: 49224 RVA: 0x002F084C File Offset: 0x002EEA4C
			// (set) Token: 0x0600C049 RID: 49225 RVA: 0x0005DEAC File Offset: 0x0005C0AC
			public unsafe static string profilerTag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BE1 RID: 15329
			// (get) Token: 0x0600C04A RID: 49226 RVA: 0x002F086C File Offset: 0x002EEA6C
			// (set) Token: 0x0600C04B RID: 49227 RVA: 0x0005DEBE File Offset: 0x0005C0BE
			public unsafe Material mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE2 RID: 15330
			// (get) Token: 0x0600C04C RID: 49228 RVA: 0x002F089C File Offset: 0x002EEA9C
			// (set) Token: 0x0600C04D RID: 49229 RVA: 0x0005DEDD File Offset: 0x0005C0DD
			public unsafe int targetNameId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId)) = value;
				}
			}

			// Token: 0x17003BE3 RID: 15331
			// (get) Token: 0x0600C04E RID: 49230 RVA: 0x002F08C4 File Offset: 0x002EEAC4
			// (set) Token: 0x0600C04F RID: 49231 RVA: 0x0005DEF8 File Offset: 0x0005C0F8
			public unsafe RTHandle targetRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE4 RID: 15332
			// (get) Token: 0x0600C050 RID: 49232 RVA: 0x002F08F4 File Offset: 0x002EEAF4
			// (set) Token: 0x0600C051 RID: 49233 RVA: 0x0005DF17 File Offset: 0x0005C117
			public unsafe int passId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId)) = value;
				}
			}

			// Token: 0x17003BE5 RID: 15333
			// (get) Token: 0x0600C052 RID: 49234 RVA: 0x002F091C File Offset: 0x002EEB1C
			// (set) Token: 0x0600C053 RID: 49235 RVA: 0x0005DF32 File Offset: 0x0005C132
			public unsafe List<LiquidVolume> lvRenderers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE6 RID: 15334
			// (get) Token: 0x0600C054 RID: 49236 RVA: 0x002F094C File Offset: 0x002EEB4C
			// (set) Token: 0x0600C055 RID: 49237 RVA: 0x0005DF51 File Offset: 0x0005C151
			public unsafe ScriptableRenderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE7 RID: 15335
			// (get) Token: 0x0600C056 RID: 49238 RVA: 0x002F097C File Offset: 0x002EEB7C
			// (set) Token: 0x0600C057 RID: 49239 RVA: 0x0005DF70 File Offset: 0x0005C170
			public unsafe bool interleavedRendering
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering)) = value;
				}
			}

			// Token: 0x17003BE8 RID: 15336
			// (get) Token: 0x0600C058 RID: 49240 RVA: 0x002F09A4 File Offset: 0x002EEBA4
			// (set) Token: 0x0600C059 RID: 49241 RVA: 0x0005DF8B File Offset: 0x0005C18B
			public unsafe static Vector3 currentCameraPosition
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&value));
				}
			}

			// Token: 0x17003BE9 RID: 15337
			// (get) Token: 0x0600C05A RID: 49242 RVA: 0x002F09C0 File Offset: 0x002EEBC0
			// (set) Token: 0x0600C05B RID: 49243 RVA: 0x0005DF99 File Offset: 0x0005C199
			public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400822C RID: 33324
			private static readonly IntPtr NativeFieldInfoPtr_profilerTag;

			// Token: 0x0400822D RID: 33325
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x0400822E RID: 33326
			private static readonly IntPtr NativeFieldInfoPtr_targetNameId;

			// Token: 0x0400822F RID: 33327
			private static readonly IntPtr NativeFieldInfoPtr_targetRT;

			// Token: 0x04008230 RID: 33328
			private static readonly IntPtr NativeFieldInfoPtr_passId;

			// Token: 0x04008231 RID: 33329
			private static readonly IntPtr NativeFieldInfoPtr_lvRenderers;

			// Token: 0x04008232 RID: 33330
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x04008233 RID: 33331
			private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

			// Token: 0x04008234 RID: 33332
			private static readonly IntPtr NativeFieldInfoPtr_currentCameraPosition;

			// Token: 0x04008235 RID: 33333
			private static readonly IntPtr NativeFieldInfoPtr_passData;

			// Token: 0x04008236 RID: 33334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0;

			// Token: 0x04008237 RID: 33335
			private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0;

			// Token: 0x04008238 RID: 33336
			private static readonly IntPtr NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0;

			// Token: 0x04008239 RID: 33337
			private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

			// Token: 0x0400823A RID: 33338
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x0400823B RID: 33339
			private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0;

			// Token: 0x0400823C RID: 33340
			private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Public_Void_0;

			// Token: 0x02000C2B RID: 3115
			public class PassData : Il2CppSystem.Object
			{
				// Token: 0x0600E10D RID: 57613 RVA: 0x0034EB3C File Offset: 0x0034CD3C
				// Note: this type is marked as 'beforefieldinit'.
				static PassData()
				{
					Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "PassData");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr);
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cam");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cmd");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depthPass");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "mat");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "source");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depth");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cameraTargetDescriptor");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, 100665331);
				}

				// Token: 0x0600E10E RID: 57614 RVA: 0x0034EC08 File Offset: 0x0034CE08
				[CallerCount(2261)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PassData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E10F RID: 57615 RVA: 0x0006DB80 File Offset: 0x0006BD80
				public PassData(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045B8 RID: 17848
				// (get) Token: 0x0600E110 RID: 57616 RVA: 0x0034EC44 File Offset: 0x0034CE44
				// (set) Token: 0x0600E111 RID: 57617 RVA: 0x0006DB89 File Offset: 0x0006BD89
				public unsafe Camera cam
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045B9 RID: 17849
				// (get) Token: 0x0600E112 RID: 57618 RVA: 0x0034EC74 File Offset: 0x0034CE74
				// (set) Token: 0x0600E113 RID: 57619 RVA: 0x0006DBA8 File Offset: 0x0006BDA8
				public unsafe CommandBuffer cmd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BA RID: 17850
				// (get) Token: 0x0600E114 RID: 57620 RVA: 0x0034ECA4 File Offset: 0x0034CEA4
				// (set) Token: 0x0600E115 RID: 57621 RVA: 0x0006DBC7 File Offset: 0x0006BDC7
				public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass depthPass
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BB RID: 17851
				// (get) Token: 0x0600E116 RID: 57622 RVA: 0x0034ECD4 File Offset: 0x0034CED4
				// (set) Token: 0x0600E117 RID: 57623 RVA: 0x0006DBE6 File Offset: 0x0006BDE6
				public unsafe Material mat
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BC RID: 17852
				// (get) Token: 0x0600E118 RID: 57624 RVA: 0x0034ED04 File Offset: 0x0034CF04
				// (set) Token: 0x0600E119 RID: 57625 RVA: 0x0006DC05 File Offset: 0x0006BE05
				public unsafe RTHandle source
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BD RID: 17853
				// (get) Token: 0x0600E11A RID: 57626 RVA: 0x0034ED34 File Offset: 0x0034CF34
				// (set) Token: 0x0600E11B RID: 57627 RVA: 0x0006DC24 File Offset: 0x0006BE24
				public unsafe RTHandle depth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045BE RID: 17854
				// (get) Token: 0x0600E11C RID: 57628 RVA: 0x0034ED64 File Offset: 0x0034CF64
				// (set) Token: 0x0600E11D RID: 57629 RVA: 0x0006DC43 File Offset: 0x0006BE43
				public unsafe RenderTextureDescriptor cameraTargetDescriptor
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor)) = value;
					}
				}

				// Token: 0x040096B8 RID: 38584
				private static readonly IntPtr NativeFieldInfoPtr_cam;

				// Token: 0x040096B9 RID: 38585
				private static readonly IntPtr NativeFieldInfoPtr_cmd;

				// Token: 0x040096BA RID: 38586
				private static readonly IntPtr NativeFieldInfoPtr_depthPass;

				// Token: 0x040096BB RID: 38587
				private static readonly IntPtr NativeFieldInfoPtr_mat;

				// Token: 0x040096BC RID: 38588
				private static readonly IntPtr NativeFieldInfoPtr_source;

				// Token: 0x040096BD RID: 38589
				private static readonly IntPtr NativeFieldInfoPtr_depth;

				// Token: 0x040096BE RID: 38590
				private static readonly IntPtr NativeFieldInfoPtr_cameraTargetDescriptor;

				// Token: 0x040096BF RID: 38591
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}
	}
}
