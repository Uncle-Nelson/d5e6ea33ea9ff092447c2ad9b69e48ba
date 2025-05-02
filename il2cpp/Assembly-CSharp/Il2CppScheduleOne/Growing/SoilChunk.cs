using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055F RID: 1375
	public class SoilChunk : Clickable
	{
		// Token: 0x060078CE RID: 30926 RVA: 0x00209F98 File Offset: 0x00208198
		// Note: this type is marked as 'beforefieldinit'.
		static SoilChunk()
		{
			Il2CppClassPointerStore<SoilChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SoilChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr);
			SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<CurrentLerp>k__BackingField");
			SoilChunk.NativeFieldInfoPtr_EndTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "EndTransform");
			SoilChunk.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "LerpTime");
			SoilChunk.NativeFieldInfoPtr_localPos_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localPos_Start");
			SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localEulerAngles_Start");
			SoilChunk.NativeFieldInfoPtr_localScale_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localScale_Start");
			SoilChunk.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "lerpRoutine");
			SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678442);
			SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678443);
			SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678444);
			SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678445);
			SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678446);
			SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678447);
			SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678448);
			SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678449);
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x060078CF RID: 30927 RVA: 0x0020A0F4 File Offset: 0x002082F4
		// (set) Token: 0x060078D0 RID: 30928 RVA: 0x0020A130 File Offset: 0x00208330
		public unsafe float CurrentLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x0020A170 File Offset: 0x00208370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232852, XrefRangeEnd = 232858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x0020A1AC File Offset: 0x002083AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232873, RefRangeEnd = 232875, XrefRangeStart = 232858, XrefRangeEnd = 232873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLerpedTransform(float _lerp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x0020A1EC File Offset: 0x002083EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232875, XrefRangeEnd = 232884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x0020A238 File Offset: 0x00208438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232885, RefRangeEnd = 232886, XrefRangeStart = 232884, XrefRangeEnd = 232885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLerp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x0020A26C File Offset: 0x0020846C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232886, XrefRangeEnd = 232887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilChunk() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x0020A2A8 File Offset: 0x002084A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232887, XrefRangeEnd = 232892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x00039573 File Offset: 0x00037773
		public SoilChunk(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x060078D8 RID: 30936 RVA: 0x0020A2E8 File Offset: 0x002084E8
		// (set) Token: 0x060078D9 RID: 30937 RVA: 0x0003957C File Offset: 0x0003777C
		public unsafe float _CurrentLerp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField)) = value;
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x0020A310 File Offset: 0x00208510
		// (set) Token: 0x060078DB RID: 30939 RVA: 0x00039597 File Offset: 0x00037797
		public unsafe Transform EndTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x0020A340 File Offset: 0x00208540
		// (set) Token: 0x060078DD RID: 30941 RVA: 0x000395B6 File Offset: 0x000377B6
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x0020A368 File Offset: 0x00208568
		// (set) Token: 0x060078DF RID: 30943 RVA: 0x000395D1 File Offset: 0x000377D1
		public unsafe Vector3 localPos_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start)) = value;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x0020A390 File Offset: 0x00208590
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x000395EC File Offset: 0x000377EC
		public unsafe Vector3 localEulerAngles_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start)) = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x0020A3B8 File Offset: 0x002085B8
		// (set) Token: 0x060078E3 RID: 30947 RVA: 0x00039607 File Offset: 0x00037807
		public unsafe Vector3 localScale_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start)) = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x0020A3E0 File Offset: 0x002085E0
		// (set) Token: 0x060078E5 RID: 30949 RVA: 0x00039622 File Offset: 0x00037822
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005247 RID: 21063
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLerp_k__BackingField;

		// Token: 0x04005248 RID: 21064
		private static readonly IntPtr NativeFieldInfoPtr_EndTransform;

		// Token: 0x04005249 RID: 21065
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x0400524A RID: 21066
		private static readonly IntPtr NativeFieldInfoPtr_localPos_Start;

		// Token: 0x0400524B RID: 21067
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles_Start;

		// Token: 0x0400524C RID: 21068
		private static readonly IntPtr NativeFieldInfoPtr_localScale_Start;

		// Token: 0x0400524D RID: 21069
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x0400524E RID: 21070
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0;

		// Token: 0x0400524F RID: 21071
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0;

		// Token: 0x04005250 RID: 21072
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005251 RID: 21073
		private static readonly IntPtr NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0;

		// Token: 0x04005252 RID: 21074
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04005253 RID: 21075
		private static readonly IntPtr NativeMethodInfoPtr_StopLerp_Public_Void_0;

		// Token: 0x04005254 RID: 21076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005255 RID: 21077
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AA7 RID: 2727
		[ObfuscatedName("ScheduleOne.Growing.SoilChunk+<<StartClick>g__Lerp|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D343 RID: 54083 RVA: 0x00327D58 File Offset: 0x00325F58
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<<StartClick>g__Lerp|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<i>5__2");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678450);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678451);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678452);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678453);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678454);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678455);
			}

			// Token: 0x0600D344 RID: 54084 RVA: 0x00327E4C File Offset: 0x0032604C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D345 RID: 54085 RVA: 0x00327E94 File Offset: 0x00326094
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D346 RID: 54086 RVA: 0x00327EC8 File Offset: 0x003260C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232838, XrefRangeEnd = 232847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004187 RID: 16775
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x00327F04 File Offset: 0x00326104
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D348 RID: 54088 RVA: 0x00327F44 File Offset: 0x00326144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232847, XrefRangeEnd = 232852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004188 RID: 16776
			// (get) Token: 0x0600D349 RID: 54089 RVA: 0x00327F78 File Offset: 0x00326178
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D34A RID: 54090 RVA: 0x00066D57 File Offset: 0x00064F57
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004183 RID: 16771
			// (get) Token: 0x0600D34B RID: 54091 RVA: 0x00327FB8 File Offset: 0x003261B8
			// (set) Token: 0x0600D34C RID: 54092 RVA: 0x00066D60 File Offset: 0x00064F60
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004184 RID: 16772
			// (get) Token: 0x0600D34D RID: 54093 RVA: 0x00327FE0 File Offset: 0x003261E0
			// (set) Token: 0x0600D34E RID: 54094 RVA: 0x00066D7B File Offset: 0x00064F7B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004185 RID: 16773
			// (get) Token: 0x0600D34F RID: 54095 RVA: 0x00328010 File Offset: 0x00326210
			// (set) Token: 0x0600D350 RID: 54096 RVA: 0x00066D9A File Offset: 0x00064F9A
			public unsafe SoilChunk __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004186 RID: 16774
			// (get) Token: 0x0600D351 RID: 54097 RVA: 0x00328040 File Offset: 0x00326240
			// (set) Token: 0x0600D352 RID: 54098 RVA: 0x00066DB9 File Offset: 0x00064FB9
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04008E5A RID: 36442
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E5B RID: 36443
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E5C RID: 36444
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E5D RID: 36445
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04008E5E RID: 36446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E5F RID: 36447
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E60 RID: 36448
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E61 RID: 36449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E62 RID: 36450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E63 RID: 36451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
