using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000475 RID: 1141
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x06006282 RID: 25218 RVA: 0x001BFBDC File Offset: 0x001BDDDC
		// Note: this type is marked as 'beforefieldinit'.
		static RebindActionUI()
		{
			Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "RebindActionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr);
			RebindActionUI.NativeFieldInfoPtr_onRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "onRebind");
			RebindActionUI.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_Action");
			RebindActionUI.NativeFieldInfoPtr_m_BindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingId");
			RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_DisplayStringOptions");
			RebindActionUI.NativeFieldInfoPtr_m_ActionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_ActionLabel");
			RebindActionUI.NativeFieldInfoPtr_m_BindingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingText");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOverlay");
			RebindActionUI.NativeFieldInfoPtr_m_RebindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindText");
			RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_UpdateBindingUIEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStartEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStopEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOperation");
			RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "s_RebindActionUIs");
			RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675778);
			RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675779);
			RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675780);
			RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675781);
			RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675782);
			RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675783);
			RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675784);
			RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675785);
			RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675786);
			RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675787);
			RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675788);
			RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675789);
			RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675790);
			RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675791);
			RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675792);
			RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675793);
			RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675794);
			RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675795);
			RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675796);
			RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675797);
			RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675798);
			RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675799);
			RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675800);
			RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675801);
			RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675802);
			RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675803);
			RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675804);
			RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675805);
			RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675806);
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x001BFF54 File Offset: 0x001BE154
		// (set) Token: 0x06006284 RID: 25220 RVA: 0x001BFF94 File Offset: 0x001BE194
		public unsafe InputActionReference actionReference
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202190, XrefRangeEnd = 202193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x001BFFD8 File Offset: 0x001BE1D8
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x001C0010 File Offset: 0x001BE210
		public unsafe string bindingId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202193, XrefRangeEnd = 202195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x001C0054 File Offset: 0x001BE254
		// (set) Token: 0x06006288 RID: 25224 RVA: 0x001C0090 File Offset: 0x001BE290
		public unsafe InputBinding.DisplayStringOptions displayStringOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202195, XrefRangeEnd = 202196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x001C00D0 File Offset: 0x001BE2D0
		// (set) Token: 0x0600628A RID: 25226 RVA: 0x001C0110 File Offset: 0x001BE310
		public unsafe TextMeshProUGUI actionLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202196, XrefRangeEnd = 202198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x001C0154 File Offset: 0x001BE354
		// (set) Token: 0x0600628C RID: 25228 RVA: 0x001C0194 File Offset: 0x001BE394
		public unsafe TextMeshProUGUI bindingText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202198, XrefRangeEnd = 202200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x001C01D8 File Offset: 0x001BE3D8
		// (set) Token: 0x0600628E RID: 25230 RVA: 0x001C0218 File Offset: 0x001BE418
		public unsafe TextMeshProUGUI rebindPrompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x001C025C File Offset: 0x001BE45C
		// (set) Token: 0x06006290 RID: 25232 RVA: 0x001C029C File Offset: 0x001BE49C
		public unsafe GameObject rebindOverlay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x001C02E0 File Offset: 0x001BE4E0
		public unsafe RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202200, XrefRangeEnd = 202207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06006292 RID: 25234 RVA: 0x001C0320 File Offset: 0x001BE520
		public unsafe RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202207, XrefRangeEnd = 202214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x001C0360 File Offset: 0x001BE560
		public unsafe RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202214, XrefRangeEnd = 202221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06006294 RID: 25236 RVA: 0x001C03A0 File Offset: 0x001BE5A0
		public unsafe InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45803, RefRangeEnd = 45804, XrefRangeStart = 45803, XrefRangeEnd = 45804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x001C03E0 File Offset: 0x001BE5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202221, XrefRangeEnd = 202243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bindingIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x001C044C File Offset: 0x001BE64C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 202266, RefRangeEnd = 202276, XrefRangeStart = 202243, XrefRangeEnd = 202266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindingDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x001C0480 File Offset: 0x001BE680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202276, XrefRangeEnd = 202306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x001C04B4 File Offset: 0x001BE6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202306, XrefRangeEnd = 202345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInteractiveRebind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x001C04E8 File Offset: 0x001BE6E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202410, RefRangeEnd = 202412, XrefRangeStart = 202345, XrefRangeEnd = 202410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allCompositeParts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x001C0548 File Offset: 0x001BE748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202412, XrefRangeEnd = 202441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x001C057C File Offset: 0x001BE77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202441, XrefRangeEnd = 202462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x001C05B0 File Offset: 0x001BE7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202462, XrefRangeEnd = 202489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActionChange(Il2CppSystem.Object obj, InputActionChange change)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x001C05F4 File Offset: 0x001BE7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202497, RefRangeEnd = 202499, XrefRangeStart = 202489, XrefRangeEnd = 202497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x001C0628 File Offset: 0x001BE828
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindActionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x001C0664 File Offset: 0x001BE864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202499, XrefRangeEnd = 202502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateBindingDisplay_b__31_0(InputBinding x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x0002E970 File Offset: 0x0002CB70
		public RebindActionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x001C06B8 File Offset: 0x001BE8B8
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x0002E979 File Offset: 0x0002CB79
		public unsafe Action onRebind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x001C06E8 File Offset: 0x001BE8E8
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0002E998 File Offset: 0x0002CB98
		public unsafe InputActionReference m_Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x001C0718 File Offset: 0x001BE918
		// (set) Token: 0x060062A6 RID: 25254 RVA: 0x0002E9B7 File Offset: 0x0002CBB7
		public unsafe string m_BindingId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x001C0740 File Offset: 0x001BE940
		// (set) Token: 0x060062A8 RID: 25256 RVA: 0x0002E9D6 File Offset: 0x0002CBD6
		public unsafe InputBinding.DisplayStringOptions m_DisplayStringOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions)) = value;
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x001C0768 File Offset: 0x001BE968
		// (set) Token: 0x060062AA RID: 25258 RVA: 0x0002E9F1 File Offset: 0x0002CBF1
		public unsafe TextMeshProUGUI m_ActionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x060062AB RID: 25259 RVA: 0x001C0798 File Offset: 0x001BE998
		// (set) Token: 0x060062AC RID: 25260 RVA: 0x0002EA10 File Offset: 0x0002CC10
		public unsafe TextMeshProUGUI m_BindingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x060062AD RID: 25261 RVA: 0x001C07C8 File Offset: 0x001BE9C8
		// (set) Token: 0x060062AE RID: 25262 RVA: 0x0002EA2F File Offset: 0x0002CC2F
		public unsafe GameObject m_RebindOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x060062AF RID: 25263 RVA: 0x001C07F8 File Offset: 0x001BE9F8
		// (set) Token: 0x060062B0 RID: 25264 RVA: 0x0002EA4E File Offset: 0x0002CC4E
		public unsafe TextMeshProUGUI m_RebindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x001C0828 File Offset: 0x001BEA28
		// (set) Token: 0x060062B2 RID: 25266 RVA: 0x0002EA6D File Offset: 0x0002CC6D
		public unsafe RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x060062B3 RID: 25267 RVA: 0x001C0858 File Offset: 0x001BEA58
		// (set) Token: 0x060062B4 RID: 25268 RVA: 0x0002EA8C File Offset: 0x0002CC8C
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x001C0888 File Offset: 0x001BEA88
		// (set) Token: 0x060062B6 RID: 25270 RVA: 0x0002EAAB File Offset: 0x0002CCAB
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStopEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x060062B7 RID: 25271 RVA: 0x001C08B8 File Offset: 0x001BEAB8
		// (set) Token: 0x060062B8 RID: 25272 RVA: 0x0002EACA File Offset: 0x0002CCCA
		public unsafe InputActionRebindingExtensions.RebindingOperation m_RebindOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x001C08E8 File Offset: 0x001BEAE8
		// (set) Token: 0x060062BA RID: 25274 RVA: 0x0002EAE9 File Offset: 0x0002CCE9
		public unsafe static List<RebindActionUI> s_RebindActionUIs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RebindActionUI>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeFieldInfoPtr_onRebind;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeFieldInfoPtr_m_Action;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingId;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayStringOptions;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionLabel;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingText;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOverlay;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindText;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateBindingUIEvent;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStartEvent;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStopEvent;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOperation;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeFieldInfoPtr_s_RebindActionUIs;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingId_Public_get_String_0;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0;

		// Token: 0x0400433C RID: 17212
		private static readonly IntPtr NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0;

		// Token: 0x0400433D RID: 17213
		private static readonly IntPtr NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0;

		// Token: 0x0400433E RID: 17214
		private static readonly IntPtr NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0;

		// Token: 0x0400433F RID: 17215
		private static readonly IntPtr NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004340 RID: 17216
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004341 RID: 17217
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004342 RID: 17218
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0;

		// Token: 0x04004343 RID: 17219
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04004344 RID: 17220
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0;

		// Token: 0x04004345 RID: 17221
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0;

		// Token: 0x04004346 RID: 17222
		private static readonly IntPtr NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0;

		// Token: 0x04004347 RID: 17223
		private static readonly IntPtr NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x04004348 RID: 17224
		private static readonly IntPtr NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x04004349 RID: 17225
		private static readonly IntPtr NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0;

		// Token: 0x0400434A RID: 17226
		private static readonly IntPtr NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0;

		// Token: 0x0400434B RID: 17227
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0;

		// Token: 0x0400434C RID: 17228
		private static readonly IntPtr NativeMethodInfoPtr_ResetToDefault_Public_Void_0;

		// Token: 0x0400434D RID: 17229
		private static readonly IntPtr NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0;

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0;

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeMethodInfoPtr__UpdateBindingDisplay_b__31_0_Private_Boolean_InputBinding_0;

		// Token: 0x02000A21 RID: 2593
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x0600CF1B RID: 53019 RVA: 0x00064BD2 File Offset: 0x00062DD2
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateBindingUIEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "UpdateBindingUIEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr);
				RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr, 100675807);
			}

			// Token: 0x0600CF1C RID: 53020 RVA: 0x0031C6F8 File Offset: 0x0031A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202150, XrefRangeEnd = 202153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateBindingUIEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF1D RID: 53021 RVA: 0x00064C06 File Offset: 0x00062E06
			public UpdateBindingUIEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008BC2 RID: 35778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A22 RID: 2594
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x0600CF1E RID: 53022 RVA: 0x00064C0F File Offset: 0x00062E0F
			// Note: this type is marked as 'beforefieldinit'.
			static InteractiveRebindEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "InteractiveRebindEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr);
				RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr, 100675808);
			}

			// Token: 0x0600CF1F RID: 53023 RVA: 0x0031C734 File Offset: 0x0031A934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202153, XrefRangeEnd = 202156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractiveRebindEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF20 RID: 53024 RVA: 0x00064C43 File Offset: 0x00062E43
			public InteractiveRebindEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008BC3 RID: 35779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A23 RID: 2595
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF21 RID: 53025 RVA: 0x0031C770 File Offset: 0x0031A970
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, "bindingId");
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100675809);
				RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr, 100675810);
			}

			// Token: 0x0600CF22 RID: 53026 RVA: 0x0031C7D8 File Offset: 0x0031A9D8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF23 RID: 53027 RVA: 0x0031C814 File Offset: 0x0031AA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202156, XrefRangeEnd = 202158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveActionAndBinding_b__0(InputBinding x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF24 RID: 53028 RVA: 0x00064C4C File Offset: 0x00062E4C
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004066 RID: 16486
			// (get) Token: 0x0600CF25 RID: 53029 RVA: 0x0031C868 File Offset: 0x0031AA68
			// (set) Token: 0x0600CF26 RID: 53030 RVA: 0x00064C55 File Offset: 0x00062E55
			public unsafe Guid bindingId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass30_0.NativeFieldInfoPtr_bindingId)) = value;
				}
			}

			// Token: 0x04008BC4 RID: 35780
			private static readonly IntPtr NativeFieldInfoPtr_bindingId;

			// Token: 0x04008BC5 RID: 35781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BC6 RID: 35782
			private static readonly IntPtr NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0;
		}

		// Token: 0x02000A24 RID: 2596
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF27 RID: 53031 RVA: 0x0031C890 File Offset: 0x0031AA90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "allCompositeParts");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "bindingIndex");
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "action");
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675811);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675812);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675813);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675814);
			}

			// Token: 0x0600CF28 RID: 53032 RVA: 0x0031C95C File Offset: 0x0031AB5C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF29 RID: 53033 RVA: 0x0031C998 File Offset: 0x0031AB98
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 202163, RefRangeEnd = 202165, XrefRangeStart = 202158, XrefRangeEnd = 202163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF2A RID: 53034 RVA: 0x0031C9CC File Offset: 0x0031ABCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202165, XrefRangeEnd = 202176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__1(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF2B RID: 53035 RVA: 0x0031CA10 File Offset: 0x0031AC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202176, XrefRangeEnd = 202190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__2(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF2C RID: 53036 RVA: 0x00064C70 File Offset: 0x00062E70
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004067 RID: 16487
			// (get) Token: 0x0600CF2D RID: 53037 RVA: 0x0031CA54 File Offset: 0x0031AC54
			// (set) Token: 0x0600CF2E RID: 53038 RVA: 0x00064C79 File Offset: 0x00062E79
			public unsafe RebindActionUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004068 RID: 16488
			// (get) Token: 0x0600CF2F RID: 53039 RVA: 0x0031CA84 File Offset: 0x0031AC84
			// (set) Token: 0x0600CF30 RID: 53040 RVA: 0x00064C98 File Offset: 0x00062E98
			public unsafe bool allCompositeParts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_allCompositeParts)) = value;
				}
			}

			// Token: 0x17004069 RID: 16489
			// (get) Token: 0x0600CF31 RID: 53041 RVA: 0x0031CAAC File Offset: 0x0031ACAC
			// (set) Token: 0x0600CF32 RID: 53042 RVA: 0x00064CB3 File Offset: 0x00062EB3
			public unsafe int bindingIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingIndex)) = value;
				}
			}

			// Token: 0x1700406A RID: 16490
			// (get) Token: 0x0600CF33 RID: 53043 RVA: 0x0031CAD4 File Offset: 0x0031ACD4
			// (set) Token: 0x0600CF34 RID: 53044 RVA: 0x00064CCE File Offset: 0x00062ECE
			public unsafe InputAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BC7 RID: 35783
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BC8 RID: 35784
			private static readonly IntPtr NativeFieldInfoPtr_allCompositeParts;

			// Token: 0x04008BC9 RID: 35785
			private static readonly IntPtr NativeFieldInfoPtr_bindingIndex;

			// Token: 0x04008BCA RID: 35786
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04008BCB RID: 35787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BCC RID: 35788
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04008BCD RID: 35789
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0;

			// Token: 0x04008BCE RID: 35790
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0;
		}
	}
}
