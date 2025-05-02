using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076A RID: 1898
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x0600B423 RID: 46115 RVA: 0x002CE09C File Offset: 0x002CC29C
		// Note: this type is marked as 'beforefieldinit'.
		static CarStopper()
		{
			Il2CppClassPointerStore<CarStopper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "CarStopper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarStopper>.NativeClassPtr);
			CarStopper.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "isActive");
			CarStopper.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "blocker");
			CarStopper.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "Obstacle");
			CarStopper.NativeFieldInfoPtr_moveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "moveTime");
			CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100685483);
			CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100685484);
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x002CE144 File Offset: 0x002CC344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309284, XrefRangeEnd = 309294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x002CE180 File Offset: 0x002CC380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarStopper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarStopper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x00058508 File Offset: 0x00056708
		public CarStopper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B427 RID: 46119 RVA: 0x002CE1BC File Offset: 0x002CC3BC
		// (set) Token: 0x0600B428 RID: 46120 RVA: 0x00058511 File Offset: 0x00056711
		public unsafe bool isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive)) = value;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600B429 RID: 46121 RVA: 0x002CE1E4 File Offset: 0x002CC3E4
		// (set) Token: 0x0600B42A RID: 46122 RVA: 0x0005852C File Offset: 0x0005672C
		public unsafe Transform blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600B42B RID: 46123 RVA: 0x002CE214 File Offset: 0x002CC414
		// (set) Token: 0x0600B42C RID: 46124 RVA: 0x0005854B File Offset: 0x0005674B
		public unsafe NavMeshObstacle Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600B42D RID: 46125 RVA: 0x002CE244 File Offset: 0x002CC444
		// (set) Token: 0x0600B42E RID: 46126 RVA: 0x0005856A File Offset: 0x0005676A
		public unsafe float moveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime)) = value;
			}
		}

		// Token: 0x04007975 RID: 31093
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04007976 RID: 31094
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x04007977 RID: 31095
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04007978 RID: 31096
		private static readonly IntPtr NativeFieldInfoPtr_moveTime;

		// Token: 0x04007979 RID: 31097
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400797A RID: 31098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
