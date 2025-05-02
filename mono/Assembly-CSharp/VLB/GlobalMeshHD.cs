using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200010F RID: 271
	public static class GlobalMeshHD
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00016EE8 File Offset: 0x000150E8
		public static Mesh Get()
		{
			if (GlobalMeshHD.ms_Mesh == null)
			{
				GlobalMeshHD.Destroy();
				GlobalMeshHD.ms_Mesh = MeshGenerator.GenerateConeZ_Radii_DoubleCaps(1f, 1f, 1f, Config.Instance.sharedMeshSides, true);
				GlobalMeshHD.ms_Mesh.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
			}
			return GlobalMeshHD.ms_Mesh;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016F3F File Offset: 0x0001513F
		public static void Destroy()
		{
			if (GlobalMeshHD.ms_Mesh != null)
			{
				Object.DestroyImmediate(GlobalMeshHD.ms_Mesh);
				GlobalMeshHD.ms_Mesh = null;
			}
		}

		// Token: 0x040005ED RID: 1517
		private static Mesh ms_Mesh;
	}
}
