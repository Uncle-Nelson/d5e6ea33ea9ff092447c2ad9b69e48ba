using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003A RID: 58
	public class FlockWaypointTrigger : MonoBehaviour
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x0007E720 File Offset: 0x0007C920
		// Note: this type is marked as 'beforefieldinit'.
		static FlockWaypointTrigger()
		{
			Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockWaypointTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr);
			FlockWaypointTrigger.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_timer");
			FlockWaypointTrigger.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_flockChild");
			FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663695);
			FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663696);
			FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663697);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0007E7B4 File Offset: 0x0007C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74357, XrefRangeEnd = 74371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007E7E8 File Offset: 0x0007C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74371, XrefRangeEnd = 74373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007E81C File Offset: 0x0007CA1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74374, RefRangeEnd = 74378, XrefRangeStart = 74373, XrefRangeEnd = 74374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockWaypointTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004E49 File Offset: 0x00003049
		public FlockWaypointTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0007E858 File Offset: 0x0007CA58
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00004E52 File Offset: 0x00003052
		public unsafe float _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0007E880 File Offset: 0x0007CA80
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00004E6D File Offset: 0x0000306D
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
