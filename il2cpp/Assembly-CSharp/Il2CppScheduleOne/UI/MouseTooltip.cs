using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064A RID: 1610
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06008EC8 RID: 36552 RVA: 0x0025190C File Offset: 0x0024FB0C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseTooltip()
		{
			Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MouseTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr);
			MouseTooltip.NativeFieldInfoPtr_IconRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconRect");
			MouseTooltip.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconImg");
			MouseTooltip.NativeFieldInfoPtr_TooltipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipRect");
			MouseTooltip.NativeFieldInfoPtr_TooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipLabel");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_NoIcon");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_WithIcon");
			MouseTooltip.NativeFieldInfoPtr_IconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconOffset");
			MouseTooltip.NativeFieldInfoPtr_Color_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Color_Invalid");
			MouseTooltip.NativeFieldInfoPtr_Sprite_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Sprite_Cross");
			MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "tooltipShownThisFrame");
			MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "iconShownThisFrame");
			MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681021);
			MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681022);
			MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681023);
			MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681024);
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x00251A68 File Offset: 0x0024FC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259808, RefRangeEnd = 259809, XrefRangeStart = 259808, XrefRangeEnd = 259808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x00251AB8 File Offset: 0x0024FCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259810, RefRangeEnd = 259811, XrefRangeStart = 259809, XrefRangeEnd = 259810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowIcon(Sprite sprite, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x00251B08 File Offset: 0x0024FD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259811, XrefRangeEnd = 259821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x00251B3C File Offset: 0x0024FD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259821, XrefRangeEnd = 259824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseTooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x00044B99 File Offset: 0x00042D99
		public MouseTooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008ECE RID: 36558 RVA: 0x00251B78 File Offset: 0x0024FD78
		// (set) Token: 0x06008ECF RID: 36559 RVA: 0x00044BA2 File Offset: 0x00042DA2
		public unsafe RectTransform IconRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x00251BA8 File Offset: 0x0024FDA8
		// (set) Token: 0x06008ED1 RID: 36561 RVA: 0x00044BC1 File Offset: 0x00042DC1
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06008ED2 RID: 36562 RVA: 0x00251BD8 File Offset: 0x0024FDD8
		// (set) Token: 0x06008ED3 RID: 36563 RVA: 0x00044BE0 File Offset: 0x00042DE0
		public unsafe RectTransform TooltipRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06008ED4 RID: 36564 RVA: 0x00251C08 File Offset: 0x0024FE08
		// (set) Token: 0x06008ED5 RID: 36565 RVA: 0x00044BFF File Offset: 0x00042DFF
		public unsafe TextMeshProUGUI TooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x00251C38 File Offset: 0x0024FE38
		// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x00044C1E File Offset: 0x00042E1E
		public unsafe Vector3 TooltipOffset_NoIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon)) = value;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x00251C60 File Offset: 0x0024FE60
		// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x00044C39 File Offset: 0x00042E39
		public unsafe Vector3 TooltipOffset_WithIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon)) = value;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x00251C88 File Offset: 0x0024FE88
		// (set) Token: 0x06008EDB RID: 36571 RVA: 0x00044C54 File Offset: 0x00042E54
		public unsafe Vector3 IconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset)) = value;
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008EDC RID: 36572 RVA: 0x00251CB0 File Offset: 0x0024FEB0
		// (set) Token: 0x06008EDD RID: 36573 RVA: 0x00044C6F File Offset: 0x00042E6F
		public unsafe Color Color_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid)) = value;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x00251CD8 File Offset: 0x0024FED8
		// (set) Token: 0x06008EDF RID: 36575 RVA: 0x00044C8A File Offset: 0x00042E8A
		public unsafe Sprite Sprite_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x00251D08 File Offset: 0x0024FF08
		// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x00044CA9 File Offset: 0x00042EA9
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x00251D30 File Offset: 0x0024FF30
		// (set) Token: 0x06008EE3 RID: 36579 RVA: 0x00044CC4 File Offset: 0x00042EC4
		public unsafe bool iconShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame)) = value;
			}
		}

		// Token: 0x040060A5 RID: 24741
		private static readonly IntPtr NativeFieldInfoPtr_IconRect;

		// Token: 0x040060A6 RID: 24742
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x040060A7 RID: 24743
		private static readonly IntPtr NativeFieldInfoPtr_TooltipRect;

		// Token: 0x040060A8 RID: 24744
		private static readonly IntPtr NativeFieldInfoPtr_TooltipLabel;

		// Token: 0x040060A9 RID: 24745
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_NoIcon;

		// Token: 0x040060AA RID: 24746
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_WithIcon;

		// Token: 0x040060AB RID: 24747
		private static readonly IntPtr NativeFieldInfoPtr_IconOffset;

		// Token: 0x040060AC RID: 24748
		private static readonly IntPtr NativeFieldInfoPtr_Color_Invalid;

		// Token: 0x040060AD RID: 24749
		private static readonly IntPtr NativeFieldInfoPtr_Sprite_Cross;

		// Token: 0x040060AE RID: 24750
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x040060AF RID: 24751
		private static readonly IntPtr NativeFieldInfoPtr_iconShownThisFrame;

		// Token: 0x040060B0 RID: 24752
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0;

		// Token: 0x040060B1 RID: 24753
		private static readonly IntPtr NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0;

		// Token: 0x040060B2 RID: 24754
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040060B3 RID: 24755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
