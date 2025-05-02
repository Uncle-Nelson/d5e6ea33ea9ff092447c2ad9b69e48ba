using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000547 RID: 1351
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x00206648 File Offset: 0x00204848
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDetector()
		{
			Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr);
			PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectPlayerInVehicle");
			PlayerDetector.NativeFieldInfoPtr_onPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_DetectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectedPlayers");
			PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			PlayerDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ignoreExit");
			PlayerDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "collidersEnabled");
			PlayerDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "detectionColliders");
			PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678348);
			PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678349);
			PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678350);
			PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678351);
			PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678352);
			PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678353);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678354);
			PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678355);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678356);
			PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678357);
			PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678358);
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x00206830 File Offset: 0x00204A30
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x0020686C File Offset: 0x00204A6C
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x002068AC File Offset: 0x00204AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231906, XrefRangeEnd = 231923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x002068E0 File Offset: 0x00204AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231923, XrefRangeEnd = 231941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00206914 File Offset: 0x00204B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231941, XrefRangeEnd = 231959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00206948 File Offset: 0x00204B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231959, XrefRangeEnd = 231975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x0020697C File Offset: 0x00204B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231975, XrefRangeEnd = 232028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x002069C0 File Offset: 0x00204BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232028, XrefRangeEnd = 232041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x002069F4 File Offset: 0x00204BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232094, RefRangeEnd = 232095, XrefRangeStart = 232041, XrefRangeEnd = 232094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00206A38 File Offset: 0x00204C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232102, RefRangeEnd = 232104, XrefRangeStart = 232095, XrefRangeEnd = 232102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00206A78 File Offset: 0x00204C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232104, XrefRangeEnd = 232112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x00038930 File Offset: 0x00036B30
		public PlayerDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x06007789 RID: 30601 RVA: 0x00206AB4 File Offset: 0x00204CB4
		// (set) Token: 0x0600778A RID: 30602 RVA: 0x00038939 File Offset: 0x00036B39
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600778B RID: 30603 RVA: 0x00206AD0 File Offset: 0x00204CD0
		// (set) Token: 0x0600778C RID: 30604 RVA: 0x00038947 File Offset: 0x00036B47
		public unsafe bool DetectPlayerInVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle)) = value;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x00206AF8 File Offset: 0x00204CF8
		// (set) Token: 0x0600778E RID: 30606 RVA: 0x00038962 File Offset: 0x00036B62
		public unsafe UnityEvent<Player> onPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x00206B28 File Offset: 0x00204D28
		// (set) Token: 0x06007790 RID: 30608 RVA: 0x00038981 File Offset: 0x00036B81
		public unsafe UnityEvent<Player> onPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x00206B58 File Offset: 0x00204D58
		// (set) Token: 0x06007792 RID: 30610 RVA: 0x000389A0 File Offset: 0x00036BA0
		public unsafe UnityEvent onLocalPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x00206B88 File Offset: 0x00204D88
		// (set) Token: 0x06007794 RID: 30612 RVA: 0x000389BF File Offset: 0x00036BBF
		public unsafe UnityEvent onLocalPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x00206BB8 File Offset: 0x00204DB8
		// (set) Token: 0x06007796 RID: 30614 RVA: 0x000389DE File Offset: 0x00036BDE
		public unsafe List<Player> DetectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x00206BE8 File Offset: 0x00204DE8
		// (set) Token: 0x06007798 RID: 30616 RVA: 0x000389FD File Offset: 0x00036BFD
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06007799 RID: 30617 RVA: 0x00206C10 File Offset: 0x00204E10
		// (set) Token: 0x0600779A RID: 30618 RVA: 0x00038A18 File Offset: 0x00036C18
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x00206C38 File Offset: 0x00204E38
		// (set) Token: 0x0600779C RID: 30620 RVA: 0x00038A33 File Offset: 0x00036C33
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x00206C60 File Offset: 0x00204E60
		// (set) Token: 0x0600779E RID: 30622 RVA: 0x00038A4E File Offset: 0x00036C4E
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400518B RID: 20875
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x0400518C RID: 20876
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerInVehicle;

		// Token: 0x0400518D RID: 20877
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnter;

		// Token: 0x0400518E RID: 20878
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExit;

		// Token: 0x0400518F RID: 20879
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerEnter;

		// Token: 0x04005190 RID: 20880
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExit;

		// Token: 0x04005191 RID: 20881
		private static readonly IntPtr NativeFieldInfoPtr_DetectedPlayers;

		// Token: 0x04005192 RID: 20882
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x04005193 RID: 20883
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x04005194 RID: 20884
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005195 RID: 20885
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x04005196 RID: 20886
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x04005197 RID: 20887
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x04005198 RID: 20888
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005199 RID: 20889
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400519A RID: 20890
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400519B RID: 20891
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400519C RID: 20892
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x0400519D RID: 20893
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400519E RID: 20894
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x0400519F RID: 20895
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x040051A0 RID: 20896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
