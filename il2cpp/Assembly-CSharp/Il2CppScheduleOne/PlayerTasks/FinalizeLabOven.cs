using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000206 RID: 518
	public class FinalizeLabOven : Task
	{
		// Token: 0x06002B12 RID: 11026 RVA: 0x000F8EE4 File Offset: 0x000F70E4
		// Note: this type is marked as 'beforefieldinit'.
		static FinalizeLabOven()
		{
			Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinalizeLabOven");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr);
			FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "MAX_DISTANCE_FROM_IMPACT_POINT");
			FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "SMASH_VELOCITY_THRESHOLD");
			FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "REQUIRED_IMPACTS");
			FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<Oven>k__BackingField");
			FinalizeLabOven.NativeFieldInfoPtr_startSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "startSequence");
			FinalizeLabOven.NativeFieldInfoPtr_hammer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "hammer");
			FinalizeLabOven.NativeFieldInfoPtr_impactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "impactCount");
			FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "timeSinceLastImpact");
			FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668124);
			FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668125);
			FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668126);
			FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668127);
			FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668128);
			FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668129);
			FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668130);
			FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668131);
			FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668132);
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000F9068 File Offset: 0x000F7268
		// (set) Token: 0x06002B14 RID: 11028 RVA: 0x000F90A8 File Offset: 0x000F72A8
		public unsafe LabOven Oven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43173, RefRangeEnd = 43174, XrefRangeStart = 43173, XrefRangeEnd = 43174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000F90EC File Offset: 0x000F72EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121537, RefRangeEnd = 121538, XrefRangeStart = 121516, XrefRangeEnd = 121537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalizeLabOven(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000F9138 File Offset: 0x000F7338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121538, XrefRangeEnd = 121540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000F9174 File Offset: 0x000F7374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121540, XrefRangeEnd = 121572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000F91B0 File Offset: 0x000F73B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121572, XrefRangeEnd = 121577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000F91F0 File Offset: 0x000F73F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121577, XrefRangeEnd = 121603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Collision(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000F9234 File Offset: 0x000F7434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121630, RefRangeEnd = 121631, XrefRangeStart = 121603, XrefRangeEnd = 121630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000F9268 File Offset: 0x000F7468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121631, XrefRangeEnd = 121636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00017556 File Offset: 0x00015756
		public FinalizeLabOven(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000F92A8 File Offset: 0x000F74A8
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x0001755F File Offset: 0x0001575F
		public unsafe static float MAX_DISTANCE_FROM_IMPACT_POINT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000F92C4 File Offset: 0x000F74C4
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x0001756D File Offset: 0x0001576D
		public unsafe float SMASH_VELOCITY_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000F92EC File Offset: 0x000F74EC
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00017588 File Offset: 0x00015788
		public unsafe static int REQUIRED_IMPACTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000F9308 File Offset: 0x000F7508
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x00017596 File Offset: 0x00015796
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000F9338 File Offset: 0x000F7538
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x000175B5 File Offset: 0x000157B5
		public unsafe Coroutine startSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000F9368 File Offset: 0x000F7568
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x000175D4 File Offset: 0x000157D4
		public unsafe LabOvenHammer hammer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenHammer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000F9398 File Offset: 0x000F7598
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x000175F3 File Offset: 0x000157F3
		public unsafe int impactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount)) = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000F93C0 File Offset: 0x000F75C0
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x0001760E File Offset: 0x0001580E
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr_REQUIRED_IMPACTS;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeFieldInfoPtr_startSequence;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeFieldInfoPtr_hammer;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeFieldInfoPtr_impactCount;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_Collision_Public_Void_Collision_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_Shatter_Private_Void_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008E1 RID: 2273
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<<Shatter>g__Routine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C47E RID: 50302 RVA: 0x002FDCE0 File Offset: 0x002FBEE0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<<Shatter>g__Routine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668133);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668134);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668135);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668136);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668137);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668138);
			}

			// Token: 0x0600C47F RID: 50303 RVA: 0x002FDDC0 File Offset: 0x002FBFC0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C480 RID: 50304 RVA: 0x002FDE08 File Offset: 0x002FC008
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C481 RID: 50305 RVA: 0x002FDE3C File Offset: 0x002FC03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121485, XrefRangeEnd = 121490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D55 RID: 15701
			// (get) Token: 0x0600C482 RID: 50306 RVA: 0x002FDE78 File Offset: 0x002FC078
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C483 RID: 50307 RVA: 0x002FDEB8 File Offset: 0x002FC0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121490, XrefRangeEnd = 121495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D56 RID: 15702
			// (get) Token: 0x0600C484 RID: 50308 RVA: 0x002FDEEC File Offset: 0x002FC0EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C485 RID: 50309 RVA: 0x0005FA0B File Offset: 0x0005DC0B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D52 RID: 15698
			// (get) Token: 0x0600C486 RID: 50310 RVA: 0x002FDF2C File Offset: 0x002FC12C
			// (set) Token: 0x0600C487 RID: 50311 RVA: 0x0005FA14 File Offset: 0x0005DC14
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D53 RID: 15699
			// (get) Token: 0x0600C488 RID: 50312 RVA: 0x002FDF54 File Offset: 0x002FC154
			// (set) Token: 0x0600C489 RID: 50313 RVA: 0x0005FA2F File Offset: 0x0005DC2F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D54 RID: 15700
			// (get) Token: 0x0600C48A RID: 50314 RVA: 0x002FDF84 File Offset: 0x002FC184
			// (set) Token: 0x0600C48B RID: 50315 RVA: 0x0005FA4E File Offset: 0x0005DC4E
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008530 RID: 34096
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008531 RID: 34097
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008532 RID: 34098
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008533 RID: 34099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008534 RID: 34100
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008535 RID: 34101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008536 RID: 34102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008537 RID: 34103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008538 RID: 34104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008E2 RID: 2274
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<StartSequence>d__14")]
		public sealed class _StartSequence_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600C48C RID: 50316 RVA: 0x002FDFB4 File Offset: 0x002FC1B4
			// Note: this type is marked as 'beforefieldinit'.
			static _StartSequence_d__14()
			{
				Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<StartSequence>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr);
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>1__state");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>2__current");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>4__this");
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668139);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668140);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668141);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668142);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668143);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668144);
			}

			// Token: 0x0600C48D RID: 50317 RVA: 0x002FE094 File Offset: 0x002FC294
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartSequence_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C48E RID: 50318 RVA: 0x002FE0DC File Offset: 0x002FC2DC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C48F RID: 50319 RVA: 0x002FE110 File Offset: 0x002FC310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121495, XrefRangeEnd = 121511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D5A RID: 15706
			// (get) Token: 0x0600C490 RID: 50320 RVA: 0x002FE14C File Offset: 0x002FC34C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C491 RID: 50321 RVA: 0x002FE18C File Offset: 0x002FC38C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121511, XrefRangeEnd = 121516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D5B RID: 15707
			// (get) Token: 0x0600C492 RID: 50322 RVA: 0x002FE1C0 File Offset: 0x002FC3C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C493 RID: 50323 RVA: 0x0005FA6D File Offset: 0x0005DC6D
			public _StartSequence_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D57 RID: 15703
			// (get) Token: 0x0600C494 RID: 50324 RVA: 0x002FE200 File Offset: 0x002FC400
			// (set) Token: 0x0600C495 RID: 50325 RVA: 0x0005FA76 File Offset: 0x0005DC76
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D58 RID: 15704
			// (get) Token: 0x0600C496 RID: 50326 RVA: 0x002FE228 File Offset: 0x002FC428
			// (set) Token: 0x0600C497 RID: 50327 RVA: 0x0005FA91 File Offset: 0x0005DC91
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D59 RID: 15705
			// (get) Token: 0x0600C498 RID: 50328 RVA: 0x002FE258 File Offset: 0x002FC458
			// (set) Token: 0x0600C499 RID: 50329 RVA: 0x0005FAB0 File Offset: 0x0005DCB0
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008539 RID: 34105
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400853A RID: 34106
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400853B RID: 34107
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400853C RID: 34108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400853D RID: 34109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400853E RID: 34110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400853F RID: 34111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008540 RID: 34112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008541 RID: 34113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
