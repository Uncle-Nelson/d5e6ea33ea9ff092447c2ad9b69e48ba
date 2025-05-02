using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000082 RID: 130
	public class EffectPulse : EffectAbstractBase
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x0008DB08 File Offset: 0x0008BD08
		// Note: this type is marked as 'beforefieldinit'.
		static EffectPulse()
		{
			Il2CppClassPointerStore<EffectPulse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectPulse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr);
			EffectPulse.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "ClassName");
			EffectPulse.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "frequency");
			EffectPulse.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "intensityAmplitude");
			EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664322);
			EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664323);
			EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664324);
			EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100664325);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0008DBC4 File Offset: 0x0008BDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80278, XrefRangeEnd = 80290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0008DC14 File Offset: 0x0008BE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80290, XrefRangeEnd = 80297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0008DC50 File Offset: 0x0008BE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80297, XrefRangeEnd = 80302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0008DC90 File Offset: 0x0008BE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80302, XrefRangeEnd = 80314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectPulse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00007280 File Offset: 0x00005480
		public EffectPulse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0008DCCC File Offset: 0x0008BECC
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00007289 File Offset: 0x00005489
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectPulse.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectPulse.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0008DCEC File Offset: 0x0008BEEC
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0000729B File Offset: 0x0000549B
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0008DD14 File Offset: 0x0008BF14
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000072B6 File Offset: 0x000054B6
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200081B RID: 2075
		[ObfuscatedName("VLB.EffectPulse+<CoUpdate>d__5")]
		public sealed class _CoUpdate_d__5 : Object
		{
			// Token: 0x0600BE67 RID: 48743 RVA: 0x002EBB60 File Offset: 0x002E9D60
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__5()
			{
				Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "<CoUpdate>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr);
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>1__state");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>2__current");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>4__this");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<t>5__2");
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664326);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664327);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664328);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664329);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664330);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100664331);
			}

			// Token: 0x0600BE68 RID: 48744 RVA: 0x002EBC54 File Offset: 0x002E9E54
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE69 RID: 48745 RVA: 0x002EBC9C File Offset: 0x002E9E9C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE6A RID: 48746 RVA: 0x002EBCD0 File Offset: 0x002E9ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80242, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B3A RID: 15162
			// (get) Token: 0x0600BE6B RID: 48747 RVA: 0x002EBD0C File Offset: 0x002E9F0C
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE6C RID: 48748 RVA: 0x002EBD4C File Offset: 0x002E9F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80248, XrefRangeEnd = 80278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B3B RID: 15163
			// (get) Token: 0x0600BE6D RID: 48749 RVA: 0x002EBD80 File Offset: 0x002E9F80
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE6E RID: 48750 RVA: 0x0005D272 File Offset: 0x0005B472
			public _CoUpdate_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B36 RID: 15158
			// (get) Token: 0x0600BE6F RID: 48751 RVA: 0x002EBDC0 File Offset: 0x002E9FC0
			// (set) Token: 0x0600BE70 RID: 48752 RVA: 0x0005D27B File Offset: 0x0005B47B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B37 RID: 15159
			// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x002EBDE8 File Offset: 0x002E9FE8
			// (set) Token: 0x0600BE72 RID: 48754 RVA: 0x0005D296 File Offset: 0x0005B496
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B38 RID: 15160
			// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x002EBE18 File Offset: 0x002EA018
			// (set) Token: 0x0600BE74 RID: 48756 RVA: 0x0005D2B5 File Offset: 0x0005B4B5
			public unsafe EffectPulse __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectPulse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B39 RID: 15161
			// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x002EBE48 File Offset: 0x002EA048
			// (set) Token: 0x0600BE76 RID: 48758 RVA: 0x0005D2D4 File Offset: 0x0005B4D4
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x040080CE RID: 32974
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080CF RID: 32975
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080D0 RID: 32976
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080D1 RID: 32977
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040080D2 RID: 32978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080D3 RID: 32979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080D4 RID: 32980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080D5 RID: 32981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080D6 RID: 32982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080D7 RID: 32983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
