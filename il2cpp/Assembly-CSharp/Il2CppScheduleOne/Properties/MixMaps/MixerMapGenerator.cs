using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001F5 RID: 501
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x000F0DFC File Offset: 0x000EEFFC
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapGenerator()
		{
			Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMapGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr);
			MixerMapGenerator.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapRadius");
			MixerMapGenerator.NativeFieldInfoPtr_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapName");
			MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "BasePlateMesh");
			MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "EffectPrefab");
			MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667875);
			MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667876);
			MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667877);
			MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667878);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000F0ECC File Offset: 0x000EF0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118684, XrefRangeEnd = 118690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000F0F00 File Offset: 0x000EF100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118690, XrefRangeEnd = 118728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEffectPrefabs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000F0F34 File Offset: 0x000EF134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118728, XrefRangeEnd = 118746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect GetEffect(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr3) : null;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000F0F84 File Offset: 0x000EF184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118746, XrefRangeEnd = 118751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00016125 File Offset: 0x00014325
		public MixerMapGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000F0FC0 File Offset: 0x000EF1C0
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x0001612E File Offset: 0x0001432E
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00016149 File Offset: 0x00014349
		public unsafe string MapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000F1010 File Offset: 0x000EF210
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00016168 File Offset: 0x00014368
		public unsafe Transform BasePlateMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000F1040 File Offset: 0x000EF240
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00016187 File Offset: 0x00014387
		public unsafe Effect EffectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_MapName;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_BasePlateMesh;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeFieldInfoPtr_EffectPrefab;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008DA RID: 2266
		[ObfuscatedName("ScheduleOne.Properties.MixMaps.MixerMapGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C461 RID: 50273 RVA: 0x002FD78C File Offset: 0x002FB98C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, "property");
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667879);
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667880);
			}

			// Token: 0x0600C462 RID: 50274 RVA: 0x002FD7F4 File Offset: 0x002FB9F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C463 RID: 50275 RVA: 0x002FD830 File Offset: 0x002FBA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118665, XrefRangeEnd = 118684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEffect_b__0(Effect effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C464 RID: 50276 RVA: 0x0005F923 File Offset: 0x0005DB23
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D49 RID: 15689
			// (get) Token: 0x0600C465 RID: 50277 RVA: 0x002FD880 File Offset: 0x002FBA80
			// (set) Token: 0x0600C466 RID: 50278 RVA: 0x0005F92C File Offset: 0x0005DB2C
			public unsafe Property property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008513 RID: 34067
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04008514 RID: 34068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008515 RID: 34069
			private static readonly IntPtr NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0;
		}
	}
}
