using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Sound
{
	// Token: 0x020004F5 RID: 1269
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x06007044 RID: 28740 RVA: 0x001EE338 File Offset: 0x001EC538
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSound()
		{
			Il2CppClassPointerStore<VehicleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Sound", "VehicleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr);
			VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "COLLISION_SOUND_COOLDOWN");
			VehicleSound.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "VolumeMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineStartSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineStartSource");
			VehicleSound.NativeFieldInfoPtr_EngineIdleSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineIdleSource");
			VehicleSound.NativeFieldInfoPtr_EngineLoopSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopSource");
			VehicleSound.NativeFieldInfoPtr_HandbrakeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HandbrakeSource");
			VehicleSound.NativeFieldInfoPtr_HonkSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HonkSource");
			VehicleSound.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "ImpactSound");
			VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MinCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MinCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchCurve");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopVolumeCurve");
			VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "<Vehicle>k__BackingField");
			VehicleSound.NativeFieldInfoPtr_currentIdleVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "currentIdleVolume");
			VehicleSound.NativeFieldInfoPtr_lastCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionTime");
			VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionMomentum");
			VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677427);
			VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677428);
			VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677429);
			VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677430);
			VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677431);
			VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677432);
			VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677433);
			VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677434);
			VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677435);
			VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677436);
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06007045 RID: 28741 RVA: 0x001EE5D4 File Offset: 0x001EC7D4
		// (set) Token: 0x06007046 RID: 28742 RVA: 0x001EE614 File Offset: 0x001EC814
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95750, RefRangeEnd = 95751, XrefRangeStart = 95750, XrefRangeEnd = 95751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x001EE658 File Offset: 0x001EC858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221660, XrefRangeEnd = 221690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x001EE694 File Offset: 0x001EC894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221690, XrefRangeEnd = 221691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x001EE6D0 File Offset: 0x001EC8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221704, RefRangeEnd = 221705, XrefRangeStart = 221691, XrefRangeEnd = 221704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x001EE704 File Offset: 0x001EC904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221705, XrefRangeEnd = 221706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandbrakeApplied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x001EE738 File Offset: 0x001EC938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221706, XrefRangeEnd = 221707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x001EE76C File Offset: 0x001EC96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221707, XrefRangeEnd = 221708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Honk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x001EE7A0 File Offset: 0x001EC9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221708, XrefRangeEnd = 221726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollision(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x001EE7E4 File Offset: 0x001EC9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221726, XrefRangeEnd = 221727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x000353C7 File Offset: 0x000335C7
		public VehicleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06007050 RID: 28752 RVA: 0x001EE820 File Offset: 0x001ECA20
		// (set) Token: 0x06007051 RID: 28753 RVA: 0x000353D0 File Offset: 0x000335D0
		public unsafe static float COLLISION_SOUND_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06007052 RID: 28754 RVA: 0x001EE83C File Offset: 0x001ECA3C
		// (set) Token: 0x06007053 RID: 28755 RVA: 0x000353DE File Offset: 0x000335DE
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x001EE864 File Offset: 0x001ECA64
		// (set) Token: 0x06007055 RID: 28757 RVA: 0x000353F9 File Offset: 0x000335F9
		public unsafe AudioSourceController EngineStartSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06007056 RID: 28758 RVA: 0x001EE894 File Offset: 0x001ECA94
		// (set) Token: 0x06007057 RID: 28759 RVA: 0x00035418 File Offset: 0x00033618
		public unsafe AudioSourceController EngineIdleSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06007058 RID: 28760 RVA: 0x001EE8C4 File Offset: 0x001ECAC4
		// (set) Token: 0x06007059 RID: 28761 RVA: 0x00035437 File Offset: 0x00033637
		public unsafe AudioSourceController EngineLoopSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600705A RID: 28762 RVA: 0x001EE8F4 File Offset: 0x001ECAF4
		// (set) Token: 0x0600705B RID: 28763 RVA: 0x00035456 File Offset: 0x00033656
		public unsafe AudioSourceController HandbrakeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x001EE924 File Offset: 0x001ECB24
		// (set) Token: 0x0600705D RID: 28765 RVA: 0x00035475 File Offset: 0x00033675
		public unsafe AudioSourceController HonkSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x001EE954 File Offset: 0x001ECB54
		// (set) Token: 0x0600705F RID: 28767 RVA: 0x00035494 File Offset: 0x00033694
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x001EE984 File Offset: 0x001ECB84
		// (set) Token: 0x06007061 RID: 28769 RVA: 0x000354B3 File Offset: 0x000336B3
		public unsafe float MinCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum)) = value;
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06007062 RID: 28770 RVA: 0x001EE9AC File Offset: 0x001ECBAC
		// (set) Token: 0x06007063 RID: 28771 RVA: 0x000354CE File Offset: 0x000336CE
		public unsafe float MaxCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum)) = value;
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x001EE9D4 File Offset: 0x001ECBD4
		// (set) Token: 0x06007065 RID: 28773 RVA: 0x000354E9 File Offset: 0x000336E9
		public unsafe float MinCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume)) = value;
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x001EE9FC File Offset: 0x001ECBFC
		// (set) Token: 0x06007067 RID: 28775 RVA: 0x00035504 File Offset: 0x00033704
		public unsafe float MaxCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume)) = value;
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06007068 RID: 28776 RVA: 0x001EEA24 File Offset: 0x001ECC24
		// (set) Token: 0x06007069 RID: 28777 RVA: 0x0003551F File Offset: 0x0003371F
		public unsafe float MinCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch)) = value;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x001EEA4C File Offset: 0x001ECC4C
		// (set) Token: 0x0600706B RID: 28779 RVA: 0x0003553A File Offset: 0x0003373A
		public unsafe float MaxCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch)) = value;
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600706C RID: 28780 RVA: 0x001EEA74 File Offset: 0x001ECC74
		// (set) Token: 0x0600706D RID: 28781 RVA: 0x00035555 File Offset: 0x00033755
		public unsafe AnimationCurve EngineLoopPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600706E RID: 28782 RVA: 0x001EEAA4 File Offset: 0x001ECCA4
		// (set) Token: 0x0600706F RID: 28783 RVA: 0x00035574 File Offset: 0x00033774
		public unsafe float EngineLoopPitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier)) = value;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06007070 RID: 28784 RVA: 0x001EEACC File Offset: 0x001ECCCC
		// (set) Token: 0x06007071 RID: 28785 RVA: 0x0003558F File Offset: 0x0003378F
		public unsafe AnimationCurve EngineLoopVolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06007072 RID: 28786 RVA: 0x001EEAFC File Offset: 0x001ECCFC
		// (set) Token: 0x06007073 RID: 28787 RVA: 0x000355AE File Offset: 0x000337AE
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06007074 RID: 28788 RVA: 0x001EEB2C File Offset: 0x001ECD2C
		// (set) Token: 0x06007075 RID: 28789 RVA: 0x000355CD File Offset: 0x000337CD
		public unsafe float currentIdleVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume)) = value;
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06007076 RID: 28790 RVA: 0x001EEB54 File Offset: 0x001ECD54
		// (set) Token: 0x06007077 RID: 28791 RVA: 0x000355E8 File Offset: 0x000337E8
		public unsafe float lastCollisionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime)) = value;
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x001EEB7C File Offset: 0x001ECD7C
		// (set) Token: 0x06007079 RID: 28793 RVA: 0x00035603 File Offset: 0x00033803
		public unsafe float lastCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum)) = value;
			}
		}

		// Token: 0x04004CB5 RID: 19637
		private static readonly IntPtr NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN;

		// Token: 0x04004CB6 RID: 19638
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004CB7 RID: 19639
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSource;

		// Token: 0x04004CB8 RID: 19640
		private static readonly IntPtr NativeFieldInfoPtr_EngineIdleSource;

		// Token: 0x04004CB9 RID: 19641
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopSource;

		// Token: 0x04004CBA RID: 19642
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSource;

		// Token: 0x04004CBB RID: 19643
		private static readonly IntPtr NativeFieldInfoPtr_HonkSource;

		// Token: 0x04004CBC RID: 19644
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x04004CBD RID: 19645
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionMomentum;

		// Token: 0x04004CBE RID: 19646
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionMomentum;

		// Token: 0x04004CBF RID: 19647
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionVolume;

		// Token: 0x04004CC0 RID: 19648
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionVolume;

		// Token: 0x04004CC1 RID: 19649
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionPitch;

		// Token: 0x04004CC2 RID: 19650
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionPitch;

		// Token: 0x04004CC3 RID: 19651
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchCurve;

		// Token: 0x04004CC4 RID: 19652
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchMultiplier;

		// Token: 0x04004CC5 RID: 19653
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopVolumeCurve;

		// Token: 0x04004CC6 RID: 19654
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x04004CC7 RID: 19655
		private static readonly IntPtr NativeFieldInfoPtr_currentIdleVolume;

		// Token: 0x04004CC8 RID: 19656
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionTime;

		// Token: 0x04004CC9 RID: 19657
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionMomentum;

		// Token: 0x04004CCA RID: 19658
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x04004CCB RID: 19659
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x04004CCC RID: 19660
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004CCD RID: 19661
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004CCE RID: 19662
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIdle_Private_Void_0;

		// Token: 0x04004CCF RID: 19663
		private static readonly IntPtr NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0;

		// Token: 0x04004CD0 RID: 19664
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Void_0;

		// Token: 0x04004CD1 RID: 19665
		private static readonly IntPtr NativeMethodInfoPtr_Honk_Public_Void_0;

		// Token: 0x04004CD2 RID: 19666
		private static readonly IntPtr NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0;

		// Token: 0x04004CD3 RID: 19667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
