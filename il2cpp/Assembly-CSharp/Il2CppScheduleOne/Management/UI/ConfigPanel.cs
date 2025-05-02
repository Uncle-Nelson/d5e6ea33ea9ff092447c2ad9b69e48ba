using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management.UI
{
	// Token: 0x020003A9 RID: 937
	public class ConfigPanel : MonoBehaviour
	{
		// Token: 0x06004953 RID: 18771 RVA: 0x001658DC File Offset: 0x00163ADC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigPanel()
		{
			Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.UI", "ConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr);
			ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672386);
			ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr, 100672387);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00165934 File Offset: 0x00163B34
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00165984 File Offset: 0x00163B84
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x0002358D File Offset: 0x0002178D
		public ConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_New_Void_List_1_EntityConfiguration_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
