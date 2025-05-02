using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DC RID: 476
	public class LightningSpawnArea : MonoBehaviour
	{
		// Token: 0x06000A94 RID: 2708 RVA: 0x0002EE24 File Offset: 0x0002D024
		public void OnDrawGizmosSelected()
		{
			Vector3 localScale = base.transform.localScale;
			Gizmos.color = Color.yellow;
			Matrix4x4 matrix = Gizmos.matrix;
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, this.lightningArea);
			Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002EE82 File Offset: 0x0002D082
		private void OnEnable()
		{
			LightningRenderer.AddSpawnArea(this);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0002EE8A File Offset: 0x0002D08A
		private void OnDisable()
		{
			LightningRenderer.RemoveSpawnArea(this);
		}

		// Token: 0x04000B83 RID: 2947
		[Tooltip("Dimensions of the lightning area where lightning bolts will be spawned inside randomly.")]
		public Vector3 lightningArea = new Vector3(40f, 20f, 20f);
	}
}
