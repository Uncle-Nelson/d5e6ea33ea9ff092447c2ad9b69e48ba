using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004AE RID: 1198
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x0600699C RID: 27036 RVA: 0x001D8EDC File Offset: 0x001D70DC
		// Note: this type is marked as 'beforefieldinit'.
		static PayPhone()
		{
			Il2CppClassPointerStore<PayPhone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "PayPhone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPhone>.NativeClassPtr);
			PayPhone.NativeFieldInfoPtr_RING_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_INTERVAL");
			PayPhone.NativeFieldInfoPtr_RING_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_RANGE");
			PayPhone.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "Light");
			PayPhone.NativeFieldInfoPtr_RingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RingSound");
			PayPhone.NativeFieldInfoPtr_AnswerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "AnswerSound");
			PayPhone.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "IntObj");
			PayPhone.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "CameraPosition");
			PayPhone.NativeFieldInfoPtr_timeSinceLastRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "timeSinceLastRing");
			PayPhone.NativeFieldInfoPtr_ringRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "ringRangeSquared");
			PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676714);
			PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676715);
			PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676716);
			PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676717);
			PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676718);
			PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676719);
			PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100676720);
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x0600699D RID: 27037 RVA: 0x001D904C File Offset: 0x001D724C
		public unsafe PhoneCallData QueuedCall
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 213157, RefRangeEnd = 213162, XrefRangeStart = 213153, XrefRangeEnd = 213157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x001D908C File Offset: 0x001D728C
		public unsafe PhoneCallData ActiveCall
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 213166, RefRangeEnd = 213169, XrefRangeStart = 213162, XrefRangeEnd = 213166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x001D90CC File Offset: 0x001D72CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213169, XrefRangeEnd = 213199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x001D9100 File Offset: 0x001D7300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213199, XrefRangeEnd = 213201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x001D9134 File Offset: 0x001D7334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213201, XrefRangeEnd = 213221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x001D9168 File Offset: 0x001D7368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213233, RefRangeEnd = 213235, XrefRangeStart = 213221, XrefRangeEnd = 213233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x001D91A4 File Offset: 0x001D73A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213235, XrefRangeEnd = 213236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayPhone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPhone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x00031E83 File Offset: 0x00030083
		public PayPhone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x001D91E0 File Offset: 0x001D73E0
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x00031E8C File Offset: 0x0003008C
		public unsafe static float RING_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x001D91FC File Offset: 0x001D73FC
		// (set) Token: 0x060069A8 RID: 27048 RVA: 0x00031E9A File Offset: 0x0003009A
		public unsafe static float RING_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x001D9218 File Offset: 0x001D7418
		// (set) Token: 0x060069AA RID: 27050 RVA: 0x00031EA8 File Offset: 0x000300A8
		public unsafe BlinkingLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x060069AB RID: 27051 RVA: 0x001D9248 File Offset: 0x001D7448
		// (set) Token: 0x060069AC RID: 27052 RVA: 0x00031EC7 File Offset: 0x000300C7
		public unsafe AudioSourceController RingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x060069AD RID: 27053 RVA: 0x001D9278 File Offset: 0x001D7478
		// (set) Token: 0x060069AE RID: 27054 RVA: 0x00031EE6 File Offset: 0x000300E6
		public unsafe AudioSourceController AnswerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x001D92A8 File Offset: 0x001D74A8
		// (set) Token: 0x060069B0 RID: 27056 RVA: 0x00031F05 File Offset: 0x00030105
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x001D92D8 File Offset: 0x001D74D8
		// (set) Token: 0x060069B2 RID: 27058 RVA: 0x00031F24 File Offset: 0x00030124
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x001D9308 File Offset: 0x001D7508
		// (set) Token: 0x060069B4 RID: 27060 RVA: 0x00031F43 File Offset: 0x00030143
		public unsafe float timeSinceLastRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing)) = value;
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x001D9330 File Offset: 0x001D7530
		// (set) Token: 0x060069B6 RID: 27062 RVA: 0x00031F5E File Offset: 0x0003015E
		public unsafe static float ringRangeSquared
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&value));
			}
		}

		// Token: 0x0400485C RID: 18524
		private static readonly IntPtr NativeFieldInfoPtr_RING_INTERVAL;

		// Token: 0x0400485D RID: 18525
		private static readonly IntPtr NativeFieldInfoPtr_RING_RANGE;

		// Token: 0x0400485E RID: 18526
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x0400485F RID: 18527
		private static readonly IntPtr NativeFieldInfoPtr_RingSound;

		// Token: 0x04004860 RID: 18528
		private static readonly IntPtr NativeFieldInfoPtr_AnswerSound;

		// Token: 0x04004861 RID: 18529
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004862 RID: 18530
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004863 RID: 18531
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastRing;

		// Token: 0x04004864 RID: 18532
		private static readonly IntPtr NativeFieldInfoPtr_ringRangeSquared;

		// Token: 0x04004865 RID: 18533
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0;

		// Token: 0x04004866 RID: 18534
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0;

		// Token: 0x04004867 RID: 18535
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04004868 RID: 18536
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04004869 RID: 18537
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400486A RID: 18538
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x0400486B RID: 18539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
