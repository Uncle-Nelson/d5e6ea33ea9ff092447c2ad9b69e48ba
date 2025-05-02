using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000153 RID: 339
	[Serializable]
	public class PreBuiltData : Il2CppSystem.Object
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x000C70D4 File Offset: 0x000C52D4
		// Note: this type is marked as 'beforefieldinit'.
		static PreBuiltData()
		{
			Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "PreBuiltData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr);
			PreBuiltData.NativeFieldInfoPtr_GroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "GroupName");
			PreBuiltData.NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "meshes");
			PreBuiltData.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, "materials");
			PreBuiltData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr, 100666232);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000C7154 File Offset: 0x000C5354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100491, XrefRangeEnd = 100506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreBuiltData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreBuiltData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreBuiltData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000FB98 File Offset: 0x0000DD98
		public PreBuiltData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x000C7190 File Offset: 0x000C5390
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000FBA1 File Offset: 0x0000DDA1
		public unsafe string GroupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_GroupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_GroupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x000C71B8 File Offset: 0x000C53B8
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		public unsafe List<Mesh> meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000C71E8 File Offset: 0x000C53E8
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000FBDF File Offset: 0x0000DDDF
		public unsafe List<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreBuiltData.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr_GroupName;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeFieldInfoPtr_meshes;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
