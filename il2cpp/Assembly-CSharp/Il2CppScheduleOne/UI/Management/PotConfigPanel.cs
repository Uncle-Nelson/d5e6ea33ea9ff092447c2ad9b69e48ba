using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C5 RID: 1733
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x06009BA1 RID: 39841 RVA: 0x00277948 File Offset: 0x00275B48
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigPanel()
		{
			Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr);
			PotConfigPanel.NativeFieldInfoPtr_SeedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "SeedUI");
			PotConfigPanel.NativeFieldInfoPtr_Additive1UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive1UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive2UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive2UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive3UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive3UI");
			PotConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "DestinationUI");
			PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682420);
			PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682421);
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x00277A04 File Offset: 0x00275C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276482, XrefRangeEnd = 276557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BA3 RID: 39843 RVA: 0x00277A54 File Offset: 0x00275C54
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x0004C38B File Offset: 0x0004A58B
		public PotConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x06009BA5 RID: 39845 RVA: 0x00277A90 File Offset: 0x00275C90
		// (set) Token: 0x06009BA6 RID: 39846 RVA: 0x0004C394 File Offset: 0x0004A594
		public unsafe ItemFieldUI SeedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x06009BA7 RID: 39847 RVA: 0x00277AC0 File Offset: 0x00275CC0
		// (set) Token: 0x06009BA8 RID: 39848 RVA: 0x0004C3B3 File Offset: 0x0004A5B3
		public unsafe ItemFieldUI Additive1UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x06009BA9 RID: 39849 RVA: 0x00277AF0 File Offset: 0x00275CF0
		// (set) Token: 0x06009BAA RID: 39850 RVA: 0x0004C3D2 File Offset: 0x0004A5D2
		public unsafe ItemFieldUI Additive2UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x00277B20 File Offset: 0x00275D20
		// (set) Token: 0x06009BAC RID: 39852 RVA: 0x0004C3F1 File Offset: 0x0004A5F1
		public unsafe ItemFieldUI Additive3UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x00277B50 File Offset: 0x00275D50
		// (set) Token: 0x06009BAE RID: 39854 RVA: 0x0004C410 File Offset: 0x0004A610
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006893 RID: 26771
		private static readonly IntPtr NativeFieldInfoPtr_SeedUI;

		// Token: 0x04006894 RID: 26772
		private static readonly IntPtr NativeFieldInfoPtr_Additive1UI;

		// Token: 0x04006895 RID: 26773
		private static readonly IntPtr NativeFieldInfoPtr_Additive2UI;

		// Token: 0x04006896 RID: 26774
		private static readonly IntPtr NativeFieldInfoPtr_Additive3UI;

		// Token: 0x04006897 RID: 26775
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006898 RID: 26776
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006899 RID: 26777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
