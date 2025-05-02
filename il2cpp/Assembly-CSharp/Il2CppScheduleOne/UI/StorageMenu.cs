using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000668 RID: 1640
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x06009281 RID: 37505 RVA: 0x0025C918 File Offset: 0x0025AB18
		// Note: this type is marked as 'beforefieldinit'.
		static StorageMenu()
		{
			Il2CppClassPointerStore<StorageMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "StorageMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr);
			StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<OpenedStorageEntity>k__BackingField");
			StorageMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Canvas");
			StorageMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Container");
			StorageMenu.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "TitleLabel");
			StorageMenu.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SubtitleLabel");
			StorageMenu.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotContainer");
			StorageMenu.NativeFieldInfoPtr_SlotsUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotsUIs");
			StorageMenu.NativeFieldInfoPtr_SlotGridLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotGridLayout");
			StorageMenu.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "CloseButton");
			StorageMenu.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "onClosed");
			StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681490);
			StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681491);
			StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681492);
			StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681493);
			StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681494);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681495);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681496);
			StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681497);
			StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681498);
			StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681499);
			StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681500);
			StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681501);
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x06009282 RID: 37506 RVA: 0x0025CB14 File Offset: 0x0025AD14
		// (set) Token: 0x06009283 RID: 37507 RVA: 0x0025CB50 File Offset: 0x0025AD50
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x06009284 RID: 37508 RVA: 0x0025CB90 File Offset: 0x0025AD90
		// (set) Token: 0x06009285 RID: 37509 RVA: 0x0025CBD0 File Offset: 0x0025ADD0
		public unsafe StorageEntity OpenedStorageEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x0025CC14 File Offset: 0x0025AE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264852, XrefRangeEnd = 264869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x0025CC50 File Offset: 0x0025AE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264869, XrefRangeEnd = 264873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x0025CCC4 File Offset: 0x0025AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264873, XrefRangeEnd = 264876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(StorageEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x0025CD14 File Offset: 0x0025AF14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264954, RefRangeEnd = 264956, XrefRangeStart = 264876, XrefRangeEnd = 264954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x0025CD7C File Offset: 0x0025AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264956, XrefRangeEnd = 264962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x0025CDB0 File Offset: 0x0025AFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264962, XrefRangeEnd = 265007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CloseMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x0025CDEC File Offset: 0x0025AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265007, XrefRangeEnd = 265012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x0025CE30 File Offset: 0x0025B030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265012, XrefRangeEnd = 265015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x00046E2D File Offset: 0x0004502D
		public StorageMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600928F RID: 37519 RVA: 0x0025CE6C File Offset: 0x0025B06C
		// (set) Token: 0x06009290 RID: 37520 RVA: 0x00046E36 File Offset: 0x00045036
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06009291 RID: 37521 RVA: 0x0025CE94 File Offset: 0x0025B094
		// (set) Token: 0x06009292 RID: 37522 RVA: 0x00046E51 File Offset: 0x00045051
		public unsafe StorageEntity _OpenedStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06009293 RID: 37523 RVA: 0x0025CEC4 File Offset: 0x0025B0C4
		// (set) Token: 0x06009294 RID: 37524 RVA: 0x00046E70 File Offset: 0x00045070
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x06009295 RID: 37525 RVA: 0x0025CEF4 File Offset: 0x0025B0F4
		// (set) Token: 0x06009296 RID: 37526 RVA: 0x00046E8F File Offset: 0x0004508F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x0025CF24 File Offset: 0x0025B124
		// (set) Token: 0x06009298 RID: 37528 RVA: 0x00046EAE File Offset: 0x000450AE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x06009299 RID: 37529 RVA: 0x0025CF54 File Offset: 0x0025B154
		// (set) Token: 0x0600929A RID: 37530 RVA: 0x00046ECD File Offset: 0x000450CD
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x0025CF84 File Offset: 0x0025B184
		// (set) Token: 0x0600929C RID: 37532 RVA: 0x00046EEC File Offset: 0x000450EC
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x0025CFB4 File Offset: 0x0025B1B4
		// (set) Token: 0x0600929E RID: 37534 RVA: 0x00046F0B File Offset: 0x0004510B
		public unsafe Il2CppReferenceArray<ItemSlotUI> SlotsUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600929F RID: 37535 RVA: 0x0025CFE4 File Offset: 0x0025B1E4
		// (set) Token: 0x060092A0 RID: 37536 RVA: 0x00046F2A File Offset: 0x0004512A
		public unsafe GridLayoutGroup SlotGridLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x0025D014 File Offset: 0x0025B214
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x00046F49 File Offset: 0x00045149
		public unsafe RectTransform CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x0025D044 File Offset: 0x0025B244
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x00046F68 File Offset: 0x00045168
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040062FA RID: 25338
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040062FB RID: 25339
		private static readonly IntPtr NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField;

		// Token: 0x040062FC RID: 25340
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040062FD RID: 25341
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040062FE RID: 25342
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040062FF RID: 25343
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x04006300 RID: 25344
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04006301 RID: 25345
		private static readonly IntPtr NativeFieldInfoPtr_SlotsUIs;

		// Token: 0x04006302 RID: 25346
		private static readonly IntPtr NativeFieldInfoPtr_SlotGridLayout;

		// Token: 0x04006303 RID: 25347
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x04006304 RID: 25348
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04006305 RID: 25349
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006306 RID: 25350
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006307 RID: 25351
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0;

		// Token: 0x04006308 RID: 25352
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0;

		// Token: 0x04006309 RID: 25353
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400630A RID: 25354
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0;

		// Token: 0x0400630B RID: 25355
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0;

		// Token: 0x0400630C RID: 25356
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0;

		// Token: 0x0400630D RID: 25357
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400630E RID: 25358
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0;

		// Token: 0x0400630F RID: 25359
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006310 RID: 25360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
