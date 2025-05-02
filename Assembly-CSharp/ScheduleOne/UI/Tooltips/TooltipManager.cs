using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Tooltips
{
	// Token: 0x02000A64 RID: 2660
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x06004797 RID: 18327 RVA: 0x0012BBC0 File Offset: 0x00129DC0
		protected override void Awake()
		{
			base.Awake();
			this.eventSystem = EventSystem.current;
			this.sortedCanvases = (from canvas in this.canvases
			where canvas.GetComponent<GraphicRaycaster>() != null
			orderby canvas.sortingOrder, canvas.transform.GetSiblingIndex()
			select canvas).ToList<Canvas>();
			for (int i = 0; i < this.sortedCanvases.Count; i++)
			{
				this.raycasters.Add(this.sortedCanvases[i].GetComponent<GraphicRaycaster>());
			}
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x0012BC8D File Offset: 0x00129E8D
		protected virtual void Update()
		{
			this.CheckForTooltipHover();
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0012BC95 File Offset: 0x00129E95
		protected virtual void LateUpdate()
		{
			if (!this.tooltipShownThisFrame)
			{
				this.anchor.gameObject.SetActive(false);
			}
			this.tooltipShownThisFrame = false;
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x0012BCB8 File Offset: 0x00129EB8
		public void AddCanvas(Canvas canvas)
		{
			this.canvases.Add(canvas);
			this.sortedCanvases = (from c in this.canvases
			where c != null && c.GetComponent<GraphicRaycaster>() != null
			orderby c.sortingOrder, c.transform.GetSiblingIndex()
			select c).ToList<Canvas>();
			this.raycasters.Clear();
			for (int i = 0; i < this.sortedCanvases.Count; i++)
			{
				this.raycasters.Add(this.sortedCanvases[i].GetComponent<GraphicRaycaster>());
			}
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x0012BD8C File Offset: 0x00129F8C
		private void CheckForTooltipHover()
		{
			PointerEventData pointerEventData = new PointerEventData(this.eventSystem);
			pointerEventData.position = Input.mousePosition;
			for (int i = 0; i < this.sortedCanvases.Count; i++)
			{
				if (!(this.sortedCanvases[i] == null) && this.sortedCanvases[i].enabled && this.sortedCanvases[i].gameObject.activeSelf)
				{
					List<RaycastResult> list = new List<RaycastResult>();
					this.raycasters[i].Raycast(pointerEventData, list);
					if (list.Count > 0)
					{
						Tooltip componentInParent = list[0].gameObject.GetComponentInParent<Tooltip>();
						if (componentInParent != null && componentInParent.enabled)
						{
							this.ShowTooltip(componentInParent.text, componentInParent.labelPosition, componentInParent.isWorldspace);
						}
						return;
					}
				}
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x0012BE7C File Offset: 0x0012A07C
		public void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
			if (text == string.Empty || string.IsNullOrWhiteSpace(text))
			{
				Console.LogWarning("ShowTooltip: text is empty", null);
				return;
			}
			this.tooltipShownThisFrame = true;
			string text2 = this.tooltipLabel.text;
			this.tooltipLabel.text = text;
			if (text2 != text)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.anchor);
				this.tooltipLabel.ForceMeshUpdate(true, true);
			}
			this.anchor.sizeDelta = new Vector2(this.tooltipLabel.renderedWidth + 4f, this.tooltipLabel.renderedHeight + 1f);
			this.anchor.position = position + new Vector2(this.anchor.sizeDelta.x / 2f, -this.anchor.sizeDelta.y / 2f);
			Vector2 anchoredPosition = this.anchor.anchoredPosition;
			float min = Singleton<HUD>.Instance.canvasRect.sizeDelta.x * -0.5f - this.anchor.sizeDelta.x * this.anchor.pivot.x * -1f;
			float max = Singleton<HUD>.Instance.canvasRect.sizeDelta.x * 0.5f - this.anchor.sizeDelta.x * (1f - this.anchor.pivot.x);
			float min2 = Singleton<HUD>.Instance.canvasRect.sizeDelta.y * -0.5f - this.anchor.sizeDelta.y * this.anchor.pivot.y * -1f;
			float max2 = Singleton<HUD>.Instance.canvasRect.sizeDelta.y * 0.5f - this.anchor.sizeDelta.y * (1f - this.anchor.pivot.y);
			anchoredPosition.x = Mathf.Clamp(anchoredPosition.x, min, max);
			anchoredPosition.y = Mathf.Clamp(anchoredPosition.y, min2, max2);
			this.anchor.anchoredPosition = anchoredPosition;
			this.anchor.gameObject.SetActive(true);
		}

		// Token: 0x04003500 RID: 13568
		[Header("References")]
		[SerializeField]
		private RectTransform anchor;

		// Token: 0x04003501 RID: 13569
		[SerializeField]
		private TextMeshProUGUI tooltipLabel;

		// Token: 0x04003502 RID: 13570
		[Header("Canvas")]
		public List<Canvas> canvases = new List<Canvas>();

		// Token: 0x04003503 RID: 13571
		private List<Canvas> sortedCanvases = new List<Canvas>();

		// Token: 0x04003504 RID: 13572
		private List<GraphicRaycaster> raycasters = new List<GraphicRaycaster>();

		// Token: 0x04003505 RID: 13573
		private EventSystem eventSystem;

		// Token: 0x04003506 RID: 13574
		private bool tooltipShownThisFrame;
	}
}
