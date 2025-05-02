using System;
using Il2CppBeautify.Universal;
using Il2CppCorgiGodRays;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003FA RID: 1018
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x060054C4 RID: 21700 RVA: 0x0018CE1C File Offset: 0x0018B01C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingManager()
		{
			Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PostProcessingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr);
			PostProcessingManager.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GlobalVolume");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultIntensity");
			PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "Vig_DefaultSmoothness");
			PostProcessingManager.NativeFieldInfoPtr_MinBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MinBlur");
			PostProcessingManager.NativeFieldInfoPtr_MaxBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "MaxBlur");
			PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ChromaticAberrationController");
			PostProcessingManager.NativeFieldInfoPtr_SaturationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "SaturationController");
			PostProcessingManager.NativeFieldInfoPtr_BloomController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "BloomController");
			PostProcessingManager.NativeFieldInfoPtr_ColorFilterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorFilterController");
			PostProcessingManager.NativeFieldInfoPtr_vig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "vig");
			PostProcessingManager.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "DoF");
			PostProcessingManager.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "GodRays");
			PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "ColorAdjustments");
			PostProcessingManager.NativeFieldInfoPtr_beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "beautifySettings");
			PostProcessingManager.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "bloom");
			PostProcessingManager.NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "chromaticAberration");
			PostProcessingManager.NativeFieldInfoPtr_colorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, "colorAdjustments");
			PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673839);
			PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673840);
			PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673841);
			PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673842);
			PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673843);
			PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673844);
			PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673845);
			PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673846);
			PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673847);
			PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673848);
			PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr, 100673849);
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x0018D07C File Offset: 0x0018B27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180374, XrefRangeEnd = 180406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x0018D0B8 File Offset: 0x0018B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180406, XrefRangeEnd = 180407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x0018D0EC File Offset: 0x0018B2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180416, RefRangeEnd = 180417, XrefRangeStart = 180407, XrefRangeEnd = 180416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x0018D120 File Offset: 0x0018B320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180418, RefRangeEnd = 180419, XrefRangeStart = 180417, XrefRangeEnd = 180418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideVignette(float intensity, float smoothness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x0018D16C File Offset: 0x0018B36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180419, XrefRangeEnd = 180420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVignette()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_ResetVignette_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x0018D1A0 File Offset: 0x0018B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180420, XrefRangeEnd = 180421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGodRayIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x0018D1E0 File Offset: 0x0018B3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180421, XrefRangeEnd = 180422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContrast(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetContrast_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x0018D220 File Offset: 0x0018B420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180422, XrefRangeEnd = 180424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSaturation(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x0018D260 File Offset: 0x0018B460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180424, XrefRangeEnd = 180425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBloomThreshold(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x0018D2A0 File Offset: 0x0018B4A0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 180427, RefRangeEnd = 180436, XrefRangeStart = 180425, XrefRangeEnd = 180427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlur(float blurLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blurLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr_SetBlur_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x0018D2E0 File Offset: 0x0018B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180436, XrefRangeEnd = 180439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00028AC5 File Offset: 0x00026CC5
		public PostProcessingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x0018D31C File Offset: 0x0018B51C
		// (set) Token: 0x060054D2 RID: 21714 RVA: 0x00028ACE File Offset: 0x00026CCE
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x0018D34C File Offset: 0x0018B54C
		// (set) Token: 0x060054D4 RID: 21716 RVA: 0x00028AED File Offset: 0x00026CED
		public unsafe float Vig_DefaultIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultIntensity)) = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060054D5 RID: 21717 RVA: 0x0018D374 File Offset: 0x0018B574
		// (set) Token: 0x060054D6 RID: 21718 RVA: 0x00028B08 File Offset: 0x00026D08
		public unsafe float Vig_DefaultSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_Vig_DefaultSmoothness)) = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060054D7 RID: 21719 RVA: 0x0018D39C File Offset: 0x0018B59C
		// (set) Token: 0x060054D8 RID: 21720 RVA: 0x00028B23 File Offset: 0x00026D23
		public unsafe float MinBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MinBlur)) = value;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x0018D3C4 File Offset: 0x0018B5C4
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x00028B3E File Offset: 0x00026D3E
		public unsafe float MaxBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_MaxBlur)) = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x0018D3EC File Offset: 0x0018B5EC
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x00028B59 File Offset: 0x00026D59
		public unsafe FloatSmoother ChromaticAberrationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ChromaticAberrationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x0018D41C File Offset: 0x0018B61C
		// (set) Token: 0x060054DE RID: 21726 RVA: 0x00028B78 File Offset: 0x00026D78
		public unsafe FloatSmoother SaturationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_SaturationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x0018D44C File Offset: 0x0018B64C
		// (set) Token: 0x060054E0 RID: 21728 RVA: 0x00028B97 File Offset: 0x00026D97
		public unsafe FloatSmoother BloomController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_BloomController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x0018D47C File Offset: 0x0018B67C
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x00028BB6 File Offset: 0x00026DB6
		public unsafe HDRColorSmoother ColorFilterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorFilterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x0018D4AC File Offset: 0x0018B6AC
		// (set) Token: 0x060054E4 RID: 21732 RVA: 0x00028BD5 File Offset: 0x00026DD5
		public unsafe Vignette vig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vignette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_vig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060054E5 RID: 21733 RVA: 0x0018D4DC File Offset: 0x0018B6DC
		// (set) Token: 0x060054E6 RID: 21734 RVA: 0x00028BF4 File Offset: 0x00026DF4
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x0018D50C File Offset: 0x0018B70C
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x00028C13 File Offset: 0x00026E13
		public unsafe GodRaysVolume GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GodRaysVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x0018D53C File Offset: 0x0018B73C
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x00028C32 File Offset: 0x00026E32
		public unsafe ColorAdjustments ColorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_ColorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x0018D56C File Offset: 0x0018B76C
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x00028C51 File Offset: 0x00026E51
		public unsafe Beautify beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x0018D59C File Offset: 0x0018B79C
		// (set) Token: 0x060054EE RID: 21742 RVA: 0x00028C70 File Offset: 0x00026E70
		public unsafe Bloom bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bloom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x0018D5CC File Offset: 0x0018B7CC
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00028C8F File Offset: 0x00026E8F
		public unsafe ChromaticAberration chromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_chromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x0018D5FC File Offset: 0x0018B7FC
		// (set) Token: 0x060054F2 RID: 21746 RVA: 0x00028CAE File Offset: 0x00026EAE
		public unsafe ColorAdjustments colorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingManager.NativeFieldInfoPtr_colorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400395F RID: 14687
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003960 RID: 14688
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultIntensity;

		// Token: 0x04003961 RID: 14689
		private static readonly IntPtr NativeFieldInfoPtr_Vig_DefaultSmoothness;

		// Token: 0x04003962 RID: 14690
		private static readonly IntPtr NativeFieldInfoPtr_MinBlur;

		// Token: 0x04003963 RID: 14691
		private static readonly IntPtr NativeFieldInfoPtr_MaxBlur;

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberrationController;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeFieldInfoPtr_SaturationController;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeFieldInfoPtr_BloomController;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeFieldInfoPtr_ColorFilterController;

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeFieldInfoPtr_vig;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x0400396B RID: 14699
		private static readonly IntPtr NativeFieldInfoPtr_ColorAdjustments;

		// Token: 0x0400396C RID: 14700
		private static readonly IntPtr NativeFieldInfoPtr_beautifySettings;

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeFieldInfoPtr_bloom;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeFieldInfoPtr_chromaticAberration;

		// Token: 0x0400396F RID: 14703
		private static readonly IntPtr NativeFieldInfoPtr_colorAdjustments;

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeMethodInfoPtr_OverrideVignette_Public_Void_Single_Single_0;

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeMethodInfoPtr_ResetVignette_Public_Void_0;

		// Token: 0x04003975 RID: 14709
		private static readonly IntPtr NativeMethodInfoPtr_SetGodRayIntensity_Public_Void_Single_0;

		// Token: 0x04003976 RID: 14710
		private static readonly IntPtr NativeMethodInfoPtr_SetContrast_Public_Void_Single_0;

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeMethodInfoPtr_SetSaturation_Public_Void_Single_0;

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeMethodInfoPtr_SetBloomThreshold_Public_Void_Single_0;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeMethodInfoPtr_SetBlur_Public_Void_Single_0;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
