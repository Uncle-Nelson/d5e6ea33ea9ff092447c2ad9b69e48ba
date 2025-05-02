using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BE RID: 1726
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009B6B RID: 39787 RVA: 0x00276F98 File Offset: 0x00275198
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigPanel()
		{
			Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr);
			ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "RecipeUI");
			ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "DestinationUI");
			ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682406);
			ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682407);
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x00277018 File Offset: 0x00275218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276177, XrefRangeEnd = 276222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x00277068 File Offset: 0x00275268
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x0004C1B9 File Offset: 0x0004A3B9
		public ChemistryStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x002770A4 File Offset: 0x002752A4
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x0004C1C2 File Offset: 0x0004A3C2
		public unsafe StationRecipeFieldUI RecipeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x06009B71 RID: 39793 RVA: 0x002770D4 File Offset: 0x002752D4
		// (set) Token: 0x06009B72 RID: 39794 RVA: 0x0004C1E1 File Offset: 0x0004A3E1
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006878 RID: 26744
		private static readonly IntPtr NativeFieldInfoPtr_RecipeUI;

		// Token: 0x04006879 RID: 26745
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x0400687A RID: 26746
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400687B RID: 26747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
