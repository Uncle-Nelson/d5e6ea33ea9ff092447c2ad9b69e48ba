using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public class TextResponseData : Object
	{
		// Token: 0x060031D6 RID: 12758 RVA: 0x0010E87C File Offset: 0x0010CA7C
		// Note: this type is marked as 'beforefieldinit'.
		static TextResponseData()
		{
			Il2CppClassPointerStore<TextResponseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextResponseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr);
			TextResponseData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Text");
			TextResponseData.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, "Label");
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100668853);
			TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr, 100668854);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0010E8FC File Offset: 0x0010CAFC
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110734, XrefRangeEnd = 110783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData(string text, string label) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0010E95C File Offset: 0x0010CB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131310, RefRangeEnd = 131311, XrefRangeStart = 131302, XrefRangeEnd = 131310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextResponseData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResponseData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0001AB19 File Offset: 0x00018D19
		public TextResponseData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x0010E998 File Offset: 0x0010CB98
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x0001AB22 File Offset: 0x00018D22
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x0010E9C0 File Offset: 0x0010CBC0
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x0001AB41 File Offset: 0x00018D41
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResponseData.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
