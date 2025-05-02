using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063F RID: 1599
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x06008D59 RID: 36185 RVA: 0x0024D770 File Offset: 0x0024B970
		// Note: this type is marked as 'beforefieldinit'.
		static GenericUIScreen()
		{
			Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericUIScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr);
			GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			GenericUIScreen.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "Name");
			GenericUIScreen.NativeFieldInfoPtr_UseExitActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "UseExitActions");
			GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ExitActionPriority");
			GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "CanExitWithRightClick");
			GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableControlsOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableInventoryOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableEquippingOnClose");
			GenericUIScreen.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onOpen");
			GenericUIScreen.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onClose");
			GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680864);
			GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680865);
			GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680866);
			GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680867);
			GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680868);
			GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680869);
			GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100680870);
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x06008D5A RID: 36186 RVA: 0x0024D8F4 File Offset: 0x0024BAF4
		// (set) Token: 0x06008D5B RID: 36187 RVA: 0x0024D930 File Offset: 0x0024BB30
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x0024D970 File Offset: 0x0024BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258103, XrefRangeEnd = 258113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D5D RID: 36189 RVA: 0x0024D9A4 File Offset: 0x0024BBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258136, RefRangeEnd = 258138, XrefRangeStart = 258113, XrefRangeEnd = 258136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x0024D9D8 File Offset: 0x0024BBD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258165, RefRangeEnd = 258166, XrefRangeStart = 258138, XrefRangeEnd = 258165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0024DA0C File Offset: 0x0024BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258166, XrefRangeEnd = 258168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x0024DA50 File Offset: 0x0024BC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258168, XrefRangeEnd = 258169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericUIScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x00043D0B File Offset: 0x00041F0B
		public GenericUIScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x06008D62 RID: 36194 RVA: 0x0024DA8C File Offset: 0x0024BC8C
		// (set) Token: 0x06008D63 RID: 36195 RVA: 0x00043D14 File Offset: 0x00041F14
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x06008D64 RID: 36196 RVA: 0x0024DAB4 File Offset: 0x0024BCB4
		// (set) Token: 0x06008D65 RID: 36197 RVA: 0x00043D2F File Offset: 0x00041F2F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x06008D66 RID: 36198 RVA: 0x0024DADC File Offset: 0x0024BCDC
		// (set) Token: 0x06008D67 RID: 36199 RVA: 0x00043D4E File Offset: 0x00041F4E
		public unsafe bool UseExitActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions)) = value;
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x06008D68 RID: 36200 RVA: 0x0024DB04 File Offset: 0x0024BD04
		// (set) Token: 0x06008D69 RID: 36201 RVA: 0x00043D69 File Offset: 0x00041F69
		public unsafe int ExitActionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority)) = value;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x06008D6A RID: 36202 RVA: 0x0024DB2C File Offset: 0x0024BD2C
		// (set) Token: 0x06008D6B RID: 36203 RVA: 0x00043D84 File Offset: 0x00041F84
		public unsafe bool CanExitWithRightClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick)) = value;
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x0024DB54 File Offset: 0x0024BD54
		// (set) Token: 0x06008D6D RID: 36205 RVA: 0x00043D9F File Offset: 0x00041F9F
		public unsafe bool ReenableControlsOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose)) = value;
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x06008D6E RID: 36206 RVA: 0x0024DB7C File Offset: 0x0024BD7C
		// (set) Token: 0x06008D6F RID: 36207 RVA: 0x00043DBA File Offset: 0x00041FBA
		public unsafe bool ReenableInventoryOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose)) = value;
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x0024DBA4 File Offset: 0x0024BDA4
		// (set) Token: 0x06008D71 RID: 36209 RVA: 0x00043DD5 File Offset: 0x00041FD5
		public unsafe bool ReenableEquippingOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose)) = value;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06008D72 RID: 36210 RVA: 0x0024DBCC File Offset: 0x0024BDCC
		// (set) Token: 0x06008D73 RID: 36211 RVA: 0x00043DF0 File Offset: 0x00041FF0
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06008D74 RID: 36212 RVA: 0x0024DBFC File Offset: 0x0024BDFC
		// (set) Token: 0x06008D75 RID: 36213 RVA: 0x00043E0F File Offset: 0x0004200F
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005FC4 RID: 24516
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FC5 RID: 24517
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005FC6 RID: 24518
		private static readonly IntPtr NativeFieldInfoPtr_UseExitActions;

		// Token: 0x04005FC7 RID: 24519
		private static readonly IntPtr NativeFieldInfoPtr_ExitActionPriority;

		// Token: 0x04005FC8 RID: 24520
		private static readonly IntPtr NativeFieldInfoPtr_CanExitWithRightClick;

		// Token: 0x04005FC9 RID: 24521
		private static readonly IntPtr NativeFieldInfoPtr_ReenableControlsOnClose;

		// Token: 0x04005FCA RID: 24522
		private static readonly IntPtr NativeFieldInfoPtr_ReenableInventoryOnClose;

		// Token: 0x04005FCB RID: 24523
		private static readonly IntPtr NativeFieldInfoPtr_ReenableEquippingOnClose;

		// Token: 0x04005FCC RID: 24524
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04005FCD RID: 24525
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04005FCE RID: 24526
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FCF RID: 24527
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005FD0 RID: 24528
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005FD1 RID: 24529
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005FD2 RID: 24530
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005FD3 RID: 24531
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005FD4 RID: 24532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
