using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000592 RID: 1426
	public class StationItem : MonoBehaviour
	{
		// Token: 0x06007D88 RID: 32136 RVA: 0x0021A174 File Offset: 0x00218374
		// Note: this type is marked as 'beforefieldinit'.
		static StationItem()
		{
			Il2CppClassPointerStore<StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem>.NativeClassPtr);
			StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<ActiveModules>k__BackingField");
			StationItem.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "Modules");
			StationItem.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "TrashPrefab");
			StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678992);
			StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678993);
			StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678994);
			StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678995);
			StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678996);
			StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678997);
			StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678998);
			StationItem.NativeMethodInfoPtr_GetModule_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100678999);
			StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679000);
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06007D89 RID: 32137 RVA: 0x0021A294 File Offset: 0x00218494
		// (set) Token: 0x06007D8A RID: 32138 RVA: 0x0021A2D4 File Offset: 0x002184D4
		public unsafe List<ItemModule> ActiveModules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x0021A318 File Offset: 0x00218518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238092, XrefRangeEnd = 238097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x0021A354 File Offset: 0x00218554
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x0021A3A4 File Offset: 0x002185A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 238119, RefRangeEnd = 238127, XrefRangeStart = 238097, XrefRangeEnd = 238119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x0021A3D8 File Offset: 0x002185D8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 238132, RefRangeEnd = 238141, XrefRangeStart = 238127, XrefRangeEnd = 238132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x0021A40C File Offset: 0x0021860C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 238159, RefRangeEnd = 238171, XrefRangeStart = 238141, XrefRangeEnd = 238159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x0021A448 File Offset: 0x00218648
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 238189, RefRangeEnd = 238226, XrefRangeStart = 238171, XrefRangeEnd = 238189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_GetModule_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x0021A484 File Offset: 0x00218684
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238234, RefRangeEnd = 238239, XrefRangeStart = 238226, XrefRangeEnd = 238234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		public StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0021A4C0 File Offset: 0x002186C0
		// (set) Token: 0x06007D94 RID: 32148 RVA: 0x0003BAC9 File Offset: 0x00039CC9
		public unsafe List<ItemModule> _ActiveModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0021A4F0 File Offset: 0x002186F0
		// (set) Token: 0x06007D96 RID: 32150 RVA: 0x0003BAE8 File Offset: 0x00039CE8
		public unsafe List<ItemModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0021A520 File Offset: 0x00218720
		// (set) Token: 0x06007D98 RID: 32152 RVA: 0x0003BB07 File Offset: 0x00039D07
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005564 RID: 21860
		private static readonly IntPtr NativeFieldInfoPtr__ActiveModules_k__BackingField;

		// Token: 0x04005565 RID: 21861
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04005566 RID: 21862
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x04005567 RID: 21863
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0;

		// Token: 0x04005568 RID: 21864
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0;

		// Token: 0x04005569 RID: 21865
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400556A RID: 21866
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0;

		// Token: 0x0400556B RID: 21867
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Void_0;

		// Token: 0x0400556C RID: 21868
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400556D RID: 21869
		private static readonly IntPtr NativeMethodInfoPtr_HasModule_Public_Boolean_0;

		// Token: 0x0400556E RID: 21870
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_T_0;

		// Token: 0x0400556F RID: 21871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABC RID: 2748
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D3F7 RID: 54263 RVA: 0x00329CAC File Offset: 0x00327EAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr);
				StationItem.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9");
				StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679002);
				StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679003);
			}

			// Token: 0x0600D3F8 RID: 54264 RVA: 0x00329D64 File Offset: 0x00327F64
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3F9 RID: 54265 RVA: 0x00329DA0 File Offset: 0x00327FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238075, XrefRangeEnd = 238082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasModule_b__10_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3FA RID: 54266 RVA: 0x000672FC File Offset: 0x000654FC
			public __c__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0600D3FB RID: 54267 RVA: 0x00329DF0 File Offset: 0x00327FF0
			// (set) Token: 0x0600D3FC RID: 54268 RVA: 0x00067305 File Offset: 0x00065505
			public unsafe static StationItem.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BA RID: 16826
			// (get) Token: 0x0600D3FD RID: 54269 RVA: 0x00329E18 File Offset: 0x00328018
			// (set) Token: 0x0600D3FE RID: 54270 RVA: 0x00067317 File Offset: 0x00065517
			public unsafe static Predicate<ItemModule> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EC1 RID: 36545
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EC2 RID: 36546
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04008EC3 RID: 36547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC4 RID: 36548
			private static readonly IntPtr NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000ABD RID: 2749
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D3FF RID: 54271 RVA: 0x00329E40 File Offset: 0x00328040
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr);
				StationItem.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9");
				StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679005);
				StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679006);
			}

			// Token: 0x0600D400 RID: 54272 RVA: 0x00329EF8 File Offset: 0x003280F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D401 RID: 54273 RVA: 0x00329F34 File Offset: 0x00328134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238082, XrefRangeEnd = 238092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetModule_b__11_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D402 RID: 54274 RVA: 0x00067329 File Offset: 0x00065529
			public __c__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BB RID: 16827
			// (get) Token: 0x0600D403 RID: 54275 RVA: 0x00329F84 File Offset: 0x00328184
			// (set) Token: 0x0600D404 RID: 54276 RVA: 0x00067332 File Offset: 0x00065532
			public unsafe static StationItem.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BC RID: 16828
			// (get) Token: 0x0600D405 RID: 54277 RVA: 0x00329FAC File Offset: 0x003281AC
			// (set) Token: 0x0600D406 RID: 54278 RVA: 0x00067344 File Offset: 0x00065544
			public unsafe static Predicate<ItemModule> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EC5 RID: 36549
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EC6 RID: 36550
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008EC7 RID: 36551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC8 RID: 36552
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000ABE RID: 2750
		private sealed class MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>
		{
			// Token: 0x04008EC9 RID: 36553
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000ABF RID: 2751
		private sealed class MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>
		{
			// Token: 0x04008ECA RID: 36554
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AC0 RID: 2752
		private sealed class MethodInfoStoreGeneric_GetModule_Public_T_0<T>
		{
			// Token: 0x04008ECB RID: 36555
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_GetModule_Public_T_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
