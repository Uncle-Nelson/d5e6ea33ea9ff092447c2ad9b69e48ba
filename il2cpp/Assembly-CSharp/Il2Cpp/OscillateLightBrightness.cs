using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000044 RID: 68
	public class OscillateLightBrightness : MonoBehaviour
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x00081AD0 File Offset: 0x0007FCD0
		// Note: this type is marked as 'beforefieldinit'.
		static OscillateLightBrightness()
		{
			Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OscillateLightBrightness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr);
			OscillateLightBrightness.NativeFieldInfoPtr_lightComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lightComponent");
			OscillateLightBrightness.NativeFieldInfoPtr_lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lower");
			OscillateLightBrightness.NativeFieldInfoPtr_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "upper");
			OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663845);
			OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663846);
			OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663847);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00081B78 File Offset: 0x0007FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75616, XrefRangeEnd = 75620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00081BAC File Offset: 0x0007FDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75620, XrefRangeEnd = 75623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00081BE0 File Offset: 0x0007FDE0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OscillateLightBrightness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00005684 File Offset: 0x00003884
		public OscillateLightBrightness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00081C1C File Offset: 0x0007FE1C
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000568D File Offset: 0x0000388D
		public unsafe Light lightComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00081C4C File Offset: 0x0007FE4C
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x000056AC File Offset: 0x000038AC
		public unsafe float lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00081C74 File Offset: 0x0007FE74
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000056C7 File Offset: 0x000038C7
		public unsafe float upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper)) = value;
			}
		}

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_lightComponent;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_lower;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_upper;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
