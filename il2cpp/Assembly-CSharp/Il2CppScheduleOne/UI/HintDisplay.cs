using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000640 RID: 1600
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x06008D76 RID: 36214 RVA: 0x0024DC2C File Offset: 0x0024BE2C
		// Note: this type is marked as 'beforefieldinit'.
		static HintDisplay()
		{
			Il2CppClassPointerStore<HintDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HintDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr);
			HintDisplay.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FadeTime");
			HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			HintDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Container");
			HintDisplay.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Label");
			HintDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Group");
			HintDisplay.NativeFieldInfoPtr_DismissPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "DismissPrompt");
			HintDisplay.NativeFieldInfoPtr_FlashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FlashAnim");
			HintDisplay.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Padding");
			HintDisplay.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Offset");
			HintDisplay.NativeFieldInfoPtr_autoCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "autoCloseRoutine");
			HintDisplay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "fadeRoutine");
			HintDisplay.NativeFieldInfoPtr_hintQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "hintQueue");
			HintDisplay.NativeFieldInfoPtr_timeSinceOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "timeSinceOpened");
			HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680871);
			HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680872);
			HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680873);
			HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680874);
			HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680875);
			HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680876);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680877);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680878);
			HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680879);
			HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680880);
			HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680881);
			HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680882);
			HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680883);
			HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680884);
			HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680885);
			HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680886);
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x06008D77 RID: 36215 RVA: 0x0024DEA0 File Offset: 0x0024C0A0
		// (set) Token: 0x06008D78 RID: 36216 RVA: 0x0024DEDC File Offset: 0x0024C0DC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0024DF1C File Offset: 0x0024C11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258212, XrefRangeEnd = 258219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0024DF58 File Offset: 0x0024C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258219, XrefRangeEnd = 258241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x0024DF8C File Offset: 0x0024C18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258241, XrefRangeEnd = 258242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_10s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0024DFD0 File Offset: 0x0024C1D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258243, RefRangeEnd = 258248, XrefRangeStart = 258242, XrefRangeEnd = 258243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_20s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0024E014 File Offset: 0x0024C214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258248, XrefRangeEnd = 258249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x0024E058 File Offset: 0x0024C258
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 258271, RefRangeEnd = 258277, XrefRangeStart = 258249, XrefRangeEnd = 258271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text, float autoCloseTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCloseTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x0024E0A8 File Offset: 0x0024C2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258277, XrefRangeEnd = 258278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0024E0DC File Offset: 0x0024C2DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258294, RefRangeEnd = 258298, XrefRangeStart = 258278, XrefRangeEnd = 258294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x0024E11C File Offset: 0x0024C31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258298, XrefRangeEnd = 258309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_10s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0024E160 File Offset: 0x0024C360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258309, XrefRangeEnd = 258320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_20s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x0024E1A4 File Offset: 0x0024C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258320, XrefRangeEnd = 258328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint(string message, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x0024E1F4 File Offset: 0x0024C3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258370, RefRangeEnd = 258371, XrefRangeStart = 258328, XrefRangeEnd = 258370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x0024E23C File Offset: 0x0024C43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258371, XrefRangeEnd = 258381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HintDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x0024E278 File Offset: 0x0024C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258381, XrefRangeEnd = 258386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00043E2E File Offset: 0x0004202E
		public HintDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x0024E2C4 File Offset: 0x0024C4C4
		// (set) Token: 0x06008D89 RID: 36233 RVA: 0x00043E37 File Offset: 0x00042037
		public unsafe static float FadeTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&value));
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x0024E2E0 File Offset: 0x0024C4E0
		// (set) Token: 0x06008D8B RID: 36235 RVA: 0x00043E45 File Offset: 0x00042045
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x0024E308 File Offset: 0x0024C508
		// (set) Token: 0x06008D8D RID: 36237 RVA: 0x00043E60 File Offset: 0x00042060
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x06008D8E RID: 36238 RVA: 0x0024E338 File Offset: 0x0024C538
		// (set) Token: 0x06008D8F RID: 36239 RVA: 0x00043E7F File Offset: 0x0004207F
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x06008D90 RID: 36240 RVA: 0x0024E368 File Offset: 0x0024C568
		// (set) Token: 0x06008D91 RID: 36241 RVA: 0x00043E9E File Offset: 0x0004209E
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x06008D92 RID: 36242 RVA: 0x0024E398 File Offset: 0x0024C598
		// (set) Token: 0x06008D93 RID: 36243 RVA: 0x00043EBD File Offset: 0x000420BD
		public unsafe InputPrompt DismissPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x06008D94 RID: 36244 RVA: 0x0024E3C8 File Offset: 0x0024C5C8
		// (set) Token: 0x06008D95 RID: 36245 RVA: 0x00043EDC File Offset: 0x000420DC
		public unsafe Animation FlashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008D96 RID: 36246 RVA: 0x0024E3F8 File Offset: 0x0024C5F8
		// (set) Token: 0x06008D97 RID: 36247 RVA: 0x00043EFB File Offset: 0x000420FB
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06008D98 RID: 36248 RVA: 0x0024E420 File Offset: 0x0024C620
		// (set) Token: 0x06008D99 RID: 36249 RVA: 0x00043F16 File Offset: 0x00042116
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x0024E448 File Offset: 0x0024C648
		// (set) Token: 0x06008D9B RID: 36251 RVA: 0x00043F31 File Offset: 0x00042131
		public unsafe Coroutine autoCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06008D9C RID: 36252 RVA: 0x0024E478 File Offset: 0x0024C678
		// (set) Token: 0x06008D9D RID: 36253 RVA: 0x00043F50 File Offset: 0x00042150
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x0024E4A8 File Offset: 0x0024C6A8
		// (set) Token: 0x06008D9F RID: 36255 RVA: 0x00043F6F File Offset: 0x0004216F
		public unsafe List<HintDisplay.Hint> hintQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HintDisplay.Hint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x0024E4D8 File Offset: 0x0024C6D8
		// (set) Token: 0x06008DA1 RID: 36257 RVA: 0x00043F8E File Offset: 0x0004218E
		public unsafe float timeSinceOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened)) = value;
			}
		}

		// Token: 0x04005FD5 RID: 24533
		private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

		// Token: 0x04005FD6 RID: 24534
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FD7 RID: 24535
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005FD8 RID: 24536
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005FD9 RID: 24537
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005FDA RID: 24538
		private static readonly IntPtr NativeFieldInfoPtr_DismissPrompt;

		// Token: 0x04005FDB RID: 24539
		private static readonly IntPtr NativeFieldInfoPtr_FlashAnim;

		// Token: 0x04005FDC RID: 24540
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04005FDD RID: 24541
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04005FDE RID: 24542
		private static readonly IntPtr NativeFieldInfoPtr_autoCloseRoutine;

		// Token: 0x04005FDF RID: 24543
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04005FE0 RID: 24544
		private static readonly IntPtr NativeFieldInfoPtr_hintQueue;

		// Token: 0x04005FE1 RID: 24545
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceOpened;

		// Token: 0x04005FE2 RID: 24546
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FE3 RID: 24547
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005FE4 RID: 24548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005FE5 RID: 24549
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005FE6 RID: 24550
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0;

		// Token: 0x04005FE7 RID: 24551
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0;

		// Token: 0x04005FE8 RID: 24552
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_0;

		// Token: 0x04005FE9 RID: 24553
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0;

		// Token: 0x04005FEA RID: 24554
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04005FEB RID: 24555
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04005FEC RID: 24556
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0;

		// Token: 0x04005FED RID: 24557
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0;

		// Token: 0x04005FEE RID: 24558
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0;

		// Token: 0x04005FEF RID: 24559
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x04005FF0 RID: 24560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005FF1 RID: 24561
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000B25 RID: 2853
		public class Hint : Il2CppSystem.Object
		{
			// Token: 0x0600D79A RID: 55194 RVA: 0x00334264 File Offset: 0x00332464
			// Note: this type is marked as 'beforefieldinit'.
			static Hint()
			{
				Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Hint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr);
				HintDisplay.Hint.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Text");
				HintDisplay.Hint.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Duration");
				HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, 100680887);
			}

			// Token: 0x0600D79B RID: 55195 RVA: 0x003342CC File Offset: 0x003324CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70203, XrefRangeEnd = 70204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hint(string text, float duration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D79C RID: 55196 RVA: 0x00068F97 File Offset: 0x00067197
			public Hint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D2 RID: 17106
			// (get) Token: 0x0600D79D RID: 55197 RVA: 0x00334328 File Offset: 0x00332528
			// (set) Token: 0x0600D79E RID: 55198 RVA: 0x00068FA0 File Offset: 0x000671A0
			public unsafe string Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042D3 RID: 17107
			// (get) Token: 0x0600D79F RID: 55199 RVA: 0x00334350 File Offset: 0x00332550
			// (set) Token: 0x0600D7A0 RID: 55200 RVA: 0x00068FBF File Offset: 0x000671BF
			public unsafe float Duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration)) = value;
				}
			}

			// Token: 0x040090EE RID: 37102
			private static readonly IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x040090EF RID: 37103
			private static readonly IntPtr NativeFieldInfoPtr_Duration;

			// Token: 0x040090F0 RID: 37104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x02000B26 RID: 2854
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<<ShowHint>g__AutoClose|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D7A1 RID: 55201 RVA: 0x00334378 File Offset: 0x00332578
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique()
			{
				Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<<ShowHint>g__AutoClose|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>1__state");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>2__current");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "time");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>4__this");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680888);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680889);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680890);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680891);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680892);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680893);
			}

			// Token: 0x0600D7A2 RID: 55202 RVA: 0x0033446C File Offset: 0x0033266C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7A3 RID: 55203 RVA: 0x003344B4 File Offset: 0x003326B4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7A4 RID: 55204 RVA: 0x003344E8 File Offset: 0x003326E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258169, XrefRangeEnd = 258174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x00334524 File Offset: 0x00332724
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7A6 RID: 55206 RVA: 0x00334564 File Offset: 0x00332764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258174, XrefRangeEnd = 258179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x00334598 File Offset: 0x00332798
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7A8 RID: 55208 RVA: 0x00068FDA File Offset: 0x000671DA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D4 RID: 17108
			// (get) Token: 0x0600D7A9 RID: 55209 RVA: 0x003345D8 File Offset: 0x003327D8
			// (set) Token: 0x0600D7AA RID: 55210 RVA: 0x00068FE3 File Offset: 0x000671E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042D5 RID: 17109
			// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x00334600 File Offset: 0x00332800
			// (set) Token: 0x0600D7AC RID: 55212 RVA: 0x00068FFE File Offset: 0x000671FE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x00334630 File Offset: 0x00332830
			// (set) Token: 0x0600D7AE RID: 55214 RVA: 0x0006901D File Offset: 0x0006721D
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x00334658 File Offset: 0x00332858
			// (set) Token: 0x0600D7B0 RID: 55216 RVA: 0x00069038 File Offset: 0x00067238
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090F1 RID: 37105
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090F2 RID: 37106
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090F3 RID: 37107
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x040090F4 RID: 37108
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090F5 RID: 37109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090F6 RID: 37110
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090F7 RID: 37111
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090F8 RID: 37112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090F9 RID: 37113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090FA RID: 37114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B27 RID: 2855
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7B1 RID: 55217 RVA: 0x00334688 File Offset: 0x00332888
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr);
				HintDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9");
				HintDisplay.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9__28_0");
				HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100680895);
				HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100680896);
			}

			// Token: 0x0600D7B2 RID: 55218 RVA: 0x00334704 File Offset: 0x00332904
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7B3 RID: 55219 RVA: 0x00334740 File Offset: 0x00332940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258179, XrefRangeEnd = 258192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ProcessText_b__28_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D7B4 RID: 55220 RVA: 0x00069057 File Offset: 0x00067257
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x00334788 File Offset: 0x00332988
			// (set) Token: 0x0600D7B6 RID: 55222 RVA: 0x00069060 File Offset: 0x00067260
			public unsafe static HintDisplay.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600D7B7 RID: 55223 RVA: 0x003347B0 File Offset: 0x003329B0
			// (set) Token: 0x0600D7B8 RID: 55224 RVA: 0x00069072 File Offset: 0x00067272
			public unsafe static MatchEvaluator __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090FB RID: 37115
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090FC RID: 37116
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040090FD RID: 37117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090FE RID: 37118
			private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0;
		}

		// Token: 0x02000B28 RID: 2856
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7B9 RID: 55225 RVA: 0x003347D8 File Offset: 0x003329D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr);
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "alpha");
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100680897);
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100680898);
			}

			// Token: 0x0600D7BA RID: 55226 RVA: 0x00334854 File Offset: 0x00332A54
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7BB RID: 55227 RVA: 0x00334890 File Offset: 0x00332A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258207, XrefRangeEnd = 258212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D7BC RID: 55228 RVA: 0x00069084 File Offset: 0x00067284
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x003348D0 File Offset: 0x00332AD0
			// (set) Token: 0x0600D7BE RID: 55230 RVA: 0x0006908D File Offset: 0x0006728D
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x00334900 File Offset: 0x00332B00
			// (set) Token: 0x0600D7C0 RID: 55232 RVA: 0x000690AC File Offset: 0x000672AC
			public unsafe float alpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha)) = value;
				}
			}

			// Token: 0x040090FF RID: 37119
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009100 RID: 37120
			private static readonly IntPtr NativeFieldInfoPtr_alpha;

			// Token: 0x04009101 RID: 37121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009102 RID: 37122
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C74 RID: 3188
			[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0+<<SetAlpha>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E571 RID: 58737 RVA: 0x0035C128 File Offset: 0x0035A328
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<<SetAlpha>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680899);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680900);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680901);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680902);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680903);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680904);
				}

				// Token: 0x0600E572 RID: 58738 RVA: 0x0035C230 File Offset: 0x0035A430
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E573 RID: 58739 RVA: 0x0035C278 File Offset: 0x0035A478
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E574 RID: 58740 RVA: 0x0035C2AC File Offset: 0x0035A4AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258192, XrefRangeEnd = 258202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700475A RID: 18266
				// (get) Token: 0x0600E575 RID: 58741 RVA: 0x0035C2E8 File Offset: 0x0035A4E8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E576 RID: 58742 RVA: 0x0035C328 File Offset: 0x0035A528
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258202, XrefRangeEnd = 258207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700475B RID: 18267
				// (get) Token: 0x0600E577 RID: 58743 RVA: 0x0035C35C File Offset: 0x0035A55C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E578 RID: 58744 RVA: 0x0006FE81 File Offset: 0x0006E081
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004755 RID: 18261
				// (get) Token: 0x0600E579 RID: 58745 RVA: 0x0035C39C File Offset: 0x0035A59C
				// (set) Token: 0x0600E57A RID: 58746 RVA: 0x0006FE8A File Offset: 0x0006E08A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004756 RID: 18262
				// (get) Token: 0x0600E57B RID: 58747 RVA: 0x0035C3C4 File Offset: 0x0035A5C4
				// (set) Token: 0x0600E57C RID: 58748 RVA: 0x0006FEA5 File Offset: 0x0006E0A5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004757 RID: 18263
				// (get) Token: 0x0600E57D RID: 58749 RVA: 0x0035C3F4 File Offset: 0x0035A5F4
				// (set) Token: 0x0600E57E RID: 58750 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
				public unsafe HintDisplay.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004758 RID: 18264
				// (get) Token: 0x0600E57F RID: 58751 RVA: 0x0035C424 File Offset: 0x0035A624
				// (set) Token: 0x0600E580 RID: 58752 RVA: 0x0006FEE3 File Offset: 0x0006E0E3
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004759 RID: 18265
				// (get) Token: 0x0600E581 RID: 58753 RVA: 0x0035C44C File Offset: 0x0035A64C
				// (set) Token: 0x0600E582 RID: 58754 RVA: 0x0006FEFE File Offset: 0x0006E0FE
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400996C RID: 39276
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400996D RID: 39277
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400996E RID: 39278
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400996F RID: 39279
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009970 RID: 39280
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009971 RID: 39281
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009972 RID: 39282
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009973 RID: 39283
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009974 RID: 39284
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009975 RID: 39285
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009976 RID: 39286
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
