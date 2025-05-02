using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050D RID: 1293
	public class LaunderingOperation : Object
	{
		// Token: 0x06007282 RID: 29314 RVA: 0x001F4C70 File Offset: 0x001F2E70
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingOperation()
		{
			Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "LaunderingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr);
			LaunderingOperation.NativeFieldInfoPtr_business = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "business");
			LaunderingOperation.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "amount");
			LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "minutesSinceStarted");
			LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "completionTime_Minutes");
			LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, 100677668);
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x001F4D04 File Offset: 0x001F2F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224611, XrefRangeEnd = 224613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_business);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00036730 File Offset: 0x00034930
		public LaunderingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06007285 RID: 29317 RVA: 0x001F4D6C File Offset: 0x001F2F6C
		// (set) Token: 0x06007286 RID: 29318 RVA: 0x00036739 File Offset: 0x00034939
		public unsafe Business business
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06007287 RID: 29319 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		// (set) Token: 0x06007288 RID: 29320 RVA: 0x00036758 File Offset: 0x00034958
		public unsafe float amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x001F4DC4 File Offset: 0x001F2FC4
		// (set) Token: 0x0600728A RID: 29322 RVA: 0x00036773 File Offset: 0x00034973
		public unsafe int minutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted)) = value;
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x001F4DEC File Offset: 0x001F2FEC
		// (set) Token: 0x0600728C RID: 29324 RVA: 0x0003678E File Offset: 0x0003498E
		public unsafe int completionTime_Minutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes)) = value;
			}
		}

		// Token: 0x04004E28 RID: 20008
		private static readonly IntPtr NativeFieldInfoPtr_business;

		// Token: 0x04004E29 RID: 20009
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04004E2A RID: 20010
		private static readonly IntPtr NativeFieldInfoPtr_minutesSinceStarted;

		// Token: 0x04004E2B RID: 20011
		private static readonly IntPtr NativeFieldInfoPtr_completionTime_Minutes;

		// Token: 0x04004E2C RID: 20012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0;
	}
}
