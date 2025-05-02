using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C1 RID: 1729
	public class LabOvenConfigPanel : ConfigPanel
	{
		// Token: 0x06009B83 RID: 39811 RVA: 0x002773DC File Offset: 0x002755DC
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigPanel()
		{
			Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr);
			LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, "DestinationUI");
			LabOvenConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, 100682412);
			LabOvenConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, 100682413);
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x00277448 File Offset: 0x00275648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276312, XrefRangeEnd = 276347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x00277498 File Offset: 0x00275698
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0004C28E File Offset: 0x0004A48E
		public LabOvenConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x002774D4 File Offset: 0x002756D4
		// (set) Token: 0x06009B88 RID: 39816 RVA: 0x0004C297 File Offset: 0x0004A497
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006884 RID: 26756
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006885 RID: 26757
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006886 RID: 26758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
