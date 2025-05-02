using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppVLB;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003BB RID: 955
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x06004A59 RID: 19033 RVA: 0x00168B54 File Offset: 0x00166D54
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightTracker()
		{
			Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "VolumetricLightTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr);
			VolumetricLightTracker.NativeFieldInfoPtr_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Override");
			VolumetricLightTracker.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Enabled");
			VolumetricLightTracker.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "light");
			VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "optimizedLight");
			VolumetricLightTracker.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "beam");
			VolumetricLightTracker.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "dust");
			VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672510);
			VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672511);
			VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672512);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00168C38 File Offset: 0x00166E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164012, XrefRangeEnd = 164041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00168C6C File Offset: 0x00166E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164041, XrefRangeEnd = 164057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00168CA0 File Offset: 0x00166EA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00023DF6 File Offset: 0x00021FF6
		public VolumetricLightTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004A5E RID: 19038 RVA: 0x00168CDC File Offset: 0x00166EDC
		// (set) Token: 0x06004A5F RID: 19039 RVA: 0x00023DFF File Offset: 0x00021FFF
		public unsafe bool Override
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override)) = value;
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004A60 RID: 19040 RVA: 0x00168D04 File Offset: 0x00166F04
		// (set) Token: 0x06004A61 RID: 19041 RVA: 0x00023E1A File Offset: 0x0002201A
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06004A62 RID: 19042 RVA: 0x00168D2C File Offset: 0x00166F2C
		// (set) Token: 0x06004A63 RID: 19043 RVA: 0x00023E35 File Offset: 0x00022035
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x00168D5C File Offset: 0x00166F5C
		// (set) Token: 0x06004A65 RID: 19045 RVA: 0x00023E54 File Offset: 0x00022054
		public unsafe OptimizedLight optimizedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06004A66 RID: 19046 RVA: 0x00168D8C File Offset: 0x00166F8C
		// (set) Token: 0x06004A67 RID: 19047 RVA: 0x00023E73 File Offset: 0x00022073
		public unsafe VolumetricLightBeamSD beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06004A68 RID: 19048 RVA: 0x00168DBC File Offset: 0x00166FBC
		// (set) Token: 0x06004A69 RID: 19049 RVA: 0x00023E92 File Offset: 0x00022092
		public unsafe VolumetricDustParticles dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr_Override;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeFieldInfoPtr_optimizedLight;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
