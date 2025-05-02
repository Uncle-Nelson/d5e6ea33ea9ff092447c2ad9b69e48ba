using System;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C2 RID: 706
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x00042810 File Offset: 0x00040A10
		public void Awake()
		{
			this.SetVisible(false);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00042819 File Offset: 0x00040A19
		public void SetVisible(bool visible)
		{
			this.tileMesh.enabled = visible;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00042828 File Offset: 0x00040A28
		public void SetColor(ETileColor col)
		{
			Material material = this.mat_White;
			switch (col)
			{
			case ETileColor.White:
				material = this.mat_White;
				break;
			case ETileColor.Blue:
				material = this.mat_Blue;
				break;
			case ETileColor.Red:
				material = this.mat_Red;
				break;
			default:
				Console.LogWarning("GridUnitAppearance: enum type not accounted for.", null);
				break;
			}
			this.tileMesh.material = material;
		}

		// Token: 0x04000F7C RID: 3964
		[Header("References")]
		[SerializeField]
		protected MeshRenderer tileMesh;

		// Token: 0x04000F7D RID: 3965
		[Header("Settings")]
		[SerializeField]
		protected Material mat_White;

		// Token: 0x04000F7E RID: 3966
		[SerializeField]
		protected Material mat_Blue;

		// Token: 0x04000F7F RID: 3967
		[SerializeField]
		protected Material mat_Red;
	}
}
