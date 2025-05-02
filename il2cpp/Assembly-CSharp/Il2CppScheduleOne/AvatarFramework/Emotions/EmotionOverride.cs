using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000606 RID: 1542
	public class EmotionOverride : Object
	{
		// Token: 0x060087F0 RID: 34800 RVA: 0x0023D3AC File Offset: 0x0023B5AC
		// Note: this type is marked as 'beforefieldinit'.
		static EmotionOverride()
		{
			Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "EmotionOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr);
			EmotionOverride.NativeFieldInfoPtr_Emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Emotion");
			EmotionOverride.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Label");
			EmotionOverride.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Priority");
			EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, 100680240);
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x0023D42C File Offset: 0x0023B62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride(string emotion, string label, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00040C75 File Offset: 0x0003EE75
		public EmotionOverride(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x060087F3 RID: 34803 RVA: 0x0023D498 File Offset: 0x0023B698
		// (set) Token: 0x060087F4 RID: 34804 RVA: 0x00040C7E File Offset: 0x0003EE7E
		public unsafe string Emotion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x0023D4C0 File Offset: 0x0023B6C0
		// (set) Token: 0x060087F6 RID: 34806 RVA: 0x00040C9D File Offset: 0x0003EE9D
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x060087F7 RID: 34807 RVA: 0x0023D4E8 File Offset: 0x0023B6E8
		// (set) Token: 0x060087F8 RID: 34808 RVA: 0x00040CBC File Offset: 0x0003EEBC
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x04005C67 RID: 23655
		private static readonly IntPtr NativeFieldInfoPtr_Emotion;

		// Token: 0x04005C68 RID: 23656
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005C69 RID: 23657
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005C6A RID: 23658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
	}
}
