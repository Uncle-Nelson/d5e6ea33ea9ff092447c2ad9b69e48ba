using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000029 RID: 41
	public class MeshCombiner : MonoBehaviour
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0007970C File Offset: 0x0007790C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshCombiner()
		{
			Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshCombiner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr);
			MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "Mesh16BitBufferVertexLimit");
			MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "createMultiMaterialMesh");
			MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "combineInactiveChildren");
			MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "deactivateCombinedChildren");
			MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "deactivateCombinedChildrenMeshRenderers");
			MeshCombiner.NativeFieldInfoPtr_generateUVMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "generateUVMap");
			MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "destroyCombinedChildren");
			MeshCombiner.NativeFieldInfoPtr_folderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "folderPath");
			MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "meshFiltersToSkip");
			MeshCombiner.NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663562);
			MeshCombiner.NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663563);
			MeshCombiner.NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663564);
			MeshCombiner.NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663565);
			MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663566);
			MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663567);
			MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663568);
			MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663569);
			MeshCombiner.NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663570);
			MeshCombiner.NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663571);
			MeshCombiner.NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663572);
			MeshCombiner.NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663573);
			MeshCombiner.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663574);
			MeshCombiner.NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663575);
			MeshCombiner.NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663576);
			MeshCombiner.NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663577);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663578);
			MeshCombiner.NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663579);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663580);
			MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663581);
			MeshCombiner.NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663582);
			MeshCombiner.NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663583);
			MeshCombiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100663584);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002EF RID: 751 RVA: 0x000799BC File Offset: 0x00077BBC
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000799F8 File Offset: 0x00077BF8
		public unsafe bool CreateMultiMaterialMesh
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00079A38 File Offset: 0x00077C38
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00079A74 File Offset: 0x00077C74
		public unsafe bool CombineInactiveChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00079AB4 File Offset: 0x00077CB4
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00079AF0 File Offset: 0x00077CF0
		public unsafe bool DeactivateCombinedChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00079B30 File Offset: 0x00077D30
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00079B6C File Offset: 0x00077D6C
		public unsafe bool DeactivateCombinedChildrenMeshRenderers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00079BAC File Offset: 0x00077DAC
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00079BE8 File Offset: 0x00077DE8
		public unsafe bool GenerateUVMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00079C28 File Offset: 0x00077E28
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00079C64 File Offset: 0x00077E64
		public unsafe bool DestroyCombinedChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00079CA4 File Offset: 0x00077EA4
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00079CDC File Offset: 0x00077EDC
		public unsafe string FolderPath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00079D20 File Offset: 0x00077F20
		[CallerCount(0)]
		public unsafe void CheckDeactivateCombinedChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00079D54 File Offset: 0x00077F54
		[CallerCount(0)]
		public unsafe void CheckDestroyCombinedChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00079D88 File Offset: 0x00077F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72822, XrefRangeEnd = 72863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00079DC8 File Offset: 0x00077FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72920, RefRangeEnd = 72922, XrefRangeStart = 72863, XrefRangeEnd = 72920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<MeshFilter> GetMeshFiltersToCombine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr3) : null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00079E08 File Offset: 0x00078008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72986, RefRangeEnd = 72987, XrefRangeStart = 72922, XrefRangeEnd = 72986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00079E48 File Offset: 0x00078048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73119, RefRangeEnd = 73120, XrefRangeStart = 72987, XrefRangeEnd = 73119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showCreatedMeshInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00079E88 File Offset: 0x00078088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73137, RefRangeEnd = 73139, XrefRangeStart = 73120, XrefRangeEnd = 73137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateCombinedGameObjects(Il2CppReferenceArray<MeshFilter> meshFilters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00079ECC File Offset: 0x000780CC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateUV(Mesh combinedMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combinedMesh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00079F10 File Offset: 0x00078110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73139, XrefRangeEnd = 73148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshCombiner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003ADE File Offset: 0x00001CDE
		public MeshCombiner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00079F4C File Offset: 0x0007814C
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003AE7 File Offset: 0x00001CE7
		public unsafe static int Mesh16BitBufferVertexLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshCombiner.NativeFieldInfoPtr_Mesh16BitBufferVertexLimit, (void*)(&value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00079F68 File Offset: 0x00078168
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003AF5 File Offset: 0x00001CF5
		public unsafe bool createMultiMaterialMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_createMultiMaterialMesh)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00079F90 File Offset: 0x00078190
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00003B10 File Offset: 0x00001D10
		public unsafe bool combineInactiveChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_combineInactiveChildren)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00079FB8 File Offset: 0x000781B8
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003B2B File Offset: 0x00001D2B
		public unsafe bool deactivateCombinedChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildren)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00079FE0 File Offset: 0x000781E0
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003B46 File Offset: 0x00001D46
		public unsafe bool deactivateCombinedChildrenMeshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0007A008 File Offset: 0x00078208
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003B61 File Offset: 0x00001D61
		public unsafe bool generateUVMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_generateUVMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_generateUVMap)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0007A030 File Offset: 0x00078230
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003B7C File Offset: 0x00001D7C
		public unsafe bool destroyCombinedChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_destroyCombinedChildren)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0007A058 File Offset: 0x00078258
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003B97 File Offset: 0x00001D97
		public unsafe string folderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_folderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_folderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0007A080 File Offset: 0x00078280
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003BB6 File Offset: 0x00001DB6
		public unsafe Il2CppReferenceArray<MeshFilter> meshFiltersToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.NativeFieldInfoPtr_meshFiltersToSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_Mesh16BitBufferVertexLimit;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_createMultiMaterialMesh;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_combineInactiveChildren;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_deactivateCombinedChildren;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_deactivateCombinedChildrenMeshRenderers;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_generateUVMap;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_destroyCombinedChildren;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_folderPath;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_meshFiltersToSkip;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_CreateMultiMaterialMesh_Public_get_Boolean_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_set_CreateMultiMaterialMesh_Public_set_Void_Boolean_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_get_CombineInactiveChildren_Public_get_Boolean_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_set_CombineInactiveChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_DeactivateCombinedChildren_Public_get_Boolean_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_set_DeactivateCombinedChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_DeactivateCombinedChildrenMeshRenderers_Public_get_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_set_DeactivateCombinedChildrenMeshRenderers_Public_set_Void_Boolean_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_GenerateUVMap_Public_get_Boolean_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerateUVMap_Public_set_Void_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_DestroyCombinedChildren_Public_get_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_set_DestroyCombinedChildren_Public_set_Void_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_FolderPath_Public_get_String_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_set_FolderPath_Public_set_Void_String_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeactivateCombinedChildren_Private_Void_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_CheckDestroyCombinedChildren_Private_Void_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshFiltersToCombine_Private_Il2CppReferenceArray_1_MeshFilter_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesWithSingleMaterial_Private_Void_Boolean_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesWithMutliMaterial_Private_Void_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateCombinedGameObjects_Private_Void_Il2CppReferenceArray_1_MeshFilter_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUV_Private_Void_Mesh_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007AF RID: 1967
		[ObfuscatedName("MeshCombiner+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B995 RID: 47509 RVA: 0x002E1200 File Offset: 0x002DF400
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr);
				MeshCombiner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, "<>9");
				MeshCombiner.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, "<>9__33_1");
				MeshCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, 100663586);
				MeshCombiner.__c.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr, 100663587);
			}

			// Token: 0x0600B996 RID: 47510 RVA: 0x002E127C File Offset: 0x002DF47C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B997 RID: 47511 RVA: 0x002E12B8 File Offset: 0x002DF4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72806, XrefRangeEnd = 72810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__33_1(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B998 RID: 47512 RVA: 0x0005AB93 File Offset: 0x00058D93
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003940 RID: 14656
			// (get) Token: 0x0600B999 RID: 47513 RVA: 0x002E1308 File Offset: 0x002DF508
			// (set) Token: 0x0600B99A RID: 47514 RVA: 0x0005AB9C File Offset: 0x00058D9C
			public unsafe static MeshCombiner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MeshCombiner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshCombiner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003941 RID: 14657
			// (get) Token: 0x0600B99B RID: 47515 RVA: 0x002E1330 File Offset: 0x002DF530
			// (set) Token: 0x0600B99C RID: 47516 RVA: 0x0005ABAE File Offset: 0x00058DAE
			public unsafe static Func<MeshFilter, bool> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MeshCombiner.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MeshFilter, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshCombiner.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D33 RID: 32051
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D34 RID: 32052
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04007D35 RID: 32053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D36 RID: 32054
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__33_1_Internal_Boolean_MeshFilter_0;
		}

		// Token: 0x020007B0 RID: 1968
		[ObfuscatedName("MeshCombiner+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B99D RID: 47517 RVA: 0x002E1358 File Offset: 0x002DF558
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr);
				MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, "meshFilters");
				MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, 100663588);
				MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr, 100663589);
			}

			// Token: 0x0600B99E RID: 47518 RVA: 0x002E13D4 File Offset: 0x002DF5D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B99F RID: 47519 RVA: 0x002E1410 File Offset: 0x002DF610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72810, XrefRangeEnd = 72816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__0(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_0.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9A0 RID: 47520 RVA: 0x0005ABC0 File Offset: 0x00058DC0
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003942 RID: 14658
			// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x002E1460 File Offset: 0x002DF660
			// (set) Token: 0x0600B9A2 RID: 47522 RVA: 0x0005ABC9 File Offset: 0x00058DC9
			public unsafe Il2CppReferenceArray<MeshFilter> meshFilters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshFilter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr_meshFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003943 RID: 14659
			// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x002E1490 File Offset: 0x002DF690
			// (set) Token: 0x0600B9A4 RID: 47524 RVA: 0x0005ABE8 File Offset: 0x00058DE8
			public unsafe MeshCombiner __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D37 RID: 32055
			private static readonly IntPtr NativeFieldInfoPtr_meshFilters;

			// Token: 0x04007D38 RID: 32056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D39 RID: 32057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D3A RID: 32058
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__0_Internal_Boolean_MeshFilter_0;
		}

		// Token: 0x020007B1 RID: 1969
		[ObfuscatedName("MeshCombiner+<>c__DisplayClass33_1")]
		public sealed class __c__DisplayClass33_1 : Il2CppSystem.Object
		{
			// Token: 0x0600B9A5 RID: 47525 RVA: 0x002E14C0 File Offset: 0x002DF6C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_1()
			{
				Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c__DisplayClass33_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr);
				MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, "i");
				MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, "CS$<>8__locals1");
				MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, 100663590);
				MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr, 100663591);
			}

			// Token: 0x0600B9A6 RID: 47526 RVA: 0x002E153C File Offset: 0x002DF73C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCombiner.__c__DisplayClass33_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9A7 RID: 47527 RVA: 0x002E1578 File Offset: 0x002DF778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72816, XrefRangeEnd = 72822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMeshFiltersToCombine_b__2(MeshFilter meshFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCombiner.__c__DisplayClass33_1.NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9A8 RID: 47528 RVA: 0x0005AC07 File Offset: 0x00058E07
			public __c__DisplayClass33_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003944 RID: 14660
			// (get) Token: 0x0600B9A9 RID: 47529 RVA: 0x002E15C8 File Offset: 0x002DF7C8
			// (set) Token: 0x0600B9AA RID: 47530 RVA: 0x0005AC10 File Offset: 0x00058E10
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17003945 RID: 14661
			// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x002E15F0 File Offset: 0x002DF7F0
			// (set) Token: 0x0600B9AC RID: 47532 RVA: 0x0005AC2B File Offset: 0x00058E2B
			public unsafe MeshCombiner.__c__DisplayClass33_0 field_Public___c__DisplayClass33_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCombiner.__c__DisplayClass33_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshCombiner.__c__DisplayClass33_1.NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D3B RID: 32059
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04007D3C RID: 32060
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass33_0_0;

			// Token: 0x04007D3D RID: 32061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D3E RID: 32062
			private static readonly IntPtr NativeMethodInfoPtr__GetMeshFiltersToCombine_b__2_Internal_Boolean_MeshFilter_0;
		}
	}
}
