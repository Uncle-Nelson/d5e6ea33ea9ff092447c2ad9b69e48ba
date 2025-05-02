using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050A RID: 1290
	public class Bungalow : Property
	{
		// Token: 0x06007224 RID: 29220 RVA: 0x001F3504 File Offset: 0x001F1704
		// Note: this type is marked as 'beforefieldinit'.
		static Bungalow()
		{
			Il2CppClassPointerStore<Bungalow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Bungalow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow>.NativeClassPtr);
			Bungalow.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "ModelContainer");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BungalowAssembly-CSharp.dll_Excuted");
			Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677601);
			Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677602);
			Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677603);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677604);
			Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677605);
			Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677606);
			Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, 100677607);
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x001F35FC File Offset: 0x001F17FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223892, XrefRangeEnd = 223896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x001F3638 File Offset: 0x001F1838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223896, XrefRangeEnd = 224019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x001F366C File Offset: 0x001F186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224019, XrefRangeEnd = 224023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bungalow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x001F36A8 File Offset: 0x001F18A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224023, XrefRangeEnd = 224024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x001F36E4 File Offset: 0x001F18E4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x001F3720 File Offset: 0x001F1920
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x001F375C File Offset: 0x001F195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224024, XrefRangeEnd = 224025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bungalow.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x0003655F File Offset: 0x0003475F
		public Bungalow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x001F3798 File Offset: 0x001F1998
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x00036568 File Offset: 0x00034768
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x001F37C8 File Offset: 0x001F19C8
		// (set) Token: 0x06007230 RID: 29232 RVA: 0x00036587 File Offset: 0x00034787
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x001F37F0 File Offset: 0x001F19F0
		// (set) Token: 0x06007232 RID: 29234 RVA: 0x000365A2 File Offset: 0x000347A2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bungalow.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004DE1 RID: 19937
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04004DE2 RID: 19938
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004DE3 RID: 19939
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004DE4 RID: 19940
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004DE5 RID: 19941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004DE6 RID: 19942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DE7 RID: 19943
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004DE8 RID: 19944
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004DE9 RID: 19945
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004DEA RID: 19946
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A82 RID: 2690
		[ObfuscatedName("ScheduleOne.Property.Bungalow+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D200 RID: 53760 RVA: 0x003242EC File Offset: 0x003224EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bungalow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr);
				Bungalow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9");
				Bungalow.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_0");
				Bungalow.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_1");
				Bungalow.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_2");
				Bungalow.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, "<>9__2_3");
				Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677609);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677610);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677611);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677612);
				Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr, 100677613);
			}

			// Token: 0x0600D201 RID: 53761 RVA: 0x003243E0 File Offset: 0x003225E0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bungalow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D202 RID: 53762 RVA: 0x0032441C File Offset: 0x0032261C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223885, XrefRangeEnd = 223886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D203 RID: 53763 RVA: 0x0032446C File Offset: 0x0032266C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223886, XrefRangeEnd = 223887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__2_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D204 RID: 53764 RVA: 0x003244BC File Offset: 0x003226BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223887, XrefRangeEnd = 223888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_2(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D205 RID: 53765 RVA: 0x0032450C File Offset: 0x0032270C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223888, XrefRangeEnd = 223892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__2_3(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bungalow.__c.NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D206 RID: 53766 RVA: 0x00066494 File Offset: 0x00064694
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004131 RID: 16689
			// (get) Token: 0x0600D207 RID: 53767 RVA: 0x0032455C File Offset: 0x0032275C
			// (set) Token: 0x0600D208 RID: 53768 RVA: 0x0006649D File Offset: 0x0006469D
			public unsafe static Bungalow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bungalow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004132 RID: 16690
			// (get) Token: 0x0600D209 RID: 53769 RVA: 0x00324584 File Offset: 0x00322784
			// (set) Token: 0x0600D20A RID: 53770 RVA: 0x000664AF File Offset: 0x000646AF
			public unsafe static Func<BuildableItem, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004133 RID: 16691
			// (get) Token: 0x0600D20B RID: 53771 RVA: 0x003245AC File Offset: 0x003227AC
			// (set) Token: 0x0600D20C RID: 53772 RVA: 0x000664C1 File Offset: 0x000646C1
			public unsafe static Func<BuildableItem, Pot> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004134 RID: 16692
			// (get) Token: 0x0600D20D RID: 53773 RVA: 0x003245D4 File Offset: 0x003227D4
			// (set) Token: 0x0600D20E RID: 53774 RVA: 0x000664D3 File Offset: 0x000646D3
			public unsafe static Func<BuildableItem, bool> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004135 RID: 16693
			// (get) Token: 0x0600D20F RID: 53775 RVA: 0x003245FC File Offset: 0x003227FC
			// (set) Token: 0x0600D210 RID: 53776 RVA: 0x000664E5 File Offset: 0x000646E5
			public unsafe static Predicate<Additive> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bungalow.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DAB RID: 36267
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DAC RID: 36268
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008DAD RID: 36269
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04008DAE RID: 36270
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04008DAF RID: 36271
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x04008DB0 RID: 36272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB1 RID: 36273
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DB2 RID: 36274
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DB3 RID: 36275
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_2_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DB4 RID: 36276
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__2_3_Internal_Boolean_Additive_0;
		}
	}
}
