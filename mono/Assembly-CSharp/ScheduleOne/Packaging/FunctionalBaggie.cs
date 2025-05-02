using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200088C RID: 2188
	public class FunctionalBaggie : FunctionalPackaging
	{
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x000F90C1 File Offset: 0x000F72C1
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x000F90C9 File Offset: 0x000F72C9
		public override CursorManager.ECursorType HoveredCursor { get; protected set; } = CursorManager.ECursorType.Finger;

		// Token: 0x06003B38 RID: 15160 RVA: 0x000F90D4 File Offset: 0x000F72D4
		public void SetClosed(float closedDelta)
		{
			this.ClosedDelta = closedDelta;
			SkinnedMeshRenderer[] bagMeshes = this.BagMeshes;
			for (int i = 0; i < bagMeshes.Length; i++)
			{
				bagMeshes[i].SetBlendShapeWeight(0, closedDelta * 100f);
			}
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x000F910D File Offset: 0x000F730D
		public override void StartClick(RaycastHit hit)
		{
			if (base.IsFull && this.ClosedDelta == 0f)
			{
				this.ClickableEnabled = false;
				if (!base.IsSealed)
				{
					this.Seal();
				}
			}
			base.StartClick(hit);
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x000F9140 File Offset: 0x000F7340
		public override void Seal()
		{
			base.Seal();
			this.FunnelCollidersContainer.gameObject.SetActive(false);
			this.DynamicCollider.enabled = true;
			base.StartCoroutine(this.<Seal>g__Routine|11_0());
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000F9172 File Offset: 0x000F7372
		protected override void FullyPacked()
		{
			base.FullyPacked();
			this.FullyPackedBlocker.SetActive(true);
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x000F9195 File Offset: 0x000F7395
		[CompilerGenerated]
		private IEnumerator <Seal>g__Routine|11_0()
		{
			float lerpTime = 0.25f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.SetClosed(i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.SetClosed(1f);
			yield break;
		}

		// Token: 0x04002ABB RID: 10939
		public SkinnedMeshRenderer[] BagMeshes;

		// Token: 0x04002ABC RID: 10940
		public GameObject FunnelCollidersContainer;

		// Token: 0x04002ABD RID: 10941
		public GameObject FullyPackedBlocker;

		// Token: 0x04002ABE RID: 10942
		public Collider DynamicCollider;

		// Token: 0x04002AC0 RID: 10944
		private float ClosedDelta;
	}
}
