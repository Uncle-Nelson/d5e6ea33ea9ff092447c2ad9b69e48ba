using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008EF RID: 2287
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06003DC3 RID: 15811 RVA: 0x00103074 File Offset: 0x00101274
		public Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			ProductIconManager.ProductIcon productIcon = this.icons.Find((ProductIconManager.ProductIcon x) => x.ProductID == productID && x.PackagingID == packagingID);
			if (productIcon == null)
			{
				if (!ignoreError)
				{
					Console.LogError(string.Concat(new string[]
					{
						"Failed to find icon for packaging (",
						packagingID,
						") containing product (",
						productID,
						")"
					}), null);
				}
				return null;
			}
			return productIcon.Icon;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x001030F8 File Offset: 0x001012F8
		public Sprite GenerateIcons(string productID)
		{
			if (Registry.GetItem(productID) == null)
			{
				Console.LogError("Failed to find product with ID: " + productID, null);
				return null;
			}
			if (this.icons.Any((ProductIconManager.ProductIcon x) => x.ProductID == productID) && Registry.GetItem(productID) != null)
			{
				return Registry.GetItem(productID).Icon;
			}
			for (int i = 0; i < this.Packaging.Length; i++)
			{
				Texture2D texture2D = this.GenerateProductTexture(productID, this.Packaging[i].ID);
				if (texture2D == null)
				{
					Console.LogError(string.Concat(new string[]
					{
						"Failed to generate icon for packaging (",
						this.Packaging[i].ID,
						") containing product (",
						productID,
						")"
					}), null);
				}
				else
				{
					ProductIconManager.ProductIcon productIcon = new ProductIconManager.ProductIcon();
					productIcon.ProductID = productID;
					productIcon.PackagingID = this.Packaging[i].ID;
					texture2D.Apply();
					productIcon.Icon = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f));
					this.icons.Add(productIcon);
				}
			}
			Texture2D texture2D2 = this.GenerateProductTexture(productID, "none");
			texture2D2.Apply();
			return Sprite.Create(texture2D2, new Rect(0f, 0f, (float)texture2D2.width, (float)texture2D2.height), new Vector2(0.5f, 0.5f));
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x001032B8 File Offset: 0x001014B8
		private Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			return this.IconGenerator.GeneratePackagingIcon(packagingID, productID);
		}

		// Token: 0x04002C86 RID: 11398
		[SerializeField]
		private List<ProductIconManager.ProductIcon> icons = new List<ProductIconManager.ProductIcon>();

		// Token: 0x04002C87 RID: 11399
		[Header("Product and packaging")]
		public IconGenerator IconGenerator;

		// Token: 0x04002C88 RID: 11400
		public string IconContainerPath = "ProductIcons";

		// Token: 0x04002C89 RID: 11401
		public ProductDefinition[] Products;

		// Token: 0x04002C8A RID: 11402
		public PackagingDefinition[] Packaging;

		// Token: 0x020008F0 RID: 2288
		[Serializable]
		public class ProductIcon
		{
			// Token: 0x04002C8B RID: 11403
			public string ProductID;

			// Token: 0x04002C8C RID: 11404
			public string PackagingID;

			// Token: 0x04002C8D RID: 11405
			public Sprite Icon;
		}
	}
}
