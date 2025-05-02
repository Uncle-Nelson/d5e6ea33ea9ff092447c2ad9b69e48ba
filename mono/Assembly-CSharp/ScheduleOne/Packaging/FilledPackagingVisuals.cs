using System;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000897 RID: 2199
	public class FilledPackagingVisuals : MonoBehaviour
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x000FA358 File Offset: 0x000F8558
		public void ResetVisuals()
		{
			if (this.weedVisuals.Container != null)
			{
				this.weedVisuals.Container.gameObject.SetActive(false);
			}
			if (this.methVisuals.Container != null)
			{
				this.methVisuals.Container.gameObject.SetActive(false);
			}
			if (this.cocaineVisuals.Container != null)
			{
				this.cocaineVisuals.Container.gameObject.SetActive(false);
			}
		}

		// Token: 0x04002B0D RID: 11021
		public FilledPackagingVisuals.WeedVisuals weedVisuals;

		// Token: 0x04002B0E RID: 11022
		public FilledPackagingVisuals.MethVisuals methVisuals;

		// Token: 0x04002B0F RID: 11023
		public FilledPackagingVisuals.CocaineVisuals cocaineVisuals;

		// Token: 0x02000898 RID: 2200
		[Serializable]
		public class MeshIndexPair
		{
			// Token: 0x04002B10 RID: 11024
			public MeshRenderer Mesh;

			// Token: 0x04002B11 RID: 11025
			public int MaterialIndex;
		}

		// Token: 0x02000899 RID: 2201
		[Serializable]
		public class BaseVisuals
		{
			// Token: 0x04002B12 RID: 11026
			public Transform Container;
		}

		// Token: 0x0200089A RID: 2202
		[Serializable]
		public class WeedVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x04002B13 RID: 11027
			public FilledPackagingVisuals.MeshIndexPair[] MainMeshes;

			// Token: 0x04002B14 RID: 11028
			public FilledPackagingVisuals.MeshIndexPair[] SecondaryMeshes;

			// Token: 0x04002B15 RID: 11029
			public FilledPackagingVisuals.MeshIndexPair[] LeafMeshes;

			// Token: 0x04002B16 RID: 11030
			public FilledPackagingVisuals.MeshIndexPair[] StemMeshes;
		}

		// Token: 0x0200089B RID: 2203
		[Serializable]
		public class MethVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x04002B17 RID: 11031
			public MeshRenderer[] CrystalMeshes;
		}

		// Token: 0x0200089C RID: 2204
		[Serializable]
		public class CocaineVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x04002B18 RID: 11032
			public MeshRenderer[] RockMeshes;
		}
	}
}
