using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000446 RID: 1094
	[Serializable]
	public class DialogueChoiceData : Object
	{
		// Token: 0x06005F77 RID: 24439 RVA: 0x001B6764 File Offset: 0x001B4964
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceData()
		{
			Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChoiceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr);
			DialogueChoiceData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "Guid");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceText");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceLabel");
			DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, 100675476);
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x001B67E4 File Offset: 0x001B49E4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x0002D054 File Offset: 0x0002B254
		public DialogueChoiceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001B6820 File Offset: 0x001B4A20
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x0002D05D File Offset: 0x0002B25D
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x001B6848 File Offset: 0x001B4A48
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x0002D07C File Offset: 0x0002B27C
		public unsafe string ChoiceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x001B6870 File Offset: 0x001B4A70
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x0002D09B File Offset: 0x0002B29B
		public unsafe string ChoiceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceLabel;

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
