using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000133 RID: 307
	public class HelpBoxAttribute : PropertyAttribute
	{
		// Token: 0x06001A15 RID: 6677 RVA: 0x000C20FC File Offset: 0x000C02FC
		// Note: this type is marked as 'beforefieldinit'.
		static HelpBoxAttribute()
		{
			Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "HelpBoxAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr);
			HelpBoxAttribute.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, "text");
			HelpBoxAttribute.NativeFieldInfoPtr_messageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, "messageType");
			HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr, 100666061);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000C2168 File Offset: 0x000C0368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96927, XrefRangeEnd = 96929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpBoxAttribute(string text, HelpBoxMessageType messageType = HelpBoxMessageType.None) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpBoxAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0000ED97 File Offset: 0x0000CF97
		public HelpBoxAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000C21C4 File Offset: 0x000C03C4
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000C21EC File Offset: 0x000C03EC
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000EDBF File Offset: 0x0000CFBF
		public unsafe HelpBoxMessageType messageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_messageType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpBoxAttribute.NativeFieldInfoPtr_messageType)) = value;
			}
		}

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeFieldInfoPtr_messageType;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HelpBoxMessageType_0;
	}
}
