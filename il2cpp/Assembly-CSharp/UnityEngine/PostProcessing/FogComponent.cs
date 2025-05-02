using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000056 RID: 86
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00084CCC File Offset: 0x00082ECC
		// Note: this type is marked as 'beforefieldinit'.
		static FogComponent()
		{
			Il2CppClassPointerStore<FogComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FogComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogComponent>.NativeClassPtr);
			FogComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, "k_ShaderString");
			FogComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663960);
			FogComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663961);
			FogComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663962);
			FogComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663963);
			FogComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663964);
			FogComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663965);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00084D88 File Offset: 0x00082F88
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76849, XrefRangeEnd = 76852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00084DC4 File Offset: 0x00082FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76852, XrefRangeEnd = 76854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00084DFC File Offset: 0x00082FFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76505, RefRangeEnd = 76509, XrefRangeStart = 76505, XrefRangeEnd = 76509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00084E38 File Offset: 0x00083038
		[CallerCount(0)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00084E74 File Offset: 0x00083074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76854, XrefRangeEnd = 76910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00084EB8 File Offset: 0x000830B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76910, XrefRangeEnd = 76913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FogComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00005DAC File Offset: 0x00003FAC
		public FogComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00084EF4 File Offset: 0x000830F4
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00005DB5 File Offset: 0x00003FB5
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FogComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FogComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CF RID: 1999
		public static class Uniforms : Object
		{
			// Token: 0x0600BB84 RID: 48004 RVA: 0x002E5CE8 File Offset: 0x002E3EE8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr);
				FogComponent.Uniforms.NativeFieldInfoPtr__FogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_FogColor");
				FogComponent.Uniforms.NativeFieldInfoPtr__Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_Density");
				FogComponent.Uniforms.NativeFieldInfoPtr__Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_Start");
				FogComponent.Uniforms.NativeFieldInfoPtr__End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_End");
				FogComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_TempRT");
			}

			// Token: 0x0600BB85 RID: 48005 RVA: 0x0005BBE2 File Offset: 0x00059DE2
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A00 RID: 14848
			// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x002E5D78 File Offset: 0x002E3F78
			// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x0005BBEB File Offset: 0x00059DEB
			public unsafe static int _FogColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__FogColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__FogColor, (void*)(&value));
				}
			}

			// Token: 0x17003A01 RID: 14849
			// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x002E5D94 File Offset: 0x002E3F94
			// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x0005BBF9 File Offset: 0x00059DF9
			public unsafe static int _Density
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__Density, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__Density, (void*)(&value));
				}
			}

			// Token: 0x17003A02 RID: 14850
			// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x002E5DB0 File Offset: 0x002E3FB0
			// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x0005BC07 File Offset: 0x00059E07
			public unsafe static int _Start
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__Start, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__Start, (void*)(&value));
				}
			}

			// Token: 0x17003A03 RID: 14851
			// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x002E5DCC File Offset: 0x002E3FCC
			// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x0005BC15 File Offset: 0x00059E15
			public unsafe static int _End
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__End, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__End, (void*)(&value));
				}
			}

			// Token: 0x17003A04 RID: 14852
			// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x002E5DE8 File Offset: 0x002E3FE8
			// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x0005BC23 File Offset: 0x00059E23
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x04007E5D RID: 32349
			private static readonly IntPtr NativeFieldInfoPtr__FogColor;

			// Token: 0x04007E5E RID: 32350
			private static readonly IntPtr NativeFieldInfoPtr__Density;

			// Token: 0x04007E5F RID: 32351
			private static readonly IntPtr NativeFieldInfoPtr__Start;

			// Token: 0x04007E60 RID: 32352
			private static readonly IntPtr NativeFieldInfoPtr__End;

			// Token: 0x04007E61 RID: 32353
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;
		}
	}
}
