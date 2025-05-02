using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000438 RID: 1080
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x06005EAC RID: 24236 RVA: 0x001B3A8C File Offset: 0x001B1C8C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueDatabase()
		{
			Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr);
			DialogueDatabase.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "Modules");
			DialogueDatabase.NativeFieldInfoPtr_GenericEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "GenericEntries");
			DialogueDatabase.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "handler");
			DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675359);
			DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675360);
			DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675361);
			DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675362);
			DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675363);
			DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675364);
			DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675365);
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06005EAD RID: 24237 RVA: 0x001B3B84 File Offset: 0x001B1D84
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x001B3BC4 File Offset: 0x001B1DC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DialogueHandler _handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x001B3C08 File Offset: 0x001B1E08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197581, RefRangeEnd = 197584, XrefRangeStart = 197532, XrefRangeEnd = 197581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule GetModule(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x001B3C54 File Offset: 0x001B1E54
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 197601, RefRangeEnd = 197616, XrefRangeStart = 197584, XrefRangeEnd = 197601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x001B3CB4 File Offset: 0x001B1EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197625, RefRangeEnd = 197626, XrefRangeStart = 197616, XrefRangeEnd = 197625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x001B3D10 File Offset: 0x001B1F10
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 197640, RefRangeEnd = 197675, XrefRangeStart = 197626, XrefRangeEnd = 197640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x001B3D68 File Offset: 0x001B1F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197675, XrefRangeEnd = 197683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x0002CA44 File Offset: 0x0002AC44
		public DialogueDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x001B3DA4 File Offset: 0x001B1FA4
		// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x0002CA4D File Offset: 0x0002AC4D
		public unsafe List<DialogueModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x001B3DD4 File Offset: 0x001B1FD4
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		public unsafe List<Entry> GenericEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x001B3E04 File Offset: 0x001B2004
		// (set) Token: 0x06005EBA RID: 24250 RVA: 0x0002CA8B File Offset: 0x0002AC8B
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040BC RID: 16572
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x040040BD RID: 16573
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntries;

		// Token: 0x040040BE RID: 16574
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x040040BF RID: 16575
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0;

		// Token: 0x040040C0 RID: 16576
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0;

		// Token: 0x040040C1 RID: 16577
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x040040C2 RID: 16578
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0;

		// Token: 0x040040C3 RID: 16579
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0;

		// Token: 0x040040C4 RID: 16580
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0;

		// Token: 0x040040C5 RID: 16581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FD RID: 2557
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueDatabase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE41 RID: 52801 RVA: 0x00319FA8 File Offset: 0x003181A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr);
				DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, "moduleType");
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675366);
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675367);
			}

			// Token: 0x0600CE42 RID: 52802 RVA: 0x0031A010 File Offset: 0x00318210
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE43 RID: 52803 RVA: 0x0031A04C File Offset: 0x0031824C
			[CallerCount(0)]
			public unsafe bool _GetModule_b__0(DialogueModule module)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE44 RID: 52804 RVA: 0x00064569 File Offset: 0x00062769
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004032 RID: 16434
			// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0031A09C File Offset: 0x0031829C
			// (set) Token: 0x0600CE46 RID: 52806 RVA: 0x00064572 File Offset: 0x00062772
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008B42 RID: 35650
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008B43 RID: 35651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B44 RID: 35652
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
