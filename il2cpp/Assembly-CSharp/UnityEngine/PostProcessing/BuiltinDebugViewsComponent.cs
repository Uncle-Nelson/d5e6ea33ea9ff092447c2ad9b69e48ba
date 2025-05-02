using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000050 RID: 80
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x0008318C File Offset: 0x0008138C
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinDebugViewsComponent()
		{
			Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BuiltinDebugViewsComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr);
			BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "k_ShaderString");
			BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "m_Arrows");
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663885);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663886);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663887);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663888);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663889);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663890);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663891);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663892);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_PrepareArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663893);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663894);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663895);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000832C0 File Offset: 0x000814C0
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76079, XrefRangeEnd = 76083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000832FC File Offset: 0x000814FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76083, XrefRangeEnd = 76084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00083338 File Offset: 0x00081538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76084, XrefRangeEnd = 76085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00083374 File Offset: 0x00081574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76085, XrefRangeEnd = 76087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000833AC File Offset: 0x000815AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76087, XrefRangeEnd = 76116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000833F0 File Offset: 0x000815F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76116, XrefRangeEnd = 76127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepthPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00083434 File Offset: 0x00081634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76127, XrefRangeEnd = 76132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepthNormalsPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00083478 File Offset: 0x00081678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76202, RefRangeEnd = 76203, XrefRangeStart = 76132, XrefRangeEnd = 76202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MotionVectorsPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000834BC File Offset: 0x000816BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76203, XrefRangeEnd = 76214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareArrows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_PrepareArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000834F0 File Offset: 0x000816F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76214, XrefRangeEnd = 76217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00083524 File Offset: 0x00081724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76220, RefRangeEnd = 76221, XrefRangeStart = 76217, XrefRangeEnd = 76220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinDebugViewsComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00005B2A File Offset: 0x00003D2A
		public BuiltinDebugViewsComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00083560 File Offset: 0x00081760
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005B33 File Offset: 0x00003D33
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00083580 File Offset: 0x00081780
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005B45 File Offset: 0x00003D45
		public unsafe BuiltinDebugViewsComponent.ArrowArray m_Arrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuiltinDebugViewsComponent.ArrowArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_m_Arrows;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_PrepareArrows_Private_Void_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C7 RID: 1991
		public static class Uniforms : Object
		{
			// Token: 0x0600BB07 RID: 47879 RVA: 0x002E4F0C File Offset: 0x002E310C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr);
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_DepthScale");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_TempRT");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Opacity");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_MainTex");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_TempRT2");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Amplitude");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Scale");
			}

			// Token: 0x0600BB08 RID: 47880 RVA: 0x0005B8AE File Offset: 0x00059AAE
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039CA RID: 14794
			// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x002E4FC4 File Offset: 0x002E31C4
			// (set) Token: 0x0600BB0A RID: 47882 RVA: 0x0005B8B7 File Offset: 0x00059AB7
			public unsafe static int _DepthScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale, (void*)(&value));
				}
			}

			// Token: 0x170039CB RID: 14795
			// (get) Token: 0x0600BB0B RID: 47883 RVA: 0x002E4FE0 File Offset: 0x002E31E0
			// (set) Token: 0x0600BB0C RID: 47884 RVA: 0x0005B8C5 File Offset: 0x00059AC5
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x170039CC RID: 14796
			// (get) Token: 0x0600BB0D RID: 47885 RVA: 0x002E4FFC File Offset: 0x002E31FC
			// (set) Token: 0x0600BB0E RID: 47886 RVA: 0x0005B8D3 File Offset: 0x00059AD3
			public unsafe static int _Opacity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity, (void*)(&value));
				}
			}

			// Token: 0x170039CD RID: 14797
			// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x002E5018 File Offset: 0x002E3218
			// (set) Token: 0x0600BB10 RID: 47888 RVA: 0x0005B8E1 File Offset: 0x00059AE1
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039CE RID: 14798
			// (get) Token: 0x0600BB11 RID: 47889 RVA: 0x002E5034 File Offset: 0x002E3234
			// (set) Token: 0x0600BB12 RID: 47890 RVA: 0x0005B8EF File Offset: 0x00059AEF
			public unsafe static int _TempRT2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2, (void*)(&value));
				}
			}

			// Token: 0x170039CF RID: 14799
			// (get) Token: 0x0600BB13 RID: 47891 RVA: 0x002E5050 File Offset: 0x002E3250
			// (set) Token: 0x0600BB14 RID: 47892 RVA: 0x0005B8FD File Offset: 0x00059AFD
			public unsafe static int _Amplitude
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude, (void*)(&value));
				}
			}

			// Token: 0x170039D0 RID: 14800
			// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x002E506C File Offset: 0x002E326C
			// (set) Token: 0x0600BB16 RID: 47894 RVA: 0x0005B90B File Offset: 0x00059B0B
			public unsafe static int _Scale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale, (void*)(&value));
				}
			}

			// Token: 0x04007E1B RID: 32283
			private static readonly IntPtr NativeFieldInfoPtr__DepthScale;

			// Token: 0x04007E1C RID: 32284
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;

			// Token: 0x04007E1D RID: 32285
			private static readonly IntPtr NativeFieldInfoPtr__Opacity;

			// Token: 0x04007E1E RID: 32286
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E1F RID: 32287
			private static readonly IntPtr NativeFieldInfoPtr__TempRT2;

			// Token: 0x04007E20 RID: 32288
			private static readonly IntPtr NativeFieldInfoPtr__Amplitude;

			// Token: 0x04007E21 RID: 32289
			private static readonly IntPtr NativeFieldInfoPtr__Scale;
		}

		// Token: 0x020007C8 RID: 1992
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04007E23 RID: 32291
			Depth,
			// Token: 0x04007E24 RID: 32292
			Normals,
			// Token: 0x04007E25 RID: 32293
			MovecOpacity,
			// Token: 0x04007E26 RID: 32294
			MovecImaging,
			// Token: 0x04007E27 RID: 32295
			MovecArrows
		}

		// Token: 0x020007C9 RID: 1993
		public class ArrowArray : Object
		{
			// Token: 0x0600BB17 RID: 47895 RVA: 0x002E5088 File Offset: 0x002E3288
			// Note: this type is marked as 'beforefieldinit'.
			static ArrowArray()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "ArrowArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr);
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<mesh>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<columnCount>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<rowCount>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663897);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663898);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663899);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663900);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663901);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663902);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663903);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663904);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663905);
			}

			// Token: 0x170039D4 RID: 14804
			// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x002E51A4 File Offset: 0x002E33A4
			// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x002E51E4 File Offset: 0x002E33E4
			public unsafe Mesh mesh
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170039D5 RID: 14805
			// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x002E5228 File Offset: 0x002E3428
			// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x002E5264 File Offset: 0x002E3464
			public unsafe int columnCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29997, RefRangeEnd = 29999, XrefRangeStart = 29997, XrefRangeEnd = 29999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170039D6 RID: 14806
			// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x002E52A4 File Offset: 0x002E34A4
			// (set) Token: 0x0600BB1D RID: 47901 RVA: 0x002E52E0 File Offset: 0x002E34E0
			public unsafe int rowCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 41641, RefRangeEnd = 41642, XrefRangeStart = 41641, XrefRangeEnd = 41642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BB1E RID: 47902 RVA: 0x002E5320 File Offset: 0x002E3520
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76075, RefRangeEnd = 76077, XrefRangeStart = 76041, XrefRangeEnd = 76075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BuildMesh(int columns, int rows)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref columns;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rows;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB1F RID: 47903 RVA: 0x002E536C File Offset: 0x002E356C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76077, XrefRangeEnd = 76079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB20 RID: 47904 RVA: 0x002E53A0 File Offset: 0x002E35A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrowArray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB21 RID: 47905 RVA: 0x0005B919 File Offset: 0x00059B19
			public ArrowArray(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039D1 RID: 14801
			// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x002E53DC File Offset: 0x002E35DC
			// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x0005B922 File Offset: 0x00059B22
			public unsafe Mesh _mesh_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039D2 RID: 14802
			// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x002E540C File Offset: 0x002E360C
			// (set) Token: 0x0600BB25 RID: 47909 RVA: 0x0005B941 File Offset: 0x00059B41
			public unsafe int _columnCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField)) = value;
				}
			}

			// Token: 0x170039D3 RID: 14803
			// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x002E5434 File Offset: 0x002E3634
			// (set) Token: 0x0600BB27 RID: 47911 RVA: 0x0005B95C File Offset: 0x00059B5C
			public unsafe int _rowCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField)) = value;
				}
			}

			// Token: 0x04007E28 RID: 32296
			private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

			// Token: 0x04007E29 RID: 32297
			private static readonly IntPtr NativeFieldInfoPtr__columnCount_k__BackingField;

			// Token: 0x04007E2A RID: 32298
			private static readonly IntPtr NativeFieldInfoPtr__rowCount_k__BackingField;

			// Token: 0x04007E2B RID: 32299
			private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

			// Token: 0x04007E2C RID: 32300
			private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

			// Token: 0x04007E2D RID: 32301
			private static readonly IntPtr NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0;

			// Token: 0x04007E2E RID: 32302
			private static readonly IntPtr NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0;

			// Token: 0x04007E2F RID: 32303
			private static readonly IntPtr NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0;

			// Token: 0x04007E30 RID: 32304
			private static readonly IntPtr NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0;

			// Token: 0x04007E31 RID: 32305
			private static readonly IntPtr NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0;

			// Token: 0x04007E32 RID: 32306
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x04007E33 RID: 32307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
