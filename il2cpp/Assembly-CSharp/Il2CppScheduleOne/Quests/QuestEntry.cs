using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x06002546 RID: 9542 RVA: 0x000E4748 File Offset: 0x000E2948
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntry()
		{
			Il2CppClassPointerStore<QuestEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr);
			QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "<ParentQuest>k__BackingField");
			QuestEntry.NativeFieldInfoPtr_EntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryTitle");
			QuestEntry.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "state");
			QuestEntry.NativeFieldInfoPtr_AutoComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoComplete");
			QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCompleteConditions");
			QuestEntry.NativeFieldInfoPtr_CompleteParentQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "CompleteParentQuest");
			QuestEntry.NativeFieldInfoPtr_EntryAddedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryAddedIn");
			QuestEntry.NativeFieldInfoPtr_AutoCreatePoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCreatePoI");
			QuestEntry.NativeFieldInfoPtr_PoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoILocation");
			QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoUpdatePoILocation");
			QuestEntry.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoI");
			QuestEntry.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onStart");
			QuestEntry.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onEnd");
			QuestEntry.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onComplete");
			QuestEntry.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onInitialComplete");
			QuestEntry.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "compassElement");
			QuestEntry.NativeFieldInfoPtr_entryUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "entryUI");
			QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667426);
			QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667427);
			QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667428);
			QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667429);
			QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667430);
			QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667431);
			QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667432);
			QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667433);
			QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667434);
			QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667435);
			QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667436);
			QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667437);
			QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667438);
			QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667439);
			QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667440);
			QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667441);
			QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667442);
			QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667443);
			QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667444);
			QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667445);
			QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667446);
			QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667447);
			QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667448);
			QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667449);
			QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667450);
			QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667451);
			QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667452);
			QuestEntry.NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667453);
			QuestEntry.NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667454);
			QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667455);
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000E4B24 File Offset: 0x000E2D24
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000E4B64 File Offset: 0x000E2D64
		public unsafe Quest ParentQuest
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000E4BA8 File Offset: 0x000E2DA8
		public unsafe string Title
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000E4BE0 File Offset: 0x000E2DE0
		public unsafe EQuestState State
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40392, RefRangeEnd = 40393, XrefRangeStart = 40392, XrefRangeEnd = 40393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000E4C1C File Offset: 0x000E2E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114670, XrefRangeEnd = 114708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000E4C58 File Offset: 0x000E2E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114708, XrefRangeEnd = 114768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000E4C94 File Offset: 0x000E2E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114768, XrefRangeEnd = 114777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000E4CC8 File Offset: 0x000E2EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114777, XrefRangeEnd = 114784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000E4D04 File Offset: 0x000E2F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114784, XrefRangeEnd = 114786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(QuestEntryData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000E4D48 File Offset: 0x000E2F48
		[CallerCount(0)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000E4D7C File Offset: 0x000E2F7C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 114786, RefRangeEnd = 114802, XrefRangeStart = 114786, XrefRangeEnd = 114786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000E4DB0 File Offset: 0x000E2FB0
		[CallerCount(0)]
		public unsafe void SetActive(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000E4DF0 File Offset: 0x000E2FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114802, XrefRangeEnd = 114878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetState(EQuestState newState, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000E4E48 File Offset: 0x000E3048
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000E4E90 File Offset: 0x000E3090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114878, XrefRangeEnd = 114884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000E4ECC File Offset: 0x000E30CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114891, RefRangeEnd = 114893, XrefRangeStart = 114884, XrefRangeEnd = 114891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoILocation(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000E4F0C File Offset: 0x000E310C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114942, RefRangeEnd = 114944, XrefRangeStart = 114893, XrefRangeEnd = 114942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000E4F40 File Offset: 0x000E3140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114944, XrefRangeEnd = 114953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000E4F74 File Offset: 0x000E3174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114953, XrefRangeEnd = 114968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000E4FA8 File Offset: 0x000E31A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 114974, RefRangeEnd = 114979, XrefRangeStart = 114968, XrefRangeEnd = 114974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000E4FDC File Offset: 0x000E31DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114983, RefRangeEnd = 114984, XrefRangeStart = 114979, XrefRangeEnd = 114983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestEntryData>(intPtr3) : null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000E501C File Offset: 0x000E321C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114993, RefRangeEnd = 114995, XrefRangeStart = 114984, XrefRangeEnd = 114993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000E5050 File Offset: 0x000E3250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114995, XrefRangeEnd = 114996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000E5084 File Offset: 0x000E3284
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 114998, RefRangeEnd = 115007, XrefRangeStart = 114996, XrefRangeEnd = 114998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTitle(string newTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000E50C8 File Offset: 0x000E32C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115007, XrefRangeEnd = 115034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000E5104 File Offset: 0x000E3304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115034, XrefRangeEnd = 115035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000E5140 File Offset: 0x000E3340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115035, XrefRangeEnd = 115060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000E517C File Offset: 0x000E337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__24_0(EQuestState <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000E51BC File Offset: 0x000E33BC
		[CallerCount(0)]
		public unsafe void _Awake_b__24_1(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000E51FC File Offset: 0x000E33FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115088, RefRangeEnd = 115089, XrefRangeStart = 115060, XrefRangeEnd = 115088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00014E0A File Offset: 0x0001300A
		public QuestEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000E5230 File Offset: 0x000E3430
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00014E13 File Offset: 0x00013013
		public unsafe Quest _ParentQuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000E5260 File Offset: 0x000E3460
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x00014E32 File Offset: 0x00013032
		public unsafe string EntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000E5288 File Offset: 0x000E3488
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x00014E51 File Offset: 0x00013051
		public unsafe EQuestState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000E52B0 File Offset: 0x000E34B0
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x00014E6C File Offset: 0x0001306C
		public unsafe bool AutoComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete)) = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000E52D8 File Offset: 0x000E34D8
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x00014E87 File Offset: 0x00013087
		public unsafe Conditions AutoCompleteConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000E5308 File Offset: 0x000E3508
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x00014EA6 File Offset: 0x000130A6
		public unsafe bool CompleteParentQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest)) = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000E5330 File Offset: 0x000E3530
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00014EC1 File Offset: 0x000130C1
		public unsafe string EntryAddedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000E5358 File Offset: 0x000E3558
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00014EE0 File Offset: 0x000130E0
		public unsafe bool AutoCreatePoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI)) = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000E5380 File Offset: 0x000E3580
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00014EFB File Offset: 0x000130FB
		public unsafe Transform PoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000E53B0 File Offset: 0x000E35B0
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00014F1A File Offset: 0x0001311A
		public unsafe bool AutoUpdatePoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation)) = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000E53D8 File Offset: 0x000E35D8
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x00014F35 File Offset: 0x00013135
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000E5408 File Offset: 0x000E3608
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00014F54 File Offset: 0x00013154
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000E5438 File Offset: 0x000E3638
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00014F73 File Offset: 0x00013173
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000E5468 File Offset: 0x000E3668
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00014F92 File Offset: 0x00013192
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x000E5498 File Offset: 0x000E3698
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x00014FB1 File Offset: 0x000131B1
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000E54C8 File Offset: 0x000E36C8
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00014FD0 File Offset: 0x000131D0
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000E54F8 File Offset: 0x000E36F8
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x00014FEF File Offset: 0x000131EF
		public unsafe QuestEntryHUDUI entryUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr__ParentQuest_k__BackingField;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeFieldInfoPtr_EntryTitle;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeFieldInfoPtr_AutoComplete;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteConditions;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr_CompleteParentQuest;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_EntryAddedIn;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_AutoCreatePoI;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_PoILocation;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePoILocation;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr_entryUI;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EQuestState_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_1;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoI_Public_Void_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPoI_Public_Void_0;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompassElement_Public_Void_0;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_1;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateConditions_Private_Void_1;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
