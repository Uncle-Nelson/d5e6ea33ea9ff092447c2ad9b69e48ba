using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000163 RID: 355
	public class BillboardAsset : ScriptableObject
	{
		// Token: 0x06001CBA RID: 7354 RVA: 0x000C9B34 File Offset: 0x000C7D34
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardAsset()
		{
			Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "BillboardAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr);
			BillboardAsset.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "prefab");
			BillboardAsset.NativeFieldInfoPtr_renderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "renderSettings");
			BillboardAsset.NativeFieldInfoPtr_textureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "textureSize");
			BillboardAsset.NativeFieldInfoPtr_cutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "cutoff");
			BillboardAsset.NativeFieldInfoPtr_pickLastLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "pickLastLOD");
			BillboardAsset.NativeFieldInfoPtr_LODIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "LODIndex");
			BillboardAsset.NativeFieldInfoPtr_generatedTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedTextures");
			BillboardAsset.NativeFieldInfoPtr_generatedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedMesh");
			BillboardAsset.NativeFieldInfoPtr_generatedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedMaterial");
			BillboardAsset.NativeFieldInfoPtr_generatedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedPrefab");
			BillboardAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, 100666307);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000C9C40 File Offset: 0x000C7E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101315, XrefRangeEnd = 101316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BillboardAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000105B0 File Offset: 0x0000E7B0
		public BillboardAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x000C9C7C File Offset: 0x000C7E7C
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x000105B9 File Offset: 0x0000E7B9
		public unsafe GameObject prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000C9CAC File Offset: 0x000C7EAC
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x000105D8 File Offset: 0x0000E7D8
		public unsafe BillboardRenderSettings renderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_renderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BillboardRenderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_renderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000C9CDC File Offset: 0x000C7EDC
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x000105F7 File Offset: 0x0000E7F7
		public unsafe int textureSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_textureSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_textureSize)) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000C9D04 File Offset: 0x000C7F04
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00010612 File Offset: 0x0000E812
		public unsafe float cutoff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_cutoff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_cutoff)) = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x000C9D2C File Offset: 0x000C7F2C
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0001062D File Offset: 0x0000E82D
		public unsafe bool pickLastLOD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_pickLastLOD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_pickLastLOD)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x000C9D54 File Offset: 0x000C7F54
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00010648 File Offset: 0x0000E848
		public unsafe int LODIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_LODIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_LODIndex)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000C9D7C File Offset: 0x000C7F7C
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x00010663 File Offset: 0x0000E863
		public unsafe List<Texture2D> generatedTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x000C9DAC File Offset: 0x000C7FAC
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x00010682 File Offset: 0x0000E882
		public unsafe Mesh generatedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x000C9DDC File Offset: 0x000C7FDC
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x000106A1 File Offset: 0x0000E8A1
		public unsafe Material generatedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x000C9E0C File Offset: 0x000C800C
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x000106C0 File Offset: 0x0000E8C0
		public unsafe GameObject generatedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_renderSettings;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_textureSize;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_cutoff;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_pickLastLOD;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_LODIndex;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_generatedTextures;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_generatedMesh;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_generatedMaterial;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_generatedPrefab;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
