using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000054 RID: 84
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x00084514 File Offset: 0x00082714
		// Note: this type is marked as 'beforefieldinit'.
		static DitheringComponent()
		{
			Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DitheringComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr);
			DitheringComponent.NativeFieldInfoPtr_noiseTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "noiseTextures");
			DitheringComponent.NativeFieldInfoPtr_textureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "textureIndex");
			DitheringComponent.NativeFieldInfoPtr_k_TextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "k_TextureCount");
			DitheringComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663945);
			DitheringComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663946);
			DitheringComponent.NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663947);
			DitheringComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663948);
			DitheringComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663949);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000845E4 File Offset: 0x000827E4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76630, XrefRangeEnd = 76631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00084620 File Offset: 0x00082820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76631, XrefRangeEnd = 76632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00084654 File Offset: 0x00082854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76632, XrefRangeEnd = 76644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNoiseTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00084688 File Offset: 0x00082888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76644, XrefRangeEnd = 76670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000846CC File Offset: 0x000828CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76673, RefRangeEnd = 76674, XrefRangeStart = 76670, XrefRangeEnd = 76673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DitheringComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00005C45 File Offset: 0x00003E45
		public DitheringComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00084708 File Offset: 0x00082908
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00005C4E File Offset: 0x00003E4E
		public unsafe Il2CppReferenceArray<Texture2D> noiseTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_noiseTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_noiseTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00084738 File Offset: 0x00082938
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00005C6D File Offset: 0x00003E6D
		public unsafe int textureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_textureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_textureIndex)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00084760 File Offset: 0x00082960
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00005C88 File Offset: 0x00003E88
		public unsafe static int k_TextureCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DitheringComponent.NativeFieldInfoPtr_k_TextureCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DitheringComponent.NativeFieldInfoPtr_k_TextureCount, (void*)(&value));
			}
		}

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_noiseTextures;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_textureIndex;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_k_TextureCount;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CD RID: 1997
		public static class Uniforms : Object
		{
			// Token: 0x0600BB70 RID: 47984 RVA: 0x002E5B10 File Offset: 0x002E3D10
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr);
				DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr, "_DitheringTex");
				DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr, "_DitheringCoords");
			}

			// Token: 0x0600BB71 RID: 47985 RVA: 0x0005BB60 File Offset: 0x00059D60
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039F8 RID: 14840
			// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x002E5B64 File Offset: 0x002E3D64
			// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x0005BB69 File Offset: 0x00059D69
			public unsafe static int _DitheringTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex, (void*)(&value));
				}
			}

			// Token: 0x170039F9 RID: 14841
			// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x002E5B80 File Offset: 0x002E3D80
			// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x0005BB77 File Offset: 0x00059D77
			public unsafe static int _DitheringCoords
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords, (void*)(&value));
				}
			}

			// Token: 0x04007E55 RID: 32341
			private static readonly IntPtr NativeFieldInfoPtr__DitheringTex;

			// Token: 0x04007E56 RID: 32342
			private static readonly IntPtr NativeFieldInfoPtr__DitheringCoords;
		}
	}
}
