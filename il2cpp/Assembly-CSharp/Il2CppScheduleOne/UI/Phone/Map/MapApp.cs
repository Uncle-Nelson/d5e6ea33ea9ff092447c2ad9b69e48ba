using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Map
{
	// Token: 0x020006A9 RID: 1705
	public class MapApp : App<MapApp>
	{
		// Token: 0x060098AC RID: 39084 RVA: 0x0026F3CC File Offset: 0x0026D5CC
		// Note: this type is marked as 'beforefieldinit'.
		static MapApp()
		{
			Il2CppClassPointerStore<MapApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Map", "MapApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapApp>.NativeClassPtr);
			MapApp.NativeFieldInfoPtr_KeyMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "KeyMoveSpeed");
			MapApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "ContentRect");
			MapApp.NativeFieldInfoPtr_PoIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "PoIContainer");
			MapApp.NativeFieldInfoPtr_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "HorizontalScrollbar");
			MapApp.NativeFieldInfoPtr_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "VerticalScrollbar");
			MapApp.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "BackgroundImage");
			MapApp.NativeFieldInfoPtr_LabelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelGroup");
			MapApp.NativeFieldInfoPtr_DemoMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "DemoMapSprite");
			MapApp.NativeFieldInfoPtr_MainMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "MainMapSprite");
			MapApp.NativeFieldInfoPtr_TutorialMapSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "TutorialMapSprite");
			MapApp.NativeFieldInfoPtr_LabelScrollMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMin");
			MapApp.NativeFieldInfoPtr_LabelScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "LabelScrollMax");
			MapApp.NativeFieldInfoPtr_SkipFocusPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "SkipFocusPlayer");
			MapApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "contentMoveRoutine");
			MapApp.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapApp>.NativeClassPtr, "opened");
			MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682148);
			MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682149);
			MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682150);
			MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682151);
			MapApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapApp>.NativeClassPtr, 100682152);
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x0026F58C File Offset: 0x0026D78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272887, XrefRangeEnd = 272898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x0026F5C8 File Offset: 0x0026D7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272898, XrefRangeEnd = 272942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x0026F614 File Offset: 0x0026D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272942, XrefRangeEnd = 272955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x0026F650 File Offset: 0x0026D850
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272961, RefRangeEnd = 272965, XrefRangeStart = 272955, XrefRangeEnd = 272961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusPosition(Vector2 anchoredPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref anchoredPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x0026F690 File Offset: 0x0026D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272965, XrefRangeEnd = 272971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x0004A5BC File Offset: 0x000487BC
		public MapApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x060098B3 RID: 39091 RVA: 0x0026F6CC File Offset: 0x0026D8CC
		// (set) Token: 0x060098B4 RID: 39092 RVA: 0x0004A5C5 File Offset: 0x000487C5
		public unsafe static float KeyMoveSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapApp.NativeFieldInfoPtr_KeyMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x0026F6E8 File Offset: 0x0026D8E8
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x0004A5D3 File Offset: 0x000487D3
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x060098B7 RID: 39095 RVA: 0x0026F718 File Offset: 0x0026D918
		// (set) Token: 0x060098B8 RID: 39096 RVA: 0x0004A5F2 File Offset: 0x000487F2
		public unsafe RectTransform PoIContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_PoIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x060098B9 RID: 39097 RVA: 0x0026F748 File Offset: 0x0026D948
		// (set) Token: 0x060098BA RID: 39098 RVA: 0x0004A611 File Offset: 0x00048811
		public unsafe Scrollbar HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x060098BB RID: 39099 RVA: 0x0026F778 File Offset: 0x0026D978
		// (set) Token: 0x060098BC RID: 39100 RVA: 0x0004A630 File Offset: 0x00048830
		public unsafe Scrollbar VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x0026F7A8 File Offset: 0x0026D9A8
		// (set) Token: 0x060098BE RID: 39102 RVA: 0x0004A64F File Offset: 0x0004884F
		public unsafe Image BackgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x060098BF RID: 39103 RVA: 0x0026F7D8 File Offset: 0x0026D9D8
		// (set) Token: 0x060098C0 RID: 39104 RVA: 0x0004A66E File Offset: 0x0004886E
		public unsafe CanvasGroup LabelGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x060098C1 RID: 39105 RVA: 0x0026F808 File Offset: 0x0026DA08
		// (set) Token: 0x060098C2 RID: 39106 RVA: 0x0004A68D File Offset: 0x0004888D
		public unsafe Sprite DemoMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_DemoMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x0026F838 File Offset: 0x0026DA38
		// (set) Token: 0x060098C4 RID: 39108 RVA: 0x0004A6AC File Offset: 0x000488AC
		public unsafe Sprite MainMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_MainMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x0026F868 File Offset: 0x0026DA68
		// (set) Token: 0x060098C6 RID: 39110 RVA: 0x0004A6CB File Offset: 0x000488CB
		public unsafe Sprite TutorialMapSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_TutorialMapSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x060098C7 RID: 39111 RVA: 0x0026F898 File Offset: 0x0026DA98
		// (set) Token: 0x060098C8 RID: 39112 RVA: 0x0004A6EA File Offset: 0x000488EA
		public unsafe float LabelScrollMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMin)) = value;
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x060098C9 RID: 39113 RVA: 0x0026F8C0 File Offset: 0x0026DAC0
		// (set) Token: 0x060098CA RID: 39114 RVA: 0x0004A705 File Offset: 0x00048905
		public unsafe float LabelScrollMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_LabelScrollMax)) = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x060098CB RID: 39115 RVA: 0x0026F8E8 File Offset: 0x0026DAE8
		// (set) Token: 0x060098CC RID: 39116 RVA: 0x0004A720 File Offset: 0x00048920
		public unsafe bool SkipFocusPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_SkipFocusPlayer)) = value;
			}
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x060098CD RID: 39117 RVA: 0x0026F910 File Offset: 0x0026DB10
		// (set) Token: 0x060098CE RID: 39118 RVA: 0x0004A73B File Offset: 0x0004893B
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x060098CF RID: 39119 RVA: 0x0026F940 File Offset: 0x0026DB40
		// (set) Token: 0x060098D0 RID: 39120 RVA: 0x0004A75A File Offset: 0x0004895A
		public unsafe bool opened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapApp.NativeFieldInfoPtr_opened)) = value;
			}
		}

		// Token: 0x040066D2 RID: 26322
		private static readonly IntPtr NativeFieldInfoPtr_KeyMoveSpeed;

		// Token: 0x040066D3 RID: 26323
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x040066D4 RID: 26324
		private static readonly IntPtr NativeFieldInfoPtr_PoIContainer;

		// Token: 0x040066D5 RID: 26325
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalScrollbar;

		// Token: 0x040066D6 RID: 26326
		private static readonly IntPtr NativeFieldInfoPtr_VerticalScrollbar;

		// Token: 0x040066D7 RID: 26327
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;

		// Token: 0x040066D8 RID: 26328
		private static readonly IntPtr NativeFieldInfoPtr_LabelGroup;

		// Token: 0x040066D9 RID: 26329
		private static readonly IntPtr NativeFieldInfoPtr_DemoMapSprite;

		// Token: 0x040066DA RID: 26330
		private static readonly IntPtr NativeFieldInfoPtr_MainMapSprite;

		// Token: 0x040066DB RID: 26331
		private static readonly IntPtr NativeFieldInfoPtr_TutorialMapSprite;

		// Token: 0x040066DC RID: 26332
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMin;

		// Token: 0x040066DD RID: 26333
		private static readonly IntPtr NativeFieldInfoPtr_LabelScrollMax;

		// Token: 0x040066DE RID: 26334
		private static readonly IntPtr NativeFieldInfoPtr_SkipFocusPlayer;

		// Token: 0x040066DF RID: 26335
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x040066E0 RID: 26336
		private static readonly IntPtr NativeFieldInfoPtr_opened;

		// Token: 0x040066E1 RID: 26337
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040066E2 RID: 26338
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040066E3 RID: 26339
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040066E4 RID: 26340
		private static readonly IntPtr NativeMethodInfoPtr_FocusPosition_Public_Void_Vector2_0;

		// Token: 0x040066E5 RID: 26341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
