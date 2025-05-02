using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E8 RID: 1768
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x06009E5D RID: 40541 RVA: 0x00280488 File Offset: 0x0027E688
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuPopup()
		{
			Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr);
			MainMenuPopup.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Screen");
			MainMenuPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Title");
			MainMenuPopup.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Description");
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682727);
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682728);
			MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100682729);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x00280530 File Offset: 0x0027E730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280372, RefRangeEnd = 280373, XrefRangeStart = 280370, XrefRangeEnd = 280372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MainMenuPopup.Data data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x00280574 File Offset: 0x0027E774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280375, RefRangeEnd = 280376, XrefRangeStart = 280373, XrefRangeEnd = 280375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string description, bool isBad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x002805D8 File Offset: 0x0027E7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280376, XrefRangeEnd = 280379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x0004DAA7 File Offset: 0x0004BCA7
		public MainMenuPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009E62 RID: 40546 RVA: 0x00280614 File Offset: 0x0027E814
		// (set) Token: 0x06009E63 RID: 40547 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		public unsafe MainMenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06009E64 RID: 40548 RVA: 0x00280644 File Offset: 0x0027E844
		// (set) Token: 0x06009E65 RID: 40549 RVA: 0x0004DACF File Offset: 0x0004BCCF
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06009E66 RID: 40550 RVA: 0x00280674 File Offset: 0x0027E874
		// (set) Token: 0x06009E67 RID: 40551 RVA: 0x0004DAEE File Offset: 0x0004BCEE
		public unsafe TextMeshProUGUI Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A4D RID: 27213
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04006A4E RID: 27214
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006A4F RID: 27215
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04006A50 RID: 27216
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Data_0;

		// Token: 0x04006A51 RID: 27217
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0;

		// Token: 0x04006A52 RID: 27218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9C RID: 2972
		public class Data : Object
		{
			// Token: 0x0600DC72 RID: 56434 RVA: 0x00342168 File Offset: 0x00340368
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr);
				MainMenuPopup.Data.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Title");
				MainMenuPopup.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Description");
				MainMenuPopup.Data.NativeFieldInfoPtr_IsBad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "IsBad");
				MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, 100682730);
			}

			// Token: 0x0600DC73 RID: 56435 RVA: 0x003421E4 File Offset: 0x003403E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280369, RefRangeEnd = 280370, XrefRangeStart = 280366, XrefRangeEnd = 280369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Data(string title, string description, bool isBad) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBad;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC74 RID: 56436 RVA: 0x0006B630 File Offset: 0x00069830
			public Data(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004452 RID: 17490
			// (get) Token: 0x0600DC75 RID: 56437 RVA: 0x00342250 File Offset: 0x00340450
			// (set) Token: 0x0600DC76 RID: 56438 RVA: 0x0006B639 File Offset: 0x00069839
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004453 RID: 17491
			// (get) Token: 0x0600DC77 RID: 56439 RVA: 0x00342278 File Offset: 0x00340478
			// (set) Token: 0x0600DC78 RID: 56440 RVA: 0x0006B658 File Offset: 0x00069858
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004454 RID: 17492
			// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x003422A0 File Offset: 0x003404A0
			// (set) Token: 0x0600DC7A RID: 56442 RVA: 0x0006B677 File Offset: 0x00069877
			public unsafe bool IsBad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad)) = value;
				}
			}

			// Token: 0x040093BC RID: 37820
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x040093BD RID: 37821
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x040093BE RID: 37822
			private static readonly IntPtr NativeFieldInfoPtr_IsBad;

			// Token: 0x040093BF RID: 37823
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;
		}
	}
}
