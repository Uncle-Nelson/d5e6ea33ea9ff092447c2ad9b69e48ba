using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002F RID: 47
	public static class SmartCombineUtilities : Il2CppSystem.Object
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00003D85 File Offset: 0x00001F85
		// Note: this type is marked as 'beforefieldinit'.
		static SmartCombineUtilities()
		{
			Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmartCombineUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr);
			SmartCombineUtilities.NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr, 100663619);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0007ACC4 File Offset: 0x00078EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73348, XrefRangeEnd = 73445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineMeshesSmart(this Mesh mesh, Il2CppReferenceArray<SmartMeshData> meshData, out Il2CppReferenceArray<Material> materials)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			materials = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Material>(intPtr4));
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003DBE File Offset: 0x00001FBE
		public SmartCombineUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesSmart_Public_Static_Void_Mesh_Il2CppReferenceArray_1_SmartMeshData_byref_Il2CppReferenceArray_1_Material_0;

		// Token: 0x020007B3 RID: 1971
		public class SmartSubmeshData : Il2CppSystem.Object
		{
			// Token: 0x0600B9C7 RID: 47559 RVA: 0x002E1A5C File Offset: 0x002DFC5C
			// Note: this type is marked as 'beforefieldinit'.
			static SmartSubmeshData()
			{
				Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmartCombineUtilities>.NativeClassPtr, "SmartSubmeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr);
				SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, "<mesh>k__BackingField");
				SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, "<combineInstances>k__BackingField");
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663620);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663621);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663622);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663623);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663624);
				SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr, 100663625);
			}

			// Token: 0x17003953 RID: 14675
			// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x002E1B28 File Offset: 0x002DFD28
			// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x002E1B68 File Offset: 0x002DFD68
			public unsafe Mesh mesh
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003954 RID: 14676
			// (get) Token: 0x0600B9CA RID: 47562 RVA: 0x002E1BAC File Offset: 0x002DFDAC
			// (set) Token: 0x0600B9CB RID: 47563 RVA: 0x002E1BEC File Offset: 0x002DFDEC
			public unsafe IList<CombineInstance> combineInstances
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CombineInstance>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B9CC RID: 47564 RVA: 0x002E1C30 File Offset: 0x002DFE30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73332, RefRangeEnd = 73333, XrefRangeStart = 73324, XrefRangeEnd = 73332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmartSubmeshData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartCombineUtilities.SmartSubmeshData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9CD RID: 47565 RVA: 0x002E1C6C File Offset: 0x002DFE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73333, XrefRangeEnd = 73348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CombineSubmeshes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartCombineUtilities.SmartSubmeshData.NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9CE RID: 47566 RVA: 0x0005AD4E File Offset: 0x00058F4E
			public SmartSubmeshData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003951 RID: 14673
			// (get) Token: 0x0600B9CF RID: 47567 RVA: 0x002E1CA0 File Offset: 0x002DFEA0
			// (set) Token: 0x0600B9D0 RID: 47568 RVA: 0x0005AD57 File Offset: 0x00058F57
			public unsafe Mesh _mesh_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003952 RID: 14674
			// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x002E1CD0 File Offset: 0x002DFED0
			// (set) Token: 0x0600B9D2 RID: 47570 RVA: 0x0005AD76 File Offset: 0x00058F76
			public unsafe IList<CombineInstance> _combineInstances_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CombineInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartCombineUtilities.SmartSubmeshData.NativeFieldInfoPtr__combineInstances_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D4E RID: 32078
			private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

			// Token: 0x04007D4F RID: 32079
			private static readonly IntPtr NativeFieldInfoPtr__combineInstances_k__BackingField;

			// Token: 0x04007D50 RID: 32080
			private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

			// Token: 0x04007D51 RID: 32081
			private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

			// Token: 0x04007D52 RID: 32082
			private static readonly IntPtr NativeMethodInfoPtr_get_combineInstances_Public_get_IList_1_CombineInstance_0;

			// Token: 0x04007D53 RID: 32083
			private static readonly IntPtr NativeMethodInfoPtr_set_combineInstances_Private_set_Void_IList_1_CombineInstance_0;

			// Token: 0x04007D54 RID: 32084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D55 RID: 32085
			private static readonly IntPtr NativeMethodInfoPtr_CombineSubmeshes_Public_Void_0;
		}
	}
}
