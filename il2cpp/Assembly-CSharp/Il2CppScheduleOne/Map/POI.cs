using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000785 RID: 1925
	public class POI : MonoBehaviour
	{
		// Token: 0x0600B622 RID: 46626 RVA: 0x002D3F30 File Offset: 0x002D2130
		// Note: this type is marked as 'beforefieldinit'.
		static POI()
		{
			Il2CppClassPointerStore<POI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "POI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI>.NativeClassPtr);
			POI.NativeFieldInfoPtr__UISetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UISetup>k__BackingField");
			POI.NativeFieldInfoPtr_MainTextVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "MainTextVisibility");
			POI.NativeFieldInfoPtr_DefaultMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "DefaultMainText");
			POI.NativeFieldInfoPtr_AutoUpdatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "AutoUpdatePosition");
			POI.NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "Rotate");
			POI.NativeFieldInfoPtr__MainText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<MainText>k__BackingField");
			POI.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "UIPrefab");
			POI.NativeFieldInfoPtr__UI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UI>k__BackingField");
			POI.NativeFieldInfoPtr__IconContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<IconContainer>k__BackingField");
			POI.NativeFieldInfoPtr_mainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainLabel");
			POI.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "button");
			POI.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "eventTrigger");
			POI.NativeFieldInfoPtr_mainTextSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainTextSet");
			POI.NativeFieldInfoPtr_onUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "onUICreated");
			POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685687);
			POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685688);
			POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685689);
			POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685690);
			POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685691);
			POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685692);
			POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685693);
			POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685694);
			POI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685695);
			POI.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685696);
			POI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685697);
			POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685698);
			POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685699);
			POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685700);
			POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685701);
			POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685702);
			POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685703);
			POI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685704);
			POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685705);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685706);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685707);
			POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100685708);
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x002D4230 File Offset: 0x002D2430
		// (set) Token: 0x0600B624 RID: 46628 RVA: 0x002D426C File Offset: 0x002D246C
		public unsafe bool UISetup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600B625 RID: 46629 RVA: 0x002D42AC File Offset: 0x002D24AC
		// (set) Token: 0x0600B626 RID: 46630 RVA: 0x002D42E4 File Offset: 0x002D24E4
		public unsafe string MainText
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B627 RID: 46631 RVA: 0x002D4328 File Offset: 0x002D2528
		// (set) Token: 0x0600B628 RID: 46632 RVA: 0x002D4368 File Offset: 0x002D2568
		public unsafe RectTransform UI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B629 RID: 46633 RVA: 0x002D43AC File Offset: 0x002D25AC
		// (set) Token: 0x0600B62A RID: 46634 RVA: 0x002D43EC File Offset: 0x002D25EC
		public unsafe RectTransform IconContainer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x002D4430 File Offset: 0x002D2630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311232, XrefRangeEnd = 311257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x002D4464 File Offset: 0x002D2664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311257, XrefRangeEnd = 311266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x002D4498 File Offset: 0x002D2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311266, XrefRangeEnd = 311273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x002D44CC File Offset: 0x002D26CC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 311278, RefRangeEnd = 311292, XrefRangeStart = 311273, XrefRangeEnd = 311278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x002D4510 File Offset: 0x002D2710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311292, XrefRangeEnd = 311317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x002D454C File Offset: 0x002D274C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311405, RefRangeEnd = 311406, XrefRangeStart = 311317, XrefRangeEnd = 311405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x002D4588 File Offset: 0x002D2788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311406, XrefRangeEnd = 311407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x002D45C4 File Offset: 0x002D27C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311407, XrefRangeEnd = 311408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x002D4600 File Offset: 0x002D2800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311408, XrefRangeEnd = 311415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x002D463C File Offset: 0x002D283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B635 RID: 46645 RVA: 0x002D4678 File Offset: 0x002D2878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311415, XrefRangeEnd = 311420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x002D46B8 File Offset: 0x002D28B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311420, RefRangeEnd = 311422, XrefRangeStart = 311420, XrefRangeEnd = 311420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x002D46FC File Offset: 0x002D28FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38038, RefRangeEnd = 38043, XrefRangeStart = 38038, XrefRangeEnd = 38043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__32_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x002D4740 File Offset: 0x002D2940
		[CallerCount(0)]
		public unsafe void _InitializeUI_b__32_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x00059689 File Offset: 0x00057889
		public POI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600B63A RID: 46650 RVA: 0x002D4774 File Offset: 0x002D2974
		// (set) Token: 0x0600B63B RID: 46651 RVA: 0x00059692 File Offset: 0x00057892
		public unsafe bool _UISetup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField)) = value;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600B63C RID: 46652 RVA: 0x002D479C File Offset: 0x002D299C
		// (set) Token: 0x0600B63D RID: 46653 RVA: 0x000596AD File Offset: 0x000578AD
		public unsafe POI.TextShowMode MainTextVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility)) = value;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600B63E RID: 46654 RVA: 0x002D47C4 File Offset: 0x002D29C4
		// (set) Token: 0x0600B63F RID: 46655 RVA: 0x000596C8 File Offset: 0x000578C8
		public unsafe string DefaultMainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600B640 RID: 46656 RVA: 0x002D47EC File Offset: 0x002D29EC
		// (set) Token: 0x0600B641 RID: 46657 RVA: 0x000596E7 File Offset: 0x000578E7
		public unsafe bool AutoUpdatePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition)) = value;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600B642 RID: 46658 RVA: 0x002D4814 File Offset: 0x002D2A14
		// (set) Token: 0x0600B643 RID: 46659 RVA: 0x00059702 File Offset: 0x00057902
		public unsafe bool Rotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate)) = value;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600B644 RID: 46660 RVA: 0x002D483C File Offset: 0x002D2A3C
		// (set) Token: 0x0600B645 RID: 46661 RVA: 0x0005971D File Offset: 0x0005791D
		public unsafe string _MainText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600B646 RID: 46662 RVA: 0x002D4864 File Offset: 0x002D2A64
		// (set) Token: 0x0600B647 RID: 46663 RVA: 0x0005973C File Offset: 0x0005793C
		public unsafe GameObject UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600B648 RID: 46664 RVA: 0x002D4894 File Offset: 0x002D2A94
		// (set) Token: 0x0600B649 RID: 46665 RVA: 0x0005975B File Offset: 0x0005795B
		public unsafe RectTransform _UI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x002D48C4 File Offset: 0x002D2AC4
		// (set) Token: 0x0600B64B RID: 46667 RVA: 0x0005977A File Offset: 0x0005797A
		public unsafe RectTransform _IconContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x002D48F4 File Offset: 0x002D2AF4
		// (set) Token: 0x0600B64D RID: 46669 RVA: 0x00059799 File Offset: 0x00057999
		public unsafe Text mainLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600B64E RID: 46670 RVA: 0x002D4924 File Offset: 0x002D2B24
		// (set) Token: 0x0600B64F RID: 46671 RVA: 0x000597B8 File Offset: 0x000579B8
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600B650 RID: 46672 RVA: 0x002D4954 File Offset: 0x002D2B54
		// (set) Token: 0x0600B651 RID: 46673 RVA: 0x000597D7 File Offset: 0x000579D7
		public unsafe EventTrigger eventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600B652 RID: 46674 RVA: 0x002D4984 File Offset: 0x002D2B84
		// (set) Token: 0x0600B653 RID: 46675 RVA: 0x000597F6 File Offset: 0x000579F6
		public unsafe bool mainTextSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet)) = value;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B654 RID: 46676 RVA: 0x002D49AC File Offset: 0x002D2BAC
		// (set) Token: 0x0600B655 RID: 46677 RVA: 0x00059811 File Offset: 0x00057A11
		public unsafe UnityEvent onUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AB4 RID: 31412
		private static readonly IntPtr NativeFieldInfoPtr__UISetup_k__BackingField;

		// Token: 0x04007AB5 RID: 31413
		private static readonly IntPtr NativeFieldInfoPtr_MainTextVisibility;

		// Token: 0x04007AB6 RID: 31414
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMainText;

		// Token: 0x04007AB7 RID: 31415
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePosition;

		// Token: 0x04007AB8 RID: 31416
		private static readonly IntPtr NativeFieldInfoPtr_Rotate;

		// Token: 0x04007AB9 RID: 31417
		private static readonly IntPtr NativeFieldInfoPtr__MainText_k__BackingField;

		// Token: 0x04007ABA RID: 31418
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x04007ABB RID: 31419
		private static readonly IntPtr NativeFieldInfoPtr__UI_k__BackingField;

		// Token: 0x04007ABC RID: 31420
		private static readonly IntPtr NativeFieldInfoPtr__IconContainer_k__BackingField;

		// Token: 0x04007ABD RID: 31421
		private static readonly IntPtr NativeFieldInfoPtr_mainLabel;

		// Token: 0x04007ABE RID: 31422
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04007ABF RID: 31423
		private static readonly IntPtr NativeFieldInfoPtr_eventTrigger;

		// Token: 0x04007AC0 RID: 31424
		private static readonly IntPtr NativeFieldInfoPtr_mainTextSet;

		// Token: 0x04007AC1 RID: 31425
		private static readonly IntPtr NativeFieldInfoPtr_onUICreated;

		// Token: 0x04007AC2 RID: 31426
		private static readonly IntPtr NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0;

		// Token: 0x04007AC3 RID: 31427
		private static readonly IntPtr NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0;

		// Token: 0x04007AC4 RID: 31428
		private static readonly IntPtr NativeMethodInfoPtr_get_MainText_Public_get_String_0;

		// Token: 0x04007AC5 RID: 31429
		private static readonly IntPtr NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0;

		// Token: 0x04007AC6 RID: 31430
		private static readonly IntPtr NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0;

		// Token: 0x04007AC7 RID: 31431
		private static readonly IntPtr NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0;

		// Token: 0x04007AC8 RID: 31432
		private static readonly IntPtr NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0;

		// Token: 0x04007AC9 RID: 31433
		private static readonly IntPtr NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04007ACA RID: 31434
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007ACB RID: 31435
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04007ACC RID: 31436
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007ACD RID: 31437
		private static readonly IntPtr NativeMethodInfoPtr_SetMainText_Public_Void_String_0;

		// Token: 0x04007ACE RID: 31438
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0;

		// Token: 0x04007ACF RID: 31439
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0;

		// Token: 0x04007AD0 RID: 31440
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0;

		// Token: 0x04007AD1 RID: 31441
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0;

		// Token: 0x04007AD2 RID: 31442
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x04007AD3 RID: 31443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007AD4 RID: 31444
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007AD5 RID: 31445
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_0_Private_Void_BaseEventData_0;

		// Token: 0x04007AD6 RID: 31446
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_1_Private_Void_BaseEventData_0;

		// Token: 0x04007AD7 RID: 31447
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__32_2_Private_Void_0;

		// Token: 0x02000C03 RID: 3075
		[OriginalName("Assembly-CSharp.dll", "", "TextShowMode")]
		public enum TextShowMode
		{
			// Token: 0x04009617 RID: 38423
			Off,
			// Token: 0x04009618 RID: 38424
			Always,
			// Token: 0x04009619 RID: 38425
			OnHover
		}

		// Token: 0x02000C04 RID: 3076
		[ObfuscatedName("ScheduleOne.Map.POI+<<OnEnable>g__Wait|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E025 RID: 57381 RVA: 0x0034C910 File Offset: 0x0034AB10
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique()
			{
				Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<<OnEnable>g__Wait|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>1__state");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>2__current");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>4__this");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685709);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685710);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685711);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685712);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685713);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100685714);
			}

			// Token: 0x0600E026 RID: 57382 RVA: 0x0034C9F0 File Offset: 0x0034ABF0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E027 RID: 57383 RVA: 0x0034CA38 File Offset: 0x0034AC38
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E028 RID: 57384 RVA: 0x0034CA6C File Offset: 0x0034AC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311195, XrefRangeEnd = 311219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004577 RID: 17783
			// (get) Token: 0x0600E029 RID: 57385 RVA: 0x0034CAA8 File Offset: 0x0034ACA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E02A RID: 57386 RVA: 0x0034CAE8 File Offset: 0x0034ACE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311219, XrefRangeEnd = 311224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004578 RID: 17784
			// (get) Token: 0x0600E02B RID: 57387 RVA: 0x0034CB1C File Offset: 0x0034AD1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E02C RID: 57388 RVA: 0x0006D497 File Offset: 0x0006B697
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004574 RID: 17780
			// (get) Token: 0x0600E02D RID: 57389 RVA: 0x0034CB5C File Offset: 0x0034AD5C
			// (set) Token: 0x0600E02E RID: 57390 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004575 RID: 17781
			// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0034CB84 File Offset: 0x0034AD84
			// (set) Token: 0x0600E030 RID: 57392 RVA: 0x0006D4BB File Offset: 0x0006B6BB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004576 RID: 17782
			// (get) Token: 0x0600E031 RID: 57393 RVA: 0x0034CBB4 File Offset: 0x0034ADB4
			// (set) Token: 0x0600E032 RID: 57394 RVA: 0x0006D4DA File Offset: 0x0006B6DA
			public unsafe POI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400961A RID: 38426
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400961B RID: 38427
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400961C RID: 38428
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400961D RID: 38429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400961E RID: 38430
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400961F RID: 38431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009620 RID: 38432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009621 RID: 38433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009622 RID: 38434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C05 RID: 3077
		[ObfuscatedName("ScheduleOne.Map.POI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E033 RID: 57395 RVA: 0x0034CBE4 File Offset: 0x0034ADE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<POI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.__c>.NativeClassPtr);
				POI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9");
				POI.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9__27_1");
				POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100685716);
				POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100685717);
			}

			// Token: 0x0600E034 RID: 57396 RVA: 0x0034CC60 File Offset: 0x0034AE60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E035 RID: 57397 RVA: 0x0034CC9C File Offset: 0x0034AE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311224, XrefRangeEnd = 311232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__27_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E036 RID: 57398 RVA: 0x0006D4F9 File Offset: 0x0006B6F9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004579 RID: 17785
			// (get) Token: 0x0600E037 RID: 57399 RVA: 0x0034CCD8 File Offset: 0x0034AED8
			// (set) Token: 0x0600E038 RID: 57400 RVA: 0x0006D502 File Offset: 0x0006B702
			public unsafe static POI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457A RID: 17786
			// (get) Token: 0x0600E039 RID: 57401 RVA: 0x0034CD00 File Offset: 0x0034AF00
			// (set) Token: 0x0600E03A RID: 57402 RVA: 0x0006D514 File Offset: 0x0006B714
			public unsafe static Func<bool> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009623 RID: 38435
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009624 RID: 38436
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04009625 RID: 38437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009626 RID: 38438
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__27_1_Internal_Boolean_0;
		}
	}
}
