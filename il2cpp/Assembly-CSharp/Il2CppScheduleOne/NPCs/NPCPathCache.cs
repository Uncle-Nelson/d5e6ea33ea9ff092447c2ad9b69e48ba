using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DB RID: 731
	public class NPCPathCache : Il2CppSystem.Object
	{
		// Token: 0x060035F5 RID: 13813 RVA: 0x0011E238 File Offset: 0x0011C438
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPathCache()
		{
			Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCPathCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr);
			NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "<Paths>k__BackingField");
			NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669412);
			NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669413);
			NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669414);
			NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669415);
			NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669416);
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x0011E2E0 File Offset: 0x0011C4E0
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0011E320 File Offset: 0x0011C520
		public unsafe List<NPCPathCache.PathCache> Paths
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0011E364 File Offset: 0x0011C564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138055, RefRangeEnd = 138056, XrefRangeStart = 138045, XrefRangeEnd = 138055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrMaxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0011E3CC File Offset: 0x0011C5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138056, XrefRangeEnd = 138064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0011E42C File Offset: 0x0011C62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138064, XrefRangeEnd = 138072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPathCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x0001C58C File Offset: 0x0001A78C
		public NPCPathCache(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x0011E468 File Offset: 0x0011C668
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x0001C595 File Offset: 0x0001A795
		public unsafe List<NPCPathCache.PathCache> _Paths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeFieldInfoPtr__Paths_k__BackingField;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000926 RID: 2342
		[Serializable]
		public class PathCache : Il2CppSystem.Object
		{
			// Token: 0x0600C689 RID: 50825 RVA: 0x00303754 File Offset: 0x00301954
			// Note: this type is marked as 'beforefieldinit'.
			static PathCache()
			{
				Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "PathCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr);
				NPCPathCache.PathCache.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Start");
				NPCPathCache.PathCache.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "End");
				NPCPathCache.PathCache.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Path");
				NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, 100669417);
			}

			// Token: 0x0600C68A RID: 50826 RVA: 0x003037D0 File Offset: 0x003019D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138043, XrefRangeEnd = 138045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathCache(Vector3 start, Vector3 end, NavMeshPath path) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C68B RID: 50827 RVA: 0x00060A31 File Offset: 0x0005EC31
			public PathCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDC RID: 15836
			// (get) Token: 0x0600C68C RID: 50828 RVA: 0x00303838 File Offset: 0x00301A38
			// (set) Token: 0x0600C68D RID: 50829 RVA: 0x00060A3A File Offset: 0x0005EC3A
			public unsafe Vector3 Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x17003DDD RID: 15837
			// (get) Token: 0x0600C68E RID: 50830 RVA: 0x00303860 File Offset: 0x00301A60
			// (set) Token: 0x0600C68F RID: 50831 RVA: 0x00060A55 File Offset: 0x0005EC55
			public unsafe Vector3 End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x17003DDE RID: 15838
			// (get) Token: 0x0600C690 RID: 50832 RVA: 0x00303888 File Offset: 0x00301A88
			// (set) Token: 0x0600C691 RID: 50833 RVA: 0x00060A70 File Offset: 0x0005EC70
			public unsafe NavMeshPath Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400866A RID: 34410
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x0400866B RID: 34411
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x0400866C RID: 34412
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x0400866D RID: 34413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0;
		}
	}
}
