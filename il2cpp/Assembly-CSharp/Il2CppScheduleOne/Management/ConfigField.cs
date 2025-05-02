using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000392 RID: 914
	public class ConfigField : Object
	{
		// Token: 0x060047CD RID: 18381 RVA: 0x0015FCD0 File Offset: 0x0015DED0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigField()
		{
			Il2CppClassPointerStore<ConfigField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigField>.NativeClassPtr);
			ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, "<ParentConfig>k__BackingField");
			ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672171);
			ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672172);
			ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672173);
			ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100672174);
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x0015FD64 File Offset: 0x0015DF64
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x0015FDA4 File Offset: 0x0015DFA4
		public unsafe EntityConfiguration ParentConfig
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0015FDE8 File Offset: 0x0015DFE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 161483, RefRangeEnd = 161495, XrefRangeStart = 161475, XrefRangeEnd = 161483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x0015FE34 File Offset: 0x0015E034
		[CallerCount(0)]
		public unsafe virtual bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00022C12 File Offset: 0x00020E12
		public ConfigField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0015FE7C File Offset: 0x0015E07C
		// (set) Token: 0x060047D4 RID: 18388 RVA: 0x00022C1B File Offset: 0x00020E1B
		public unsafe EntityConfiguration _ParentConfig_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeFieldInfoPtr__ParentConfig_k__BackingField;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0;
	}
}
