using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000442 RID: 1090
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x06005F5C RID: 24412 RVA: 0x001B62B0 File Offset: 0x001B44B0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueModule()
		{
			Il2CppClassPointerStore<DialogueModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr);
			DialogueModule.NativeFieldInfoPtr_ModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "ModuleType");
			DialogueModule.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "Entries");
			DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675467);
			DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675468);
			DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675469);
			DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675470);
			DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675471);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x001B636C File Offset: 0x001B456C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 198574, RefRangeEnd = 198580, XrefRangeStart = 198560, XrefRangeEnd = 198574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Entry(pointer);
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x001B63B4 File Offset: 0x001B45B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198580, XrefRangeEnd = 198589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x001B6404 File Offset: 0x001B4604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198589, XrefRangeEnd = 198590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x001B6454 File Offset: 0x001B4654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198590, XrefRangeEnd = 198595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x001B649C File Offset: 0x001B469C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198595, XrefRangeEnd = 198603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x0002CF68 File Offset: 0x0002B168
		public DialogueModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06005F63 RID: 24419 RVA: 0x001B64D8 File Offset: 0x001B46D8
		// (set) Token: 0x06005F64 RID: 24420 RVA: 0x0002CF71 File Offset: 0x0002B171
		public unsafe EDialogueModule ModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType)) = value;
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06005F65 RID: 24421 RVA: 0x001B6500 File Offset: 0x001B4700
		// (set) Token: 0x06005F66 RID: 24422 RVA: 0x0002CF8C File Offset: 0x0002B18C
		public unsafe List<Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400412F RID: 16687
		private static readonly IntPtr NativeFieldInfoPtr_ModuleType;

		// Token: 0x04004130 RID: 16688
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004131 RID: 16689
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_String_0;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_String_0;

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A08 RID: 2568
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueModule+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE8E RID: 52878 RVA: 0x0031AE70 File Offset: 0x00319070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, "key");
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675472);
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675473);
			}

			// Token: 0x0600CE8F RID: 52879 RVA: 0x0031AED8 File Offset: 0x003190D8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE90 RID: 52880 RVA: 0x0031AF14 File Offset: 0x00319114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198559, XrefRangeEnd = 198560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEntry_b__0(Entry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE91 RID: 52881 RVA: 0x00064776 File Offset: 0x00062976
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004040 RID: 16448
			// (get) Token: 0x0600CE92 RID: 52882 RVA: 0x0031AF68 File Offset: 0x00319168
			// (set) Token: 0x0600CE93 RID: 52883 RVA: 0x0006477F File Offset: 0x0006297F
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B6B RID: 35691
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008B6C RID: 35692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B6D RID: 35693
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0;
		}
	}
}
