using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class DialogueEvent : Object
	{
		// Token: 0x06005EC4 RID: 24260 RVA: 0x001B3F8C File Offset: 0x001B218C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueEvent()
		{
			Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr);
			DialogueEvent.NativeFieldInfoPtr_Dialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "Dialogue");
			DialogueEvent.NativeFieldInfoPtr_onDialogueEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "onDialogueEnded");
			DialogueEvent.NativeFieldInfoPtr_NodeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "NodeEvents");
			DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, 100675370);
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x001B400C File Offset: 0x001B220C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x0002CB03 File Offset: 0x0002AD03
		public DialogueEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x001B4048 File Offset: 0x001B2248
		// (set) Token: 0x06005EC8 RID: 24264 RVA: 0x0002CB0C File Offset: 0x0002AD0C
		public unsafe DialogueContainer Dialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x001B4078 File Offset: 0x001B2278
		// (set) Token: 0x06005ECA RID: 24266 RVA: 0x0002CB2B File Offset: 0x0002AD2B
		public unsafe UnityEvent onDialogueEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x001B40A8 File Offset: 0x001B22A8
		// (set) Token: 0x06005ECC RID: 24268 RVA: 0x0002CB4A File Offset: 0x0002AD4A
		public unsafe Il2CppReferenceArray<DialogueNodeEvent> NodeEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueNodeEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040CA RID: 16586
		private static readonly IntPtr NativeFieldInfoPtr_Dialogue;

		// Token: 0x040040CB RID: 16587
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueEnded;

		// Token: 0x040040CC RID: 16588
		private static readonly IntPtr NativeFieldInfoPtr_NodeEvents;

		// Token: 0x040040CD RID: 16589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
