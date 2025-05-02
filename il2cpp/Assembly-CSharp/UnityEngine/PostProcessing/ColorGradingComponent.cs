using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000052 RID: 82
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x00083764 File Offset: 0x00081964
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingComponent()
		{
			Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr);
			ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_InternalLogLutSize");
			ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_CurvePrecision");
			ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_CurveStep");
			ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "m_GradingCurves");
			ColorGradingComponent.NativeFieldInfoPtr_m_pixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "m_pixels");
			ColorGradingComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663911);
			ColorGradingComponent.NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663912);
			ColorGradingComponent.NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663913);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663914);
			ColorGradingComponent.NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663915);
			ColorGradingComponent.NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663916);
			ColorGradingComponent.NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663917);
			ColorGradingComponent.NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663918);
			ColorGradingComponent.NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663919);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663920);
			ColorGradingComponent.NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663921);
			ColorGradingComponent.NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663922);
			ColorGradingComponent.NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663923);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663924);
			ColorGradingComponent.NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663925);
			ColorGradingComponent.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663926);
			ColorGradingComponent.NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663927);
			ColorGradingComponent.NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663928);
			ColorGradingComponent.NativeMethodInfoPtr_GenerateLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663929);
			ColorGradingComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663930);
			ColorGradingComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663931);
			ColorGradingComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663932);
			ColorGradingComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663933);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000839C4 File Offset: 0x00081BC4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76265, XrefRangeEnd = 76266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00083A00 File Offset: 0x00081C00
		[CallerCount(0)]
		public unsafe float StandardIlluminantY(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00083A4C File Offset: 0x00081C4C
		[CallerCount(0)]
		public unsafe Vector3 CIExyToLMS(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00083AA4 File Offset: 0x00081CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76266, XrefRangeEnd = 76267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CalculateColorBalance(float temperature, float tint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temperature;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00083AFC File Offset: 0x00081CFC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 76269, RefRangeEnd = 76280, XrefRangeStart = 76267, XrefRangeEnd = 76269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color NormalizeColor(Color c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00083B3C File Offset: 0x00081D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76280, XrefRangeEnd = 76282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00083B98 File Offset: 0x00081D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76282, XrefRangeEnd = 76286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetLiftValue(Color lift)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00083BD8 File Offset: 0x00081DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76294, RefRangeEnd = 76295, XrefRangeStart = 76286, XrefRangeEnd = 76294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetGammaValue(Color gamma)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gamma;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00083C18 File Offset: 0x00081E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76295, XrefRangeEnd = 76302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetGainValue(Color gain)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00083C58 File Offset: 0x00081E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76314, RefRangeEnd = 76315, XrefRangeStart = 76302, XrefRangeEnd = 76314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamma;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outLift;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outGamma;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outGain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00083CD4 File Offset: 0x00081ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76315, XrefRangeEnd = 76319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetSlopeValue(Color slope)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00083D14 File Offset: 0x00081F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76319, XrefRangeEnd = 76323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPowerValue(Color power)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00083D54 File Offset: 0x00081F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76323, XrefRangeEnd = 76327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetOffsetValue(Color offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00083D94 File Offset: 0x00081F94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76339, RefRangeEnd = 76340, XrefRangeStart = 76327, XrefRangeEnd = 76339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slope;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outSlope;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outPower;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00083E10 File Offset: 0x00082010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76340, XrefRangeEnd = 76341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureFormat GetCurveFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00083E4C File Offset: 0x0008204C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76371, RefRangeEnd = 76372, XrefRangeStart = 76341, XrefRangeEnd = 76371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetCurveTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00083E8C File Offset: 0x0008208C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76372, XrefRangeEnd = 76377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLogLutValid(RenderTexture lut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00083EDC File Offset: 0x000820DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76377, XrefRangeEnd = 76378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat GetLutFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00083F18 File Offset: 0x00082118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76458, RefRangeEnd = 76459, XrefRangeStart = 76378, XrefRangeEnd = 76458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GenerateLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00083F4C File Offset: 0x0008214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76459, XrefRangeEnd = 76483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00083F90 File Offset: 0x00082190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76483, XrefRangeEnd = 76490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00083FC4 File Offset: 0x000821C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76490, XrefRangeEnd = 76496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00083FF8 File Offset: 0x000821F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76503, RefRangeEnd = 76504, XrefRangeStart = 76496, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00005B8C File Offset: 0x00003D8C
		public ColorGradingComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00084034 File Offset: 0x00082234
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00005B95 File Offset: 0x00003D95
		public unsafe static int k_InternalLogLutSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize, (void*)(&value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00084050 File Offset: 0x00082250
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00005BA3 File Offset: 0x00003DA3
		public unsafe static int k_CurvePrecision
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision, (void*)(&value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0008406C File Offset: 0x0008226C
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00005BB1 File Offset: 0x00003DB1
		public unsafe static float k_CurveStep
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep, (void*)(&value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00084088 File Offset: 0x00082288
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00005BBF File Offset: 0x00003DBF
		public unsafe Texture2D m_GradingCurves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000840B8 File Offset: 0x000822B8
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00005BDE File Offset: 0x00003DDE
		public unsafe Il2CppStructArray<Color> m_pixels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_pixels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_pixels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_k_InternalLogLutSize;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_k_CurvePrecision;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_k_CurveStep;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_m_GradingCurves;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_m_pixels;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_GenerateLut_Private_Void_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CB RID: 1995
		public static class Uniforms : Object
		{
			// Token: 0x0600BB2E RID: 47918 RVA: 0x002E54E8 File Offset: 0x002E36E8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr);
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LutParams");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_NeutralTonemapperParams1");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_NeutralTonemapperParams2");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_HueShift");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Saturation");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Contrast");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Balance");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Lift");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_InvGamma");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Gain");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Slope");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Power");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Offset");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerRed");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerGreen");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerBlue");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Curves");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LogLut");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LogLut_Params");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ExposureEV");
			}

			// Token: 0x0600BB2F RID: 47919 RVA: 0x0005B99C File Offset: 0x00059B9C
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039D9 RID: 14809
			// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x002E56A4 File Offset: 0x002E38A4
			// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x0005B9A5 File Offset: 0x00059BA5
			public unsafe static int _LutParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams, (void*)(&value));
				}
			}

			// Token: 0x170039DA RID: 14810
			// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x002E56C0 File Offset: 0x002E38C0
			// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x0005B9B3 File Offset: 0x00059BB3
			public unsafe static int _NeutralTonemapperParams1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1, (void*)(&value));
				}
			}

			// Token: 0x170039DB RID: 14811
			// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x002E56DC File Offset: 0x002E38DC
			// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x0005B9C1 File Offset: 0x00059BC1
			public unsafe static int _NeutralTonemapperParams2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2, (void*)(&value));
				}
			}

			// Token: 0x170039DC RID: 14812
			// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x002E56F8 File Offset: 0x002E38F8
			// (set) Token: 0x0600BB37 RID: 47927 RVA: 0x0005B9CF File Offset: 0x00059BCF
			public unsafe static int _HueShift
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift, (void*)(&value));
				}
			}

			// Token: 0x170039DD RID: 14813
			// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x002E5714 File Offset: 0x002E3914
			// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x0005B9DD File Offset: 0x00059BDD
			public unsafe static int _Saturation
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation, (void*)(&value));
				}
			}

			// Token: 0x170039DE RID: 14814
			// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x002E5730 File Offset: 0x002E3930
			// (set) Token: 0x0600BB3B RID: 47931 RVA: 0x0005B9EB File Offset: 0x00059BEB
			public unsafe static int _Contrast
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast, (void*)(&value));
				}
			}

			// Token: 0x170039DF RID: 14815
			// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x002E574C File Offset: 0x002E394C
			// (set) Token: 0x0600BB3D RID: 47933 RVA: 0x0005B9F9 File Offset: 0x00059BF9
			public unsafe static int _Balance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance, (void*)(&value));
				}
			}

			// Token: 0x170039E0 RID: 14816
			// (get) Token: 0x0600BB3E RID: 47934 RVA: 0x002E5768 File Offset: 0x002E3968
			// (set) Token: 0x0600BB3F RID: 47935 RVA: 0x0005BA07 File Offset: 0x00059C07
			public unsafe static int _Lift
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift, (void*)(&value));
				}
			}

			// Token: 0x170039E1 RID: 14817
			// (get) Token: 0x0600BB40 RID: 47936 RVA: 0x002E5784 File Offset: 0x002E3984
			// (set) Token: 0x0600BB41 RID: 47937 RVA: 0x0005BA15 File Offset: 0x00059C15
			public unsafe static int _InvGamma
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma, (void*)(&value));
				}
			}

			// Token: 0x170039E2 RID: 14818
			// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x002E57A0 File Offset: 0x002E39A0
			// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x0005BA23 File Offset: 0x00059C23
			public unsafe static int _Gain
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain, (void*)(&value));
				}
			}

			// Token: 0x170039E3 RID: 14819
			// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x002E57BC File Offset: 0x002E39BC
			// (set) Token: 0x0600BB45 RID: 47941 RVA: 0x0005BA31 File Offset: 0x00059C31
			public unsafe static int _Slope
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope, (void*)(&value));
				}
			}

			// Token: 0x170039E4 RID: 14820
			// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x002E57D8 File Offset: 0x002E39D8
			// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x0005BA3F File Offset: 0x00059C3F
			public unsafe static int _Power
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power, (void*)(&value));
				}
			}

			// Token: 0x170039E5 RID: 14821
			// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x002E57F4 File Offset: 0x002E39F4
			// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x0005BA4D File Offset: 0x00059C4D
			public unsafe static int _Offset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset, (void*)(&value));
				}
			}

			// Token: 0x170039E6 RID: 14822
			// (get) Token: 0x0600BB4A RID: 47946 RVA: 0x002E5810 File Offset: 0x002E3A10
			// (set) Token: 0x0600BB4B RID: 47947 RVA: 0x0005BA5B File Offset: 0x00059C5B
			public unsafe static int _ChannelMixerRed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&value));
				}
			}

			// Token: 0x170039E7 RID: 14823
			// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x002E582C File Offset: 0x002E3A2C
			// (set) Token: 0x0600BB4D RID: 47949 RVA: 0x0005BA69 File Offset: 0x00059C69
			public unsafe static int _ChannelMixerGreen
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&value));
				}
			}

			// Token: 0x170039E8 RID: 14824
			// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002E5848 File Offset: 0x002E3A48
			// (set) Token: 0x0600BB4F RID: 47951 RVA: 0x0005BA77 File Offset: 0x00059C77
			public unsafe static int _ChannelMixerBlue
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&value));
				}
			}

			// Token: 0x170039E9 RID: 14825
			// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x002E5864 File Offset: 0x002E3A64
			// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x0005BA85 File Offset: 0x00059C85
			public unsafe static int _Curves
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves, (void*)(&value));
				}
			}

			// Token: 0x170039EA RID: 14826
			// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x002E5880 File Offset: 0x002E3A80
			// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x0005BA93 File Offset: 0x00059C93
			public unsafe static int _LogLut
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut, (void*)(&value));
				}
			}

			// Token: 0x170039EB RID: 14827
			// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x002E589C File Offset: 0x002E3A9C
			// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x0005BAA1 File Offset: 0x00059CA1
			public unsafe static int _LogLut_Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params, (void*)(&value));
				}
			}

			// Token: 0x170039EC RID: 14828
			// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x002E58B8 File Offset: 0x002E3AB8
			// (set) Token: 0x0600BB57 RID: 47959 RVA: 0x0005BAAF File Offset: 0x00059CAF
			public unsafe static int _ExposureEV
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV, (void*)(&value));
				}
			}

			// Token: 0x04007E36 RID: 32310
			private static readonly IntPtr NativeFieldInfoPtr__LutParams;

			// Token: 0x04007E37 RID: 32311
			private static readonly IntPtr NativeFieldInfoPtr__NeutralTonemapperParams1;

			// Token: 0x04007E38 RID: 32312
			private static readonly IntPtr NativeFieldInfoPtr__NeutralTonemapperParams2;

			// Token: 0x04007E39 RID: 32313
			private static readonly IntPtr NativeFieldInfoPtr__HueShift;

			// Token: 0x04007E3A RID: 32314
			private static readonly IntPtr NativeFieldInfoPtr__Saturation;

			// Token: 0x04007E3B RID: 32315
			private static readonly IntPtr NativeFieldInfoPtr__Contrast;

			// Token: 0x04007E3C RID: 32316
			private static readonly IntPtr NativeFieldInfoPtr__Balance;

			// Token: 0x04007E3D RID: 32317
			private static readonly IntPtr NativeFieldInfoPtr__Lift;

			// Token: 0x04007E3E RID: 32318
			private static readonly IntPtr NativeFieldInfoPtr__InvGamma;

			// Token: 0x04007E3F RID: 32319
			private static readonly IntPtr NativeFieldInfoPtr__Gain;

			// Token: 0x04007E40 RID: 32320
			private static readonly IntPtr NativeFieldInfoPtr__Slope;

			// Token: 0x04007E41 RID: 32321
			private static readonly IntPtr NativeFieldInfoPtr__Power;

			// Token: 0x04007E42 RID: 32322
			private static readonly IntPtr NativeFieldInfoPtr__Offset;

			// Token: 0x04007E43 RID: 32323
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerRed;

			// Token: 0x04007E44 RID: 32324
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerGreen;

			// Token: 0x04007E45 RID: 32325
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerBlue;

			// Token: 0x04007E46 RID: 32326
			private static readonly IntPtr NativeFieldInfoPtr__Curves;

			// Token: 0x04007E47 RID: 32327
			private static readonly IntPtr NativeFieldInfoPtr__LogLut;

			// Token: 0x04007E48 RID: 32328
			private static readonly IntPtr NativeFieldInfoPtr__LogLut_Params;

			// Token: 0x04007E49 RID: 32329
			private static readonly IntPtr NativeFieldInfoPtr__ExposureEV;
		}
	}
}
