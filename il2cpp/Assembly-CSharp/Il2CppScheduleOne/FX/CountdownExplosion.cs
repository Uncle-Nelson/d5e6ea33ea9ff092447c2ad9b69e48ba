using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F6 RID: 1014
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x0600543F RID: 21567 RVA: 0x0018B860 File Offset: 0x00189A60
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownExplosion()
		{
			Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "CountdownExplosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr);
			CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "COUNTDOWN");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MAX");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MIN");
			CountdownExplosion.NativeFieldInfoPtr_TickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TickSound");
			CountdownExplosion.NativeFieldInfoPtr_countdownRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "countdownRoutine");
			CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673797);
			CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673798);
			CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673799);
			CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673800);
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0018B944 File Offset: 0x00189B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179996, RefRangeEnd = 179997, XrefRangeStart = 179984, XrefRangeEnd = 179996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0018B978 File Offset: 0x00189B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17709, RefRangeEnd = 17710, XrefRangeStart = 17709, XrefRangeEnd = 17710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0018B9AC File Offset: 0x00189BAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownExplosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0018B9E8 File Offset: 0x00189BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179997, XrefRangeEnd = 180002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x000284FE File Offset: 0x000266FE
		public CountdownExplosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x0018BA28 File Offset: 0x00189C28
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x00028507 File Offset: 0x00026707
		public unsafe static float COUNTDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x0018BA44 File Offset: 0x00189C44
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x00028515 File Offset: 0x00026715
		public unsafe static float TICK_SPACING_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x0018BA60 File Offset: 0x00189C60
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x00028523 File Offset: 0x00026723
		public unsafe static float TICK_SPACING_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x0018BA7C File Offset: 0x00189C7C
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x00028531 File Offset: 0x00026731
		public unsafe AudioSourceController TickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x0018BAAC File Offset: 0x00189CAC
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x00028550 File Offset: 0x00026750
		public unsafe Coroutine countdownRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeFieldInfoPtr_COUNTDOWN;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MAX;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MIN;

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeFieldInfoPtr_TickSound;

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeFieldInfoPtr_countdownRoutine;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdown_Public_Void_0;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009B7 RID: 2487
		[ObfuscatedName("ScheduleOne.FX.CountdownExplosion+<<Trigger>g__Routine|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CBFF RID: 52223 RVA: 0x00313948 File Offset: 0x00311B48
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique()
			{
				Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "<<Trigger>g__Routine|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<timeUntilNextTick>5__2");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673801);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673802);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673803);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673804);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673805);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673806);
			}

			// Token: 0x0600CC00 RID: 52224 RVA: 0x00313A50 File Offset: 0x00311C50
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC01 RID: 52225 RVA: 0x00313A98 File Offset: 0x00311C98
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC02 RID: 52226 RVA: 0x00313ACC File Offset: 0x00311CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179966, XrefRangeEnd = 179979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F92 RID: 16274
			// (get) Token: 0x0600CC03 RID: 52227 RVA: 0x00313B08 File Offset: 0x00311D08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC04 RID: 52228 RVA: 0x00313B48 File Offset: 0x00311D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179979, XrefRangeEnd = 179984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F93 RID: 16275
			// (get) Token: 0x0600CC05 RID: 52229 RVA: 0x00313B7C File Offset: 0x00311D7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC06 RID: 52230 RVA: 0x000633C6 File Offset: 0x000615C6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8D RID: 16269
			// (get) Token: 0x0600CC07 RID: 52231 RVA: 0x00313BBC File Offset: 0x00311DBC
			// (set) Token: 0x0600CC08 RID: 52232 RVA: 0x000633CF File Offset: 0x000615CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F8E RID: 16270
			// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x00313BE4 File Offset: 0x00311DE4
			// (set) Token: 0x0600CC0A RID: 52234 RVA: 0x000633EA File Offset: 0x000615EA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x00313C14 File Offset: 0x00311E14
			// (set) Token: 0x0600CC0C RID: 52236 RVA: 0x00063409 File Offset: 0x00061609
			public unsafe CountdownExplosion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0600CC0D RID: 52237 RVA: 0x00313C44 File Offset: 0x00311E44
			// (set) Token: 0x0600CC0E RID: 52238 RVA: 0x00063428 File Offset: 0x00061628
			public unsafe float _timeUntilNextTick_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2)) = value;
				}
			}

			// Token: 0x17003F91 RID: 16273
			// (get) Token: 0x0600CC0F RID: 52239 RVA: 0x00313C6C File Offset: 0x00311E6C
			// (set) Token: 0x0600CC10 RID: 52240 RVA: 0x00063443 File Offset: 0x00061643
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040089EB RID: 35307
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089EC RID: 35308
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089ED RID: 35309
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089EE RID: 35310
			private static readonly IntPtr NativeFieldInfoPtr__timeUntilNextTick_5__2;

			// Token: 0x040089EF RID: 35311
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040089F0 RID: 35312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089F1 RID: 35313
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089F2 RID: 35314
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089F3 RID: 35315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089F4 RID: 35316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089F5 RID: 35317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
