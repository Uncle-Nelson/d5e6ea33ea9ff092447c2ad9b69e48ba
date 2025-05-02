using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000437 RID: 1079
	[Serializable]
	public class DialogueChain : Object
	{
		// Token: 0x06005EA6 RID: 24230 RVA: 0x001B3974 File Offset: 0x001B1B74
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChain()
		{
			Il2CppClassPointerStore<DialogueChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr);
			DialogueChain.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, "Lines");
			DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675357);
			DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675358);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x001B39E0 File Offset: 0x001B1BE0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 197518, RefRangeEnd = 197532, XrefRangeStart = 197510, XrefRangeEnd = 197518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetMessageChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x001B3A20 File Offset: 0x001B1C20
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x0002CA1C File Offset: 0x0002AC1C
		public DialogueChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06005EAA RID: 24234 RVA: 0x001B3A5C File Offset: 0x001B1C5C
		// (set) Token: 0x06005EAB RID: 24235 RVA: 0x0002CA25 File Offset: 0x0002AC25
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040B9 RID: 16569
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x040040BA RID: 16570
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0;

		// Token: 0x040040BB RID: 16571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
