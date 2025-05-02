using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008BE RID: 2238
	public class CookableModule : ItemModule
	{
		// Token: 0x04002BC5 RID: 11205
		[Header("Cook Settings")]
		public int CookTime = 360;

		// Token: 0x04002BC6 RID: 11206
		public CookableModule.ECookableType CookType;

		// Token: 0x04002BC7 RID: 11207
		[Header("Product Settings")]
		public StorableItemDefinition Product;

		// Token: 0x04002BC8 RID: 11208
		public int ProductQuantity = 1;

		// Token: 0x04002BC9 RID: 11209
		public Rigidbody ProductShardPrefab;

		// Token: 0x04002BCA RID: 11210
		[Header("Appearance")]
		public Color LiquidColor;

		// Token: 0x04002BCB RID: 11211
		public Color SolidColor;

		// Token: 0x020008BF RID: 2239
		public enum ECookableType
		{
			// Token: 0x04002BCD RID: 11213
			Liquid,
			// Token: 0x04002BCE RID: 11214
			Solid
		}
	}
}
