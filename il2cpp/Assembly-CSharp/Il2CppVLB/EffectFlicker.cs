using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000080 RID: 128
	public class EffectFlicker : EffectAbstractBase
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x0008D3E8 File Offset: 0x0008B5E8
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFlicker()
		{
			Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFlicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr);
			EffectFlicker.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "ClassName");
			EffectFlicker.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "frequency");
			EffectFlicker.NativeFieldInfoPtr_performPauses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "performPauses");
			EffectFlicker.NativeFieldInfoPtr_flickeringDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "flickeringDuration");
			EffectFlicker.NativeFieldInfoPtr_pauseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "pauseDuration");
			EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "restoreIntensityOnPause");
			EffectFlicker.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "intensityAmplitude");
			EffectFlicker.NativeFieldInfoPtr_smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "smoothing");
			EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "m_CurrentAdditiveIntensity");
			EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664292);
			EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664293);
			EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664294);
			EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664295);
			EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664296);
			EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664297);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0008D544 File Offset: 0x0008B744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80165, XrefRangeEnd = 80177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0008D594 File Offset: 0x0008B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80177, XrefRangeEnd = 80184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0008D5D0 File Offset: 0x0008B7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80184, XrefRangeEnd = 80189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0008D610 File Offset: 0x0008B810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80189, XrefRangeEnd = 80194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoFlicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0008D650 File Offset: 0x0008B850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80199, RefRangeEnd = 80200, XrefRangeStart = 80194, XrefRangeEnd = 80199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expectedDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0008D6AC File Offset: 0x0008B8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80200, XrefRangeEnd = 80207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFlicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00007134 File Offset: 0x00005334
		public EffectFlicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0008D6E8 File Offset: 0x0008B8E8
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000713D File Offset: 0x0000533D
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFlicker.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFlicker.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0008D708 File Offset: 0x0008B908
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0000714F File Offset: 0x0000534F
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0008D730 File Offset: 0x0008B930
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0000716A File Offset: 0x0000536A
		public unsafe bool performPauses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0008D758 File Offset: 0x0008B958
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00007185 File Offset: 0x00005385
		public unsafe MinMaxRangeFloat flickeringDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0008D780 File Offset: 0x0008B980
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000071A0 File Offset: 0x000053A0
		public unsafe MinMaxRangeFloat pauseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0008D7A8 File Offset: 0x0008B9A8
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000071BB File Offset: 0x000053BB
		public unsafe bool restoreIntensityOnPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0008D7D0 File Offset: 0x0008B9D0
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000071D6 File Offset: 0x000053D6
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x000071F1 File Offset: 0x000053F1
		public unsafe float smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0008D820 File Offset: 0x0008BA20
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000720C File Offset: 0x0000540C
		public unsafe float m_CurrentAdditiveIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity)) = value;
			}
		}

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_performPauses;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_flickeringDuration;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_pauseDuration;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnPause;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_smoothing;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAdditiveIntensity;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000818 RID: 2072
		[ObfuscatedName("VLB.EffectFlicker+<CoChangeIntensity>d__13")]
		public sealed class _CoChangeIntensity_d__13 : Object
		{
			// Token: 0x0600BE31 RID: 48689 RVA: 0x002EB17C File Offset: 0x002E937C
			// Note: this type is marked as 'beforefieldinit'.
			static _CoChangeIntensity_d__13()
			{
				Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoChangeIntensity>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr);
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "nextIntensity");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "expectedDuration");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<velocity>5__2");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<t>5__3");
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664298);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664299);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664300);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664301);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664302);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664303);
			}

			// Token: 0x0600BE32 RID: 48690 RVA: 0x002EB2AC File Offset: 0x002E94AC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoChangeIntensity_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE33 RID: 48691 RVA: 0x002EB2F4 File Offset: 0x002E94F4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE34 RID: 48692 RVA: 0x002EB328 File Offset: 0x002E9528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80138, XrefRangeEnd = 80144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B28 RID: 15144
			// (get) Token: 0x0600BE35 RID: 48693 RVA: 0x002EB364 File Offset: 0x002E9564
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE36 RID: 48694 RVA: 0x002EB3A4 File Offset: 0x002E95A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80144, XrefRangeEnd = 80149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B29 RID: 15145
			// (get) Token: 0x0600BE37 RID: 48695 RVA: 0x002EB3D8 File Offset: 0x002E95D8
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE38 RID: 48696 RVA: 0x0005D0AA File Offset: 0x0005B2AA
			public _CoChangeIntensity_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B21 RID: 15137
			// (get) Token: 0x0600BE39 RID: 48697 RVA: 0x002EB418 File Offset: 0x002E9618
			// (set) Token: 0x0600BE3A RID: 48698 RVA: 0x0005D0B3 File Offset: 0x0005B2B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B22 RID: 15138
			// (get) Token: 0x0600BE3B RID: 48699 RVA: 0x002EB440 File Offset: 0x002E9640
			// (set) Token: 0x0600BE3C RID: 48700 RVA: 0x0005D0CE File Offset: 0x0005B2CE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B23 RID: 15139
			// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x002EB470 File Offset: 0x002E9670
			// (set) Token: 0x0600BE3E RID: 48702 RVA: 0x0005D0ED File Offset: 0x0005B2ED
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B24 RID: 15140
			// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x002EB4A0 File Offset: 0x002E96A0
			// (set) Token: 0x0600BE40 RID: 48704 RVA: 0x0005D10C File Offset: 0x0005B30C
			public unsafe float nextIntensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity)) = value;
				}
			}

			// Token: 0x17003B25 RID: 15141
			// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x002EB4C8 File Offset: 0x002E96C8
			// (set) Token: 0x0600BE42 RID: 48706 RVA: 0x0005D127 File Offset: 0x0005B327
			public unsafe float expectedDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration)) = value;
				}
			}

			// Token: 0x17003B26 RID: 15142
			// (get) Token: 0x0600BE43 RID: 48707 RVA: 0x002EB4F0 File Offset: 0x002E96F0
			// (set) Token: 0x0600BE44 RID: 48708 RVA: 0x0005D142 File Offset: 0x0005B342
			public unsafe float _velocity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2)) = value;
				}
			}

			// Token: 0x17003B27 RID: 15143
			// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x002EB518 File Offset: 0x002E9718
			// (set) Token: 0x0600BE46 RID: 48710 RVA: 0x0005D15D File Offset: 0x0005B35D
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x040080AD RID: 32941
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080AE RID: 32942
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080AF RID: 32943
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080B0 RID: 32944
			private static readonly IntPtr NativeFieldInfoPtr_nextIntensity;

			// Token: 0x040080B1 RID: 32945
			private static readonly IntPtr NativeFieldInfoPtr_expectedDuration;

			// Token: 0x040080B2 RID: 32946
			private static readonly IntPtr NativeFieldInfoPtr__velocity_5__2;

			// Token: 0x040080B3 RID: 32947
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x040080B4 RID: 32948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080B5 RID: 32949
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080B6 RID: 32950
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080B7 RID: 32951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080B8 RID: 32952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080B9 RID: 32953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000819 RID: 2073
		[ObfuscatedName("VLB.EffectFlicker+<CoFlicker>d__12")]
		public sealed class _CoFlicker_d__12 : Object
		{
			// Token: 0x0600BE47 RID: 48711 RVA: 0x002EB540 File Offset: 0x002E9740
			// Note: this type is marked as 'beforefieldinit'.
			static _CoFlicker_d__12()
			{
				Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoFlicker>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr);
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<remainingDuration>5__2");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<freqDuration>5__3");
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664304);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664305);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664306);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664307);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664308);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664309);
			}

			// Token: 0x0600BE48 RID: 48712 RVA: 0x002EB648 File Offset: 0x002E9848
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoFlicker_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE49 RID: 48713 RVA: 0x002EB690 File Offset: 0x002E9890
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE4A RID: 48714 RVA: 0x002EB6C4 File Offset: 0x002E98C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80149, XrefRangeEnd = 80155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B2F RID: 15151
			// (get) Token: 0x0600BE4B RID: 48715 RVA: 0x002EB700 File Offset: 0x002E9900
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE4C RID: 48716 RVA: 0x002EB740 File Offset: 0x002E9940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80155, XrefRangeEnd = 80160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B30 RID: 15152
			// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x002EB774 File Offset: 0x002E9974
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE4E RID: 48718 RVA: 0x0005D178 File Offset: 0x0005B378
			public _CoFlicker_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B2A RID: 15146
			// (get) Token: 0x0600BE4F RID: 48719 RVA: 0x002EB7B4 File Offset: 0x002E99B4
			// (set) Token: 0x0600BE50 RID: 48720 RVA: 0x0005D181 File Offset: 0x0005B381
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B2B RID: 15147
			// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x002EB7DC File Offset: 0x002E99DC
			// (set) Token: 0x0600BE52 RID: 48722 RVA: 0x0005D19C File Offset: 0x0005B39C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2C RID: 15148
			// (get) Token: 0x0600BE53 RID: 48723 RVA: 0x002EB80C File Offset: 0x002E9A0C
			// (set) Token: 0x0600BE54 RID: 48724 RVA: 0x0005D1BB File Offset: 0x0005B3BB
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2D RID: 15149
			// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x002EB83C File Offset: 0x002E9A3C
			// (set) Token: 0x0600BE56 RID: 48726 RVA: 0x0005D1DA File Offset: 0x0005B3DA
			public unsafe float _remainingDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2)) = value;
				}
			}

			// Token: 0x17003B2E RID: 15150
			// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x002EB864 File Offset: 0x002E9A64
			// (set) Token: 0x0600BE58 RID: 48728 RVA: 0x0005D1F5 File Offset: 0x0005B3F5
			public unsafe float _freqDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3)) = value;
				}
			}

			// Token: 0x040080BA RID: 32954
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080BB RID: 32955
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080BC RID: 32956
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080BD RID: 32957
			private static readonly IntPtr NativeFieldInfoPtr__remainingDuration_5__2;

			// Token: 0x040080BE RID: 32958
			private static readonly IntPtr NativeFieldInfoPtr__freqDuration_5__3;

			// Token: 0x040080BF RID: 32959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080C0 RID: 32960
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080C1 RID: 32961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080C2 RID: 32962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080C3 RID: 32963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080C4 RID: 32964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200081A RID: 2074
		[ObfuscatedName("VLB.EffectFlicker+<CoUpdate>d__11")]
		public sealed class _CoUpdate_d__11 : Object
		{
			// Token: 0x0600BE59 RID: 48729 RVA: 0x002EB88C File Offset: 0x002E9A8C
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__11()
			{
				Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoUpdate>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr);
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664310);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664311);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664312);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664313);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664314);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664315);
			}

			// Token: 0x0600BE5A RID: 48730 RVA: 0x002EB96C File Offset: 0x002E9B6C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE5B RID: 48731 RVA: 0x002EB9B4 File Offset: 0x002E9BB4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE5C RID: 48732 RVA: 0x002EB9E8 File Offset: 0x002E9BE8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B34 RID: 15156
			// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x002EBA24 File Offset: 0x002E9C24
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE5E RID: 48734 RVA: 0x002EBA64 File Offset: 0x002E9C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80160, XrefRangeEnd = 80165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B35 RID: 15157
			// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x002EBA98 File Offset: 0x002E9C98
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE60 RID: 48736 RVA: 0x0005D210 File Offset: 0x0005B410
			public _CoUpdate_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B31 RID: 15153
			// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x002EBAD8 File Offset: 0x002E9CD8
			// (set) Token: 0x0600BE62 RID: 48738 RVA: 0x0005D219 File Offset: 0x0005B419
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B32 RID: 15154
			// (get) Token: 0x0600BE63 RID: 48739 RVA: 0x002EBB00 File Offset: 0x002E9D00
			// (set) Token: 0x0600BE64 RID: 48740 RVA: 0x0005D234 File Offset: 0x0005B434
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B33 RID: 15155
			// (get) Token: 0x0600BE65 RID: 48741 RVA: 0x002EBB30 File Offset: 0x002E9D30
			// (set) Token: 0x0600BE66 RID: 48742 RVA: 0x0005D253 File Offset: 0x0005B453
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040080C5 RID: 32965
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080C6 RID: 32966
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080C7 RID: 32967
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080C8 RID: 32968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080C9 RID: 32969
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080CA RID: 32970
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080CB RID: 32971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080CC RID: 32972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080CD RID: 32973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
