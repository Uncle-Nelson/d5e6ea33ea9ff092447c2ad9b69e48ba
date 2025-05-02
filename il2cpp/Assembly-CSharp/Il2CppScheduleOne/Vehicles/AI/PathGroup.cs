using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000502 RID: 1282
	public class PathGroup : Il2CppSystem.Object
	{
		// Token: 0x060070FA RID: 28922 RVA: 0x001F0234 File Offset: 0x001EE434
		// Note: this type is marked as 'beforefieldinit'.
		static PathGroup()
		{
			Il2CppClassPointerStore<PathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathGroup>.NativeClassPtr);
			PathGroup.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryPoint");
			PathGroup.NativeFieldInfoPtr_startToEntryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "startToEntryPath");
			PathGroup.NativeFieldInfoPtr_entryToExitPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryToExitPath");
			PathGroup.NativeFieldInfoPtr_exitToDestinationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "exitToDestinationPath");
			PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, 100677514);
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x001F02C8 File Offset: 0x001EE4C8
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00035A6E File Offset: 0x00033C6E
		public PathGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x060070FD RID: 28925 RVA: 0x001F0304 File Offset: 0x001EE504
		// (set) Token: 0x060070FE RID: 28926 RVA: 0x00035A77 File Offset: 0x00033C77
		public unsafe Vector3 entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint)) = value;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x060070FF RID: 28927 RVA: 0x001F032C File Offset: 0x001EE52C
		// (set) Token: 0x06007100 RID: 28928 RVA: 0x00035A92 File Offset: 0x00033C92
		public unsafe Path startToEntryPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06007101 RID: 28929 RVA: 0x001F035C File Offset: 0x001EE55C
		// (set) Token: 0x06007102 RID: 28930 RVA: 0x00035AB1 File Offset: 0x00033CB1
		public unsafe Path entryToExitPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06007103 RID: 28931 RVA: 0x001F038C File Offset: 0x001EE58C
		// (set) Token: 0x06007104 RID: 28932 RVA: 0x00035AD0 File Offset: 0x00033CD0
		public unsafe Path exitToDestinationPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeFieldInfoPtr_startToEntryPath;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeFieldInfoPtr_entryToExitPath;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeFieldInfoPtr_exitToDestinationPath;

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
