using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AC RID: 172
	public class RecoilTest : MonoBehaviour
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00027980 File Offset: 0x00025B80
		private void Start()
		{
			this.recoil = base.GetComponent<Recoil>();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0002798E File Offset: 0x00025B8E
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(0))
			{
				this.recoil.Fire(this.magnitude);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000279B2 File Offset: 0x00025BB2
		private void OnGUI()
		{
			GUILayout.Label("Press R or LMB for procedural recoil.", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x040004FD RID: 1277
		public float magnitude = 1f;

		// Token: 0x040004FE RID: 1278
		private Recoil recoil;
	}
}
