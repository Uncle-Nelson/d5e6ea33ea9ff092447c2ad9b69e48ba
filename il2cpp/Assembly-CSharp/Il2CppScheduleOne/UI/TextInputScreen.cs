using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066E RID: 1646
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x060092EE RID: 37614 RVA: 0x0025DC80 File Offset: 0x0025BE80
		// Note: this type is marked as 'beforefieldinit'.
		static TextInputScreen()
		{
			Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TextInputScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr);
			TextInputScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "Canvas");
			TextInputScreen.NativeFieldInfoPtr_HeaderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "HeaderLabel");
			TextInputScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "InputField");
			TextInputScreen.NativeFieldInfoPtr_onSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "onSubmit");
			TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681520);
			TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681521);
			TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681522);
			TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681523);
			TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681524);
			TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681525);
			TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681526);
			TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681527);
			TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681528);
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x060092EF RID: 37615 RVA: 0x0025DDB4 File Offset: 0x0025BFB4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 259909, RefRangeEnd = 259910, XrefRangeStart = 259909, XrefRangeEnd = 259910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0025DDF0 File Offset: 0x0025BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265190, XrefRangeEnd = 265203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x0025DE2C File Offset: 0x0025C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265203, XrefRangeEnd = 265204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x0025DE60 File Offset: 0x0025C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265204, XrefRangeEnd = 265205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x0025DE94 File Offset: 0x0025C094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265205, XrefRangeEnd = 265208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x0025DEC8 File Offset: 0x0025C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265208, XrefRangeEnd = 265211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x0025DF0C File Offset: 0x0025C10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265240, RefRangeEnd = 265241, XrefRangeStart = 265211, XrefRangeEnd = 265240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_onSubmit);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x0025DF80 File Offset: 0x0025C180
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265266, RefRangeEnd = 265270, XrefRangeStart = 265241, XrefRangeEnd = 265266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool submit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x0025DFC0 File Offset: 0x0025C1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265270, XrefRangeEnd = 265273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInputScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x00047255 File Offset: 0x00045455
		public TextInputScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x060092F9 RID: 37625 RVA: 0x0025DFFC File Offset: 0x0025C1FC
		// (set) Token: 0x060092FA RID: 37626 RVA: 0x0004725E File Offset: 0x0004545E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x060092FB RID: 37627 RVA: 0x0025E02C File Offset: 0x0025C22C
		// (set) Token: 0x060092FC RID: 37628 RVA: 0x0004727D File Offset: 0x0004547D
		public unsafe TextMeshProUGUI HeaderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x0025E05C File Offset: 0x0025C25C
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x0004729C File Offset: 0x0004549C
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x0025E08C File Offset: 0x0025C28C
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x000472BB File Offset: 0x000454BB
		public unsafe TextInputScreen.OnSubmit onSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInputScreen.OnSubmit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006339 RID: 25401
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400633A RID: 25402
		private static readonly IntPtr NativeFieldInfoPtr_HeaderLabel;

		// Token: 0x0400633B RID: 25403
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x0400633C RID: 25404
		private static readonly IntPtr NativeFieldInfoPtr_onSubmit;

		// Token: 0x0400633D RID: 25405
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400633E RID: 25406
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400633F RID: 25407
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x04006340 RID: 25408
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04006341 RID: 25409
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006342 RID: 25410
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006343 RID: 25411
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0;

		// Token: 0x04006344 RID: 25412
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04006345 RID: 25413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B52 RID: 2898
		public sealed class OnSubmit : MulticastDelegate
		{
			// Token: 0x0600D9C1 RID: 55745 RVA: 0x0033A668 File Offset: 0x00338868
			// Note: this type is marked as 'beforefieldinit'.
			static OnSubmit()
			{
				Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "OnSubmit");
				TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681529);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681530);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681531);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681532);
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x0033A6DC File Offset: 0x003388DC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83966, RefRangeEnd = 83970, XrefRangeStart = 83966, XrefRangeEnd = 83970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnSubmit(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x0033A738 File Offset: 0x00338938
			[CallerCount(0)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C4 RID: 55748 RVA: 0x0033A77C File Offset: 0x0033897C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x0033A7F0 File Offset: 0x003389F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9C6 RID: 55750 RVA: 0x0006A100 File Offset: 0x00068300
			public OnSubmit(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x0006A109 File Offset: 0x00068309
			public static implicit operator TextInputScreen.OnSubmit(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<TextInputScreen.OnSubmit>(A_0);
			}

			// Token: 0x0600D9C8 RID: 55752 RVA: 0x0006A111 File Offset: 0x00068311
			public static TextInputScreen.OnSubmit operator +(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TextInputScreen.OnSubmit>();
			}

			// Token: 0x0600D9C9 RID: 55753 RVA: 0x0006A11F File Offset: 0x0006831F
			public static TextInputScreen.OnSubmit operator -(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<TextInputScreen.OnSubmit>();
				}
				return result;
			}

			// Token: 0x0400923F RID: 37439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009240 RID: 37440
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x04009241 RID: 37441
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04009242 RID: 37442
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
