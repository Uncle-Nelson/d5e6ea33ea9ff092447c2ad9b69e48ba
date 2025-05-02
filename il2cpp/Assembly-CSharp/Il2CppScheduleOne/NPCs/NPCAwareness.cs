using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D6 RID: 726
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x06003426 RID: 13350 RVA: 0x00117A00 File Offset: 0x00115C00
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAwareness()
		{
			Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAwareness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr);
			NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "PLAYER_AIM_DETECTION_RANGE");
			NPCAwareness.NativeFieldInfoPtr_VisionCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "VisionCone");
			NPCAwareness.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Listener");
			NPCAwareness.NativeFieldInfoPtr_Responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Responses");
			NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedGeneralCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPettyCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedDrugDealing");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPlayerViolatingCurfew");
			NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedSuspiciousPlayer");
			NPCAwareness.NativeFieldInfoPtr_onGunshotHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onGunshotHeard");
			NPCAwareness.NativeFieldInfoPtr_onExplosionHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onExplosionHeard");
			NPCAwareness.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onHitByCar");
			NPCAwareness.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "npc");
			NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669183);
			NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669184);
			NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669185);
			NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669186);
			NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669187);
			NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669188);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00117BAC File Offset: 0x00115DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134928, XrefRangeEnd = 134969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00117BE8 File Offset: 0x00115DE8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134973, RefRangeEnd = 134982, XrefRangeStart = 134969, XrefRangeEnd = 134973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAwarenessActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00117C28 File Offset: 0x00115E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134982, XrefRangeEnd = 134995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisionEvent(VisionEventReceipt vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00117C6C File Offset: 0x00115E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134995, XrefRangeEnd = 135008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoiseEvent(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00117CB0 File Offset: 0x00115EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135008, XrefRangeEnd = 135015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00117CF4 File Offset: 0x00115EF4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAwareness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x0001B8A7 File Offset: 0x00019AA7
		public NPCAwareness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x00117D30 File Offset: 0x00115F30
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		public unsafe static float PLAYER_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x00117D4C File Offset: 0x00115F4C
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x0001B8BE File Offset: 0x00019ABE
		public unsafe VisionCone VisionCone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x00117D7C File Offset: 0x00115F7C
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x0001B8DD File Offset: 0x00019ADD
		public unsafe Listener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x00117DAC File Offset: 0x00115FAC
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x0001B8FC File Offset: 0x00019AFC
		public unsafe NPCResponses Responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00117DDC File Offset: 0x00115FDC
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x0001B91B File Offset: 0x00019B1B
		public unsafe UnityEvent<Player> onNoticedGeneralCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x00117E0C File Offset: 0x0011600C
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x0001B93A File Offset: 0x00019B3A
		public unsafe UnityEvent<Player> onNoticedPettyCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x00117E3C File Offset: 0x0011603C
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x0001B959 File Offset: 0x00019B59
		public unsafe UnityEvent<Player> onNoticedDrugDealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x00117E6C File Offset: 0x0011606C
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x0001B978 File Offset: 0x00019B78
		public unsafe UnityEvent<Player> onNoticedPlayerViolatingCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x00117E9C File Offset: 0x0011609C
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x0001B997 File Offset: 0x00019B97
		public unsafe UnityEvent<Player> onNoticedSuspiciousPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x00117ECC File Offset: 0x001160CC
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x0001B9B6 File Offset: 0x00019BB6
		public unsafe UnityEvent<NoiseEvent> onGunshotHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x00117EFC File Offset: 0x001160FC
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x0001B9D5 File Offset: 0x00019BD5
		public unsafe UnityEvent<NoiseEvent> onExplosionHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x00117F2C File Offset: 0x0011612C
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x00117F5C File Offset: 0x0011615C
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x0001BA13 File Offset: 0x00019C13
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeFieldInfoPtr_VisionCone;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeFieldInfoPtr_Responses;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedGeneralCrime;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPettyCrime;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedDrugDealing;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedSuspiciousPlayer;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeFieldInfoPtr_onGunshotHeard;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeFieldInfoPtr_onExplosionHeard;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
