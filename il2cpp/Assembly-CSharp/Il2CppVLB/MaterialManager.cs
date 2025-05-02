using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x0200009F RID: 159
	public static class MaterialManager : Il2CppSystem.Object
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x00093080 File Offset: 0x00091280
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialManager()
		{
			Il2CppClassPointerStore<MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr);
			MaterialManager.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "materialPropertyBlock");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_SrcFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_DstFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_AlphaAsBlack");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupSD");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupHD");
			MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664544);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664545);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664546);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664547);
			MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664548);
			MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664549);
			MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664550);
			MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664551);
			MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664552);
			MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664553);
			MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664554);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00093204 File Offset: 0x00091404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81775, RefRangeEnd = 81777, XrefRangeStart = 81764, XrefRangeEnd = 81775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gpuInstanced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00093258 File Offset: 0x00091458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81777, XrefRangeEnd = 81785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesSD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000932A8 File Offset: 0x000914A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81793, RefRangeEnd = 81794, XrefRangeStart = 81785, XrefRangeEnd = 81793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesHD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000932F8 File Offset: 0x000914F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81829, RefRangeEnd = 81832, XrefRangeStart = 81794, XrefRangeEnd = 81829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(Hashtable groups, uint groupID, ref MaterialManager.IStaticProperties staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groupID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(staticProps);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			staticProps = ((intPtr4 == 0) ? null : new MaterialManager.IStaticProperties(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Material>(intPtr5) : null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00093374 File Offset: 0x00091574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81832, XrefRangeEnd = 81880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000933C8 File Offset: 0x000915C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilRef(this Material mat, int nameID, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0009341C File Offset: 0x0009161C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilComp(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00093470 File Offset: 0x00091670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilOp(this Material mat, int nameID, StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000934C4 File Offset: 0x000916C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCull(this Material mat, int nameID, CullMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00093518 File Offset: 0x00091718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZWrite(this Material mat, int nameID, MaterialManager.ZWrite value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0009356C File Offset: 0x0009176C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTest(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00007A4C File Offset: 0x00005C4C
		public MaterialManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000935C0 File Offset: 0x000917C0
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00007A55 File Offset: 0x00005C55
		public unsafe static MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000935E8 File Offset: 0x000917E8
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00007A67 File Offset: 0x00005C67
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_SrcFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00093610 File Offset: 0x00091810
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00007A79 File Offset: 0x00005C79
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_DstFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00093638 File Offset: 0x00091838
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00007A8B File Offset: 0x00005C8B
		public unsafe static Il2CppStructArray<bool> BlendingMode_AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00093660 File Offset: 0x00091860
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00007A9D File Offset: 0x00005C9D
		public unsafe static Hashtable ms_MaterialsGroupSD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00093688 File Offset: 0x00091888
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00007AAF File Offset: 0x00005CAF
		public unsafe static Hashtable ms_MaterialsGroupHD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_SrcFactor;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_DstFactor;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_AlphaAsBlack;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupSD;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupHD;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x0200081F RID: 2079
		[OriginalName("Assembly-CSharp.dll", "", "BlendingMode")]
		public enum BlendingMode
		{
			// Token: 0x040080E5 RID: 32997
			Additive,
			// Token: 0x040080E6 RID: 32998
			SoftAdditive,
			// Token: 0x040080E7 RID: 32999
			TraditionalTransparency,
			// Token: 0x040080E8 RID: 33000
			Count
		}

		// Token: 0x02000820 RID: 2080
		[OriginalName("Assembly-CSharp.dll", "", "ColorGradient")]
		public enum ColorGradient
		{
			// Token: 0x040080EA RID: 33002
			Off,
			// Token: 0x040080EB RID: 33003
			MatrixLow,
			// Token: 0x040080EC RID: 33004
			MatrixHigh,
			// Token: 0x040080ED RID: 33005
			Count
		}

		// Token: 0x02000821 RID: 2081
		[OriginalName("Assembly-CSharp.dll", "", "Noise3D")]
		public enum Noise3D
		{
			// Token: 0x040080EF RID: 33007
			Off,
			// Token: 0x040080F0 RID: 33008
			On,
			// Token: 0x040080F1 RID: 33009
			Count
		}

		// Token: 0x02000822 RID: 2082
		public static class SD : Il2CppSystem.Object
		{
			// Token: 0x0600BE7F RID: 48767 RVA: 0x0005D31C File Offset: 0x0005B51C
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr);
			}

			// Token: 0x0600BE80 RID: 48768 RVA: 0x0005D33C File Offset: 0x0005B53C
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000C24 RID: 3108
			[OriginalName("Assembly-CSharp.dll", "", "DepthBlend")]
			public enum DepthBlend
			{
				// Token: 0x0400969B RID: 38555
				Off,
				// Token: 0x0400969C RID: 38556
				On,
				// Token: 0x0400969D RID: 38557
				Count
			}

			// Token: 0x02000C25 RID: 3109
			[OriginalName("Assembly-CSharp.dll", "", "DynamicOcclusion")]
			public enum DynamicOcclusion
			{
				// Token: 0x0400969F RID: 38559
				Off,
				// Token: 0x040096A0 RID: 38560
				ClippingPlane,
				// Token: 0x040096A1 RID: 38561
				DepthTexture,
				// Token: 0x040096A2 RID: 38562
				Count
			}

			// Token: 0x02000C26 RID: 3110
			[OriginalName("Assembly-CSharp.dll", "", "MeshSkewing")]
			public enum MeshSkewing
			{
				// Token: 0x040096A4 RID: 38564
				Off,
				// Token: 0x040096A5 RID: 38565
				On,
				// Token: 0x040096A6 RID: 38566
				Count
			}

			// Token: 0x02000C27 RID: 3111
			[OriginalName("Assembly-CSharp.dll", "", "ShaderAccuracy")]
			public enum ShaderAccuracy
			{
				// Token: 0x040096A8 RID: 38568
				Fast,
				// Token: 0x040096A9 RID: 38569
				High,
				// Token: 0x040096AA RID: 38570
				Count
			}
		}

		// Token: 0x02000823 RID: 2083
		public static class HD : Il2CppSystem.Object
		{
			// Token: 0x0600BE81 RID: 48769 RVA: 0x0005D345 File Offset: 0x0005B545
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr);
			}

			// Token: 0x0600BE82 RID: 48770 RVA: 0x0005D365 File Offset: 0x0005B565
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000C28 RID: 3112
			[OriginalName("Assembly-CSharp.dll", "", "Attenuation")]
			public enum Attenuation
			{
				// Token: 0x040096AC RID: 38572
				Linear,
				// Token: 0x040096AD RID: 38573
				Quadratic,
				// Token: 0x040096AE RID: 38574
				Count
			}

			// Token: 0x02000C29 RID: 3113
			[OriginalName("Assembly-CSharp.dll", "", "Shadow")]
			public enum Shadow
			{
				// Token: 0x040096B0 RID: 38576
				Off,
				// Token: 0x040096B1 RID: 38577
				On,
				// Token: 0x040096B2 RID: 38578
				Count
			}

			// Token: 0x02000C2A RID: 3114
			[OriginalName("Assembly-CSharp.dll", "", "Cookie")]
			public enum Cookie
			{
				// Token: 0x040096B4 RID: 38580
				Off,
				// Token: 0x040096B5 RID: 38581
				SingleChannel,
				// Token: 0x040096B6 RID: 38582
				RGBA,
				// Token: 0x040096B7 RID: 38583
				Count
			}
		}

		// Token: 0x02000824 RID: 2084
		public class IStaticProperties : Il2CppObjectBase
		{
			// Token: 0x0600BE83 RID: 48771 RVA: 0x002EBFBC File Offset: 0x002EA1BC
			// Note: this type is marked as 'beforefieldinit'.
			static IStaticProperties()
			{
				Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "IStaticProperties");
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664556);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664557);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664558);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664559);
			}

			// Token: 0x0600BE84 RID: 48772 RVA: 0x002EC030 File Offset: 0x002EA230
			[CallerCount(0)]
			public unsafe virtual int GetPropertiesCount()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE85 RID: 48773 RVA: 0x002EC078 File Offset: 0x002EA278
			[CallerCount(0)]
			public unsafe virtual int GetMaterialID()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE86 RID: 48774 RVA: 0x002EC0C0 File Offset: 0x002EA2C0
			[CallerCount(0)]
			public unsafe virtual void ApplyToMaterial(Material mat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE87 RID: 48775 RVA: 0x002EC110 File Offset: 0x002EA310
			[CallerCount(0)]
			public unsafe virtual ShaderMode GetShaderMode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE88 RID: 48776 RVA: 0x0005D36E File Offset: 0x0005B56E
			public IStaticProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040080F2 RID: 33010
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x040080F3 RID: 33011
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x040080F4 RID: 33012
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0;

			// Token: 0x040080F5 RID: 33013
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0;
		}

		// Token: 0x02000825 RID: 2085
		[StructLayout(2)]
		public struct StaticPropertiesSD
		{
			// Token: 0x0600BE89 RID: 48777 RVA: 0x002EC158 File Offset: 0x002EA358
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesSD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesSD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr);
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_depthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "depthBlend");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_dynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "dynamicOcclusion");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_meshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "meshSkewing");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_shaderAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "shaderAccuracy");
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664560);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664561);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664562);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664563);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664564);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664565);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664566);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664567);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664568);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664569);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664570);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664571);
			}

			// Token: 0x0600BE8A RID: 48778 RVA: 0x002EC300 File Offset: 0x002EA500
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B3E RID: 15166
			// (get) Token: 0x0600BE8B RID: 48779 RVA: 0x002EC330 File Offset: 0x002EA530
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE8C RID: 48780 RVA: 0x002EC360 File Offset: 0x002EA560
			[CallerCount(0)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B3F RID: 15167
			// (get) Token: 0x0600BE8D RID: 48781 RVA: 0x002EC390 File Offset: 0x002EA590
			public unsafe int blendingModeID
			{
				[CallerCount(197)]
				[CachedScanResults(RefRangeStart = 34412, RefRangeEnd = 34609, XrefRangeStart = 34412, XrefRangeEnd = 34609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B40 RID: 15168
			// (get) Token: 0x0600BE8E RID: 48782 RVA: 0x002EC3C0 File Offset: 0x002EA5C0
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81589, XrefRangeEnd = 81590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B41 RID: 15169
			// (get) Token: 0x0600BE8F RID: 48783 RVA: 0x002EC3F0 File Offset: 0x002EA5F0
			public unsafe int depthBlendID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81590, XrefRangeEnd = 81591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B42 RID: 15170
			// (get) Token: 0x0600BE90 RID: 48784 RVA: 0x002EC420 File Offset: 0x002EA620
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81591, XrefRangeEnd = 81592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B43 RID: 15171
			// (get) Token: 0x0600BE91 RID: 48785 RVA: 0x002EC450 File Offset: 0x002EA650
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81592, XrefRangeEnd = 81593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B44 RID: 15172
			// (get) Token: 0x0600BE92 RID: 48786 RVA: 0x002EC480 File Offset: 0x002EA680
			public unsafe int meshSkewingID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81593, XrefRangeEnd = 81594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B45 RID: 15173
			// (get) Token: 0x0600BE93 RID: 48787 RVA: 0x002EC4B0 File Offset: 0x002EA6B0
			public unsafe int shaderAccuracyID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81594, XrefRangeEnd = 81595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE94 RID: 48788 RVA: 0x002EC4E0 File Offset: 0x002EA6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81595, XrefRangeEnd = 81606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BE95 RID: 48789 RVA: 0x002EC510 File Offset: 0x002EA710
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81668, RefRangeEnd = 81669, XrefRangeStart = 81606, XrefRangeEnd = 81668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE96 RID: 48790 RVA: 0x0005D377 File Offset: 0x0005B577
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, ref this));
			}

			// Token: 0x040080F6 RID: 33014
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x040080F7 RID: 33015
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x040080F8 RID: 33016
			private static readonly IntPtr NativeFieldInfoPtr_depthBlend;

			// Token: 0x040080F9 RID: 33017
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x040080FA RID: 33018
			private static readonly IntPtr NativeFieldInfoPtr_dynamicOcclusion;

			// Token: 0x040080FB RID: 33019
			private static readonly IntPtr NativeFieldInfoPtr_meshSkewing;

			// Token: 0x040080FC RID: 33020
			private static readonly IntPtr NativeFieldInfoPtr_shaderAccuracy;

			// Token: 0x040080FD RID: 33021
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x040080FE RID: 33022
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x040080FF RID: 33023
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008100 RID: 33024
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x04008101 RID: 33025
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x04008102 RID: 33026
			private static readonly IntPtr NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0;

			// Token: 0x04008103 RID: 33027
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x04008104 RID: 33028
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x04008105 RID: 33029
			private static readonly IntPtr NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0;

			// Token: 0x04008106 RID: 33030
			private static readonly IntPtr NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0;

			// Token: 0x04008107 RID: 33031
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008108 RID: 33032
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x04008109 RID: 33033
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x0400810A RID: 33034
			[FieldOffset(4)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x0400810B RID: 33035
			[FieldOffset(8)]
			public MaterialManager.SD.DepthBlend depthBlend;

			// Token: 0x0400810C RID: 33036
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x0400810D RID: 33037
			[FieldOffset(16)]
			public MaterialManager.SD.DynamicOcclusion dynamicOcclusion;

			// Token: 0x0400810E RID: 33038
			[FieldOffset(20)]
			public MaterialManager.SD.MeshSkewing meshSkewing;

			// Token: 0x0400810F RID: 33039
			[FieldOffset(24)]
			public MaterialManager.SD.ShaderAccuracy shaderAccuracy;
		}

		// Token: 0x02000826 RID: 2086
		[StructLayout(2)]
		public struct StaticPropertiesHD
		{
			// Token: 0x0600BE97 RID: 48791 RVA: 0x002EC548 File Offset: 0x002EA748
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesHD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesHD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr);
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "attenuation");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "shadow");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "cookie");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_raymarchingQualityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "raymarchingQualityIndex");
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664572);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664573);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664574);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664575);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664576);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664577);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664578);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664579);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664580);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664581);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664582);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664583);
			}

			// Token: 0x0600BE98 RID: 48792 RVA: 0x002EC6F0 File Offset: 0x002EA8F0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 76505, RefRangeEnd = 76509, XrefRangeStart = 76505, XrefRangeEnd = 76509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B46 RID: 15174
			// (get) Token: 0x0600BE99 RID: 48793 RVA: 0x002EC720 File Offset: 0x002EA920
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81669, XrefRangeEnd = 81671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BE9A RID: 48794 RVA: 0x002EC750 File Offset: 0x002EA950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B47 RID: 15175
			// (get) Token: 0x0600BE9B RID: 48795 RVA: 0x002EC780 File Offset: 0x002EA980
			public unsafe int blendingModeID
			{
				[CallerCount(197)]
				[CachedScanResults(RefRangeStart = 34412, RefRangeEnd = 34609, XrefRangeStart = 34412, XrefRangeEnd = 34609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B48 RID: 15176
			// (get) Token: 0x0600BE9C RID: 48796 RVA: 0x002EC7B0 File Offset: 0x002EA9B0
			public unsafe int attenuationID
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B49 RID: 15177
			// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x002EC7E0 File Offset: 0x002EA9E0
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81671, XrefRangeEnd = 81672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B4A RID: 15178
			// (get) Token: 0x0600BE9E RID: 48798 RVA: 0x002EC810 File Offset: 0x002EAA10
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B4B RID: 15179
			// (get) Token: 0x0600BE9F RID: 48799 RVA: 0x002EC840 File Offset: 0x002EAA40
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81672, XrefRangeEnd = 81673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B4C RID: 15180
			// (get) Token: 0x0600BEA0 RID: 48800 RVA: 0x002EC870 File Offset: 0x002EAA70
			public unsafe int cookieID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81673, XrefRangeEnd = 81674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B4D RID: 15181
			// (get) Token: 0x0600BEA1 RID: 48801 RVA: 0x002EC8A0 File Offset: 0x002EAAA0
			public unsafe int raymarchingQualityID
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEA2 RID: 48802 RVA: 0x002EC8D0 File Offset: 0x002EAAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81674, XrefRangeEnd = 81683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEA3 RID: 48803 RVA: 0x002EC900 File Offset: 0x002EAB00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81758, RefRangeEnd = 81759, XrefRangeStart = 81683, XrefRangeEnd = 81758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEA4 RID: 48804 RVA: 0x0005D389 File Offset: 0x0005B589
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, ref this));
			}

			// Token: 0x04008110 RID: 33040
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x04008111 RID: 33041
			private static readonly IntPtr NativeFieldInfoPtr_attenuation;

			// Token: 0x04008112 RID: 33042
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x04008113 RID: 33043
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x04008114 RID: 33044
			private static readonly IntPtr NativeFieldInfoPtr_shadow;

			// Token: 0x04008115 RID: 33045
			private static readonly IntPtr NativeFieldInfoPtr_cookie;

			// Token: 0x04008116 RID: 33046
			private static readonly IntPtr NativeFieldInfoPtr_raymarchingQualityIndex;

			// Token: 0x04008117 RID: 33047
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x04008118 RID: 33048
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x04008119 RID: 33049
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x0400811A RID: 33050
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x0400811B RID: 33051
			private static readonly IntPtr NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0;

			// Token: 0x0400811C RID: 33052
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x0400811D RID: 33053
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x0400811E RID: 33054
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x0400811F RID: 33055
			private static readonly IntPtr NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0;

			// Token: 0x04008120 RID: 33056
			private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0;

			// Token: 0x04008121 RID: 33057
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008122 RID: 33058
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x04008123 RID: 33059
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x04008124 RID: 33060
			[FieldOffset(4)]
			public MaterialManager.HD.Attenuation attenuation;

			// Token: 0x04008125 RID: 33061
			[FieldOffset(8)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x04008126 RID: 33062
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x04008127 RID: 33063
			[FieldOffset(16)]
			public MaterialManager.HD.Shadow shadow;

			// Token: 0x04008128 RID: 33064
			[FieldOffset(20)]
			public MaterialManager.HD.Cookie cookie;

			// Token: 0x04008129 RID: 33065
			[FieldOffset(24)]
			public int raymarchingQualityIndex;
		}

		// Token: 0x02000827 RID: 2087
		public class MaterialsGroup : Il2CppSystem.Object
		{
			// Token: 0x0600BEA5 RID: 48805 RVA: 0x002EC938 File Offset: 0x002EAB38
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialsGroup()
			{
				Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "MaterialsGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr);
				MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, "materials");
				MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, 100664584);
			}

			// Token: 0x0600BEA6 RID: 48806 RVA: 0x002EC98C File Offset: 0x002EAB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81759, XrefRangeEnd = 81764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialsGroup(int count) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEA7 RID: 48807 RVA: 0x0005D39B File Offset: 0x0005B59B
			public MaterialsGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B4E RID: 15182
			// (get) Token: 0x0600BEA8 RID: 48808 RVA: 0x002EC9D4 File Offset: 0x002EABD4
			// (set) Token: 0x0600BEA9 RID: 48809 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
			public unsafe Il2CppReferenceArray<Material> materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400812A RID: 33066
			private static readonly IntPtr NativeFieldInfoPtr_materials;

			// Token: 0x0400812B RID: 33067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x02000828 RID: 2088
		[OriginalName("Assembly-CSharp.dll", "", "ZWrite")]
		public enum ZWrite
		{
			// Token: 0x0400812D RID: 33069
			Off,
			// Token: 0x0400812E RID: 33070
			On
		}
	}
}
