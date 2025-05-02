using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000339 RID: 825
	public class Clickable : MonoBehaviour
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00050B3E File Offset: 0x0004ED3E
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x00050B46 File Offset: 0x0004ED46
		public virtual CursorManager.ECursorType HoveredCursor { get; protected set; } = CursorManager.ECursorType.Finger;

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00050B4F File Offset: 0x0004ED4F
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00050B57 File Offset: 0x0004ED57
		public Vector3 originalHitPoint { get; protected set; } = Vector3.zero;

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00050B60 File Offset: 0x0004ED60
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00050B68 File Offset: 0x0004ED68
		public bool IsHeld { get; protected set; }

		// Token: 0x06001275 RID: 4725 RVA: 0x00050B71 File Offset: 0x0004ED71
		private void Awake()
		{
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Task"));
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00050B88 File Offset: 0x0004ED88
		public virtual void StartClick(RaycastHit hit)
		{
			if (this.onClickStart != null)
			{
				this.onClickStart.Invoke(hit);
			}
			this.IsHeld = true;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00050BA5 File Offset: 0x0004EDA5
		public virtual void EndClick()
		{
			if (this.onClickEnd != null)
			{
				this.onClickEnd.Invoke();
			}
			this.IsHeld = false;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00050BC1 File Offset: 0x0004EDC1
		public void SetOriginalHitPoint(Vector3 hitPoint)
		{
			this.originalHitPoint = hitPoint;
		}

		// Token: 0x040011C7 RID: 4551
		public bool ClickableEnabled = true;

		// Token: 0x040011C8 RID: 4552
		public bool AutoCalculateOffset = true;

		// Token: 0x040011C9 RID: 4553
		public bool FlattenZOffset;

		// Token: 0x040011CC RID: 4556
		public UnityEvent<RaycastHit> onClickStart;

		// Token: 0x040011CD RID: 4557
		public UnityEvent onClickEnd;
	}
}
