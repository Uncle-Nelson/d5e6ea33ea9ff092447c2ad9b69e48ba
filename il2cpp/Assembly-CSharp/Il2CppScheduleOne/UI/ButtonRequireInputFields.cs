using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066A RID: 1642
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x060092B6 RID: 37558 RVA: 0x0025D388 File Offset: 0x0025B588
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonRequireInputFields()
		{
			Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonRequireInputFields");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr);
			ButtonRequireInputFields.NativeFieldInfoPtr_Inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Inputs");
			ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Dropdown");
			ButtonRequireInputFields.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Button");
			ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681507);
			ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100681508);
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x0025D41C File Offset: 0x0025B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265090, XrefRangeEnd = 265117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x0025D450 File Offset: 0x0025B650
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonRequireInputFields() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00047027 File Offset: 0x00045227
		public ButtonRequireInputFields(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x060092BA RID: 37562 RVA: 0x0025D48C File Offset: 0x0025B68C
		// (set) Token: 0x060092BB RID: 37563 RVA: 0x00047030 File Offset: 0x00045230
		public unsafe List<ButtonRequireInputFields.Input> Inputs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ButtonRequireInputFields.Input>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x0025D4BC File Offset: 0x0025B6BC
		// (set) Token: 0x060092BD RID: 37565 RVA: 0x0004704F File Offset: 0x0004524F
		public unsafe TMP_Dropdown Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x0025D4EC File Offset: 0x0025B6EC
		// (set) Token: 0x060092BF RID: 37567 RVA: 0x0004706E File Offset: 0x0004526E
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400631B RID: 25371
		private static readonly IntPtr NativeFieldInfoPtr_Inputs;

		// Token: 0x0400631C RID: 25372
		private static readonly IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x0400631D RID: 25373
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x0400631E RID: 25374
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400631F RID: 25375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B51 RID: 2897
		[Serializable]
		public class Input : Il2CppSystem.Object
		{
			// Token: 0x0600D9BA RID: 55738 RVA: 0x0033A564 File Offset: 0x00338764
			// Note: this type is marked as 'beforefieldinit'.
			static Input()
			{
				Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr);
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "InputField");
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "ErrorMessage");
				ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, 100681509);
			}

			// Token: 0x0600D9BB RID: 55739 RVA: 0x0033A5CC File Offset: 0x003387CC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Input() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9BC RID: 55740 RVA: 0x0006A0B9 File Offset: 0x000682B9
			public Input(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600D9BD RID: 55741 RVA: 0x0033A608 File Offset: 0x00338808
			// (set) Token: 0x0600D9BE RID: 55742 RVA: 0x0006A0C2 File Offset: 0x000682C2
			public unsafe TMP_InputField InputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438F RID: 17295
			// (get) Token: 0x0600D9BF RID: 55743 RVA: 0x0033A638 File Offset: 0x00338838
			// (set) Token: 0x0600D9C0 RID: 55744 RVA: 0x0006A0E1 File Offset: 0x000682E1
			public unsafe RectTransform ErrorMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400923C RID: 37436
			private static readonly IntPtr NativeFieldInfoPtr_InputField;

			// Token: 0x0400923D RID: 37437
			private static readonly IntPtr NativeFieldInfoPtr_ErrorMessage;

			// Token: 0x0400923E RID: 37438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
