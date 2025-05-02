using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	// Token: 0x020002A0 RID: 672
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0003ED79 File Offset: 0x0003CF79
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0003ED81 File Offset: 0x0003CF81
		public SnakeTile.TileType Type { get; private set; }

		// Token: 0x06000E0B RID: 3595 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		public void SetType(SnakeTile.TileType type, int index = 0)
		{
			this.Type = type;
			switch (this.Type)
			{
			case SnakeTile.TileType.Empty:
				base.gameObject.SetActive(false);
				return;
			case SnakeTile.TileType.Snake:
				this.Image.color = this.SnakeColor;
				if (index > 0)
				{
					float a = 1f - 0.8f * Mathf.Sqrt((float)index / 240f);
					this.Image.color = new Color(this.SnakeColor.r, this.SnakeColor.g, this.SnakeColor.b, a);
				}
				base.gameObject.SetActive(true);
				return;
			case SnakeTile.TileType.Food:
				this.Image.color = this.FoodColor;
				base.gameObject.SetActive(true);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0003EE54 File Offset: 0x0003D054
		public void SetPosition(Vector2 position, float tileSize)
		{
			this.Position = position;
			this.RectTransform.anchoredPosition = new Vector2((0.5f + position.x) * tileSize, (0.5f + position.y) * tileSize);
			base.gameObject.name = string.Format("Tile {0}, {1}", position.x, position.y);
			this.RectTransform.sizeDelta = new Vector2(tileSize, tileSize);
		}

		// Token: 0x04000EBA RID: 3770
		public Vector2 Position = Vector2.zero;

		// Token: 0x04000EBB RID: 3771
		public Color SnakeColor;

		// Token: 0x04000EBC RID: 3772
		public Color FoodColor;

		// Token: 0x04000EBD RID: 3773
		public RectTransform RectTransform;

		// Token: 0x04000EBE RID: 3774
		public Image Image;

		// Token: 0x020002A1 RID: 673
		public enum TileType
		{
			// Token: 0x04000EC0 RID: 3776
			Empty,
			// Token: 0x04000EC1 RID: 3777
			Snake,
			// Token: 0x04000EC2 RID: 3778
			Food
		}
	}
}
