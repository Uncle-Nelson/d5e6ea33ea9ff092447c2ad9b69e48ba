using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000058 RID: 88
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x0008504C File Offset: 0x0008324C
		// Note: this type is marked as 'beforefieldinit'.
		static GrainComponent()
		{
			Il2CppClassPointerStore<GrainComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GrainComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr);
			GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, "m_GrainLookupRT");
			GrainComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663971);
			GrainComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663972);
			GrainComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663973);
			GrainComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663974);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000850E0 File Offset: 0x000832E0
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76941, XrefRangeEnd = 76943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0008511C File Offset: 0x0008331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00085150 File Offset: 0x00083350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76943, XrefRangeEnd = 76990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00085194 File Offset: 0x00083394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76990, XrefRangeEnd = 76993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrainComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public GrainComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000851D0 File Offset: 0x000833D0
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00005DD9 File Offset: 0x00003FD9
		public unsafe RenderTexture m_GrainLookupRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_m_GrainLookupRT;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D1 RID: 2001
		public static class Uniforms : Object
		{
			// Token: 0x0600BB96 RID: 48022 RVA: 0x002E5E90 File Offset: 0x002E4090
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr);
				GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Grain_Params1");
				GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Grain_Params2");
				GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_GrainTex");
				GrainComponent.Uniforms.NativeFieldInfoPtr__Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Phase");
			}

			// Token: 0x0600BB97 RID: 48023 RVA: 0x0005BC56 File Offset: 0x00059E56
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A07 RID: 14855
			// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x002E5F0C File Offset: 0x002E410C
			// (set) Token: 0x0600BB99 RID: 48025 RVA: 0x0005BC5F File Offset: 0x00059E5F
			public unsafe static int _Grain_Params1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1, (void*)(&value));
				}
			}

			// Token: 0x17003A08 RID: 14856
			// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x002E5F28 File Offset: 0x002E4128
			// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x0005BC6D File Offset: 0x00059E6D
			public unsafe static int _Grain_Params2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2, (void*)(&value));
				}
			}

			// Token: 0x17003A09 RID: 14857
			// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x002E5F44 File Offset: 0x002E4144
			// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x0005BC7B File Offset: 0x00059E7B
			public unsafe static int _GrainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex, (void*)(&value));
				}
			}

			// Token: 0x17003A0A RID: 14858
			// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x002E5F60 File Offset: 0x002E4160
			// (set) Token: 0x0600BB9F RID: 48031 RVA: 0x0005BC89 File Offset: 0x00059E89
			public unsafe static int _Phase
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Phase, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Phase, (void*)(&value));
				}
			}

			// Token: 0x04007E64 RID: 32356
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Params1;

			// Token: 0x04007E65 RID: 32357
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Params2;

			// Token: 0x04007E66 RID: 32358
			private static readonly IntPtr NativeFieldInfoPtr__GrainTex;

			// Token: 0x04007E67 RID: 32359
			private static readonly IntPtr NativeFieldInfoPtr__Phase;
		}
	}
}
