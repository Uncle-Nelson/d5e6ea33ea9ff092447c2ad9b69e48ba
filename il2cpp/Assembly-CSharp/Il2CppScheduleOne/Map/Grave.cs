using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000770 RID: 1904
	public class Grave : MonoBehaviour
	{
		// Token: 0x0600B4B6 RID: 46262 RVA: 0x002CFAF4 File Offset: 0x002CDCF4
		// Note: this type is marked as 'beforefieldinit'.
		static Grave()
		{
			Il2CppClassPointerStore<Grave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Grave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave>.NativeClassPtr);
			Grave.NativeFieldInfoPtr_Surfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "Surfaces");
			Grave.NativeFieldInfoPtr_HeadstoneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneObjects");
			Grave.NativeFieldInfoPtr_HeadstoneMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMeshes");
			Grave.NativeFieldInfoPtr_HeadstoneMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMaterials");
			Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100685530);
			Grave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100685531);
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x002CFB9C File Offset: 0x002CDD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309836, XrefRangeEnd = 309847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeGrave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x002CFBD0 File Offset: 0x002CDDD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x00058A5E File Offset: 0x00056C5E
		public Grave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600B4BA RID: 46266 RVA: 0x002CFC0C File Offset: 0x002CDE0C
		// (set) Token: 0x0600B4BB RID: 46267 RVA: 0x00058A67 File Offset: 0x00056C67
		public unsafe Il2CppReferenceArray<Grave.GraveSuface> Surfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grave.GraveSuface>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x002CFC3C File Offset: 0x002CDE3C
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x00058A86 File Offset: 0x00056C86
		public unsafe Il2CppReferenceArray<GameObject> HeadstoneObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x002CFC6C File Offset: 0x002CDE6C
		// (set) Token: 0x0600B4BF RID: 46271 RVA: 0x00058AA5 File Offset: 0x00056CA5
		public unsafe Il2CppReferenceArray<MeshRenderer> HeadstoneMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600B4C0 RID: 46272 RVA: 0x002CFC9C File Offset: 0x002CDE9C
		// (set) Token: 0x0600B4C1 RID: 46273 RVA: 0x00058AC4 File Offset: 0x00056CC4
		public unsafe Il2CppReferenceArray<Material> HeadstoneMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079CE RID: 31182
		private static readonly IntPtr NativeFieldInfoPtr_Surfaces;

		// Token: 0x040079CF RID: 31183
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneObjects;

		// Token: 0x040079D0 RID: 31184
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMeshes;

		// Token: 0x040079D1 RID: 31185
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMaterials;

		// Token: 0x040079D2 RID: 31186
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeGrave_Public_Void_0;

		// Token: 0x040079D3 RID: 31187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF9 RID: 3065
		[Serializable]
		public class GraveSuface : Il2CppSystem.Object
		{
			// Token: 0x0600DFBF RID: 57279 RVA: 0x0034B694 File Offset: 0x00349894
			// Note: this type is marked as 'beforefieldinit'.
			static GraveSuface()
			{
				Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grave>.NativeClassPtr, "GraveSuface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr);
				Grave.GraveSuface.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Object");
				Grave.GraveSuface.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Mesh");
				Grave.GraveSuface.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Materials");
				Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, 100685532);
			}

			// Token: 0x0600DFC0 RID: 57280 RVA: 0x0034B710 File Offset: 0x00349910
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GraveSuface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFC1 RID: 57281 RVA: 0x0006D1A8 File Offset: 0x0006B3A8
			public GraveSuface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004555 RID: 17749
			// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x0034B74C File Offset: 0x0034994C
			// (set) Token: 0x0600DFC3 RID: 57283 RVA: 0x0006D1B1 File Offset: 0x0006B3B1
			public unsafe GameObject Object
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004556 RID: 17750
			// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x0034B77C File Offset: 0x0034997C
			// (set) Token: 0x0600DFC5 RID: 57285 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004557 RID: 17751
			// (get) Token: 0x0600DFC6 RID: 57286 RVA: 0x0034B7AC File Offset: 0x003499AC
			// (set) Token: 0x0600DFC7 RID: 57287 RVA: 0x0006D1EF File Offset: 0x0006B3EF
			public unsafe Il2CppReferenceArray<Material> Materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095DD RID: 38365
			private static readonly IntPtr NativeFieldInfoPtr_Object;

			// Token: 0x040095DE RID: 38366
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x040095DF RID: 38367
			private static readonly IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x040095E0 RID: 38368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
