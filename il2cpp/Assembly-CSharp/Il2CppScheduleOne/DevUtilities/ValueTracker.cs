using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046C RID: 1132
	public class ValueTracker : Object
	{
		// Token: 0x06006202 RID: 25090 RVA: 0x001BE4C4 File Offset: 0x001BC6C4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTracker()
		{
			Il2CppClassPointerStore<ValueTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ValueTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr);
			ValueTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "historyDuration");
			ValueTracker.NativeFieldInfoPtr_valueHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "valueHistory");
			ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675734);
			ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675735);
			ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675736);
			ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675737);
			ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675738);
			ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675739);
			ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675740);
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x001BE5A8 File Offset: 0x001BC7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201674, RefRangeEnd = 201675, XrefRangeStart = 201648, XrefRangeEnd = 201674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTracker(float HistoryDuration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref HistoryDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x001BE5F0 File Offset: 0x001BC7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201675, XrefRangeEnd = 201693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x001BE624 File Offset: 0x001BC824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201693, XrefRangeEnd = 201702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x001BE658 File Offset: 0x001BC858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201710, RefRangeEnd = 201711, XrefRangeStart = 201702, XrefRangeEnd = 201710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x001BE698 File Offset: 0x001BC898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201716, RefRangeEnd = 201718, XrefRangeStart = 201711, XrefRangeEnd = 201716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecordedHistoryLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x001BE6D4 File Offset: 0x001BC8D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201739, RefRangeEnd = 201741, XrefRangeStart = 201718, XrefRangeEnd = 201739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowestValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x001BE710 File Offset: 0x001BC910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201741, XrefRangeEnd = 201756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x0002E52F File Offset: 0x0002C72F
		public ValueTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x001BE74C File Offset: 0x001BC94C
		// (set) Token: 0x0600620C RID: 25100 RVA: 0x0002E538 File Offset: 0x0002C738
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x001BE774 File Offset: 0x001BC974
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x0002E553 File Offset: 0x0002C753
		public unsafe List<ValueTracker.Value> valueHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTracker.Value>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042D3 RID: 17107
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x040042D4 RID: 17108
		private static readonly IntPtr NativeFieldInfoPtr_valueHistory;

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeMethodInfoPtr_GetLowestValue_Public_Single_0;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageValue_Public_Single_0;

		// Token: 0x02000A1A RID: 2586
		public class Value : Object
		{
			// Token: 0x0600CF02 RID: 52994 RVA: 0x0031C2F0 File Offset: 0x0031A4F0
			// Note: this type is marked as 'beforefieldinit'.
			static Value()
			{
				Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "Value");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr);
				ValueTracker.Value.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "val");
				ValueTracker.Value.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "time");
				ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, 100675741);
			}

			// Token: 0x0600CF03 RID: 52995 RVA: 0x0031C358 File Offset: 0x0031A558
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 95687, RefRangeEnd = 95694, XrefRangeStart = 95687, XrefRangeEnd = 95694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Value(float val, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref val;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF04 RID: 52996 RVA: 0x00064B04 File Offset: 0x00062D04
			public Value(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405F RID: 16479
			// (get) Token: 0x0600CF05 RID: 52997 RVA: 0x0031C3B0 File Offset: 0x0031A5B0
			// (set) Token: 0x0600CF06 RID: 52998 RVA: 0x00064B0D File Offset: 0x00062D0D
			public unsafe float val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x17004060 RID: 16480
			// (get) Token: 0x0600CF07 RID: 52999 RVA: 0x0031C3D8 File Offset: 0x0031A5D8
			// (set) Token: 0x0600CF08 RID: 53000 RVA: 0x00064B28 File Offset: 0x00062D28
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008BA6 RID: 35750
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008BA7 RID: 35751
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008BA8 RID: 35752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
		}

		// Token: 0x02000A1B RID: 2587
		[ObfuscatedName("ScheduleOne.DevUtilities.ValueTracker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CF09 RID: 53001 RVA: 0x0031C400 File Offset: 0x0031A600
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr);
				ValueTracker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9");
				ValueTracker.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9__8_0");
				ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675743);
				ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675744);
			}

			// Token: 0x0600CF0A RID: 53002 RVA: 0x0031C47C File Offset: 0x0031A67C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF0B RID: 53003 RVA: 0x0031C4B8 File Offset: 0x0031A6B8
			[CallerCount(0)]
			public unsafe float _GetLowestValue_b__8_0(ValueTracker.Value x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF0C RID: 53004 RVA: 0x00064B43 File Offset: 0x00062D43
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004061 RID: 16481
			// (get) Token: 0x0600CF0D RID: 53005 RVA: 0x0031C508 File Offset: 0x0031A708
			// (set) Token: 0x0600CF0E RID: 53006 RVA: 0x00064B4C File Offset: 0x00062D4C
			public unsafe static ValueTracker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004062 RID: 16482
			// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x0031C530 File Offset: 0x0031A730
			// (set) Token: 0x0600CF10 RID: 53008 RVA: 0x00064B5E File Offset: 0x00062D5E
			public unsafe static Func<ValueTracker.Value, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTracker.Value, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BA9 RID: 35753
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BAA RID: 35754
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008BAB RID: 35755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BAC RID: 35756
			private static readonly IntPtr NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0;
		}
	}
}
