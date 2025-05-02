using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000AC0 RID: 2752
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x06004A12 RID: 18962 RVA: 0x00136790 File Offset: 0x00134990
		public void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
			this.alignment = _alignment;
			this.text = _text;
			this.alignTextCenter = alignCenter;
			ColorBlock colors = this.button.colors;
			if (this.alignment == MessageBubble.Alignment.Left)
			{
				this.container.anchorMin = new Vector2(0f, 1f);
				this.container.anchorMax = new Vector2(0f, 1f);
				colors.normalColor = MessageBubble.backgroundColor_Left;
				colors.disabledColor = MessageBubble.backgroundColor_Left;
				this.content.color = MessageBubble.textColor_Left;
			}
			else if (this.alignment == MessageBubble.Alignment.Right)
			{
				this.container.anchorMin = new Vector2(1f, 1f);
				this.container.anchorMax = new Vector2(1f, 1f);
				colors.normalColor = MessageBubble.backgroundColor_Right;
				colors.disabledColor = MessageBubble.backgroundColor_Right;
				this.content.color = MessageBubble.textColor_Right;
			}
			else
			{
				this.container.anchorMin = new Vector2(0.5f, 1f);
				this.container.anchorMax = new Vector2(0.5f, 1f);
				colors.normalColor = MessageBubble.backgroundColor_Right;
				colors.disabledColor = MessageBubble.backgroundColor_Right;
				this.content.color = MessageBubble.textColor_Right;
			}
			this.button.colors = colors;
			this.RefreshDisplayedText();
			this.RefreshTriangle();
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00136930 File Offset: 0x00134B30
		protected virtual void Update()
		{
			if (this.text != this.displayedText)
			{
				this.RefreshDisplayedText();
			}
			if (this.showTriangle != this.triangleShown)
			{
				this.RefreshTriangle();
			}
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x00136960 File Offset: 0x00134B60
		public virtual void RefreshDisplayedText()
		{
			this.displayedText = this.text;
			this.content.text = this.displayedText;
			if (this.alignTextCenter)
			{
				this.content.alignment = 1;
			}
			else
			{
				this.content.alignment = 0;
			}
			RectTransform component = base.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(Mathf.Clamp(this.content.preferredWidth + 50f, this.bubble_MinWidth, this.bubble_MaxWidth), 75f);
			this.height = Mathf.Clamp(this.content.preferredHeight + 25f, 75f, float.MaxValue);
			component.sizeDelta = new Vector2(component.sizeDelta.x, this.height);
			float num = 1f;
			if (this.alignment == MessageBubble.Alignment.Right)
			{
				num = -1f;
			}
			else if (this.alignment == MessageBubble.Alignment.Center)
			{
				num = 0f;
			}
			if (this.autosetPosition)
			{
				component.anchoredPosition = new Vector2((component.sizeDelta.x / 2f + 25f) * num, -this.height / 2f);
			}
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00136A88 File Offset: 0x00134C88
		protected virtual void RefreshTriangle()
		{
			this.triangleShown = this.showTriangle;
			this.triangle_Left.gameObject.SetActive(false);
			this.triangle_Right.gameObject.SetActive(false);
			if (this.showTriangle)
			{
				this.triangle_Left.color = this.button.colors.normalColor;
				this.triangle_Right.color = this.button.colors.normalColor;
				if (this.alignment == MessageBubble.Alignment.Left)
				{
					this.triangle_Left.gameObject.SetActive(true);
					return;
				}
				this.triangle_Right.gameObject.SetActive(true);
			}
		}

		// Token: 0x0400372B RID: 14123
		[Header("Settings")]
		public string text = string.Empty;

		// Token: 0x0400372C RID: 14124
		public MessageBubble.Alignment alignment = MessageBubble.Alignment.Left;

		// Token: 0x0400372D RID: 14125
		public bool showTriangle;

		// Token: 0x0400372E RID: 14126
		public float bubble_MinWidth = 75f;

		// Token: 0x0400372F RID: 14127
		public float bubble_MaxWidth = 500f;

		// Token: 0x04003730 RID: 14128
		public bool alignTextCenter;

		// Token: 0x04003731 RID: 14129
		public bool autosetPosition = true;

		// Token: 0x04003732 RID: 14130
		private string displayedText = string.Empty;

		// Token: 0x04003733 RID: 14131
		private bool triangleShown;

		// Token: 0x04003734 RID: 14132
		[Header("References")]
		public RectTransform container;

		// Token: 0x04003735 RID: 14133
		[SerializeField]
		protected Image bubble;

		// Token: 0x04003736 RID: 14134
		[SerializeField]
		protected Text content;

		// Token: 0x04003737 RID: 14135
		[SerializeField]
		protected Image triangle_Left;

		// Token: 0x04003738 RID: 14136
		[SerializeField]
		protected Image triangle_Right;

		// Token: 0x04003739 RID: 14137
		public Button button;

		// Token: 0x0400373A RID: 14138
		public float height;

		// Token: 0x0400373B RID: 14139
		public float spacingAbove;

		// Token: 0x0400373C RID: 14140
		public static Color32 backgroundColor_Left = new Color32(225, 225, 225, byte.MaxValue);

		// Token: 0x0400373D RID: 14141
		public static Color32 textColor_Left = new Color32(50, 50, 50, byte.MaxValue);

		// Token: 0x0400373E RID: 14142
		public static Color32 backgroundColor_Right = new Color32(75, 175, 225, byte.MaxValue);

		// Token: 0x0400373F RID: 14143
		public static Color32 textColor_Right = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04003740 RID: 14144
		public static float baseBubbleSpacing = 5f;

		// Token: 0x02000AC1 RID: 2753
		public enum Alignment
		{
			// Token: 0x04003742 RID: 14146
			Center,
			// Token: 0x04003743 RID: 14147
			Left,
			// Token: 0x04003744 RID: 14148
			Right
		}
	}
}
