using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000551 RID: 1361
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x060077F8 RID: 30712 RVA: 0x00207B14 File Offset: 0x00205D14
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr);
			SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "Velocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "SampleLength");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "MaxReasonableVelocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "VelocityHistory");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "maxSamples");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "lastFramePosition");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "zeroOut");
			SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678382);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678383);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678384);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678385);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678386);
			SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678387);
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00207C48 File Offset: 0x00205E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232409, XrefRangeEnd = 232411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00207C7C File Offset: 0x00205E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232434, RefRangeEnd = 232435, XrefRangeStart = 232411, XrefRangeEnd = 232434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00207CB8 File Offset: 0x00205EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232446, RefRangeEnd = 232447, XrefRangeStart = 232435, XrefRangeEnd = 232446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAverageVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00207CF4 File Offset: 0x00205EF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 232453, RefRangeEnd = 232456, XrefRangeStart = 232447, XrefRangeEnd = 232453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00207D28 File Offset: 0x00205F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232456, XrefRangeEnd = 232468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZeroOut(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x00207D68 File Offset: 0x00205F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00038D65 File Offset: 0x00036F65
		public SmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x06007800 RID: 30720 RVA: 0x00207DA4 File Offset: 0x00205FA4
		// (set) Token: 0x06007801 RID: 30721 RVA: 0x00038D6E File Offset: 0x00036F6E
		public unsafe Vector3 Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity)) = value;
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x06007802 RID: 30722 RVA: 0x00207DCC File Offset: 0x00205FCC
		// (set) Token: 0x06007803 RID: 30723 RVA: 0x00038D89 File Offset: 0x00036F89
		public unsafe float SampleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength)) = value;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x06007804 RID: 30724 RVA: 0x00207DF4 File Offset: 0x00205FF4
		// (set) Token: 0x06007805 RID: 30725 RVA: 0x00038DA4 File Offset: 0x00036FA4
		public unsafe float MaxReasonableVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity)) = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x00207E1C File Offset: 0x0020601C
		// (set) Token: 0x06007807 RID: 30727 RVA: 0x00038DBF File Offset: 0x00036FBF
		public unsafe List<Tuple<Vector3, float>> VelocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<Vector3, float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x00207E4C File Offset: 0x0020604C
		// (set) Token: 0x06007809 RID: 30729 RVA: 0x00038DDE File Offset: 0x00036FDE
		public unsafe int maxSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples)) = value;
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x00207E74 File Offset: 0x00206074
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x00038DF9 File Offset: 0x00036FF9
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x00207E9C File Offset: 0x0020609C
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x00038E14 File Offset: 0x00037014
		public unsafe bool zeroOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut)) = value;
			}
		}

		// Token: 0x040051D0 RID: 20944
		private static readonly IntPtr NativeFieldInfoPtr_Velocity;

		// Token: 0x040051D1 RID: 20945
		private static readonly IntPtr NativeFieldInfoPtr_SampleLength;

		// Token: 0x040051D2 RID: 20946
		private static readonly IntPtr NativeFieldInfoPtr_MaxReasonableVelocity;

		// Token: 0x040051D3 RID: 20947
		private static readonly IntPtr NativeFieldInfoPtr_VelocityHistory;

		// Token: 0x040051D4 RID: 20948
		private static readonly IntPtr NativeFieldInfoPtr_maxSamples;

		// Token: 0x040051D5 RID: 20949
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040051D6 RID: 20950
		private static readonly IntPtr NativeFieldInfoPtr_zeroOut;

		// Token: 0x040051D7 RID: 20951
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051D8 RID: 20952
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040051D9 RID: 20953
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0;

		// Token: 0x040051DA RID: 20954
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Public_Void_0;

		// Token: 0x040051DB RID: 20955
		private static readonly IntPtr NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0;

		// Token: 0x040051DC RID: 20956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA6 RID: 2726
		[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D33B RID: 54075 RVA: 0x00327C08 File Offset: 0x00325E08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "duration");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678388);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678389);
			}

			// Token: 0x0600D33C RID: 54076 RVA: 0x00327C84 File Offset: 0x00325E84
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D33D RID: 54077 RVA: 0x00327CC0 File Offset: 0x00325EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232404, XrefRangeEnd = 232409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D33E RID: 54078 RVA: 0x00066D14 File Offset: 0x00064F14
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004181 RID: 16769
			// (get) Token: 0x0600D33F RID: 54079 RVA: 0x00327D00 File Offset: 0x00325F00
			// (set) Token: 0x0600D340 RID: 54080 RVA: 0x00066D1D File Offset: 0x00064F1D
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004182 RID: 16770
			// (get) Token: 0x0600D341 RID: 54081 RVA: 0x00327D28 File Offset: 0x00325F28
			// (set) Token: 0x0600D342 RID: 54082 RVA: 0x00066D38 File Offset: 0x00064F38
			public unsafe SmoothedVelocityCalculator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E56 RID: 36438
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008E57 RID: 36439
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E58 RID: 36440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E59 RID: 36441
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C63 RID: 3171
			[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0+<<ZeroOut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E449 RID: 58441 RVA: 0x00358A40 File Offset: 0x00356C40
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<<ZeroOut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678390);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678391);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678392);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678393);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678394);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678395);
				}

				// Token: 0x0600E44A RID: 58442 RVA: 0x00358B20 File Offset: 0x00356D20
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E44B RID: 58443 RVA: 0x00358B68 File Offset: 0x00356D68
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E44C RID: 58444 RVA: 0x00358B9C File Offset: 0x00356D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232394, XrefRangeEnd = 232399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046E6 RID: 18150
				// (get) Token: 0x0600E44D RID: 58445 RVA: 0x00358BD8 File Offset: 0x00356DD8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E44E RID: 58446 RVA: 0x00358C18 File Offset: 0x00356E18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232399, XrefRangeEnd = 232404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046E7 RID: 18151
				// (get) Token: 0x0600E44F RID: 58447 RVA: 0x00358C4C File Offset: 0x00356E4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E450 RID: 58448 RVA: 0x0006F4EC File Offset: 0x0006D6EC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046E3 RID: 18147
				// (get) Token: 0x0600E451 RID: 58449 RVA: 0x00358C8C File Offset: 0x00356E8C
				// (set) Token: 0x0600E452 RID: 58450 RVA: 0x0006F4F5 File Offset: 0x0006D6F5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046E4 RID: 18148
				// (get) Token: 0x0600E453 RID: 58451 RVA: 0x00358CB4 File Offset: 0x00356EB4
				// (set) Token: 0x0600E454 RID: 58452 RVA: 0x0006F510 File Offset: 0x0006D710
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046E5 RID: 18149
				// (get) Token: 0x0600E455 RID: 58453 RVA: 0x00358CE4 File Offset: 0x00356EE4
				// (set) Token: 0x0600E456 RID: 58454 RVA: 0x0006F52F File Offset: 0x0006D72F
				public unsafe SmoothedVelocityCalculator.__c__DisplayClass11_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098B6 RID: 39094
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098B7 RID: 39095
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098B8 RID: 39096
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098B9 RID: 39097
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098BA RID: 39098
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098BB RID: 39099
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098BC RID: 39100
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098BD RID: 39101
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098BE RID: 39102
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
