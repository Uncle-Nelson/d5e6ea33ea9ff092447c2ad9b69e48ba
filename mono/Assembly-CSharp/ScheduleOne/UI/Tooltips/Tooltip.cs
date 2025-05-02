using System;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Tooltips
{
	// Token: 0x02000A63 RID: 2659
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0012BAE8 File Offset: 0x00129CE8
		public Vector3 labelPosition
		{
			get
			{
				if (this.isWorldspace)
				{
					return RectTransformUtility.WorldToScreenPoint(Singleton<GameplayMenu>.Instance.OverlayCamera, this.rect.position);
				}
				return this.rect.position + new Vector3(this.labelOffset.x, this.labelOffset.y, 0f);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x0012BB4D File Offset: 0x00129D4D
		// (set) Token: 0x06004794 RID: 18324 RVA: 0x0012BB55 File Offset: 0x00129D55
		public bool isWorldspace { get; private set; }

		// Token: 0x06004795 RID: 18325 RVA: 0x0012BB60 File Offset: 0x00129D60
		protected virtual void Awake()
		{
			this.rect = base.GetComponent<RectTransform>();
			if (base.GetComponentInParent<GraphicRaycaster>() == null)
			{
				Console.LogWarning("Tooltip has not parent GraphicRaycaster! Tooltip won't ever be activated", null);
			}
			this.canvas = base.GetComponentInParent<Canvas>();
			if (this.canvas != null)
			{
				this.isWorldspace = (this.canvas.renderMode == 2);
			}
		}

		// Token: 0x040034FB RID: 13563
		[Header("Settings")]
		public string text;

		// Token: 0x040034FC RID: 13564
		public Vector2 labelOffset;

		// Token: 0x040034FD RID: 13565
		private RectTransform rect;

		// Token: 0x040034FF RID: 13567
		private Canvas canvas;
	}
}
