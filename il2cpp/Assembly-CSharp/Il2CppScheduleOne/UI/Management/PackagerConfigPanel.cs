using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C3 RID: 1731
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x06009B91 RID: 39825 RVA: 0x00277670 File Offset: 0x00275870
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigPanel()
		{
			Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr);
			PackagerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "BedUI");
			PackagerConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "StationsUI");
			PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "RoutesUI");
			PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682416);
			PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682417);
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x00277704 File Offset: 0x00275904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276392, XrefRangeEnd = 276447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x00277754 File Offset: 0x00275954
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x0004C2FD File Offset: 0x0004A4FD
		public PackagerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x06009B95 RID: 39829 RVA: 0x00277790 File Offset: 0x00275990
		// (set) Token: 0x06009B96 RID: 39830 RVA: 0x0004C306 File Offset: 0x0004A506
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x06009B97 RID: 39831 RVA: 0x002777C0 File Offset: 0x002759C0
		// (set) Token: 0x06009B98 RID: 39832 RVA: 0x0004C325 File Offset: 0x0004A525
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x06009B99 RID: 39833 RVA: 0x002777F0 File Offset: 0x002759F0
		// (set) Token: 0x06009B9A RID: 39834 RVA: 0x0004C344 File Offset: 0x0004A544
		public unsafe RouteListFieldUI RoutesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400688B RID: 26763
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400688C RID: 26764
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x0400688D RID: 26765
		private static readonly IntPtr NativeFieldInfoPtr_RoutesUI;

		// Token: 0x0400688E RID: 26766
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400688F RID: 26767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
