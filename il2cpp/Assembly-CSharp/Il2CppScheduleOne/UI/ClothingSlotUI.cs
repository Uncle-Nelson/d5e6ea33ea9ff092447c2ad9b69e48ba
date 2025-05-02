using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000644 RID: 1604
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x06008E0E RID: 36366 RVA: 0x0024F728 File Offset: 0x0024D928
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingSlotUI()
		{
			Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ClothingSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr);
			ClothingSlotUI.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotType");
			ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotTypeImage");
			ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100680936);
			ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100680937);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x0024F7A8 File Offset: 0x0024D9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258723, XrefRangeEnd = 258730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x0024F7DC File Offset: 0x0024D9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00044494 File Offset: 0x00042694
		public ClothingSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x06008E12 RID: 36370 RVA: 0x0024F818 File Offset: 0x0024DA18
		// (set) Token: 0x06008E13 RID: 36371 RVA: 0x0004449D File Offset: 0x0004269D
		public unsafe EClothingSlot SlotType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType)) = value;
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x06008E14 RID: 36372 RVA: 0x0024F840 File Offset: 0x0024DA40
		// (set) Token: 0x06008E15 RID: 36373 RVA: 0x000444B8 File Offset: 0x000426B8
		public unsafe Image SlotTypeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006030 RID: 24624
		private static readonly IntPtr NativeFieldInfoPtr_SlotType;

		// Token: 0x04006031 RID: 24625
		private static readonly IntPtr NativeFieldInfoPtr_SlotTypeImage;

		// Token: 0x04006032 RID: 24626
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006033 RID: 24627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
