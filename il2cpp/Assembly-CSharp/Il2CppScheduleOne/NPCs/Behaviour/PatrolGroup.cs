using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035B RID: 859
	public class PatrolGroup : Il2CppSystem.Object
	{
		// Token: 0x060041FF RID: 16895 RVA: 0x0014A138 File Offset: 0x00148338
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolGroup()
		{
			Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PatrolGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr);
			PatrolGroup.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Members");
			PatrolGroup.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Route");
			PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "CurrentWaypoint");
			PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671325);
			PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671326);
			PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671327);
			PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671328);
			PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671329);
			PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671330);
			PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100671331);
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x0014A230 File Offset: 0x00148430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152040, RefRangeEnd = 152041, XrefRangeStart = 152031, XrefRangeEnd = 152040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup(FootPatrolRoute route) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x0014A27C File Offset: 0x0014847C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 152076, RefRangeEnd = 152080, XrefRangeStart = 152041, XrefRangeEnd = 152076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDestination(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x0014A2CC File Offset: 0x001484CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152105, RefRangeEnd = 152107, XrefRangeStart = 152080, XrefRangeEnd = 152105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisbandGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x0014A300 File Offset: 0x00148500
		[CallerCount(0)]
		public unsafe void AdvanceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0014A334 File Offset: 0x00148534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152107, XrefRangeEnd = 152118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMemberOffset(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0014A384 File Offset: 0x00148584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152118, XrefRangeEnd = 152126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x0014A3C0 File Offset: 0x001485C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152126, XrefRangeEnd = 152145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x000206EF File Offset: 0x0001E8EF
		public PatrolGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x0014A3FC File Offset: 0x001485FC
		// (set) Token: 0x06004209 RID: 16905 RVA: 0x000206F8 File Offset: 0x0001E8F8
		public unsafe List<NPC> Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x0014A42C File Offset: 0x0014862C
		// (set) Token: 0x0600420B RID: 16907 RVA: 0x00020717 File Offset: 0x0001E917
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x0014A45C File Offset: 0x0014865C
		// (set) Token: 0x0600420D RID: 16909 RVA: 0x00020736 File Offset: 0x0001E936
		public unsafe int CurrentWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_DisbandGroup_Public_Void_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceGroup_Public_Void_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Boolean_0;
	}
}
