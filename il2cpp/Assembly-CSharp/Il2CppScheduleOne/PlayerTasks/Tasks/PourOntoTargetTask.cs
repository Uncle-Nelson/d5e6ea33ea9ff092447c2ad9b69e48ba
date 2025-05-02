using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000211 RID: 529
	public class PourOntoTargetTask : PourIntoPotTask
	{
		// Token: 0x06002C28 RID: 11304 RVA: 0x000FC640 File Offset: 0x000FA840
		// Note: this type is marked as 'beforefieldinit'.
		static PourOntoTargetTask()
		{
			Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourOntoTargetTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr);
			PourOntoTargetTask.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "Target");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_THRESHOLD");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_TIME");
			PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "timeOverTarget");
			PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668264);
			PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668265);
			PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668266);
			PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668267);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000FC710 File Offset: 0x000FA910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123537, XrefRangeEnd = 123542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourOntoTargetTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000FC780 File Offset: 0x000FA980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123542, XrefRangeEnd = 123546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000FC7BC File Offset: 0x000FA9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123546, XrefRangeEnd = 123549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000FC7F8 File Offset: 0x000FA9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123549, XrefRangeEnd = 123555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00017DF6 File Offset: 0x00015FF6
		public PourOntoTargetTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x000FC834 File Offset: 0x000FAA34
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x00017DFF File Offset: 0x00015FFF
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000FC864 File Offset: 0x000FAA64
		// (set) Token: 0x06002C31 RID: 11313 RVA: 0x00017E1E File Offset: 0x0001601E
		public unsafe float SUCCESS_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x000FC88C File Offset: 0x000FAA8C
		// (set) Token: 0x06002C33 RID: 11315 RVA: 0x00017E39 File Offset: 0x00016039
		public unsafe float SUCCESS_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME)) = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000FC8B4 File Offset: 0x000FAAB4
		// (set) Token: 0x06002C35 RID: 11317 RVA: 0x00017E54 File Offset: 0x00016054
		public unsafe float timeOverTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget)) = value;
			}
		}

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_THRESHOLD;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_TIME;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr_timeOverTarget;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0;
	}
}
