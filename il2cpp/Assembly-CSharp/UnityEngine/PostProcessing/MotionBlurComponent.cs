using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000059 RID: 89
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x00085200 File Offset: 0x00083400
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurComponent()
		{
			Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MotionBlurComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr);
			MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_ReconstructionFilter");
			MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_FrameBlendingFilter");
			MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_FirstFrame");
			MotionBlurComponent.NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663976);
			MotionBlurComponent.NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663977);
			MotionBlurComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663978);
			MotionBlurComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663979);
			MotionBlurComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663980);
			MotionBlurComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663981);
			MotionBlurComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663982);
			MotionBlurComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663983);
			MotionBlurComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663984);
			MotionBlurComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663985);
			MotionBlurComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663986);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00085348 File Offset: 0x00083548
		public unsafe MotionBlurComponent.ReconstructionFilter reconstructionFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77248, RefRangeEnd = 77251, XrefRangeStart = 77242, XrefRangeEnd = 77248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.ReconstructionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00085388 File Offset: 0x00083588
		public unsafe MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 77271, RefRangeEnd = 77275, XrefRangeStart = 77251, XrefRangeEnd = 77271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.FrameBlendingFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000853C8 File Offset: 0x000835C8
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77275, XrefRangeEnd = 77279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00085404 File Offset: 0x00083604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77279, XrefRangeEnd = 77281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0008543C File Offset: 0x0008363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77281, XrefRangeEnd = 77283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00085470 File Offset: 0x00083670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77283, RefRangeEnd = 77284, XrefRangeStart = 77283, XrefRangeEnd = 77283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000854AC File Offset: 0x000836AC
		[CallerCount(0)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000854E8 File Offset: 0x000836E8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77284, RefRangeEnd = 77293, XrefRangeStart = 77284, XrefRangeEnd = 77284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0008551C File Offset: 0x0008371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77293, XrefRangeEnd = 77352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00085560 File Offset: 0x00083760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77352, XrefRangeEnd = 77353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00085594 File Offset: 0x00083794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77353, XrefRangeEnd = 77356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public MotionBlurComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000855D0 File Offset: 0x000837D0
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00005E01 File Offset: 0x00004001
		public unsafe MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.ReconstructionFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00085600 File Offset: 0x00083800
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00005E20 File Offset: 0x00004020
		public unsafe MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.FrameBlendingFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00085630 File Offset: 0x00083830
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00005E3F File Offset: 0x0000403F
		public unsafe bool m_FirstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame)) = value;
			}
		}

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_m_ReconstructionFilter;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameBlendingFilter;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstFrame;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D2 RID: 2002
		public static class Uniforms : Object
		{
			// Token: 0x0600BBA0 RID: 48032 RVA: 0x002E5F7C File Offset: 0x002E417C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr);
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_VelocityScale");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_MaxBlurRadius");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_RcpMaxBlurRadius");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_VelocityTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_MainTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile2RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile4RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile8RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileMaxOffs");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileMaxLoop");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileVRT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_NeighborMaxTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_LoopCount");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TempRT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4Weight");
			}

			// Token: 0x0600BBA1 RID: 48033 RVA: 0x0005BC97 File Offset: 0x00059E97
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A0B RID: 14859
			// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x002E61B0 File Offset: 0x002E43B0
			// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x0005BCA0 File Offset: 0x00059EA0
			public unsafe static int _VelocityScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale, (void*)(&value));
				}
			}

			// Token: 0x17003A0C RID: 14860
			// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x002E61CC File Offset: 0x002E43CC
			// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x0005BCAE File Offset: 0x00059EAE
			public unsafe static int _MaxBlurRadius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius, (void*)(&value));
				}
			}

			// Token: 0x17003A0D RID: 14861
			// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x002E61E8 File Offset: 0x002E43E8
			// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x0005BCBC File Offset: 0x00059EBC
			public unsafe static int _RcpMaxBlurRadius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius, (void*)(&value));
				}
			}

			// Token: 0x17003A0E RID: 14862
			// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x002E6204 File Offset: 0x002E4404
			// (set) Token: 0x0600BBA9 RID: 48041 RVA: 0x0005BCCA File Offset: 0x00059ECA
			public unsafe static int _VelocityTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex, (void*)(&value));
				}
			}

			// Token: 0x17003A0F RID: 14863
			// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x002E6220 File Offset: 0x002E4420
			// (set) Token: 0x0600BBAB RID: 48043 RVA: 0x0005BCD8 File Offset: 0x00059ED8
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x17003A10 RID: 14864
			// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x002E623C File Offset: 0x002E443C
			// (set) Token: 0x0600BBAD RID: 48045 RVA: 0x0005BCE6 File Offset: 0x00059EE6
			public unsafe static int _Tile2RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT, (void*)(&value));
				}
			}

			// Token: 0x17003A11 RID: 14865
			// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x002E6258 File Offset: 0x002E4458
			// (set) Token: 0x0600BBAF RID: 48047 RVA: 0x0005BCF4 File Offset: 0x00059EF4
			public unsafe static int _Tile4RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT, (void*)(&value));
				}
			}

			// Token: 0x17003A12 RID: 14866
			// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x002E6274 File Offset: 0x002E4474
			// (set) Token: 0x0600BBB1 RID: 48049 RVA: 0x0005BD02 File Offset: 0x00059F02
			public unsafe static int _Tile8RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT, (void*)(&value));
				}
			}

			// Token: 0x17003A13 RID: 14867
			// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x002E6290 File Offset: 0x002E4490
			// (set) Token: 0x0600BBB3 RID: 48051 RVA: 0x0005BD10 File Offset: 0x00059F10
			public unsafe static int _TileMaxOffs
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs, (void*)(&value));
				}
			}

			// Token: 0x17003A14 RID: 14868
			// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x002E62AC File Offset: 0x002E44AC
			// (set) Token: 0x0600BBB5 RID: 48053 RVA: 0x0005BD1E File Offset: 0x00059F1E
			public unsafe static int _TileMaxLoop
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop, (void*)(&value));
				}
			}

			// Token: 0x17003A15 RID: 14869
			// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x002E62C8 File Offset: 0x002E44C8
			// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x0005BD2C File Offset: 0x00059F2C
			public unsafe static int _TileVRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT, (void*)(&value));
				}
			}

			// Token: 0x17003A16 RID: 14870
			// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x002E62E4 File Offset: 0x002E44E4
			// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x0005BD3A File Offset: 0x00059F3A
			public unsafe static int _NeighborMaxTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex, (void*)(&value));
				}
			}

			// Token: 0x17003A17 RID: 14871
			// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x002E6300 File Offset: 0x002E4500
			// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x0005BD48 File Offset: 0x00059F48
			public unsafe static int _LoopCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount, (void*)(&value));
				}
			}

			// Token: 0x17003A18 RID: 14872
			// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x002E631C File Offset: 0x002E451C
			// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x0005BD56 File Offset: 0x00059F56
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x17003A19 RID: 14873
			// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x002E6338 File Offset: 0x002E4538
			// (set) Token: 0x0600BBBF RID: 48063 RVA: 0x0005BD64 File Offset: 0x00059F64
			public unsafe static int _History1LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1A RID: 14874
			// (get) Token: 0x0600BBC0 RID: 48064 RVA: 0x002E6354 File Offset: 0x002E4554
			// (set) Token: 0x0600BBC1 RID: 48065 RVA: 0x0005BD72 File Offset: 0x00059F72
			public unsafe static int _History2LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1B RID: 14875
			// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x002E6370 File Offset: 0x002E4570
			// (set) Token: 0x0600BBC3 RID: 48067 RVA: 0x0005BD80 File Offset: 0x00059F80
			public unsafe static int _History3LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1C RID: 14876
			// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x002E638C File Offset: 0x002E458C
			// (set) Token: 0x0600BBC5 RID: 48069 RVA: 0x0005BD8E File Offset: 0x00059F8E
			public unsafe static int _History4LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1D RID: 14877
			// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x002E63A8 File Offset: 0x002E45A8
			// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x0005BD9C File Offset: 0x00059F9C
			public unsafe static int _History1ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1E RID: 14878
			// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x002E63C4 File Offset: 0x002E45C4
			// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x0005BDAA File Offset: 0x00059FAA
			public unsafe static int _History2ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1F RID: 14879
			// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x002E63E0 File Offset: 0x002E45E0
			// (set) Token: 0x0600BBCB RID: 48075 RVA: 0x0005BDB8 File Offset: 0x00059FB8
			public unsafe static int _History3ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A20 RID: 14880
			// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x002E63FC File Offset: 0x002E45FC
			// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x0005BDC6 File Offset: 0x00059FC6
			public unsafe static int _History4ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A21 RID: 14881
			// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x002E6418 File Offset: 0x002E4618
			// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x0005BDD4 File Offset: 0x00059FD4
			public unsafe static int _History1Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A22 RID: 14882
			// (get) Token: 0x0600BBD0 RID: 48080 RVA: 0x002E6434 File Offset: 0x002E4634
			// (set) Token: 0x0600BBD1 RID: 48081 RVA: 0x0005BDE2 File Offset: 0x00059FE2
			public unsafe static int _History2Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A23 RID: 14883
			// (get) Token: 0x0600BBD2 RID: 48082 RVA: 0x002E6450 File Offset: 0x002E4650
			// (set) Token: 0x0600BBD3 RID: 48083 RVA: 0x0005BDF0 File Offset: 0x00059FF0
			public unsafe static int _History3Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A24 RID: 14884
			// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x002E646C File Offset: 0x002E466C
			// (set) Token: 0x0600BBD5 RID: 48085 RVA: 0x0005BDFE File Offset: 0x00059FFE
			public unsafe static int _History4Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight, (void*)(&value));
				}
			}

			// Token: 0x04007E68 RID: 32360
			private static readonly IntPtr NativeFieldInfoPtr__VelocityScale;

			// Token: 0x04007E69 RID: 32361
			private static readonly IntPtr NativeFieldInfoPtr__MaxBlurRadius;

			// Token: 0x04007E6A RID: 32362
			private static readonly IntPtr NativeFieldInfoPtr__RcpMaxBlurRadius;

			// Token: 0x04007E6B RID: 32363
			private static readonly IntPtr NativeFieldInfoPtr__VelocityTex;

			// Token: 0x04007E6C RID: 32364
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E6D RID: 32365
			private static readonly IntPtr NativeFieldInfoPtr__Tile2RT;

			// Token: 0x04007E6E RID: 32366
			private static readonly IntPtr NativeFieldInfoPtr__Tile4RT;

			// Token: 0x04007E6F RID: 32367
			private static readonly IntPtr NativeFieldInfoPtr__Tile8RT;

			// Token: 0x04007E70 RID: 32368
			private static readonly IntPtr NativeFieldInfoPtr__TileMaxOffs;

			// Token: 0x04007E71 RID: 32369
			private static readonly IntPtr NativeFieldInfoPtr__TileMaxLoop;

			// Token: 0x04007E72 RID: 32370
			private static readonly IntPtr NativeFieldInfoPtr__TileVRT;

			// Token: 0x04007E73 RID: 32371
			private static readonly IntPtr NativeFieldInfoPtr__NeighborMaxTex;

			// Token: 0x04007E74 RID: 32372
			private static readonly IntPtr NativeFieldInfoPtr__LoopCount;

			// Token: 0x04007E75 RID: 32373
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;

			// Token: 0x04007E76 RID: 32374
			private static readonly IntPtr NativeFieldInfoPtr__History1LumaTex;

			// Token: 0x04007E77 RID: 32375
			private static readonly IntPtr NativeFieldInfoPtr__History2LumaTex;

			// Token: 0x04007E78 RID: 32376
			private static readonly IntPtr NativeFieldInfoPtr__History3LumaTex;

			// Token: 0x04007E79 RID: 32377
			private static readonly IntPtr NativeFieldInfoPtr__History4LumaTex;

			// Token: 0x04007E7A RID: 32378
			private static readonly IntPtr NativeFieldInfoPtr__History1ChromaTex;

			// Token: 0x04007E7B RID: 32379
			private static readonly IntPtr NativeFieldInfoPtr__History2ChromaTex;

			// Token: 0x04007E7C RID: 32380
			private static readonly IntPtr NativeFieldInfoPtr__History3ChromaTex;

			// Token: 0x04007E7D RID: 32381
			private static readonly IntPtr NativeFieldInfoPtr__History4ChromaTex;

			// Token: 0x04007E7E RID: 32382
			private static readonly IntPtr NativeFieldInfoPtr__History1Weight;

			// Token: 0x04007E7F RID: 32383
			private static readonly IntPtr NativeFieldInfoPtr__History2Weight;

			// Token: 0x04007E80 RID: 32384
			private static readonly IntPtr NativeFieldInfoPtr__History3Weight;

			// Token: 0x04007E81 RID: 32385
			private static readonly IntPtr NativeFieldInfoPtr__History4Weight;
		}

		// Token: 0x020007D3 RID: 2003
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04007E83 RID: 32387
			VelocitySetup,
			// Token: 0x04007E84 RID: 32388
			TileMax1,
			// Token: 0x04007E85 RID: 32389
			TileMax2,
			// Token: 0x04007E86 RID: 32390
			TileMaxV,
			// Token: 0x04007E87 RID: 32391
			NeighborMax,
			// Token: 0x04007E88 RID: 32392
			Reconstruction,
			// Token: 0x04007E89 RID: 32393
			FrameCompression,
			// Token: 0x04007E8A RID: 32394
			FrameBlendingChroma,
			// Token: 0x04007E8B RID: 32395
			FrameBlendingRaw
		}

		// Token: 0x020007D4 RID: 2004
		public class ReconstructionFilter : Object
		{
			// Token: 0x0600BBD6 RID: 48086 RVA: 0x002E6488 File Offset: 0x002E4688
			// Note: this type is marked as 'beforefieldinit'.
			static ReconstructionFilter()
			{
				Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "ReconstructionFilter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr);
				MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, "m_VectorRTFormat");
				MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, "m_PackedRTFormat");
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663988);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663989);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_IsSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663990);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663991);
			}

			// Token: 0x0600BBD7 RID: 48087 RVA: 0x002E652C File Offset: 0x002E472C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76993, XrefRangeEnd = 76995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReconstructionFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBD8 RID: 48088 RVA: 0x002E6568 File Offset: 0x002E4768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76995, XrefRangeEnd = 76996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckTextureFormatSupport()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBD9 RID: 48089 RVA: 0x002E659C File Offset: 0x002E479C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76996, XrefRangeEnd = 76997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsSupported()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_IsSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBDA RID: 48090 RVA: 0x002E65D8 File Offset: 0x002E47D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 77082, RefRangeEnd = 77084, XrefRangeStart = 76997, XrefRangeEnd = 77082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &settings;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBDB RID: 48091 RVA: 0x0005BE0C File Offset: 0x0005A00C
			public ReconstructionFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A25 RID: 14885
			// (get) Token: 0x0600BBDC RID: 48092 RVA: 0x002E666C File Offset: 0x002E486C
			// (set) Token: 0x0600BBDD RID: 48093 RVA: 0x0005BE15 File Offset: 0x0005A015
			public unsafe RenderTextureFormat m_VectorRTFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat)) = value;
				}
			}

			// Token: 0x17003A26 RID: 14886
			// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x002E6694 File Offset: 0x002E4894
			// (set) Token: 0x0600BBDF RID: 48095 RVA: 0x0005BE30 File Offset: 0x0005A030
			public unsafe RenderTextureFormat m_PackedRTFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat)) = value;
				}
			}

			// Token: 0x04007E8C RID: 32396
			private static readonly IntPtr NativeFieldInfoPtr_m_VectorRTFormat;

			// Token: 0x04007E8D RID: 32397
			private static readonly IntPtr NativeFieldInfoPtr_m_PackedRTFormat;

			// Token: 0x04007E8E RID: 32398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007E8F RID: 32399
			private static readonly IntPtr NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0;

			// Token: 0x04007E90 RID: 32400
			private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Public_Boolean_0;

			// Token: 0x04007E91 RID: 32401
			private static readonly IntPtr NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0;
		}

		// Token: 0x020007D5 RID: 2005
		public class FrameBlendingFilter : Object
		{
			// Token: 0x0600BBE0 RID: 48096 RVA: 0x002E66BC File Offset: 0x002E48BC
			// Note: this type is marked as 'beforefieldinit'.
			static FrameBlendingFilter()
			{
				Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "FrameBlendingFilter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr);
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_UseCompression");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_RawTextureFormat");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_FrameList");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_LastFrameCount");
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663992);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663993);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663994);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663995);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663996);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663997);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663998);
			}

			// Token: 0x0600BBE1 RID: 48097 RVA: 0x002E67C4 File Offset: 0x002E49C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77145, XrefRangeEnd = 77163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FrameBlendingFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE2 RID: 48098 RVA: 0x002E6800 File Offset: 0x002E4A00
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77175, RefRangeEnd = 77178, XrefRangeStart = 77163, XrefRangeEnd = 77175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE3 RID: 48099 RVA: 0x002E6834 File Offset: 0x002E4A34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77182, RefRangeEnd = 77183, XrefRangeStart = 77178, XrefRangeEnd = 77182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE4 RID: 48100 RVA: 0x002E68B4 File Offset: 0x002E4AB4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 77230, RefRangeEnd = 77232, XrefRangeStart = 77183, XrefRangeEnd = 77230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBE5 RID: 48101 RVA: 0x002E6934 File Offset: 0x002E4B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77232, XrefRangeEnd = 77233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool CheckSupportCompression()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBE6 RID: 48102 RVA: 0x002E6964 File Offset: 0x002E4B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77233, XrefRangeEnd = 77241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBE7 RID: 48103 RVA: 0x002E6994 File Offset: 0x002E4B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77241, XrefRangeEnd = 77242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref offset;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MotionBlurComponent.FrameBlendingFilter.Frame(pointer);
			}

			// Token: 0x0600BBE8 RID: 48104 RVA: 0x0005BE4B File Offset: 0x0005A04B
			public FrameBlendingFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A27 RID: 14887
			// (get) Token: 0x0600BBE9 RID: 48105 RVA: 0x002E69D8 File Offset: 0x002E4BD8
			// (set) Token: 0x0600BBEA RID: 48106 RVA: 0x0005BE54 File Offset: 0x0005A054
			public unsafe bool m_UseCompression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression)) = value;
				}
			}

			// Token: 0x17003A28 RID: 14888
			// (get) Token: 0x0600BBEB RID: 48107 RVA: 0x002E6A00 File Offset: 0x002E4C00
			// (set) Token: 0x0600BBEC RID: 48108 RVA: 0x0005BE6F File Offset: 0x0005A06F
			public unsafe RenderTextureFormat m_RawTextureFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat)) = value;
				}
			}

			// Token: 0x17003A29 RID: 14889
			// (get) Token: 0x0600BBED RID: 48109 RVA: 0x002E6A28 File Offset: 0x002E4C28
			// (set) Token: 0x0600BBEE RID: 48110 RVA: 0x0005BE8A File Offset: 0x0005A08A
			public unsafe Il2CppReferenceArray<MotionBlurComponent.FrameBlendingFilter.Frame> m_FrameList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MotionBlurComponent.FrameBlendingFilter.Frame>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A2A RID: 14890
			// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x002E6A58 File Offset: 0x002E4C58
			// (set) Token: 0x0600BBF0 RID: 48112 RVA: 0x0005BEA9 File Offset: 0x0005A0A9
			public unsafe int m_LastFrameCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount)) = value;
				}
			}

			// Token: 0x04007E92 RID: 32402
			private static readonly IntPtr NativeFieldInfoPtr_m_UseCompression;

			// Token: 0x04007E93 RID: 32403
			private static readonly IntPtr NativeFieldInfoPtr_m_RawTextureFormat;

			// Token: 0x04007E94 RID: 32404
			private static readonly IntPtr NativeFieldInfoPtr_m_FrameList;

			// Token: 0x04007E95 RID: 32405
			private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameCount;

			// Token: 0x04007E96 RID: 32406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007E97 RID: 32407
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

			// Token: 0x04007E98 RID: 32408
			private static readonly IntPtr NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0;

			// Token: 0x04007E99 RID: 32409
			private static readonly IntPtr NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0;

			// Token: 0x04007E9A RID: 32410
			private static readonly IntPtr NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0;

			// Token: 0x04007E9B RID: 32411
			private static readonly IntPtr NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0;

			// Token: 0x04007E9C RID: 32412
			private static readonly IntPtr NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0;

			// Token: 0x02000C1E RID: 3102
			public sealed class Frame : ValueType
			{
				// Token: 0x0600E0B8 RID: 57528 RVA: 0x0034E178 File Offset: 0x0034C378
				// Note: this type is marked as 'beforefieldinit'.
				static Frame()
				{
					Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "Frame");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "lumaTexture");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "chromaTexture");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "m_Time");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "m_MRT");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100663999);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664000);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664001);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664002);
				}

				// Token: 0x0600E0B9 RID: 57529 RVA: 0x0034E244 File Offset: 0x0034C444
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 77089, RefRangeEnd = 77093, XrefRangeStart = 77084, XrefRangeEnd = 77089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float CalculateWeight(float strength, float currentTime)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref strength;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E0BA RID: 57530 RVA: 0x0034E2A0 File Offset: 0x0034C4A0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 77104, RefRangeEnd = 77106, XrefRangeStart = 77093, XrefRangeEnd = 77104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Release()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0BB RID: 57531 RVA: 0x0034E2D8 File Offset: 0x0034C4D8
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77131, RefRangeEnd = 77132, XrefRangeStart = 77106, XrefRangeEnd = 77131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0BC RID: 57532 RVA: 0x0034E35C File Offset: 0x0034C55C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77144, RefRangeEnd = 77145, XrefRangeStart = 77132, XrefRangeEnd = 77144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0BD RID: 57533 RVA: 0x0006D8F8 File Offset: 0x0006BAF8
				public Frame(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600E0BE RID: 57534 RVA: 0x0006D901 File Offset: 0x0006BB01
				public Frame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr))
				{
				}

				// Token: 0x17004596 RID: 17814
				// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x0034E3DC File Offset: 0x0034C5DC
				// (set) Token: 0x0600E0C0 RID: 57536 RVA: 0x0006D913 File Offset: 0x0006BB13
				public unsafe RenderTexture lumaTexture
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004597 RID: 17815
				// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x0034E40C File Offset: 0x0034C60C
				// (set) Token: 0x0600E0C2 RID: 57538 RVA: 0x0006D932 File Offset: 0x0006BB32
				public unsafe RenderTexture chromaTexture
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004598 RID: 17816
				// (get) Token: 0x0600E0C3 RID: 57539 RVA: 0x0034E43C File Offset: 0x0034C63C
				// (set) Token: 0x0600E0C4 RID: 57540 RVA: 0x0006D951 File Offset: 0x0006BB51
				public unsafe float m_Time
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time)) = value;
					}
				}

				// Token: 0x17004599 RID: 17817
				// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x0034E464 File Offset: 0x0034C664
				// (set) Token: 0x0600E0C6 RID: 57542 RVA: 0x0006D96C File Offset: 0x0006BB6C
				public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009674 RID: 38516
				private static readonly IntPtr NativeFieldInfoPtr_lumaTexture;

				// Token: 0x04009675 RID: 38517
				private static readonly IntPtr NativeFieldInfoPtr_chromaTexture;

				// Token: 0x04009676 RID: 38518
				private static readonly IntPtr NativeFieldInfoPtr_m_Time;

				// Token: 0x04009677 RID: 38519
				private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

				// Token: 0x04009678 RID: 38520
				private static readonly IntPtr NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0;

				// Token: 0x04009679 RID: 38521
				private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

				// Token: 0x0400967A RID: 38522
				private static readonly IntPtr NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0;

				// Token: 0x0400967B RID: 38523
				private static readonly IntPtr NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0;
			}
		}
	}
}
