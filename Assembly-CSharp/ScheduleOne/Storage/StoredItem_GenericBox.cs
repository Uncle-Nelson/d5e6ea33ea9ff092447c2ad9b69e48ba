using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B8 RID: 2232
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x06003CB7 RID: 15543 RVA: 0x000FFBE4 File Offset: 0x000FDDE4
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			this.icon1.sprite = _item.Icon;
			this.icon2.sprite = _item.Icon;
			float num = 0.025f / (_item.Icon.rect.width / 1024f) * this.IconScale;
			this.icon1.transform.localScale = new Vector3(num, num, 1f);
			this.icon2.transform.localScale = new Vector3(num, num, 1f);
		}

		// Token: 0x04002B9B RID: 11163
		private const float ReferenceIconWidth = 1024f;

		// Token: 0x04002B9C RID: 11164
		[Header("References")]
		[SerializeField]
		protected SpriteRenderer icon1;

		// Token: 0x04002B9D RID: 11165
		[SerializeField]
		protected SpriteRenderer icon2;

		// Token: 0x04002B9E RID: 11166
		[Header("Settings")]
		public float IconScale = 0.5f;
	}
}
