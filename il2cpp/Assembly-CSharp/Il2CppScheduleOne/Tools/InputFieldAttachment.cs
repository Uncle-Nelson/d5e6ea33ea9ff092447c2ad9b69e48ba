using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052A RID: 1322
	public class InputFieldAttachment : MonoBehaviour
	{
		// Token: 0x0600763D RID: 30269 RVA: 0x00202A54 File Offset: 0x00200C54
		// Note: this type is marked as 'beforefieldinit'.
		static InputFieldAttachment()
		{
			Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "InputFieldAttachment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr);
			InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678192);
			InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678193);
			InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678194);
			InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678195);
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00202AD4 File Offset: 0x00200CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230823, XrefRangeEnd = 230887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00202B08 File Offset: 0x00200D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230887, XrefRangeEnd = 230891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00202B4C File Offset: 0x00200D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230891, XrefRangeEnd = 230895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00202B90 File Offset: 0x00200D90
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputFieldAttachment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00038080 File Offset: 0x00036280
		public InputFieldAttachment(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050CC RID: 20684
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050CD RID: 20685
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x040050CE RID: 20686
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x040050CF RID: 20687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A97 RID: 2711
		[ObfuscatedName("ScheduleOne.Tools.InputFieldAttachment+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2C5 RID: 53957 RVA: 0x00326758 File Offset: 0x00324958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr);
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "inputField");
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678196);
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678197);
			}

			// Token: 0x0600D2C6 RID: 53958 RVA: 0x003267D4 File Offset: 0x003249D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2C7 RID: 53959 RVA: 0x00326810 File Offset: 0x00324A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230819, XrefRangeEnd = 230823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2C8 RID: 53960 RVA: 0x000669A4 File Offset: 0x00064BA4
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004162 RID: 16738
			// (get) Token: 0x0600D2C9 RID: 53961 RVA: 0x00326854 File Offset: 0x00324A54
			// (set) Token: 0x0600D2CA RID: 53962 RVA: 0x000669AD File Offset: 0x00064BAD
			public unsafe InputFieldAttachment __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputFieldAttachment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004163 RID: 16739
			// (get) Token: 0x0600D2CB RID: 53963 RVA: 0x00326884 File Offset: 0x00324A84
			// (set) Token: 0x0600D2CC RID: 53964 RVA: 0x000669CC File Offset: 0x00064BCC
			public unsafe InputField inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E16 RID: 36374
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E17 RID: 36375
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04008E18 RID: 36376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E19 RID: 36377
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
