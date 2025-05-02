using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000097 RID: 151
	public static class GlobalMeshHD : Il2CppSystem.Object
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x0008E8C4 File Offset: 0x0008CAC4
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshHD()
		{
			Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr);
			GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100664363);
			GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100664364);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0008E930 File Offset: 0x0008CB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80807, RefRangeEnd = 80808, XrefRangeStart = 80776, XrefRangeEnd = 80807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0008E964 File Offset: 0x0008CB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80808, XrefRangeEnd = 80821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00007371 File Offset: 0x00005571
		public GlobalMeshHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0008E98C File Offset: 0x0008CB8C
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0000737A File Offset: 0x0000557A
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
