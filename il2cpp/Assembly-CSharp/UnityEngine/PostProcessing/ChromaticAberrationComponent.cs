using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000051 RID: 81
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x000835B0 File Offset: 0x000817B0
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberrationComponent()
		{
			Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ChromaticAberrationComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr);
			ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, "m_SpectrumLut");
			ChromaticAberrationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663906);
			ChromaticAberrationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663907);
			ChromaticAberrationComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663908);
			ChromaticAberrationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663909);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00083644 File Offset: 0x00081844
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76221, XrefRangeEnd = 76222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00083680 File Offset: 0x00081880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76222, XrefRangeEnd = 76224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000836B4 File Offset: 0x000818B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76224, XrefRangeEnd = 76261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000836F8 File Offset: 0x000818F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76264, RefRangeEnd = 76265, XrefRangeStart = 76261, XrefRangeEnd = 76264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberrationComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00005B64 File Offset: 0x00003D64
		public ChromaticAberrationComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00083734 File Offset: 0x00081934
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00005B6D File Offset: 0x00003D6D
		public unsafe Texture2D m_SpectrumLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_m_SpectrumLut;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CA RID: 1994
		public static class Uniforms : Object
		{
			// Token: 0x0600BB28 RID: 47912 RVA: 0x002E545C File Offset: 0x002E365C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr);
				ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr, "_ChromaticAberration_Amount");
				ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr, "_ChromaticAberration_Spectrum");
			}

			// Token: 0x0600BB29 RID: 47913 RVA: 0x0005B977 File Offset: 0x00059B77
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039D7 RID: 14807
			// (get) Token: 0x0600BB2A RID: 47914 RVA: 0x002E54B0 File Offset: 0x002E36B0
			// (set) Token: 0x0600BB2B RID: 47915 RVA: 0x0005B980 File Offset: 0x00059B80
			public unsafe static int _ChromaticAberration_Amount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount, (void*)(&value));
				}
			}

			// Token: 0x170039D8 RID: 14808
			// (get) Token: 0x0600BB2C RID: 47916 RVA: 0x002E54CC File Offset: 0x002E36CC
			// (set) Token: 0x0600BB2D RID: 47917 RVA: 0x0005B98E File Offset: 0x00059B8E
			public unsafe static int _ChromaticAberration_Spectrum
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum, (void*)(&value));
				}
			}

			// Token: 0x04007E34 RID: 32308
			private static readonly IntPtr NativeFieldInfoPtr__ChromaticAberration_Amount;

			// Token: 0x04007E35 RID: 32309
			private static readonly IntPtr NativeFieldInfoPtr__ChromaticAberration_Spectrum;
		}
	}
}
