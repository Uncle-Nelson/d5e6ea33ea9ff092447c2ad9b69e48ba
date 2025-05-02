using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000676 RID: 1654
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x060093AA RID: 37802 RVA: 0x0025FE14 File Offset: 0x0025E014
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopup()
		{
			Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr);
			WorldspacePopup.NativeFieldInfoPtr_ActivePopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ActivePopups");
			WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "CurrentFillLevel");
			WorldspacePopup.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIPrefab");
			WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "DisplayOnHUD");
			WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ScaleWithDistance");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceOffset");
			WorldspacePopup.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "Range");
			WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "SizeMultiplier");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUIIcon");
			WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUICanvasGroup");
			WorldspacePopup.NativeFieldInfoPtr_UIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIs");
			WorldspacePopup.NativeFieldInfoPtr_popupCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "popupCoroutine");
			WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681601);
			WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681602);
			WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681603);
			WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681604);
			WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681605);
			WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681606);
			WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681608);
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x0025FFE8 File Offset: 0x0025E1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265873, XrefRangeEnd = 265886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x0026001C File Offset: 0x0025E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265886, XrefRangeEnd = 265894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00260050 File Offset: 0x0025E250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265920, RefRangeEnd = 265923, XrefRangeStart = 265894, XrefRangeEnd = 265920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateUI(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x002600A0 File Offset: 0x0025E2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265923, XrefRangeEnd = 265938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x002600D4 File Offset: 0x0025E2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265946, RefRangeEnd = 265947, XrefRangeStart = 265938, XrefRangeEnd = 265946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Popup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00260108 File Offset: 0x0025E308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265947, XrefRangeEnd = 265955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x00260144 File Offset: 0x0025E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265955, XrefRangeEnd = 265960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00047931 File Offset: 0x00045B31
		public WorldspacePopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x00260184 File Offset: 0x0025E384
		// (set) Token: 0x060093B4 RID: 37812 RVA: 0x0004793A File Offset: 0x00045B3A
		public unsafe static List<WorldspacePopup> ActivePopups
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x002601AC File Offset: 0x0025E3AC
		// (set) Token: 0x060093B6 RID: 37814 RVA: 0x0004794C File Offset: 0x00045B4C
		public unsafe float CurrentFillLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel)) = value;
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x060093B7 RID: 37815 RVA: 0x002601D4 File Offset: 0x0025E3D4
		// (set) Token: 0x060093B8 RID: 37816 RVA: 0x00047967 File Offset: 0x00045B67
		public unsafe WorldspacePopupUI UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x060093B9 RID: 37817 RVA: 0x00260204 File Offset: 0x0025E404
		// (set) Token: 0x060093BA RID: 37818 RVA: 0x00047986 File Offset: 0x00045B86
		public unsafe bool DisplayOnHUD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD)) = value;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x060093BB RID: 37819 RVA: 0x0026022C File Offset: 0x0025E42C
		// (set) Token: 0x060093BC RID: 37820 RVA: 0x000479A1 File Offset: 0x00045BA1
		public unsafe bool ScaleWithDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance)) = value;
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x00260254 File Offset: 0x0025E454
		// (set) Token: 0x060093BE RID: 37822 RVA: 0x000479BC File Offset: 0x00045BBC
		public unsafe Vector3 WorldspaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset)) = value;
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x0026027C File Offset: 0x0025E47C
		// (set) Token: 0x060093C0 RID: 37824 RVA: 0x000479D7 File Offset: 0x00045BD7
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x002602A4 File Offset: 0x0025E4A4
		// (set) Token: 0x060093C2 RID: 37826 RVA: 0x000479F2 File Offset: 0x00045BF2
		public unsafe float SizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier)) = value;
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x002602CC File Offset: 0x0025E4CC
		// (set) Token: 0x060093C4 RID: 37828 RVA: 0x00047A0D File Offset: 0x00045C0D
		public unsafe WorldspacePopupUI WorldspaceUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x002602FC File Offset: 0x0025E4FC
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00047A2C File Offset: 0x00045C2C
		public unsafe RectTransform HUDUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x0026032C File Offset: 0x0025E52C
		// (set) Token: 0x060093C8 RID: 37832 RVA: 0x00047A4B File Offset: 0x00045C4B
		public unsafe WorldspacePopupUI HUDUIIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x0026035C File Offset: 0x0025E55C
		// (set) Token: 0x060093CA RID: 37834 RVA: 0x00047A6A File Offset: 0x00045C6A
		public unsafe CanvasGroup HUDUICanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x0026038C File Offset: 0x0025E58C
		// (set) Token: 0x060093CC RID: 37836 RVA: 0x00047A89 File Offset: 0x00045C89
		public unsafe List<WorldspacePopupUI> UIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x060093CD RID: 37837 RVA: 0x002603BC File Offset: 0x0025E5BC
		// (set) Token: 0x060093CE RID: 37838 RVA: 0x00047AA8 File Offset: 0x00045CA8
		public unsafe Coroutine popupCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063AB RID: 25515
		private static readonly IntPtr NativeFieldInfoPtr_ActivePopups;

		// Token: 0x040063AC RID: 25516
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillLevel;

		// Token: 0x040063AD RID: 25517
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x040063AE RID: 25518
		private static readonly IntPtr NativeFieldInfoPtr_DisplayOnHUD;

		// Token: 0x040063AF RID: 25519
		private static readonly IntPtr NativeFieldInfoPtr_ScaleWithDistance;

		// Token: 0x040063B0 RID: 25520
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceOffset;

		// Token: 0x040063B1 RID: 25521
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x040063B2 RID: 25522
		private static readonly IntPtr NativeFieldInfoPtr_SizeMultiplier;

		// Token: 0x040063B3 RID: 25523
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUI;

		// Token: 0x040063B4 RID: 25524
		private static readonly IntPtr NativeFieldInfoPtr_HUDUI;

		// Token: 0x040063B5 RID: 25525
		private static readonly IntPtr NativeFieldInfoPtr_HUDUIIcon;

		// Token: 0x040063B6 RID: 25526
		private static readonly IntPtr NativeFieldInfoPtr_HUDUICanvasGroup;

		// Token: 0x040063B7 RID: 25527
		private static readonly IntPtr NativeFieldInfoPtr_UIs;

		// Token: 0x040063B8 RID: 25528
		private static readonly IntPtr NativeFieldInfoPtr_popupCoroutine;

		// Token: 0x040063B9 RID: 25529
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040063BA RID: 25530
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040063BB RID: 25531
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0;

		// Token: 0x040063BC RID: 25532
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040063BD RID: 25533
		private static readonly IntPtr NativeMethodInfoPtr_Popup_Public_Void_0;

		// Token: 0x040063BE RID: 25534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063BF RID: 25535
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B57 RID: 2903
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<<Popup>g__PopupCoroutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D9FE RID: 55806 RVA: 0x0033B230 File Offset: 0x00339430
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique()
			{
				Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<<Popup>g__PopupCoroutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681609);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681610);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681611);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681612);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681613);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681614);
			}

			// Token: 0x0600D9FF RID: 55807 RVA: 0x0033B338 File Offset: 0x00339538
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA00 RID: 55808 RVA: 0x0033B380 File Offset: 0x00339580
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA01 RID: 55809 RVA: 0x0033B3B4 File Offset: 0x003395B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265860, XrefRangeEnd = 265864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043A7 RID: 17319
			// (get) Token: 0x0600DA02 RID: 55810 RVA: 0x0033B3F0 File Offset: 0x003395F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA03 RID: 55811 RVA: 0x0033B430 File Offset: 0x00339630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265864, XrefRangeEnd = 265869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043A8 RID: 17320
			// (get) Token: 0x0600DA04 RID: 55812 RVA: 0x0033B464 File Offset: 0x00339664
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA05 RID: 55813 RVA: 0x0006A2B4 File Offset: 0x000684B4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A2 RID: 17314
			// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x0033B4A4 File Offset: 0x003396A4
			// (set) Token: 0x0600DA07 RID: 55815 RVA: 0x0006A2BD File Offset: 0x000684BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043A3 RID: 17315
			// (get) Token: 0x0600DA08 RID: 55816 RVA: 0x0033B4CC File Offset: 0x003396CC
			// (set) Token: 0x0600DA09 RID: 55817 RVA: 0x0006A2D8 File Offset: 0x000684D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A4 RID: 17316
			// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x0033B4FC File Offset: 0x003396FC
			// (set) Token: 0x0600DA0B RID: 55819 RVA: 0x0006A2F7 File Offset: 0x000684F7
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A5 RID: 17317
			// (get) Token: 0x0600DA0C RID: 55820 RVA: 0x0033B52C File Offset: 0x0033972C
			// (set) Token: 0x0600DA0D RID: 55821 RVA: 0x0006A316 File Offset: 0x00068516
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x170043A6 RID: 17318
			// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x0033B554 File Offset: 0x00339754
			// (set) Token: 0x0600DA0F RID: 55823 RVA: 0x0006A331 File Offset: 0x00068531
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009263 RID: 37475
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009264 RID: 37476
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009265 RID: 37477
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009266 RID: 37478
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04009267 RID: 37479
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009268 RID: 37480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009269 RID: 37481
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400926A RID: 37482
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400926B RID: 37483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400926C RID: 37484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400926D RID: 37485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B58 RID: 2904
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA10 RID: 55824 RVA: 0x0033B57C File Offset: 0x0033977C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr);
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "newUI");
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681615);
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681616);
			}

			// Token: 0x0600DA11 RID: 55825 RVA: 0x0033B5F8 File Offset: 0x003397F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA12 RID: 55826 RVA: 0x0033B634 File Offset: 0x00339834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265869, XrefRangeEnd = 265873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA13 RID: 55827 RVA: 0x0006A34C File Offset: 0x0006854C
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A9 RID: 17321
			// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x0033B668 File Offset: 0x00339868
			// (set) Token: 0x0600DA15 RID: 55829 RVA: 0x0006A355 File Offset: 0x00068555
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AA RID: 17322
			// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x0033B698 File Offset: 0x00339898
			// (set) Token: 0x0600DA17 RID: 55831 RVA: 0x0006A374 File Offset: 0x00068574
			public unsafe WorldspacePopupUI newUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400926E RID: 37486
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400926F RID: 37487
			private static readonly IntPtr NativeFieldInfoPtr_newUI;

			// Token: 0x04009270 RID: 37488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009271 RID: 37489
			private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0;
		}
	}
}
