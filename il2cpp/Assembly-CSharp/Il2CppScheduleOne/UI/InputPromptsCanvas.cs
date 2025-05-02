using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000642 RID: 1602
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x06008DF8 RID: 36344 RVA: 0x0024F2EC File Offset: 0x0024D4EC
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsCanvas()
		{
			Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "InputPromptsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr);
			InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "InputPromptsContainer");
			InputPromptsCanvas.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Modules");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModuleLabel>k__BackingField");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModule>k__BackingField");
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680925);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680926);
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680927);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680928);
			InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680929);
			InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680930);
			InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680931);
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x0024F3F8 File Offset: 0x0024D5F8
		// (set) Token: 0x06008DFA RID: 36346 RVA: 0x0024F430 File Offset: 0x0024D630
		public unsafe string currentModuleLabel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06008DFB RID: 36347 RVA: 0x0024F474 File Offset: 0x0024D674
		// (set) Token: 0x06008DFC RID: 36348 RVA: 0x0024F4B4 File Offset: 0x0024D6B4
		public unsafe RectTransform currentModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x0024F4F8 File Offset: 0x0024D6F8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 258614, RefRangeEnd = 258657, XrefRangeStart = 258579, XrefRangeEnd = 258614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x0024F53C File Offset: 0x0024D73C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 258668, RefRangeEnd = 258709, XrefRangeStart = 258657, XrefRangeEnd = 258668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x0024F570 File Offset: 0x0024D770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258709, XrefRangeEnd = 258722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x000443E7 File Offset: 0x000425E7
		public InputPromptsCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x0024F5AC File Offset: 0x0024D7AC
		// (set) Token: 0x06008E02 RID: 36354 RVA: 0x000443F0 File Offset: 0x000425F0
		public unsafe RectTransform InputPromptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x0024F5DC File Offset: 0x0024D7DC
		// (set) Token: 0x06008E04 RID: 36356 RVA: 0x0004440F File Offset: 0x0004260F
		public unsafe List<InputPromptsCanvas.Module> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsCanvas.Module>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x0024F60C File Offset: 0x0024D80C
		// (set) Token: 0x06008E06 RID: 36358 RVA: 0x0004442E File Offset: 0x0004262E
		public unsafe string _currentModuleLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x0024F634 File Offset: 0x0024D834
		// (set) Token: 0x06008E08 RID: 36360 RVA: 0x0004444D File Offset: 0x0004264D
		public unsafe RectTransform _currentModule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006023 RID: 24611
		private static readonly IntPtr NativeFieldInfoPtr_InputPromptsContainer;

		// Token: 0x04006024 RID: 24612
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04006025 RID: 24613
		private static readonly IntPtr NativeFieldInfoPtr__currentModuleLabel_k__BackingField;

		// Token: 0x04006026 RID: 24614
		private static readonly IntPtr NativeFieldInfoPtr__currentModule_k__BackingField;

		// Token: 0x04006027 RID: 24615
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0;

		// Token: 0x04006028 RID: 24616
		private static readonly IntPtr NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0;

		// Token: 0x04006029 RID: 24617
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0;

		// Token: 0x0400602A RID: 24618
		private static readonly IntPtr NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0;

		// Token: 0x0400602B RID: 24619
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_0;

		// Token: 0x0400602C RID: 24620
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_0;

		// Token: 0x0400602D RID: 24621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B2A RID: 2858
		[Serializable]
		public class Module : Il2CppSystem.Object
		{
			// Token: 0x0600D7D9 RID: 55257 RVA: 0x00334D28 File Offset: 0x00332F28
			// Note: this type is marked as 'beforefieldinit'.
			static Module()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Module");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr);
				InputPromptsCanvas.Module.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "key");
				InputPromptsCanvas.Module.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "module");
				InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, 100680932);
			}

			// Token: 0x0600D7DA RID: 55258 RVA: 0x00334D90 File Offset: 0x00332F90
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Module() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7DB RID: 55259 RVA: 0x000691B0 File Offset: 0x000673B0
			public Module(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E8 RID: 17128
			// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x00334DCC File Offset: 0x00332FCC
			// (set) Token: 0x0600D7DD RID: 55261 RVA: 0x000691B9 File Offset: 0x000673B9
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042E9 RID: 17129
			// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x00334DF4 File Offset: 0x00332FF4
			// (set) Token: 0x0600D7DF RID: 55263 RVA: 0x000691D8 File Offset: 0x000673D8
			public unsafe GameObject module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009111 RID: 37137
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009112 RID: 37138
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x04009113 RID: 37139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B2B RID: 2859
		[ObfuscatedName("ScheduleOne.UI.InputPromptsCanvas+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7E0 RID: 55264 RVA: 0x00334E24 File Offset: 0x00333024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, "key");
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100680933);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100680934);
			}

			// Token: 0x0600D7E1 RID: 55265 RVA: 0x00334E8C File Offset: 0x0033308C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E2 RID: 55266 RVA: 0x00334EC8 File Offset: 0x003330C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadModule_b__0(InputPromptsCanvas.Module x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7E3 RID: 55267 RVA: 0x000691F7 File Offset: 0x000673F7
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EA RID: 17130
			// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x00334F18 File Offset: 0x00333118
			// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x00069200 File Offset: 0x00067400
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009114 RID: 37140
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009115 RID: 37141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009116 RID: 37142
			private static readonly IntPtr NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0;
		}
	}
}
