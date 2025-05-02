using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000450 RID: 1104
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x06005FCC RID: 24524 RVA: 0x001B7638 File Offset: 0x001B5838
		// Note: this type is marked as 'beforefieldinit'.
		static AverageAcceleration()
		{
			Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AverageAcceleration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr);
			AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "<Acceleration>k__BackingField");
			AverageAcceleration.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "Rb");
			AverageAcceleration.NativeFieldInfoPtr_TimeWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "TimeWindow");
			AverageAcceleration.NativeFieldInfoPtr_accelerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "accelerations");
			AverageAcceleration.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "currentIndex");
			AverageAcceleration.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "timer");
			AverageAcceleration.NativeFieldInfoPtr_prevVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "prevVelocity");
			AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675514);
			AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675515);
			AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675516);
			AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675517);
			AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675518);
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06005FCD RID: 24525 RVA: 0x001B7758 File Offset: 0x001B5958
		// (set) Token: 0x06005FCE RID: 24526 RVA: 0x001B7794 File Offset: 0x001B5994
		public unsafe Vector3 Acceleration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x001B77D4 File Offset: 0x001B59D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198791, XrefRangeEnd = 198812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x001B7808 File Offset: 0x001B5A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198812, XrefRangeEnd = 198822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x001B783C File Offset: 0x001B5A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198822, XrefRangeEnd = 198825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AverageAcceleration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x0002D343 File Offset: 0x0002B543
		public AverageAcceleration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06005FD3 RID: 24531 RVA: 0x001B7878 File Offset: 0x001B5A78
		// (set) Token: 0x06005FD4 RID: 24532 RVA: 0x0002D34C File Offset: 0x0002B54C
		public unsafe Vector3 _Acceleration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06005FD5 RID: 24533 RVA: 0x001B78A0 File Offset: 0x001B5AA0
		// (set) Token: 0x06005FD6 RID: 24534 RVA: 0x0002D367 File Offset: 0x0002B567
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06005FD7 RID: 24535 RVA: 0x001B78D0 File Offset: 0x001B5AD0
		// (set) Token: 0x06005FD8 RID: 24536 RVA: 0x0002D386 File Offset: 0x0002B586
		public unsafe float TimeWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow)) = value;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x001B78F8 File Offset: 0x001B5AF8
		// (set) Token: 0x06005FDA RID: 24538 RVA: 0x0002D3A1 File Offset: 0x0002B5A1
		public unsafe Il2CppStructArray<Vector3> accelerations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06005FDB RID: 24539 RVA: 0x001B7928 File Offset: 0x001B5B28
		// (set) Token: 0x06005FDC RID: 24540 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06005FDD RID: 24541 RVA: 0x001B7950 File Offset: 0x001B5B50
		// (set) Token: 0x06005FDE RID: 24542 RVA: 0x0002D3DB File Offset: 0x0002B5DB
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x001B7978 File Offset: 0x001B5B78
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x0002D3F6 File Offset: 0x0002B5F6
		public unsafe Vector3 prevVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity)) = value;
			}
		}

		// Token: 0x04004172 RID: 16754
		private static readonly IntPtr NativeFieldInfoPtr__Acceleration_k__BackingField;

		// Token: 0x04004173 RID: 16755
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04004174 RID: 16756
		private static readonly IntPtr NativeFieldInfoPtr_TimeWindow;

		// Token: 0x04004175 RID: 16757
		private static readonly IntPtr NativeFieldInfoPtr_accelerations;

		// Token: 0x04004176 RID: 16758
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04004177 RID: 16759
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04004178 RID: 16760
		private static readonly IntPtr NativeFieldInfoPtr_prevVelocity;

		// Token: 0x04004179 RID: 16761
		private static readonly IntPtr NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0;

		// Token: 0x0400417A RID: 16762
		private static readonly IntPtr NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0;

		// Token: 0x0400417B RID: 16763
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400417C RID: 16764
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400417D RID: 16765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
