using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F5 RID: 1781
	[ExecuteInEditMode]
	public class PlaceholderBuilding : MonoBehaviour
	{
		// Token: 0x0600306E RID: 12398 RVA: 0x000C9BD6 File Offset: 0x000C7DD6
		private void Awake()
		{
			if (Application.isPlaying)
			{
				this.Model.GetComponent<Collider>().enabled = true;
			}
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000C9BF0 File Offset: 0x000C7DF0
		protected virtual void LateUpdate()
		{
			if (Application.isPlaying)
			{
				return;
			}
			base.gameObject.name = "Placeholder (" + this.Name + ")";
			this.Label.text = this.Name;
			this.Model.localScale = this.Dimensions;
			if (base.transform.position != this.lastFramePosition)
			{
				RaycastHit raycastHit;
				if (this.AutoGround && Physics.Raycast(base.transform.position + Vector3.up * 50f, Vector3.down, ref raycastHit, 100f, 1 << LayerMask.NameToLayer("Default")))
				{
					this.Model.transform.position = new Vector3(this.Model.transform.position.x, raycastHit.point.y + this.Dimensions.y / 2f, this.Model.transform.position.z);
				}
				this.lastFramePosition = base.transform.position;
			}
			this.Label.transform.position = new Vector3(this.Label.transform.position.x, this.Model.transform.position.y + this.Dimensions.y / 2f + 0.1f, this.Label.transform.position.z);
		}

		// Token: 0x0400226D RID: 8813
		[Header("Settings")]
		public string Name;

		// Token: 0x0400226E RID: 8814
		public Vector3 Dimensions;

		// Token: 0x0400226F RID: 8815
		public bool AutoGround = true;

		// Token: 0x04002270 RID: 8816
		[Header("References")]
		public Transform Model;

		// Token: 0x04002271 RID: 8817
		public TextMeshPro Label;

		// Token: 0x04002272 RID: 8818
		private Vector3 lastFramePosition = Vector3.zero;
	}
}
