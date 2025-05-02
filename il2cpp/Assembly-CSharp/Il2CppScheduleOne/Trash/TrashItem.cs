using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000523 RID: 1315
	public class TrashItem : MonoBehaviour
	{
		// Token: 0x0600752C RID: 29996 RVA: 0x001FE42C File Offset: 0x001FC62C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItem()
		{
			Il2CppClassPointerStore<TrashItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItem>.NativeClassPtr);
			TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "POSITION_CHANGE_THRESHOLD");
			TrashItem.NativeFieldInfoPtr_LINEAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "LINEAR_DRAG");
			TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ANGULAR_DRAG");
			TrashItem.NativeFieldInfoPtr_MIN_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "MIN_Y");
			TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "INTERACTION_PRIORITY");
			TrashItem.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Rigidbody");
			TrashItem.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Draggable");
			TrashItem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ID");
			TrashItem.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Size");
			TrashItem.NativeFieldInfoPtr_SellValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "SellValue");
			TrashItem.NativeFieldInfoPtr_CanGoInContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "CanGoInContainer");
			TrashItem.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "colliders");
			TrashItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<GUID>k__BackingField");
			TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			TrashItem.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "lastPosition");
			TrashItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "onDestroyed");
			TrashItem.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "collidersEnabled");
			TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "timeOnPhysicsEnabled");
			TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678043);
			TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678044);
			TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678045);
			TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678046);
			TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678047);
			TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678048);
			TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678049);
			TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678050);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678051);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678052);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678053);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678054);
			TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678055);
			TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678056);
			TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678057);
			TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678058);
			TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678059);
			TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678060);
			TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678061);
			TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678062);
			TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678063);
			TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678064);
			TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678065);
			TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678066);
			TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678067);
			TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678068);
			TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678069);
			TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678070);
			TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678071);
			TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678072);
			TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678073);
			TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678074);
			TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678075);
			TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678076);
			TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678077);
			TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678078);
			TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678079);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678080);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678081);
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x001FE90C File Offset: 0x001FCB0C
		// (set) Token: 0x0600752E RID: 29998 RVA: 0x001FE948 File Offset: 0x001FCB48
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x001FE988 File Offset: 0x001FCB88
		// (set) Token: 0x06007530 RID: 30000 RVA: 0x001FE9C8 File Offset: 0x001FCBC8
		public unsafe Property CurrentProperty
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47274, RefRangeEnd = 47314, XrefRangeStart = 47274, XrefRangeEnd = 47314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06007531 RID: 30001 RVA: 0x001FEA0C File Offset: 0x001FCC0C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228824, XrefRangeEnd = 228829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06007532 RID: 30002 RVA: 0x001FEA44 File Offset: 0x001FCC44
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228829, XrefRangeEnd = 228834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x06007533 RID: 30003 RVA: 0x001FEA7C File Offset: 0x001FCC7C
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x06007534 RID: 30004 RVA: 0x001FEABC File Offset: 0x001FCCBC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x001FEAF8 File Offset: 0x001FCCF8
		// (set) Token: 0x06007536 RID: 30006 RVA: 0x001FEB38 File Offset: 0x001FCD38
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95750, RefRangeEnd = 95751, XrefRangeStart = 95750, XrefRangeEnd = 95751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x001FEB7C File Offset: 0x001FCD7C
		// (set) Token: 0x06007538 RID: 30008 RVA: 0x001FEBBC File Offset: 0x001FCDBC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31093, RefRangeEnd = 31100, XrefRangeStart = 31093, XrefRangeEnd = 31100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x001FEC00 File Offset: 0x001FCE00
		// (set) Token: 0x0600753A RID: 30010 RVA: 0x001FEC3C File Offset: 0x001FCE3C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x001FEC7C File Offset: 0x001FCE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228834, XrefRangeEnd = 228894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x001FECB0 File Offset: 0x001FCEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228894, XrefRangeEnd = 228945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x001FECE4 File Offset: 0x001FCEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228945, XrefRangeEnd = 228951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x001FED20 File Offset: 0x001FCF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228951, XrefRangeEnd = 228980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x001FED54 File Offset: 0x001FCF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228980, XrefRangeEnd = 229008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x001FED88 File Offset: 0x001FCF88
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x001FEDC8 File Offset: 0x001FCFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229008, XrefRangeEnd = 229016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x001FEDFC File Offset: 0x001FCFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229016, XrefRangeEnd = 229023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x001FEE30 File Offset: 0x001FD030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229039, RefRangeEnd = 229041, XrefRangeStart = 229023, XrefRangeEnd = 229039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x001FEE70 File Offset: 0x001FD070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229042, RefRangeEnd = 229044, XrefRangeStart = 229041, XrefRangeEnd = 229042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x001FEEB0 File Offset: 0x001FD0B0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 229050, RefRangeEnd = 229061, XrefRangeStart = 229044, XrefRangeEnd = 229050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x001FEEE4 File Offset: 0x001FD0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229061, XrefRangeEnd = 229099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x001FEF20 File Offset: 0x001FD120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229099, XrefRangeEnd = 229135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x001FEF54 File Offset: 0x001FD154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229135, XrefRangeEnd = 229145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x001FEF88 File Offset: 0x001FD188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229145, XrefRangeEnd = 229154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr3) : null;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x001FEFD4 File Offset: 0x001FD1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229154, XrefRangeEnd = 229155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x001FF018 File Offset: 0x001FD218
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x001FF060 File Offset: 0x001FD260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229198, RefRangeEnd = 229200, XrefRangeStart = 229155, XrefRangeEnd = 229198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x001FF094 File Offset: 0x001FD294
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 229210, RefRangeEnd = 229216, XrefRangeStart = 229200, XrefRangeEnd = 229210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuousCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x001FF0C8 File Offset: 0x001FD2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229216, XrefRangeEnd = 229223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDiscreteCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x001FF0FC File Offset: 0x001FD2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229223, XrefRangeEnd = 229226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhysicsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x001FF13C File Offset: 0x001FD33C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229229, RefRangeEnd = 229234, XrefRangeStart = 229226, XrefRangeEnd = 229229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x001FF17C File Offset: 0x001FD37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229234, XrefRangeEnd = 229253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x001FF1B8 File Offset: 0x001FD3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229253, XrefRangeEnd = 229254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x001FF1EC File Offset: 0x001FD3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229254, XrefRangeEnd = 229255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_1(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00037949 File Offset: 0x00035B49
		public TrashItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06007555 RID: 30037 RVA: 0x001FF230 File Offset: 0x001FD430
		// (set) Token: 0x06007556 RID: 30038 RVA: 0x00037952 File Offset: 0x00035B52
		public unsafe static float POSITION_CHANGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x06007557 RID: 30039 RVA: 0x001FF24C File Offset: 0x001FD44C
		// (set) Token: 0x06007558 RID: 30040 RVA: 0x00037960 File Offset: 0x00035B60
		public unsafe static float LINEAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06007559 RID: 30041 RVA: 0x001FF268 File Offset: 0x001FD468
		// (set) Token: 0x0600755A RID: 30042 RVA: 0x0003796E File Offset: 0x00035B6E
		public unsafe static float ANGULAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x0600755B RID: 30043 RVA: 0x001FF284 File Offset: 0x001FD484
		// (set) Token: 0x0600755C RID: 30044 RVA: 0x0003797C File Offset: 0x00035B7C
		public unsafe static float MIN_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&value));
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x0600755D RID: 30045 RVA: 0x001FF2A0 File Offset: 0x001FD4A0
		// (set) Token: 0x0600755E RID: 30046 RVA: 0x0003798A File Offset: 0x00035B8A
		public unsafe static int INTERACTION_PRIORITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&value));
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600755F RID: 30047 RVA: 0x001FF2BC File Offset: 0x001FD4BC
		// (set) Token: 0x06007560 RID: 30048 RVA: 0x00037998 File Offset: 0x00035B98
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x001FF2EC File Offset: 0x001FD4EC
		// (set) Token: 0x06007562 RID: 30050 RVA: 0x000379B7 File Offset: 0x00035BB7
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06007563 RID: 30051 RVA: 0x001FF31C File Offset: 0x001FD51C
		// (set) Token: 0x06007564 RID: 30052 RVA: 0x000379D6 File Offset: 0x00035BD6
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06007565 RID: 30053 RVA: 0x001FF344 File Offset: 0x001FD544
		// (set) Token: 0x06007566 RID: 30054 RVA: 0x000379F5 File Offset: 0x00035BF5
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06007567 RID: 30055 RVA: 0x001FF36C File Offset: 0x001FD56C
		// (set) Token: 0x06007568 RID: 30056 RVA: 0x00037A10 File Offset: 0x00035C10
		public unsafe int SellValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue)) = value;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06007569 RID: 30057 RVA: 0x001FF394 File Offset: 0x001FD594
		// (set) Token: 0x0600756A RID: 30058 RVA: 0x00037A2B File Offset: 0x00035C2B
		public unsafe bool CanGoInContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer)) = value;
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x0600756B RID: 30059 RVA: 0x001FF3BC File Offset: 0x001FD5BC
		// (set) Token: 0x0600756C RID: 30060 RVA: 0x00037A46 File Offset: 0x00035C46
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x001FF3EC File Offset: 0x001FD5EC
		// (set) Token: 0x0600756E RID: 30062 RVA: 0x00037A65 File Offset: 0x00035C65
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x001FF414 File Offset: 0x001FD614
		// (set) Token: 0x06007570 RID: 30064 RVA: 0x00037A80 File Offset: 0x00035C80
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x001FF444 File Offset: 0x001FD644
		// (set) Token: 0x06007572 RID: 30066 RVA: 0x00037A9F File Offset: 0x00035C9F
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06007573 RID: 30067 RVA: 0x001FF46C File Offset: 0x001FD66C
		// (set) Token: 0x06007574 RID: 30068 RVA: 0x00037ABA File Offset: 0x00035CBA
		public unsafe Action<TrashItem> onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x001FF49C File Offset: 0x001FD69C
		// (set) Token: 0x06007576 RID: 30070 RVA: 0x00037AD9 File Offset: 0x00035CD9
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06007577 RID: 30071 RVA: 0x001FF4C4 File Offset: 0x001FD6C4
		// (set) Token: 0x06007578 RID: 30072 RVA: 0x00037AF4 File Offset: 0x00035CF4
		public unsafe float timeOnPhysicsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled)) = value;
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x001FF4EC File Offset: 0x001FD6EC
		// (set) Token: 0x0600757A RID: 30074 RVA: 0x00037B0F File Offset: 0x00035D0F
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600757B RID: 30075 RVA: 0x001FF51C File Offset: 0x001FD71C
		// (set) Token: 0x0600757C RID: 30076 RVA: 0x00037B2E File Offset: 0x00035D2E
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600757D RID: 30077 RVA: 0x001FF54C File Offset: 0x001FD74C
		// (set) Token: 0x0600757E RID: 30078 RVA: 0x00037B4D File Offset: 0x00035D4D
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04005007 RID: 20487
		private static readonly IntPtr NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD;

		// Token: 0x04005008 RID: 20488
		private static readonly IntPtr NativeFieldInfoPtr_LINEAR_DRAG;

		// Token: 0x04005009 RID: 20489
		private static readonly IntPtr NativeFieldInfoPtr_ANGULAR_DRAG;

		// Token: 0x0400500A RID: 20490
		private static readonly IntPtr NativeFieldInfoPtr_MIN_Y;

		// Token: 0x0400500B RID: 20491
		private static readonly IntPtr NativeFieldInfoPtr_INTERACTION_PRIORITY;

		// Token: 0x0400500C RID: 20492
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x0400500D RID: 20493
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x0400500E RID: 20494
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x0400500F RID: 20495
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04005010 RID: 20496
		private static readonly IntPtr NativeFieldInfoPtr_SellValue;

		// Token: 0x04005011 RID: 20497
		private static readonly IntPtr NativeFieldInfoPtr_CanGoInContainer;

		// Token: 0x04005012 RID: 20498
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04005013 RID: 20499
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005014 RID: 20500
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x04005015 RID: 20501
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04005016 RID: 20502
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04005017 RID: 20503
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005018 RID: 20504
		private static readonly IntPtr NativeFieldInfoPtr_timeOnPhysicsEnabled;

		// Token: 0x04005019 RID: 20505
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400501A RID: 20506
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400501B RID: 20507
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400501C RID: 20508
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400501D RID: 20509
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400501E RID: 20510
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x0400501F RID: 20511
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04005020 RID: 20512
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005021 RID: 20513
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005022 RID: 20514
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04005023 RID: 20515
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005024 RID: 20516
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005025 RID: 20517
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005026 RID: 20518
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005027 RID: 20519
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005028 RID: 20520
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005029 RID: 20521
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400502A RID: 20522
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x0400502B RID: 20523
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x0400502C RID: 20524
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400502D RID: 20525
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x0400502E RID: 20526
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Void_0;

		// Token: 0x0400502F RID: 20527
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0;

		// Token: 0x04005030 RID: 20528
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Void_0;

		// Token: 0x04005031 RID: 20529
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Void_0;

		// Token: 0x04005032 RID: 20530
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005033 RID: 20531
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04005034 RID: 20532
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_0;

		// Token: 0x04005035 RID: 20533
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0;

		// Token: 0x04005036 RID: 20534
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005037 RID: 20535
		private static readonly IntPtr NativeMethodInfoPtr_RecheckPosition_Private_Void_0;

		// Token: 0x04005038 RID: 20536
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0;

		// Token: 0x04005039 RID: 20537
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400503A RID: 20538
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x0400503B RID: 20539
		private static readonly IntPtr NativeMethodInfoPtr_RecheckProperty_Private_Void_0;

		// Token: 0x0400503C RID: 20540
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0;

		// Token: 0x0400503D RID: 20541
		private static readonly IntPtr NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0;

		// Token: 0x0400503E RID: 20542
		private static readonly IntPtr NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0;

		// Token: 0x0400503F RID: 20543
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0;

		// Token: 0x04005040 RID: 20544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005041 RID: 20545
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0;

		// Token: 0x04005042 RID: 20546
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0;
	}
}
