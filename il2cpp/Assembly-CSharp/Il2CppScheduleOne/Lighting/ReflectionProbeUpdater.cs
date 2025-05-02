using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B9 RID: 953
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x06004A45 RID: 19013 RVA: 0x001687F4 File Offset: 0x001669F4
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeUpdater()
		{
			Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "ReflectionProbeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr);
			ReflectionProbeUpdater.NativeFieldInfoPtr_Probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "Probe");
			ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "renderQueue");
			ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "RenderRoutine");
			ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672497);
			ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672498);
			ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672499);
			ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672500);
			ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672501);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x001688C4 File Offset: 0x00166AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163942, XrefRangeEnd = 163950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x001688F8 File Offset: 0x00166AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163950, XrefRangeEnd = 163994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0016892C File Offset: 0x00166B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163994, XrefRangeEnd = 164007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProbe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00168960 File Offset: 0x00166B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164007, XrefRangeEnd = 164011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x001689A0 File Offset: 0x00166BA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionProbeUpdater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00023D6B File Offset: 0x00021F6B
		public ReflectionProbeUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x001689DC File Offset: 0x00166BDC
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x00023D74 File Offset: 0x00021F74
		public unsafe ReflectionProbe Probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00168A0C File Offset: 0x00166C0C
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x00023D93 File Offset: 0x00021F93
		public unsafe static List<ReflectionProbe> renderQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReflectionProbe>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x00168A34 File Offset: 0x00166C34
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x00023DA5 File Offset: 0x00021FA5
		public unsafe static Coroutine RenderRoutine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeFieldInfoPtr_Probe;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeFieldInfoPtr_renderQueue;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeFieldInfoPtr_RenderRoutine;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProbe_Private_Void_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000987 RID: 2439
		[ObfuscatedName("ScheduleOne.Lighting.ReflectionProbeUpdater+<ProcessQueue>d__6")]
		public sealed class _ProcessQueue_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600CA4A RID: 51786 RVA: 0x0030ED88 File Offset: 0x0030CF88
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessQueue_d__6()
			{
				Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "<ProcessQueue>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>1__state");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>2__current");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<renderDuration_Frames>5__2");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<i>5__3");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672503);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672504);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672505);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672506);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672507);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672508);
			}

			// Token: 0x0600CA4B RID: 51787 RVA: 0x0030EE7C File Offset: 0x0030D07C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessQueue_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA4C RID: 51788 RVA: 0x0030EEC4 File Offset: 0x0030D0C4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA4D RID: 51789 RVA: 0x0030EEF8 File Offset: 0x0030D0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163915, XrefRangeEnd = 163937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F0D RID: 16141
			// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x0030EF34 File Offset: 0x0030D134
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA4F RID: 51791 RVA: 0x0030EF74 File Offset: 0x0030D174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163937, XrefRangeEnd = 163942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F0E RID: 16142
			// (get) Token: 0x0600CA50 RID: 51792 RVA: 0x0030EFA8 File Offset: 0x0030D1A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA51 RID: 51793 RVA: 0x000625B6 File Offset: 0x000607B6
			public _ProcessQueue_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F09 RID: 16137
			// (get) Token: 0x0600CA52 RID: 51794 RVA: 0x0030EFE8 File Offset: 0x0030D1E8
			// (set) Token: 0x0600CA53 RID: 51795 RVA: 0x000625BF File Offset: 0x000607BF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F0A RID: 16138
			// (get) Token: 0x0600CA54 RID: 51796 RVA: 0x0030F010 File Offset: 0x0030D210
			// (set) Token: 0x0600CA55 RID: 51797 RVA: 0x000625DA File Offset: 0x000607DA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0B RID: 16139
			// (get) Token: 0x0600CA56 RID: 51798 RVA: 0x0030F040 File Offset: 0x0030D240
			// (set) Token: 0x0600CA57 RID: 51799 RVA: 0x000625F9 File Offset: 0x000607F9
			public unsafe int _renderDuration_Frames_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2)) = value;
				}
			}

			// Token: 0x17003F0C RID: 16140
			// (get) Token: 0x0600CA58 RID: 51800 RVA: 0x0030F068 File Offset: 0x0030D268
			// (set) Token: 0x0600CA59 RID: 51801 RVA: 0x00062614 File Offset: 0x00060814
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040088D6 RID: 35030
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088D7 RID: 35031
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088D8 RID: 35032
			private static readonly IntPtr NativeFieldInfoPtr__renderDuration_Frames_5__2;

			// Token: 0x040088D9 RID: 35033
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040088DA RID: 35034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088DB RID: 35035
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088DC RID: 35036
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088DD RID: 35037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088DE RID: 35038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088DF RID: 35039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
