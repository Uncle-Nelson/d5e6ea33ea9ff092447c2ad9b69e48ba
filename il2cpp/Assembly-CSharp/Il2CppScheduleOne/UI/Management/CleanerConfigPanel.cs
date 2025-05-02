using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BF RID: 1727
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x06009B73 RID: 39795 RVA: 0x00277104 File Offset: 0x00275304
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigPanel()
		{
			Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr);
			CleanerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BedUI");
			CleanerConfigPanel.NativeFieldInfoPtr_BinsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BinsUI");
			CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682408);
			CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682409);
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x00277184 File Offset: 0x00275384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276222, XrefRangeEnd = 276267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x002771D4 File Offset: 0x002753D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B76 RID: 39798 RVA: 0x0004C200 File Offset: 0x0004A400
		public CleanerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x00277210 File Offset: 0x00275410
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x0004C209 File Offset: 0x0004A409
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x00277240 File Offset: 0x00275440
		// (set) Token: 0x06009B7A RID: 39802 RVA: 0x0004C228 File Offset: 0x0004A428
		public unsafe ObjectListFieldUI BinsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400687C RID: 26748
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400687D RID: 26749
		private static readonly IntPtr NativeFieldInfoPtr_BinsUI;

		// Token: 0x0400687E RID: 26750
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400687F RID: 26751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
