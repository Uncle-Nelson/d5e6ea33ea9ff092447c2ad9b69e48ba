using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B0 RID: 1712
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x060099EE RID: 39406 RVA: 0x00272EA4 File Offset: 0x002710A4
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBubble()
		{
			Il2CppClassPointerStore<MessageBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageBubble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr);
			MessageBubble.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "text");
			MessageBubble.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignment");
			MessageBubble.NativeFieldInfoPtr_showTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "showTriangle");
			MessageBubble.NativeFieldInfoPtr_bubble_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MinWidth");
			MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MaxWidth");
			MessageBubble.NativeFieldInfoPtr_alignTextCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignTextCenter");
			MessageBubble.NativeFieldInfoPtr_autosetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "autosetPosition");
			MessageBubble.NativeFieldInfoPtr_displayedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "displayedText");
			MessageBubble.NativeFieldInfoPtr_triangleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangleShown");
			MessageBubble.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "container");
			MessageBubble.NativeFieldInfoPtr_bubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble");
			MessageBubble.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "content");
			MessageBubble.NativeFieldInfoPtr_triangle_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Left");
			MessageBubble.NativeFieldInfoPtr_triangle_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Right");
			MessageBubble.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "button");
			MessageBubble.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "height");
			MessageBubble.NativeFieldInfoPtr_spacingAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "spacingAbove");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Left");
			MessageBubble.NativeFieldInfoPtr_textColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Left");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Right");
			MessageBubble.NativeFieldInfoPtr_textColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Right");
			MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "baseBubbleSpacing");
			MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682268);
			MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682269);
			MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682270);
			MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682271);
			MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682272);
		}

		// Token: 0x060099EF RID: 39407 RVA: 0x002730F0 File Offset: 0x002712F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274498, RefRangeEnd = 274501, XrefRangeStart = 274474, XrefRangeEnd = 274498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignCenter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x00273150 File Offset: 0x00271350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274501, XrefRangeEnd = 274502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099F1 RID: 39409 RVA: 0x0027318C File Offset: 0x0027138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274502, XrefRangeEnd = 274515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshDisplayedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x002731C8 File Offset: 0x002713C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274515, XrefRangeEnd = 274524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTriangle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x00273204 File Offset: 0x00271404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274524, XrefRangeEnd = 274530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBubble() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x0004B209 File Offset: 0x00049409
		public MessageBubble(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x060099F5 RID: 39413 RVA: 0x00273240 File Offset: 0x00271440
		// (set) Token: 0x060099F6 RID: 39414 RVA: 0x0004B212 File Offset: 0x00049412
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x060099F7 RID: 39415 RVA: 0x00273268 File Offset: 0x00271468
		// (set) Token: 0x060099F8 RID: 39416 RVA: 0x0004B231 File Offset: 0x00049431
		public unsafe MessageBubble.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x060099F9 RID: 39417 RVA: 0x00273290 File Offset: 0x00271490
		// (set) Token: 0x060099FA RID: 39418 RVA: 0x0004B24C File Offset: 0x0004944C
		public unsafe bool showTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle)) = value;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x060099FB RID: 39419 RVA: 0x002732B8 File Offset: 0x002714B8
		// (set) Token: 0x060099FC RID: 39420 RVA: 0x0004B267 File Offset: 0x00049467
		public unsafe float bubble_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth)) = value;
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x002732E0 File Offset: 0x002714E0
		// (set) Token: 0x060099FE RID: 39422 RVA: 0x0004B282 File Offset: 0x00049482
		public unsafe float bubble_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth)) = value;
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x060099FF RID: 39423 RVA: 0x00273308 File Offset: 0x00271508
		// (set) Token: 0x06009A00 RID: 39424 RVA: 0x0004B29D File Offset: 0x0004949D
		public unsafe bool alignTextCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter)) = value;
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x00273330 File Offset: 0x00271530
		// (set) Token: 0x06009A02 RID: 39426 RVA: 0x0004B2B8 File Offset: 0x000494B8
		public unsafe bool autosetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition)) = value;
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00273358 File Offset: 0x00271558
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x0004B2D3 File Offset: 0x000494D3
		public unsafe string displayedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x00273380 File Offset: 0x00271580
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x0004B2F2 File Offset: 0x000494F2
		public unsafe bool triangleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown)) = value;
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x002733A8 File Offset: 0x002715A8
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x0004B30D File Offset: 0x0004950D
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x002733D8 File Offset: 0x002715D8
		// (set) Token: 0x06009A0A RID: 39434 RVA: 0x0004B32C File Offset: 0x0004952C
		public unsafe Image bubble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x00273408 File Offset: 0x00271608
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x0004B34B File Offset: 0x0004954B
		public unsafe Text content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x00273438 File Offset: 0x00271638
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x0004B36A File Offset: 0x0004956A
		public unsafe Image triangle_Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x00273468 File Offset: 0x00271668
		// (set) Token: 0x06009A10 RID: 39440 RVA: 0x0004B389 File Offset: 0x00049589
		public unsafe Image triangle_Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x06009A11 RID: 39441 RVA: 0x00273498 File Offset: 0x00271698
		// (set) Token: 0x06009A12 RID: 39442 RVA: 0x0004B3A8 File Offset: 0x000495A8
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x06009A13 RID: 39443 RVA: 0x002734C8 File Offset: 0x002716C8
		// (set) Token: 0x06009A14 RID: 39444 RVA: 0x0004B3C7 File Offset: 0x000495C7
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x06009A15 RID: 39445 RVA: 0x002734F0 File Offset: 0x002716F0
		// (set) Token: 0x06009A16 RID: 39446 RVA: 0x0004B3E2 File Offset: 0x000495E2
		public unsafe float spacingAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove)) = value;
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x00273518 File Offset: 0x00271718
		// (set) Token: 0x06009A18 RID: 39448 RVA: 0x0004B3FD File Offset: 0x000495FD
		public unsafe static Color32 backgroundColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x00273534 File Offset: 0x00271734
		// (set) Token: 0x06009A1A RID: 39450 RVA: 0x0004B40B File Offset: 0x0004960B
		public unsafe static Color32 textColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009A1B RID: 39451 RVA: 0x00273550 File Offset: 0x00271750
		// (set) Token: 0x06009A1C RID: 39452 RVA: 0x0004B419 File Offset: 0x00049619
		public unsafe static Color32 backgroundColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x0027356C File Offset: 0x0027176C
		// (set) Token: 0x06009A1E RID: 39454 RVA: 0x0004B427 File Offset: 0x00049627
		public unsafe static Color32 textColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x00273588 File Offset: 0x00271788
		// (set) Token: 0x06009A20 RID: 39456 RVA: 0x0004B435 File Offset: 0x00049635
		public unsafe static float baseBubbleSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&value));
			}
		}

		// Token: 0x0400679C RID: 26524
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400679D RID: 26525
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x0400679E RID: 26526
		private static readonly IntPtr NativeFieldInfoPtr_showTriangle;

		// Token: 0x0400679F RID: 26527
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MinWidth;

		// Token: 0x040067A0 RID: 26528
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MaxWidth;

		// Token: 0x040067A1 RID: 26529
		private static readonly IntPtr NativeFieldInfoPtr_alignTextCenter;

		// Token: 0x040067A2 RID: 26530
		private static readonly IntPtr NativeFieldInfoPtr_autosetPosition;

		// Token: 0x040067A3 RID: 26531
		private static readonly IntPtr NativeFieldInfoPtr_displayedText;

		// Token: 0x040067A4 RID: 26532
		private static readonly IntPtr NativeFieldInfoPtr_triangleShown;

		// Token: 0x040067A5 RID: 26533
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040067A6 RID: 26534
		private static readonly IntPtr NativeFieldInfoPtr_bubble;

		// Token: 0x040067A7 RID: 26535
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040067A8 RID: 26536
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Left;

		// Token: 0x040067A9 RID: 26537
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Right;

		// Token: 0x040067AA RID: 26538
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040067AB RID: 26539
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040067AC RID: 26540
		private static readonly IntPtr NativeFieldInfoPtr_spacingAbove;

		// Token: 0x040067AD RID: 26541
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Left;

		// Token: 0x040067AE RID: 26542
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Left;

		// Token: 0x040067AF RID: 26543
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Right;

		// Token: 0x040067B0 RID: 26544
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Right;

		// Token: 0x040067B1 RID: 26545
		private static readonly IntPtr NativeFieldInfoPtr_baseBubbleSpacing;

		// Token: 0x040067B2 RID: 26546
		private static readonly IntPtr NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0;

		// Token: 0x040067B3 RID: 26547
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040067B4 RID: 26548
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0;

		// Token: 0x040067B5 RID: 26549
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0;

		// Token: 0x040067B6 RID: 26550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7C RID: 2940
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x0400932A RID: 37674
			Center,
			// Token: 0x0400932B RID: 37675
			Left,
			// Token: 0x0400932C RID: 37676
			Right
		}
	}
}
