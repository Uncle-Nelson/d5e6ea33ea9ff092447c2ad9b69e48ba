using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006F0 RID: 1776
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		// Token: 0x06009EEF RID: 40687 RVA: 0x00281FC4 File Offset: 0x002801C4
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsManager()
		{
			Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr);
			InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "KeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "WideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "ExtraWideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "LeftClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "MiddleClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "RightClickPromptPrefab");
			InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682788);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682789);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682790);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682791);
			InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682792);
			InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682793);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x002820E4 File Offset: 0x002802E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281079, RefRangeEnd = 281080, XrefRangeStart = 281042, XrefRangeEnd = 281079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage GetPromptImage(string controlPath, RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PromptImage>(intPtr3) : null;
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x00282148 File Offset: 0x00280348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281080, XrefRangeEnd = 281089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathMouseRelated(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x00282198 File Offset: 0x00280398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281128, RefRangeEnd = 281129, XrefRangeStart = 281089, XrefRangeEnd = 281128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x002821E8 File Offset: 0x002803E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281129, XrefRangeEnd = 281132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathExtraWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x00282238 File Offset: 0x00280438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 281282, RefRangeEnd = 281287, XrefRangeStart = 281132, XrefRangeEnd = 281282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayNameForControlPath(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x00282280 File Offset: 0x00280480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281287, XrefRangeEnd = 281290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x0004DF86 File Offset: 0x0004C186
		public InputPromptsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x002822BC File Offset: 0x002804BC
		// (set) Token: 0x06009EF8 RID: 40696 RVA: 0x0004DF8F File Offset: 0x0004C18F
		public unsafe GameObject KeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06009EF9 RID: 40697 RVA: 0x002822EC File Offset: 0x002804EC
		// (set) Token: 0x06009EFA RID: 40698 RVA: 0x0004DFAE File Offset: 0x0004C1AE
		public unsafe GameObject WideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06009EFB RID: 40699 RVA: 0x0028231C File Offset: 0x0028051C
		// (set) Token: 0x06009EFC RID: 40700 RVA: 0x0004DFCD File Offset: 0x0004C1CD
		public unsafe GameObject ExtraWideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06009EFD RID: 40701 RVA: 0x0028234C File Offset: 0x0028054C
		// (set) Token: 0x06009EFE RID: 40702 RVA: 0x0004DFEC File Offset: 0x0004C1EC
		public unsafe GameObject LeftClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x0028237C File Offset: 0x0028057C
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x0004E00B File Offset: 0x0004C20B
		public unsafe GameObject MiddleClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x002823AC File Offset: 0x002805AC
		// (set) Token: 0x06009F02 RID: 40706 RVA: 0x0004E02A File Offset: 0x0004C22A
		public unsafe GameObject RightClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AA6 RID: 27302
		private static readonly IntPtr NativeFieldInfoPtr_KeyPromptPrefab;

		// Token: 0x04006AA7 RID: 27303
		private static readonly IntPtr NativeFieldInfoPtr_WideKeyPromptPrefab;

		// Token: 0x04006AA8 RID: 27304
		private static readonly IntPtr NativeFieldInfoPtr_ExtraWideKeyPromptPrefab;

		// Token: 0x04006AA9 RID: 27305
		private static readonly IntPtr NativeFieldInfoPtr_LeftClickPromptPrefab;

		// Token: 0x04006AAA RID: 27306
		private static readonly IntPtr NativeFieldInfoPtr_MiddleClickPromptPrefab;

		// Token: 0x04006AAB RID: 27307
		private static readonly IntPtr NativeFieldInfoPtr_RightClickPromptPrefab;

		// Token: 0x04006AAC RID: 27308
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0;

		// Token: 0x04006AAD RID: 27309
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0;

		// Token: 0x04006AAE RID: 27310
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0;

		// Token: 0x04006AAF RID: 27311
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0;

		// Token: 0x04006AB0 RID: 27312
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0;

		// Token: 0x04006AB1 RID: 27313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
