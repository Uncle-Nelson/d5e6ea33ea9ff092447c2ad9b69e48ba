using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C1 RID: 961
	[Serializable]
	public class CheckpointInstance : Object
	{
		// Token: 0x06004AE6 RID: 19174 RVA: 0x0016AD0C File Offset: 0x00168F0C
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointInstance()
		{
			Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr);
			CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MIN_ACTIVATION_DISTANCE");
			CheckpointInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Location");
			CheckpointInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Members");
			CheckpointInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "StartTime");
			CheckpointInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "EndTime");
			CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "IntensityRequirement");
			CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			CheckpointInstance.NativeFieldInfoPtr_checkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "checkPoint");
			CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "<activeCheckpoint>k__BackingField");
			CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672585);
			CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672586);
			CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672587);
			CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672588);
			CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672589);
			CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672590);
			CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672591);
			CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100672592);
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0016AE90 File Offset: 0x00169090
		// (set) Token: 0x06004AE8 RID: 19176 RVA: 0x0016AED0 File Offset: 0x001690D0
		public unsafe RoadCheckpoint activeCheckpoint
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0016AF14 File Offset: 0x00169114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164651, RefRangeEnd = 164652, XrefRangeStart = 164623, XrefRangeEnd = 164651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x0016AF48 File Offset: 0x00169148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164690, RefRangeEnd = 164691, XrefRangeStart = 164652, XrefRangeEnd = 164690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x0016AF7C File Offset: 0x0016917C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164712, RefRangeEnd = 164714, XrefRangeStart = 164691, XrefRangeEnd = 164712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DistanceRequirementsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0016AFB8 File Offset: 0x001691B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164714, XrefRangeEnd = 164721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x0016AFEC File Offset: 0x001691EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164751, RefRangeEnd = 164752, XrefRangeStart = 164721, XrefRangeEnd = 164751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0016B020 File Offset: 0x00169220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164752, XrefRangeEnd = 164753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00024140 File Offset: 0x00022340
		public CheckpointInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x0016B05C File Offset: 0x0016925C
		// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x00024149 File Offset: 0x00022349
		public unsafe static float MIN_ACTIVATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x0016B078 File Offset: 0x00169278
		// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x00024157 File Offset: 0x00022357
		public unsafe CheckpointManager.ECheckpointLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location)) = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x0016B0A0 File Offset: 0x001692A0
		// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x00024172 File Offset: 0x00022372
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x0016B0C8 File Offset: 0x001692C8
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x0002418D File Offset: 0x0002238D
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x0016B0F0 File Offset: 0x001692F0
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x000241A8 File Offset: 0x000223A8
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x0016B118 File Offset: 0x00169318
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x000241C3 File Offset: 0x000223C3
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x0016B140 File Offset: 0x00169340
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x000241DE File Offset: 0x000223DE
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x0016B168 File Offset: 0x00169368
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x000241F9 File Offset: 0x000223F9
		public unsafe RoadCheckpoint checkPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x0016B198 File Offset: 0x00169398
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x00024218 File Offset: 0x00022418
		public unsafe RoadCheckpoint _activeCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeFieldInfoPtr_checkPoint;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeFieldInfoPtr__activeCheckpoint_k__BackingField;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
