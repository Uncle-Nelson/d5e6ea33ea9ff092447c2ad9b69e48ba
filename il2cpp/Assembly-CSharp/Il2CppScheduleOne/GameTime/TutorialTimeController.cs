using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000194 RID: 404
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x000D93D8 File Offset: 0x000D75D8
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialTimeController()
		{
			Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TutorialTimeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr);
			TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "TimeProgressionCurve");
			TutorialTimeController.NativeFieldInfoPtr_KeyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrames");
			TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "currentKeyFrameIndex");
			TutorialTimeController.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "disabled");
			TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667088);
			TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667089);
			TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667090);
			TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667091);
			TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667092);
			TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667093);
			TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667094);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000D94E4 File Offset: 0x000D76E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110516, XrefRangeEnd = 110534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x000D9518 File Offset: 0x000D7718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110534, XrefRangeEnd = 110552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000D954C File Offset: 0x000D774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110552, XrefRangeEnd = 110567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000D9580 File Offset: 0x000D7780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110567, XrefRangeEnd = 110571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentKeyFrameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000D95BC File Offset: 0x000D77BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110571, XrefRangeEnd = 110579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000D95F0 File Offset: 0x000D77F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110579, XrefRangeEnd = 110584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000D9624 File Offset: 0x000D7824
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialTimeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00012B40 File Offset: 0x00010D40
		public TutorialTimeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x000D9660 File Offset: 0x000D7860
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00012B49 File Offset: 0x00010D49
		public unsafe AnimationCurve TimeProgressionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000D9690 File Offset: 0x000D7890
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00012B68 File Offset: 0x00010D68
		public unsafe Il2CppReferenceArray<TutorialTimeController.KeyFrame> KeyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialTimeController.KeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x000D96C0 File Offset: 0x000D78C0
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00012B87 File Offset: 0x00010D87
		public unsafe int currentKeyFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex)) = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000D96E8 File Offset: 0x000D78E8
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00012BA2 File Offset: 0x00010DA2
		public unsafe bool disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled)) = value;
			}
		}

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_TimeProgressionCurve;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_KeyFrames;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_currentKeyFrameIndex;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_disabled;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008BF RID: 2239
		[Serializable]
		public sealed class KeyFrame : ValueType
		{
			// Token: 0x0600C39E RID: 50078 RVA: 0x002FB458 File Offset: 0x002F9658
			// Note: this type is marked as 'beforefieldinit'.
			static KeyFrame()
			{
				Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr);
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Time");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "SpeedMultiplier");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Note");
			}

			// Token: 0x0600C39F RID: 50079 RVA: 0x0005F3AB File Offset: 0x0005D5AB
			public KeyFrame(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C3A0 RID: 50080 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
			public KeyFrame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr))
			{
			}

			// Token: 0x17003D18 RID: 15640
			// (get) Token: 0x0600C3A1 RID: 50081 RVA: 0x002FB4C0 File Offset: 0x002F96C0
			// (set) Token: 0x0600C3A2 RID: 50082 RVA: 0x0005F3C6 File Offset: 0x0005D5C6
			public unsafe int Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time)) = value;
				}
			}

			// Token: 0x17003D19 RID: 15641
			// (get) Token: 0x0600C3A3 RID: 50083 RVA: 0x002FB4E8 File Offset: 0x002F96E8
			// (set) Token: 0x0600C3A4 RID: 50084 RVA: 0x0005F3E1 File Offset: 0x0005D5E1
			public unsafe float SpeedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier)) = value;
				}
			}

			// Token: 0x17003D1A RID: 15642
			// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x002FB510 File Offset: 0x002F9710
			// (set) Token: 0x0600C3A6 RID: 50086 RVA: 0x0005F3FC File Offset: 0x0005D5FC
			public unsafe string Note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040084A3 RID: 33955
			private static readonly IntPtr NativeFieldInfoPtr_Time;

			// Token: 0x040084A4 RID: 33956
			private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

			// Token: 0x040084A5 RID: 33957
			private static readonly IntPtr NativeFieldInfoPtr_Note;
		}
	}
}
