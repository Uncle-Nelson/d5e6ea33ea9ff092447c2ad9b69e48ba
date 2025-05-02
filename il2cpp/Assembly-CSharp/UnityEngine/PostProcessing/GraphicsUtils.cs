using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000076 RID: 118
	public static class GraphicsUtils : Object
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0008A3AC File Offset: 0x000885AC
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsUtils()
		{
			Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GraphicsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr);
			GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, "s_WhiteTexture");
			GraphicsUtils.NativeFieldInfoPtr_s_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, "s_Quad");
			GraphicsUtils.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664186);
			GraphicsUtils.NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664187);
			GraphicsUtils.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664188);
			GraphicsUtils.NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664189);
			GraphicsUtils.NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664190);
			GraphicsUtils.NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664191);
			GraphicsUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664192);
			GraphicsUtils.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsUtils>.NativeClassPtr, 100664193);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0008A4A4 File Offset: 0x000886A4
		public unsafe static bool isLinearColorSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78948, RefRangeEnd = 78949, XrefRangeStart = 78947, XrefRangeEnd = 78948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0008A4D4 File Offset: 0x000886D4
		public unsafe static bool supportsDX11
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78949, XrefRangeEnd = 78950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0008A504 File Offset: 0x00088704
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78950, XrefRangeEnd = 78968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0008A538 File Offset: 0x00088738
		public unsafe static Mesh quad
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79001, RefRangeEnd = 79003, XrefRangeStart = 78968, XrefRangeEnd = 79001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0008A56C File Offset: 0x0008876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79003, XrefRangeEnd = 79018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Material material, int pass)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0008A5B0 File Offset: 0x000887B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79018, XrefRangeEnd = 79040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0008A634 File Offset: 0x00088834
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 79047, RefRangeEnd = 79060, XrefRangeStart = 79040, XrefRangeEnd = 79047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0008A66C File Offset: 0x0008886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79060, XrefRangeEnd = 79063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsUtils.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0000696E File Offset: 0x00004B6E
		public GraphicsUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0008A694 File Offset: 0x00088894
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00006977 File Offset: 0x00004B77
		public unsafe static Texture2D s_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsUtils.NativeFieldInfoPtr_s_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0008A6BC File Offset: 0x000888BC
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00006989 File Offset: 0x00004B89
		public unsafe static Mesh s_Quad
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsUtils.NativeFieldInfoPtr_s_Quad, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsUtils.NativeFieldInfoPtr_s_Quad, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeFieldInfoPtr_s_WhiteTexture;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_s_Quad;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDX11_Public_Static_get_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_quad_Public_Static_get_Mesh_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Material_Int32_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_ClearAndBlit_Public_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;
	}
}
