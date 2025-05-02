using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000736 RID: 1846
	public class MethVisuals : MonoBehaviour
	{
		// Token: 0x0600A908 RID: 43272 RVA: 0x002A3600 File Offset: 0x002A1800
		// Note: this type is marked as 'beforefieldinit'.
		static MethVisuals()
		{
			Il2CppClassPointerStore<MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr);
			MethVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, "Meshes");
			MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100684004);
			MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100684005);
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x002A366C File Offset: 0x002A186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(MethDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x002A36B0 File Offset: 0x002A18B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x000533D7 File Offset: 0x000515D7
		public MethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600A90C RID: 43276 RVA: 0x002A36EC File Offset: 0x002A18EC
		// (set) Token: 0x0600A90D RID: 43277 RVA: 0x000533E0 File Offset: 0x000515E0
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007174 RID: 29044
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x04007175 RID: 29045
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0;

		// Token: 0x04007176 RID: 29046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
