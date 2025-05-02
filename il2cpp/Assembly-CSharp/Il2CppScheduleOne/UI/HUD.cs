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
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000641 RID: 1601
	public class HUD : Singleton<HUD>
	{
		// Token: 0x06008DA2 RID: 36258 RVA: 0x0024E500 File Offset: 0x0024C700
		// Note: this type is marked as 'beforefieldinit'.
		static HUD()
		{
			Il2CppClassPointerStore<HUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HUD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD>.NativeClassPtr);
			HUD.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvas");
			HUD.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvasRect");
			HUD.NativeFieldInfoPtr_crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "crosshair");
			HUD.NativeFieldInfoPtr_blackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlay");
			HUD.NativeFieldInfoPtr_radialIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicator");
			HUD.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "raycaster");
			HUD.NativeFieldInfoPtr_topScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText");
			HUD.NativeFieldInfoPtr_topScreenText_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText_Background");
			HUD.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "fpsLabel");
			HUD.NativeFieldInfoPtr_cashSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotContainer");
			HUD.NativeFieldInfoPtr_cashSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotUI");
			HUD.NativeFieldInfoPtr_onlineBalanceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceContainer");
			HUD.NativeFieldInfoPtr_onlineBalanceSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceSlotUI");
			HUD.NativeFieldInfoPtr_managementSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotContainer");
			HUD.NativeFieldInfoPtr_managementSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotUI");
			HUD.NativeFieldInfoPtr_HotbarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "HotbarContainer");
			HUD.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SlotContainer");
			HUD.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlot");
			HUD.NativeFieldInfoPtr_discardSlotFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlotFill");
			HUD.NativeFieldInfoPtr_selectedItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "selectedItemLabel");
			HUD.NativeFieldInfoPtr_QuestEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryContainer");
			HUD.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryTitle");
			HUD.NativeFieldInfoPtr_CrimeStatusUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrimeStatusUI");
			HUD.NativeFieldInfoPtr_OnlineBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "OnlineBalanceDisplay");
			HUD.NativeFieldInfoPtr_SafeBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SafeBalanceDisplay");
			HUD.NativeFieldInfoPtr_CrosshairText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrosshairText");
			HUD.NativeFieldInfoPtr_UnreadMessagesPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "UnreadMessagesPrompt");
			HUD.NativeFieldInfoPtr_SleepPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SleepPrompt");
			HUD.NativeFieldInfoPtr_CurfewPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CurfewPrompt");
			HUD.NativeFieldInfoPtr_RedGreenGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "RedGreenGradient");
			HUD.NativeFieldInfoPtr_SampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SampleSize");
			HUD.NativeFieldInfoPtr__previousFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "_previousFPS");
			HUD.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "eventSystem");
			HUD.NativeFieldInfoPtr_blackOverlayFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlayFade");
			HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicatorSetThisFrame");
			HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680905);
			HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680906);
			HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680907);
			HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680908);
			HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680909);
			HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680910);
			HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680911);
			HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680912);
			HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680913);
			HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680914);
			HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680915);
			HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680916);
			HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680917);
			HUD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680918);
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x0024E904 File Offset: 0x0024CB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258407, XrefRangeEnd = 258420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x0024E940 File Offset: 0x0024CB40
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 258423, RefRangeEnd = 258455, XrefRangeStart = 258420, XrefRangeEnd = 258423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrosshairVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x0024E980 File Offset: 0x0024CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258455, XrefRangeEnd = 258463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x0024E9CC File Offset: 0x0024CBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258463, XrefRangeEnd = 258464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x0024EA08 File Offset: 0x0024CC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258464, XrefRangeEnd = 258499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x0024EA3C File Offset: 0x0024CC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258499, XrefRangeEnd = 258506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuestEntryTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x0024EA70 File Offset: 0x0024CC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258525, RefRangeEnd = 258526, XrefRangeStart = 258506, XrefRangeEnd = 258525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x0024EAA4 File Offset: 0x0024CCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258526, XrefRangeEnd = 258531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x0024EAE0 File Offset: 0x0024CCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258531, XrefRangeEnd = 258532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x0024EB1C File Offset: 0x0024CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258532, XrefRangeEnd = 258537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x0024EB78 File Offset: 0x0024CD78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258540, RefRangeEnd = 258545, XrefRangeStart = 258537, XrefRangeEnd = 258540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRadialIndicator(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x0024EBB8 File Offset: 0x0024CDB8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 258550, RefRangeEnd = 258559, XrefRangeStart = 258545, XrefRangeEnd = 258550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTopScreenText(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x0024EBFC File Offset: 0x0024CDFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 258562, RefRangeEnd = 258569, XrefRangeStart = 258559, XrefRangeEnd = 258562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTopScreenText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x0024EC30 File Offset: 0x0024CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258569, XrefRangeEnd = 258579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HUD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00043FA9 File Offset: 0x000421A9
		public HUD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x0024EC6C File Offset: 0x0024CE6C
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x00043FB2 File Offset: 0x000421B2
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x0024EC9C File Offset: 0x0024CE9C
		// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x00043FD1 File Offset: 0x000421D1
		public unsafe RectTransform canvasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x0024ECCC File Offset: 0x0024CECC
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x00043FF0 File Offset: 0x000421F0
		public unsafe Image crosshair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x0024ECFC File Offset: 0x0024CEFC
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x0004400F File Offset: 0x0004220F
		public unsafe Image blackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x06008DBA RID: 36282 RVA: 0x0024ED2C File Offset: 0x0024CF2C
		// (set) Token: 0x06008DBB RID: 36283 RVA: 0x0004402E File Offset: 0x0004222E
		public unsafe Image radialIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x06008DBC RID: 36284 RVA: 0x0024ED5C File Offset: 0x0024CF5C
		// (set) Token: 0x06008DBD RID: 36285 RVA: 0x0004404D File Offset: 0x0004224D
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x06008DBE RID: 36286 RVA: 0x0024ED8C File Offset: 0x0024CF8C
		// (set) Token: 0x06008DBF RID: 36287 RVA: 0x0004406C File Offset: 0x0004226C
		public unsafe TextMeshProUGUI topScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x0024EDBC File Offset: 0x0024CFBC
		// (set) Token: 0x06008DC1 RID: 36289 RVA: 0x0004408B File Offset: 0x0004228B
		public unsafe RectTransform topScreenText_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x0024EDEC File Offset: 0x0024CFEC
		// (set) Token: 0x06008DC3 RID: 36291 RVA: 0x000440AA File Offset: 0x000422AA
		public unsafe Text fpsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x0024EE1C File Offset: 0x0024D01C
		// (set) Token: 0x06008DC5 RID: 36293 RVA: 0x000440C9 File Offset: 0x000422C9
		public unsafe RectTransform cashSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x0024EE4C File Offset: 0x0024D04C
		// (set) Token: 0x06008DC7 RID: 36295 RVA: 0x000440E8 File Offset: 0x000422E8
		public unsafe RectTransform cashSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x0024EE7C File Offset: 0x0024D07C
		// (set) Token: 0x06008DC9 RID: 36297 RVA: 0x00044107 File Offset: 0x00042307
		public unsafe RectTransform onlineBalanceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x0024EEAC File Offset: 0x0024D0AC
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x00044126 File Offset: 0x00042326
		public unsafe RectTransform onlineBalanceSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06008DCC RID: 36300 RVA: 0x0024EEDC File Offset: 0x0024D0DC
		// (set) Token: 0x06008DCD RID: 36301 RVA: 0x00044145 File Offset: 0x00042345
		public unsafe RectTransform managementSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x0024EF0C File Offset: 0x0024D10C
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x00044164 File Offset: 0x00042364
		public unsafe ItemSlotUI managementSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x0024EF3C File Offset: 0x0024D13C
		// (set) Token: 0x06008DD1 RID: 36305 RVA: 0x00044183 File Offset: 0x00042383
		public unsafe RectTransform HotbarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x06008DD2 RID: 36306 RVA: 0x0024EF6C File Offset: 0x0024D16C
		// (set) Token: 0x06008DD3 RID: 36307 RVA: 0x000441A2 File Offset: 0x000423A2
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x06008DD4 RID: 36308 RVA: 0x0024EF9C File Offset: 0x0024D19C
		// (set) Token: 0x06008DD5 RID: 36309 RVA: 0x000441C1 File Offset: 0x000423C1
		public unsafe ItemSlotUI discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x0024EFCC File Offset: 0x0024D1CC
		// (set) Token: 0x06008DD7 RID: 36311 RVA: 0x000441E0 File Offset: 0x000423E0
		public unsafe Image discardSlotFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x0024EFFC File Offset: 0x0024D1FC
		// (set) Token: 0x06008DD9 RID: 36313 RVA: 0x000441FF File Offset: 0x000423FF
		public unsafe TextMeshProUGUI selectedItemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x0024F02C File Offset: 0x0024D22C
		// (set) Token: 0x06008DDB RID: 36315 RVA: 0x0004421E File Offset: 0x0004241E
		public unsafe RectTransform QuestEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x0024F05C File Offset: 0x0024D25C
		// (set) Token: 0x06008DDD RID: 36317 RVA: 0x0004423D File Offset: 0x0004243D
		public unsafe TextMeshProUGUI QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x0024F08C File Offset: 0x0024D28C
		// (set) Token: 0x06008DDF RID: 36319 RVA: 0x0004425C File Offset: 0x0004245C
		public unsafe CrimeStatusUI CrimeStatusUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x0024F0BC File Offset: 0x0024D2BC
		// (set) Token: 0x06008DE1 RID: 36321 RVA: 0x0004427B File Offset: 0x0004247B
		public unsafe BalanceDisplay OnlineBalanceDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06008DE2 RID: 36322 RVA: 0x0024F0EC File Offset: 0x0024D2EC
		// (set) Token: 0x06008DE3 RID: 36323 RVA: 0x0004429A File Offset: 0x0004249A
		public unsafe BalanceDisplay SafeBalanceDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06008DE4 RID: 36324 RVA: 0x0024F11C File Offset: 0x0024D31C
		// (set) Token: 0x06008DE5 RID: 36325 RVA: 0x000442B9 File Offset: 0x000424B9
		public unsafe CrosshairText CrosshairText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrosshairText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x06008DE6 RID: 36326 RVA: 0x0024F14C File Offset: 0x0024D34C
		// (set) Token: 0x06008DE7 RID: 36327 RVA: 0x000442D8 File Offset: 0x000424D8
		public unsafe RectTransform UnreadMessagesPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x06008DE8 RID: 36328 RVA: 0x0024F17C File Offset: 0x0024D37C
		// (set) Token: 0x06008DE9 RID: 36329 RVA: 0x000442F7 File Offset: 0x000424F7
		public unsafe TextMeshProUGUI SleepPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x06008DEA RID: 36330 RVA: 0x0024F1AC File Offset: 0x0024D3AC
		// (set) Token: 0x06008DEB RID: 36331 RVA: 0x00044316 File Offset: 0x00042516
		public unsafe TextMeshProUGUI CurfewPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06008DEC RID: 36332 RVA: 0x0024F1DC File Offset: 0x0024D3DC
		// (set) Token: 0x06008DED RID: 36333 RVA: 0x00044335 File Offset: 0x00042535
		public unsafe Gradient RedGreenGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x0024F20C File Offset: 0x0024D40C
		// (set) Token: 0x06008DEF RID: 36335 RVA: 0x00044354 File Offset: 0x00042554
		public unsafe int SampleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize)) = value;
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x0024F234 File Offset: 0x0024D434
		// (set) Token: 0x06008DF1 RID: 36337 RVA: 0x0004436F File Offset: 0x0004256F
		public unsafe List<float> _previousFPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x06008DF2 RID: 36338 RVA: 0x0024F264 File Offset: 0x0024D464
		// (set) Token: 0x06008DF3 RID: 36339 RVA: 0x0004438E File Offset: 0x0004258E
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x0024F294 File Offset: 0x0024D494
		// (set) Token: 0x06008DF5 RID: 36341 RVA: 0x000443AD File Offset: 0x000425AD
		public unsafe Coroutine blackOverlayFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x06008DF6 RID: 36342 RVA: 0x0024F2C4 File Offset: 0x0024D4C4
		// (set) Token: 0x06008DF7 RID: 36343 RVA: 0x000443CC File Offset: 0x000425CC
		public unsafe bool radialIndicatorSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame)) = value;
			}
		}

		// Token: 0x04005FF2 RID: 24562
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005FF3 RID: 24563
		private static readonly IntPtr NativeFieldInfoPtr_canvasRect;

		// Token: 0x04005FF4 RID: 24564
		private static readonly IntPtr NativeFieldInfoPtr_crosshair;

		// Token: 0x04005FF5 RID: 24565
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlay;

		// Token: 0x04005FF6 RID: 24566
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicator;

		// Token: 0x04005FF7 RID: 24567
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04005FF8 RID: 24568
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText;

		// Token: 0x04005FF9 RID: 24569
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText_Background;

		// Token: 0x04005FFA RID: 24570
		private static readonly IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x04005FFB RID: 24571
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotContainer;

		// Token: 0x04005FFC RID: 24572
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotUI;

		// Token: 0x04005FFD RID: 24573
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceContainer;

		// Token: 0x04005FFE RID: 24574
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceSlotUI;

		// Token: 0x04005FFF RID: 24575
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotContainer;

		// Token: 0x04006000 RID: 24576
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotUI;

		// Token: 0x04006001 RID: 24577
		private static readonly IntPtr NativeFieldInfoPtr_HotbarContainer;

		// Token: 0x04006002 RID: 24578
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04006003 RID: 24579
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x04006004 RID: 24580
		private static readonly IntPtr NativeFieldInfoPtr_discardSlotFill;

		// Token: 0x04006005 RID: 24581
		private static readonly IntPtr NativeFieldInfoPtr_selectedItemLabel;

		// Token: 0x04006006 RID: 24582
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryContainer;

		// Token: 0x04006007 RID: 24583
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x04006008 RID: 24584
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusUI;

		// Token: 0x04006009 RID: 24585
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalanceDisplay;

		// Token: 0x0400600A RID: 24586
		private static readonly IntPtr NativeFieldInfoPtr_SafeBalanceDisplay;

		// Token: 0x0400600B RID: 24587
		private static readonly IntPtr NativeFieldInfoPtr_CrosshairText;

		// Token: 0x0400600C RID: 24588
		private static readonly IntPtr NativeFieldInfoPtr_UnreadMessagesPrompt;

		// Token: 0x0400600D RID: 24589
		private static readonly IntPtr NativeFieldInfoPtr_SleepPrompt;

		// Token: 0x0400600E RID: 24590
		private static readonly IntPtr NativeFieldInfoPtr_CurfewPrompt;

		// Token: 0x0400600F RID: 24591
		private static readonly IntPtr NativeFieldInfoPtr_RedGreenGradient;

		// Token: 0x04006010 RID: 24592
		private static readonly IntPtr NativeFieldInfoPtr_SampleSize;

		// Token: 0x04006011 RID: 24593
		private static readonly IntPtr NativeFieldInfoPtr__previousFPS;

		// Token: 0x04006012 RID: 24594
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006013 RID: 24595
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlayFade;

		// Token: 0x04006014 RID: 24596
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicatorSetThisFrame;

		// Token: 0x04006015 RID: 24597
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006016 RID: 24598
		private static readonly IntPtr NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0;

		// Token: 0x04006017 RID: 24599
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0;

		// Token: 0x04006018 RID: 24600
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006019 RID: 24601
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400601A RID: 24602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0;

		// Token: 0x0400601B RID: 24603
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFPS_Private_Void_0;

		// Token: 0x0400601C RID: 24604
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageFPS_Private_Single_0;

		// Token: 0x0400601D RID: 24605
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400601E RID: 24606
		private static readonly IntPtr NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0;

		// Token: 0x0400601F RID: 24607
		private static readonly IntPtr NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0;

		// Token: 0x04006020 RID: 24608
		private static readonly IntPtr NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0;

		// Token: 0x04006021 RID: 24609
		private static readonly IntPtr NativeMethodInfoPtr_HideTopScreenText_Public_Void_0;

		// Token: 0x04006022 RID: 24610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B29 RID: 2857
		[ObfuscatedName("ScheduleOne.UI.HUD+<FadeBlackOverlay>d__43")]
		public sealed class _FadeBlackOverlay_d__43 : Il2CppSystem.Object
		{
			// Token: 0x0600D7C1 RID: 55233 RVA: 0x00334928 File Offset: 0x00332B28
			// Note: this type is marked as 'beforefieldinit'.
			static _FadeBlackOverlay_d__43()
			{
				Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUD>.NativeClassPtr, "<FadeBlackOverlay>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr);
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>1__state");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>2__current");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "visible");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>4__this");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "fadeTime");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<startAlpha>5__2");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<endAlpha>5__3");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<i>5__4");
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680919);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680920);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680921);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680922);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680923);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680924);
			}

			// Token: 0x0600D7C2 RID: 55234 RVA: 0x00334A6C File Offset: 0x00332C6C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FadeBlackOverlay_d__43(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7C3 RID: 55235 RVA: 0x00334AB4 File Offset: 0x00332CB4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7C4 RID: 55236 RVA: 0x00334AE8 File Offset: 0x00332CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258386, XrefRangeEnd = 258402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042E6 RID: 17126
			// (get) Token: 0x0600D7C5 RID: 55237 RVA: 0x00334B24 File Offset: 0x00332D24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7C6 RID: 55238 RVA: 0x00334B64 File Offset: 0x00332D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258402, XrefRangeEnd = 258407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042E7 RID: 17127
			// (get) Token: 0x0600D7C7 RID: 55239 RVA: 0x00334B98 File Offset: 0x00332D98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7C8 RID: 55240 RVA: 0x000690C7 File Offset: 0x000672C7
			public _FadeBlackOverlay_d__43(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600D7C9 RID: 55241 RVA: 0x00334BD8 File Offset: 0x00332DD8
			// (set) Token: 0x0600D7CA RID: 55242 RVA: 0x000690D0 File Offset: 0x000672D0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600D7CB RID: 55243 RVA: 0x00334C00 File Offset: 0x00332E00
			// (set) Token: 0x0600D7CC RID: 55244 RVA: 0x000690EB File Offset: 0x000672EB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600D7CD RID: 55245 RVA: 0x00334C30 File Offset: 0x00332E30
			// (set) Token: 0x0600D7CE RID: 55246 RVA: 0x0006910A File Offset: 0x0006730A
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600D7CF RID: 55247 RVA: 0x00334C58 File Offset: 0x00332E58
			// (set) Token: 0x0600D7D0 RID: 55248 RVA: 0x00069125 File Offset: 0x00067325
			public unsafe HUD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HUD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E2 RID: 17122
			// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x00334C88 File Offset: 0x00332E88
			// (set) Token: 0x0600D7D2 RID: 55250 RVA: 0x00069144 File Offset: 0x00067344
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170042E3 RID: 17123
			// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x00334CB0 File Offset: 0x00332EB0
			// (set) Token: 0x0600D7D4 RID: 55252 RVA: 0x0006915F File Offset: 0x0006735F
			public unsafe float _startAlpha_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2)) = value;
				}
			}

			// Token: 0x170042E4 RID: 17124
			// (get) Token: 0x0600D7D5 RID: 55253 RVA: 0x00334CD8 File Offset: 0x00332ED8
			// (set) Token: 0x0600D7D6 RID: 55254 RVA: 0x0006917A File Offset: 0x0006737A
			public unsafe float _endAlpha_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3)) = value;
				}
			}

			// Token: 0x170042E5 RID: 17125
			// (get) Token: 0x0600D7D7 RID: 55255 RVA: 0x00334D00 File Offset: 0x00332F00
			// (set) Token: 0x0600D7D8 RID: 55256 RVA: 0x00069195 File Offset: 0x00067395
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009103 RID: 37123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009104 RID: 37124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009105 RID: 37125
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x04009106 RID: 37126
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009107 RID: 37127
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009108 RID: 37128
			private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

			// Token: 0x04009109 RID: 37129
			private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__3;

			// Token: 0x0400910A RID: 37130
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400910B RID: 37131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400910C RID: 37132
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400910D RID: 37133
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400910E RID: 37134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400910F RID: 37135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009110 RID: 37136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
