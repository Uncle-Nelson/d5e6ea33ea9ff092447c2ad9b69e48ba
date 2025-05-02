using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x02000789 RID: 1929
	public class Intersection : MonoBehaviour
	{
		// Token: 0x0600B6A3 RID: 46755 RVA: 0x002D57EC File Offset: 0x002D39EC
		// Note: this type is marked as 'beforefieldinit'.
		static Intersection()
		{
			Il2CppClassPointerStore<Intersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "Intersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection>.NativeClassPtr);
			Intersection.NativeFieldInfoPtr_path1Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Lights");
			Intersection.NativeFieldInfoPtr_path2Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Lights");
			Intersection.NativeFieldInfoPtr_path1Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Obstacles");
			Intersection.NativeFieldInfoPtr_path2Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Obstacles");
			Intersection.NativeFieldInfoPtr_path1Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Time");
			Intersection.NativeFieldInfoPtr_path2Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Time");
			Intersection.NativeFieldInfoPtr_timeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "timeOffset");
			Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685745);
			Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685746);
			Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685747);
			Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685748);
			Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685749);
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x002D590C File Offset: 0x002D3B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311758, XrefRangeEnd = 311769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x002D5948 File Offset: 0x002D3B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311769, XrefRangeEnd = 311774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x002D5988 File Offset: 0x002D3B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311816, RefRangeEnd = 311817, XrefRangeStart = 311774, XrefRangeEnd = 311816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath1Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x002D59C8 File Offset: 0x002D3BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311817, XrefRangeEnd = 311859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath2Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x002D5A08 File Offset: 0x002D3C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311859, XrefRangeEnd = 311884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00059AEE File Offset: 0x00057CEE
		public Intersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600B6AA RID: 46762 RVA: 0x002D5A44 File Offset: 0x002D3C44
		// (set) Token: 0x0600B6AB RID: 46763 RVA: 0x00059AF7 File Offset: 0x00057CF7
		public unsafe List<TrafficLight> path1Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600B6AC RID: 46764 RVA: 0x002D5A74 File Offset: 0x002D3C74
		// (set) Token: 0x0600B6AD RID: 46765 RVA: 0x00059B16 File Offset: 0x00057D16
		public unsafe List<TrafficLight> path2Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600B6AE RID: 46766 RVA: 0x002D5AA4 File Offset: 0x002D3CA4
		// (set) Token: 0x0600B6AF RID: 46767 RVA: 0x00059B35 File Offset: 0x00057D35
		public unsafe List<GameObject> path1Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600B6B0 RID: 46768 RVA: 0x002D5AD4 File Offset: 0x002D3CD4
		// (set) Token: 0x0600B6B1 RID: 46769 RVA: 0x00059B54 File Offset: 0x00057D54
		public unsafe List<GameObject> path2Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600B6B2 RID: 46770 RVA: 0x002D5B04 File Offset: 0x002D3D04
		// (set) Token: 0x0600B6B3 RID: 46771 RVA: 0x00059B73 File Offset: 0x00057D73
		public unsafe float path1Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time)) = value;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600B6B4 RID: 46772 RVA: 0x002D5B2C File Offset: 0x002D3D2C
		// (set) Token: 0x0600B6B5 RID: 46773 RVA: 0x00059B8E File Offset: 0x00057D8E
		public unsafe float path2Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time)) = value;
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600B6B6 RID: 46774 RVA: 0x002D5B54 File Offset: 0x002D3D54
		// (set) Token: 0x0600B6B7 RID: 46775 RVA: 0x00059BA9 File Offset: 0x00057DA9
		public unsafe float timeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset)) = value;
			}
		}

		// Token: 0x04007B07 RID: 31495
		private static readonly IntPtr NativeFieldInfoPtr_path1Lights;

		// Token: 0x04007B08 RID: 31496
		private static readonly IntPtr NativeFieldInfoPtr_path2Lights;

		// Token: 0x04007B09 RID: 31497
		private static readonly IntPtr NativeFieldInfoPtr_path1Obstacles;

		// Token: 0x04007B0A RID: 31498
		private static readonly IntPtr NativeFieldInfoPtr_path2Obstacles;

		// Token: 0x04007B0B RID: 31499
		private static readonly IntPtr NativeFieldInfoPtr_path1Time;

		// Token: 0x04007B0C RID: 31500
		private static readonly IntPtr NativeFieldInfoPtr_path2Time;

		// Token: 0x04007B0D RID: 31501
		private static readonly IntPtr NativeFieldInfoPtr_timeOffset;

		// Token: 0x04007B0E RID: 31502
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007B0F RID: 31503
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_IEnumerator_0;

		// Token: 0x04007B10 RID: 31504
		private static readonly IntPtr NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0;

		// Token: 0x04007B11 RID: 31505
		private static readonly IntPtr NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0;

		// Token: 0x04007B12 RID: 31506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C09 RID: 3081
		[ObfuscatedName("ScheduleOne.Map.Infrastructure.Intersection+<Run>d__8")]
		public sealed class _Run_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600E043 RID: 57411 RVA: 0x0034CE80 File Offset: 0x0034B080
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__8()
			{
				Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "<Run>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr);
				Intersection._Run_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>1__state");
				Intersection._Run_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>2__current");
				Intersection._Run_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>4__this");
				Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685750);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685751);
				Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685752);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685753);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685754);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685755);
			}

			// Token: 0x0600E044 RID: 57412 RVA: 0x0034CF60 File Offset: 0x0034B160
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Run_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E045 RID: 57413 RVA: 0x0034CFA8 File Offset: 0x0034B1A8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E046 RID: 57414 RVA: 0x0034CFDC File Offset: 0x0034B1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311742, XrefRangeEnd = 311753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004580 RID: 17792
			// (get) Token: 0x0600E047 RID: 57415 RVA: 0x0034D018 File Offset: 0x0034B218
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E048 RID: 57416 RVA: 0x0034D058 File Offset: 0x0034B258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311753, XrefRangeEnd = 311758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004581 RID: 17793
			// (get) Token: 0x0600E049 RID: 57417 RVA: 0x0034D08C File Offset: 0x0034B28C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E04A RID: 57418 RVA: 0x0006D553 File Offset: 0x0006B753
			public _Run_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457D RID: 17789
			// (get) Token: 0x0600E04B RID: 57419 RVA: 0x0034D0CC File Offset: 0x0034B2CC
			// (set) Token: 0x0600E04C RID: 57420 RVA: 0x0006D55C File Offset: 0x0006B75C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700457E RID: 17790
			// (get) Token: 0x0600E04D RID: 57421 RVA: 0x0034D0F4 File Offset: 0x0034B2F4
			// (set) Token: 0x0600E04E RID: 57422 RVA: 0x0006D577 File Offset: 0x0006B777
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457F RID: 17791
			// (get) Token: 0x0600E04F RID: 57423 RVA: 0x0034D124 File Offset: 0x0034B324
			// (set) Token: 0x0600E050 RID: 57424 RVA: 0x0006D596 File Offset: 0x0006B796
			public unsafe Intersection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Intersection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009633 RID: 38451
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009634 RID: 38452
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009635 RID: 38453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009636 RID: 38454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009637 RID: 38455
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009638 RID: 38456
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009639 RID: 38457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400963A RID: 38458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400963B RID: 38459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
