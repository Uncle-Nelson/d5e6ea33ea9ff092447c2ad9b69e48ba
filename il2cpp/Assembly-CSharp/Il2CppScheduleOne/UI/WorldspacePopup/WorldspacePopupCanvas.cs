using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000677 RID: 1655
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x060093CF RID: 37839 RVA: 0x002603EC File Offset: 0x0025E5EC
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupCanvas()
		{
			Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr);
			WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WORLDSPACE_ICON_SCALE_MULTIPLIER");
			WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WorldspaceContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudIconContainerPrefab");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeWorldspaceUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeHUDUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "popupsWithUI");
			WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681617);
			WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681618);
			WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681619);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681620);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681621);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681622);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681623);
			WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681624);
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00260548 File Offset: 0x0025E748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265960, XrefRangeEnd = 266072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x0026057C File Offset: 0x0025E77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266072, XrefRangeEnd = 266170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x002605B0 File Offset: 0x0025E7B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266183, RefRangeEnd = 266185, XrefRangeStart = 266170, XrefRangeEnd = 266183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldCreateUI(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x00260600 File Offset: 0x0025E800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266185, XrefRangeEnd = 266197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00260650 File Offset: 0x0025E850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266225, RefRangeEnd = 266226, XrefRangeStart = 266197, XrefRangeEnd = 266225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x002606A0 File Offset: 0x0025E8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266226, XrefRangeEnd = 266244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x002606E4 File Offset: 0x0025E8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266270, RefRangeEnd = 266271, XrefRangeStart = 266244, XrefRangeEnd = 266270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x00260728 File Offset: 0x0025E928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266271, XrefRangeEnd = 266293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x00047AC7 File Offset: 0x00045CC7
		public WorldspacePopupCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x060093D9 RID: 37849 RVA: 0x00260764 File Offset: 0x0025E964
		// (set) Token: 0x060093DA RID: 37850 RVA: 0x00047AD0 File Offset: 0x00045CD0
		public unsafe static float WORLDSPACE_ICON_SCALE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x00260780 File Offset: 0x0025E980
		// (set) Token: 0x060093DC RID: 37852 RVA: 0x00047ADE File Offset: 0x00045CDE
		public unsafe RectTransform WorldspaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x002607B0 File Offset: 0x0025E9B0
		// (set) Token: 0x060093DE RID: 37854 RVA: 0x00047AFD File Offset: 0x00045CFD
		public unsafe RectTransform HudContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x060093DF RID: 37855 RVA: 0x002607E0 File Offset: 0x0025E9E0
		// (set) Token: 0x060093E0 RID: 37856 RVA: 0x00047B1C File Offset: 0x00045D1C
		public unsafe GameObject HudIconContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x060093E1 RID: 37857 RVA: 0x00260810 File Offset: 0x0025EA10
		// (set) Token: 0x060093E2 RID: 37858 RVA: 0x00047B3B File Offset: 0x00045D3B
		public unsafe List<WorldspacePopupUI> activeWorldspaceUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x060093E3 RID: 37859 RVA: 0x00260840 File Offset: 0x0025EA40
		// (set) Token: 0x060093E4 RID: 37860 RVA: 0x00047B5A File Offset: 0x00045D5A
		public unsafe List<RectTransform> activeHUDUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x060093E5 RID: 37861 RVA: 0x00260870 File Offset: 0x0025EA70
		// (set) Token: 0x060093E6 RID: 37862 RVA: 0x00047B79 File Offset: 0x00045D79
		public unsafe List<WorldspacePopup> popupsWithUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063C0 RID: 25536
		private static readonly IntPtr NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER;

		// Token: 0x040063C1 RID: 25537
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceContainer;

		// Token: 0x040063C2 RID: 25538
		private static readonly IntPtr NativeFieldInfoPtr_HudContainer;

		// Token: 0x040063C3 RID: 25539
		private static readonly IntPtr NativeFieldInfoPtr_HudIconContainerPrefab;

		// Token: 0x040063C4 RID: 25540
		private static readonly IntPtr NativeFieldInfoPtr_activeWorldspaceUIs;

		// Token: 0x040063C5 RID: 25541
		private static readonly IntPtr NativeFieldInfoPtr_activeHUDUIs;

		// Token: 0x040063C6 RID: 25542
		private static readonly IntPtr NativeFieldInfoPtr_popupsWithUI;

		// Token: 0x040063C7 RID: 25543
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040063C8 RID: 25544
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040063C9 RID: 25545
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0;

		// Token: 0x040063CA RID: 25546
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0;

		// Token: 0x040063CB RID: 25547
		private static readonly IntPtr NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0;

		// Token: 0x040063CC RID: 25548
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x040063CD RID: 25549
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x040063CE RID: 25550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
