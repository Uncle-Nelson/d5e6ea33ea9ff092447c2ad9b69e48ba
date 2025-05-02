using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000503 RID: 1283
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x06007105 RID: 28933 RVA: 0x001F03BC File Offset: 0x001EE5BC
		// Note: this type is marked as 'beforefieldinit'.
		static PathPoint()
		{
			Il2CppClassPointerStore<PathPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPoint>.NativeClassPtr);
			PathPoint.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "connections");
			PathPoint.NativeFieldInfoPtr_unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "unique");
			PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, 100677515);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x001F0428 File Offset: 0x001EE628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222375, XrefRangeEnd = 222383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00035AEF File Offset: 0x00033CEF
		public PathPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x001F0464 File Offset: 0x001EE664
		// (set) Token: 0x06007109 RID: 28937 RVA: 0x00035AF8 File Offset: 0x00033CF8
		public unsafe List<PathPoint> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x001F0494 File Offset: 0x001EE694
		// (set) Token: 0x0600710B RID: 28939 RVA: 0x00035B17 File Offset: 0x00033D17
		public unsafe bool unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique)) = value;
			}
		}

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_unique;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
