using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x02000762 RID: 1890
	public class PourableSoil : Pourable
	{
		// Token: 0x0600B38F RID: 45967 RVA: 0x002CC6EC File Offset: 0x002CA8EC
		// Note: this type is marked as 'beforefieldinit'.
		static PourableSoil()
		{
			Il2CppClassPointerStore<PourableSoil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "PourableSoil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr);
			PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TEAR_ANGLE");
			PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "HIGHLIGHT_CYCLE_TIME");
			PourableSoil.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "IsOpen");
			PourableSoil.NativeFieldInfoPtr_SoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilDefinition");
			PourableSoil.NativeFieldInfoPtr_SoilBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilBag");
			PourableSoil.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Bones");
			PourableSoil.NativeFieldInfoPtr_TopColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopColliders");
			PourableSoil.NativeFieldInfoPtr_Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Highlights");
			PourableSoil.NativeFieldInfoPtr_TopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopParent");
			PourableSoil.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SnipSound");
			PourableSoil.NativeFieldInfoPtr_TopMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopMesh");
			PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<currentCut>k__BackingField");
			PourableSoil.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "onOpened");
			PourableSoil.NativeFieldInfoPtr_highlightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "highlightScale");
			PourableSoil.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "timeSinceStart");
			PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685434);
			PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685435);
			PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685436);
			PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685437);
			PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685438);
			PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685439);
			PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685440);
			PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685441);
			PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685442);
			PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685443);
			PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685444);
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B390 RID: 45968 RVA: 0x002CC924 File Offset: 0x002CAB24
		// (set) Token: 0x0600B391 RID: 45969 RVA: 0x002CC960 File Offset: 0x002CAB60
		public unsafe int currentCut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x002CC9A0 File Offset: 0x002CABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308930, XrefRangeEnd = 308934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x002CC9DC File Offset: 0x002CABDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308934, XrefRangeEnd = 308937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x002CCA18 File Offset: 0x002CAC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308950, RefRangeEnd = 308952, XrefRangeStart = 308937, XrefRangeEnd = 308950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHighlights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x002CCA4C File Offset: 0x002CAC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308952, XrefRangeEnd = 308964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x002CCA98 File Offset: 0x002CAC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308964, XrefRangeEnd = 308965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B397 RID: 45975 RVA: 0x002CCAE0 File Offset: 0x002CACE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308972, RefRangeEnd = 308973, XrefRangeStart = 308965, XrefRangeEnd = 308972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x002CCB14 File Offset: 0x002CAD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308998, RefRangeEnd = 308999, XrefRangeStart = 308973, XrefRangeEnd = 308998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x002CCB48 File Offset: 0x002CAD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309015, RefRangeEnd = 309016, XrefRangeStart = 308999, XrefRangeEnd = 309015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpCut(int cutIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cutIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x002CCB88 File Offset: 0x002CAD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309016, XrefRangeEnd = 309019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableSoil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x00057FB4 File Offset: 0x000561B4
		public PourableSoil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B39C RID: 45980 RVA: 0x002CCBC4 File Offset: 0x002CADC4
		// (set) Token: 0x0600B39D RID: 45981 RVA: 0x00057FBD File Offset: 0x000561BD
		public unsafe static float TEAR_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B39E RID: 45982 RVA: 0x002CCBE0 File Offset: 0x002CADE0
		// (set) Token: 0x0600B39F RID: 45983 RVA: 0x00057FCB File Offset: 0x000561CB
		public unsafe static float HIGHLIGHT_CYCLE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B3A0 RID: 45984 RVA: 0x002CCBFC File Offset: 0x002CADFC
		// (set) Token: 0x0600B3A1 RID: 45985 RVA: 0x00057FD9 File Offset: 0x000561D9
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B3A2 RID: 45986 RVA: 0x002CCC24 File Offset: 0x002CAE24
		// (set) Token: 0x0600B3A3 RID: 45987 RVA: 0x00057FF4 File Offset: 0x000561F4
		public unsafe SoilDefinition SoilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B3A4 RID: 45988 RVA: 0x002CCC54 File Offset: 0x002CAE54
		// (set) Token: 0x0600B3A5 RID: 45989 RVA: 0x00058013 File Offset: 0x00056213
		public unsafe Transform SoilBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B3A6 RID: 45990 RVA: 0x002CCC84 File Offset: 0x002CAE84
		// (set) Token: 0x0600B3A7 RID: 45991 RVA: 0x00058032 File Offset: 0x00056232
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x002CCCB4 File Offset: 0x002CAEB4
		// (set) Token: 0x0600B3A9 RID: 45993 RVA: 0x00058051 File Offset: 0x00056251
		public unsafe List<Collider> TopColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B3AA RID: 45994 RVA: 0x002CCCE4 File Offset: 0x002CAEE4
		// (set) Token: 0x0600B3AB RID: 45995 RVA: 0x00058070 File Offset: 0x00056270
		public unsafe Il2CppReferenceArray<MeshRenderer> Highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x002CCD14 File Offset: 0x002CAF14
		// (set) Token: 0x0600B3AD RID: 45997 RVA: 0x0005808F File Offset: 0x0005628F
		public unsafe Transform TopParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B3AE RID: 45998 RVA: 0x002CCD44 File Offset: 0x002CAF44
		// (set) Token: 0x0600B3AF RID: 45999 RVA: 0x000580AE File Offset: 0x000562AE
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B3B0 RID: 46000 RVA: 0x002CCD74 File Offset: 0x002CAF74
		// (set) Token: 0x0600B3B1 RID: 46001 RVA: 0x000580CD File Offset: 0x000562CD
		public unsafe SkinnedMeshRenderer TopMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x002CCDA4 File Offset: 0x002CAFA4
		// (set) Token: 0x0600B3B3 RID: 46003 RVA: 0x000580EC File Offset: 0x000562EC
		public unsafe int _currentCut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField)) = value;
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x002CCDCC File Offset: 0x002CAFCC
		// (set) Token: 0x0600B3B5 RID: 46005 RVA: 0x00058107 File Offset: 0x00056307
		public unsafe UnityEvent onOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x002CCDFC File Offset: 0x002CAFFC
		// (set) Token: 0x0600B3B7 RID: 46007 RVA: 0x00058126 File Offset: 0x00056326
		public unsafe Vector3 highlightScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale)) = value;
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x002CCE24 File Offset: 0x002CB024
		// (set) Token: 0x0600B3B9 RID: 46009 RVA: 0x00058141 File Offset: 0x00056341
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x0400791F RID: 31007
		private static readonly IntPtr NativeFieldInfoPtr_TEAR_ANGLE;

		// Token: 0x04007920 RID: 31008
		private static readonly IntPtr NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME;

		// Token: 0x04007921 RID: 31009
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04007922 RID: 31010
		private static readonly IntPtr NativeFieldInfoPtr_SoilDefinition;

		// Token: 0x04007923 RID: 31011
		private static readonly IntPtr NativeFieldInfoPtr_SoilBag;

		// Token: 0x04007924 RID: 31012
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04007925 RID: 31013
		private static readonly IntPtr NativeFieldInfoPtr_TopColliders;

		// Token: 0x04007926 RID: 31014
		private static readonly IntPtr NativeFieldInfoPtr_Highlights;

		// Token: 0x04007927 RID: 31015
		private static readonly IntPtr NativeFieldInfoPtr_TopParent;

		// Token: 0x04007928 RID: 31016
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x04007929 RID: 31017
		private static readonly IntPtr NativeFieldInfoPtr_TopMesh;

		// Token: 0x0400792A RID: 31018
		private static readonly IntPtr NativeFieldInfoPtr__currentCut_k__BackingField;

		// Token: 0x0400792B RID: 31019
		private static readonly IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x0400792C RID: 31020
		private static readonly IntPtr NativeFieldInfoPtr_highlightScale;

		// Token: 0x0400792D RID: 31021
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x0400792E RID: 31022
		private static readonly IntPtr NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0;

		// Token: 0x0400792F RID: 31023
		private static readonly IntPtr NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0;

		// Token: 0x04007930 RID: 31024
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007931 RID: 31025
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04007932 RID: 31026
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHighlights_Private_Void_0;

		// Token: 0x04007933 RID: 31027
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007934 RID: 31028
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0;

		// Token: 0x04007935 RID: 31029
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Public_Void_0;

		// Token: 0x04007936 RID: 31030
		private static readonly IntPtr NativeMethodInfoPtr_FinishCut_Private_Void_0;

		// Token: 0x04007937 RID: 31031
		private static readonly IntPtr NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0;

		// Token: 0x04007938 RID: 31032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF7 RID: 3063
		[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFAC RID: 57260 RVA: 0x0034B344 File Offset: 0x00349544
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr);
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "bone");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "startRot");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "endRot");
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100685445);
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100685446);
			}

			// Token: 0x0600DFAD RID: 57261 RVA: 0x0034B3D4 File Offset: 0x003495D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFAE RID: 57262 RVA: 0x0034B410 File Offset: 0x00349610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308925, XrefRangeEnd = 308930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DFAF RID: 57263 RVA: 0x0006D11A File Offset: 0x0006B31A
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004552 RID: 17746
			// (get) Token: 0x0600DFB0 RID: 57264 RVA: 0x0034B450 File Offset: 0x00349650
			// (set) Token: 0x0600DFB1 RID: 57265 RVA: 0x0006D123 File Offset: 0x0006B323
			public unsafe Transform bone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004553 RID: 17747
			// (get) Token: 0x0600DFB2 RID: 57266 RVA: 0x0034B480 File Offset: 0x00349680
			// (set) Token: 0x0600DFB3 RID: 57267 RVA: 0x0006D142 File Offset: 0x0006B342
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x17004554 RID: 17748
			// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x0034B4A8 File Offset: 0x003496A8
			// (set) Token: 0x0600DFB5 RID: 57269 RVA: 0x0006D15D File Offset: 0x0006B35D
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x040095D4 RID: 38356
			private static readonly IntPtr NativeFieldInfoPtr_bone;

			// Token: 0x040095D5 RID: 38357
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x040095D6 RID: 38358
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x040095D7 RID: 38359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095D8 RID: 38360
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C90 RID: 3216
			[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0+<<LerpCut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E770 RID: 59248 RVA: 0x00361E9C File Offset: 0x0036009C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "<<LerpCut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685447);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685448);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685449);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685450);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685451);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685452);
				}

				// Token: 0x0600E771 RID: 59249 RVA: 0x00361FA4 File Offset: 0x003601A4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E772 RID: 59250 RVA: 0x00361FEC File Offset: 0x003601EC
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E773 RID: 59251 RVA: 0x00362020 File Offset: 0x00360220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308911, XrefRangeEnd = 308920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004821 RID: 18465
				// (get) Token: 0x0600E774 RID: 59252 RVA: 0x0036205C File Offset: 0x0036025C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E775 RID: 59253 RVA: 0x0036209C File Offset: 0x0036029C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308920, XrefRangeEnd = 308925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004822 RID: 18466
				// (get) Token: 0x0600E776 RID: 59254 RVA: 0x003620D0 File Offset: 0x003602D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E777 RID: 59255 RVA: 0x00070F99 File Offset: 0x0006F199
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700481C RID: 18460
				// (get) Token: 0x0600E778 RID: 59256 RVA: 0x00362110 File Offset: 0x00360310
				// (set) Token: 0x0600E779 RID: 59257 RVA: 0x00070FA2 File Offset: 0x0006F1A2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700481D RID: 18461
				// (get) Token: 0x0600E77A RID: 59258 RVA: 0x00362138 File Offset: 0x00360338
				// (set) Token: 0x0600E77B RID: 59259 RVA: 0x00070FBD File Offset: 0x0006F1BD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700481E RID: 18462
				// (get) Token: 0x0600E77C RID: 59260 RVA: 0x00362168 File Offset: 0x00360368
				// (set) Token: 0x0600E77D RID: 59261 RVA: 0x00070FDC File Offset: 0x0006F1DC
				public unsafe PourableSoil.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700481F RID: 18463
				// (get) Token: 0x0600E77E RID: 59262 RVA: 0x00362198 File Offset: 0x00360398
				// (set) Token: 0x0600E77F RID: 59263 RVA: 0x00070FFB File Offset: 0x0006F1FB
				public unsafe float _lerpTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004820 RID: 18464
				// (get) Token: 0x0600E780 RID: 59264 RVA: 0x003621C0 File Offset: 0x003603C0
				// (set) Token: 0x0600E781 RID: 59265 RVA: 0x00071016 File Offset: 0x0006F216
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009AA4 RID: 39588
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AA5 RID: 39589
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AA6 RID: 39590
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AA7 RID: 39591
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

				// Token: 0x04009AA8 RID: 39592
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009AA9 RID: 39593
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AAA RID: 39594
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AAB RID: 39595
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AAC RID: 39596
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AAD RID: 39597
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AAE RID: 39598
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
