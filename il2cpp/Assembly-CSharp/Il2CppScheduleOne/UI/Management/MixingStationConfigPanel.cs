using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C2 RID: 1730
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009B89 RID: 39817 RVA: 0x00277504 File Offset: 0x00275704
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigPanel()
		{
			Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr);
			MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "StartThresholdUI");
			MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682414);
			MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682415);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x00277584 File Offset: 0x00275784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276347, XrefRangeEnd = 276392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x002775D4 File Offset: 0x002757D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x0004C2B6 File Offset: 0x0004A4B6
		public MixingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x00277610 File Offset: 0x00275810
		// (set) Token: 0x06009B8E RID: 39822 RVA: 0x0004C2BF File Offset: 0x0004A4BF
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x00277640 File Offset: 0x00275840
		// (set) Token: 0x06009B90 RID: 39824 RVA: 0x0004C2DE File Offset: 0x0004A4DE
		public unsafe NumberFieldUI StartThresholdUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006887 RID: 26759
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006888 RID: 26760
		private static readonly IntPtr NativeFieldInfoPtr_StartThresholdUI;

		// Token: 0x04006889 RID: 26761
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400688A RID: 26762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
