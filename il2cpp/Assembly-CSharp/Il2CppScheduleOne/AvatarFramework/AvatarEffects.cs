using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F2 RID: 1522
	public class AvatarEffects : MonoBehaviour
	{
		// Token: 0x06008561 RID: 34145 RVA: 0x00235B84 File Offset: 0x00233D84
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEffects()
		{
			Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr);
			AvatarEffects.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "Avatar");
			AvatarEffects.NativeFieldInfoPtr_StinkParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "StinkParticles");
			AvatarEffects.NativeFieldInfoPtr_VomitParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitParticles");
			AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadPoofParticles");
			AvatarEffects.NativeFieldInfoPtr_FartParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartParticles");
			AvatarEffects.NativeFieldInfoPtr_AntiGravParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AntiGravParticles");
			AvatarEffects.NativeFieldInfoPtr_FireParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireParticles");
			AvatarEffects.NativeFieldInfoPtr_FireLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireLight");
			AvatarEffects.NativeFieldInfoPtr_FoggyEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FoggyEffects");
			AvatarEffects.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadBone");
			AvatarEffects.NativeFieldInfoPtr_NeckBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckBone");
			AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "MirrorEffectsTo");
			AvatarEffects.NativeFieldInfoPtr_ZapParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapParticles");
			AvatarEffects.NativeFieldInfoPtr_CountdownExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "CountdownExplosion");
			AvatarEffects.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ObjectsToCull");
			AvatarEffects.NativeFieldInfoPtr_DisableHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "DisableHead");
			AvatarEffects.NativeFieldInfoPtr_GurgleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "GurgleSound");
			AvatarEffects.NativeFieldInfoPtr_VomitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "VomitSound");
			AvatarEffects.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "PoofSound");
			AvatarEffects.NativeFieldInfoPtr_FartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FartSound");
			AvatarEffects.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "FireSound");
			AvatarEffects.NativeFieldInfoPtr_ZapSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapSound");
			AvatarEffects.NativeFieldInfoPtr_ZapLoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "ZapLoopSound");
			AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalWeightController");
			AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "AdditionalGenderController");
			AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "HeadSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "NeckSizeBoost");
			AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "SkinColorSmoother");
			AvatarEffects.NativeFieldInfoPtr_laxativeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "laxativeEnabled");
			AvatarEffects.NativeFieldInfoPtr_currentEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "currentEmission");
			AvatarEffects.NativeFieldInfoPtr_targetEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "targetEmission");
			AvatarEffects.NativeFieldInfoPtr_isCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "isCulled");
			AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679963);
			AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679964);
			AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679965);
			AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679966);
			AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679967);
			AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679968);
			AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679969);
			AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679970);
			AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679971);
			AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679972);
			AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679973);
			AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679974);
			AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679975);
			AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679976);
			AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679977);
			AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679978);
			AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679979);
			AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679980);
			AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679981);
			AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679982);
			AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679983);
			AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679984);
			AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679985);
			AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679986);
			AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679987);
			AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679988);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679989);
			AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679990);
			AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679991);
			AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679992);
			AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679993);
			AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679994);
			AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679995);
			AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679996);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679997);
			AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, 100679998);
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x00236104 File Offset: 0x00234304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250271, XrefRangeEnd = 250293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x00236138 File Offset: 0x00234338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250293, XrefRangeEnd = 250333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x0023616C File Offset: 0x0023436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250333, XrefRangeEnd = 250335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffectsCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x002361AC File Offset: 0x002343AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250341, RefRangeEnd = 250346, XrefRangeStart = 250335, XrefRangeEnd = 250341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStinkParticlesActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x002361F8 File Offset: 0x002343F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 250356, RefRangeEnd = 250363, XrefRangeStart = 250346, XrefRangeEnd = 250356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSick(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00236238 File Offset: 0x00234438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250366, RefRangeEnd = 250371, XrefRangeStart = 250363, XrefRangeEnd = 250366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAntiGrav(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00236284 File Offset: 0x00234484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250374, RefRangeEnd = 250379, XrefRangeStart = 250371, XrefRangeEnd = 250374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoggy(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x002362D0 File Offset: 0x002344D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250387, RefRangeEnd = 250390, XrefRangeStart = 250379, XrefRangeEnd = 250387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VanishHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x00236310 File Offset: 0x00234510
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250401, RefRangeEnd = 250407, XrefRangeStart = 250390, XrefRangeEnd = 250401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZapped(bool zapped, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zapped;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x0023635C File Offset: 0x0023455C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250415, RefRangeEnd = 250418, XrefRangeStart = 250407, XrefRangeEnd = 250415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnHair(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x0023639C File Offset: 0x0023459C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250435, RefRangeEnd = 250438, XrefRangeStart = 250418, XrefRangeEnd = 250435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x002363E8 File Offset: 0x002345E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250442, RefRangeEnd = 250445, XrefRangeStart = 250438, XrefRangeEnd = 250442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x00236428 File Offset: 0x00234628
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250449, RefRangeEnd = 250454, XrefRangeStart = 250445, XrefRangeEnd = 250449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emission;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00236484 File Offset: 0x00234684
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250458, RefRangeEnd = 250463, XrefRangeStart = 250454, XrefRangeEnd = 250458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x002364C4 File Offset: 0x002346C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250467, RefRangeEnd = 250472, XrefRangeStart = 250463, XrefRangeEnd = 250467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00236520 File Offset: 0x00234720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250486, RefRangeEnd = 250489, XrefRangeStart = 250472, XrefRangeEnd = 250486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x00236560 File Offset: 0x00234760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250491, RefRangeEnd = 250494, XrefRangeStart = 250489, XrefRangeEnd = 250491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLaxative(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x002365A0 File Offset: 0x002347A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250497, RefRangeEnd = 250502, XrefRangeStart = 250494, XrefRangeEnd = 250497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFireActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008574 RID: 34164 RVA: 0x002365EC File Offset: 0x002347EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250510, RefRangeEnd = 250515, XrefRangeStart = 250502, XrefRangeEnd = 250510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBigHeadActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x00236638 File Offset: 0x00234838
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250527, RefRangeEnd = 250532, XrefRangeStart = 250515, XrefRangeEnd = 250527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGiraffeActive(bool active, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00236684 File Offset: 0x00234884
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250545, RefRangeEnd = 250550, XrefRangeStart = 250532, XrefRangeEnd = 250545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x002366D0 File Offset: 0x002348D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250563, RefRangeEnd = 250568, XrefRangeStart = 250550, XrefRangeEnd = 250563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSicklySkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00236710 File Offset: 0x00234910
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250575, RefRangeEnd = 250578, XrefRangeStart = 250568, XrefRangeEnd = 250575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultSkinColor(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00236750 File Offset: 0x00234950
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250588, RefRangeEnd = 250593, XrefRangeStart = 250578, XrefRangeEnd = 250588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGenderInverted(bool inverted, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inverted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x0023679C File Offset: 0x0023499C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250596, RefRangeEnd = 250599, XrefRangeStart = 250593, XrefRangeEnd = 250596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00236808 File Offset: 0x00234A08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250602, RefRangeEnd = 250605, XrefRangeStart = 250599, XrefRangeEnd = 250602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x00236858 File Offset: 0x00234A58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250607, RefRangeEnd = 250610, XrefRangeStart = 250605, XrefRangeEnd = 250607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOn(Color color, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x002368A4 File Offset: 0x00234AA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250612, RefRangeEnd = 250615, XrefRangeStart = 250610, XrefRangeEnd = 250612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlowingOff(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x002368E4 File Offset: 0x00234AE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250618, RefRangeEnd = 250621, XrefRangeStart = 250615, XrefRangeEnd = 250618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x00236924 File Offset: 0x00234B24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250624, RefRangeEnd = 250627, XrefRangeStart = 250621, XrefRangeEnd = 250624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdownExplosion(bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00236964 File Offset: 0x00234B64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250646, RefRangeEnd = 250651, XrefRangeStart = 250627, XrefRangeEnd = 250646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCyclopean(bool enabled, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x002369B0 File Offset: 0x00234BB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250676, RefRangeEnd = 250681, XrefRangeStart = 250651, XrefRangeEnd = 250676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZombified(bool zombified, bool mirror = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref zombified;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirror;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x002369FC File Offset: 0x00234BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250681, XrefRangeEnd = 250682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00236A38 File Offset: 0x00234C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250682, XrefRangeEnd = 250683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr__Start_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00236A6C File Offset: 0x00234C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250683, XrefRangeEnd = 250688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00236AAC File Offset: 0x00234CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250688, XrefRangeEnd = 250693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x0003F501 File Offset: 0x0003D701
		public AvatarEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x00236AEC File Offset: 0x00234CEC
		// (set) Token: 0x06008588 RID: 34184 RVA: 0x0003F50A File Offset: 0x0003D70A
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x00236B1C File Offset: 0x00234D1C
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x0003F529 File Offset: 0x0003D729
		public unsafe Il2CppReferenceArray<ParticleSystem> StinkParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_StinkParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x00236B4C File Offset: 0x00234D4C
		// (set) Token: 0x0600858C RID: 34188 RVA: 0x0003F548 File Offset: 0x0003D748
		public unsafe ParticleSystem VomitParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x00236B7C File Offset: 0x00234D7C
		// (set) Token: 0x0600858E RID: 34190 RVA: 0x0003F567 File Offset: 0x0003D767
		public unsafe ParticleSystem HeadPoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadPoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600858F RID: 34191 RVA: 0x00236BAC File Offset: 0x00234DAC
		// (set) Token: 0x06008590 RID: 34192 RVA: 0x0003F586 File Offset: 0x0003D786
		public unsafe ParticleSystem FartParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x00236BDC File Offset: 0x00234DDC
		// (set) Token: 0x06008592 RID: 34194 RVA: 0x0003F5A5 File Offset: 0x0003D7A5
		public unsafe ParticleSystem AntiGravParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AntiGravParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x00236C0C File Offset: 0x00234E0C
		// (set) Token: 0x06008594 RID: 34196 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
		public unsafe ParticleSystem FireParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x00236C3C File Offset: 0x00234E3C
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x0003F5E3 File Offset: 0x0003D7E3
		public unsafe OptimizedLight FireLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x00236C6C File Offset: 0x00234E6C
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x0003F602 File Offset: 0x0003D802
		public unsafe ParticleSystem FoggyEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FoggyEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x00236C9C File Offset: 0x00234E9C
		// (set) Token: 0x0600859A RID: 34202 RVA: 0x0003F621 File Offset: 0x0003D821
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x00236CCC File Offset: 0x00234ECC
		// (set) Token: 0x0600859C RID: 34204 RVA: 0x0003F640 File Offset: 0x0003D840
		public unsafe Transform NeckBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600859D RID: 34205 RVA: 0x00236CFC File Offset: 0x00234EFC
		// (set) Token: 0x0600859E RID: 34206 RVA: 0x0003F65F File Offset: 0x0003D85F
		public unsafe Il2CppReferenceArray<AvatarEffects> MirrorEffectsTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarEffects>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_MirrorEffectsTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600859F RID: 34207 RVA: 0x00236D2C File Offset: 0x00234F2C
		// (set) Token: 0x060085A0 RID: 34208 RVA: 0x0003F67E File Offset: 0x0003D87E
		public unsafe ParticleSystem ZapParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00236D5C File Offset: 0x00234F5C
		// (set) Token: 0x060085A2 RID: 34210 RVA: 0x0003F69D File Offset: 0x0003D89D
		public unsafe CountdownExplosion CountdownExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_CountdownExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x060085A3 RID: 34211 RVA: 0x00236D8C File Offset: 0x00234F8C
		// (set) Token: 0x060085A4 RID: 34212 RVA: 0x0003F6BC File Offset: 0x0003D8BC
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x00236DBC File Offset: 0x00234FBC
		// (set) Token: 0x060085A6 RID: 34214 RVA: 0x0003F6DB File Offset: 0x0003D8DB
		public unsafe bool DisableHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_DisableHead)) = value;
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x00236DE4 File Offset: 0x00234FE4
		// (set) Token: 0x060085A8 RID: 34216 RVA: 0x0003F6F6 File Offset: 0x0003D8F6
		public unsafe AudioSourceController GurgleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_GurgleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x00236E14 File Offset: 0x00235014
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x0003F715 File Offset: 0x0003D915
		public unsafe AudioSourceController VomitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_VomitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x00236E44 File Offset: 0x00235044
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x0003F734 File Offset: 0x0003D934
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x00236E74 File Offset: 0x00235074
		// (set) Token: 0x060085AE RID: 34222 RVA: 0x0003F753 File Offset: 0x0003D953
		public unsafe AudioSourceController FartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x060085AF RID: 34223 RVA: 0x00236EA4 File Offset: 0x002350A4
		// (set) Token: 0x060085B0 RID: 34224 RVA: 0x0003F772 File Offset: 0x0003D972
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x060085B1 RID: 34225 RVA: 0x00236ED4 File Offset: 0x002350D4
		// (set) Token: 0x060085B2 RID: 34226 RVA: 0x0003F791 File Offset: 0x0003D991
		public unsafe AudioSourceController ZapSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x060085B3 RID: 34227 RVA: 0x00236F04 File Offset: 0x00235104
		// (set) Token: 0x060085B4 RID: 34228 RVA: 0x0003F7B0 File Offset: 0x0003D9B0
		public unsafe AudioSourceController ZapLoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_ZapLoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x060085B5 RID: 34229 RVA: 0x00236F34 File Offset: 0x00235134
		// (set) Token: 0x060085B6 RID: 34230 RVA: 0x0003F7CF File Offset: 0x0003D9CF
		public unsafe FloatSmoother AdditionalWeightController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x060085B7 RID: 34231 RVA: 0x00236F64 File Offset: 0x00235164
		// (set) Token: 0x060085B8 RID: 34232 RVA: 0x0003F7EE File Offset: 0x0003D9EE
		public unsafe FloatSmoother AdditionalGenderController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_AdditionalGenderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x060085B9 RID: 34233 RVA: 0x00236F94 File Offset: 0x00235194
		// (set) Token: 0x060085BA RID: 34234 RVA: 0x0003F80D File Offset: 0x0003DA0D
		public unsafe FloatSmoother HeadSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_HeadSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x00236FC4 File Offset: 0x002351C4
		// (set) Token: 0x060085BC RID: 34236 RVA: 0x0003F82C File Offset: 0x0003DA2C
		public unsafe FloatSmoother NeckSizeBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_NeckSizeBoost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x060085BD RID: 34237 RVA: 0x00236FF4 File Offset: 0x002351F4
		// (set) Token: 0x060085BE RID: 34238 RVA: 0x0003F84B File Offset: 0x0003DA4B
		public unsafe ColorSmoother SkinColorSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_SkinColorSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x00237024 File Offset: 0x00235224
		// (set) Token: 0x060085C0 RID: 34240 RVA: 0x0003F86A File Offset: 0x0003DA6A
		public unsafe bool laxativeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_laxativeEnabled)) = value;
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x060085C1 RID: 34241 RVA: 0x0023704C File Offset: 0x0023524C
		// (set) Token: 0x060085C2 RID: 34242 RVA: 0x0003F885 File Offset: 0x0003DA85
		public unsafe Color currentEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_currentEmission)) = value;
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x00237074 File Offset: 0x00235274
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		public unsafe Color targetEmission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_targetEmission)) = value;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x060085C5 RID: 34245 RVA: 0x0023709C File Offset: 0x0023529C
		// (set) Token: 0x060085C6 RID: 34246 RVA: 0x0003F8BB File Offset: 0x0003DABB
		public unsafe bool isCulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.NativeFieldInfoPtr_isCulled)) = value;
			}
		}

		// Token: 0x04005ACF RID: 23247
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005AD0 RID: 23248
		private static readonly IntPtr NativeFieldInfoPtr_StinkParticles;

		// Token: 0x04005AD1 RID: 23249
		private static readonly IntPtr NativeFieldInfoPtr_VomitParticles;

		// Token: 0x04005AD2 RID: 23250
		private static readonly IntPtr NativeFieldInfoPtr_HeadPoofParticles;

		// Token: 0x04005AD3 RID: 23251
		private static readonly IntPtr NativeFieldInfoPtr_FartParticles;

		// Token: 0x04005AD4 RID: 23252
		private static readonly IntPtr NativeFieldInfoPtr_AntiGravParticles;

		// Token: 0x04005AD5 RID: 23253
		private static readonly IntPtr NativeFieldInfoPtr_FireParticles;

		// Token: 0x04005AD6 RID: 23254
		private static readonly IntPtr NativeFieldInfoPtr_FireLight;

		// Token: 0x04005AD7 RID: 23255
		private static readonly IntPtr NativeFieldInfoPtr_FoggyEffects;

		// Token: 0x04005AD8 RID: 23256
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005AD9 RID: 23257
		private static readonly IntPtr NativeFieldInfoPtr_NeckBone;

		// Token: 0x04005ADA RID: 23258
		private static readonly IntPtr NativeFieldInfoPtr_MirrorEffectsTo;

		// Token: 0x04005ADB RID: 23259
		private static readonly IntPtr NativeFieldInfoPtr_ZapParticles;

		// Token: 0x04005ADC RID: 23260
		private static readonly IntPtr NativeFieldInfoPtr_CountdownExplosion;

		// Token: 0x04005ADD RID: 23261
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04005ADE RID: 23262
		private static readonly IntPtr NativeFieldInfoPtr_DisableHead;

		// Token: 0x04005ADF RID: 23263
		private static readonly IntPtr NativeFieldInfoPtr_GurgleSound;

		// Token: 0x04005AE0 RID: 23264
		private static readonly IntPtr NativeFieldInfoPtr_VomitSound;

		// Token: 0x04005AE1 RID: 23265
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04005AE2 RID: 23266
		private static readonly IntPtr NativeFieldInfoPtr_FartSound;

		// Token: 0x04005AE3 RID: 23267
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005AE4 RID: 23268
		private static readonly IntPtr NativeFieldInfoPtr_ZapSound;

		// Token: 0x04005AE5 RID: 23269
		private static readonly IntPtr NativeFieldInfoPtr_ZapLoopSound;

		// Token: 0x04005AE6 RID: 23270
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalWeightController;

		// Token: 0x04005AE7 RID: 23271
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalGenderController;

		// Token: 0x04005AE8 RID: 23272
		private static readonly IntPtr NativeFieldInfoPtr_HeadSizeBoost;

		// Token: 0x04005AE9 RID: 23273
		private static readonly IntPtr NativeFieldInfoPtr_NeckSizeBoost;

		// Token: 0x04005AEA RID: 23274
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorSmoother;

		// Token: 0x04005AEB RID: 23275
		private static readonly IntPtr NativeFieldInfoPtr_laxativeEnabled;

		// Token: 0x04005AEC RID: 23276
		private static readonly IntPtr NativeFieldInfoPtr_currentEmission;

		// Token: 0x04005AED RID: 23277
		private static readonly IntPtr NativeFieldInfoPtr_targetEmission;

		// Token: 0x04005AEE RID: 23278
		private static readonly IntPtr NativeFieldInfoPtr_isCulled;

		// Token: 0x04005AEF RID: 23279
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005AF0 RID: 23280
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04005AF1 RID: 23281
		private static readonly IntPtr NativeMethodInfoPtr_SetEffectsCulled_Private_Void_Boolean_0;

		// Token: 0x04005AF2 RID: 23282
		private static readonly IntPtr NativeMethodInfoPtr_SetStinkParticlesActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF3 RID: 23283
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSick_Public_Void_Boolean_0;

		// Token: 0x04005AF4 RID: 23284
		private static readonly IntPtr NativeMethodInfoPtr_SetAntiGrav_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF5 RID: 23285
		private static readonly IntPtr NativeMethodInfoPtr_SetFoggy_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF6 RID: 23286
		private static readonly IntPtr NativeMethodInfoPtr_VanishHair_Public_Void_Boolean_0;

		// Token: 0x04005AF7 RID: 23287
		private static readonly IntPtr NativeMethodInfoPtr_SetZapped_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005AF8 RID: 23288
		private static readonly IntPtr NativeMethodInfoPtr_ReturnHair_Public_Void_Boolean_0;

		// Token: 0x04005AF9 RID: 23289
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_Boolean_0;

		// Token: 0x04005AFA RID: 23290
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_Boolean_0;

		// Token: 0x04005AFB RID: 23291
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005AFC RID: 23292
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeColor_Public_Void_Boolean_0;

		// Token: 0x04005AFD RID: 23293
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeLightEmission_Public_Void_Single_Color_Boolean_0;

		// Token: 0x04005AFE RID: 23294
		private static readonly IntPtr NativeMethodInfoPtr_EnableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005AFF RID: 23295
		private static readonly IntPtr NativeMethodInfoPtr_DisableLaxative_Public_Void_Boolean_0;

		// Token: 0x04005B00 RID: 23296
		private static readonly IntPtr NativeMethodInfoPtr_SetFireActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B01 RID: 23297
		private static readonly IntPtr NativeMethodInfoPtr_SetBigHeadActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B02 RID: 23298
		private static readonly IntPtr NativeMethodInfoPtr_SetGiraffeActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B03 RID: 23299
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColorInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B04 RID: 23300
		private static readonly IntPtr NativeMethodInfoPtr_SetSicklySkinColor_Public_Void_Boolean_0;

		// Token: 0x04005B05 RID: 23301
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultSkinColor_Private_Void_Boolean_0;

		// Token: 0x04005B06 RID: 23302
		private static readonly IntPtr NativeMethodInfoPtr_SetGenderInverted_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B07 RID: 23303
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalWeightOverride_Public_Void_Single_Int32_String_Boolean_0;

		// Token: 0x04005B08 RID: 23304
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAdditionalWeightOverride_Public_Void_String_Boolean_0;

		// Token: 0x04005B09 RID: 23305
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOn_Public_Void_Color_Boolean_0;

		// Token: 0x04005B0A RID: 23306
		private static readonly IntPtr NativeMethodInfoPtr_SetGlowingOff_Public_Void_Boolean_0;

		// Token: 0x04005B0B RID: 23307
		private static readonly IntPtr NativeMethodInfoPtr_TriggerCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005B0C RID: 23308
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdownExplosion_Public_Void_Boolean_0;

		// Token: 0x04005B0D RID: 23309
		private static readonly IntPtr NativeMethodInfoPtr_SetCyclopean_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B0E RID: 23310
		private static readonly IntPtr NativeMethodInfoPtr_SetZombified_Public_Void_Boolean_Boolean_0;

		// Token: 0x04005B0F RID: 23311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005B10 RID: 23312
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Void_0;

		// Token: 0x04005B11 RID: 23313
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005B12 RID: 23314
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000AEB RID: 2795
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<EnableLaxative>g__Routine|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D579 RID: 54649 RVA: 0x0032E22C File Offset: 0x0032C42C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<EnableLaxative>g__Routine|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100679999);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680000);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680001);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680002);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680003);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr, 100680004);
			}

			// Token: 0x0600D57A RID: 54650 RVA: 0x0032E30C File Offset: 0x0032C50C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D57B RID: 54651 RVA: 0x0032E354 File Offset: 0x0032C554
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D57C RID: 54652 RVA: 0x0032E388 File Offset: 0x0032C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250247, XrefRangeEnd = 250255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004228 RID: 16936
			// (get) Token: 0x0600D57D RID: 54653 RVA: 0x0032E3C4 File Offset: 0x0032C5C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D57E RID: 54654 RVA: 0x0032E404 File Offset: 0x0032C604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250255, XrefRangeEnd = 250260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004229 RID: 16937
			// (get) Token: 0x0600D57F RID: 54655 RVA: 0x0032E438 File Offset: 0x0032C638
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D580 RID: 54656 RVA: 0x00067DA3 File Offset: 0x00065FA3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004225 RID: 16933
			// (get) Token: 0x0600D581 RID: 54657 RVA: 0x0032E478 File Offset: 0x0032C678
			// (set) Token: 0x0600D582 RID: 54658 RVA: 0x00067DAC File Offset: 0x00065FAC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004226 RID: 16934
			// (get) Token: 0x0600D583 RID: 54659 RVA: 0x0032E4A0 File Offset: 0x0032C6A0
			// (set) Token: 0x0600D584 RID: 54660 RVA: 0x00067DC7 File Offset: 0x00065FC7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004227 RID: 16935
			// (get) Token: 0x0600D585 RID: 54661 RVA: 0x0032E4D0 File Offset: 0x0032C6D0
			// (set) Token: 0x0600D586 RID: 54662 RVA: 0x00067DE6 File Offset: 0x00065FE6
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F9B RID: 36763
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F9C RID: 36764
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F9D RID: 36765
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F9E RID: 36766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F9F RID: 36767
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FA0 RID: 36768
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FA1 RID: 36769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FA2 RID: 36770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FA3 RID: 36771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AEC RID: 2796
		[ObfuscatedName("ScheduleOne.AvatarFramework.AvatarEffects+<<TriggerSick>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D587 RID: 54663 RVA: 0x0032E500 File Offset: 0x0032C700
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEffects>.NativeClassPtr, "<<TriggerSick>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680005);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680006);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680007);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680008);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680009);
				AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr, 100680010);
			}

			// Token: 0x0600D588 RID: 54664 RVA: 0x0032E5E0 File Offset: 0x0032C7E0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D589 RID: 54665 RVA: 0x0032E628 File Offset: 0x0032C828
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D58A RID: 54666 RVA: 0x0032E65C File Offset: 0x0032C85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250260, XrefRangeEnd = 250266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700422D RID: 16941
			// (get) Token: 0x0600D58B RID: 54667 RVA: 0x0032E698 File Offset: 0x0032C898
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D58C RID: 54668 RVA: 0x0032E6D8 File Offset: 0x0032C8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250266, XrefRangeEnd = 250271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700422E RID: 16942
			// (get) Token: 0x0600D58D RID: 54669 RVA: 0x0032E70C File Offset: 0x0032C90C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D58E RID: 54670 RVA: 0x00067E05 File Offset: 0x00066005
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0600D58F RID: 54671 RVA: 0x0032E74C File Offset: 0x0032C94C
			// (set) Token: 0x0600D590 RID: 54672 RVA: 0x00067E0E File Offset: 0x0006600E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0600D591 RID: 54673 RVA: 0x0032E774 File Offset: 0x0032C974
			// (set) Token: 0x0600D592 RID: 54674 RVA: 0x00067E29 File Offset: 0x00066029
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422C RID: 16940
			// (get) Token: 0x0600D593 RID: 54675 RVA: 0x0032E7A4 File Offset: 0x0032C9A4
			// (set) Token: 0x0600D594 RID: 54676 RVA: 0x00067E48 File Offset: 0x00066048
			public unsafe AvatarEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEffects.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FA4 RID: 36772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FA5 RID: 36773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FA6 RID: 36774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FA7 RID: 36775
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FA8 RID: 36776
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FA9 RID: 36777
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FAA RID: 36778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FAB RID: 36779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FAC RID: 36780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
