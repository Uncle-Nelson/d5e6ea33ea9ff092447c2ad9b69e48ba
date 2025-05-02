using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000532 RID: 1330
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x0600768F RID: 30351 RVA: 0x00203990 File Offset: 0x00201B90
		// Note: this type is marked as 'beforefieldinit'.
		static CombatNPCDetector()
		{
			Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CombatNPCDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr);
			CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "DetectOnlyInCombat");
			CombatNPCDetector.NativeFieldInfoPtr_onDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "onDetected");
			CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "ContactTimeForDetection");
			CombatNPCDetector.NativeFieldInfoPtr_contactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "contactTime");
			CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "timeSinceLastContact");
			CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678233);
			CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678234);
			CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678235);
			CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678236);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00203A74 File Offset: 0x00201C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231133, XrefRangeEnd = 231146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00203AA8 File Offset: 0x00201CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231146, XrefRangeEnd = 231150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00203ADC File Offset: 0x00201CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231150, XrefRangeEnd = 231164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00203B20 File Offset: 0x00201D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231164, XrefRangeEnd = 231165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatNPCDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x000382B9 File Offset: 0x000364B9
		public CombatNPCDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x00203B5C File Offset: 0x00201D5C
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x000382C2 File Offset: 0x000364C2
		public unsafe bool DetectOnlyInCombat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat)) = value;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x00203B84 File Offset: 0x00201D84
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x000382DD File Offset: 0x000364DD
		public unsafe UnityEvent onDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x00203BB4 File Offset: 0x00201DB4
		// (set) Token: 0x0600769A RID: 30362 RVA: 0x000382FC File Offset: 0x000364FC
		public unsafe float ContactTimeForDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection)) = value;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x00203BDC File Offset: 0x00201DDC
		// (set) Token: 0x0600769C RID: 30364 RVA: 0x00038317 File Offset: 0x00036517
		public unsafe float contactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime)) = value;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600769D RID: 30365 RVA: 0x00203C04 File Offset: 0x00201E04
		// (set) Token: 0x0600769E RID: 30366 RVA: 0x00038332 File Offset: 0x00036532
		public unsafe float timeSinceLastContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact)) = value;
			}
		}

		// Token: 0x040050FC RID: 20732
		private static readonly IntPtr NativeFieldInfoPtr_DetectOnlyInCombat;

		// Token: 0x040050FD RID: 20733
		private static readonly IntPtr NativeFieldInfoPtr_onDetected;

		// Token: 0x040050FE RID: 20734
		private static readonly IntPtr NativeFieldInfoPtr_ContactTimeForDetection;

		// Token: 0x040050FF RID: 20735
		private static readonly IntPtr NativeFieldInfoPtr_contactTime;

		// Token: 0x04005100 RID: 20736
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastContact;

		// Token: 0x04005101 RID: 20737
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005102 RID: 20738
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04005103 RID: 20739
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04005104 RID: 20740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
