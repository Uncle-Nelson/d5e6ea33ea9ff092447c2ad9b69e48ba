using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F2 RID: 754
	[Serializable]
	public class NPCRelationData : Object
	{
		// Token: 0x060038ED RID: 14573 RVA: 0x00129884 File Offset: 0x00127A84
		// Note: this type is marked as 'beforefieldinit'.
		static NPCRelationData()
		{
			Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCRelationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr);
			NPCRelationData.NativeFieldInfoPtr_MinDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MinDelta");
			NPCRelationData.NativeFieldInfoPtr_MaxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MaxDelta");
			NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DEFAULT_RELATION_DELTA");
			NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<RelationDelta>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<Unlocked>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<UnlockType>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<NPC>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr_FullGameConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "FullGameConnections");
			NPCRelationData.NativeFieldInfoPtr_DemoConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DemoConnections");
			NPCRelationData.NativeFieldInfoPtr_onRelationshipChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onRelationshipChange");
			NPCRelationData.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onUnlocked");
			NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669910);
			NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669911);
			NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669912);
			NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669913);
			NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669914);
			NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669915);
			NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669916);
			NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669917);
			NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669918);
			NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669919);
			NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669920);
			NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669921);
			NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669922);
			NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669923);
			NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669924);
			NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669925);
			NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669926);
			NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669927);
			NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669928);
			NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669929);
			NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669930);
			NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669931);
			NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669932);
			NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100669933);
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x00129B70 File Offset: 0x00127D70
		// (set) Token: 0x060038EF RID: 14575 RVA: 0x00129BAC File Offset: 0x00127DAC
		public unsafe float RelationDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29950, RefRangeEnd = 29954, XrefRangeStart = 29950, XrefRangeEnd = 29954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00129BEC File Offset: 0x00127DEC
		public unsafe float NormalizedRelationDelta
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 141733, RefRangeEnd = 141743, XrefRangeStart = 141733, XrefRangeEnd = 141733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00129C28 File Offset: 0x00127E28
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x00129C64 File Offset: 0x00127E64
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x00129CA4 File Offset: 0x00127EA4
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x00129CE0 File Offset: 0x00127EE0
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29997, RefRangeEnd = 29999, XrefRangeStart = 29997, XrefRangeEnd = 29999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x00129D20 File Offset: 0x00127F20
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x00129D60 File Offset: 0x00127F60
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x00129DA4 File Offset: 0x00127FA4
		public unsafe List<NPC> Connections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
			}
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00129DE4 File Offset: 0x00127FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x00129E28 File Offset: 0x00128028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141767, RefRangeEnd = 141768, XrefRangeStart = 141743, XrefRangeEnd = 141767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00129E6C File Offset: 0x0012806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141768, XrefRangeEnd = 141770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00129EC4 File Offset: 0x001280C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141770, XrefRangeEnd = 141771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRelationship(float newDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00129F10 File Offset: 0x00128110
		[CallerCount(0)]
		public unsafe virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00129F68 File Offset: 0x00128168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141771, XrefRangeEnd = 141778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnlockConnections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00129FA4 File Offset: 0x001281A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141782, RefRangeEnd = 141783, XrefRangeStart = 141778, XrefRangeEnd = 141782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationshipData>(intPtr3) : null;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00129FE4 File Offset: 0x001281E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141790, RefRangeEnd = 141792, XrefRangeStart = 141783, XrefRangeEnd = 141790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageMutualRelationship()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x0012A020 File Offset: 0x00128220
		[CallerCount(0)]
		public unsafe bool IsKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x0012A05C File Offset: 0x0012825C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 141803, RefRangeEnd = 141811, XrefRangeStart = 141792, XrefRangeEnd = 141803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMutuallyKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0012A098 File Offset: 0x00128298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141811, XrefRangeEnd = 141825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeCustomers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x0012A0E4 File Offset: 0x001282E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141839, RefRangeEnd = 141840, XrefRangeStart = 141825, XrefRangeEnd = 141839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0012A130 File Offset: 0x00128330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141859, RefRangeEnd = 141860, XrefRangeStart = 141840, XrefRangeEnd = 141859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedSuppliers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0012A170 File Offset: 0x00128370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141860, XrefRangeEnd = 141873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCRelationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		public NPCRelationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x0012A1AC File Offset: 0x001283AC
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x0001D4E1 File Offset: 0x0001B6E1
		public unsafe static float MinDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&value));
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x0012A1C8 File Offset: 0x001283C8
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x0001D4EF File Offset: 0x0001B6EF
		public unsafe static float MaxDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&value));
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x0012A1E4 File Offset: 0x001283E4
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x0001D4FD File Offset: 0x0001B6FD
		public unsafe static float DEFAULT_RELATION_DELTA
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&value));
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0012A200 File Offset: 0x00128400
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x0001D50B File Offset: 0x0001B70B
		public unsafe float _RelationDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0012A228 File Offset: 0x00128428
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x0001D526 File Offset: 0x0001B726
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0012A250 File Offset: 0x00128450
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x0001D541 File Offset: 0x0001B741
		public unsafe NPCRelationData.EUnlockType _UnlockType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x0012A278 File Offset: 0x00128478
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0001D55C File Offset: 0x0001B75C
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0012A2A8 File Offset: 0x001284A8
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x0001D57B File Offset: 0x0001B77B
		public unsafe List<NPC> FullGameConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x0012A2D8 File Offset: 0x001284D8
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x0001D59A File Offset: 0x0001B79A
		public unsafe List<NPC> DemoConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x0012A308 File Offset: 0x00128508
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x0001D5B9 File Offset: 0x0001B7B9
		public unsafe Action<float> onRelationshipChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x0012A338 File Offset: 0x00128538
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		public unsafe Action<NPCRelationData.EUnlockType, bool> onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCRelationData.EUnlockType, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeFieldInfoPtr_MinDelta;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeFieldInfoPtr_MaxDelta;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_RELATION_DELTA;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeFieldInfoPtr__RelationDelta_k__BackingField;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeFieldInfoPtr__UnlockType_k__BackingField;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeFieldInfoPtr_FullGameConnections;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeFieldInfoPtr_DemoConnections;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeFieldInfoPtr_onRelationshipChange;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_NPC_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_IsKnown_Public_Boolean_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000937 RID: 2359
		[OriginalName("Assembly-CSharp.dll", "", "EUnlockType")]
		public enum EUnlockType
		{
			// Token: 0x040086D7 RID: 34519
			Recommendation,
			// Token: 0x040086D8 RID: 34520
			DirectApproach
		}

		// Token: 0x02000938 RID: 2360
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C732 RID: 50994 RVA: 0x003056D4 File Offset: 0x003038D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr);
				NPCRelationData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9");
				NPCRelationData.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9__40_0");
				NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100669935);
				NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100669936);
			}

			// Token: 0x0600C733 RID: 50995 RVA: 0x00305750 File Offset: 0x00303950
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C734 RID: 50996 RVA: 0x0030578C File Offset: 0x0030398C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141728, XrefRangeEnd = 141729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedSuppliers_b__40_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C735 RID: 50997 RVA: 0x00060F48 File Offset: 0x0005F148
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E12 RID: 15890
			// (get) Token: 0x0600C736 RID: 50998 RVA: 0x003057DC File Offset: 0x003039DC
			// (set) Token: 0x0600C737 RID: 50999 RVA: 0x00060F51 File Offset: 0x0005F151
			public unsafe static NPCRelationData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCRelationData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E13 RID: 15891
			// (get) Token: 0x0600C738 RID: 51000 RVA: 0x00305804 File Offset: 0x00303A04
			// (set) Token: 0x0600C739 RID: 51001 RVA: 0x00060F63 File Offset: 0x0005F163
			public unsafe static Predicate<NPC> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NPC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086D9 RID: 34521
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040086DA RID: 34522
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040086DB RID: 34523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086DC RID: 34524
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000939 RID: 2361
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Object
		{
			// Token: 0x0600C73A RID: 51002 RVA: 0x0030582C File Offset: 0x00303A2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, "excludeCustomers");
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100669937);
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100669938);
			}

			// Token: 0x0600C73B RID: 51003 RVA: 0x00305894 File Offset: 0x00303A94
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C73C RID: 51004 RVA: 0x003058D0 File Offset: 0x00303AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141729, XrefRangeEnd = 141731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedConnections_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C73D RID: 51005 RVA: 0x00060F75 File Offset: 0x0005F175
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E14 RID: 15892
			// (get) Token: 0x0600C73E RID: 51006 RVA: 0x00305920 File Offset: 0x00303B20
			// (set) Token: 0x0600C73F RID: 51007 RVA: 0x00060F7E File Offset: 0x0005F17E
			public unsafe bool excludeCustomers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers)) = value;
				}
			}

			// Token: 0x040086DD RID: 34525
			private static readonly IntPtr NativeFieldInfoPtr_excludeCustomers;

			// Token: 0x040086DE RID: 34526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086DF RID: 34527
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0;
		}

		// Token: 0x0200093A RID: 2362
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Object
		{
			// Token: 0x0600C740 RID: 51008 RVA: 0x00305948 File Offset: 0x00303B48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, "excludeRecommended");
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100669939);
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100669940);
			}

			// Token: 0x0600C741 RID: 51009 RVA: 0x003059B0 File Offset: 0x00303BB0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C742 RID: 51010 RVA: 0x003059EC File Offset: 0x00303BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141731, XrefRangeEnd = 141733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedDealers_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C743 RID: 51011 RVA: 0x00060F99 File Offset: 0x0005F199
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E15 RID: 15893
			// (get) Token: 0x0600C744 RID: 51012 RVA: 0x00305A3C File Offset: 0x00303C3C
			// (set) Token: 0x0600C745 RID: 51013 RVA: 0x00060FA2 File Offset: 0x0005F1A2
			public unsafe bool excludeRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended)) = value;
				}
			}

			// Token: 0x040086E0 RID: 34528
			private static readonly IntPtr NativeFieldInfoPtr_excludeRecommended;

			// Token: 0x040086E1 RID: 34529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086E2 RID: 34530
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0;
		}
	}
}
