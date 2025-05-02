using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069C RID: 1692
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x06009697 RID: 38551 RVA: 0x00268FC0 File Offset: 0x002671C0
		// Note: this type is marked as 'beforefieldinit'.
		static JournalApp()
		{
			Il2CppClassPointerStore<JournalApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "JournalApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalApp>.NativeClassPtr);
			JournalApp.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "EntryContainer");
			JournalApp.NativeFieldInfoPtr_NoTasksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoTasksLabel");
			JournalApp.NativeFieldInfoPtr_NoDetailsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoDetailsLabel");
			JournalApp.NativeFieldInfoPtr_DetailsPanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "DetailsPanelContainer");
			JournalApp.NativeFieldInfoPtr_GenericEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericEntry");
			JournalApp.NativeFieldInfoPtr_GenericDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericDetailsPanel");
			JournalApp.NativeFieldInfoPtr_GenericQuestEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericQuestEntry");
			JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestEntryHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanelQuest");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanel");
			JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681910);
			JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681911);
			JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681912);
			JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681913);
			JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681914);
			JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681915);
			JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681916);
			JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100681917);
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x0026916C File Offset: 0x0026736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270173, XrefRangeEnd = 270176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x002691A8 File Offset: 0x002673A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270176, XrefRangeEnd = 270195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969A RID: 38554 RVA: 0x002691E4 File Offset: 0x002673E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270195, XrefRangeEnd = 270205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x00269230 File Offset: 0x00267430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270205, XrefRangeEnd = 270221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x0026926C File Offset: 0x0026746C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270235, RefRangeEnd = 270236, XrefRangeStart = 270221, XrefRangeEnd = 270235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDetailsPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x002692A0 File Offset: 0x002674A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270236, XrefRangeEnd = 270255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x002692DC File Offset: 0x002674DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270255, XrefRangeEnd = 270256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x00269318 File Offset: 0x00267518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270256, XrefRangeEnd = 270262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JournalApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0004916F File Offset: 0x0004736F
		public JournalApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x060096A1 RID: 38561 RVA: 0x00269354 File Offset: 0x00267554
		// (set) Token: 0x060096A2 RID: 38562 RVA: 0x00049178 File Offset: 0x00047378
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x060096A3 RID: 38563 RVA: 0x00269384 File Offset: 0x00267584
		// (set) Token: 0x060096A4 RID: 38564 RVA: 0x00049197 File Offset: 0x00047397
		public unsafe Text NoTasksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x002693B4 File Offset: 0x002675B4
		// (set) Token: 0x060096A6 RID: 38566 RVA: 0x000491B6 File Offset: 0x000473B6
		public unsafe Text NoDetailsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x060096A7 RID: 38567 RVA: 0x002693E4 File Offset: 0x002675E4
		// (set) Token: 0x060096A8 RID: 38568 RVA: 0x000491D5 File Offset: 0x000473D5
		public unsafe RectTransform DetailsPanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x060096A9 RID: 38569 RVA: 0x00269414 File Offset: 0x00267614
		// (set) Token: 0x060096AA RID: 38570 RVA: 0x000491F4 File Offset: 0x000473F4
		public unsafe GameObject GenericEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x060096AB RID: 38571 RVA: 0x00269444 File Offset: 0x00267644
		// (set) Token: 0x060096AC RID: 38572 RVA: 0x00049213 File Offset: 0x00047413
		public unsafe GameObject GenericDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x060096AD RID: 38573 RVA: 0x00269474 File Offset: 0x00267674
		// (set) Token: 0x060096AE RID: 38574 RVA: 0x00049232 File Offset: 0x00047432
		public unsafe GameObject GenericQuestEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x060096AF RID: 38575 RVA: 0x002694A4 File Offset: 0x002676A4
		// (set) Token: 0x060096B0 RID: 38576 RVA: 0x00049251 File Offset: 0x00047451
		public unsafe QuestHUDUI QuestHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x060096B1 RID: 38577 RVA: 0x002694D4 File Offset: 0x002676D4
		// (set) Token: 0x060096B2 RID: 38578 RVA: 0x00049270 File Offset: 0x00047470
		public unsafe QuestEntryHUDUI QuestEntryHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x00269504 File Offset: 0x00267704
		// (set) Token: 0x060096B4 RID: 38580 RVA: 0x0004928F File Offset: 0x0004748F
		public unsafe Quest currentDetailsPanelQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x060096B5 RID: 38581 RVA: 0x00269534 File Offset: 0x00267734
		// (set) Token: 0x060096B6 RID: 38582 RVA: 0x000492AE File Offset: 0x000474AE
		public unsafe RectTransform currentDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006583 RID: 25987
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04006584 RID: 25988
		private static readonly IntPtr NativeFieldInfoPtr_NoTasksLabel;

		// Token: 0x04006585 RID: 25989
		private static readonly IntPtr NativeFieldInfoPtr_NoDetailsLabel;

		// Token: 0x04006586 RID: 25990
		private static readonly IntPtr NativeFieldInfoPtr_DetailsPanelContainer;

		// Token: 0x04006587 RID: 25991
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntry;

		// Token: 0x04006588 RID: 25992
		private static readonly IntPtr NativeFieldInfoPtr_GenericDetailsPanel;

		// Token: 0x04006589 RID: 25993
		private static readonly IntPtr NativeFieldInfoPtr_GenericQuestEntry;

		// Token: 0x0400658A RID: 25994
		private static readonly IntPtr NativeFieldInfoPtr_QuestHUDUIPrefab;

		// Token: 0x0400658B RID: 25995
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryHUDUIPrefab;

		// Token: 0x0400658C RID: 25996
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanelQuest;

		// Token: 0x0400658D RID: 25997
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanel;

		// Token: 0x0400658E RID: 25998
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400658F RID: 25999
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006590 RID: 26000
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006591 RID: 26001
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006592 RID: 26002
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0;

		// Token: 0x04006593 RID: 26003
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006594 RID: 26004
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006595 RID: 26005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
