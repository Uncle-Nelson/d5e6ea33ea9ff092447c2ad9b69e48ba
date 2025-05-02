using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007F RID: 127
	public class EffectAbstractBase : MonoBehaviour
	{
		// Token: 0x0600093B RID: 2363 RVA: 0x0008CD88 File Offset: 0x0008AF88
		// Note: this type is marked as 'beforefieldinit'.
		static EffectAbstractBase()
		{
			Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr);
			EffectAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "ClassName");
			EffectAbstractBase.NativeFieldInfoPtr_componentsToChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "componentsToChange");
			EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "restoreIntensityOnDisable");
			EffectAbstractBase.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Beam");
			EffectAbstractBase.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Light");
			EffectAbstractBase.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Particles");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamInside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamOutside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityLight");
			EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664280);
			EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664281);
			EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664282);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664283);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664284);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664285);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664286);
			EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664287);
			EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664288);
			EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664289);
			EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664290);
			EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100664291);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0008CF5C File Offset: 0x0008B15C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0008CF98 File Offset: 0x0008B198
		public unsafe bool restoreBaseIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0008CFD8 File Offset: 0x0008B1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80049, XrefRangeEnd = 80053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitFrom(EffectAbstractBase Source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0008D028 File Offset: 0x0008B228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80053, XrefRangeEnd = 80057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamSD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0008D06C File Offset: 0x0008B26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80057, XrefRangeEnd = 80061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamHD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0008D0B0 File Offset: 0x0008B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80061, XrefRangeEnd = 80065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0008D100 File Offset: 0x0008B300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80065, XrefRangeEnd = 80070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamHD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0008D150 File Offset: 0x0008B350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80098, RefRangeEnd = 80101, XrefRangeStart = 80070, XrefRangeEnd = 80098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditiveIntensity(float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0008D190 File Offset: 0x0008B390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80101, XrefRangeEnd = 80134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0008D1C4 File Offset: 0x0008B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80134, XrefRangeEnd = 80135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0008D200 File Offset: 0x0008B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80135, XrefRangeEnd = 80137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0008D234 File Offset: 0x0008B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80137, XrefRangeEnd = 80138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00007035 File Offset: 0x00005235
		public EffectAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0008D270 File Offset: 0x0008B470
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0000703E File Offset: 0x0000523E
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0008D290 File Offset: 0x0008B490
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00007050 File Offset: 0x00005250
		public unsafe EffectAbstractBase.ComponentsToChange componentsToChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0000706B File Offset: 0x0000526B
		public unsafe bool restoreIntensityOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00007086 File Offset: 0x00005286
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0008D310 File Offset: 0x0008B510
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x000070A5 File Offset: 0x000052A5
		public unsafe Light m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0008D340 File Offset: 0x0008B540
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x000070C4 File Offset: 0x000052C4
		public unsafe VolumetricDustParticles m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0008D370 File Offset: 0x0008B570
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x000070E3 File Offset: 0x000052E3
		public unsafe float m_BaseIntensityBeamInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside)) = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0008D398 File Offset: 0x0008B598
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000070FE File Offset: 0x000052FE
		public unsafe float m_BaseIntensityBeamOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside)) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0008D3C0 File Offset: 0x0008B5C0
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00007119 File Offset: 0x00005319
		public unsafe float m_BaseIntensityLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight)) = value;
			}
		}

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_componentsToChange;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnDisable;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamInside;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamOutside;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityLight;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000817 RID: 2071
		[OriginalName("Assembly-CSharp.dll", "", "ComponentsToChange")]
		[Flags]
		public enum ComponentsToChange
		{
			// Token: 0x040080AA RID: 32938
			UnityLight = 1,
			// Token: 0x040080AB RID: 32939
			VolumetricLightBeam = 2,
			// Token: 0x040080AC RID: 32940
			VolumetricDustParticles = 4
		}
	}
}
