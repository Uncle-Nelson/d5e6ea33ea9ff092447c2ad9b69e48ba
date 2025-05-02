using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000177 RID: 375
	[Serializable]
	public class VisionEventReceipt : Object
	{
		// Token: 0x06001E6B RID: 7787 RVA: 0x000CF0B4 File Offset: 0x000CD2B4
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEventReceipt()
		{
			Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEventReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr);
			VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "TargetPlayer");
			VisionEventReceipt.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "State");
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666743);
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666744);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000CF134 File Offset: 0x000CD334
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 107300, RefRangeEnd = 107309, XrefRangeStart = 107298, XrefRangeEnd = 107300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000CF190 File Offset: 0x000CD390
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000112CB File Offset: 0x0000F4CB
		public VisionEventReceipt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x000CF1CC File Offset: 0x000CD3CC
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x000112D4 File Offset: 0x0000F4D4
		public unsafe NetworkObject TargetPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000CF1FC File Offset: 0x000CD3FC
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000112F3 File Offset: 0x0000F4F3
		public unsafe PlayerVisualState.EVisualState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeFieldInfoPtr_TargetPlayer;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
