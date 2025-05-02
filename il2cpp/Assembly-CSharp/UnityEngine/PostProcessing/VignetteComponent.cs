using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005D RID: 93
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x00086188 File Offset: 0x00084388
		// Note: this type is marked as 'beforefieldinit'.
		static VignetteComponent()
		{
			Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "VignetteComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr);
			VignetteComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664030);
			VignetteComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664031);
			VignetteComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664032);
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000861F4 File Offset: 0x000843F4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77717, XrefRangeEnd = 77718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00086230 File Offset: 0x00084430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77718, XrefRangeEnd = 77738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00086274 File Offset: 0x00084474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77738, XrefRangeEnd = 77741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VignetteComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00005FAF File Offset: 0x000041AF
		public VignetteComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DA RID: 2010
		public static class Uniforms : Object
		{
			// Token: 0x0600BC4B RID: 48203 RVA: 0x002E72E4 File Offset: 0x002E54E4
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr);
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Color");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Center");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Settings");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Mask");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Opacity");
			}

			// Token: 0x0600BC4C RID: 48204 RVA: 0x0005C12B File Offset: 0x0005A32B
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A55 RID: 14933
			// (get) Token: 0x0600BC4D RID: 48205 RVA: 0x002E7374 File Offset: 0x002E5574
			// (set) Token: 0x0600BC4E RID: 48206 RVA: 0x0005C134 File Offset: 0x0005A334
			public unsafe static int _Vignette_Color
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color, (void*)(&value));
				}
			}

			// Token: 0x17003A56 RID: 14934
			// (get) Token: 0x0600BC4F RID: 48207 RVA: 0x002E7390 File Offset: 0x002E5590
			// (set) Token: 0x0600BC50 RID: 48208 RVA: 0x0005C142 File Offset: 0x0005A342
			public unsafe static int _Vignette_Center
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center, (void*)(&value));
				}
			}

			// Token: 0x17003A57 RID: 14935
			// (get) Token: 0x0600BC51 RID: 48209 RVA: 0x002E73AC File Offset: 0x002E55AC
			// (set) Token: 0x0600BC52 RID: 48210 RVA: 0x0005C150 File Offset: 0x0005A350
			public unsafe static int _Vignette_Settings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings, (void*)(&value));
				}
			}

			// Token: 0x17003A58 RID: 14936
			// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x002E73C8 File Offset: 0x002E55C8
			// (set) Token: 0x0600BC54 RID: 48212 RVA: 0x0005C15E File Offset: 0x0005A35E
			public unsafe static int _Vignette_Mask
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask, (void*)(&value));
				}
			}

			// Token: 0x17003A59 RID: 14937
			// (get) Token: 0x0600BC55 RID: 48213 RVA: 0x002E73E4 File Offset: 0x002E55E4
			// (set) Token: 0x0600BC56 RID: 48214 RVA: 0x0005C16C File Offset: 0x0005A36C
			public unsafe static int _Vignette_Opacity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity, (void*)(&value));
				}
			}

			// Token: 0x04007ED1 RID: 32465
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Color;

			// Token: 0x04007ED2 RID: 32466
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Center;

			// Token: 0x04007ED3 RID: 32467
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Settings;

			// Token: 0x04007ED4 RID: 32468
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Mask;

			// Token: 0x04007ED5 RID: 32469
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Opacity;
		}
	}
}
