using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077F RID: 1919
	public class NPCEnterableBuilding : MonoBehaviour
	{
		// Token: 0x0600B5B8 RID: 46520 RVA: 0x002D2AAC File Offset: 0x002D0CAC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEnterableBuilding()
		{
			Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCEnterableBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr);
			NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "DOOR_SOUND_DISTANCE_LIMIT");
			NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<GUID>k__BackingField");
			NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BuildingName");
			NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BakedGUID");
			NPCEnterableBuilding.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Doors");
			NPCEnterableBuilding.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Occupants");
			NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685628);
			NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685629);
			NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685630);
			NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685631);
			NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685632);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685633);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685634);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685635);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685636);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685637);
			NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685638);
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B5B9 RID: 46521 RVA: 0x002D2C30 File Offset: 0x002D0E30
		// (set) Token: 0x0600B5BA RID: 46522 RVA: 0x002D2C6C File Offset: 0x002D0E6C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600B5BB RID: 46523 RVA: 0x002D2CAC File Offset: 0x002D0EAC
		public unsafe int OccupantCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310628, RefRangeEnd = 310629, XrefRangeStart = 310627, XrefRangeEnd = 310628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x002D2CE8 File Offset: 0x002D0EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310656, RefRangeEnd = 310657, XrefRangeStart = 310629, XrefRangeEnd = 310656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x002D2D24 File Offset: 0x002D0F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310657, XrefRangeEnd = 310661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x002D2D64 File Offset: 0x002D0F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310705, RefRangeEnd = 310706, XrefRangeStart = 310661, XrefRangeEnd = 310705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x002D2DB4 File Offset: 0x002D0FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310748, RefRangeEnd = 310749, XrefRangeStart = 310706, XrefRangeEnd = 310748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x002D2E04 File Offset: 0x002D1004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310749, XrefRangeEnd = 310753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDoors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x002D2E38 File Offset: 0x002D1038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310753, XrefRangeEnd = 310774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetSummonableNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x002D2E78 File Offset: 0x002D1078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310800, RefRangeEnd = 310802, XrefRangeStart = 310774, XrefRangeEnd = 310800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr3) : null;
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x002D2ED4 File Offset: 0x002D10D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310813, RefRangeEnd = 310815, XrefRangeStart = 310802, XrefRangeEnd = 310813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEnterableBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x0005932D File Offset: 0x0005752D
		public NPCEnterableBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B5C5 RID: 46533 RVA: 0x002D2F10 File Offset: 0x002D1110
		// (set) Token: 0x0600B5C6 RID: 46534 RVA: 0x00059336 File Offset: 0x00057536
		public unsafe static float DOOR_SOUND_DISTANCE_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B5C7 RID: 46535 RVA: 0x002D2F2C File Offset: 0x002D112C
		// (set) Token: 0x0600B5C8 RID: 46536 RVA: 0x00059344 File Offset: 0x00057544
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B5C9 RID: 46537 RVA: 0x002D2F54 File Offset: 0x002D1154
		// (set) Token: 0x0600B5CA RID: 46538 RVA: 0x0005935F File Offset: 0x0005755F
		public unsafe string BuildingName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B5CB RID: 46539 RVA: 0x002D2F7C File Offset: 0x002D117C
		// (set) Token: 0x0600B5CC RID: 46540 RVA: 0x0005937E File Offset: 0x0005757E
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B5CD RID: 46541 RVA: 0x002D2FA4 File Offset: 0x002D11A4
		// (set) Token: 0x0600B5CE RID: 46542 RVA: 0x0005939D File Offset: 0x0005759D
		public unsafe Il2CppReferenceArray<StaticDoor> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B5CF RID: 46543 RVA: 0x002D2FD4 File Offset: 0x002D11D4
		// (set) Token: 0x0600B5D0 RID: 46544 RVA: 0x000593BC File Offset: 0x000575BC
		public unsafe List<NPC> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A72 RID: 31346
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT;

		// Token: 0x04007A73 RID: 31347
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007A74 RID: 31348
		private static readonly IntPtr NativeFieldInfoPtr_BuildingName;

		// Token: 0x04007A75 RID: 31349
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007A76 RID: 31350
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x04007A77 RID: 31351
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x04007A78 RID: 31352
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007A79 RID: 31353
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007A7A RID: 31354
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0;

		// Token: 0x04007A7B RID: 31355
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007A7C RID: 31356
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007A7D RID: 31357
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007A7E RID: 31358
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007A7F RID: 31359
		private static readonly IntPtr NativeMethodInfoPtr_GetDoors_Public_Void_0;

		// Token: 0x04007A80 RID: 31360
		private static readonly IntPtr NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0;

		// Token: 0x04007A81 RID: 31361
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0;

		// Token: 0x04007A82 RID: 31362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFE RID: 3070
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFEC RID: 57324 RVA: 0x0034BE7C File Offset: 0x0034A07C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr);
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9");
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9__16_0");
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100685640);
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100685641);
			}

			// Token: 0x0600DFED RID: 57325 RVA: 0x0034BEF8 File Offset: 0x0034A0F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFEE RID: 57326 RVA: 0x0034BF34 File Offset: 0x0034A134
			[CallerCount(0)]
			public unsafe bool _GetSummonableNPCs_b__16_0(NPC npc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFEF RID: 57327 RVA: 0x0006D300 File Offset: 0x0006B500
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004562 RID: 17762
			// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x0034BF84 File Offset: 0x0034A184
			// (set) Token: 0x0600DFF1 RID: 57329 RVA: 0x0006D309 File Offset: 0x0006B509
			public unsafe static NPCEnterableBuilding.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004563 RID: 17763
			// (get) Token: 0x0600DFF2 RID: 57330 RVA: 0x0034BFAC File Offset: 0x0034A1AC
			// (set) Token: 0x0600DFF3 RID: 57331 RVA: 0x0006D31B File Offset: 0x0006B51B
			public unsafe static Func<NPC, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095F5 RID: 38389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095F6 RID: 38390
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040095F7 RID: 38391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095F8 RID: 38392
			private static readonly IntPtr NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000BFF RID: 3071
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFF4 RID: 57332 RVA: 0x0034BFD4 File Offset: 0x0034A1D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "useableOnly");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "pos");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685642);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685643);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685644);
			}

			// Token: 0x0600DFF5 RID: 57333 RVA: 0x0034C064 File Offset: 0x0034A264
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF6 RID: 57334 RVA: 0x0034C0A0 File Offset: 0x0034A2A0
			[CallerCount(0)]
			public unsafe bool _GetClosestDoor_b__0(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFF7 RID: 57335 RVA: 0x0034C0F0 File Offset: 0x0034A2F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310622, XrefRangeEnd = 310627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestDoor_b__1(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFF8 RID: 57336 RVA: 0x0006D32D File Offset: 0x0006B52D
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004564 RID: 17764
			// (get) Token: 0x0600DFF9 RID: 57337 RVA: 0x0034C140 File Offset: 0x0034A340
			// (set) Token: 0x0600DFFA RID: 57338 RVA: 0x0006D336 File Offset: 0x0006B536
			public unsafe bool useableOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly)) = value;
				}
			}

			// Token: 0x17004565 RID: 17765
			// (get) Token: 0x0600DFFB RID: 57339 RVA: 0x0034C168 File Offset: 0x0034A368
			// (set) Token: 0x0600DFFC RID: 57340 RVA: 0x0006D351 File Offset: 0x0006B551
			public unsafe Vector3 pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x040095F9 RID: 38393
			private static readonly IntPtr NativeFieldInfoPtr_useableOnly;

			// Token: 0x040095FA RID: 38394
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040095FB RID: 38395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095FC RID: 38396
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0;

			// Token: 0x040095FD RID: 38397
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0;
		}
	}
}
