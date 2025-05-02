using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000157 RID: 343
	[Serializable]
	public class CharacterElementsPreset : Il2CppSystem.Object
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x000C79A4 File Offset: 0x000C5BA4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterElementsPreset()
		{
			Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterElementsPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr);
			CharacterElementsPreset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "name");
			CharacterElementsPreset.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "mesh");
			CharacterElementsPreset.NativeFieldInfoPtr_hideParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "hideParts");
			CharacterElementsPreset.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "yOffset");
			CharacterElementsPreset.NativeFieldInfoPtr_mats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, "mats");
			CharacterElementsPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr, 100666236);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000C7A4C File Offset: 0x000C5C4C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterElementsPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterElementsPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0000FEDE File Offset: 0x0000E0DE
		public CharacterElementsPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000C7A88 File Offset: 0x000C5C88
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0000FEE7 File Offset: 0x0000E0E7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000C7AB0 File Offset: 0x000C5CB0
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000FF06 File Offset: 0x0000E106
		public unsafe Il2CppReferenceArray<Mesh> mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000C7AE0 File Offset: 0x000C5CE0
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0000FF25 File Offset: 0x0000E125
		public unsafe Il2CppStringArray hideParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_hideParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_hideParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000C7B10 File Offset: 0x000C5D10
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000FF44 File Offset: 0x0000E144
		public unsafe float yOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_yOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_yOffset)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000C7B38 File Offset: 0x000C5D38
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0000FF5F File Offset: 0x0000E15F
		public unsafe Il2CppReferenceArray<Material> mats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterElementsPreset.NativeFieldInfoPtr_mats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeFieldInfoPtr_hideParts;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr_yOffset;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeFieldInfoPtr_mats;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
