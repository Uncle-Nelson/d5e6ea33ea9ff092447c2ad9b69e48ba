using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Map
{
	// Token: 0x02000AB0 RID: 2736
	public class MapApp : App<MapApp>
	{
		// Token: 0x0600499A RID: 18842 RVA: 0x00134658 File Offset: 0x00132858
		protected override void Start()
		{
			base.Start();
			this.BackgroundImage.sprite = (NetworkSingleton<GameManager>.Instance.IsTutorial ? this.TutorialMapSprite : this.MainMapSprite);
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00134688 File Offset: 0x00132888
		public override void SetOpen(bool open)
		{
			base.SetOpen(open);
			if (NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("MapAppOpen", open.ToString(), false);
			}
			if (open)
			{
				if (!this.opened && !this.SkipFocusPlayer)
				{
					this.opened = true;
					Player.Local.PoI.UpdatePosition();
					this.FocusPosition(Player.Local.PoI.UI.anchoredPosition);
				}
				if (Player.Local != null && Player.Local.PoI.UI != null)
				{
					Player.Local.PoI.UI.GetComponentInChildren<Animation>().Play();
				}
			}
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x0013473C File Offset: 0x0013293C
		protected override void Update()
		{
			base.Update();
			if (base.isOpen)
			{
				GameInput.GetButton(GameInput.ButtonCode.Right);
				GameInput.GetButton(GameInput.ButtonCode.Left);
				GameInput.GetButton(GameInput.ButtonCode.Forward);
				GameInput.GetButton(GameInput.ButtonCode.Backward);
				float x = this.ContentRect.localScale.x;
				if (x >= this.LabelScrollMin)
				{
					this.LabelGroup.alpha = Mathf.Clamp01((x - this.LabelScrollMin) / (this.LabelScrollMax - this.LabelScrollMin));
					return;
				}
				this.LabelGroup.alpha = 0f;
			}
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x001347C4 File Offset: 0x001329C4
		public void FocusPosition(Vector2 anchoredPosition)
		{
			this.ContentRect.pivot = new Vector2(0f, 1f);
			float num = 1.3f;
			Vector2 a = new Vector2(-this.ContentRect.sizeDelta.x / 2f, this.ContentRect.sizeDelta.y / 2f);
			a.x -= anchoredPosition.x;
			a.y -= anchoredPosition.y;
			this.ContentRect.localScale = new Vector3(num, num, num);
			this.ContentRect.anchoredPosition = a * num;
		}

		// Token: 0x040036B0 RID: 14000
		public const float KeyMoveSpeed = 1.25f;

		// Token: 0x040036B1 RID: 14001
		public RectTransform ContentRect;

		// Token: 0x040036B2 RID: 14002
		public RectTransform PoIContainer;

		// Token: 0x040036B3 RID: 14003
		public Scrollbar HorizontalScrollbar;

		// Token: 0x040036B4 RID: 14004
		public Scrollbar VerticalScrollbar;

		// Token: 0x040036B5 RID: 14005
		public Image BackgroundImage;

		// Token: 0x040036B6 RID: 14006
		public CanvasGroup LabelGroup;

		// Token: 0x040036B7 RID: 14007
		[Header("Settings")]
		public Sprite DemoMapSprite;

		// Token: 0x040036B8 RID: 14008
		public Sprite MainMapSprite;

		// Token: 0x040036B9 RID: 14009
		public Sprite TutorialMapSprite;

		// Token: 0x040036BA RID: 14010
		public float LabelScrollMin = 1.2f;

		// Token: 0x040036BB RID: 14011
		public float LabelScrollMax = 1.5f;

		// Token: 0x040036BC RID: 14012
		[HideInInspector]
		public bool SkipFocusPlayer;

		// Token: 0x040036BD RID: 14013
		private Coroutine contentMoveRoutine;

		// Token: 0x040036BE RID: 14014
		private bool opened;
	}
}
