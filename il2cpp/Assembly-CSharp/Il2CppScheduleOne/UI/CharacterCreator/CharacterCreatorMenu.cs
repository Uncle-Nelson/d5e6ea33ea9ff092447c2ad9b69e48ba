using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FF RID: 1791
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x0600A0AD RID: 41133 RVA: 0x00287400 File Offset: 0x00285600
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorMenu()
		{
			Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr);
			CharacterCreatorMenu.NativeFieldInfoPtr_Windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Windows");
			CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "CategoryLabel");
			CharacterCreatorMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "BackButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "NextButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindowIndex");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindow");
			CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682949);
			CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682950);
			CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682951);
			CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682952);
			CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682953);
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x0028750C File Offset: 0x0028570C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282848, XrefRangeEnd = 282854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00287540 File Offset: 0x00285740
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282863, RefRangeEnd = 282866, XrefRangeStart = 282854, XrefRangeEnd = 282863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenWindow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x00287580 File Offset: 0x00285780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282866, XrefRangeEnd = 282867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x002875B4 File Offset: 0x002857B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282867, XrefRangeEnd = 282868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x002875E8 File Offset: 0x002857E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x0004F05E File Offset: 0x0004D25E
		public CharacterCreatorMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x00287624 File Offset: 0x00285824
		// (set) Token: 0x0600A0B5 RID: 41141 RVA: 0x0004F067 File Offset: 0x0004D267
		public unsafe Il2CppReferenceArray<CharacterCreatorMenu.Window> Windows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCreatorMenu.Window>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600A0B6 RID: 41142 RVA: 0x00287654 File Offset: 0x00285854
		// (set) Token: 0x0600A0B7 RID: 41143 RVA: 0x0004F086 File Offset: 0x0004D286
		public unsafe TextMeshProUGUI CategoryLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x00287684 File Offset: 0x00285884
		// (set) Token: 0x0600A0B9 RID: 41145 RVA: 0x0004F0A5 File Offset: 0x0004D2A5
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x002876B4 File Offset: 0x002858B4
		// (set) Token: 0x0600A0BB RID: 41147 RVA: 0x0004F0C4 File Offset: 0x0004D2C4
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x002876E4 File Offset: 0x002858E4
		// (set) Token: 0x0600A0BD RID: 41149 RVA: 0x0004F0E3 File Offset: 0x0004D2E3
		public unsafe int openWindowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex)) = value;
			}
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600A0BE RID: 41150 RVA: 0x0028770C File Offset: 0x0028590C
		// (set) Token: 0x0600A0BF RID: 41151 RVA: 0x0004F0FE File Offset: 0x0004D2FE
		public unsafe CharacterCreatorMenu.Window openWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorMenu.Window>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BB8 RID: 27576
		private static readonly IntPtr NativeFieldInfoPtr_Windows;

		// Token: 0x04006BB9 RID: 27577
		private static readonly IntPtr NativeFieldInfoPtr_CategoryLabel;

		// Token: 0x04006BBA RID: 27578
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006BBB RID: 27579
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x04006BBC RID: 27580
		private static readonly IntPtr NativeFieldInfoPtr_openWindowIndex;

		// Token: 0x04006BBD RID: 27581
		private static readonly IntPtr NativeFieldInfoPtr_openWindow;

		// Token: 0x04006BBE RID: 27582
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006BBF RID: 27583
		private static readonly IntPtr NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0;

		// Token: 0x04006BC0 RID: 27584
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006BC1 RID: 27585
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x04006BC2 RID: 27586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAC RID: 2988
		[Serializable]
		public class Window : Il2CppSystem.Object
		{
			// Token: 0x0600DCF4 RID: 56564 RVA: 0x00343740 File Offset: 0x00341940
			// Note: this type is marked as 'beforefieldinit'.
			static Window()
			{
				Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Window");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr);
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Name");
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Container");
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682954);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682955);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682956);
			}

			// Token: 0x0600DCF5 RID: 56565 RVA: 0x003437D0 File Offset: 0x003419D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282842, XrefRangeEnd = 282845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Open()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF6 RID: 56566 RVA: 0x00343804 File Offset: 0x00341A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282845, XrefRangeEnd = 282848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF7 RID: 56567 RVA: 0x00343838 File Offset: 0x00341A38
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Window() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF8 RID: 56568 RVA: 0x0006BAC4 File Offset: 0x00069CC4
			public Window(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447C RID: 17532
			// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x00343874 File Offset: 0x00341A74
			// (set) Token: 0x0600DCFA RID: 56570 RVA: 0x0006BACD File Offset: 0x00069CCD
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700447D RID: 17533
			// (get) Token: 0x0600DCFB RID: 56571 RVA: 0x0034389C File Offset: 0x00341A9C
			// (set) Token: 0x0600DCFC RID: 56572 RVA: 0x0006BAEC File Offset: 0x00069CEC
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009410 RID: 37904
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009411 RID: 37905
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009412 RID: 37906
			private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

			// Token: 0x04009413 RID: 37907
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

			// Token: 0x04009414 RID: 37908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
