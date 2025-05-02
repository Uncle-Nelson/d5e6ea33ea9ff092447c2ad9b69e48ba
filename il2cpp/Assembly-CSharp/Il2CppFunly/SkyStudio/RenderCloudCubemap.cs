using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011E RID: 286
	public class RenderCloudCubemap : MonoBehaviour
	{
		// Token: 0x0600186B RID: 6251 RVA: 0x000BC93C File Offset: 0x000BAB3C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderCloudCubemap()
		{
			Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RenderCloudCubemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr);
			RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "kDefaultFilenamePrefix");
			RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "filenamePrefix");
			RenderCloudCubemap.NativeFieldInfoPtr_faceWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "faceWidth");
			RenderCloudCubemap.NativeFieldInfoPtr_textureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "textureFormat");
			RenderCloudCubemap.NativeFieldInfoPtr_exportFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, "exportFaces");
			RenderCloudCubemap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr, 100665896);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000BC9E4 File Offset: 0x000BABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95299, XrefRangeEnd = 95304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderCloudCubemap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderCloudCubemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderCloudCubemap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0000E0AB File Offset: 0x0000C2AB
		public RenderCloudCubemap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000BCA20 File Offset: 0x000BAC20
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public unsafe static string kDefaultFilenamePrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderCloudCubemap.NativeFieldInfoPtr_kDefaultFilenamePrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000BCA40 File Offset: 0x000BAC40
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		public unsafe string filenamePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_filenamePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x000BCA68 File Offset: 0x000BAC68
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0000E0E5 File Offset: 0x0000C2E5
		public unsafe int faceWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_faceWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_faceWidth)) = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x000BCA90 File Offset: 0x000BAC90
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000E100 File Offset: 0x0000C300
		public unsafe RenderCloudCubemap.CubemapTextureFormat textureFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_textureFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_textureFormat)) = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000BCAB8 File Offset: 0x000BACB8
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000E11B File Offset: 0x0000C31B
		public unsafe bool exportFaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_exportFaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderCloudCubemap.NativeFieldInfoPtr_exportFaces)) = value;
			}
		}

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultFilenamePrefix;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr_filenamePrefix;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr_faceWidth;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_textureFormat;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr_exportFaces;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000856 RID: 2134
		[OriginalName("Assembly-CSharp.dll", "", "CubemapTextureFormat")]
		public enum CubemapTextureFormat
		{
			// Token: 0x04008261 RID: 33377
			RGBColor,
			// Token: 0x04008262 RID: 33378
			RGBAColor,
			// Token: 0x04008263 RID: 33379
			RGBALit
		}
	}
}
