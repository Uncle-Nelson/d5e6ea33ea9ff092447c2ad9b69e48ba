using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000553 RID: 1363
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x0600781D RID: 30749 RVA: 0x0020810C File Offset: 0x0020630C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSaleSign()
		{
			Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VehicleSaleSign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr);
			VehicleSaleSign.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "NameLabel");
			VehicleSaleSign.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "PriceLabel");
			VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678399);
			VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678400);
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x0020818C File Offset: 0x0020638C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232478, XrefRangeEnd = 232486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x002081C0 File Offset: 0x002063C0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSaleSign() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00038EBF File Offset: 0x000370BF
		public VehicleSaleSign(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x002081FC File Offset: 0x002063FC
		// (set) Token: 0x06007822 RID: 30754 RVA: 0x00038EC8 File Offset: 0x000370C8
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06007823 RID: 30755 RVA: 0x0020822C File Offset: 0x0020642C
		// (set) Token: 0x06007824 RID: 30756 RVA: 0x00038EE7 File Offset: 0x000370E7
		public unsafe TextMeshPro PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E5 RID: 20965
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040051E6 RID: 20966
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x040051E7 RID: 20967
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051E8 RID: 20968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
