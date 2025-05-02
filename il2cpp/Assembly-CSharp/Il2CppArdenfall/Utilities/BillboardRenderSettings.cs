using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000164 RID: 356
	public class BillboardRenderSettings : ScriptableObject
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x000C9E3C File Offset: 0x000C803C
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardRenderSettings()
		{
			Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "BillboardRenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr);
			BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "billboardTextures");
			BillboardRenderSettings.NativeFieldInfoPtr_billboardShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "billboardShader");
			BillboardRenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, 100666308);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000C9EA8 File Offset: 0x000C80A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BillboardRenderSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000106DF File Offset: 0x0000E8DF
		public BillboardRenderSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000C9EE4 File Offset: 0x000C80E4
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000106E8 File Offset: 0x0000E8E8
		public unsafe List<BillboardRenderSettings.BillboardTexture> billboardTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BillboardRenderSettings.BillboardTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000C9F14 File Offset: 0x000C8114
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00010707 File Offset: 0x0000E907
		public unsafe Shader billboardShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_billboardTextures;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_billboardShader;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000869 RID: 2153
		[Serializable]
		public class BillboardTexture : Il2CppSystem.Object
		{
			// Token: 0x0600C130 RID: 49456 RVA: 0x002F2DA0 File Offset: 0x002F0FA0
			// Note: this type is marked as 'beforefieldinit'.
			static BillboardTexture()
			{
				Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "BillboardTexture");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr);
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "textureId");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "powerOfTwo");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "alphaIsTransparency");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "bakePasses");
				BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, 100666309);
				BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, 100666310);
			}

			// Token: 0x0600C131 RID: 49457 RVA: 0x002F2E44 File Offset: 0x002F1044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101316, XrefRangeEnd = 101336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureFormat GetFormat()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C132 RID: 49458 RVA: 0x002F2E80 File Offset: 0x002F1080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101336, XrefRangeEnd = 101341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BillboardTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C133 RID: 49459 RVA: 0x0005E739 File Offset: 0x0005C939
			public BillboardTexture(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C32 RID: 15410
			// (get) Token: 0x0600C134 RID: 49460 RVA: 0x002F2EBC File Offset: 0x002F10BC
			// (set) Token: 0x0600C135 RID: 49461 RVA: 0x0005E742 File Offset: 0x0005C942
			public unsafe string textureId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C33 RID: 15411
			// (get) Token: 0x0600C136 RID: 49462 RVA: 0x002F2EE4 File Offset: 0x002F10E4
			// (set) Token: 0x0600C137 RID: 49463 RVA: 0x0005E761 File Offset: 0x0005C961
			public unsafe bool powerOfTwo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo)) = value;
				}
			}

			// Token: 0x17003C34 RID: 15412
			// (get) Token: 0x0600C138 RID: 49464 RVA: 0x002F2F0C File Offset: 0x002F110C
			// (set) Token: 0x0600C139 RID: 49465 RVA: 0x0005E77C File Offset: 0x0005C97C
			public unsafe bool alphaIsTransparency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency)) = value;
				}
			}

			// Token: 0x17003C35 RID: 15413
			// (get) Token: 0x0600C13A RID: 49466 RVA: 0x002F2F34 File Offset: 0x002F1134
			// (set) Token: 0x0600C13B RID: 49467 RVA: 0x0005E797 File Offset: 0x0005C997
			public unsafe List<BillboardRenderSettings.BakePass> bakePasses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BillboardRenderSettings.BakePass>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082DA RID: 33498
			private static readonly IntPtr NativeFieldInfoPtr_textureId;

			// Token: 0x040082DB RID: 33499
			private static readonly IntPtr NativeFieldInfoPtr_powerOfTwo;

			// Token: 0x040082DC RID: 33500
			private static readonly IntPtr NativeFieldInfoPtr_alphaIsTransparency;

			// Token: 0x040082DD RID: 33501
			private static readonly IntPtr NativeFieldInfoPtr_bakePasses;

			// Token: 0x040082DE RID: 33502
			private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0;

			// Token: 0x040082DF RID: 33503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086A RID: 2154
		[Serializable]
		public class BakePass : Il2CppSystem.Object
		{
			// Token: 0x0600C13C RID: 49468 RVA: 0x002F2F64 File Offset: 0x002F1164
			// Note: this type is marked as 'beforefieldinit'.
			static BakePass()
			{
				Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "BakePass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr);
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "customShader");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "materialOverrides");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "r");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "g");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "b");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "a");
				BillboardRenderSettings.BakePass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, 100666311);
			}

			// Token: 0x0600C13D RID: 49469 RVA: 0x002F301C File Offset: 0x002F121C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101341, XrefRangeEnd = 101342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BakePass() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BakePass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C13E RID: 49470 RVA: 0x0005E7B6 File Offset: 0x0005C9B6
			public BakePass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C36 RID: 15414
			// (get) Token: 0x0600C13F RID: 49471 RVA: 0x002F3058 File Offset: 0x002F1258
			// (set) Token: 0x0600C140 RID: 49472 RVA: 0x0005E7BF File Offset: 0x0005C9BF
			public unsafe Shader customShader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C37 RID: 15415
			// (get) Token: 0x0600C141 RID: 49473 RVA: 0x002F3088 File Offset: 0x002F1288
			// (set) Token: 0x0600C142 RID: 49474 RVA: 0x0005E7DE File Offset: 0x0005C9DE
			public unsafe MaterialOverrides materialOverrides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialOverrides>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C38 RID: 15416
			// (get) Token: 0x0600C143 RID: 49475 RVA: 0x002F30B8 File Offset: 0x002F12B8
			// (set) Token: 0x0600C144 RID: 49476 RVA: 0x0005E7FD File Offset: 0x0005C9FD
			public unsafe bool r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r)) = value;
				}
			}

			// Token: 0x17003C39 RID: 15417
			// (get) Token: 0x0600C145 RID: 49477 RVA: 0x002F30E0 File Offset: 0x002F12E0
			// (set) Token: 0x0600C146 RID: 49478 RVA: 0x0005E818 File Offset: 0x0005CA18
			public unsafe bool g
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g)) = value;
				}
			}

			// Token: 0x17003C3A RID: 15418
			// (get) Token: 0x0600C147 RID: 49479 RVA: 0x002F3108 File Offset: 0x002F1308
			// (set) Token: 0x0600C148 RID: 49480 RVA: 0x0005E833 File Offset: 0x0005CA33
			public unsafe bool b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b)) = value;
				}
			}

			// Token: 0x17003C3B RID: 15419
			// (get) Token: 0x0600C149 RID: 49481 RVA: 0x002F3130 File Offset: 0x002F1330
			// (set) Token: 0x0600C14A RID: 49482 RVA: 0x0005E84E File Offset: 0x0005CA4E
			public unsafe bool a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a)) = value;
				}
			}

			// Token: 0x040082E0 RID: 33504
			private static readonly IntPtr NativeFieldInfoPtr_customShader;

			// Token: 0x040082E1 RID: 33505
			private static readonly IntPtr NativeFieldInfoPtr_materialOverrides;

			// Token: 0x040082E2 RID: 33506
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x040082E3 RID: 33507
			private static readonly IntPtr NativeFieldInfoPtr_g;

			// Token: 0x040082E4 RID: 33508
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x040082E5 RID: 33509
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x040082E6 RID: 33510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
