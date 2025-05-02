using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BC RID: 1724
	public class CauldronConfigPanel : ConfigPanel
	{
		// Token: 0x06009B5D RID: 39773 RVA: 0x00276D04 File Offset: 0x00274F04
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigPanel()
		{
			Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr);
			CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, "DestinationUI");
			CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682402);
			CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682403);
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00276D70 File Offset: 0x00274F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276097, XrefRangeEnd = 276132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00276DC0 File Offset: 0x00274FC0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19447, RefRangeEnd = 19461, XrefRangeStart = 19447, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x0004C14A File Offset: 0x0004A34A
		public CauldronConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x00276DFC File Offset: 0x00274FFC
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x0004C153 File Offset: 0x0004A353
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006871 RID: 26737
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006872 RID: 26738
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006873 RID: 26739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
