using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B5 RID: 949
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x060049EE RID: 18926 RVA: 0x001679C4 File Offset: 0x00165BC4
		// Note: this type is marked as 'beforefieldinit'.
		static FlickeringLight()
		{
			Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "FlickeringLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr);
			FlickeringLight.NativeFieldInfoPtr_minIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minIntensity");
			FlickeringLight.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxIntensity");
			FlickeringLight.NativeFieldInfoPtr_enableColorShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "enableColorShift");
			FlickeringLight.NativeFieldInfoPtr_minColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minColor");
			FlickeringLight.NativeFieldInfoPtr_maxColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxColor");
			FlickeringLight.NativeFieldInfoPtr_flickerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "flickerSpeed");
			FlickeringLight.NativeFieldInfoPtr_lightSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "lightSource");
			FlickeringLight.NativeFieldInfoPtr_targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetIntensity");
			FlickeringLight.NativeFieldInfoPtr_targetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetColor");
			FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672472);
			FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672473);
			FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672474);
			FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672475);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00167AF8 File Offset: 0x00165CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163767, XrefRangeEnd = 163772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00167B2C File Offset: 0x00165D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163772, XrefRangeEnd = 163782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00167B60 File Offset: 0x00165D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163785, RefRangeEnd = 163787, XrefRangeStart = 163782, XrefRangeEnd = 163785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00167B94 File Offset: 0x00165D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163787, XrefRangeEnd = 163788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlickeringLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x000239E1 File Offset: 0x00021BE1
		public FlickeringLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x00167BD0 File Offset: 0x00165DD0
		// (set) Token: 0x060049F5 RID: 18933 RVA: 0x000239EA File Offset: 0x00021BEA
		public unsafe float minIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity)) = value;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00167BF8 File Offset: 0x00165DF8
		// (set) Token: 0x060049F7 RID: 18935 RVA: 0x00023A05 File Offset: 0x00021C05
		public unsafe float maxIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity)) = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x00167C20 File Offset: 0x00165E20
		// (set) Token: 0x060049F9 RID: 18937 RVA: 0x00023A20 File Offset: 0x00021C20
		public unsafe bool enableColorShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift)) = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060049FA RID: 18938 RVA: 0x00167C48 File Offset: 0x00165E48
		// (set) Token: 0x060049FB RID: 18939 RVA: 0x00023A3B File Offset: 0x00021C3B
		public unsafe Color minColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor)) = value;
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x00167C70 File Offset: 0x00165E70
		// (set) Token: 0x060049FD RID: 18941 RVA: 0x00023A56 File Offset: 0x00021C56
		public unsafe Color maxColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor)) = value;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x00167C98 File Offset: 0x00165E98
		// (set) Token: 0x060049FF RID: 18943 RVA: 0x00023A71 File Offset: 0x00021C71
		public unsafe float flickerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed)) = value;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06004A00 RID: 18944 RVA: 0x00167CC0 File Offset: 0x00165EC0
		// (set) Token: 0x06004A01 RID: 18945 RVA: 0x00023A8C File Offset: 0x00021C8C
		public unsafe Light lightSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x00167CF0 File Offset: 0x00165EF0
		// (set) Token: 0x06004A03 RID: 18947 RVA: 0x00023AAB File Offset: 0x00021CAB
		public unsafe float targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity)) = value;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x00167D18 File Offset: 0x00165F18
		// (set) Token: 0x06004A05 RID: 18949 RVA: 0x00023AC6 File Offset: 0x00021CC6
		public unsafe Color targetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor)) = value;
			}
		}

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeFieldInfoPtr_minIntensity;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeFieldInfoPtr_enableColorShift;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeFieldInfoPtr_minColor;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeFieldInfoPtr_maxColor;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeFieldInfoPtr_flickerSpeed;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeFieldInfoPtr_lightSource;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeFieldInfoPtr_targetIntensity;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeFieldInfoPtr_targetColor;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
