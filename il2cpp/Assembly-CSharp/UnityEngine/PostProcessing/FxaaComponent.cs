using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000057 RID: 87
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00084F14 File Offset: 0x00083114
		// Note: this type is marked as 'beforefieldinit'.
		static FxaaComponent()
		{
			Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FxaaComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr);
			FxaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663967);
			FxaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663968);
			FxaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663969);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00084F80 File Offset: 0x00083180
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76913, XrefRangeEnd = 76914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00084FBC File Offset: 0x000831BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76937, RefRangeEnd = 76938, XrefRangeStart = 76914, XrefRangeEnd = 76937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00085010 File Offset: 0x00083210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76938, XrefRangeEnd = 76941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FxaaComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00005DC7 File Offset: 0x00003FC7
		public FxaaComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D0 RID: 2000
		public static class Uniforms : Object
		{
			// Token: 0x0600BB90 RID: 48016 RVA: 0x002E5E04 File Offset: 0x002E4004
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr);
				FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr, "_QualitySettings");
				FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr, "_ConsoleSettings");
			}

			// Token: 0x0600BB91 RID: 48017 RVA: 0x0005BC31 File Offset: 0x00059E31
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A05 RID: 14853
			// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x002E5E58 File Offset: 0x002E4058
			// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x0005BC3A File Offset: 0x00059E3A
			public unsafe static int _QualitySettings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings, (void*)(&value));
				}
			}

			// Token: 0x17003A06 RID: 14854
			// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x002E5E74 File Offset: 0x002E4074
			// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x0005BC48 File Offset: 0x00059E48
			public unsafe static int _ConsoleSettings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings, (void*)(&value));
				}
			}

			// Token: 0x04007E62 RID: 32354
			private static readonly IntPtr NativeFieldInfoPtr__QualitySettings;

			// Token: 0x04007E63 RID: 32355
			private static readonly IntPtr NativeFieldInfoPtr__ConsoleSettings;
		}
	}
}
