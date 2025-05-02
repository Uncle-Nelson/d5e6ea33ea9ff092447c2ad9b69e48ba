using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000441 RID: 1089
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x06005F54 RID: 24404 RVA: 0x001B6148 File Offset: 0x001B4348
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueManager()
		{
			Il2CppClassPointerStore<DialogueManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr);
			DialogueManager.NativeFieldInfoPtr_DefaultDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultDatabase");
			DialogueManager.NativeFieldInfoPtr_DefaultModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultModules");
			DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675463);
			DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675464);
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x001B61C8 File Offset: 0x001B43C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198522, XrefRangeEnd = 198549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule Get(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x001B6214 File Offset: 0x001B4414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198549, XrefRangeEnd = 198559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x0002CF21 File Offset: 0x0002B121
		public DialogueManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x001B6250 File Offset: 0x001B4450
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x0002CF2A File Offset: 0x0002B12A
		public unsafe DialogueDatabase DefaultDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x001B6280 File Offset: 0x001B4480
		// (set) Token: 0x06005F5B RID: 24411 RVA: 0x0002CF49 File Offset: 0x0002B149
		public unsafe List<DialogueModule> DefaultModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400412B RID: 16683
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDatabase;

		// Token: 0x0400412C RID: 16684
		private static readonly IntPtr NativeFieldInfoPtr_DefaultModules;

		// Token: 0x0400412D RID: 16685
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x0400412E RID: 16686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A07 RID: 2567
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CE88 RID: 52872 RVA: 0x0031AD54 File Offset: 0x00318F54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, "moduleType");
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675465);
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675466);
			}

			// Token: 0x0600CE89 RID: 52873 RVA: 0x0031ADBC File Offset: 0x00318FBC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE8A RID: 52874 RVA: 0x0031ADF8 File Offset: 0x00318FF8
			[CallerCount(0)]
			public unsafe bool _Get_b__0(DialogueModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE8B RID: 52875 RVA: 0x00064752 File Offset: 0x00062952
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403F RID: 16447
			// (get) Token: 0x0600CE8C RID: 52876 RVA: 0x0031AE48 File Offset: 0x00319048
			// (set) Token: 0x0600CE8D RID: 52877 RVA: 0x0006475B File Offset: 0x0006295B
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008B68 RID: 35688
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008B69 RID: 35689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B6A RID: 35690
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
