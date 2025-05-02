using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AB RID: 171
	public static class GlobalMeshSD : Il2CppSystem.Object
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x0009729C File Offset: 0x0009549C
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshSD()
		{
			Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr);
			GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_DoubleSided");
			GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664769);
			GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664770);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0009731C File Offset: 0x0009551C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83903, RefRangeEnd = 83904, XrefRangeStart = 83867, XrefRangeEnd = 83903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00097350 File Offset: 0x00095550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83904, XrefRangeEnd = 83917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00007FC7 File Offset: 0x000061C7
		public GlobalMeshSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00097378 File Offset: 0x00095578
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00007FD0 File Offset: 0x000061D0
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000973A0 File Offset: 0x000955A0
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00007FE2 File Offset: 0x000061E2
		public unsafe static bool ms_DoubleSided
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&value));
			}
		}

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_ms_DoubleSided;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
