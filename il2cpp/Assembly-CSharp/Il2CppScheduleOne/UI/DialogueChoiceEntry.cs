using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000635 RID: 1589
	[Serializable]
	public class DialogueChoiceEntry : Il2CppSystem.Object
	{
		// Token: 0x06008C6B RID: 35947 RVA: 0x0024AA04 File Offset: 0x00248C04
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceEntry()
		{
			Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueChoiceEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr);
			DialogueChoiceEntry.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "gameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "text");
			DialogueChoiceEntry.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "button");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleGameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleText");
			DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "canvasGroup");
			DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100680734);
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x0024AAC0 File Offset: 0x00248CC0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00043512 File Offset: 0x00041712
		public DialogueChoiceEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x0024AAFC File Offset: 0x00248CFC
		// (set) Token: 0x06008C6F RID: 35951 RVA: 0x0004351B File Offset: 0x0004171B
		public unsafe GameObject gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x0024AB2C File Offset: 0x00248D2C
		// (set) Token: 0x06008C71 RID: 35953 RVA: 0x0004353A File Offset: 0x0004173A
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x0024AB5C File Offset: 0x00248D5C
		// (set) Token: 0x06008C73 RID: 35955 RVA: 0x00043559 File Offset: 0x00041759
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x0024AB8C File Offset: 0x00248D8C
		// (set) Token: 0x06008C75 RID: 35957 RVA: 0x00043578 File Offset: 0x00041778
		public unsafe GameObject notPossibleGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x0024ABBC File Offset: 0x00248DBC
		// (set) Token: 0x06008C77 RID: 35959 RVA: 0x00043597 File Offset: 0x00041797
		public unsafe TextMeshProUGUI notPossibleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x0024ABEC File Offset: 0x00248DEC
		// (set) Token: 0x06008C79 RID: 35961 RVA: 0x000435B6 File Offset: 0x000417B6
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F2E RID: 24366
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x04005F2F RID: 24367
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04005F30 RID: 24368
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04005F31 RID: 24369
		private static readonly IntPtr NativeFieldInfoPtr_notPossibleGameObject;

		// Token: 0x04005F32 RID: 24370
		private static readonly IntPtr NativeFieldInfoPtr_notPossibleText;

		// Token: 0x04005F33 RID: 24371
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x04005F34 RID: 24372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
