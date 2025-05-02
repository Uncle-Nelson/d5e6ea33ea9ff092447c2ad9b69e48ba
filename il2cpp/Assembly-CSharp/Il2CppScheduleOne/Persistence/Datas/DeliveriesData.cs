using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025C RID: 604
	public class DeliveriesData : SaveData
	{
		// Token: 0x06002EE7 RID: 12007 RVA: 0x00106274 File Offset: 0x00104474
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesData()
		{
			Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeliveriesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr);
			DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "ActiveDeliveries");
			DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, 100668732);
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x001062CC File Offset: 0x001044CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130507, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesData(Il2CppReferenceArray<DeliveryInstance> deliveries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(deliveries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00018C9E File Offset: 0x00016E9E
		public DeliveriesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00106318 File Offset: 0x00104518
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00018CA7 File Offset: 0x00016EA7
		public unsafe Il2CppReferenceArray<DeliveryInstance> ActiveDeliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDeliveries;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0;
	}
}
