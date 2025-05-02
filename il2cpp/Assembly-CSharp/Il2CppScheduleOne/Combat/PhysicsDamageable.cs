using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000496 RID: 1174
	public class PhysicsDamageable : MonoBehaviour
	{
		// Token: 0x06006560 RID: 25952 RVA: 0x001C99A4 File Offset: 0x001C7BA4
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsDamageable()
		{
			Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PhysicsDamageable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr);
			PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "VELOCITY_HISTORY_LENGTH");
			PhysicsDamageable.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "Rb");
			PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "ForceMultiplier");
			PhysicsDamageable.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "impactHistory");
			PhysicsDamageable.NativeFieldInfoPtr_onImpacted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "onImpacted");
			PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "<averageVelocity>k__BackingField");
			PhysicsDamageable.NativeFieldInfoPtr_velocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "velocityHistory");
			PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676121);
			PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676122);
			PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676123);
			PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676124);
			PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676125);
			PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676126);
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x001C9AD8 File Offset: 0x001C7CD8
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x001C9B14 File Offset: 0x001C7D14
		public unsafe Vector3 averageVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205945, RefRangeEnd = 205946, XrefRangeStart = 205945, XrefRangeEnd = 205945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x001C9B54 File Offset: 0x001C7D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205946, XrefRangeEnd = 205954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x001C9B88 File Offset: 0x001C7D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205954, RefRangeEnd = 205955, XrefRangeStart = 205954, XrefRangeEnd = 205954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x001C9BD8 File Offset: 0x001C7DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205955, XrefRangeEnd = 205969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x001C9C28 File Offset: 0x001C7E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205969, XrefRangeEnd = 205986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsDamageable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x0002FF3E File Offset: 0x0002E13E
		public PhysicsDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06006568 RID: 25960 RVA: 0x001C9C64 File Offset: 0x001C7E64
		// (set) Token: 0x06006569 RID: 25961 RVA: 0x0002FF47 File Offset: 0x0002E147
		public unsafe static int VELOCITY_HISTORY_LENGTH
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&value));
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600656A RID: 25962 RVA: 0x001C9C80 File Offset: 0x001C7E80
		// (set) Token: 0x0600656B RID: 25963 RVA: 0x0002FF55 File Offset: 0x0002E155
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600656C RID: 25964 RVA: 0x001C9CB0 File Offset: 0x001C7EB0
		// (set) Token: 0x0600656D RID: 25965 RVA: 0x0002FF74 File Offset: 0x0002E174
		public unsafe float ForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier)) = value;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600656E RID: 25966 RVA: 0x001C9CD8 File Offset: 0x001C7ED8
		// (set) Token: 0x0600656F RID: 25967 RVA: 0x0002FF8F File Offset: 0x0002E18F
		public unsafe List<int> impactHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06006570 RID: 25968 RVA: 0x001C9D08 File Offset: 0x001C7F08
		// (set) Token: 0x06006571 RID: 25969 RVA: 0x0002FFAE File Offset: 0x0002E1AE
		public unsafe Action<Impact> onImpacted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Impact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x001C9D38 File Offset: 0x001C7F38
		// (set) Token: 0x06006573 RID: 25971 RVA: 0x0002FFCD File Offset: 0x0002E1CD
		public unsafe Vector3 _averageVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06006574 RID: 25972 RVA: 0x001C9D60 File Offset: 0x001C7F60
		// (set) Token: 0x06006575 RID: 25973 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		public unsafe List<Vector3> velocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004531 RID: 17713
		private static readonly IntPtr NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH;

		// Token: 0x04004532 RID: 17714
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04004533 RID: 17715
		private static readonly IntPtr NativeFieldInfoPtr_ForceMultiplier;

		// Token: 0x04004534 RID: 17716
		private static readonly IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04004535 RID: 17717
		private static readonly IntPtr NativeFieldInfoPtr_onImpacted;

		// Token: 0x04004536 RID: 17718
		private static readonly IntPtr NativeFieldInfoPtr__averageVelocity_k__BackingField;

		// Token: 0x04004537 RID: 17719
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistory;

		// Token: 0x04004538 RID: 17720
		private static readonly IntPtr NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0;

		// Token: 0x04004539 RID: 17721
		private static readonly IntPtr NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0;

		// Token: 0x0400453A RID: 17722
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400453B RID: 17723
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400453C RID: 17724
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400453D RID: 17725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
