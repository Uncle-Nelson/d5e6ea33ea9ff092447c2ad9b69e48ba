using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Lighting;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x0200078A RID: 1930
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x0600B6B8 RID: 46776 RVA: 0x002D5B7C File Offset: 0x002D3D7C
		// Note: this type is marked as 'beforefieldinit'.
		static StreetLight()
		{
			Il2CppClassPointerStore<StreetLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "StreetLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetLight>.NativeClassPtr);
			StreetLight.NativeFieldInfoPtr_POWER_ORIGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "POWER_ORIGIN");
			StreetLight.NativeFieldInfoPtr_LightRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightRend");
			StreetLight.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "Light");
			StreetLight.NativeFieldInfoPtr_BeamTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "BeamTracker");
			StreetLight.NativeFieldInfoPtr_LightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOnMat");
			StreetLight.NativeFieldInfoPtr_LightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOffMat");
			StreetLight.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTime");
			StreetLight.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "EndTime");
			StreetLight.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTimeOffset");
			StreetLight.NativeFieldInfoPtr_ShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "ShadowsEnabled");
			StreetLight.NativeFieldInfoPtr_LightMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightMaxDistance");
			StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "SoftShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_HardShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "HardShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "isOn");
			StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685756);
			StreetLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685757);
			StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685758);
			StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685759);
			StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685760);
			StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685761);
			StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685762);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002D5D50 File Offset: 0x002D3F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311884, XrefRangeEnd = 311912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002D5D8C File Offset: 0x002D3F8C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x002D5DC0 File Offset: 0x002D3FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311912, XrefRangeEnd = 311924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x002D5DFC File Offset: 0x002D3FFC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x002D5E30 File Offset: 0x002D4030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311952, RefRangeEnd = 311953, XrefRangeStart = 311924, XrefRangeEnd = 311952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x002D5E70 File Offset: 0x002D4070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311972, RefRangeEnd = 311973, XrefRangeStart = 311953, XrefRangeEnd = 311972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShadows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x002D5EA4 File Offset: 0x002D40A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311973, XrefRangeEnd = 311974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x00059BC4 File Offset: 0x00057DC4
		public StreetLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002D5EE0 File Offset: 0x002D40E0
		// (set) Token: 0x0600B6C2 RID: 46786 RVA: 0x00059BCD File Offset: 0x00057DCD
		public unsafe static Vector3 POWER_ORIGIN
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&value));
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600B6C3 RID: 46787 RVA: 0x002D5EFC File Offset: 0x002D40FC
		// (set) Token: 0x0600B6C4 RID: 46788 RVA: 0x00059BDB File Offset: 0x00057DDB
		public unsafe MeshRenderer LightRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600B6C5 RID: 46789 RVA: 0x002D5F2C File Offset: 0x002D412C
		// (set) Token: 0x0600B6C6 RID: 46790 RVA: 0x00059BFA File Offset: 0x00057DFA
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600B6C7 RID: 46791 RVA: 0x002D5F5C File Offset: 0x002D415C
		// (set) Token: 0x0600B6C8 RID: 46792 RVA: 0x00059C19 File Offset: 0x00057E19
		public unsafe VolumetricLightTracker BeamTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600B6C9 RID: 46793 RVA: 0x002D5F8C File Offset: 0x002D418C
		// (set) Token: 0x0600B6CA RID: 46794 RVA: 0x00059C38 File Offset: 0x00057E38
		public unsafe Material LightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600B6CB RID: 46795 RVA: 0x002D5FBC File Offset: 0x002D41BC
		// (set) Token: 0x0600B6CC RID: 46796 RVA: 0x00059C57 File Offset: 0x00057E57
		public unsafe Material LightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600B6CD RID: 46797 RVA: 0x002D5FEC File Offset: 0x002D41EC
		// (set) Token: 0x0600B6CE RID: 46798 RVA: 0x00059C76 File Offset: 0x00057E76
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x002D6014 File Offset: 0x002D4214
		// (set) Token: 0x0600B6D0 RID: 46800 RVA: 0x00059C91 File Offset: 0x00057E91
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x002D603C File Offset: 0x002D423C
		// (set) Token: 0x0600B6D2 RID: 46802 RVA: 0x00059CAC File Offset: 0x00057EAC
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x002D6064 File Offset: 0x002D4264
		// (set) Token: 0x0600B6D4 RID: 46804 RVA: 0x00059CC7 File Offset: 0x00057EC7
		public unsafe bool ShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled)) = value;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002D608C File Offset: 0x002D428C
		// (set) Token: 0x0600B6D6 RID: 46806 RVA: 0x00059CE2 File Offset: 0x00057EE2
		public unsafe float LightMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance)) = value;
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600B6D7 RID: 46807 RVA: 0x002D60B4 File Offset: 0x002D42B4
		// (set) Token: 0x0600B6D8 RID: 46808 RVA: 0x00059CFD File Offset: 0x00057EFD
		public unsafe float SoftShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold)) = value;
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002D60DC File Offset: 0x002D42DC
		// (set) Token: 0x0600B6DA RID: 46810 RVA: 0x00059D18 File Offset: 0x00057F18
		public unsafe float HardShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold)) = value;
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x002D6104 File Offset: 0x002D4304
		// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x00059D33 File Offset: 0x00057F33
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007B13 RID: 31507
		private static readonly IntPtr NativeFieldInfoPtr_POWER_ORIGIN;

		// Token: 0x04007B14 RID: 31508
		private static readonly IntPtr NativeFieldInfoPtr_LightRend;

		// Token: 0x04007B15 RID: 31509
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007B16 RID: 31510
		private static readonly IntPtr NativeFieldInfoPtr_BeamTracker;

		// Token: 0x04007B17 RID: 31511
		private static readonly IntPtr NativeFieldInfoPtr_LightOnMat;

		// Token: 0x04007B18 RID: 31512
		private static readonly IntPtr NativeFieldInfoPtr_LightOffMat;

		// Token: 0x04007B19 RID: 31513
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04007B1A RID: 31514
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04007B1B RID: 31515
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x04007B1C RID: 31516
		private static readonly IntPtr NativeFieldInfoPtr_ShadowsEnabled;

		// Token: 0x04007B1D RID: 31517
		private static readonly IntPtr NativeFieldInfoPtr_LightMaxDistance;

		// Token: 0x04007B1E RID: 31518
		private static readonly IntPtr NativeFieldInfoPtr_SoftShadowsThreshold;

		// Token: 0x04007B1F RID: 31519
		private static readonly IntPtr NativeFieldInfoPtr_HardShadowsThreshold;

		// Token: 0x04007B20 RID: 31520
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x04007B21 RID: 31521
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007B22 RID: 31522
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007B23 RID: 31523
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x04007B24 RID: 31524
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007B25 RID: 31525
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x04007B26 RID: 31526
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShadows_Private_Void_0;

		// Token: 0x04007B27 RID: 31527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
