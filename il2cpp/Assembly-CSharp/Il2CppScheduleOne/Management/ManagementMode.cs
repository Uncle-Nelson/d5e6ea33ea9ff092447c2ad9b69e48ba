using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039F RID: 927
	public class ManagementMode : Singleton<ManagementMode>
	{
		// Token: 0x0600489B RID: 18587 RVA: 0x001632BC File Offset: 0x001614BC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementMode()
		{
			Il2CppClassPointerStore<ManagementMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr);
			ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "ManagementModeInputPrompt");
			ManagementMode.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "Canvas");
			ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "OnEnterManagementMode");
			ManagementMode.NativeFieldInfoPtr_onExitManagementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, "onExitManagementMode");
			ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672295);
			ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672296);
			ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672297);
			ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672298);
			ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672299);
			ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672300);
			ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672301);
			ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672302);
			ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672303);
			ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672304);
			ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672305);
			ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr, 100672306);
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x00163440 File Offset: 0x00161640
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x00163480 File Offset: 0x00161680
		public unsafe Property CurrentProperty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x001634C4 File Offset: 0x001616C4
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162531, XrefRangeEnd = 162535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x00163500 File Offset: 0x00161700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162535, XrefRangeEnd = 162550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementMode.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x0016353C File Offset: 0x0016173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162550, XrefRangeEnd = 162564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00163570 File Offset: 0x00161770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162630, RefRangeEnd = 162631, XrefRangeStart = 162564, XrefRangeEnd = 162630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x001635A4 File Offset: 0x001617A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162631, XrefRangeEnd = 162637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x001635E8 File Offset: 0x001617E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162637, XrefRangeEnd = 162651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterManagementMode(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0016362C File Offset: 0x0016182C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162665, RefRangeEnd = 162667, XrefRangeStart = 162651, XrefRangeEnd = 162665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_ExitManagementMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00163660 File Offset: 0x00161860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162667, XrefRangeEnd = 162680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanEnterManagementMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00163690 File Offset: 0x00161890
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanExitManagementMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x001636C0 File Offset: 0x001618C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162680, XrefRangeEnd = 162683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementMode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x0002301B File Offset: 0x0002121B
		public ManagementMode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x001636FC File Offset: 0x001618FC
		// (set) Token: 0x060048AA RID: 18602 RVA: 0x00023024 File Offset: 0x00021224
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x0016372C File Offset: 0x0016192C
		// (set) Token: 0x060048AC RID: 18604 RVA: 0x00023043 File Offset: 0x00021243
		public unsafe InputPrompt ManagementModeInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_ManagementModeInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x060048AD RID: 18605 RVA: 0x0016375C File Offset: 0x0016195C
		// (set) Token: 0x060048AE RID: 18606 RVA: 0x00023062 File Offset: 0x00021262
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x060048AF RID: 18607 RVA: 0x0016378C File Offset: 0x0016198C
		// (set) Token: 0x060048B0 RID: 18608 RVA: 0x00023081 File Offset: 0x00021281
		public unsafe UnityEvent OnEnterManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_OnEnterManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x001637BC File Offset: 0x001619BC
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x000230A0 File Offset: 0x000212A0
		public unsafe UnityEvent onExitManagementMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementMode.NativeFieldInfoPtr_onExitManagementMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeFieldInfoPtr_ManagementModeInputPrompt;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeFieldInfoPtr_OnEnterManagementMode;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeFieldInfoPtr_onExitManagementMode;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_EnterManagementMode_Public_Void_Property_0;

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeMethodInfoPtr_ExitManagementMode_Public_Void_0;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr_CanEnterManagementMode_Public_Static_Boolean_0;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr_CanExitManagementMode_Public_Static_Boolean_0;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
