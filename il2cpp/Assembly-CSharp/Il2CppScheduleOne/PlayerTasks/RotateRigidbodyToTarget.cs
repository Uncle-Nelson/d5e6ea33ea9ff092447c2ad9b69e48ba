using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000200 RID: 512
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x06002A7E RID: 10878 RVA: 0x000F718C File Offset: 0x000F538C
		// Note: this type is marked as 'beforefieldinit'.
		static RotateRigidbodyToTarget()
		{
			Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "RotateRigidbodyToTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr);
			RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "Rigidbody");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "TargetRotation");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "RotationForce");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_CuntAssFuckingBitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "CuntAssFuckingBitch");
			RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668068);
			RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668069);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000F7234 File Offset: 0x000F5434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120638, XrefRangeEnd = 120651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000F7268 File Offset: 0x000F5468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120651, XrefRangeEnd = 120652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateRigidbodyToTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0001709E File Offset: 0x0001529E
		public RotateRigidbodyToTarget(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000F72A4 File Offset: 0x000F54A4
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x000170A7 File Offset: 0x000152A7
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000F72D4 File Offset: 0x000F54D4
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x000170C6 File Offset: 0x000152C6
		public unsafe Vector3 TargetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation)) = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000F72FC File Offset: 0x000F54FC
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x000170E1 File Offset: 0x000152E1
		public unsafe float RotationForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000F7324 File Offset: 0x000F5524
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x000170FC File Offset: 0x000152FC
		public unsafe Transform CuntAssFuckingBitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_CuntAssFuckingBitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_CuntAssFuckingBitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_TargetRotation;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_RotationForce;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_CuntAssFuckingBitch;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
