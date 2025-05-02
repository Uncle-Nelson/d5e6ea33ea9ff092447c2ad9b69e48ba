using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000084 RID: 132
	public class VRIKLODController : MonoBehaviour
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00022BEF File Offset: 0x00020DEF
		private void Start()
		{
			this.ik = base.GetComponent<VRIK>();
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00022BFD File Offset: 0x00020DFD
		private void Update()
		{
			this.ik.solver.LOD = this.GetLODLevel();
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00022C18 File Offset: 0x00020E18
		private int GetLODLevel()
		{
			if (this.allowCulled)
			{
				if (this.LODRenderer == null)
				{
					return 0;
				}
				if (!this.LODRenderer.isVisible)
				{
					return 2;
				}
			}
			if ((this.ik.transform.position - Camera.main.transform.position).sqrMagnitude > this.LODDistance * this.LODDistance)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x040003EA RID: 1002
		public Renderer LODRenderer;

		// Token: 0x040003EB RID: 1003
		public float LODDistance = 15f;

		// Token: 0x040003EC RID: 1004
		public bool allowCulled = true;

		// Token: 0x040003ED RID: 1005
		private VRIK ik;
	}
}
