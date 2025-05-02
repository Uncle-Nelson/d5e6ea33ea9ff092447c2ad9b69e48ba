using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005C RID: 92
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x06000722 RID: 1826 RVA: 0x00086018 File Offset: 0x00084218
		// Note: this type is marked as 'beforefieldinit'.
		static UserLutComponent()
		{
			Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "UserLutComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr);
			UserLutComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664025);
			UserLutComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664026);
			UserLutComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664027);
			UserLutComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664028);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00086098 File Offset: 0x00084298
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77689, XrefRangeEnd = 77696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000860D4 File Offset: 0x000842D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77696, XrefRangeEnd = 77707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00086118 File Offset: 0x00084318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77707, XrefRangeEnd = 77714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0008614C File Offset: 0x0008434C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77714, XrefRangeEnd = 77717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserLutComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00005FA6 File Offset: 0x000041A6
		public UserLutComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D9 RID: 2009
		public static class Uniforms : Object
		{
			// Token: 0x0600BC45 RID: 48197 RVA: 0x002E7258 File Offset: 0x002E5458
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr);
				UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr, "_UserLut");
				UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr, "_UserLut_Params");
			}

			// Token: 0x0600BC46 RID: 48198 RVA: 0x0005C106 File Offset: 0x0005A306
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A53 RID: 14931
			// (get) Token: 0x0600BC47 RID: 48199 RVA: 0x002E72AC File Offset: 0x002E54AC
			// (set) Token: 0x0600BC48 RID: 48200 RVA: 0x0005C10F File Offset: 0x0005A30F
			public unsafe static int _UserLut
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut, (void*)(&value));
				}
			}

			// Token: 0x17003A54 RID: 14932
			// (get) Token: 0x0600BC49 RID: 48201 RVA: 0x002E72C8 File Offset: 0x002E54C8
			// (set) Token: 0x0600BC4A RID: 48202 RVA: 0x0005C11D File Offset: 0x0005A31D
			public unsafe static int _UserLut_Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params, (void*)(&value));
				}
			}

			// Token: 0x04007ECF RID: 32463
			private static readonly IntPtr NativeFieldInfoPtr__UserLut;

			// Token: 0x04007ED0 RID: 32464
			private static readonly IntPtr NativeFieldInfoPtr__UserLut_Params;
		}
	}
}
