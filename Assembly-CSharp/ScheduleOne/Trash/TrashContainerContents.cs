using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x0200082D RID: 2093
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerContents : MonoBehaviour
	{
		// Token: 0x0600395B RID: 14683 RVA: 0x000F299D File Offset: 0x000F0B9D
		protected void Start()
		{
			this.TrashContainer.onTrashLevelChanged.AddListener(new UnityAction(this.UpdateVisuals));
			this.UpdateVisuals();
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x000F29C4 File Offset: 0x000F0BC4
		private void UpdateVisuals()
		{
			float t = (float)this.TrashContainer.TrashLevel / (float)this.TrashContainer.TrashCapacity;
			this.ContentsTransform.transform.localPosition = Vector3.Lerp(this.VisualsMinTransform.localPosition, this.VisualsMaxTransform.localPosition, t);
			this.ContentsTransform.transform.localScale = Vector3.Lerp(this.VisualsMinTransform.localScale, this.VisualsMaxTransform.localScale, t);
			this.VisualsContainer.gameObject.SetActive(this.TrashContainer.TrashLevel > 0);
			this.Collider.enabled = (this.TrashContainer.TrashLevel >= this.TrashContainer.TrashCapacity);
		}

		// Token: 0x04002975 RID: 10613
		public TrashContainer TrashContainer;

		// Token: 0x04002976 RID: 10614
		[Header("References")]
		public Transform ContentsTransform;

		// Token: 0x04002977 RID: 10615
		public Transform VisualsContainer;

		// Token: 0x04002978 RID: 10616
		public Transform VisualsMinTransform;

		// Token: 0x04002979 RID: 10617
		public Transform VisualsMaxTransform;

		// Token: 0x0400297A RID: 10618
		public Collider Collider;
	}
}
