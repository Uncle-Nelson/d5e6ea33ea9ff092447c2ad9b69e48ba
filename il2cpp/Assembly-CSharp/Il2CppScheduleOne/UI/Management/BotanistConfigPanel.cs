using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BA RID: 1722
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x06009B4D RID: 39757 RVA: 0x00276A2C File Offset: 0x00274C2C
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigPanel()
		{
			Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr);
			BotanistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "BedUI");
			BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "SuppliesUI");
			BotanistConfigPanel.NativeFieldInfoPtr_PotsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "PotsUI");
			BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682398);
			BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682399);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x00276AC0 File Offset: 0x00274CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276010, XrefRangeEnd = 276062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x00276B10 File Offset: 0x00274D10
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x0004C0BC File Offset: 0x0004A2BC
		public BotanistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x06009B51 RID: 39761 RVA: 0x00276B4C File Offset: 0x00274D4C
		// (set) Token: 0x06009B52 RID: 39762 RVA: 0x0004C0C5 File Offset: 0x0004A2C5
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x06009B53 RID: 39763 RVA: 0x00276B7C File Offset: 0x00274D7C
		// (set) Token: 0x06009B54 RID: 39764 RVA: 0x0004C0E4 File Offset: 0x0004A2E4
		public unsafe ObjectFieldUI SuppliesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x06009B55 RID: 39765 RVA: 0x00276BAC File Offset: 0x00274DAC
		// (set) Token: 0x06009B56 RID: 39766 RVA: 0x0004C103 File Offset: 0x0004A303
		public unsafe ObjectListFieldUI PotsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006869 RID: 26729
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400686A RID: 26730
		private static readonly IntPtr NativeFieldInfoPtr_SuppliesUI;

		// Token: 0x0400686B RID: 26731
		private static readonly IntPtr NativeFieldInfoPtr_PotsUI;

		// Token: 0x0400686C RID: 26732
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400686D RID: 26733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
