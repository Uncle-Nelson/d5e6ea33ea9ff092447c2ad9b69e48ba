using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000129 RID: 297
	public class RainDownfallController : MonoBehaviour
	{
		// Token: 0x06001969 RID: 6505 RVA: 0x000C0080 File Offset: 0x000BE280
		// Note: this type is marked as 'beforefieldinit'.
		static RainDownfallController()
		{
			Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainDownfallController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr);
			RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "rainMeshRenderer");
			RainDownfallController.NativeFieldInfoPtr_rainMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "rainMaterial");
			RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_PropertyBlock");
			RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_RainAudioSource");
			RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_TimeOfDay");
			RainDownfallController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, "m_SkyProfile");
			RainDownfallController.NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666005);
			RainDownfallController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666006);
			RainDownfallController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666007);
			RainDownfallController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr, 100666008);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000C0178 File Offset: 0x000BE378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96300, RefRangeEnd = 96301, XrefRangeStart = 96271, XrefRangeEnd = 96300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeatherEnclosure(WeatherEnclosure enclosure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enclosure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000C01BC File Offset: 0x000BE3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96301, XrefRangeEnd = 96306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000C01F0 File Offset: 0x000BE3F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96427, RefRangeEnd = 96430, XrefRangeStart = 96306, XrefRangeEnd = 96427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000C0240 File Offset: 0x000BE440
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainDownfallController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainDownfallController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainDownfallController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0000E79B File Offset: 0x0000C99B
		public RainDownfallController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000C027C File Offset: 0x000BE47C
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		public unsafe MeshRenderer rainMeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000C02AC File Offset: 0x000BE4AC
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000E7C3 File Offset: 0x0000C9C3
		public unsafe Material rainMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_rainMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000C02DC File Offset: 0x000BE4DC
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000E7E2 File Offset: 0x0000C9E2
		public unsafe MaterialPropertyBlock m_PropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_PropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x000C030C File Offset: 0x000BE50C
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000E801 File Offset: 0x0000CA01
		public unsafe AudioSource m_RainAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_RainAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000C033C File Offset: 0x000BE53C
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0000E820 File Offset: 0x0000CA20
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000C0364 File Offset: 0x000BE564
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000E83B File Offset: 0x0000CA3B
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainDownfallController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_rainMeshRenderer;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeFieldInfoPtr_rainMaterial;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyBlock;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr_m_RainAudioSource;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_SetWeatherEnclosure_Public_Void_WeatherEnclosure_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Virtual_Final_New_Void_SkyProfile_Single_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
