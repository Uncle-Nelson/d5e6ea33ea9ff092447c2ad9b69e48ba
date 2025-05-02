using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000436 RID: 1078
	[Serializable]
	public class DialogueList : Object
	{
		// Token: 0x06005EA0 RID: 24224 RVA: 0x001B3864 File Offset: 0x001B1A64
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueList()
		{
			Il2CppClassPointerStore<DialogueList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueList>.NativeClassPtr);
			DialogueList.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, "Lines");
			DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675355);
			DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675356);
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x001B38D0 File Offset: 0x001B1AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197508, XrefRangeEnd = 197510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x001B3908 File Offset: 0x001B1B08
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
		public DialogueList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005EA4 RID: 24228 RVA: 0x001B3944 File Offset: 0x001B1B44
		// (set) Token: 0x06005EA5 RID: 24229 RVA: 0x0002C9FD File Offset: 0x0002ABFD
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040B6 RID: 16566
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x040040B7 RID: 16567
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;

		// Token: 0x040040B8 RID: 16568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
