using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000714 RID: 1812
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x0600A322 RID: 41762 RVA: 0x0028F4CC File Offset: 0x0028D6CC
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingItemUI()
		{
			Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ClothingItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr);
			ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, "ClothingTypeIcon");
			ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683262);
			ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683263);
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x0028F538 File Offset: 0x0028D738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285965, XrefRangeEnd = 285985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0028F574 File Offset: 0x0028D774
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x000504CF File Offset: 0x0004E6CF
		public ClothingItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A326 RID: 41766 RVA: 0x0028F5B0 File Offset: 0x0028D7B0
		// (set) Token: 0x0600A327 RID: 41767 RVA: 0x000504D8 File Offset: 0x0004E6D8
		public unsafe Image ClothingTypeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D6E RID: 28014
		private static readonly IntPtr NativeFieldInfoPtr_ClothingTypeIcon;

		// Token: 0x04006D6F RID: 28015
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D70 RID: 28016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
