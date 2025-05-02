using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004E RID: 78
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		// Token: 0x06000633 RID: 1587 RVA: 0x00082C28 File Offset: 0x00080E28
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionComponent()
		{
			Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AmbientOcclusionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr);
			AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "k_BlitShaderString");
			AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "k_ShaderString");
			AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "m_MRT");
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663872);
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663873);
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663874);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663875);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663876);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663877);
			AmbientOcclusionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663878);
			AmbientOcclusionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663879);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00082D34 File Offset: 0x00080F34
		public unsafe AmbientOcclusionComponent.OcclusionSource occlusionSource
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 75791, RefRangeEnd = 75795, XrefRangeStart = 75789, XrefRangeEnd = 75791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00082D70 File Offset: 0x00080F70
		public unsafe bool ambientOnlySupported
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75798, RefRangeEnd = 75800, XrefRangeStart = 75795, XrefRangeEnd = 75798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00082DAC File Offset: 0x00080FAC
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75800, XrefRangeEnd = 75801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00082DE8 File Offset: 0x00080FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75801, XrefRangeEnd = 75803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00082E24 File Offset: 0x00081024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75803, XrefRangeEnd = 75805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00082E5C File Offset: 0x0008105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75805, XrefRangeEnd = 75807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00082E98 File Offset: 0x00081098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75807, XrefRangeEnd = 75919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00082EDC File Offset: 0x000810DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75930, RefRangeEnd = 75931, XrefRangeStart = 75919, XrefRangeEnd = 75930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00005A89 File Offset: 0x00003C89
		public AmbientOcclusionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00082F18 File Offset: 0x00081118
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00005A92 File Offset: 0x00003C92
		public unsafe static string k_BlitShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00082F38 File Offset: 0x00081138
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00082F58 File Offset: 0x00081158
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005AB6 File Offset: 0x00003CB6
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_k_BlitShaderString;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C4 RID: 1988
		public static class Uniforms : Object
		{
			// Token: 0x0600BADB RID: 47835 RVA: 0x002E4AF4 File Offset: 0x002E2CF4
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr);
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Intensity");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Radius");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_FogParams");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Downsample");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_SampleCount");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture1");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture2");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_MainTex");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_TempRT");
			}

			// Token: 0x0600BADC RID: 47836 RVA: 0x0005B784 File Offset: 0x00059984
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039B6 RID: 14774
			// (get) Token: 0x0600BADD RID: 47837 RVA: 0x002E4BE8 File Offset: 0x002E2DE8
			// (set) Token: 0x0600BADE RID: 47838 RVA: 0x0005B78D File Offset: 0x0005998D
			public unsafe static int _Intensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity, (void*)(&value));
				}
			}

			// Token: 0x170039B7 RID: 14775
			// (get) Token: 0x0600BADF RID: 47839 RVA: 0x002E4C04 File Offset: 0x002E2E04
			// (set) Token: 0x0600BAE0 RID: 47840 RVA: 0x0005B79B File Offset: 0x0005999B
			public unsafe static int _Radius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&value));
				}
			}

			// Token: 0x170039B8 RID: 14776
			// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x002E4C20 File Offset: 0x002E2E20
			// (set) Token: 0x0600BAE2 RID: 47842 RVA: 0x0005B7A9 File Offset: 0x000599A9
			public unsafe static int _FogParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams, (void*)(&value));
				}
			}

			// Token: 0x170039B9 RID: 14777
			// (get) Token: 0x0600BAE3 RID: 47843 RVA: 0x002E4C3C File Offset: 0x002E2E3C
			// (set) Token: 0x0600BAE4 RID: 47844 RVA: 0x0005B7B7 File Offset: 0x000599B7
			public unsafe static int _Downsample
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample, (void*)(&value));
				}
			}

			// Token: 0x170039BA RID: 14778
			// (get) Token: 0x0600BAE5 RID: 47845 RVA: 0x002E4C58 File Offset: 0x002E2E58
			// (set) Token: 0x0600BAE6 RID: 47846 RVA: 0x0005B7C5 File Offset: 0x000599C5
			public unsafe static int _SampleCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount, (void*)(&value));
				}
			}

			// Token: 0x170039BB RID: 14779
			// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002E4C74 File Offset: 0x002E2E74
			// (set) Token: 0x0600BAE8 RID: 47848 RVA: 0x0005B7D3 File Offset: 0x000599D3
			public unsafe static int _OcclusionTexture1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1, (void*)(&value));
				}
			}

			// Token: 0x170039BC RID: 14780
			// (get) Token: 0x0600BAE9 RID: 47849 RVA: 0x002E4C90 File Offset: 0x002E2E90
			// (set) Token: 0x0600BAEA RID: 47850 RVA: 0x0005B7E1 File Offset: 0x000599E1
			public unsafe static int _OcclusionTexture2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2, (void*)(&value));
				}
			}

			// Token: 0x170039BD RID: 14781
			// (get) Token: 0x0600BAEB RID: 47851 RVA: 0x002E4CAC File Offset: 0x002E2EAC
			// (set) Token: 0x0600BAEC RID: 47852 RVA: 0x0005B7EF File Offset: 0x000599EF
			public unsafe static int _OcclusionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture, (void*)(&value));
				}
			}

			// Token: 0x170039BE RID: 14782
			// (get) Token: 0x0600BAED RID: 47853 RVA: 0x002E4CC8 File Offset: 0x002E2EC8
			// (set) Token: 0x0600BAEE RID: 47854 RVA: 0x0005B7FD File Offset: 0x000599FD
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039BF RID: 14783
			// (get) Token: 0x0600BAEF RID: 47855 RVA: 0x002E4CE4 File Offset: 0x002E2EE4
			// (set) Token: 0x0600BAF0 RID: 47856 RVA: 0x0005B80B File Offset: 0x00059A0B
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x04007E03 RID: 32259
			private static readonly IntPtr NativeFieldInfoPtr__Intensity;

			// Token: 0x04007E04 RID: 32260
			private static readonly IntPtr NativeFieldInfoPtr__Radius;

			// Token: 0x04007E05 RID: 32261
			private static readonly IntPtr NativeFieldInfoPtr__FogParams;

			// Token: 0x04007E06 RID: 32262
			private static readonly IntPtr NativeFieldInfoPtr__Downsample;

			// Token: 0x04007E07 RID: 32263
			private static readonly IntPtr NativeFieldInfoPtr__SampleCount;

			// Token: 0x04007E08 RID: 32264
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture1;

			// Token: 0x04007E09 RID: 32265
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture2;

			// Token: 0x04007E0A RID: 32266
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture;

			// Token: 0x04007E0B RID: 32267
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E0C RID: 32268
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;
		}

		// Token: 0x020007C5 RID: 1989
		[OriginalName("Assembly-CSharp.dll", "", "OcclusionSource")]
		public enum OcclusionSource
		{
			// Token: 0x04007E0E RID: 32270
			DepthTexture,
			// Token: 0x04007E0F RID: 32271
			DepthNormalsTexture,
			// Token: 0x04007E10 RID: 32272
			GBuffer
		}
	}
}
