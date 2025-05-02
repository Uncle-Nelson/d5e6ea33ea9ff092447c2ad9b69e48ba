using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000749 RID: 1865
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x0600AEE8 RID: 44776 RVA: 0x002BA4E0 File Offset: 0x002B86E0
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenHammer()
		{
			Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenHammer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr);
			LabOvenHammer.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Draggable");
			LabOvenHammer.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Constraint");
			LabOvenHammer.NativeFieldInfoPtr_Rotator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Rotator");
			LabOvenHammer.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "CoM");
			LabOvenHammer.NativeFieldInfoPtr_ImpactPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "ImpactPoint");
			LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "VelocityCalculator");
			LabOvenHammer.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinHeight");
			LabOvenHammer.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxHeight");
			LabOvenHammer.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinAngle");
			LabOvenHammer.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxAngle");
			LabOvenHammer.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "onCollision");
			LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684804);
			LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684805);
			LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684806);
			LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100684807);
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x002BA63C File Offset: 0x002B883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302644, XrefRangeEnd = 302646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x002BA670 File Offset: 0x002B8870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302646, XrefRangeEnd = 302652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEEB RID: 44779 RVA: 0x002BA6A4 File Offset: 0x002B88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302652, XrefRangeEnd = 302655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x002BA6E8 File Offset: 0x002B88E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302655, XrefRangeEnd = 302656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenHammer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x00055F1B File Offset: 0x0005411B
		public LabOvenHammer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600AEEE RID: 44782 RVA: 0x002BA724 File Offset: 0x002B8924
		// (set) Token: 0x0600AEEF RID: 44783 RVA: 0x00055F24 File Offset: 0x00054124
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600AEF0 RID: 44784 RVA: 0x002BA754 File Offset: 0x002B8954
		// (set) Token: 0x0600AEF1 RID: 44785 RVA: 0x00055F43 File Offset: 0x00054143
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600AEF2 RID: 44786 RVA: 0x002BA784 File Offset: 0x002B8984
		// (set) Token: 0x0600AEF3 RID: 44787 RVA: 0x00055F62 File Offset: 0x00054162
		public unsafe RotateRigidbodyToTarget Rotator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotateRigidbodyToTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600AEF4 RID: 44788 RVA: 0x002BA7B4 File Offset: 0x002B89B4
		// (set) Token: 0x0600AEF5 RID: 44789 RVA: 0x00055F81 File Offset: 0x00054181
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600AEF6 RID: 44790 RVA: 0x002BA7E4 File Offset: 0x002B89E4
		// (set) Token: 0x0600AEF7 RID: 44791 RVA: 0x00055FA0 File Offset: 0x000541A0
		public unsafe Transform ImpactPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x002BA814 File Offset: 0x002B8A14
		// (set) Token: 0x0600AEF9 RID: 44793 RVA: 0x00055FBF File Offset: 0x000541BF
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x002BA844 File Offset: 0x002B8A44
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x00055FDE File Offset: 0x000541DE
		public unsafe float MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight)) = value;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x002BA86C File Offset: 0x002B8A6C
		// (set) Token: 0x0600AEFD RID: 44797 RVA: 0x00055FF9 File Offset: 0x000541F9
		public unsafe float MaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight)) = value;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x002BA894 File Offset: 0x002B8A94
		// (set) Token: 0x0600AEFF RID: 44799 RVA: 0x00056014 File Offset: 0x00054214
		public unsafe float MinAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle)) = value;
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002BA8BC File Offset: 0x002B8ABC
		// (set) Token: 0x0600AF01 RID: 44801 RVA: 0x0005602F File Offset: 0x0005422F
		public unsafe float MaxAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle)) = value;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x002BA8E4 File Offset: 0x002B8AE4
		// (set) Token: 0x0600AF03 RID: 44803 RVA: 0x0005604A File Offset: 0x0005424A
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040075BD RID: 30141
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040075BE RID: 30142
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x040075BF RID: 30143
		private static readonly IntPtr NativeFieldInfoPtr_Rotator;

		// Token: 0x040075C0 RID: 30144
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x040075C1 RID: 30145
		private static readonly IntPtr NativeFieldInfoPtr_ImpactPoint;

		// Token: 0x040075C2 RID: 30146
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040075C3 RID: 30147
		private static readonly IntPtr NativeFieldInfoPtr_MinHeight;

		// Token: 0x040075C4 RID: 30148
		private static readonly IntPtr NativeFieldInfoPtr_MaxHeight;

		// Token: 0x040075C5 RID: 30149
		private static readonly IntPtr NativeFieldInfoPtr_MinAngle;

		// Token: 0x040075C6 RID: 30150
		private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;

		// Token: 0x040075C7 RID: 30151
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x040075C8 RID: 30152
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075C9 RID: 30153
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040075CA RID: 30154
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040075CB RID: 30155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
