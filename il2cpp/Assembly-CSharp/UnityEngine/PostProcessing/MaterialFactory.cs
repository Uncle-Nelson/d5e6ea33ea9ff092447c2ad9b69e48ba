using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000077 RID: 119
	public sealed class MaterialFactory : Object
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x0008A6E4 File Offset: 0x000888E4
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialFactory()
		{
			Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MaterialFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr);
			MaterialFactory.NativeFieldInfoPtr_m_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, "m_Materials");
			MaterialFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664194);
			MaterialFactory.NativeMethodInfoPtr_Get_Public_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664195);
			MaterialFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr, 100664196);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0008A764 File Offset: 0x00088964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79063, XrefRangeEnd = 79071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialFactory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0008A7A0 File Offset: 0x000889A0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 79095, RefRangeEnd = 79117, XrefRangeStart = 79071, XrefRangeEnd = 79095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material Get(string shaderName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr_Get_Public_Material_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0008A7F0 File Offset: 0x000889F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79117, XrefRangeEnd = 79137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0000699B File Offset: 0x00004B9B
		public MaterialFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0008A824 File Offset: 0x00088A24
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000069A4 File Offset: 0x00004BA4
		public unsafe Dictionary<string, Material> m_Materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFactory.NativeFieldInfoPtr_m_Materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFactory.NativeFieldInfoPtr_m_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_m_Materials;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Material_String_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
