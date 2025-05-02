using System;
using System.Collections.Generic;
using System.Linq;
using FishNet.Serializing.Helping;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Packaging;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Properties;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008F3 RID: 2291
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x00103320 File Offset: 0x00101520
		[CodegenExclude]
		public PackagingDefinition AppliedPackaging
		{
			get
			{
				if (this.packaging == null && this.PackagingID != string.Empty)
				{
					this.packaging = (Registry.GetItem(this.PackagingID) as PackagingDefinition);
					if (this.packaging == null)
					{
						Console.LogError("Failed to load packaging with ID (" + this.PackagingID + ")", null);
					}
				}
				return this.packaging;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x00103392 File Offset: 0x00101592
		[CodegenExclude]
		public int Amount
		{
			get
			{
				if (!(this.AppliedPackaging != null))
				{
					return 1;
				}
				return this.AppliedPackaging.Quantity;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x001033AF File Offset: 0x001015AF
		public override string Name
		{
			get
			{
				return base.Name + ((this.packaging == null) ? " (Unpackaged)" : string.Empty);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x001033D6 File Offset: 0x001015D6
		[CodegenExclude]
		public override Equippable Equippable
		{
			get
			{
				return this.GetEquippable();
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x001033DE File Offset: 0x001015DE
		[CodegenExclude]
		public override StoredItem StoredItem
		{
			get
			{
				return this.GetStoredItem();
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x001033E6 File Offset: 0x001015E6
		[CodegenExclude]
		public override Sprite Icon
		{
			get
			{
				return this.GetIcon();
			}
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001033EE File Offset: 0x001015EE
		public ProductItemInstance()
		{
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00103404 File Offset: 0x00101604
		public ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null) : base(definition, quantity, quality)
		{
			this.packaging = _packaging;
			if (this.packaging != null)
			{
				this.PackagingID = this.packaging.ID;
				return;
			}
			this.PackagingID = string.Empty;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00103458 File Offset: 0x00101658
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			if (!(other is ProductItemInstance))
			{
				return false;
			}
			if ((other as ProductItemInstance).AppliedPackaging != null)
			{
				if (this.AppliedPackaging == null)
				{
					return false;
				}
				if ((other as ProductItemInstance).AppliedPackaging.ID != this.AppliedPackaging.ID)
				{
					return false;
				}
			}
			else if (this.AppliedPackaging != null)
			{
				return false;
			}
			return base.CanStackWith(other, checkQuantities);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x001034D0 File Offset: 0x001016D0
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new ProductItemInstance(base.Definition, quantity, this.Quality, this.AppliedPackaging);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00103504 File Offset: 0x00101704
		public virtual void SetPackaging(PackagingDefinition def)
		{
			this.packaging = def;
			if (this.packaging != null)
			{
				this.PackagingID = this.packaging.ID;
			}
			else
			{
				this.PackagingID = string.Empty;
			}
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00103557 File Offset: 0x00101757
		private Equippable GetEquippable()
		{
			if (this.AppliedPackaging != null)
			{
				return this.AppliedPackaging.Equippable_Filled;
			}
			return base.Equippable;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00103579 File Offset: 0x00101779
		private StoredItem GetStoredItem()
		{
			if (this.AppliedPackaging != null)
			{
				return this.AppliedPackaging.StoredItem_Filled;
			}
			return base.StoredItem;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0010359B File Offset: 0x0010179B
		public virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			visuals.ResetVisuals();
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001035A3 File Offset: 0x001017A3
		private Sprite GetIcon()
		{
			if (this.AppliedPackaging != null)
			{
				return Singleton<ProductIconManager>.Instance.GetIcon(this.ID, this.AppliedPackaging.ID, false);
			}
			return base.Icon;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x001035D6 File Offset: 0x001017D6
		public override ItemData GetItemData()
		{
			return new ProductItemData(this.ID, this.Quantity, this.Quality.ToString(), this.PackagingID);
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00103600 File Offset: 0x00101800
		public virtual float GetAddictiveness()
		{
			return (base.Definition as ProductDefinition).GetAddictiveness();
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00103614 File Offset: 0x00101814
		public float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			ProductDefinition productDefinition = base.Definition as ProductDefinition;
			float num = 0f;
			if (other.DrugType == productDefinition.DrugType)
			{
				num = 0.4f;
			}
			int num2 = 0;
			for (int i = 0; i < other.Properties.Count; i++)
			{
				if (productDefinition.HasProperty(other.Properties[i]))
				{
					num2++;
				}
			}
			for (int j = 0; j < productDefinition.Properties.Count; j++)
			{
				if (!other.HasProperty(productDefinition.Properties[j]))
				{
					num2--;
				}
			}
			float num3 = 0.3f;
			int num4 = Mathf.Max(productDefinition.Properties.Count, other.Properties.Count);
			if (num4 > 0)
			{
				num3 *= Mathf.Clamp01((float)num2 / (float)num4);
			}
			float num5 = Mathf.Clamp((float)this.Quality / (float)quality, 0f, 1f) * 0.3f;
			return Mathf.Clamp01(num + num3 + num5);
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00103714 File Offset: 0x00101914
		public virtual void ApplyEffectsToNPC(NPC npc)
		{
			List<Property> list = new List<Property>();
			list.AddRange((base.Definition as ProductDefinition).Properties);
			list = (from x in list
			orderby x.Tier
			select x).ToList<Property>();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ApplyToNPC(npc);
			}
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00103788 File Offset: 0x00101988
		public virtual void ClearEffectsFromNPC(NPC npc)
		{
			List<Property> list = new List<Property>();
			list.AddRange((base.Definition as ProductDefinition).Properties);
			list = (from x in list
			orderby x.Tier
			select x).ToList<Property>();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ClearFromNPC(npc);
			}
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x001037FC File Offset: 0x001019FC
		public virtual void ApplyEffectsToPlayer(Player player)
		{
			List<Property> list = new List<Property>();
			list.AddRange((base.Definition as ProductDefinition).Properties);
			list = (from x in list
			orderby x.Tier
			select x).ToList<Property>();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ApplyToPlayer(player);
			}
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00103870 File Offset: 0x00101A70
		public virtual void ClearEffectsFromPlayer(Player Player)
		{
			List<Property> list = new List<Property>();
			list.AddRange((base.Definition as ProductDefinition).Properties);
			list = (from x in list
			orderby x.Tier
			select x).ToList<Property>();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ClearFromPlayer(Player);
			}
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x001038E2 File Offset: 0x00101AE2
		public override float GetMonetaryValue()
		{
			if (this.definition == null)
			{
				Console.LogWarning("ProductItemInstance.GetMonetaryValue() - Definition is null", null);
				return 0f;
			}
			return (this.definition as ProductDefinition).MarketValue * (float)this.Quantity;
		}

		// Token: 0x04002C91 RID: 11409
		public string PackagingID = string.Empty;

		// Token: 0x04002C92 RID: 11410
		[CodegenExclude]
		private PackagingDefinition packaging;
	}
}
