using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200036A RID: 874
	public class Listener : MonoBehaviour
	{
		// Token: 0x06004462 RID: 17506 RVA: 0x0015233C File Offset: 0x0015053C
		// Note: this type is marked as 'beforefieldinit'.
		static Listener()
		{
			Il2CppClassPointerStore<Listener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "Listener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Listener>.NativeClassPtr);
			Listener.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "listeners");
			Listener.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "Sensitivity");
			Listener.NativeFieldInfoPtr_HearingOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingOrigin");
			Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "<SquaredHearingRange>k__BackingField");
			Listener.NativeFieldInfoPtr_onNoiseHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "onNoiseHeard");
			Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671646);
			Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671647);
			Listener.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671648);
			Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671649);
			Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671650);
			Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671651);
			Listener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671652);
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x0015245C File Offset: 0x0015065C
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x00152498 File Offset: 0x00150698
		public unsafe float SquaredHearingRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30022, XrefRangeStart = 30021, XrefRangeEnd = 30022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30022, RefRangeEnd = 30024, XrefRangeStart = 30022, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x001524D8 File Offset: 0x001506D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155033, XrefRangeEnd = 155040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x0015250C File Offset: 0x0015070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155040, XrefRangeEnd = 155053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00152540 File Offset: 0x00150740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155053, XrefRangeEnd = 155061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00152574 File Offset: 0x00150774
		[CallerCount(0)]
		public unsafe void Notify(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x001525B8 File Offset: 0x001507B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74374, RefRangeEnd = 74378, XrefRangeStart = 74374, XrefRangeEnd = 74378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Listener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x00021655 File Offset: 0x0001F855
		public Listener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x001525F4 File Offset: 0x001507F4
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x0002165E File Offset: 0x0001F85E
		public unsafe static List<Listener> listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Listener.NativeFieldInfoPtr_listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Listener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Listener.NativeFieldInfoPtr_listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x0015261C File Offset: 0x0015081C
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x00021670 File Offset: 0x0001F870
		public unsafe float Sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity)) = value;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x00152644 File Offset: 0x00150844
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x0002168B File Offset: 0x0001F88B
		public unsafe Transform HearingOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x00152674 File Offset: 0x00150874
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x000216AA File Offset: 0x0001F8AA
		public unsafe float _SquaredHearingRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField)) = value;
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x0015269C File Offset: 0x0015089C
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x000216C5 File Offset: 0x0001F8C5
		public unsafe Listener.HearingEvent onNoiseHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener.HearingEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeFieldInfoPtr_HearingOrigin;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeFieldInfoPtr__SquaredHearingRange_k__BackingField;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeFieldInfoPtr_onNoiseHeard;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000967 RID: 2407
		public sealed class HearingEvent : MulticastDelegate
		{
			// Token: 0x0600C950 RID: 51536 RVA: 0x0030BF28 File Offset: 0x0030A128
			// Note: this type is marked as 'beforefieldinit'.
			static HearingEvent()
			{
				Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingEvent");
				Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671654);
				Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671655);
				Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671656);
				Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671657);
			}

			// Token: 0x0600C951 RID: 51537 RVA: 0x0030BF9C File Offset: 0x0030A19C
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81889, XrefRangeEnd = 82521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HearingEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C952 RID: 51538 RVA: 0x0030BFF8 File Offset: 0x0030A1F8
			[CallerCount(0)]
			public unsafe void Invoke(NoiseEvent nEvent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C953 RID: 51539 RVA: 0x0030C03C File Offset: 0x0030A23C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NoiseEvent nEvent, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C954 RID: 51540 RVA: 0x0030C0B0 File Offset: 0x0030A2B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C955 RID: 51541 RVA: 0x00061EC2 File Offset: 0x000600C2
			public HearingEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C956 RID: 51542 RVA: 0x00061ECB File Offset: 0x000600CB
			public static implicit operator Listener.HearingEvent(Action<NoiseEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listener.HearingEvent>(A_0);
			}

			// Token: 0x0600C957 RID: 51543 RVA: 0x00061ED3 File Offset: 0x000600D3
			public static Listener.HearingEvent operator +(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Listener.HearingEvent>();
			}

			// Token: 0x0600C958 RID: 51544 RVA: 0x00061EE1 File Offset: 0x000600E1
			public static Listener.HearingEvent operator -(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Listener.HearingEvent>();
				}
				return result;
			}

			// Token: 0x04008845 RID: 34885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008846 RID: 34886
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0;

			// Token: 0x04008847 RID: 34887
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0;

			// Token: 0x04008848 RID: 34888
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
