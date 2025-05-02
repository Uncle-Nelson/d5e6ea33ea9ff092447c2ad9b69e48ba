using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079A RID: 1946
	[Serializable]
	public class VolumeEffectContainer : Object
	{
		// Token: 0x0600B82C RID: 47148 RVA: 0x002DB41C File Offset: 0x002D961C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectContainer()
		{
			Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr);
			VolumeEffectContainer.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, "volumes");
			VolumeEffectContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685927);
			VolumeEffectContainer.NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685928);
			VolumeEffectContainer.NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685929);
			VolumeEffectContainer.NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685930);
			VolumeEffectContainer.NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685931);
			VolumeEffectContainer.NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685932);
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x002DB4D8 File Offset: 0x002D96D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313675, RefRangeEnd = 313676, XrefRangeStart = 313667, XrefRangeEnd = 313675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x002DB514 File Offset: 0x002D9714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313676, XrefRangeEnd = 313687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColorEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x002DB558 File Offset: 0x002D9758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313687, XrefRangeEnd = 313694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect AddJustColorEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x002DB5A8 File Offset: 0x002D97A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313705, RefRangeEnd = 313708, XrefRangeStart = 313694, XrefRangeEnd = 313705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect FindVolumeEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x002DB5F8 File Offset: 0x002D97F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313708, XrefRangeEnd = 313712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveVolumeEffect(VolumeEffect volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x002DB63C File Offset: 0x002D983C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313712, XrefRangeEnd = 313733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<AmplifyColorEffect> GetStoredEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AmplifyColorEffect>>(intPtr3) : null;
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x0005A68D File Offset: 0x0005888D
		public VolumeEffectContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x002DB67C File Offset: 0x002D987C
		// (set) Token: 0x0600B835 RID: 47157 RVA: 0x0005A696 File Offset: 0x00058896
		public unsafe List<VolumeEffect> volumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectContainer.NativeFieldInfoPtr_volumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectContainer.NativeFieldInfoPtr_volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C18 RID: 31768
		private static readonly IntPtr NativeFieldInfoPtr_volumes;

		// Token: 0x04007C19 RID: 31769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007C1A RID: 31770
		private static readonly IntPtr NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007C1B RID: 31771
		private static readonly IntPtr NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C1C RID: 31772
		private static readonly IntPtr NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C1D RID: 31773
		private static readonly IntPtr NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0;

		// Token: 0x04007C1E RID: 31774
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0;

		// Token: 0x02000C0F RID: 3087
		[ObfuscatedName("AmplifyColor.VolumeEffectContainer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E072 RID: 57458 RVA: 0x0034D7B0 File Offset: 0x0034B9B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr);
				VolumeEffectContainer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, "<>9");
				VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, "<>9__6_0");
				VolumeEffectContainer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, 100685934);
				VolumeEffectContainer.__c.NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, 100685935);
			}

			// Token: 0x0600E073 RID: 57459 RVA: 0x0034D82C File Offset: 0x0034BA2C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E074 RID: 57460 RVA: 0x0034D868 File Offset: 0x0034BA68
			[CallerCount(0)]
			public unsafe AmplifyColorEffect _GetStoredEffects_b__6_0(VolumeEffect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.__c.NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr3) : null;
			}

			// Token: 0x0600E075 RID: 57461 RVA: 0x0006D66D File Offset: 0x0006B86D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458A RID: 17802
			// (get) Token: 0x0600E076 RID: 57462 RVA: 0x0034D8B8 File Offset: 0x0034BAB8
			// (set) Token: 0x0600E077 RID: 57463 RVA: 0x0006D676 File Offset: 0x0006B876
			public unsafe static VolumeEffectContainer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectContainer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458B RID: 17803
			// (get) Token: 0x0600E078 RID: 57464 RVA: 0x0034D8E0 File Offset: 0x0034BAE0
			// (set) Token: 0x0600E079 RID: 57465 RVA: 0x0006D688 File Offset: 0x0006B888
			public unsafe static Func<VolumeEffect, AmplifyColorEffect> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffect, AmplifyColorEffect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009658 RID: 38488
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009659 RID: 38489
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400965A RID: 38490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400965B RID: 38491
			private static readonly IntPtr NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0;
		}
	}
}
