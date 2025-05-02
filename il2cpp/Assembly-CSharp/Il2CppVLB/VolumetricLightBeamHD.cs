using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009B RID: 155
	public class VolumetricLightBeamHD : VolumetricLightBeamAbstractBase
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x0008F86C File Offset: 0x0008DA6C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamHD()
		{
			Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr);
			VolumetricLightBeamHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "ClassName");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_ColorFromLight");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_ColorMode");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_ColorFlat");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_ColorGradient");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_BlendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_BlendingMode");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_Intensity");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_IntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_IntensityMultiplier");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_HDRPExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_HDRPExposureWeight");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_SpotAngle");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_SpotAngleMultiplier");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_ConeRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_ConeRadiusStart");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_Scalable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_Scalable");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_FallOffStart");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_FallOffEnd");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEndMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_FallOffEndMultiplier");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_AttenuationEquation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_AttenuationEquation");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_SideSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_SideSoftness");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_RaymarchingQualityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_RaymarchingQualityID");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_JitteringFactor");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_JitteringFrameRate");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringLerpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_JitteringLerpRange");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseMode");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseIntensity");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseScaleUseGlobal");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseScaleLocal");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseVelocityUseGlobal");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_NoiseVelocityLocal");
			VolumetricLightBeamHD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "<_INTERNAL_InstancedMaterialGroupID>k__BackingField");
			VolumetricLightBeamHD.NativeFieldInfoPtr_m_BeamGeom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, "m_BeamGeom");
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorFromLight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664399);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorFromLight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664400);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorMode_Public_get_ColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664401);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorMode_Public_set_Void_ColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664402);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorFlat_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664403);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorFlat_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664404);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664405);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664406);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664407);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664408);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664409);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664410);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_intensityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664411);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_intensityMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664412);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664413);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_hdrpExposureWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664414);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_hdrpExposureWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664415);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_blendingMode_Public_get_BlendingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664416);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_blendingMode_Public_set_Void_BlendingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664417);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664418);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664419);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_spotAngleMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664420);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_spotAngleMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664421);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664422);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664423);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneRadiusStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664424);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_coneRadiusStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664425);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664426);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664427);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664428);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetConeApexOffsetZ_Public_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664429);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_scalable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664430);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_scalable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664431);
			VolumetricLightBeamHD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664432);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_attenuationEquation_Public_get_AttenuationEquationHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664433);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_attenuationEquation_Public_set_Void_AttenuationEquationHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664434);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664435);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664436);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664437);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664438);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664439);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffEndMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664440);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffEndMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664441);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664442);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_sideSoftness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664443);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_sideSoftness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664444);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664445);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664446);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringFrameRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664447);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringFrameRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664448);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringLerpRange_Public_get_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664449);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringLerpRange_Public_set_Void_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664450);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseMode_Public_get_NoiseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664451);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseMode_Public_set_Void_NoiseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664452);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664453);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664454);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664455);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseScaleUseGlobal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664456);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseScaleUseGlobal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664457);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseScaleLocal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664458);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseScaleLocal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664459);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseVelocityUseGlobal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664460);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseVelocityUseGlobal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664461);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseVelocityLocal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664462);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseVelocityLocal_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664463);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_raymarchingQualityID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664464);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_raymarchingQualityID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664465);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_raymarchingQualityIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664466);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set_raymarchingQualityIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664467);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664468);
			VolumetricLightBeamHD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664469);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664470);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664471);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664472);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664473);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664474);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetAdditionalComponentCookie_Public_VolumetricCookieHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664475);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetAdditionalComponentShadow_Public_VolumetricShadowHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664476);
			VolumetricLightBeamHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664477);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetDimensions_Public_Virtual_New_Dimensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664478);
			VolumetricLightBeamHD.NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664479);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664480);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664481);
			VolumetricLightBeamHD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664482);
			VolumetricLightBeamHD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664483);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664484);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664485);
			VolumetricLightBeamHD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664486);
			VolumetricLightBeamHD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664487);
			VolumetricLightBeamHD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664488);
			VolumetricLightBeamHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664489);
			VolumetricLightBeamHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664490);
			VolumetricLightBeamHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664491);
			VolumetricLightBeamHD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664492);
			VolumetricLightBeamHD.NativeMethodInfoPtr_ClampProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664493);
			VolumetricLightBeamHD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664494);
			VolumetricLightBeamHD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664495);
			VolumetricLightBeamHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr, 100664496);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0009029C File Offset: 0x0008E49C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x000902D8 File Offset: 0x0008E4D8
		public unsafe bool colorFromLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorFromLight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80930, XrefRangeEnd = 80931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorFromLight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00090318 File Offset: 0x0008E518
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00090354 File Offset: 0x0008E554
		public unsafe ColorMode colorMode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 80932, RefRangeEnd = 80939, XrefRangeStart = 80931, XrefRangeEnd = 80932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorMode_Public_get_ColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80939, XrefRangeEnd = 80942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorMode_Public_set_Void_ColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00090394 File Offset: 0x0008E594
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x000903D0 File Offset: 0x0008E5D0
		public unsafe Color colorFlat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorFlat_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80945, RefRangeEnd = 80946, XrefRangeStart = 80942, XrefRangeEnd = 80945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorFlat_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00090410 File Offset: 0x0008E610
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00090450 File Offset: 0x0008E650
		public unsafe Gradient colorGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80946, XrefRangeEnd = 80949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00090494 File Offset: 0x0008E694
		public unsafe bool useColorFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80949, XrefRangeEnd = 80950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000904D0 File Offset: 0x0008E6D0
		public unsafe bool useColorTemperatureFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80950, XrefRangeEnd = 80956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0009050C File Offset: 0x0008E70C
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00090548 File Offset: 0x0008E748
		public unsafe float intensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80959, RefRangeEnd = 80961, XrefRangeStart = 80956, XrefRangeEnd = 80959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00090588 File Offset: 0x0008E788
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x000905C4 File Offset: 0x0008E7C4
		public unsafe float intensityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_intensityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80961, XrefRangeEnd = 80962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_intensityMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00090604 File Offset: 0x0008E804
		public unsafe bool useIntensityFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80962, XrefRangeEnd = 80963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00090640 File Offset: 0x0008E840
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0009067C File Offset: 0x0008E87C
		public unsafe float hdrpExposureWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_hdrpExposureWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80963, XrefRangeEnd = 80965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_hdrpExposureWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000906BC File Offset: 0x0008E8BC
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000906F8 File Offset: 0x0008E8F8
		public unsafe BlendingMode blendingMode
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 42880, RefRangeEnd = 42886, XrefRangeStart = 42880, XrefRangeEnd = 42886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_blendingMode_Public_get_BlendingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80965, XrefRangeEnd = 80967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_blendingMode_Public_set_Void_BlendingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00090738 File Offset: 0x0008E938
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00090774 File Offset: 0x0008E974
		public unsafe float spotAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80967, XrefRangeEnd = 80970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000907B4 File Offset: 0x0008E9B4
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000907F0 File Offset: 0x0008E9F0
		public unsafe float spotAngleMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_spotAngleMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80970, XrefRangeEnd = 80971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_spotAngleMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00090830 File Offset: 0x0008EA30
		public unsafe bool useSpotAngleFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80971, XrefRangeEnd = 80972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0009086C File Offset: 0x0008EA6C
		public unsafe float coneAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80972, XrefRangeEnd = 80974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000908A8 File Offset: 0x0008EAA8
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x000908E4 File Offset: 0x0008EAE4
		public unsafe float coneRadiusStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneRadiusStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80974, XrefRangeEnd = 80976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_coneRadiusStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00090924 File Offset: 0x0008EB24
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00090960 File Offset: 0x0008EB60
		public unsafe float coneRadiusEnd
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80977, RefRangeEnd = 80979, XrefRangeStart = 80976, XrefRangeEnd = 80977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80979, XrefRangeEnd = 80983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x000909A0 File Offset: 0x0008EBA0
		public unsafe float coneVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80983, XrefRangeEnd = 80984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000909DC File Offset: 0x0008EBDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80985, RefRangeEnd = 80989, XrefRangeStart = 80984, XrefRangeEnd = 80985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref counterApplyScaleForUnscalableBeam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_GetConeApexOffsetZ_Public_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00090A28 File Offset: 0x0008EC28
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00090A64 File Offset: 0x0008EC64
		public unsafe bool scalable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_scalable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80989, XrefRangeEnd = 80990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_scalable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00090AA4 File Offset: 0x0008ECA4
		[CallerCount(0)]
		public unsafe override bool IsScalable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00090AEC File Offset: 0x0008ECEC
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00090B28 File Offset: 0x0008ED28
		public unsafe AttenuationEquationHD attenuationEquation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_attenuationEquation_Public_get_AttenuationEquationHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80990, XrefRangeEnd = 80992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_attenuationEquation_Public_set_Void_AttenuationEquationHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00090B68 File Offset: 0x0008ED68
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00090BA4 File Offset: 0x0008EDA4
		public unsafe float fallOffStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80992, XrefRangeEnd = 80994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00090BE4 File Offset: 0x0008EDE4
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00090C20 File Offset: 0x0008EE20
		public unsafe float fallOffEnd
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 45792, RefRangeEnd = 45794, XrefRangeStart = 45792, XrefRangeEnd = 45794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80994, XrefRangeEnd = 80997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00090C60 File Offset: 0x0008EE60
		public unsafe float maxGeometryDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 45792, RefRangeEnd = 45794, XrefRangeStart = 45792, XrefRangeEnd = 45794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00090C9C File Offset: 0x0008EE9C
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00090CD8 File Offset: 0x0008EED8
		public unsafe float fallOffEndMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_fallOffEndMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80997, XrefRangeEnd = 80998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_fallOffEndMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00090D18 File Offset: 0x0008EF18
		public unsafe bool useFallOffEndFromAttachedLightSpot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80998, XrefRangeEnd = 80999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00090D54 File Offset: 0x0008EF54
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00090D90 File Offset: 0x0008EF90
		public unsafe float sideSoftness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_sideSoftness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80999, XrefRangeEnd = 81001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_sideSoftness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00090E0C File Offset: 0x0008F00C
		public unsafe float jitteringFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81001, XrefRangeEnd = 81003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00090E4C File Offset: 0x0008F04C
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00090E88 File Offset: 0x0008F088
		public unsafe int jitteringFrameRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringFrameRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81003, XrefRangeEnd = 81005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringFrameRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00090EC8 File Offset: 0x0008F0C8
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00090F04 File Offset: 0x0008F104
		public unsafe MinMaxRangeFloat jitteringLerpRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_jitteringLerpRange_Public_get_MinMaxRangeFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81005, XrefRangeEnd = 81007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_jitteringLerpRange_Public_set_Void_MinMaxRangeFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00090F44 File Offset: 0x0008F144
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00090F80 File Offset: 0x0008F180
		public unsafe NoiseMode noiseMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseMode_Public_get_NoiseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81007, XrefRangeEnd = 81009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseMode_Public_set_Void_NoiseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00090FC0 File Offset: 0x0008F1C0
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 81009, RefRangeEnd = 81015, XrefRangeStart = 81009, XrefRangeEnd = 81009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00090FFC File Offset: 0x0008F1FC
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00091038 File Offset: 0x0008F238
		public unsafe float noiseIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81015, XrefRangeEnd = 81017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00091078 File Offset: 0x0008F278
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x000910B4 File Offset: 0x0008F2B4
		public unsafe bool noiseScaleUseGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseScaleUseGlobal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81017, XrefRangeEnd = 81019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseScaleUseGlobal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000910F4 File Offset: 0x0008F2F4
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00091130 File Offset: 0x0008F330
		public unsafe float noiseScaleLocal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseScaleLocal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81019, XrefRangeEnd = 81021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseScaleLocal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00091170 File Offset: 0x0008F370
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x000911AC File Offset: 0x0008F3AC
		public unsafe bool noiseVelocityUseGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseVelocityUseGlobal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81021, XrefRangeEnd = 81023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseVelocityUseGlobal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000911EC File Offset: 0x0008F3EC
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00091228 File Offset: 0x0008F428
		public unsafe Vector3 noiseVelocityLocal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_noiseVelocityLocal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81023, XrefRangeEnd = 81025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_noiseVelocityLocal_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00091268 File Offset: 0x0008F468
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x000912A4 File Offset: 0x0008F4A4
		public unsafe int raymarchingQualityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_raymarchingQualityID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81025, XrefRangeEnd = 81027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_raymarchingQualityID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000912E4 File Offset: 0x0008F4E4
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00091320 File Offset: 0x0008F520
		public unsafe int raymarchingQualityIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 81030, RefRangeEnd = 81031, XrefRangeStart = 81027, XrefRangeEnd = 81030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_raymarchingQualityIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81031, XrefRangeEnd = 81037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set_raymarchingQualityIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00091360 File Offset: 0x0008F560
		[CallerCount(0)]
		public unsafe override BeamGeometryAbstractBase GetBeamGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BeamGeometryAbstractBase>(intPtr3) : null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000913AC File Offset: 0x0008F5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81037, XrefRangeEnd = 81038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetBeamGeometryNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x000913E8 File Offset: 0x0008F5E8
		public unsafe int blendingModeAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81038, XrefRangeEnd = 81049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00091424 File Offset: 0x0008F624
		public unsafe Quaternion beamInternalLocalRotation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 81051, RefRangeEnd = 81055, XrefRangeStart = 81049, XrefRangeEnd = 81051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00091460 File Offset: 0x0008F660
		public unsafe Vector3 beamLocalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81055, XrefRangeEnd = 81057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0009149C File Offset: 0x0008F69C
		public unsafe Vector3 beamGlobalForward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81057, XrefRangeEnd = 81064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000914D8 File Offset: 0x0008F6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81064, XrefRangeEnd = 81066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetLossyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00091520 File Offset: 0x0008F720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81069, RefRangeEnd = 81071, XrefRangeStart = 81066, XrefRangeEnd = 81069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricCookieHD GetAdditionalComponentCookie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_GetAdditionalComponentCookie_Public_VolumetricCookieHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricCookieHD>(intPtr3) : null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00091560 File Offset: 0x0008F760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81074, RefRangeEnd = 81076, XrefRangeStart = 81071, XrefRangeEnd = 81074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricShadowHD GetAdditionalComponentShadow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_GetAdditionalComponentShadow_Public_VolumetricShadowHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD>(intPtr3) : null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000915A0 File Offset: 0x0008F7A0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 81081, RefRangeEnd = 81115, XrefRangeStart = 81076, XrefRangeEnd = 81081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyDirty(DirtyProps flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000915E0 File Offset: 0x0008F7E0
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dimensions GetDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GetDimensions_Public_Virtual_New_Dimensions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00091628 File Offset: 0x0008F828
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesSupportSorting2D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00091670 File Offset: 0x0008F870
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetSortingLayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000916B8 File Offset: 0x0008F8B8
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetSortingOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00091700 File Offset: 0x0008F900
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0009173C File Offset: 0x0008F93C
		public unsafe uint _INTERNAL_InstancedMaterialGroupID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0009177C File Offset: 0x0008F97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81115, XrefRangeEnd = 81124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactor(Vector3 posWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000917C8 File Offset: 0x0008F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81124, XrefRangeEnd = 81130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posOS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00091814 File Offset: 0x0008FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81130, XrefRangeEnd = 81177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GenerateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00091850 File Offset: 0x0008FA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81177, XrefRangeEnd = 81179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateAfterManualPropertyChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0009188C File Offset: 0x0008FA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81179, XrefRangeEnd = 81180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000918C0 File Offset: 0x0008FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81180, XrefRangeEnd = 81185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000918F4 File Offset: 0x0008FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81185, XrefRangeEnd = 81190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00091928 File Offset: 0x0008FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81190, XrefRangeEnd = 81191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0009195C File Offset: 0x0008FB5C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 81252, RefRangeEnd = 81265, XrefRangeStart = 81191, XrefRangeEnd = 81252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPropertiesFromAttachedSpotLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00091990 File Offset: 0x0008FB90
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 81269, RefRangeEnd = 81279, XrefRangeStart = 81265, XrefRangeEnd = 81269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_ClampProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000919C4 File Offset: 0x0008FBC4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 81284, RefRangeEnd = 81310, XrefRangeStart = 81279, XrefRangeEnd = 81284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_ValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000919F8 File Offset: 0x0008FBF8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 81310, RefRangeEnd = 81320, XrefRangeStart = 81310, XrefRangeEnd = 81310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00091A44 File Offset: 0x0008FC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81320, XrefRangeEnd = 81330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0000753F File Offset: 0x0000573F
		public VolumetricLightBeamHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00091A80 File Offset: 0x0008FC80
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00007548 File Offset: 0x00005748
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricLightBeamHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricLightBeamHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00091AA0 File Offset: 0x0008FCA0
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000755A File Offset: 0x0000575A
		public unsafe bool m_ColorFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFromLight)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00091AC8 File Offset: 0x0008FCC8
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00007575 File Offset: 0x00005775
		public unsafe ColorMode m_ColorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorMode)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00091AF0 File Offset: 0x0008FCF0
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00007590 File Offset: 0x00005790
		public unsafe Color m_ColorFlat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFlat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorFlat)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00091B18 File Offset: 0x0008FD18
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x000075AB File Offset: 0x000057AB
		public unsafe Gradient m_ColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00091B48 File Offset: 0x0008FD48
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000075CA File Offset: 0x000057CA
		public unsafe BlendingMode m_BlendingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_BlendingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_BlendingMode)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00091B70 File Offset: 0x0008FD70
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000075E5 File Offset: 0x000057E5
		public unsafe float m_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_Intensity)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00091B98 File Offset: 0x0008FD98
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00007600 File Offset: 0x00005800
		public unsafe float m_IntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_IntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_IntensityMultiplier)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00091BC0 File Offset: 0x0008FDC0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0000761B File Offset: 0x0000581B
		public unsafe float m_HDRPExposureWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_HDRPExposureWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_HDRPExposureWeight)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00091BE8 File Offset: 0x0008FDE8
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00007636 File Offset: 0x00005836
		public unsafe float m_SpotAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngle)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00091C10 File Offset: 0x0008FE10
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00007651 File Offset: 0x00005851
		public unsafe float m_SpotAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SpotAngleMultiplier)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00091C38 File Offset: 0x0008FE38
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0000766C File Offset: 0x0000586C
		public unsafe float m_ConeRadiusStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ConeRadiusStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_ConeRadiusStart)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00091C60 File Offset: 0x0008FE60
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00007687 File Offset: 0x00005887
		public unsafe bool m_Scalable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_Scalable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_Scalable)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00091C88 File Offset: 0x0008FE88
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000076A2 File Offset: 0x000058A2
		public unsafe float m_FallOffStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffStart)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000076BD File Offset: 0x000058BD
		public unsafe float m_FallOffEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEnd)) = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00091CD8 File Offset: 0x0008FED8
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000076D8 File Offset: 0x000058D8
		public unsafe float m_FallOffEndMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEndMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_FallOffEndMultiplier)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00091D00 File Offset: 0x0008FF00
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000076F3 File Offset: 0x000058F3
		public unsafe AttenuationEquationHD m_AttenuationEquation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_AttenuationEquation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_AttenuationEquation)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00091D28 File Offset: 0x0008FF28
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0000770E File Offset: 0x0000590E
		public unsafe float m_SideSoftness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SideSoftness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_SideSoftness)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00091D50 File Offset: 0x0008FF50
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00007729 File Offset: 0x00005929
		public unsafe int m_RaymarchingQualityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_RaymarchingQualityID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_RaymarchingQualityID)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00091D78 File Offset: 0x0008FF78
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00007744 File Offset: 0x00005944
		public unsafe float m_JitteringFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFactor)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00091DA0 File Offset: 0x0008FFA0
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0000775F File Offset: 0x0000595F
		public unsafe int m_JitteringFrameRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFrameRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringFrameRate)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00091DC8 File Offset: 0x0008FFC8
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0000777A File Offset: 0x0000597A
		public unsafe MinMaxRangeFloat m_JitteringLerpRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringLerpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_JitteringLerpRange)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00091DF0 File Offset: 0x0008FFF0
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00007795 File Offset: 0x00005995
		public unsafe NoiseMode m_NoiseMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseMode)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00091E18 File Offset: 0x00090018
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000077B0 File Offset: 0x000059B0
		public unsafe float m_NoiseIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseIntensity)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00091E40 File Offset: 0x00090040
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000077CB File Offset: 0x000059CB
		public unsafe bool m_NoiseScaleUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleUseGlobal)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00091E68 File Offset: 0x00090068
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000077E6 File Offset: 0x000059E6
		public unsafe float m_NoiseScaleLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseScaleLocal)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00091E90 File Offset: 0x00090090
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00007801 File Offset: 0x00005A01
		public unsafe bool m_NoiseVelocityUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityUseGlobal)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00091EB8 File Offset: 0x000900B8
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0000781C File Offset: 0x00005A1C
		public unsafe Vector3 m_NoiseVelocityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_NoiseVelocityLocal)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00091EE0 File Offset: 0x000900E0
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00007837 File Offset: 0x00005A37
		public unsafe uint __INTERNAL_InstancedMaterialGroupID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00091F08 File Offset: 0x00090108
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00007852 File Offset: 0x00005A52
		public unsafe BeamGeometryHD m_BeamGeom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_BeamGeom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeamGeometryHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD.NativeFieldInfoPtr_m_BeamGeom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorFromLight;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorMode;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorFlat;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradient;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendingMode;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_m_Intensity;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_m_IntensityMultiplier;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_m_HDRPExposureWeight;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotAngle;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotAngleMultiplier;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_m_ConeRadiusStart;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_m_Scalable;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_m_FallOffStart;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_FallOffEnd;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_FallOffEndMultiplier;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_AttenuationEquation;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_SideSoftness;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_RaymarchingQualityID;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_m_JitteringFactor;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_m_JitteringFrameRate;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_m_JitteringLerpRange;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseMode;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseIntensity;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseScaleUseGlobal;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseScaleLocal;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseVelocityUseGlobal;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseVelocityLocal;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr_m_BeamGeom;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_get_colorFromLight_Public_get_Boolean_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_set_colorFromLight_Public_set_Void_Boolean_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_get_colorMode_Public_get_ColorMode_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_set_colorMode_Public_set_Void_ColorMode_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_get_colorFlat_Public_get_Color_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_set_colorFlat_Public_set_Void_Color_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_get_useColorTemperatureFromAttachedLightSpot_Private_get_Boolean_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_get_intensityMultiplier_Public_get_Single_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_set_intensityMultiplier_Public_set_Void_Single_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_get_useIntensityFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrpExposureWeight_Public_get_Single_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_set_hdrpExposureWeight_Public_set_Void_Single_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_blendingMode_Public_get_BlendingMode_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_set_blendingMode_Public_set_Void_BlendingMode_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_set_spotAngle_Public_set_Void_Single_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngleMultiplier_Public_get_Single_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_set_spotAngleMultiplier_Public_set_Void_Single_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_get_useSpotAngleFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_get_coneRadiusStart_Public_get_Single_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_set_coneRadiusStart_Public_set_Void_Single_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_set_coneRadiusEnd_Public_set_Void_Single_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_GetConeApexOffsetZ_Public_Single_Boolean_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_get_scalable_Public_get_Boolean_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_set_scalable_Public_set_Void_Boolean_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_IsScalable_Public_Virtual_Boolean_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_get_attenuationEquation_Public_get_AttenuationEquationHD_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_set_attenuationEquation_Public_set_Void_AttenuationEquationHD_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_fallOffStart_Public_get_Single_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_set_fallOffStart_Public_set_Void_Single_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_get_fallOffEnd_Public_get_Single_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_set_fallOffEnd_Public_set_Void_Single_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_get_maxGeometryDistance_Public_get_Single_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_get_fallOffEndMultiplier_Public_get_Single_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_set_fallOffEndMultiplier_Public_set_Void_Single_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_get_useFallOffEndFromAttachedLightSpot_Public_get_Boolean_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_get_sideSoftness_Public_get_Single_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_set_sideSoftness_Public_set_Void_Single_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_get_jitteringFactor_Public_get_Single_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_set_jitteringFactor_Public_set_Void_Single_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_get_jitteringFrameRate_Public_get_Int32_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_set_jitteringFrameRate_Public_set_Void_Int32_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_get_jitteringLerpRange_Public_get_MinMaxRangeFloat_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_set_jitteringLerpRange_Public_set_Void_MinMaxRangeFloat_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseMode_Public_get_NoiseMode_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseMode_Public_set_Void_NoiseMode_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseIntensity_Public_get_Single_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseIntensity_Public_set_Void_Single_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseScaleUseGlobal_Public_get_Boolean_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseScaleUseGlobal_Public_set_Void_Boolean_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseScaleLocal_Public_get_Single_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseScaleLocal_Public_set_Void_Single_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseVelocityUseGlobal_Public_get_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseVelocityUseGlobal_Public_set_Void_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseVelocityLocal_Public_get_Vector3_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseVelocityLocal_Public_set_Void_Vector3_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualityID_Public_get_Int32_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_set_raymarchingQualityID_Public_set_Void_Int32_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualityIndex_Public_get_Int32_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_set_raymarchingQualityIndex_Public_set_Void_Int32_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamGeometry_Public_Virtual_BeamGeometryAbstractBase_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Virtual_Void_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_beamInternalLocalRotation_Public_get_Quaternion_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_beamLocalForward_Public_get_Vector3_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_beamGlobalForward_Public_get_Vector3_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Public_Virtual_Vector3_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalComponentCookie_Public_VolumetricCookieHD_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalComponentShadow_Public_VolumetricShadowHD_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_Virtual_New_Dimensions_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_New_Boolean_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_New_Int32_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_New_Int32_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_AssignPropertiesFromAttachedSpotLight_Public_Void_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_ClampProperties_Private_Void_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_ValidateProperties_Private_Void_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
