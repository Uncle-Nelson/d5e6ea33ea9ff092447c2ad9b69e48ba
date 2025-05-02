using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Compass
{
	// Token: 0x020006F6 RID: 1782
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x06009FA6 RID: 40870 RVA: 0x002840B8 File Offset: 0x002822B8
		// Note: this type is marked as 'beforefieldinit'.
		static CompassManager()
		{
			Il2CppClassPointerStore<CompassManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Compass", "CompassManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager>.NativeClassPtr);
			CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DISTANCE_LABEL_THRESHOLD");
			CompassManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Container");
			CompassManager.NativeFieldInfoPtr_NotchPointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPointContainer");
			CompassManager.NativeFieldInfoPtr_NotchUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchUIContainer");
			CompassManager.NativeFieldInfoPtr_ElementUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementUIContainer");
			CompassManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Canvas");
			CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DirectionIndicatorPrefab");
			CompassManager.NativeFieldInfoPtr_NotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPrefab");
			CompassManager.NativeFieldInfoPtr_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementPrefab");
			CompassManager.NativeFieldInfoPtr_CompassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassEnabled");
			CompassManager.NativeFieldInfoPtr_ElementContentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementContentSize");
			CompassManager.NativeFieldInfoPtr_CompassUIRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassUIRange");
			CompassManager.NativeFieldInfoPtr_FullAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "FullAlphaRange");
			CompassManager.NativeFieldInfoPtr_AngleDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "AngleDivisor");
			CompassManager.NativeFieldInfoPtr_ClosedYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ClosedYPos");
			CompassManager.NativeFieldInfoPtr_OpenYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "OpenYPos");
			CompassManager.NativeFieldInfoPtr_notchPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notchPositions");
			CompassManager.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notches");
			CompassManager.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "elements");
			CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "lerpContainerPositionCoroutine");
			CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682835);
			CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682836);
			CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682837);
			CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682838);
			CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682839);
			CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682840);
			CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682841);
			CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682842);
			CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682843);
			CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682844);
			CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682845);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682846);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682847);
			CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682848);
			CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100682849);
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06009FA7 RID: 40871 RVA: 0x002843A4 File Offset: 0x002825A4
		public unsafe Transform cam
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 281806, RefRangeEnd = 281810, XrefRangeStart = 281800, XrefRangeEnd = 281806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x002843E4 File Offset: 0x002825E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281810, XrefRangeEnd = 281871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x00284420 File Offset: 0x00282620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281871, XrefRangeEnd = 281881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x00284454 File Offset: 0x00282654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281881, XrefRangeEnd = 281891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x00284488 File Offset: 0x00282688
		[CallerCount(0)]
		public unsafe void SetCompassEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x002844C8 File Offset: 0x002826C8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 281900, RefRangeEnd = 281933, XrefRangeStart = 281891, XrefRangeEnd = 281900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x00284508 File Offset: 0x00282708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281951, RefRangeEnd = 281952, XrefRangeStart = 281933, XrefRangeEnd = 281951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNotches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x0028453C File Offset: 0x0028273C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281986, RefRangeEnd = 281987, XrefRangeStart = 281952, XrefRangeEnd = 281986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x00284570 File Offset: 0x00282770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282016, RefRangeEnd = 282017, XrefRangeStart = 281987, XrefRangeEnd = 282016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElement(CompassManager.Element element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x002845B4 File Offset: 0x002827B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282039, RefRangeEnd = 282042, XrefRangeStart = 282017, XrefRangeEnd = 282039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x00284610 File Offset: 0x00282810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282084, RefRangeEnd = 282086, XrefRangeStart = 282042, XrefRangeEnd = 282084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentPrefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr3) : null;
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x00284680 File Offset: 0x00282880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282086, XrefRangeEnd = 282098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x002846D0 File Offset: 0x002828D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282107, RefRangeEnd = 282108, XrefRangeStart = 282098, XrefRangeEnd = 282107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(el);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoDestroyRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x00284720 File Offset: 0x00282920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282108, XrefRangeEnd = 282132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x0028475C File Offset: 0x0028295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282132, XrefRangeEnd = 282137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Boolean_PDM_0(float yPos, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x0004E6E2 File Offset: 0x0004C8E2
		public CompassManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x002847B8 File Offset: 0x002829B8
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x0004E6EB File Offset: 0x0004C8EB
		public unsafe static float DISTANCE_LABEL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x002847D4 File Offset: 0x002829D4
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x0004E6F9 File Offset: 0x0004C8F9
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x00284804 File Offset: 0x00282A04
		// (set) Token: 0x06009FBC RID: 40892 RVA: 0x0004E718 File Offset: 0x0004C918
		public unsafe Transform NotchPointContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x00284834 File Offset: 0x00282A34
		// (set) Token: 0x06009FBE RID: 40894 RVA: 0x0004E737 File Offset: 0x0004C937
		public unsafe RectTransform NotchUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x00284864 File Offset: 0x00282A64
		// (set) Token: 0x06009FC0 RID: 40896 RVA: 0x0004E756 File Offset: 0x0004C956
		public unsafe RectTransform ElementUIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x00284894 File Offset: 0x00282A94
		// (set) Token: 0x06009FC2 RID: 40898 RVA: 0x0004E775 File Offset: 0x0004C975
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x002848C4 File Offset: 0x00282AC4
		// (set) Token: 0x06009FC4 RID: 40900 RVA: 0x0004E794 File Offset: 0x0004C994
		public unsafe GameObject DirectionIndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x002848F4 File Offset: 0x00282AF4
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x0004E7B3 File Offset: 0x0004C9B3
		public unsafe GameObject NotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x00284924 File Offset: 0x00282B24
		// (set) Token: 0x06009FC8 RID: 40904 RVA: 0x0004E7D2 File Offset: 0x0004C9D2
		public unsafe GameObject ElementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x00284954 File Offset: 0x00282B54
		// (set) Token: 0x06009FCA RID: 40906 RVA: 0x0004E7F1 File Offset: 0x0004C9F1
		public unsafe bool CompassEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled)) = value;
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x0028497C File Offset: 0x00282B7C
		// (set) Token: 0x06009FCC RID: 40908 RVA: 0x0004E80C File Offset: 0x0004CA0C
		public unsafe Vector2 ElementContentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize)) = value;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x002849A4 File Offset: 0x00282BA4
		// (set) Token: 0x06009FCE RID: 40910 RVA: 0x0004E827 File Offset: 0x0004CA27
		public unsafe float CompassUIRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange)) = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x002849CC File Offset: 0x00282BCC
		// (set) Token: 0x06009FD0 RID: 40912 RVA: 0x0004E842 File Offset: 0x0004CA42
		public unsafe float FullAlphaRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange)) = value;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x002849F4 File Offset: 0x00282BF4
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x0004E85D File Offset: 0x0004CA5D
		public unsafe float AngleDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor)) = value;
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x00284A1C File Offset: 0x00282C1C
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x0004E878 File Offset: 0x0004CA78
		public unsafe float ClosedYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos)) = value;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x00284A44 File Offset: 0x00282C44
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x0004E893 File Offset: 0x0004CA93
		public unsafe float OpenYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos)) = value;
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06009FD7 RID: 40919 RVA: 0x00284A6C File Offset: 0x00282C6C
		// (set) Token: 0x06009FD8 RID: 40920 RVA: 0x0004E8AE File Offset: 0x0004CAAE
		public unsafe List<Transform> notchPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06009FD9 RID: 40921 RVA: 0x00284A9C File Offset: 0x00282C9C
		// (set) Token: 0x06009FDA RID: 40922 RVA: 0x0004E8CD File Offset: 0x0004CACD
		public unsafe List<CompassManager.Notch> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Notch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06009FDB RID: 40923 RVA: 0x00284ACC File Offset: 0x00282CCC
		// (set) Token: 0x06009FDC RID: 40924 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		public unsafe List<CompassManager.Element> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06009FDD RID: 40925 RVA: 0x00284AFC File Offset: 0x00282CFC
		// (set) Token: 0x06009FDE RID: 40926 RVA: 0x0004E90B File Offset: 0x0004CB0B
		public unsafe Coroutine lerpContainerPositionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B13 RID: 27411
		private static readonly IntPtr NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD;

		// Token: 0x04006B14 RID: 27412
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006B15 RID: 27413
		private static readonly IntPtr NativeFieldInfoPtr_NotchPointContainer;

		// Token: 0x04006B16 RID: 27414
		private static readonly IntPtr NativeFieldInfoPtr_NotchUIContainer;

		// Token: 0x04006B17 RID: 27415
		private static readonly IntPtr NativeFieldInfoPtr_ElementUIContainer;

		// Token: 0x04006B18 RID: 27416
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006B19 RID: 27417
		private static readonly IntPtr NativeFieldInfoPtr_DirectionIndicatorPrefab;

		// Token: 0x04006B1A RID: 27418
		private static readonly IntPtr NativeFieldInfoPtr_NotchPrefab;

		// Token: 0x04006B1B RID: 27419
		private static readonly IntPtr NativeFieldInfoPtr_ElementPrefab;

		// Token: 0x04006B1C RID: 27420
		private static readonly IntPtr NativeFieldInfoPtr_CompassEnabled;

		// Token: 0x04006B1D RID: 27421
		private static readonly IntPtr NativeFieldInfoPtr_ElementContentSize;

		// Token: 0x04006B1E RID: 27422
		private static readonly IntPtr NativeFieldInfoPtr_CompassUIRange;

		// Token: 0x04006B1F RID: 27423
		private static readonly IntPtr NativeFieldInfoPtr_FullAlphaRange;

		// Token: 0x04006B20 RID: 27424
		private static readonly IntPtr NativeFieldInfoPtr_AngleDivisor;

		// Token: 0x04006B21 RID: 27425
		private static readonly IntPtr NativeFieldInfoPtr_ClosedYPos;

		// Token: 0x04006B22 RID: 27426
		private static readonly IntPtr NativeFieldInfoPtr_OpenYPos;

		// Token: 0x04006B23 RID: 27427
		private static readonly IntPtr NativeFieldInfoPtr_notchPositions;

		// Token: 0x04006B24 RID: 27428
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04006B25 RID: 27429
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04006B26 RID: 27430
		private static readonly IntPtr NativeFieldInfoPtr_lerpContainerPositionCoroutine;

		// Token: 0x04006B27 RID: 27431
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04006B28 RID: 27432
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006B29 RID: 27433
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006B2A RID: 27434
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006B2B RID: 27435
		private static readonly IntPtr NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0;

		// Token: 0x04006B2C RID: 27436
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04006B2D RID: 27437
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNotches_Private_Void_0;

		// Token: 0x04006B2E RID: 27438
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04006B2F RID: 27439
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0;

		// Token: 0x04006B30 RID: 27440
		private static readonly IntPtr NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0;

		// Token: 0x04006B31 RID: 27441
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0;

		// Token: 0x04006B32 RID: 27442
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0;

		// Token: 0x04006B33 RID: 27443
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0;

		// Token: 0x04006B34 RID: 27444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006B35 RID: 27445
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0;

		// Token: 0x02000BA4 RID: 2980
		public class Notch : Il2CppSystem.Object
		{
			// Token: 0x0600DC92 RID: 56466 RVA: 0x00342660 File Offset: 0x00340860
			// Note: this type is marked as 'beforefieldinit'.
			static Notch()
			{
				Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Notch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr);
				CompassManager.Notch.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Rect");
				CompassManager.Notch.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Group");
				CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, 100682850);
			}

			// Token: 0x0600DC93 RID: 56467 RVA: 0x003426C8 File Offset: 0x003408C8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Notch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC94 RID: 56468 RVA: 0x0006B75F File Offset: 0x0006995F
			public Notch(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445B RID: 17499
			// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x00342704 File Offset: 0x00340904
			// (set) Token: 0x0600DC96 RID: 56470 RVA: 0x0006B768 File Offset: 0x00069968
			public unsafe RectTransform Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445C RID: 17500
			// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x00342734 File Offset: 0x00340934
			// (set) Token: 0x0600DC98 RID: 56472 RVA: 0x0006B787 File Offset: 0x00069987
			public unsafe CanvasGroup Group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093D9 RID: 37849
			private static readonly IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x040093DA RID: 37850
			private static readonly IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x040093DB RID: 37851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BA5 RID: 2981
		public class Element : Il2CppSystem.Object
		{
			// Token: 0x0600DC99 RID: 56473 RVA: 0x00342764 File Offset: 0x00340964
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr);
				CompassManager.Element.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Visible");
				CompassManager.Element.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Rect");
				CompassManager.Element.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Group");
				CompassManager.Element.NativeFieldInfoPtr_DistanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "DistanceLabel");
				CompassManager.Element.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Transform");
				CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100682851);
			}

			// Token: 0x0600DC9A RID: 56474 RVA: 0x00342808 File Offset: 0x00340A08
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC9B RID: 56475 RVA: 0x0006B7A6 File Offset: 0x000699A6
			public Element(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700445D RID: 17501
			// (get) Token: 0x0600DC9C RID: 56476 RVA: 0x00342844 File Offset: 0x00340A44
			// (set) Token: 0x0600DC9D RID: 56477 RVA: 0x0006B7AF File Offset: 0x000699AF
			public unsafe bool Visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible)) = value;
				}
			}

			// Token: 0x1700445E RID: 17502
			// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x0034286C File Offset: 0x00340A6C
			// (set) Token: 0x0600DC9F RID: 56479 RVA: 0x0006B7CA File Offset: 0x000699CA
			public unsafe RectTransform Rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700445F RID: 17503
			// (get) Token: 0x0600DCA0 RID: 56480 RVA: 0x0034289C File Offset: 0x00340A9C
			// (set) Token: 0x0600DCA1 RID: 56481 RVA: 0x0006B7E9 File Offset: 0x000699E9
			public unsafe CanvasGroup Group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004460 RID: 17504
			// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x003428CC File Offset: 0x00340ACC
			// (set) Token: 0x0600DCA3 RID: 56483 RVA: 0x0006B808 File Offset: 0x00069A08
			public unsafe TextMeshProUGUI DistanceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004461 RID: 17505
			// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x003428FC File Offset: 0x00340AFC
			// (set) Token: 0x0600DCA5 RID: 56485 RVA: 0x0006B827 File Offset: 0x00069A27
			public unsafe Transform Transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093DC RID: 37852
			private static readonly IntPtr NativeFieldInfoPtr_Visible;

			// Token: 0x040093DD RID: 37853
			private static readonly IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x040093DE RID: 37854
			private static readonly IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x040093DF RID: 37855
			private static readonly IntPtr NativeFieldInfoPtr_DistanceLabel;

			// Token: 0x040093E0 RID: 37856
			private static readonly IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x040093E1 RID: 37857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BA6 RID: 2982
		[ObfuscatedName("ScheduleOne.UI.Compass.CompassManager+<<SetVisible>g__LerpContainerPosition|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DCA6 RID: 56486 RVA: 0x0034292C File Offset: 0x00340B2C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique()
			{
				Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "<<SetVisible>g__LerpContainerPosition|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>1__state");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>2__current");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "visible");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>4__this");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "yPos");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<t>5__2");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<startPos>5__3");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<endPos>5__4");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682852);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682853);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682854);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682855);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682856);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100682857);
			}

			// Token: 0x0600DCA7 RID: 56487 RVA: 0x00342A70 File Offset: 0x00340C70
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA8 RID: 56488 RVA: 0x00342AB8 File Offset: 0x00340CB8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA9 RID: 56489 RVA: 0x00342AEC File Offset: 0x00340CEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281786, XrefRangeEnd = 281795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700446A RID: 17514
			// (get) Token: 0x0600DCAA RID: 56490 RVA: 0x00342B28 File Offset: 0x00340D28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCAB RID: 56491 RVA: 0x00342B68 File Offset: 0x00340D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281795, XrefRangeEnd = 281800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700446B RID: 17515
			// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x00342B9C File Offset: 0x00340D9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCAD RID: 56493 RVA: 0x0006B846 File Offset: 0x00069A46
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004462 RID: 17506
			// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x00342BDC File Offset: 0x00340DDC
			// (set) Token: 0x0600DCAF RID: 56495 RVA: 0x0006B84F File Offset: 0x00069A4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004463 RID: 17507
			// (get) Token: 0x0600DCB0 RID: 56496 RVA: 0x00342C04 File Offset: 0x00340E04
			// (set) Token: 0x0600DCB1 RID: 56497 RVA: 0x0006B86A File Offset: 0x00069A6A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004464 RID: 17508
			// (get) Token: 0x0600DCB2 RID: 56498 RVA: 0x00342C34 File Offset: 0x00340E34
			// (set) Token: 0x0600DCB3 RID: 56499 RVA: 0x0006B889 File Offset: 0x00069A89
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x17004465 RID: 17509
			// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x00342C5C File Offset: 0x00340E5C
			// (set) Token: 0x0600DCB5 RID: 56501 RVA: 0x0006B8A4 File Offset: 0x00069AA4
			public unsafe CompassManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004466 RID: 17510
			// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x00342C8C File Offset: 0x00340E8C
			// (set) Token: 0x0600DCB7 RID: 56503 RVA: 0x0006B8C3 File Offset: 0x00069AC3
			public unsafe float yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x17004467 RID: 17511
			// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00342CB4 File Offset: 0x00340EB4
			// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x0006B8DE File Offset: 0x00069ADE
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x17004468 RID: 17512
			// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x00342CDC File Offset: 0x00340EDC
			// (set) Token: 0x0600DCBB RID: 56507 RVA: 0x0006B8F9 File Offset: 0x00069AF9
			public unsafe Vector2 _startPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
				}
			}

			// Token: 0x17004469 RID: 17513
			// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00342D04 File Offset: 0x00340F04
			// (set) Token: 0x0600DCBD RID: 56509 RVA: 0x0006B914 File Offset: 0x00069B14
			public unsafe Vector2 _endPos_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
				}
			}

			// Token: 0x040093E2 RID: 37858
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093E3 RID: 37859
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093E4 RID: 37860
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x040093E5 RID: 37861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093E6 RID: 37862
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x040093E7 RID: 37863
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040093E8 RID: 37864
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x040093E9 RID: 37865
			private static readonly IntPtr NativeFieldInfoPtr__endPos_5__4;

			// Token: 0x040093EA RID: 37866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093EB RID: 37867
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093EC RID: 37868
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093ED RID: 37869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093EE RID: 37870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093EF RID: 37871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
