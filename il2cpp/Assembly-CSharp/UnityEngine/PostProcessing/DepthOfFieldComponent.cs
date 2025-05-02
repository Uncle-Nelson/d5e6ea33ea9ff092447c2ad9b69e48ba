using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000053 RID: 83
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x000840E8 File Offset: 0x000822E8
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldComponent()
		{
			Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DepthOfFieldComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr);
			DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "k_ShaderString");
			DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "m_CoCHistory");
			DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "k_FilmHeight");
			DepthOfFieldComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663935);
			DepthOfFieldComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663936);
			DepthOfFieldComponent.NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663937);
			DepthOfFieldComponent.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663938);
			DepthOfFieldComponent.NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663939);
			DepthOfFieldComponent.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663940);
			DepthOfFieldComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663941);
			DepthOfFieldComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663942);
			DepthOfFieldComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663943);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00084208 File Offset: 0x00082408
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76504, XrefRangeEnd = 76505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00084244 File Offset: 0x00082444
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76505, RefRangeEnd = 76509, XrefRangeStart = 76505, XrefRangeEnd = 76505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00084280 File Offset: 0x00082480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76509, XrefRangeEnd = 76512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateFocalLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000842BC File Offset: 0x000824BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76512, XrefRangeEnd = 76513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateMaxCoCRadius(int screenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00084308 File Offset: 0x00082508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76513, XrefRangeEnd = 76519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckHistory(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00084360 File Offset: 0x00082560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76519, XrefRangeEnd = 76521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref primary;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000843B8 File Offset: 0x000825B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76619, RefRangeEnd = 76620, XrefRangeStart = 76521, XrefRangeEnd = 76619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antialiasCoC;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaJitter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaBlending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00084438 File Offset: 0x00082638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76620, XrefRangeEnd = 76626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0008446C File Offset: 0x0008266C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76629, RefRangeEnd = 76630, XrefRangeStart = 76626, XrefRangeEnd = 76629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00005BFD File Offset: 0x00003DFD
		public DepthOfFieldComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000844A8 File Offset: 0x000826A8
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00005C06 File Offset: 0x00003E06
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000844C8 File Offset: 0x000826C8
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00005C18 File Offset: 0x00003E18
		public unsafe RenderTexture m_CoCHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000844F8 File Offset: 0x000826F8
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00005C37 File Offset: 0x00003E37
		public unsafe static float k_FilmHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight, (void*)(&value));
			}
		}

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_m_CoCHistory;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_k_FilmHeight;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CC RID: 1996
		public static class Uniforms : Object
		{
			// Token: 0x0600BB58 RID: 47960 RVA: 0x002E58D4 File Offset: 0x002E3AD4
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr);
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldCoCTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_Distance");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_LensCoeff");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_MaxCoC");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_RcpMaxCoC");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_RcpAspect");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_MainTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_CoCTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_TaaParams");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldParams");
			}

			// Token: 0x0600BB59 RID: 47961 RVA: 0x0005BABD File Offset: 0x00059CBD
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039ED RID: 14829
			// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x002E59DC File Offset: 0x002E3BDC
			// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x0005BAC6 File Offset: 0x00059CC6
			public unsafe static int _DepthOfFieldTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex, (void*)(&value));
				}
			}

			// Token: 0x170039EE RID: 14830
			// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x002E59F8 File Offset: 0x002E3BF8
			// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x0005BAD4 File Offset: 0x00059CD4
			public unsafe static int _DepthOfFieldCoCTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex, (void*)(&value));
				}
			}

			// Token: 0x170039EF RID: 14831
			// (get) Token: 0x0600BB5E RID: 47966 RVA: 0x002E5A14 File Offset: 0x002E3C14
			// (set) Token: 0x0600BB5F RID: 47967 RVA: 0x0005BAE2 File Offset: 0x00059CE2
			public unsafe static int _Distance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance, (void*)(&value));
				}
			}

			// Token: 0x170039F0 RID: 14832
			// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x002E5A30 File Offset: 0x002E3C30
			// (set) Token: 0x0600BB61 RID: 47969 RVA: 0x0005BAF0 File Offset: 0x00059CF0
			public unsafe static int _LensCoeff
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff, (void*)(&value));
				}
			}

			// Token: 0x170039F1 RID: 14833
			// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x002E5A4C File Offset: 0x002E3C4C
			// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x0005BAFE File Offset: 0x00059CFE
			public unsafe static int _MaxCoC
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC, (void*)(&value));
				}
			}

			// Token: 0x170039F2 RID: 14834
			// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x002E5A68 File Offset: 0x002E3C68
			// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x0005BB0C File Offset: 0x00059D0C
			public unsafe static int _RcpMaxCoC
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC, (void*)(&value));
				}
			}

			// Token: 0x170039F3 RID: 14835
			// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x002E5A84 File Offset: 0x002E3C84
			// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x0005BB1A File Offset: 0x00059D1A
			public unsafe static int _RcpAspect
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect, (void*)(&value));
				}
			}

			// Token: 0x170039F4 RID: 14836
			// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x002E5AA0 File Offset: 0x002E3CA0
			// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x0005BB28 File Offset: 0x00059D28
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039F5 RID: 14837
			// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x002E5ABC File Offset: 0x002E3CBC
			// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x0005BB36 File Offset: 0x00059D36
			public unsafe static int _CoCTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex, (void*)(&value));
				}
			}

			// Token: 0x170039F6 RID: 14838
			// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x002E5AD8 File Offset: 0x002E3CD8
			// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x0005BB44 File Offset: 0x00059D44
			public unsafe static int _TaaParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams, (void*)(&value));
				}
			}

			// Token: 0x170039F7 RID: 14839
			// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x002E5AF4 File Offset: 0x002E3CF4
			// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x0005BB52 File Offset: 0x00059D52
			public unsafe static int _DepthOfFieldParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams, (void*)(&value));
				}
			}

			// Token: 0x04007E4A RID: 32330
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldTex;

			// Token: 0x04007E4B RID: 32331
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldCoCTex;

			// Token: 0x04007E4C RID: 32332
			private static readonly IntPtr NativeFieldInfoPtr__Distance;

			// Token: 0x04007E4D RID: 32333
			private static readonly IntPtr NativeFieldInfoPtr__LensCoeff;

			// Token: 0x04007E4E RID: 32334
			private static readonly IntPtr NativeFieldInfoPtr__MaxCoC;

			// Token: 0x04007E4F RID: 32335
			private static readonly IntPtr NativeFieldInfoPtr__RcpMaxCoC;

			// Token: 0x04007E50 RID: 32336
			private static readonly IntPtr NativeFieldInfoPtr__RcpAspect;

			// Token: 0x04007E51 RID: 32337
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E52 RID: 32338
			private static readonly IntPtr NativeFieldInfoPtr__CoCTex;

			// Token: 0x04007E53 RID: 32339
			private static readonly IntPtr NativeFieldInfoPtr__TaaParams;

			// Token: 0x04007E54 RID: 32340
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldParams;
		}
	}
}
