using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000715 RID: 1813
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x0600A328 RID: 41768 RVA: 0x0028F5E0 File Offset: 0x0028D7E0
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemUI()
		{
			Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "IntegerItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr);
			IntegerItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "ValueLabel");
			IntegerItemUI.NativeFieldInfoPtr_integerItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "integerItemInstance");
			IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683264);
			IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683265);
			IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683266);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0028F674 File Offset: 0x0028D874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285985, XrefRangeEnd = 285993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x0028F6C4 File Offset: 0x0028D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285993, XrefRangeEnd = 285995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0028F700 File Offset: 0x0028D900
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x000504F7 File Offset: 0x0004E6F7
		public IntegerItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x0028F73C File Offset: 0x0028D93C
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x00050500 File Offset: 0x0004E700
		public unsafe Text ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0028F76C File Offset: 0x0028D96C
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x0005051F File Offset: 0x0004E71F
		public unsafe IntegerItemInstance integerItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D71 RID: 28017
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006D72 RID: 28018
		private static readonly IntPtr NativeFieldInfoPtr_integerItemInstance;

		// Token: 0x04006D73 RID: 28019
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D74 RID: 28020
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D75 RID: 28021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
