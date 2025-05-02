using System;
using Il2CppAeLa.EasyFeedback;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000639 RID: 1593
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x06008CC2 RID: 36034 RVA: 0x0024BA7C File Offset: 0x00249C7C
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackForm()
		{
			Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackForm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr);
			FeedbackForm.NativeFieldInfoPtr_ssCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ssCoroutine");
			FeedbackForm.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CanvasGroup");
			FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ScreenshotToggle");
			FeedbackForm.NativeFieldInfoPtr_SaveFileToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SaveFileToggle");
			FeedbackForm.NativeFieldInfoPtr_SummaryField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SummaryField");
			FeedbackForm.NativeFieldInfoPtr_DescriptionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "DescriptionField");
			FeedbackForm.NativeFieldInfoPtr_Cog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "Cog");
			FeedbackForm.NativeFieldInfoPtr_CategoryDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CategoryDropdown");
			FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680773);
			FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680774);
			FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680775);
			FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680776);
			FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680777);
			FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680778);
			FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680779);
			FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680780);
			FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680781);
			FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680782);
			FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680783);
			FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680784);
			FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680785);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680786);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680787);
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x0024BC78 File Offset: 0x00249E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257252, XrefRangeEnd = 257279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x0024BCB4 File Offset: 0x00249EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257279, XrefRangeEnd = 257282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x0024BCE8 File Offset: 0x00249EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257282, XrefRangeEnd = 257287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x0024BD1C File Offset: 0x00249F1C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenshotToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x0024BD5C File Offset: 0x00249F5C
		[CallerCount(0)]
		public unsafe void OnSaveFileToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x0024BD9C File Offset: 0x00249F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257287, XrefRangeEnd = 257301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFormData(string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x0024BDE0 File Offset: 0x00249FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257301, XrefRangeEnd = 257313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x0024BE24 File Offset: 0x0024A024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257313, XrefRangeEnd = 257490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x0024BE60 File Offset: 0x0024A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257490, XrefRangeEnd = 257515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetTextToAppendToTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x0024BEA4 File Offset: 0x0024A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257515, XrefRangeEnd = 257521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x0024BED8 File Offset: 0x0024A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257521, XrefRangeEnd = 257526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator ScreenshotAndOpenForm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x0024BF18 File Offset: 0x0024A118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257526, XrefRangeEnd = 257527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackForm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x0024BF54 File Offset: 0x0024A154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257527, XrefRangeEnd = 257532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x0024BF94 File Offset: 0x0024A194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257532, XrefRangeEnd = 257536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_0(Il2CppStructArray<byte> ss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ss);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x0024BFD8 File Offset: 0x0024A1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257536, XrefRangeEnd = 257540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_1(string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(err);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CD2 RID: 36050 RVA: 0x00043833 File Offset: 0x00041A33
		public FeedbackForm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x0024C01C File Offset: 0x0024A21C
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x0004383C File Offset: 0x00041A3C
		public new unsafe Coroutine ssCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x0024C04C File Offset: 0x0024A24C
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x0004385B File Offset: 0x00041A5B
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x0024C07C File Offset: 0x0024A27C
		// (set) Token: 0x06008CD8 RID: 36056 RVA: 0x0004387A File Offset: 0x00041A7A
		public unsafe Toggle ScreenshotToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x0024C0AC File Offset: 0x0024A2AC
		// (set) Token: 0x06008CDA RID: 36058 RVA: 0x00043899 File Offset: 0x00041A99
		public unsafe Toggle SaveFileToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x06008CDB RID: 36059 RVA: 0x0024C0DC File Offset: 0x0024A2DC
		// (set) Token: 0x06008CDC RID: 36060 RVA: 0x000438B8 File Offset: 0x00041AB8
		public unsafe TMP_InputField SummaryField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x0024C10C File Offset: 0x0024A30C
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x000438D7 File Offset: 0x00041AD7
		public unsafe TMP_InputField DescriptionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x0024C13C File Offset: 0x0024A33C
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x000438F6 File Offset: 0x00041AF6
		public unsafe RectTransform Cog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x0024C16C File Offset: 0x0024A36C
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x00043915 File Offset: 0x00041B15
		public unsafe TMP_Dropdown CategoryDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F63 RID: 24419
		private static readonly IntPtr NativeFieldInfoPtr_ssCoroutine;

		// Token: 0x04005F64 RID: 24420
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04005F65 RID: 24421
		private static readonly IntPtr NativeFieldInfoPtr_ScreenshotToggle;

		// Token: 0x04005F66 RID: 24422
		private static readonly IntPtr NativeFieldInfoPtr_SaveFileToggle;

		// Token: 0x04005F67 RID: 24423
		private static readonly IntPtr NativeFieldInfoPtr_SummaryField;

		// Token: 0x04005F68 RID: 24424
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionField;

		// Token: 0x04005F69 RID: 24425
		private static readonly IntPtr NativeFieldInfoPtr_Cog;

		// Token: 0x04005F6A RID: 24426
		private static readonly IntPtr NativeFieldInfoPtr_CategoryDropdown;

		// Token: 0x04005F6B RID: 24427
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005F6C RID: 24428
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F6D RID: 24429
		private static readonly IntPtr NativeMethodInfoPtr_PrepScreenshot_Public_Void_0;

		// Token: 0x04005F6E RID: 24430
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0;

		// Token: 0x04005F6F RID: 24431
		private static readonly IntPtr NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0;

		// Token: 0x04005F70 RID: 24432
		private static readonly IntPtr NativeMethodInfoPtr_SetFormData_Public_Void_String_0;

		// Token: 0x04005F71 RID: 24433
		private static readonly IntPtr NativeMethodInfoPtr_SetCategory_Public_Void_String_0;

		// Token: 0x04005F72 RID: 24434
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Virtual_Void_0;

		// Token: 0x04005F73 RID: 24435
		private static readonly IntPtr NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0;

		// Token: 0x04005F74 RID: 24436
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04005F75 RID: 24437
		private static readonly IntPtr NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0;

		// Token: 0x04005F76 RID: 24438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F77 RID: 24439
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005F78 RID: 24440
		private static readonly IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04005F79 RID: 24441
		private static readonly IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0;

		// Token: 0x02000B1E RID: 2846
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<<Submit>g__Wait|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D74C RID: 55116 RVA: 0x0033349C File Offset: 0x0033169C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique()
			{
				Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<<Submit>g__Wait|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>1__state");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>2__current");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>4__this");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680788);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680789);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680790);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680791);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680792);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680793);
			}

			// Token: 0x0600D74D RID: 55117 RVA: 0x0033357C File Offset: 0x0033177C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D74E RID: 55118 RVA: 0x003335C4 File Offset: 0x003317C4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D74F RID: 55119 RVA: 0x003335F8 File Offset: 0x003317F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257222, XrefRangeEnd = 257228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042BA RID: 17082
			// (get) Token: 0x0600D750 RID: 55120 RVA: 0x00333634 File Offset: 0x00331834
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D751 RID: 55121 RVA: 0x00333674 File Offset: 0x00331874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257228, XrefRangeEnd = 257233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042BB RID: 17083
			// (get) Token: 0x0600D752 RID: 55122 RVA: 0x003336A8 File Offset: 0x003318A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D753 RID: 55123 RVA: 0x00068D06 File Offset: 0x00066F06
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B7 RID: 17079
			// (get) Token: 0x0600D754 RID: 55124 RVA: 0x003336E8 File Offset: 0x003318E8
			// (set) Token: 0x0600D755 RID: 55125 RVA: 0x00068D0F File Offset: 0x00066F0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042B8 RID: 17080
			// (get) Token: 0x0600D756 RID: 55126 RVA: 0x00333710 File Offset: 0x00331910
			// (set) Token: 0x0600D757 RID: 55127 RVA: 0x00068D2A File Offset: 0x00066F2A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B9 RID: 17081
			// (get) Token: 0x0600D758 RID: 55128 RVA: 0x00333740 File Offset: 0x00331940
			// (set) Token: 0x0600D759 RID: 55129 RVA: 0x00068D49 File Offset: 0x00066F49
			public unsafe FeedbackForm __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090BE RID: 37054
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090BF RID: 37055
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090C0 RID: 37056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090C1 RID: 37057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090C2 RID: 37058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090C3 RID: 37059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090C4 RID: 37060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090C5 RID: 37061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090C6 RID: 37062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1F RID: 2847
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<ScreenshotAndOpenForm>d__18")]
		public sealed class _ScreenshotAndOpenForm_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D75A RID: 55130 RVA: 0x00333770 File Offset: 0x00331970
			// Note: this type is marked as 'beforefieldinit'.
			static _ScreenshotAndOpenForm_d__18()
			{
				Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<ScreenshotAndOpenForm>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>1__state");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>2__current");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>4__this");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680794);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680795);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680796);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680797);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680798);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680799);
			}

			// Token: 0x0600D75B RID: 55131 RVA: 0x00333850 File Offset: 0x00331A50
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ScreenshotAndOpenForm_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D75C RID: 55132 RVA: 0x00333898 File Offset: 0x00331A98
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D75D RID: 55133 RVA: 0x003338CC File Offset: 0x00331ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257233, XrefRangeEnd = 257247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042BF RID: 17087
			// (get) Token: 0x0600D75E RID: 55134 RVA: 0x00333908 File Offset: 0x00331B08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D75F RID: 55135 RVA: 0x00333948 File Offset: 0x00331B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257247, XrefRangeEnd = 257252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042C0 RID: 17088
			// (get) Token: 0x0600D760 RID: 55136 RVA: 0x0033397C File Offset: 0x00331B7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D761 RID: 55137 RVA: 0x00068D68 File Offset: 0x00066F68
			public _ScreenshotAndOpenForm_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BC RID: 17084
			// (get) Token: 0x0600D762 RID: 55138 RVA: 0x003339BC File Offset: 0x00331BBC
			// (set) Token: 0x0600D763 RID: 55139 RVA: 0x00068D71 File Offset: 0x00066F71
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042BD RID: 17085
			// (get) Token: 0x0600D764 RID: 55140 RVA: 0x003339E4 File Offset: 0x00331BE4
			// (set) Token: 0x0600D765 RID: 55141 RVA: 0x00068D8C File Offset: 0x00066F8C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BE RID: 17086
			// (get) Token: 0x0600D766 RID: 55142 RVA: 0x00333A14 File Offset: 0x00331C14
			// (set) Token: 0x0600D767 RID: 55143 RVA: 0x00068DAB File Offset: 0x00066FAB
			public unsafe FeedbackForm __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C7 RID: 37063
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090C8 RID: 37064
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090C9 RID: 37065
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090CA RID: 37066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090CB RID: 37067
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090CC RID: 37068
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090CD RID: 37069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090CE RID: 37070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090CF RID: 37071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
