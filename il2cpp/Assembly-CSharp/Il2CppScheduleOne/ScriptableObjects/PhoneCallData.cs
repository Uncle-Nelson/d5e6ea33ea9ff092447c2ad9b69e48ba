using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004B0 RID: 1200
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x060069BE RID: 27070 RVA: 0x001D944C File Offset: 0x001D764C
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallData()
		{
			Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "PhoneCallData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr);
			PhoneCallData.NativeFieldInfoPtr_CallerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "CallerID");
			PhoneCallData.NativeFieldInfoPtr_Stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stages");
			PhoneCallData.NativeFieldInfoPtr_onCallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "onCallCompleted");
			PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676722);
			PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676723);
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001D94E0 File Offset: 0x001D76E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Completed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x001D9514 File Offset: 0x001D7714
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x00031FB3 File Offset: 0x000301B3
		public PhoneCallData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x060069C2 RID: 27074 RVA: 0x001D9550 File Offset: 0x001D7750
		// (set) Token: 0x060069C3 RID: 27075 RVA: 0x00031FBC File Offset: 0x000301BC
		public unsafe CallerID CallerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x001D9580 File Offset: 0x001D7780
		// (set) Token: 0x060069C5 RID: 27077 RVA: 0x00031FDB File Offset: 0x000301DB
		public unsafe Il2CppReferenceArray<PhoneCallData.Stage> Stages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneCallData.Stage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x060069C6 RID: 27078 RVA: 0x001D95B0 File Offset: 0x001D77B0
		// (set) Token: 0x060069C7 RID: 27079 RVA: 0x00031FFA File Offset: 0x000301FA
		public unsafe UnityEvent onCallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400486F RID: 18543
		private static readonly IntPtr NativeFieldInfoPtr_CallerID;

		// Token: 0x04004870 RID: 18544
		private static readonly IntPtr NativeFieldInfoPtr_Stages;

		// Token: 0x04004871 RID: 18545
		private static readonly IntPtr NativeFieldInfoPtr_onCallCompleted;

		// Token: 0x04004872 RID: 18546
		private static readonly IntPtr NativeMethodInfoPtr_Completed_Public_Void_0;

		// Token: 0x04004873 RID: 18547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A52 RID: 2642
		[Serializable]
		public class Stage : Il2CppSystem.Object
		{
			// Token: 0x0600D053 RID: 53331 RVA: 0x0031FB3C File Offset: 0x0031DD3C
			// Note: this type is marked as 'beforefieldinit'.
			static Stage()
			{
				Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr);
				PhoneCallData.Stage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "Text");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnStartTriggers");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnDoneTriggers");
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676724);
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676725);
				PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676726);
			}

			// Token: 0x0600D054 RID: 53332 RVA: 0x0031FBE0 File Offset: 0x0031DDE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 213238, RefRangeEnd = 213240, XrefRangeStart = 213236, XrefRangeEnd = 213238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageStart()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D055 RID: 53333 RVA: 0x0031FC14 File Offset: 0x0031DE14
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 213242, RefRangeEnd = 213245, XrefRangeStart = 213240, XrefRangeEnd = 213242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D056 RID: 53334 RVA: 0x0031FC48 File Offset: 0x0031DE48
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D057 RID: 53335 RVA: 0x00065615 File Offset: 0x00063815
			public Stage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B4 RID: 16564
			// (get) Token: 0x0600D058 RID: 53336 RVA: 0x0031FC84 File Offset: 0x0031DE84
			// (set) Token: 0x0600D059 RID: 53337 RVA: 0x0006561E File Offset: 0x0006381E
			public unsafe string Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040B5 RID: 16565
			// (get) Token: 0x0600D05A RID: 53338 RVA: 0x0031FCAC File Offset: 0x0031DEAC
			// (set) Token: 0x0600D05B RID: 53339 RVA: 0x0006563D File Offset: 0x0006383D
			public unsafe Il2CppReferenceArray<SystemTrigger> OnStartTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B6 RID: 16566
			// (get) Token: 0x0600D05C RID: 53340 RVA: 0x0031FCDC File Offset: 0x0031DEDC
			// (set) Token: 0x0600D05D RID: 53341 RVA: 0x0006565C File Offset: 0x0006385C
			public unsafe Il2CppReferenceArray<SystemTrigger> OnDoneTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C98 RID: 35992
			private static readonly IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x04008C99 RID: 35993
			private static readonly IntPtr NativeFieldInfoPtr_OnStartTriggers;

			// Token: 0x04008C9A RID: 35994
			private static readonly IntPtr NativeFieldInfoPtr_OnDoneTriggers;

			// Token: 0x04008C9B RID: 35995
			private static readonly IntPtr NativeMethodInfoPtr_OnStageStart_Public_Void_0;

			// Token: 0x04008C9C RID: 35996
			private static readonly IntPtr NativeMethodInfoPtr_OnStageEnd_Public_Void_0;

			// Token: 0x04008C9D RID: 35997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
