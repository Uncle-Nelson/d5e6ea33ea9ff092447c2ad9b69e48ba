using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079D RID: 1949
	[Serializable]
	public class VolumeEffectFlags : Il2CppSystem.Object
	{
		// Token: 0x0600B84E RID: 47182 RVA: 0x002DBB60 File Offset: 0x002D9D60
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectFlags()
		{
			Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr);
			VolumeEffectFlags.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "components");
			VolumeEffectFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685952);
			VolumeEffectFlags.NativeMethodInfoPtr_AddComponent_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685953);
			VolumeEffectFlags.NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685954);
			VolumeEffectFlags.NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685955);
			VolumeEffectFlags.NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685956);
			VolumeEffectFlags.NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685957);
			VolumeEffectFlags.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685958);
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x002DBC30 File Offset: 0x002D9E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313982, RefRangeEnd = 313983, XrefRangeStart = 313974, XrefRangeEnd = 313982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x002DBC6C File Offset: 0x002D9E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313983, XrefRangeEnd = 314004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddComponent(Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_AddComponent_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B851 RID: 47185 RVA: 0x002DBCB0 File Offset: 0x002D9EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314041, RefRangeEnd = 314042, XrefRangeStart = 314004, XrefRangeEnd = 314041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFlags(VolumeEffect effectVol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effectVol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x002DBCF4 File Offset: 0x002D9EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314042, XrefRangeEnd = 314058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCamFlags(Il2CppReferenceArray<AmplifyColorEffect> effects, Il2CppReferenceArray<AmplifyColorVolumeBase> volumes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volumes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x002DBD3C File Offset: 0x002D9F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314082, RefRangeEnd = 314083, XrefRangeStart = 314058, XrefRangeEnd = 314082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect GenerateEffectData(AmplifyColorEffect go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x002DBD8C File Offset: 0x002D9F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314083, XrefRangeEnd = 314091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags FindComponentFlags(string compName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponentFlags>(intPtr3) : null;
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x002DBDDC File Offset: 0x002D9FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314091, XrefRangeEnd = 314129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetComponentNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x0005A779 File Offset: 0x00058979
		public VolumeEffectFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x002DBE1C File Offset: 0x002DA01C
		// (set) Token: 0x0600B858 RID: 47192 RVA: 0x0005A782 File Offset: 0x00058982
		public unsafe List<VolumeEffectComponentFlags> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectComponentFlags>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C2D RID: 31789
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04007C2E RID: 31790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007C2F RID: 31791
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Void_Component_0;

		// Token: 0x04007C30 RID: 31792
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0;

		// Token: 0x04007C31 RID: 31793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0;

		// Token: 0x04007C32 RID: 31794
		private static readonly IntPtr NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C33 RID: 31795
		private static readonly IntPtr NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0;

		// Token: 0x04007C34 RID: 31796
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C13 RID: 3091
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E091 RID: 57489 RVA: 0x0034DD40 File Offset: 0x0034BF40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr);
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9");
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9__7_0");
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9__7_1");
				VolumeEffectFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685960);
				VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685961);
				VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685962);
			}

			// Token: 0x0600E092 RID: 57490 RVA: 0x0034DDE4 File Offset: 0x0034BFE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E093 RID: 57491 RVA: 0x0034DE20 File Offset: 0x0034C020
			[CallerCount(0)]
			public unsafe bool _GetComponentNames_b__7_0(VolumeEffectComponentFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E094 RID: 57492 RVA: 0x0034DE70 File Offset: 0x0034C070
			[CallerCount(0)]
			public unsafe string _GetComponentNames_b__7_1(VolumeEffectComponentFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E095 RID: 57493 RVA: 0x0006D729 File Offset: 0x0006B929
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004591 RID: 17809
			// (get) Token: 0x0600E096 RID: 57494 RVA: 0x0034DEB8 File Offset: 0x0034C0B8
			// (set) Token: 0x0600E097 RID: 57495 RVA: 0x0006D732 File Offset: 0x0006B932
			public unsafe static VolumeEffectFlags.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectFlags.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004592 RID: 17810
			// (get) Token: 0x0600E098 RID: 57496 RVA: 0x0034DEE0 File Offset: 0x0034C0E0
			// (set) Token: 0x0600E099 RID: 57497 RVA: 0x0006D744 File Offset: 0x0006B944
			public unsafe static Func<VolumeEffectComponentFlags, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponentFlags, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004593 RID: 17811
			// (get) Token: 0x0600E09A RID: 57498 RVA: 0x0034DF08 File Offset: 0x0034C108
			// (set) Token: 0x0600E09B RID: 57499 RVA: 0x0006D756 File Offset: 0x0006B956
			public unsafe static Func<VolumeEffectComponentFlags, string> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponentFlags, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009668 RID: 38504
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009669 RID: 38505
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400966A RID: 38506
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x0400966B RID: 38507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400966C RID: 38508
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0;

			// Token: 0x0400966D RID: 38509
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0;
		}

		// Token: 0x02000C14 RID: 3092
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E09C RID: 57500 RVA: 0x0034DF30 File Offset: 0x0034C130
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr);
				VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, 100685963);
				VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, 100685964);
			}

			// Token: 0x0600E09D RID: 57501 RVA: 0x0034DF98 File Offset: 0x0034C198
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E09E RID: 57502 RVA: 0x0034DFD4 File Offset: 0x0034C1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313969, XrefRangeEnd = 313974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddComponent_b__0(VolumeEffectComponentFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E09F RID: 57503 RVA: 0x0006D768 File Offset: 0x0006B968
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004594 RID: 17812
			// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x0034E024 File Offset: 0x0034C224
			// (set) Token: 0x0600E0A1 RID: 57505 RVA: 0x0006D771 File Offset: 0x0006B971
			public unsafe Component c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400966E RID: 38510
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x0400966F RID: 38511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009670 RID: 38512
			private static readonly IntPtr NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0;
		}

		// Token: 0x02000C15 RID: 3093
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0A2 RID: 57506 RVA: 0x0034E054 File Offset: 0x0034C254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr);
				VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, "comp");
				VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, 100685965);
				VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, 100685966);
			}

			// Token: 0x0600E0A3 RID: 57507 RVA: 0x0034E0BC File Offset: 0x0034C2BC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0A4 RID: 57508 RVA: 0x0034E0F8 File Offset: 0x0034C2F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateFlags_b__0(VolumeEffectComponentFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E0A5 RID: 57509 RVA: 0x0006D790 File Offset: 0x0006B990
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004595 RID: 17813
			// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x0034E148 File Offset: 0x0034C348
			// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x0006D799 File Offset: 0x0006B999
			public unsafe VolumeEffectComponent comp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009671 RID: 38513
			private static readonly IntPtr NativeFieldInfoPtr_comp;

			// Token: 0x04009672 RID: 38514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009673 RID: 38515
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0;
		}
	}
}
