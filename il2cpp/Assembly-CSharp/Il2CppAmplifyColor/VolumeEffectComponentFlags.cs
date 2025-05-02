using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079C RID: 1948
	[Serializable]
	public class VolumeEffectComponentFlags : Il2CppSystem.Object
	{
		// Token: 0x0600B840 RID: 47168 RVA: 0x002DB850 File Offset: 0x002D9A50
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectComponentFlags()
		{
			Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectComponentFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr);
			VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "componentName");
			VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "componentFields");
			VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "blendFlag");
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685938);
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685939);
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685940);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685941);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685942);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685943);
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x002DB934 File Offset: 0x002D9B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313823, RefRangeEnd = 313825, XrefRangeStart = 313814, XrefRangeEnd = 313823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x002DB980 File Offset: 0x002D9B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313850, RefRangeEnd = 313851, XrefRangeStart = 313825, XrefRangeEnd = 313850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(VolumeEffectComponent comp) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B843 RID: 47171 RVA: 0x002DB9CC File Offset: 0x002D9BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313866, RefRangeEnd = 313867, XrefRangeStart = 313851, XrefRangeEnd = 313866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(Component c) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x002DBA18 File Offset: 0x002D9C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313905, RefRangeEnd = 313906, XrefRangeStart = 313867, XrefRangeEnd = 313905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponentFlags(VolumeEffectComponent comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x002DBA5C File Offset: 0x002D9C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313906, XrefRangeEnd = 313931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponentFlags(Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x002DBAA0 File Offset: 0x002D9CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313931, XrefRangeEnd = 313969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetFieldNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x0005A717 File Offset: 0x00058917
		public VolumeEffectComponentFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x002DBAE0 File Offset: 0x002D9CE0
		// (set) Token: 0x0600B849 RID: 47177 RVA: 0x0005A720 File Offset: 0x00058920
		public unsafe string componentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x002DBB08 File Offset: 0x002D9D08
		// (set) Token: 0x0600B84B RID: 47179 RVA: 0x0005A73F File Offset: 0x0005893F
		public unsafe List<VolumeEffectFieldFlags> componentFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectFieldFlags>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600B84C RID: 47180 RVA: 0x002DBB38 File Offset: 0x002D9D38
		// (set) Token: 0x0600B84D RID: 47181 RVA: 0x0005A75E File Offset: 0x0005895E
		public unsafe bool blendFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag)) = value;
			}
		}

		// Token: 0x04007C24 RID: 31780
		private static readonly IntPtr NativeFieldInfoPtr_componentName;

		// Token: 0x04007C25 RID: 31781
		private static readonly IntPtr NativeFieldInfoPtr_componentFields;

		// Token: 0x04007C26 RID: 31782
		private static readonly IntPtr NativeFieldInfoPtr_blendFlag;

		// Token: 0x04007C27 RID: 31783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04007C28 RID: 31784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C29 RID: 31785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Component_0;

		// Token: 0x04007C2A RID: 31786
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C2B RID: 31787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0;

		// Token: 0x04007C2C RID: 31788
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C10 RID: 3088
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E07A RID: 57466 RVA: 0x0034D908 File Offset: 0x0034BB08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr);
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9");
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9__8_0");
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9__8_1");
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685945);
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685946);
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685947);
			}

			// Token: 0x0600E07B RID: 57467 RVA: 0x0034D9AC File Offset: 0x0034BBAC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E07C RID: 57468 RVA: 0x0034D9E8 File Offset: 0x0034BBE8
			[CallerCount(0)]
			public unsafe bool _GetFieldNames_b__8_0(VolumeEffectFieldFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E07D RID: 57469 RVA: 0x0034DA38 File Offset: 0x0034BC38
			[CallerCount(0)]
			public unsafe string _GetFieldNames_b__8_1(VolumeEffectFieldFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E07E RID: 57470 RVA: 0x0006D69A File Offset: 0x0006B89A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458C RID: 17804
			// (get) Token: 0x0600E07F RID: 57471 RVA: 0x0034DA80 File Offset: 0x0034BC80
			// (set) Token: 0x0600E080 RID: 57472 RVA: 0x0006D6A3 File Offset: 0x0006B8A3
			public unsafe static VolumeEffectComponentFlags.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponentFlags.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458D RID: 17805
			// (get) Token: 0x0600E081 RID: 57473 RVA: 0x0034DAA8 File Offset: 0x0034BCA8
			// (set) Token: 0x0600E082 RID: 57474 RVA: 0x0006D6B5 File Offset: 0x0006B8B5
			public unsafe static Func<VolumeEffectFieldFlags, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectFieldFlags, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458E RID: 17806
			// (get) Token: 0x0600E083 RID: 57475 RVA: 0x0034DAD0 File Offset: 0x0034BCD0
			// (set) Token: 0x0600E084 RID: 57476 RVA: 0x0006D6C7 File Offset: 0x0006B8C7
			public unsafe static Func<VolumeEffectFieldFlags, string> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectFieldFlags, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400965C RID: 38492
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400965D RID: 38493
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400965E RID: 38494
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400965F RID: 38495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009660 RID: 38496
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0;

			// Token: 0x04009661 RID: 38497
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0;
		}

		// Token: 0x02000C11 RID: 3089
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E085 RID: 57477 RVA: 0x0034DAF8 File Offset: 0x0034BCF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr);
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, "field");
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, 100685948);
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, 100685949);
			}

			// Token: 0x0600E086 RID: 57478 RVA: 0x0034DB60 File Offset: 0x0034BD60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E087 RID: 57479 RVA: 0x0034DB9C File Offset: 0x0034BD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponentFlags_b__0(VolumeEffectFieldFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E088 RID: 57480 RVA: 0x0006D6D9 File Offset: 0x0006B8D9
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458F RID: 17807
			// (get) Token: 0x0600E089 RID: 57481 RVA: 0x0034DBEC File Offset: 0x0034BDEC
			// (set) Token: 0x0600E08A RID: 57482 RVA: 0x0006D6E2 File Offset: 0x0006B8E2
			public unsafe VolumeEffectField field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009662 RID: 38498
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x04009663 RID: 38499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009664 RID: 38500
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0;
		}

		// Token: 0x02000C12 RID: 3090
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E08B RID: 57483 RVA: 0x0034DC1C File Offset: 0x0034BE1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr);
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, "pi");
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, 100685950);
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, 100685951);
			}

			// Token: 0x0600E08C RID: 57484 RVA: 0x0034DC84 File Offset: 0x0034BE84
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E08D RID: 57485 RVA: 0x0034DCC0 File Offset: 0x0034BEC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313742, XrefRangeEnd = 313814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponentFlags_b__0(VolumeEffectFieldFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E08E RID: 57486 RVA: 0x0006D701 File Offset: 0x0006B901
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004590 RID: 17808
			// (get) Token: 0x0600E08F RID: 57487 RVA: 0x0034DD10 File Offset: 0x0034BF10
			// (set) Token: 0x0600E090 RID: 57488 RVA: 0x0006D70A File Offset: 0x0006B90A
			public unsafe FieldInfo pi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009665 RID: 38501
			private static readonly IntPtr NativeFieldInfoPtr_pi;

			// Token: 0x04009666 RID: 38502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009667 RID: 38503
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0;
		}
	}
}
