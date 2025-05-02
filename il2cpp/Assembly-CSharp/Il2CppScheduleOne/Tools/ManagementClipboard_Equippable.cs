using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.UI.Management;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000529 RID: 1321
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007625 RID: 30245 RVA: 0x002025C4 File Offset: 0x002007C4
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard_Equippable()
		{
			Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr);
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Clipboard");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "LoweredPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "RaisedPosition");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "Light");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "OverrideText");
			ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, "moveRoutine");
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678184);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678185);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678186);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678187);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678188);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678189);
			ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678190);
			ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr, 100678191);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00202720 File Offset: 0x00200920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230633, XrefRangeEnd = 230683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00202770 File Offset: 0x00200970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230683, XrefRangeEnd = 230718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x002027AC File Offset: 0x002009AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230718, XrefRangeEnd = 230766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x002027E8 File Offset: 0x002009E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230766, XrefRangeEnd = 230784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x0020281C File Offset: 0x00200A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230784, XrefRangeEnd = 230803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullscreenExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_FullscreenExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00202850 File Offset: 0x00200A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230808, RefRangeEnd = 230811, XrefRangeStart = 230803, XrefRangeEnd = 230808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideClipboardText(string overriddenText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(overriddenText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00202894 File Offset: 0x00200A94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230816, RefRangeEnd = 230819, XrefRangeStart = 230811, XrefRangeEnd = 230816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x002028C8 File Offset: 0x00200AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00037F9E File Offset: 0x0003619E
		public ManagementClipboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x00202904 File Offset: 0x00200B04
		// (set) Token: 0x06007630 RID: 30256 RVA: 0x00037FA7 File Offset: 0x000361A7
		public unsafe Transform Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x06007631 RID: 30257 RVA: 0x00202934 File Offset: 0x00200B34
		// (set) Token: 0x06007632 RID: 30258 RVA: 0x00037FC6 File Offset: 0x000361C6
		public unsafe Transform LoweredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_LoweredPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x06007633 RID: 30259 RVA: 0x00202964 File Offset: 0x00200B64
		// (set) Token: 0x06007634 RID: 30260 RVA: 0x00037FE5 File Offset: 0x000361E5
		public unsafe Transform RaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_RaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x00202994 File Offset: 0x00200B94
		// (set) Token: 0x06007636 RID: 30262 RVA: 0x00038004 File Offset: 0x00036204
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06007637 RID: 30263 RVA: 0x002029C4 File Offset: 0x00200BC4
		// (set) Token: 0x06007638 RID: 30264 RVA: 0x00038023 File Offset: 0x00036223
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06007639 RID: 30265 RVA: 0x002029F4 File Offset: 0x00200BF4
		// (set) Token: 0x0600763A RID: 30266 RVA: 0x00038042 File Offset: 0x00036242
		public unsafe TextMeshProUGUI OverrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_OverrideText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600763B RID: 30267 RVA: 0x00202A24 File Offset: 0x00200C24
		// (set) Token: 0x0600763C RID: 30268 RVA: 0x00038061 File Offset: 0x00036261
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard_Equippable.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050BD RID: 20669
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x040050BE RID: 20670
		private static readonly IntPtr NativeFieldInfoPtr_LoweredPosition;

		// Token: 0x040050BF RID: 20671
		private static readonly IntPtr NativeFieldInfoPtr_RaisedPosition;

		// Token: 0x040050C0 RID: 20672
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040050C1 RID: 20673
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x040050C2 RID: 20674
		private static readonly IntPtr NativeFieldInfoPtr_OverrideText;

		// Token: 0x040050C3 RID: 20675
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x040050C4 RID: 20676
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040050C5 RID: 20677
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040050C6 RID: 20678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040050C7 RID: 20679
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenEnter_Private_Void_0;

		// Token: 0x040050C8 RID: 20680
		private static readonly IntPtr NativeMethodInfoPtr_FullscreenExit_Private_Void_0;

		// Token: 0x040050C9 RID: 20681
		private static readonly IntPtr NativeMethodInfoPtr_OverrideClipboardText_Public_Void_String_0;

		// Token: 0x040050CA RID: 20682
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x040050CB RID: 20683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
