using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Relations
{
	// Token: 0x0200069A RID: 1690
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x0600964A RID: 38474 RVA: 0x002680FC File Offset: 0x002662FC
		// Note: this type is marked as 'beforefieldinit'.
		static RelationCircle()
		{
			Il2CppClassPointerStore<RelationCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Relations", "RelationCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr);
			RelationCircle.NativeFieldInfoPtr_NotchMinRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMinRot");
			RelationCircle.NativeFieldInfoPtr_NotchMaxRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMaxRot");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_ZeroDependence");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_MaxDependence");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC_ID");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC");
			RelationCircle.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onClicked");
			RelationCircle.NativeFieldInfoPtr_onHoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverStart");
			RelationCircle.NativeFieldInfoPtr_onHoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverEnd");
			RelationCircle.NativeFieldInfoPtr_AutoSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AutoSetName");
			RelationCircle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Rect");
			RelationCircle.NativeFieldInfoPtr_PortraitBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitBackground");
			RelationCircle.NativeFieldInfoPtr_HeadshotImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "HeadshotImg");
			RelationCircle.NativeFieldInfoPtr_NotchPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchPivot");
			RelationCircle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Locked");
			RelationCircle.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Button");
			RelationCircle.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Trigger");
			RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681878);
			RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681879);
			RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681880);
			RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681881);
			RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681882);
			RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681883);
			RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681884);
			RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681885);
			RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681886);
			RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681887);
			RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681888);
			RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681889);
			RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681890);
			RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681891);
			RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681892);
			RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681893);
			RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681894);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681896);
			RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681897);
			RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100681898);
		}

		// Token: 0x0600964B RID: 38475 RVA: 0x00268410 File Offset: 0x00266610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269732, XrefRangeEnd = 269794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x00268444 File Offset: 0x00266644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269794, XrefRangeEnd = 269805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x00268478 File Offset: 0x00266678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269886, RefRangeEnd = 269888, XrefRangeStart = 269805, XrefRangeEnd = 269886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x002684BC File Offset: 0x002666BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269918, RefRangeEnd = 269919, XrefRangeStart = 269888, XrefRangeEnd = 269918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x002684F0 File Offset: 0x002666F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269919, XrefRangeEnd = 269920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x00268530 File Offset: 0x00266730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269923, RefRangeEnd = 269926, XrefRangeStart = 269920, XrefRangeEnd = 269923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotchPosition(float relationshipDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationshipDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x00268570 File Offset: 0x00266770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269929, RefRangeEnd = 269931, XrefRangeStart = 269926, XrefRangeEnd = 269929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotchPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x002685A4 File Offset: 0x002667A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269944, RefRangeEnd = 269945, XrefRangeStart = 269931, XrefRangeEnd = 269944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDependenceDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x002685D8 File Offset: 0x002667D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269945, XrefRangeEnd = 269950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x0026860C File Offset: 0x0026680C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269954, RefRangeEnd = 269955, XrefRangeStart = 269950, XrefRangeEnd = 269954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x00268658 File Offset: 0x00266858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269960, RefRangeEnd = 269961, XrefRangeStart = 269955, XrefRangeEnd = 269960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x0026868C File Offset: 0x0026688C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269976, RefRangeEnd = 269978, XrefRangeStart = 269961, XrefRangeEnd = 269976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlackout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009657 RID: 38487 RVA: 0x002686C0 File Offset: 0x002668C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269978, XrefRangeEnd = 269979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackedOut(bool blackedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blackedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x00268700 File Offset: 0x00266900
		[CallerCount(0)]
		public unsafe void ButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x00268734 File Offset: 0x00266934
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x00268768 File Offset: 0x00266968
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0026879C File Offset: 0x0026699C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269979, XrefRangeEnd = 269983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x002687D8 File Offset: 0x002669D8
		[CallerCount(0)]
		public unsafe void _Awake_b__17_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0026881C File Offset: 0x00266A1C
		[CallerCount(0)]
		public unsafe void _Awake_b__17_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x00268860 File Offset: 0x00266A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269983, XrefRangeEnd = 269984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AssignNPC_b__19_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x00048EFB File Offset: 0x000470FB
		public RelationCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x002688AC File Offset: 0x00266AAC
		// (set) Token: 0x06009661 RID: 38497 RVA: 0x00048F04 File Offset: 0x00047104
		public unsafe static float NotchMinRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&value));
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x002688C8 File Offset: 0x00266AC8
		// (set) Token: 0x06009663 RID: 38499 RVA: 0x00048F12 File Offset: 0x00047112
		public unsafe static float NotchMaxRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&value));
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x002688E4 File Offset: 0x00266AE4
		// (set) Token: 0x06009665 RID: 38501 RVA: 0x00048F20 File Offset: 0x00047120
		public unsafe static Color PortraitColor_ZeroDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x00268900 File Offset: 0x00266B00
		// (set) Token: 0x06009667 RID: 38503 RVA: 0x00048F2E File Offset: 0x0004712E
		public unsafe static Color PortraitColor_MaxDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&value));
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x06009668 RID: 38504 RVA: 0x0026891C File Offset: 0x00266B1C
		// (set) Token: 0x06009669 RID: 38505 RVA: 0x00048F3C File Offset: 0x0004713C
		public unsafe string AssignedNPC_ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600966A RID: 38506 RVA: 0x00268944 File Offset: 0x00266B44
		// (set) Token: 0x0600966B RID: 38507 RVA: 0x00048F5B File Offset: 0x0004715B
		public unsafe NPC AssignedNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600966C RID: 38508 RVA: 0x00268974 File Offset: 0x00266B74
		// (set) Token: 0x0600966D RID: 38509 RVA: 0x00048F7A File Offset: 0x0004717A
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600966E RID: 38510 RVA: 0x002689A4 File Offset: 0x00266BA4
		// (set) Token: 0x0600966F RID: 38511 RVA: 0x00048F99 File Offset: 0x00047199
		public unsafe Action onHoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x06009670 RID: 38512 RVA: 0x002689D4 File Offset: 0x00266BD4
		// (set) Token: 0x06009671 RID: 38513 RVA: 0x00048FB8 File Offset: 0x000471B8
		public unsafe Action onHoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x06009672 RID: 38514 RVA: 0x00268A04 File Offset: 0x00266C04
		// (set) Token: 0x06009673 RID: 38515 RVA: 0x00048FD7 File Offset: 0x000471D7
		public unsafe bool AutoSetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName)) = value;
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x06009674 RID: 38516 RVA: 0x00268A2C File Offset: 0x00266C2C
		// (set) Token: 0x06009675 RID: 38517 RVA: 0x00048FF2 File Offset: 0x000471F2
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x06009676 RID: 38518 RVA: 0x00268A5C File Offset: 0x00266C5C
		// (set) Token: 0x06009677 RID: 38519 RVA: 0x00049011 File Offset: 0x00047211
		public unsafe Image PortraitBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x06009678 RID: 38520 RVA: 0x00268A8C File Offset: 0x00266C8C
		// (set) Token: 0x06009679 RID: 38521 RVA: 0x00049030 File Offset: 0x00047230
		public unsafe Image HeadshotImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600967A RID: 38522 RVA: 0x00268ABC File Offset: 0x00266CBC
		// (set) Token: 0x0600967B RID: 38523 RVA: 0x0004904F File Offset: 0x0004724F
		public unsafe RectTransform NotchPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600967C RID: 38524 RVA: 0x00268AEC File Offset: 0x00266CEC
		// (set) Token: 0x0600967D RID: 38525 RVA: 0x0004906E File Offset: 0x0004726E
		public unsafe RectTransform Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600967E RID: 38526 RVA: 0x00268B1C File Offset: 0x00266D1C
		// (set) Token: 0x0600967F RID: 38527 RVA: 0x0004908D File Offset: 0x0004728D
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x06009680 RID: 38528 RVA: 0x00268B4C File Offset: 0x00266D4C
		// (set) Token: 0x06009681 RID: 38529 RVA: 0x000490AC File Offset: 0x000472AC
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006550 RID: 25936
		private static readonly IntPtr NativeFieldInfoPtr_NotchMinRot;

		// Token: 0x04006551 RID: 25937
		private static readonly IntPtr NativeFieldInfoPtr_NotchMaxRot;

		// Token: 0x04006552 RID: 25938
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_ZeroDependence;

		// Token: 0x04006553 RID: 25939
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_MaxDependence;

		// Token: 0x04006554 RID: 25940
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPC_ID;

		// Token: 0x04006555 RID: 25941
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPC;

		// Token: 0x04006556 RID: 25942
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04006557 RID: 25943
		private static readonly IntPtr NativeFieldInfoPtr_onHoverStart;

		// Token: 0x04006558 RID: 25944
		private static readonly IntPtr NativeFieldInfoPtr_onHoverEnd;

		// Token: 0x04006559 RID: 25945
		private static readonly IntPtr NativeFieldInfoPtr_AutoSetName;

		// Token: 0x0400655A RID: 25946
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x0400655B RID: 25947
		private static readonly IntPtr NativeFieldInfoPtr_PortraitBackground;

		// Token: 0x0400655C RID: 25948
		private static readonly IntPtr NativeFieldInfoPtr_HeadshotImg;

		// Token: 0x0400655D RID: 25949
		private static readonly IntPtr NativeFieldInfoPtr_NotchPivot;

		// Token: 0x0400655E RID: 25950
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x0400655F RID: 25951
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04006560 RID: 25952
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04006561 RID: 25953
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006562 RID: 25954
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006563 RID: 25955
		private static readonly IntPtr NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0;

		// Token: 0x04006564 RID: 25956
		private static readonly IntPtr NativeMethodInfoPtr_UnassignNPC_Private_Void_0;

		// Token: 0x04006565 RID: 25957
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0;

		// Token: 0x04006566 RID: 25958
		private static readonly IntPtr NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0;

		// Token: 0x04006567 RID: 25959
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0;

		// Token: 0x04006568 RID: 25960
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0;

		// Token: 0x04006569 RID: 25961
		private static readonly IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_0;

		// Token: 0x0400656A RID: 25962
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0;

		// Token: 0x0400656B RID: 25963
		private static readonly IntPtr NativeMethodInfoPtr_LoadNPCData_Public_Void_0;

		// Token: 0x0400656C RID: 25964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlackout_Private_Void_0;

		// Token: 0x0400656D RID: 25965
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0;

		// Token: 0x0400656E RID: 25966
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

		// Token: 0x0400656F RID: 25967
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04006570 RID: 25968
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04006571 RID: 25969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006572 RID: 25970
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_0_Private_Void_BaseEventData_0;

		// Token: 0x04006573 RID: 25971
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_1_Private_Void_BaseEventData_0;

		// Token: 0x04006574 RID: 25972
		private static readonly IntPtr NativeMethodInfoPtr__AssignNPC_b__19_0_Private_Void_EUnlockType_Boolean_0;
	}
}
