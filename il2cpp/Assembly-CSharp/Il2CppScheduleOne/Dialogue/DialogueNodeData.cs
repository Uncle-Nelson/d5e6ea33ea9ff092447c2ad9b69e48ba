using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000448 RID: 1096
	[Serializable]
	public class DialogueNodeData : Il2CppSystem.Object
	{
		// Token: 0x06005F94 RID: 24468 RVA: 0x001B6D5C File Offset: 0x001B4F5C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeData()
		{
			Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr);
			DialogueNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Guid");
			DialogueNodeData.NativeFieldInfoPtr_DialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueText");
			DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "DialogueNodeLabel");
			DialogueNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "Position");
			DialogueNodeData.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "choices");
			DialogueNodeData.NativeFieldInfoPtr_VoiceLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, "VoiceLine");
			DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675497);
			DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr, 100675498);
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x001B6E2C File Offset: 0x001B502C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198740, XrefRangeEnd = 198749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x001B6E6C File Offset: 0x001B506C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x0002D13B File Offset: 0x0002B33B
		public DialogueNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x001B6EA8 File Offset: 0x001B50A8
		// (set) Token: 0x06005F99 RID: 24473 RVA: 0x0002D144 File Offset: 0x0002B344
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06005F9A RID: 24474 RVA: 0x001B6ED0 File Offset: 0x001B50D0
		// (set) Token: 0x06005F9B RID: 24475 RVA: 0x0002D163 File Offset: 0x0002B363
		public unsafe string DialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x001B6EF8 File Offset: 0x001B50F8
		// (set) Token: 0x06005F9D RID: 24477 RVA: 0x0002D182 File Offset: 0x0002B382
		public unsafe string DialogueNodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_DialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x001B6F20 File Offset: 0x001B5120
		// (set) Token: 0x06005F9F RID: 24479 RVA: 0x0002D1A1 File Offset: 0x0002B3A1
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x001B6F48 File Offset: 0x001B5148
		// (set) Token: 0x06005FA1 RID: 24481 RVA: 0x0002D1BC File Offset: 0x0002B3BC
		public unsafe Il2CppReferenceArray<DialogueChoiceData> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x001B6F78 File Offset: 0x001B5178
		// (set) Token: 0x06005FA3 RID: 24483 RVA: 0x0002D1DB File Offset: 0x0002B3DB
		public unsafe EVOLineType VoiceLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeData.NativeFieldInfoPtr_VoiceLine)) = value;
			}
		}

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeFieldInfoPtr_DialogueText;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeLabel;

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeFieldInfoPtr_VoiceLine;

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_DialogueNodeData_0;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
