using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043B RID: 1083
	[Serializable]
	public class DialogueNodeEvent : Object
	{
		// Token: 0x06005ECD RID: 24269 RVA: 0x001B40D8 File Offset: 0x001B22D8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeEvent()
		{
			Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr);
			DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "NodeLabel");
			DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "onNodeDisplayed");
			DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, 100675371);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x001B4144 File Offset: 0x001B2344
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x0002CB69 File Offset: 0x0002AD69
		public DialogueNodeEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x001B4180 File Offset: 0x001B2380
		// (set) Token: 0x06005ED1 RID: 24273 RVA: 0x0002CB72 File Offset: 0x0002AD72
		public unsafe string NodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06005ED2 RID: 24274 RVA: 0x001B41A8 File Offset: 0x001B23A8
		// (set) Token: 0x06005ED3 RID: 24275 RVA: 0x0002CB91 File Offset: 0x0002AD91
		public unsafe UnityEvent onNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040CE RID: 16590
		private static readonly IntPtr NativeFieldInfoPtr_NodeLabel;

		// Token: 0x040040CF RID: 16591
		private static readonly IntPtr NativeFieldInfoPtr_onNodeDisplayed;

		// Token: 0x040040D0 RID: 16592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
