using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000015 RID: 21
	public class BuildingLODMaker : MonoBehaviour
	{
		// Token: 0x06000179 RID: 377 RVA: 0x000754C0 File Offset: 0x000736C0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildingLODMaker()
		{
			Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BuildingLODMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr);
			BuildingLODMaker.NativeFieldInfoPtr_LODGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LODGroups");
			BuildingLODMaker.NativeFieldInfoPtr_LodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LodGroup");
			BuildingLODMaker.NativeMethodInfoPtr_CreateLODs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, 100663419);
			BuildingLODMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, 100663420);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00075540 File Offset: 0x00073740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72019, XrefRangeEnd = 72062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLODs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.NativeMethodInfoPtr_CreateLODs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00075574 File Offset: 0x00073774
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingLODMaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002D43 File Offset: 0x00000F43
		public BuildingLODMaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000755B0 File Offset: 0x000737B0
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002D4C File Offset: 0x00000F4C
		public unsafe Il2CppReferenceArray<BuildingLODMaker.LODGroupData> LODGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LODGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BuildingLODMaker.LODGroupData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LODGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000755E0 File Offset: 0x000737E0
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002D6B File Offset: 0x00000F6B
		public unsafe LODGroup LodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LODGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_LODGroups;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_LodGroup;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_CreateLODs_Public_Void_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A8 RID: 1960
		[Serializable]
		public class LODGroupData : Il2CppSystem.Object
		{
			// Token: 0x0600B945 RID: 47429 RVA: 0x002E028C File Offset: 0x002DE48C
			// Note: this type is marked as 'beforefieldinit'.
			static LODGroupData()
			{
				Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LODGroupData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr);
				BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, "ObjectName");
				BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, "LODObject");
				BuildingLODMaker.LODGroupData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, 100663421);
			}

			// Token: 0x0600B946 RID: 47430 RVA: 0x002E02F4 File Offset: 0x002DE4F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LODGroupData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.LODGroupData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B947 RID: 47431 RVA: 0x0005A94D File Offset: 0x00058B4D
			public LODGroupData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700392B RID: 14635
			// (get) Token: 0x0600B948 RID: 47432 RVA: 0x002E0330 File Offset: 0x002DE530
			// (set) Token: 0x0600B949 RID: 47433 RVA: 0x0005A956 File Offset: 0x00058B56
			public unsafe string ObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700392C RID: 14636
			// (get) Token: 0x0600B94A RID: 47434 RVA: 0x002E0358 File Offset: 0x002DE558
			// (set) Token: 0x0600B94B RID: 47435 RVA: 0x0005A975 File Offset: 0x00058B75
			public unsafe GameObject LODObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D06 RID: 32006
			private static readonly IntPtr NativeFieldInfoPtr_ObjectName;

			// Token: 0x04007D07 RID: 32007
			private static readonly IntPtr NativeFieldInfoPtr_LODObject;

			// Token: 0x04007D08 RID: 32008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
