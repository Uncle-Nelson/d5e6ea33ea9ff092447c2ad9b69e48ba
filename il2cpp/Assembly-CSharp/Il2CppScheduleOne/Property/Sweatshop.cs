using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000514 RID: 1300
	public class Sweatshop : Property
	{
		// Token: 0x06007388 RID: 29576 RVA: 0x001F8610 File Offset: 0x001F6810
		// Note: this type is marked as 'beforefieldinit'.
		static Sweatshop()
		{
			Il2CppClassPointerStore<Sweatshop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Sweatshop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr);
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677818);
			Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677819);
			Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677820);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677821);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677822);
			Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677823);
			Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100677824);
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x001F86F4 File Offset: 0x001F68F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226180, XrefRangeEnd = 226184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x001F8730 File Offset: 0x001F6930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226184, XrefRangeEnd = 226281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x001F8764 File Offset: 0x001F6964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226281, XrefRangeEnd = 226285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sweatshop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x001F87A0 File Offset: 0x001F69A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x001F87DC File Offset: 0x001F69DC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x001F8818 File Offset: 0x001F6A18
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x001F8854 File Offset: 0x001F6A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x00036EC2 File Offset: 0x000350C2
		public Sweatshop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x001F8890 File Offset: 0x001F6A90
		// (set) Token: 0x06007392 RID: 29586 RVA: 0x00036ECB File Offset: 0x000350CB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x001F88B8 File Offset: 0x001F6AB8
		// (set) Token: 0x06007394 RID: 29588 RVA: 0x00036EE6 File Offset: 0x000350E6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004EDF RID: 20191
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004EE0 RID: 20192
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004EE1 RID: 20193
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004EE2 RID: 20194
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004EE3 RID: 20195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004EE4 RID: 20196
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004EE5 RID: 20197
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004EE6 RID: 20198
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004EE7 RID: 20199
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A8D RID: 2701
		[ObfuscatedName("ScheduleOne.Property.Sweatshop+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D26D RID: 53869 RVA: 0x00325808 File Offset: 0x00323A08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr);
				Sweatshop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_0");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_1");
				Sweatshop.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, "<>9__1_2");
				Sweatshop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677826);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677827);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677828);
				Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr, 100677829);
			}

			// Token: 0x0600D26E RID: 53870 RVA: 0x003258D4 File Offset: 0x00323AD4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sweatshop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D26F RID: 53871 RVA: 0x00325910 File Offset: 0x00323B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226174, XrefRangeEnd = 226175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__1_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D270 RID: 53872 RVA: 0x00325960 File Offset: 0x00323B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226175, XrefRangeEnd = 226176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__1_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D271 RID: 53873 RVA: 0x003259B0 File Offset: 0x00323BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226176, XrefRangeEnd = 226180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__1_2(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.__c.NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D272 RID: 53874 RVA: 0x00066720 File Offset: 0x00064920
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414A RID: 16714
			// (get) Token: 0x0600D273 RID: 53875 RVA: 0x00325A00 File Offset: 0x00323C00
			// (set) Token: 0x0600D274 RID: 53876 RVA: 0x00066729 File Offset: 0x00064929
			public unsafe static Sweatshop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sweatshop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414B RID: 16715
			// (get) Token: 0x0600D275 RID: 53877 RVA: 0x00325A28 File Offset: 0x00323C28
			// (set) Token: 0x0600D276 RID: 53878 RVA: 0x0006673B File Offset: 0x0006493B
			public unsafe static Func<BuildableItem, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414C RID: 16716
			// (get) Token: 0x0600D277 RID: 53879 RVA: 0x00325A50 File Offset: 0x00323C50
			// (set) Token: 0x0600D278 RID: 53880 RVA: 0x0006674D File Offset: 0x0006494D
			public unsafe static Func<BuildableItem, Pot> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414D RID: 16717
			// (get) Token: 0x0600D279 RID: 53881 RVA: 0x00325A78 File Offset: 0x00323C78
			// (set) Token: 0x0600D27A RID: 53882 RVA: 0x0006675F File Offset: 0x0006495F
			public unsafe static Predicate<Additive> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Sweatshop.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DE8 RID: 36328
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DE9 RID: 36329
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008DEA RID: 36330
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04008DEB RID: 36331
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x04008DEC RID: 36332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DED RID: 36333
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DEE RID: 36334
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DEF RID: 36335
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__1_2_Internal_Boolean_Additive_0;
		}
	}
}
