using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000580 RID: 1408
	public class StoredItemRandomRotation : MonoBehaviour
	{
		// Token: 0x06007C01 RID: 31745 RVA: 0x00215874 File Offset: 0x00213A74
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItemRandomRotation()
		{
			Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItemRandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr);
			StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, "ItemContainer");
			StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678845);
			StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678846);
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x002158E0 File Offset: 0x00213AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237289, XrefRangeEnd = 237293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x00215914 File Offset: 0x00213B14
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItemRandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x0003AD88 File Offset: 0x00038F88
		public StoredItemRandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x00215950 File Offset: 0x00213B50
		// (set) Token: 0x06007C06 RID: 31750 RVA: 0x0003AD91 File Offset: 0x00038F91
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005472 RID: 21618
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005473 RID: 21619
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005474 RID: 21620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
