using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063A RID: 1594
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x06008CE3 RID: 36067 RVA: 0x0024C19C File Offset: 0x0024A39C
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackFormPopup()
		{
			Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackFormPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr);
			FeedbackFormPopup.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "Label");
			FeedbackFormPopup.NativeFieldInfoPtr_AutoClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "AutoClose");
			FeedbackFormPopup.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "closeTime");
			FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680800);
			FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680801);
			FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680802);
			FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680803);
		}

		// Token: 0x06008CE4 RID: 36068 RVA: 0x0024C258 File Offset: 0x0024A458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257540, XrefRangeEnd = 257547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x0024C29C File Offset: 0x0024A49C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194914, RefRangeEnd = 194915, XrefRangeStart = 194914, XrefRangeEnd = 194915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x0024C2D0 File Offset: 0x0024A4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257547, XrefRangeEnd = 257550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x0024C304 File Offset: 0x0024A504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackFormPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00043934 File Offset: 0x00041B34
		public FeedbackFormPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0024C340 File Offset: 0x0024A540
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0004393D File Offset: 0x00041B3D
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x0024C370 File Offset: 0x0024A570
		// (set) Token: 0x06008CEC RID: 36076 RVA: 0x0004395C File Offset: 0x00041B5C
		public unsafe bool AutoClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose)) = value;
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x06008CED RID: 36077 RVA: 0x0024C398 File Offset: 0x0024A598
		// (set) Token: 0x06008CEE RID: 36078 RVA: 0x00043977 File Offset: 0x00041B77
		public unsafe float closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04005F7A RID: 24442
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005F7B RID: 24443
		private static readonly IntPtr NativeFieldInfoPtr_AutoClose;

		// Token: 0x04005F7C RID: 24444
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04005F7D RID: 24445
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x04005F7E RID: 24446
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005F7F RID: 24447
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F80 RID: 24448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
