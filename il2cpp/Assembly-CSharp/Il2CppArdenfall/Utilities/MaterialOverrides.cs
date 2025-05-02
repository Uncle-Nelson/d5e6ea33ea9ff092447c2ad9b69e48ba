using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000165 RID: 357
	[Serializable]
	public class MaterialOverrides : Il2CppSystem.Object
	{
		// Token: 0x06001CD8 RID: 7384 RVA: 0x000C9F44 File Offset: 0x000C8144
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialOverrides()
		{
			Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "MaterialOverrides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr);
			MaterialOverrides.NativeFieldInfoPtr_textureOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "textureOverrides");
			MaterialOverrides.NativeFieldInfoPtr_floatOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "floatOverrides");
			MaterialOverrides.NativeFieldInfoPtr_intOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "intOverrides");
			MaterialOverrides.NativeFieldInfoPtr_vectorOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "vectorOverrides");
			MaterialOverrides.NativeFieldInfoPtr_colorOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "colorOverrides");
			MaterialOverrides.NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, 100666312);
			MaterialOverrides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, 100666313);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000CA000 File Offset: 0x000C8200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101342, XrefRangeEnd = 101417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideMaterial(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000CA044 File Offset: 0x000C8244
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialOverrides() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00010726 File Offset: 0x0000E926
		public MaterialOverrides(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000CA080 File Offset: 0x000C8280
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0001072F File Offset: 0x0000E92F
		public unsafe List<MaterialOverrides.TextureProperty> textureOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_textureOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.TextureProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_textureOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000CA0B0 File Offset: 0x000C82B0
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0001074E File Offset: 0x0000E94E
		public unsafe List<MaterialOverrides.FloatProperty> floatOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_floatOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.FloatProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_floatOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000CA0E0 File Offset: 0x000C82E0
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0001076D File Offset: 0x0000E96D
		public unsafe List<MaterialOverrides.IntProperty> intOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_intOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.IntProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_intOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000CA110 File Offset: 0x000C8310
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0001078C File Offset: 0x0000E98C
		public unsafe List<MaterialOverrides.VectorProperty> vectorOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_vectorOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.VectorProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_vectorOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000CA140 File Offset: 0x000C8340
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x000107AB File Offset: 0x0000E9AB
		public unsafe List<MaterialOverrides.ColorProperty> colorOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_colorOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.ColorProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_colorOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_textureOverrides;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_floatOverrides;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_intOverrides;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_vectorOverrides;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_colorOverrides;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200086B RID: 2155
		[Serializable]
		public class TextureProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C14B RID: 49483 RVA: 0x002F3158 File Offset: 0x002F1358
			// Note: this type is marked as 'beforefieldinit'.
			static TextureProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "TextureProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr);
				MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.TextureProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, 100666314);
			}

			// Token: 0x0600C14C RID: 49484 RVA: 0x002F31C0 File Offset: 0x002F13C0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.TextureProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C14D RID: 49485 RVA: 0x0005E869 File Offset: 0x0005CA69
			public TextureProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C3C RID: 15420
			// (get) Token: 0x0600C14E RID: 49486 RVA: 0x002F31FC File Offset: 0x002F13FC
			// (set) Token: 0x0600C14F RID: 49487 RVA: 0x0005E872 File Offset: 0x0005CA72
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C3D RID: 15421
			// (get) Token: 0x0600C150 RID: 49488 RVA: 0x002F3224 File Offset: 0x002F1424
			// (set) Token: 0x0600C151 RID: 49489 RVA: 0x0005E891 File Offset: 0x0005CA91
			public unsafe Texture2D propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082E7 RID: 33511
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082E8 RID: 33512
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082E9 RID: 33513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086C RID: 2156
		[Serializable]
		public class FloatProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C152 RID: 49490 RVA: 0x002F3254 File Offset: 0x002F1454
			// Note: this type is marked as 'beforefieldinit'.
			static FloatProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "FloatProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr);
				MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.FloatProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, 100666315);
			}

			// Token: 0x0600C153 RID: 49491 RVA: 0x002F32BC File Offset: 0x002F14BC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.FloatProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C154 RID: 49492 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
			public FloatProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C3E RID: 15422
			// (get) Token: 0x0600C155 RID: 49493 RVA: 0x002F32F8 File Offset: 0x002F14F8
			// (set) Token: 0x0600C156 RID: 49494 RVA: 0x0005E8B9 File Offset: 0x0005CAB9
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C3F RID: 15423
			// (get) Token: 0x0600C157 RID: 49495 RVA: 0x002F3320 File Offset: 0x002F1520
			// (set) Token: 0x0600C158 RID: 49496 RVA: 0x0005E8D8 File Offset: 0x0005CAD8
			public unsafe float propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082EA RID: 33514
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082EB RID: 33515
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082EC RID: 33516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086D RID: 2157
		[Serializable]
		public class IntProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C159 RID: 49497 RVA: 0x002F3348 File Offset: 0x002F1548
			// Note: this type is marked as 'beforefieldinit'.
			static IntProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "IntProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr);
				MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.IntProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, 100666316);
			}

			// Token: 0x0600C15A RID: 49498 RVA: 0x002F33B0 File Offset: 0x002F15B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.IntProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C15B RID: 49499 RVA: 0x0005E8F3 File Offset: 0x0005CAF3
			public IntProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C40 RID: 15424
			// (get) Token: 0x0600C15C RID: 49500 RVA: 0x002F33EC File Offset: 0x002F15EC
			// (set) Token: 0x0600C15D RID: 49501 RVA: 0x0005E8FC File Offset: 0x0005CAFC
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C41 RID: 15425
			// (get) Token: 0x0600C15E RID: 49502 RVA: 0x002F3414 File Offset: 0x002F1614
			// (set) Token: 0x0600C15F RID: 49503 RVA: 0x0005E91B File Offset: 0x0005CB1B
			public unsafe int propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082ED RID: 33517
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082EE RID: 33518
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082EF RID: 33519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086E RID: 2158
		[Serializable]
		public class VectorProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C160 RID: 49504 RVA: 0x002F343C File Offset: 0x002F163C
			// Note: this type is marked as 'beforefieldinit'.
			static VectorProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "VectorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr);
				MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.VectorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, 100666317);
			}

			// Token: 0x0600C161 RID: 49505 RVA: 0x002F34A4 File Offset: 0x002F16A4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VectorProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.VectorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C162 RID: 49506 RVA: 0x0005E936 File Offset: 0x0005CB36
			public VectorProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C42 RID: 15426
			// (get) Token: 0x0600C163 RID: 49507 RVA: 0x002F34E0 File Offset: 0x002F16E0
			// (set) Token: 0x0600C164 RID: 49508 RVA: 0x0005E93F File Offset: 0x0005CB3F
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C43 RID: 15427
			// (get) Token: 0x0600C165 RID: 49509 RVA: 0x002F3508 File Offset: 0x002F1708
			// (set) Token: 0x0600C166 RID: 49510 RVA: 0x0005E95E File Offset: 0x0005CB5E
			public unsafe Vector4 propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082F0 RID: 33520
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082F1 RID: 33521
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082F2 RID: 33522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086F RID: 2159
		[Serializable]
		public class ColorProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C167 RID: 49511 RVA: 0x002F3530 File Offset: 0x002F1730
			// Note: this type is marked as 'beforefieldinit'.
			static ColorProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "ColorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr);
				MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.ColorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, 100666318);
			}

			// Token: 0x0600C168 RID: 49512 RVA: 0x002F3598 File Offset: 0x002F1798
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.ColorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C169 RID: 49513 RVA: 0x0005E979 File Offset: 0x0005CB79
			public ColorProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C44 RID: 15428
			// (get) Token: 0x0600C16A RID: 49514 RVA: 0x002F35D4 File Offset: 0x002F17D4
			// (set) Token: 0x0600C16B RID: 49515 RVA: 0x0005E982 File Offset: 0x0005CB82
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C45 RID: 15429
			// (get) Token: 0x0600C16C RID: 49516 RVA: 0x002F35FC File Offset: 0x002F17FC
			// (set) Token: 0x0600C16D RID: 49517 RVA: 0x0005E9A1 File Offset: 0x0005CBA1
			public unsafe Color propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082F3 RID: 33523
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082F4 RID: 33524
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082F5 RID: 33525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
