using System;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000884 RID: 2180
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x06003B1C RID: 15132 RVA: 0x000F8C78 File Offset: 0x000F6E78
		public virtual void Harvest(bool giveProduct = true)
		{
			Plant componentInParent = base.GetComponentInParent<Plant>();
			if (giveProduct)
			{
				ItemInstance harvestedProduct = componentInParent.GetHarvestedProduct(this.ProductQuantity);
				ProductDefinition productDefinition = this.Product as ProductDefinition;
				if (productDefinition != null && !ProductManager.DiscoveredProducts.Contains(productDefinition))
				{
					NetworkSingleton<ProductManager>.Instance.DiscoverProduct(productDefinition.ID);
				}
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(harvestedProduct);
			}
			base.GetComponentInParent<Pot>().SendHarvestableActive(ArrayExt.IndexOf<Transform>(componentInParent.FinalGrowthStage.GrowthSites, base.transform.parent), false);
			GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject, GameObject.Find("_Temp").transform);
			gameObject.transform.position = base.transform.position;
			gameObject.transform.rotation = base.transform.rotation;
			gameObject.transform.localScale = base.transform.lossyScale;
			Object.Destroy(gameObject.GetComponent<PlantHarvestable>());
			Object.Destroy(gameObject.GetComponentInChildren<Collider>());
			gameObject.AddComponent(typeof(Rigidbody));
			Rigidbody component = gameObject.GetComponent<Rigidbody>();
			component.AddForce(Vector3.up * 1.5f, 2);
			component.AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(1f, 1f), Random.Range(-1f, 1f)) * 4f, 2);
			Object.Destroy(gameObject, 2f);
		}

		// Token: 0x04002AA5 RID: 10917
		public StorableItemDefinition Product;

		// Token: 0x04002AA6 RID: 10918
		public int ProductQuantity = 1;
	}
}
