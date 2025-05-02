using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000500 RID: 1280
	public class RoadPath : Object
	{
		// Token: 0x060070F3 RID: 28915 RVA: 0x001F0170 File Offset: 0x001EE370
		// Note: this type is marked as 'beforefieldinit'.
		static RoadPath()
		{
			Il2CppClassPointerStore<RoadPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "RoadPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPath>.NativeClassPtr);
			RoadPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, "vectorPath");
			RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, 100677513);
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x001F01C8 File Offset: 0x001EE3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222367, XrefRangeEnd = 222375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00035A18 File Offset: 0x00033C18
		public RoadPath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x001F0204 File Offset: 0x001EE404
		// (set) Token: 0x060070F7 RID: 28919 RVA: 0x00035A21 File Offset: 0x00033C21
		public unsafe List<PathPoint> vectorPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
