using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000141 RID: 321
	public static class GlobalMeshSD
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x0001B63C File Offset: 0x0001983C
		public static Mesh Get()
		{
			bool sd_requiresDoubleSidedMesh = Config.Instance.SD_requiresDoubleSidedMesh;
			if (GlobalMeshSD.ms_Mesh == null || GlobalMeshSD.ms_DoubleSided != sd_requiresDoubleSidedMesh)
			{
				GlobalMeshSD.Destroy();
				GlobalMeshSD.ms_Mesh = MeshGenerator.GenerateConeZ_Radii(1f, 1f, 1f, Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, true, sd_requiresDoubleSidedMesh);
				GlobalMeshSD.ms_Mesh.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
				GlobalMeshSD.ms_DoubleSided = sd_requiresDoubleSidedMesh;
			}
			return GlobalMeshSD.ms_Mesh;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001B6B7 File Offset: 0x000198B7
		public static void Destroy()
		{
			if (GlobalMeshSD.ms_Mesh != null)
			{
				Object.DestroyImmediate(GlobalMeshSD.ms_Mesh);
				GlobalMeshSD.ms_Mesh = null;
			}
		}

		// Token: 0x040006C7 RID: 1735
		private static Mesh ms_Mesh;

		// Token: 0x040006C8 RID: 1736
		private static bool ms_DoubleSided;
	}
}
