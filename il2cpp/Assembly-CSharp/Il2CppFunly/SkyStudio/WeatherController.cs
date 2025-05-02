using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012E RID: 302
	public class WeatherController : MonoBehaviour
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x000C1298 File Offset: 0x000BF498
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherController()
		{
			Il2CppClassPointerStore<WeatherController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherController>.NativeClassPtr);
			WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<rainDownfallController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<rainSplashController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<lightningController>k__BackingField");
			WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "<weatherDepthCamera>k__BackingField");
			WeatherController.NativeFieldInfoPtr_m_Enclosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_Enclosure");
			WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_EnclosureMeshRenderer");
			WeatherController.NativeFieldInfoPtr_detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "detector");
			WeatherController.NativeFieldInfoPtr_m_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_Profile");
			WeatherController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, "m_TimeOfDay");
			WeatherController.NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666034);
			WeatherController.NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666035);
			WeatherController.NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666036);
			WeatherController.NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666037);
			WeatherController.NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666038);
			WeatherController.NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666039);
			WeatherController.NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666040);
			WeatherController.NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666041);
			WeatherController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666042);
			WeatherController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666043);
			WeatherController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666044);
			WeatherController.NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666045);
			WeatherController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666046);
			WeatherController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666047);
			WeatherController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666048);
			WeatherController.NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666049);
			WeatherController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherController>.NativeClassPtr, 100666050);
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000C14D0 File Offset: 0x000BF6D0
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x000C1510 File Offset: 0x000BF710
		public unsafe RainDownfallController rainDownfallController
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000C1554 File Offset: 0x000BF754
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x000C1594 File Offset: 0x000BF794
		public unsafe RainSplashController rainSplashController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RainSplashController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x000C15D8 File Offset: 0x000BF7D8
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x000C1618 File Offset: 0x000BF818
		public unsafe LightningController lightningController
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightningController>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000C165C File Offset: 0x000BF85C
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x000C169C File Offset: 0x000BF89C
		public unsafe WeatherDepthCamera weatherDepthCamera
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000C16E0 File Offset: 0x000BF8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96721, XrefRangeEnd = 96722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000C1714 File Offset: 0x000BF914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000C1748 File Offset: 0x000BF948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96722, XrefRangeEnd = 96749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000C177C File Offset: 0x000BF97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96769, RefRangeEnd = 96772, XrefRangeStart = 96749, XrefRangeEnd = 96769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscoverWeatherControllers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x000C17B0 File Offset: 0x000BF9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96772, XrefRangeEnd = 96789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000C17E4 File Offset: 0x000BF9E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96813, RefRangeEnd = 96815, XrefRangeStart = 96789, XrefRangeEnd = 96813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000C1834 File Offset: 0x000BFA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96815, XrefRangeEnd = 96829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000C1868 File Offset: 0x000BFA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96829, XrefRangeEnd = 96841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnclosureDidChange(WeatherEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000C18AC File Offset: 0x000BFAAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0000EB17 File Offset: 0x0000CD17
		public WeatherController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000C18E8 File Offset: 0x000BFAE8
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public unsafe RainDownfallController _rainDownfallController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainDownfallController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainDownfallController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x000C1918 File Offset: 0x000BFB18
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0000EB3F File Offset: 0x0000CD3F
		public unsafe RainSplashController _rainSplashController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainSplashController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__rainSplashController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x000C1948 File Offset: 0x000BFB48
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0000EB5E File Offset: 0x0000CD5E
		public unsafe LightningController _lightningController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__lightningController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000C1978 File Offset: 0x000BFB78
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0000EB7D File Offset: 0x0000CD7D
		public unsafe WeatherDepthCamera _weatherDepthCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr__weatherDepthCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000C19A8 File Offset: 0x000BFBA8
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		public unsafe WeatherEnclosure m_Enclosure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Enclosure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Enclosure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000C19D8 File Offset: 0x000BFBD8
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0000EBBB File Offset: 0x0000CDBB
		public unsafe MeshRenderer m_EnclosureMeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_EnclosureMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000C1A08 File Offset: 0x000BFC08
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0000EBDA File Offset: 0x0000CDDA
		public unsafe WeatherEnclosureDetector detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherEnclosureDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000C1A38 File Offset: 0x000BFC38
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0000EBF9 File Offset: 0x0000CDF9
		public unsafe SkyProfile m_Profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_Profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x000C1A68 File Offset: 0x000BFC68
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0000EC18 File Offset: 0x0000CE18
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr__rainDownfallController_k__BackingField;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr__rainSplashController_k__BackingField;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr__lightningController_k__BackingField;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr__weatherDepthCamera_k__BackingField;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_m_Enclosure;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr_m_EnclosureMeshRenderer;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr_detector;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_m_Profile;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_get_rainDownfallController_Public_get_RainDownfallController_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_set_rainDownfallController_Protected_set_Void_RainDownfallController_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_get_rainSplashController_Public_get_RainSplashController_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_set_rainSplashController_Protected_set_Void_RainSplashController_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_get_lightningController_Public_get_LightningController_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_set_lightningController_Protected_set_Void_LightningController_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_get_weatherDepthCamera_Public_get_WeatherDepthCamera_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_set_weatherDepthCamera_Protected_set_Void_WeatherDepthCamera_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_DiscoverWeatherControllers_Private_Void_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_OnEnclosureDidChange_Private_Void_WeatherEnclosure_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
