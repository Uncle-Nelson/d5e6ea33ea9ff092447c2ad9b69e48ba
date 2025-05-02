using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ExtendedComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006ED RID: 1773
	public class SetupScreen : MainMenuScreen
	{
		// Token: 0x06009EA3 RID: 40611 RVA: 0x00281204 File Offset: 0x0027F404
		// Note: this type is marked as 'beforefieldinit'.
		static SetupScreen()
		{
			Il2CppClassPointerStore<SetupScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SetupScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr);
			SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "DEFAULT_SAVE_PATH");
			SetupScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "InputField");
			SetupScreen.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "StartButton");
			SetupScreen.NativeFieldInfoPtr_SkipIntroContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroContainer");
			SetupScreen.NativeFieldInfoPtr_SkipIntroToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroToggle");
			SetupScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "NotHostWarning");
			SetupScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "slotIndex");
			SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682760);
			SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682761);
			SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682762);
			SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682763);
			SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682764);
			SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682765);
			SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682766);
			SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682767);
			SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682768);
			SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682769);
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00281388 File Offset: 0x0027F588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280674, XrefRangeEnd = 280686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x002813C4 File Offset: 0x0027F5C4
		[CallerCount(0)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00281404 File Offset: 0x0027F604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280686, XrefRangeEnd = 280699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00281438 File Offset: 0x0027F638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280781, RefRangeEnd = 280782, XrefRangeStart = 280699, XrefRangeEnd = 280781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x0028146C File Offset: 0x0027F66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280782, XrefRangeEnd = 280783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInputValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x002814A8 File Offset: 0x0027F6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280783, XrefRangeEnd = 280792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFolderContents(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x002814EC File Offset: 0x0027F6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280817, RefRangeEnd = 280818, XrefRangeStart = 280792, XrefRangeEnd = 280817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyDefaultSaveToFolder(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x00281530 File Offset: 0x0027F730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280818, XrefRangeEnd = 280833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x00281578 File Offset: 0x0027F778
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x002815B4 File Offset: 0x0027F7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280833, XrefRangeEnd = 280834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__7_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x0004DCD4 File Offset: 0x0004BED4
		public SetupScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009EAF RID: 40623 RVA: 0x002815F8 File Offset: 0x0027F7F8
		// (set) Token: 0x06009EB0 RID: 40624 RVA: 0x0004DCDD File Offset: 0x0004BEDD
		public unsafe static string DEFAULT_SAVE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x00281618 File Offset: 0x0027F818
		// (set) Token: 0x06009EB2 RID: 40626 RVA: 0x0004DCEF File Offset: 0x0004BEEF
		public unsafe GameInputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x00281648 File Offset: 0x0027F848
		// (set) Token: 0x06009EB4 RID: 40628 RVA: 0x0004DD0E File Offset: 0x0004BF0E
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009EB5 RID: 40629 RVA: 0x00281678 File Offset: 0x0027F878
		// (set) Token: 0x06009EB6 RID: 40630 RVA: 0x0004DD2D File Offset: 0x0004BF2D
		public unsafe RectTransform SkipIntroContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x002816A8 File Offset: 0x0027F8A8
		// (set) Token: 0x06009EB8 RID: 40632 RVA: 0x0004DD4C File Offset: 0x0004BF4C
		public unsafe Toggle SkipIntroToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x002816D8 File Offset: 0x0027F8D8
		// (set) Token: 0x06009EBA RID: 40634 RVA: 0x0004DD6B File Offset: 0x0004BF6B
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00281708 File Offset: 0x0027F908
		// (set) Token: 0x06009EBC RID: 40636 RVA: 0x0004DD8A File Offset: 0x0004BF8A
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006A77 RID: 27255
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SAVE_PATH;

		// Token: 0x04006A78 RID: 27256
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006A79 RID: 27257
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04006A7A RID: 27258
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroContainer;

		// Token: 0x04006A7B RID: 27259
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroToggle;

		// Token: 0x04006A7C RID: 27260
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x04006A7D RID: 27261
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006A7E RID: 27262
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006A7F RID: 27263
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006A80 RID: 27264
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A81 RID: 27265
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;

		// Token: 0x04006A82 RID: 27266
		private static readonly IntPtr NativeMethodInfoPtr_IsInputValid_Private_Boolean_0;

		// Token: 0x04006A83 RID: 27267
		private static readonly IntPtr NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0;

		// Token: 0x04006A84 RID: 27268
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0;

		// Token: 0x04006A85 RID: 27269
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x04006A86 RID: 27270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A87 RID: 27271
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0;
	}
}
