using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000735 RID: 1845
	public class CocaineVisuals : MonoBehaviour
	{
		// Token: 0x0600A902 RID: 43266 RVA: 0x002A34E4 File Offset: 0x002A16E4
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineVisuals()
		{
			Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CocaineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr);
			CocaineVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, "Meshes");
			CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100684002);
			CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100684003);
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x002A3550 File Offset: 0x002A1750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294126, XrefRangeEnd = 294128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(CocaineDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x002A3594 File Offset: 0x002A1794
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x000533AF File Offset: 0x000515AF
		public CocaineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600A906 RID: 43270 RVA: 0x002A35D0 File Offset: 0x002A17D0
		// (set) Token: 0x0600A907 RID: 43271 RVA: 0x000533B8 File Offset: 0x000515B8
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007171 RID: 29041
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x04007172 RID: 29042
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0;

		// Token: 0x04007173 RID: 29043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
