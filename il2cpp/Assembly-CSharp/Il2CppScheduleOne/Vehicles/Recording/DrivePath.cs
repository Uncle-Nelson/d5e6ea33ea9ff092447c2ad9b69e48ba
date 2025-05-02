using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F6 RID: 1270
	[Serializable]
	public class DrivePath : ScriptableObject
	{
		// Token: 0x0600707A RID: 28794 RVA: 0x001EEBA4 File Offset: 0x001ECDA4
		// Note: this type is marked as 'beforefieldinit'.
		static DrivePath()
		{
			Il2CppClassPointerStore<DrivePath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "DrivePath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivePath>.NativeClassPtr);
			DrivePath.NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "fps");
			DrivePath.NativeFieldInfoPtr_keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "keyframes");
			DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, 100677437);
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x001EEC10 File Offset: 0x001ECE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221727, XrefRangeEnd = 221735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrivePath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrivePath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x0003561E File Offset: 0x0003381E
		public DrivePath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x001EEC4C File Offset: 0x001ECE4C
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x00035627 File Offset: 0x00033827
		public unsafe int fps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps)) = value;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x001EEC74 File Offset: 0x001ECE74
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x00035642 File Offset: 0x00033842
		public unsafe List<VehicleKeyFrame> keyframes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CD4 RID: 19668
		private static readonly IntPtr NativeFieldInfoPtr_fps;

		// Token: 0x04004CD5 RID: 19669
		private static readonly IntPtr NativeFieldInfoPtr_keyframes;

		// Token: 0x04004CD6 RID: 19670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
