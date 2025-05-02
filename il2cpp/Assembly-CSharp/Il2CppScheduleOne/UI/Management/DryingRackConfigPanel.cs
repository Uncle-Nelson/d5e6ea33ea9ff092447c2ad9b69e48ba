using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C0 RID: 1728
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x06009B7B RID: 39803 RVA: 0x00277270 File Offset: 0x00275470
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigPanel()
		{
			Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr);
			DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "QualityUI");
			DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "DestinationUI");
			DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682410);
			DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682411);
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x002772F0 File Offset: 0x002754F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276267, XrefRangeEnd = 276312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x00277340 File Offset: 0x00275540
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x0004C247 File Offset: 0x0004A447
		public DryingRackConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06009B7F RID: 39807 RVA: 0x0027737C File Offset: 0x0027557C
		// (set) Token: 0x06009B80 RID: 39808 RVA: 0x0004C250 File Offset: 0x0004A450
		public unsafe QualityFieldUI QualityUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x002773AC File Offset: 0x002755AC
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x0004C26F File Offset: 0x0004A46F
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006880 RID: 26752
		private static readonly IntPtr NativeFieldInfoPtr_QualityUI;

		// Token: 0x04006881 RID: 26753
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006882 RID: 26754
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006883 RID: 26755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
