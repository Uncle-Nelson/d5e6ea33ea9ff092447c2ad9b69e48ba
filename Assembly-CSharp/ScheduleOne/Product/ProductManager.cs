using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Properties;
using ScheduleOne.Properties.MixMaps;
using ScheduleOne.StationFramework;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x020008F7 RID: 2295
	public class ProductManager : NetworkSingleton<ProductManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x00103B50 File Offset: 0x00101D50
		public static bool MethDiscovered
		{
			get
			{
				return ProductManager.DiscoveredProducts.Any((ProductDefinition p) => p.ID == "meth");
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x00103B7B File Offset: 0x00101D7B
		public static bool CocaineDiscovered
		{
			get
			{
				return ProductManager.DiscoveredProducts.Any((ProductDefinition p) => p.ID == "cocaine");
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x00103BA6 File Offset: 0x00101DA6
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x00103BAD File Offset: 0x00101DAD
		public static bool IsAcceptingOrders { get; private set; } = true;

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00103BB5 File Offset: 0x00101DB5
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x00103BBD File Offset: 0x00101DBD
		public NewMixOperation CurrentMixOperation { get; private set; }

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x00103BC6 File Offset: 0x00101DC6
		public bool IsMixingInProgress
		{
			get
			{
				return this.CurrentMixOperation != null;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00103BD1 File Offset: 0x00101DD1
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x00103BD9 File Offset: 0x00101DD9
		public bool IsMixComplete { get; private set; }

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x00103BE2 File Offset: 0x00101DE2
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x00103BEA File Offset: 0x00101DEA
		public float TimeSinceProductListingChanged { get; private set; }

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x00103BF3 File Offset: 0x00101DF3
		public string SaveFolderName
		{
			get
			{
				return "Products";
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x00103BF3 File Offset: 0x00101DF3
		public string SaveFileName
		{
			get
			{
				return "Products";
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x00103BFA File Offset: 0x00101DFA
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x00103C02 File Offset: 0x00101E02
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x00103C0A File Offset: 0x00101E0A
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x00103C13 File Offset: 0x00101E13
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x00103C1B File Offset: 0x00101E1B
		public List<string> LocalExtraFolders { get; set; } = new List<string>
		{
			"CreatedProducts"
		};

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x00103C24 File Offset: 0x00101E24
		// (set) Token: 0x06003E03 RID: 15875 RVA: 0x00103C2C File Offset: 0x00101E2C
		public bool HasChanged { get; set; }

		// Token: 0x06003E04 RID: 15876 RVA: 0x00103C35 File Offset: 0x00101E35
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Product.ProductManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00103C4C File Offset: 0x00101E4C
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.Clean));
			foreach (ProductDefinition productDefinition in this.DefaultKnownProducts)
			{
				productDefinition.OnValidate();
				if (this.highestValueProduct == null || productDefinition.MarketValue > this.highestValueProduct.MarketValue)
				{
					this.highestValueProduct = productDefinition;
				}
			}
			foreach (ProductDefinition productDefinition2 in this.AllProducts)
			{
				if (!this.ProductNames.Contains(productDefinition2.Name))
				{
					this.ProductNames.Add(productDefinition2.Name);
				}
				if (!this.ProductPrices.ContainsKey(productDefinition2))
				{
					this.ProductPrices.Add(productDefinition2, productDefinition2.MarketValue);
				}
			}
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepEnd.AddListener(new UnityAction(this.OnNewDay));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.OnMinPass));
			foreach (PropertyItemDefinition propertyItemDefinition in this.ValidMixIngredients)
			{
				for (int i = 0; i < propertyItemDefinition.Properties.Count; i++)
				{
					if (!Singleton<PropertyUtility>.Instance.AllProperties.Contains(propertyItemDefinition.Properties[i]))
					{
						string[] array = new string[5];
						array[0] = "Mixer ";
						array[1] = propertyItemDefinition.Name;
						array[2] = " has property ";
						int num = 3;
						Property property = propertyItemDefinition.Properties[i];
						array[num] = ((property != null) ? property.ToString() : null);
						array[4] = " that is not in the valid properties list";
						Console.LogError(string.Concat(array), null);
					}
				}
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00103E78 File Offset: 0x00102078
		public override void OnStartServer()
		{
			base.OnStartServer();
			for (int i = 0; i < this.DefaultKnownProducts.Count; i++)
			{
				this.SetProductDiscovered(null, this.DefaultKnownProducts[i].ID, false);
			}
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00103EBA File Offset: 0x001020BA
		public override void OnStartClient()
		{
			base.OnStartClient();
			this.RefreshHighestValueProduct();
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00103EC8 File Offset: 0x001020C8
		private void Update()
		{
			this.TimeSinceProductListingChanged += Time.deltaTime;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00103EDC File Offset: 0x001020DC
		private void Clean()
		{
			ProductManager.DiscoveredProducts.Clear();
			ProductManager.ListedProducts.Clear();
			ProductManager.FavouritedProducts.Clear();
			ProductManager.IsAcceptingOrders = true;
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00103F02 File Offset: 0x00102102
		[ServerRpc(RequireOwnership = false)]
		public void SetMethDiscovered()
		{
			this.RpcWriter___Server_SetMethDiscovered_2166136261();
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00103F0A File Offset: 0x0010210A
		[ServerRpc(RequireOwnership = false)]
		public void SetCocaineDiscovered()
		{
			this.RpcWriter___Server_SetCocaineDiscovered_2166136261();
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00103F14 File Offset: 0x00102114
		public MixerMap GetMixerMap(EDrugType type)
		{
			switch (type)
			{
			case EDrugType.Marijuana:
				return this.WeedMixMap;
			case EDrugType.Methamphetamine:
				return this.MethMixMap;
			case EDrugType.Cocaine:
				return this.CokeMixMap;
			default:
				Console.LogError("No mixer map found for " + type.ToString(), null);
				return null;
			}
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00103F68 File Offset: 0x00102168
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			foreach (ProductDefinition productDefinition in this.createdProducts)
			{
				if (productDefinition is WeedDefinition)
				{
					WeedDefinition weedDefinition = productDefinition as WeedDefinition;
					WeedAppearanceSettings appearance = new WeedAppearanceSettings(weedDefinition.MainMat.color, weedDefinition.SecondaryMat.color, weedDefinition.LeafMat.color, weedDefinition.StemMat.color);
					List<string> list = new List<string>();
					foreach (Property property in weedDefinition.Properties)
					{
						list.Add(property.ID);
					}
					this.CreateWeed(connection, productDefinition.Name, productDefinition.ID, EDrugType.Marijuana, list, appearance);
				}
				else if (productDefinition is MethDefinition)
				{
					MethDefinition methDefinition = productDefinition as MethDefinition;
					MethAppearanceSettings appearanceSettings = methDefinition.AppearanceSettings;
					List<string> list2 = new List<string>();
					foreach (Property property2 in methDefinition.Properties)
					{
						list2.Add(property2.ID);
					}
					this.CreateMeth(connection, productDefinition.Name, productDefinition.ID, EDrugType.Methamphetamine, list2, appearanceSettings);
				}
				else if (productDefinition is CocaineDefinition)
				{
					CocaineDefinition cocaineDefinition = productDefinition as CocaineDefinition;
					CocaineAppearanceSettings appearanceSettings2 = cocaineDefinition.AppearanceSettings;
					List<string> list3 = new List<string>();
					foreach (Property property3 in cocaineDefinition.Properties)
					{
						list3.Add(property3.ID);
					}
					this.CreateCocaine(connection, productDefinition.Name, productDefinition.ID, EDrugType.Cocaine, list3, appearanceSettings2);
				}
			}
			for (int i = 0; i < this.mixRecipes.Count; i++)
			{
				this.CreateMixRecipe(null, this.mixRecipes[i].Ingredients[1].Items[0].ID, this.mixRecipes[i].Ingredients[0].Items[0].ID, this.mixRecipes[i].Product.Item.ID);
			}
			for (int j = 0; j < ProductManager.DiscoveredProducts.Count; j++)
			{
				this.SetProductDiscovered(connection, ProductManager.DiscoveredProducts[j].ID, false);
			}
			for (int k = 0; k < ProductManager.ListedProducts.Count; k++)
			{
				this.SetProductListed(connection, ProductManager.ListedProducts[k].ID, true);
			}
			for (int l = 0; l < ProductManager.FavouritedProducts.Count; l++)
			{
				this.SetProductFavourited(connection, ProductManager.FavouritedProducts[l].ID, true);
			}
			foreach (KeyValuePair<ProductDefinition, float> keyValuePair in this.ProductPrices)
			{
				this.SetPrice(connection, keyValuePair.Key.ID, keyValuePair.Value);
			}
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00104340 File Offset: 0x00102540
		private void OnMinPass()
		{
			if (!NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				return;
			}
			if (GameManager.IS_TUTORIAL)
			{
				return;
			}
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("SecondUniqueProductDiscovered"))
			{
				float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Inventory_OGKush");
				if (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Inventory_Weed_Count") > value)
				{
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("SecondUniqueProductDiscovered", true.ToString(), true);
					if (this.onSecondUniqueProductCreated != null)
					{
						this.onSecondUniqueProductCreated.Invoke();
					}
				}
			}
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x001043BC File Offset: 0x001025BC
		private void OnNewDay()
		{
			if (InstanceFinder.IsServer && this.CurrentMixOperation != null && !this.IsMixComplete)
			{
				this.SetMixOperation(this.CurrentMixOperation, true);
			}
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x001043E2 File Offset: 0x001025E2
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductListed(string productID, bool listed)
		{
			this.RpcWriter___Server_SetProductListed_310431262(productID, listed);
			this.RpcLogic___SetProductListed_310431262(productID, listed);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00104400 File Offset: 0x00102600
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductListed(NetworkConnection conn, string productID, bool listed)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetProductListed_619441887(conn, productID, listed);
				this.RpcLogic___SetProductListed_619441887(conn, productID, listed);
			}
			else
			{
				this.RpcWriter___Target_SetProductListed_619441887(conn, productID, listed);
			}
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0010444D File Offset: 0x0010264D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductFavourited(string productID, bool listed)
		{
			this.RpcWriter___Server_SetProductFavourited_310431262(productID, listed);
			this.RpcLogic___SetProductFavourited_310431262(productID, listed);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0010446C File Offset: 0x0010266C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductFavourited(NetworkConnection conn, string productID, bool fav)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetProductFavourited_619441887(conn, productID, fav);
				this.RpcLogic___SetProductFavourited_619441887(conn, productID, fav);
			}
			else
			{
				this.RpcWriter___Target_SetProductFavourited_619441887(conn, productID, fav);
			}
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x001044B9 File Offset: 0x001026B9
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DiscoverProduct(string productID)
		{
			this.RpcWriter___Server_DiscoverProduct_3615296227(productID);
			this.RpcLogic___DiscoverProduct_3615296227(productID);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x001044D0 File Offset: 0x001026D0
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductDiscovered(NetworkConnection conn, string productID, bool autoList)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetProductDiscovered_619441887(conn, productID, autoList);
				this.RpcLogic___SetProductDiscovered_619441887(conn, productID, autoList);
			}
			else
			{
				this.RpcWriter___Target_SetProductDiscovered_619441887(conn, productID, autoList);
			}
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0010451D File Offset: 0x0010271D
		public void SetIsAcceptingOrder(bool accepting)
		{
			ProductManager.IsAcceptingOrders = accepting;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00104525 File Offset: 0x00102725
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateWeed_Server(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			this.RpcWriter___Server_CreateWeed_Server_2331775230(name, id, type, properties, appearance);
			this.RpcLogic___CreateWeed_Server_2331775230(name, id, type, properties, appearance);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0010455C File Offset: 0x0010275C
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateWeed(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateWeed_1777266891(conn, name, id, type, properties, appearance);
				this.RpcLogic___CreateWeed_1777266891(conn, name, id, type, properties, appearance);
			}
			else
			{
				this.RpcWriter___Target_CreateWeed_1777266891(conn, name, id, type, properties, appearance);
			}
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x001045CD File Offset: 0x001027CD
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateCocaine_Server(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			this.RpcWriter___Server_CreateCocaine_Server_891166717(name, id, type, properties, appearance);
			this.RpcLogic___CreateCocaine_Server_891166717(name, id, type, properties, appearance);
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00104604 File Offset: 0x00102804
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateCocaine(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateCocaine_1327282946(conn, name, id, type, properties, appearance);
				this.RpcLogic___CreateCocaine_1327282946(conn, name, id, type, properties, appearance);
			}
			else
			{
				this.RpcWriter___Target_CreateCocaine_1327282946(conn, name, id, type, properties, appearance);
			}
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00104675 File Offset: 0x00102875
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateMeth_Server(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			this.RpcWriter___Server_CreateMeth_Server_4251728555(name, id, type, properties, appearance);
			this.RpcLogic___CreateMeth_Server_4251728555(name, id, type, properties, appearance);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x001046AC File Offset: 0x001028AC
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateMeth(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateMeth_1869045686(conn, name, id, type, properties, appearance);
				this.RpcLogic___CreateMeth_1869045686(conn, name, id, type, properties, appearance);
			}
			else
			{
				this.RpcWriter___Target_CreateMeth_1869045686(conn, name, id, type, properties, appearance);
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00104720 File Offset: 0x00102920
		private void RefreshHighestValueProduct()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			for (int i = 0; i < ProductManager.DiscoveredProducts.Count; i++)
			{
				if (this.highestValueProduct == null || ProductManager.DiscoveredProducts[i].MarketValue > this.highestValueProduct.MarketValue)
				{
					this.highestValueProduct = ProductManager.DiscoveredProducts[i];
				}
			}
			float marketValue = this.highestValueProduct.MarketValue;
			if (marketValue >= 100f)
			{
				Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.MASTER_CHEF);
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("HighestValueProduct", marketValue.ToString(), true);
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x001047BC File Offset: 0x001029BC
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixRecipe(string product, string mixer, string output)
		{
			this.RpcWriter___Server_SendMixRecipe_852232071(product, mixer, output);
			this.RpcLogic___SendMixRecipe_852232071(product, mixer, output);
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x001047E4 File Offset: 0x001029E4
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateMixRecipe(NetworkConnection conn, string product, string mixer, string output)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_CreateMixRecipe_1410895574(conn, product, mixer, output);
				this.RpcLogic___CreateMixRecipe_1410895574(conn, product, mixer, output);
			}
			else
			{
				this.RpcWriter___Target_CreateMixRecipe_1410895574(conn, product, mixer, output);
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x00104840 File Offset: 0x00102A40
		public StationRecipe GetRecipe(string product, string mixer)
		{
			return this.mixRecipes.Find((StationRecipe r) => r.Product.Item.ID == product && r.Ingredients[0].Items[0].ID == mixer);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00104878 File Offset: 0x00102A78
		public StationRecipe GetRecipe(List<Property> productProperties, Property mixerProperty)
		{
			Console.Log("Trying to find recipe with product properties: " + string.Join<Property>(", ", productProperties) + " and mixer property: " + mixerProperty.Name, null);
			foreach (StationRecipe stationRecipe in this.mixRecipes)
			{
				if (!(stationRecipe == null) && stationRecipe.Ingredients.Count >= 2)
				{
					ItemDefinition item = stationRecipe.Ingredients[0].Item;
					ItemDefinition item2 = stationRecipe.Ingredients[1].Item;
					if (!(item == null) && !(item2 == null))
					{
						PropertyItemDefinition propertyItemDefinition = item as PropertyItemDefinition;
						List<Property> list = (propertyItemDefinition != null) ? propertyItemDefinition.Properties : null;
						PropertyItemDefinition propertyItemDefinition2 = item2 as PropertyItemDefinition;
						List<Property> list2 = (propertyItemDefinition2 != null) ? propertyItemDefinition2.Properties : null;
						if (item2 is ProductDefinition)
						{
							PropertyItemDefinition propertyItemDefinition3 = item2 as PropertyItemDefinition;
							list = ((propertyItemDefinition3 != null) ? propertyItemDefinition3.Properties : null);
							PropertyItemDefinition propertyItemDefinition4 = item as PropertyItemDefinition;
							list2 = ((propertyItemDefinition4 != null) ? propertyItemDefinition4.Properties : null);
						}
						if (list.Count == productProperties.Count && list2.Count == 1)
						{
							bool flag = true;
							for (int i = 0; i < productProperties.Count; i++)
							{
								if (!list.Contains(productProperties[i]))
								{
									flag = false;
									break;
								}
							}
							if (flag && !(list2[0] != mixerProperty))
							{
								return stationRecipe;
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00104A14 File Offset: 0x00102C14
		[TargetRpc]
		private void GiveItem(NetworkConnection conn, string id)
		{
			this.RpcWriter___Target_GiveItem_2971853958(conn, id);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00104A24 File Offset: 0x00102C24
		public ProductDefinition GetKnownProduct(EDrugType type, List<Property> properties)
		{
			foreach (ProductDefinition productDefinition in this.AllProducts)
			{
				if (productDefinition.DrugTypes[0].DrugType == type && productDefinition.Properties.Count == properties.Count)
				{
					int num = 0;
					while (num < properties.Count && productDefinition.Properties.Contains(properties[num]))
					{
						if (num == properties.Count - 1)
						{
							return productDefinition;
						}
						num++;
					}
				}
			}
			return null;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00104AD0 File Offset: 0x00102CD0
		public float GetPrice(ProductDefinition product)
		{
			if (product == null)
			{
				Console.LogError("Product is null", null);
				return 1f;
			}
			if (this.ProductPrices.ContainsKey(product))
			{
				return Mathf.Clamp(this.ProductPrices[product], 1f, 999f);
			}
			Console.LogError("Price not found for product: " + product.ID + ". Returning market value", null);
			return Mathf.Clamp(product.MarketValue, 1f, 999f);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00104B51 File Offset: 0x00102D51
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPrice(string productID, float value)
		{
			this.RpcWriter___Server_SendPrice_606697822(productID, value);
			this.RpcLogic___SendPrice_606697822(productID, value);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00104B70 File Offset: 0x00102D70
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetPrice(NetworkConnection conn, string productID, float value)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetPrice_4077118173(conn, productID, value);
				this.RpcLogic___SetPrice_4077118173(conn, productID, value);
			}
			else
			{
				this.RpcWriter___Target_SetPrice_4077118173(conn, productID, value);
			}
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00104BBD File Offset: 0x00102DBD
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixOperation(NewMixOperation operation, bool complete)
		{
			this.RpcWriter___Server_SendMixOperation_3670976965(operation, complete);
			this.RpcLogic___SendMixOperation_3670976965(operation, complete);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00104BDB File Offset: 0x00102DDB
		[ObserversRpc(RunLocally = true)]
		private void SetMixOperation(NewMixOperation operation, bool complete)
		{
			this.RpcWriter___Observers_SetMixOperation_3670976965(operation, complete);
			this.RpcLogic___SetMixOperation_3670976965(operation, complete);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00104BFC File Offset: 0x00102DFC
		public string FinishAndNameMix(string productID, string ingredientID, string mixName)
		{
			if (!ProductManager.IsMixNameValid(mixName))
			{
				Console.LogError("Invalid mix name. Using random name", null);
				mixName = Singleton<NewMixScreen>.Instance.GenerateUniqueName(null, EDrugType.Marijuana);
			}
			string text = mixName.ToLower().Replace(" ", string.Empty);
			text = ProductManager.MakeIDFileSafe(text);
			text = text.Replace(" ", string.Empty);
			text = text.Replace("(", string.Empty);
			text = text.Replace(")", string.Empty);
			text = text.Replace("'", string.Empty);
			text = text.Replace("\"", string.Empty);
			text = text.Replace(":", string.Empty);
			text = text.Replace(";", string.Empty);
			text = text.Replace(",", string.Empty);
			text = text.Replace(".", string.Empty);
			text = text.Replace("!", string.Empty);
			text = text.Replace("?", string.Empty);
			this.FinishAndNameMix(productID, ingredientID, mixName, text);
			if (!InstanceFinder.IsServer)
			{
				this.SendFinishAndNameMix(productID, ingredientID, mixName, text);
			}
			return text;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00104D20 File Offset: 0x00102F20
		public static string MakeIDFileSafe(string id)
		{
			id = id.ToLower();
			id = id.Replace(" ", string.Empty);
			id = id.Replace("(", string.Empty);
			id = id.Replace(")", string.Empty);
			id = id.Replace("'", string.Empty);
			id = id.Replace("\"", string.Empty);
			id = id.Replace(":", string.Empty);
			id = id.Replace(";", string.Empty);
			id = id.Replace(",", string.Empty);
			id = id.Replace(".", string.Empty);
			id = id.Replace("!", string.Empty);
			id = id.Replace("?", string.Empty);
			return id;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00104DFC File Offset: 0x00102FFC
		public static bool IsMixNameValid(string mixName)
		{
			return !string.IsNullOrEmpty(mixName);
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00104E0C File Offset: 0x0010300C
		[ObserversRpc(RunLocally = true)]
		private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
			this.RpcWriter___Observers_FinishAndNameMix_4237212381(productID, ingredientID, mixName, mixID);
			this.RpcLogic___FinishAndNameMix_4237212381(productID, ingredientID, mixName, mixID);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00104E45 File Offset: 0x00103045
		[ServerRpc(RequireOwnership = false)]
		private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
			this.RpcWriter___Server_SendFinishAndNameMix_4237212381(productID, ingredientID, mixName, mixID);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00104E5D File Offset: 0x0010305D
		public static float CalculateProductValue(ProductDefinition product, float baseValue)
		{
			return ProductManager.CalculateProductValue(baseValue, product.Properties);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00104E6C File Offset: 0x0010306C
		public static float CalculateProductValue(float baseValue, List<Property> properties)
		{
			float num = baseValue;
			float num2 = 1f;
			for (int i = 0; i < properties.Count; i++)
			{
				num += (float)properties[i].ValueChange;
				num += baseValue * properties[i].AddBaseValueMultiple;
				num2 *= properties[i].ValueMultiplier;
			}
			num *= num2;
			return (float)Mathf.RoundToInt(num);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00104ED0 File Offset: 0x001030D0
		public virtual string GetSaveString()
		{
			string[] array = new string[ProductManager.DiscoveredProducts.Count];
			for (int i = 0; i < ProductManager.DiscoveredProducts.Count; i++)
			{
				array[i] = ProductManager.DiscoveredProducts[i].ID;
			}
			string[] array2 = new string[ProductManager.ListedProducts.Count];
			for (int j = 0; j < ProductManager.ListedProducts.Count; j++)
			{
				array2[j] = ProductManager.ListedProducts[j].ID;
			}
			string[] array3 = new string[ProductManager.FavouritedProducts.Count];
			for (int k = 0; k < ProductManager.FavouritedProducts.Count; k++)
			{
				array3[k] = ProductManager.FavouritedProducts[k].ID;
			}
			MixRecipeData[] array4 = new MixRecipeData[this.mixRecipes.Count];
			for (int l = 0; l < this.mixRecipes.Count; l++)
			{
				array4[l] = new MixRecipeData(this.mixRecipes[l].Ingredients[1].Items[0].ID, this.mixRecipes[l].Ingredients[0].Items[0].ID, this.mixRecipes[l].Product.Item.ID);
			}
			StringIntPair[] array5 = new StringIntPair[this.ProductPrices.Count];
			for (int m = 0; m < this.AllProducts.Count; m++)
			{
				array5[m] = new StringIntPair(this.AllProducts[m].ID, Mathf.RoundToInt(this.ProductPrices[this.AllProducts[m]]));
			}
			return new ProductManagerData(array, array2, this.CurrentMixOperation, this.IsMixComplete, array4, array5, array3).GetJson(true);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x001050BC File Offset: 0x001032BC
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> result = new List<string>();
			string parentFolderPath2 = ((ISaveable)this).WriteFolder(parentFolderPath, "CreatedProducts");
			for (int i = 0; i < this.createdProducts.Count; i++)
			{
				new SaveRequest(this.createdProducts[i], parentFolderPath2);
			}
			return result;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x001051BC File Offset: 0x001033BC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetMethDiscovered_2166136261));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_SetCocaineDiscovered_2166136261));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SetProductListed_310431262));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetProductListed_619441887));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetProductListed_619441887));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SetProductFavourited_310431262));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_SetProductFavourited_619441887));
			base.RegisterTargetRpc(7U, new ClientRpcDelegate(this.RpcReader___Target_SetProductFavourited_619441887));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_DiscoverProduct_3615296227));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_SetProductDiscovered_619441887));
			base.RegisterTargetRpc(10U, new ClientRpcDelegate(this.RpcReader___Target_SetProductDiscovered_619441887));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_CreateWeed_Server_2331775230));
			base.RegisterTargetRpc(12U, new ClientRpcDelegate(this.RpcReader___Target_CreateWeed_1777266891));
			base.RegisterObserversRpc(13U, new ClientRpcDelegate(this.RpcReader___Observers_CreateWeed_1777266891));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_CreateCocaine_Server_891166717));
			base.RegisterTargetRpc(15U, new ClientRpcDelegate(this.RpcReader___Target_CreateCocaine_1327282946));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_CreateCocaine_1327282946));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_CreateMeth_Server_4251728555));
			base.RegisterTargetRpc(18U, new ClientRpcDelegate(this.RpcReader___Target_CreateMeth_1869045686));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_CreateMeth_1869045686));
			base.RegisterServerRpc(20U, new ServerRpcDelegate(this.RpcReader___Server_SendMixRecipe_852232071));
			base.RegisterTargetRpc(21U, new ClientRpcDelegate(this.RpcReader___Target_CreateMixRecipe_1410895574));
			base.RegisterObserversRpc(22U, new ClientRpcDelegate(this.RpcReader___Observers_CreateMixRecipe_1410895574));
			base.RegisterTargetRpc(23U, new ClientRpcDelegate(this.RpcReader___Target_GiveItem_2971853958));
			base.RegisterServerRpc(24U, new ServerRpcDelegate(this.RpcReader___Server_SendPrice_606697822));
			base.RegisterObserversRpc(25U, new ClientRpcDelegate(this.RpcReader___Observers_SetPrice_4077118173));
			base.RegisterTargetRpc(26U, new ClientRpcDelegate(this.RpcReader___Target_SetPrice_4077118173));
			base.RegisterServerRpc(27U, new ServerRpcDelegate(this.RpcReader___Server_SendMixOperation_3670976965));
			base.RegisterObserversRpc(28U, new ClientRpcDelegate(this.RpcReader___Observers_SetMixOperation_3670976965));
			base.RegisterObserversRpc(29U, new ClientRpcDelegate(this.RpcReader___Observers_FinishAndNameMix_4237212381));
			base.RegisterServerRpc(30U, new ServerRpcDelegate(this.RpcReader___Server_SendFinishAndNameMix_4237212381));
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x001054A9 File Offset: 0x001036A9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x001054C2 File Offset: 0x001036C2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x001054D0 File Offset: 0x001036D0
		private void RpcWriter___Server_SetMethDiscovered_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x0010556A File Offset: 0x0010376A
		public void RpcLogic___SetMethDiscovered_2166136261()
		{
			this.SetProductDiscovered(null, "meth", false);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x0010557C File Offset: 0x0010377C
		private void RpcReader___Server_SetMethDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetMethDiscovered_2166136261();
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0010559C File Offset: 0x0010379C
		private void RpcWriter___Server_SetCocaineDiscovered_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00105636 File Offset: 0x00103836
		public void RpcLogic___SetCocaineDiscovered_2166136261()
		{
			this.SetProductDiscovered(null, "cocaine", false);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00105648 File Offset: 0x00103848
		private void RpcReader___Server_SetCocaineDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetCocaineDiscovered_2166136261();
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00105668 File Offset: 0x00103868
		private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(listed);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0010571C File Offset: 0x0010391C
		public void RpcLogic___SetProductListed_310431262(string productID, bool listed)
		{
			this.SetProductListed(null, productID, listed);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00105728 File Offset: 0x00103928
		private void RpcReader___Server_SetProductListed_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			bool listed = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetProductListed_310431262(productID, listed);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00105778 File Offset: 0x00103978
		private void RpcWriter___Observers_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(listed);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x0010583C File Offset: 0x00103A3C
		public void RpcLogic___SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
			ProductDefinition productDefinition = this.AllProducts.Find((ProductDefinition p) => p.ID == productID);
			if (productDefinition == null)
			{
				Console.LogWarning("SetProductListed: product is not found (" + productID + ")", null);
				return;
			}
			if (!ProductManager.DiscoveredProducts.Contains(productDefinition))
			{
				Console.LogWarning("SetProductListed: product is not yet discovered", null);
			}
			if (listed)
			{
				if (!ProductManager.ListedProducts.Contains(productDefinition))
				{
					ProductManager.ListedProducts.Add(productDefinition);
				}
			}
			else if (ProductManager.ListedProducts.Contains(productDefinition))
			{
				ProductManager.ListedProducts.Remove(productDefinition);
			}
			if (NetworkSingleton<VariableDatabase>.InstanceExists && InstanceFinder.IsServer)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("ListedProductsCount", ProductManager.ListedProducts.Count.ToString(), true);
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("OGKushListed", (ProductManager.ListedProducts.Find((ProductDefinition x) => x.ID == "ogkush") != null).ToString(), true);
			}
			this.HasChanged = true;
			this.TimeSinceProductListingChanged = 0f;
			if (listed)
			{
				if (this.onProductListed != null)
				{
					this.onProductListed(productDefinition);
					return;
				}
			}
			else if (this.onProductDelisted != null)
			{
				this.onProductDelisted(productDefinition);
			}
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00105998 File Offset: 0x00103B98
		private void RpcReader___Observers_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool listed = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetProductListed_619441887(null, productID, listed);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x001059E8 File Offset: 0x00103BE8
		private void RpcWriter___Target_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(listed);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00105AAC File Offset: 0x00103CAC
		private void RpcReader___Target_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool listed = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetProductListed_619441887(base.LocalConnection, productID, listed);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00105AF4 File Offset: 0x00103CF4
		private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(listed);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x00105BA8 File Offset: 0x00103DA8
		public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed)
		{
			this.SetProductFavourited(null, productID, listed);
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00105BB4 File Offset: 0x00103DB4
		private void RpcReader___Server_SetProductFavourited_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			bool listed = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetProductFavourited_310431262(productID, listed);
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00105C04 File Offset: 0x00103E04
		private void RpcWriter___Observers_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(fav);
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x00105CC8 File Offset: 0x00103EC8
		public void RpcLogic___SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
			ProductDefinition productDefinition = this.AllProducts.Find((ProductDefinition p) => p.ID == productID);
			if (productDefinition == null)
			{
				Console.LogWarning("SetProductFavourited: product is not found (" + productID + ")", null);
				return;
			}
			if (!ProductManager.DiscoveredProducts.Contains(productDefinition))
			{
				Console.LogWarning("SetProductFavourited: product is not yet discovered", null);
			}
			if (fav)
			{
				if (!ProductManager.FavouritedProducts.Contains(productDefinition))
				{
					ProductManager.FavouritedProducts.Add(productDefinition);
				}
			}
			else if (ProductManager.FavouritedProducts.Contains(productDefinition))
			{
				ProductManager.FavouritedProducts.Remove(productDefinition);
			}
			this.HasChanged = true;
			if (fav)
			{
				if (this.onProductFavourited != null)
				{
					this.onProductFavourited(productDefinition);
					return;
				}
			}
			else if (this.onProductUnfavourited != null)
			{
				this.onProductUnfavourited(productDefinition);
			}
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x00105DA0 File Offset: 0x00103FA0
		private void RpcReader___Observers_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool fav = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetProductFavourited_619441887(null, productID, fav);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00105DF0 File Offset: 0x00103FF0
		private void RpcWriter___Target_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(fav);
			base.SendTargetRpc(7U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00105EB4 File Offset: 0x001040B4
		private void RpcReader___Target_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool fav = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetProductFavourited_619441887(base.LocalConnection, productID, fav);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00105EFC File Offset: 0x001040FC
		private void RpcWriter___Server_DiscoverProduct_3615296227(string productID)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00105FA3 File Offset: 0x001041A3
		public void RpcLogic___DiscoverProduct_3615296227(string productID)
		{
			this.SetProductDiscovered(null, productID, true);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00105FB0 File Offset: 0x001041B0
		private void RpcReader___Server_DiscoverProduct_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___DiscoverProduct_3615296227(productID);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00105FF0 File Offset: 0x001041F0
		private void RpcWriter___Observers_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(autoList);
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001060B4 File Offset: 0x001042B4
		public void RpcLogic___SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
			ProductDefinition productDefinition = this.AllProducts.Find((ProductDefinition p) => p.ID == productID);
			if (productDefinition == null)
			{
				Console.LogWarning("SetProductDiscovered: product is not found", null);
				return;
			}
			if (!ProductManager.DiscoveredProducts.Contains(productDefinition))
			{
				ProductManager.DiscoveredProducts.Add(productDefinition);
				if (autoList)
				{
					this.SetProductListed(productID, true);
				}
				if (this.onProductDiscovered != null)
				{
					this.onProductDiscovered(productDefinition);
				}
			}
			this.HasChanged = true;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00106140 File Offset: 0x00104340
		private void RpcReader___Observers_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool autoList = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetProductDiscovered_619441887(null, productID, autoList);
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00106190 File Offset: 0x00104390
		private void RpcWriter___Target_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteBoolean(autoList);
			base.SendTargetRpc(10U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00106254 File Offset: 0x00104454
		private void RpcReader___Target_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			bool autoList = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetProductDiscovered_619441887(base.LocalConnection, productID, autoList);
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0010629C File Offset: 0x0010449C
		private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00106377 File Offset: 0x00104577
		public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			this.CreateWeed(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00106388 File Offset: 0x00104588
		private void RpcReader___Server_CreateWeed_Server_2331775230(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			WeedAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CreateWeed_Server_2331775230(name, id, type, properties, appearance);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0010640C File Offset: 0x0010460C
		private void RpcWriter___Target_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendTargetRpc(12U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x001064F8 File Offset: 0x001046F8
		private void RpcLogic___CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			if (Registry.GetItem(id) != null)
			{
				Console.LogError("Product with ID " + id + " already exists", null);
				return;
			}
			WeedDefinition weedDefinition = Object.Instantiate<WeedDefinition>(this.DefaultWeed);
			weedDefinition.name = name;
			weedDefinition.Name = name;
			weedDefinition.Description = string.Empty;
			weedDefinition.ID = id;
			weedDefinition.Initialize(Singleton<PropertyUtility>.Instance.GetProperties(properties), new List<EDrugType>
			{
				type
			}, appearance);
			this.AllProducts.Add(weedDefinition);
			this.ProductPrices.Add(weedDefinition, weedDefinition.MarketValue);
			this.ProductNames.Add(name);
			this.createdProducts.Add(weedDefinition);
			Singleton<Registry>.Instance.AddToRegistry(weedDefinition);
			weedDefinition.Icon = Singleton<ProductIconManager>.Instance.GenerateIcons(id);
			if (weedDefinition.Icon == null)
			{
				Console.LogError("Failed to generate icons for " + name, null);
			}
			this.SetProductDiscovered(null, id, false);
			this.RefreshHighestValueProduct();
			if (this.onNewProductCreated != null)
			{
				this.onNewProductCreated(weedDefinition);
			}
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0010660C File Offset: 0x0010480C
		private void RpcReader___Target_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			WeedAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateWeed_1777266891(base.LocalConnection, name, id, type, properties, appearance);
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00106688 File Offset: 0x00104888
		private void RpcWriter___Observers_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendObserversRpc(13U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00106774 File Offset: 0x00104974
		private void RpcReader___Observers_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			WeedAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateWeed_1777266891(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x001067F4 File Offset: 0x001049F4
		private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x001068CF File Offset: 0x00104ACF
		public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			this.CreateCocaine(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x001068E0 File Offset: 0x00104AE0
		private void RpcReader___Server_CreateCocaine_Server_891166717(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			CocaineAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CreateCocaine_Server_891166717(name, id, type, properties, appearance);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00106964 File Offset: 0x00104B64
		private void RpcWriter___Target_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendTargetRpc(15U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00106A50 File Offset: 0x00104C50
		private void RpcLogic___CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			if (Registry.GetItem(id) != null)
			{
				Console.LogError("Product with ID " + id + " already exists", null);
				return;
			}
			CocaineDefinition cocaineDefinition = Object.Instantiate<CocaineDefinition>(this.DefaultCocaine);
			cocaineDefinition.name = name;
			cocaineDefinition.Name = name;
			cocaineDefinition.Description = string.Empty;
			cocaineDefinition.ID = id;
			cocaineDefinition.Initialize(Singleton<PropertyUtility>.Instance.GetProperties(properties), new List<EDrugType>
			{
				type
			}, appearance);
			this.AllProducts.Add(cocaineDefinition);
			this.ProductPrices.Add(cocaineDefinition, cocaineDefinition.MarketValue);
			this.ProductNames.Add(name);
			this.createdProducts.Add(cocaineDefinition);
			Singleton<Registry>.Instance.AddToRegistry(cocaineDefinition);
			cocaineDefinition.Icon = Singleton<ProductIconManager>.Instance.GenerateIcons(id);
			if (cocaineDefinition.Icon == null)
			{
				Console.LogError("Failed to generate icons for " + name, null);
			}
			this.SetProductDiscovered(null, id, false);
			this.RefreshHighestValueProduct();
			if (this.onNewProductCreated != null)
			{
				this.onNewProductCreated(cocaineDefinition);
			}
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00106B64 File Offset: 0x00104D64
		private void RpcReader___Target_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			CocaineAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateCocaine_1327282946(base.LocalConnection, name, id, type, properties, appearance);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00106BE0 File Offset: 0x00104DE0
		private void RpcWriter___Observers_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00106CCC File Offset: 0x00104ECC
		private void RpcReader___Observers_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			CocaineAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateCocaine_1327282946(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00106D4C File Offset: 0x00104F4C
		private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x00106E27 File Offset: 0x00105027
		public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			this.CreateMeth(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00106E38 File Offset: 0x00105038
		private void RpcReader___Server_CreateMeth_Server_4251728555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			MethAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CreateMeth_Server_4251728555(name, id, type, properties, appearance);
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00106EBC File Offset: 0x001050BC
		private void RpcWriter___Target_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendTargetRpc(18U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00106FA8 File Offset: 0x001051A8
		private void RpcLogic___CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			if (Registry.GetItem(id) != null)
			{
				Console.LogError("Product with ID " + id + " already exists", null);
				return;
			}
			MethDefinition methDefinition = Object.Instantiate<MethDefinition>(this.DefaultMeth);
			methDefinition.name = name;
			methDefinition.Name = name;
			methDefinition.Description = string.Empty;
			methDefinition.ID = id;
			methDefinition.Initialize(Singleton<PropertyUtility>.Instance.GetProperties(properties), new List<EDrugType>
			{
				type
			}, appearance);
			this.AllProducts.Add(methDefinition);
			this.ProductPrices.Add(methDefinition, methDefinition.MarketValue);
			this.ProductNames.Add(name);
			this.createdProducts.Add(methDefinition);
			Singleton<Registry>.Instance.AddToRegistry(methDefinition);
			methDefinition.Icon = Singleton<ProductIconManager>.Instance.GenerateIcons(id);
			if (methDefinition.Icon == null)
			{
				Console.LogError("Failed to generate icons for " + name, null);
			}
			this.SetProductDiscovered(null, id, false);
			this.RefreshHighestValueProduct();
			if (this.onNewProductCreated != null)
			{
				this.onNewProductCreated(methDefinition);
			}
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x001070BC File Offset: 0x001052BC
		private void RpcReader___Target_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			MethAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateMeth_1869045686(base.LocalConnection, name, id, type, properties, appearance);
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00107138 File Offset: 0x00105338
		private void RpcWriter___Observers_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(name);
			writer.WriteString(id);
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(type);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(properties);
			writer.Write___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generated(appearance);
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00107224 File Offset: 0x00105424
		private void RpcReader___Observers_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
			string name = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			EDrugType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			List<string> properties = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
			MethAppearanceSettings appearance = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateMeth_1869045686(null, name, id, type, properties, appearance);
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x001072A4 File Offset: 0x001054A4
		private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(product);
			writer.WriteString(mixer);
			writer.WriteString(output);
			base.SendServerRpc(20U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00107365 File Offset: 0x00105565
		public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output)
		{
			this.CreateMixRecipe(null, product, mixer, output);
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00107374 File Offset: 0x00105574
		private void RpcReader___Server_SendMixRecipe_852232071(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string product = PooledReader0.ReadString();
			string mixer = PooledReader0.ReadString();
			string output = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMixRecipe_852232071(product, mixer, output);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x001073D4 File Offset: 0x001055D4
		private void RpcWriter___Target_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(product);
			writer.WriteString(mixer);
			writer.WriteString(output);
			base.SendTargetRpc(21U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x001074A4 File Offset: 0x001056A4
		public void RpcLogic___CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
			if (string.IsNullOrEmpty(product) || string.IsNullOrEmpty(mixer) || string.IsNullOrEmpty(output))
			{
				Console.LogError(string.Concat(new string[]
				{
					"Invalid mix recipe: Product:",
					product,
					" Mixer:",
					mixer,
					" Output:",
					output
				}), null);
				return;
			}
			StationRecipe x = null;
			for (int i = 0; i < this.mixRecipes.Count; i++)
			{
				if (!(this.mixRecipes[i] == null) && this.mixRecipes[i].Product != null && this.mixRecipes[i].Ingredients.Count >= 2)
				{
					string id = this.mixRecipes[i].Ingredients[0].Items[0].ID;
					string id2 = this.mixRecipes[i].Ingredients[1].Items[0].ID;
					string id3 = this.mixRecipes[i].Product.Item.ID;
					if (id == product && id2 == mixer && id3 == output)
					{
						x = this.mixRecipes[i];
						break;
					}
					if (id2 == product && id == mixer && id3 == output)
					{
						x = this.mixRecipes[i];
						break;
					}
				}
			}
			if (x != null)
			{
				Console.LogWarning("Mix recipe already exists", null);
				return;
			}
			StationRecipe stationRecipe = ScriptableObject.CreateInstance<StationRecipe>();
			ItemDefinition item = Registry.GetItem(product);
			ItemDefinition item2 = Registry.GetItem(mixer);
			if (item == null)
			{
				Console.LogError("Product not found: " + product, null);
				return;
			}
			if (item2 == null)
			{
				Console.LogError("Mixer not found: " + mixer, null);
				return;
			}
			stationRecipe.Ingredients = new List<StationRecipe.IngredientQuantity>();
			stationRecipe.Ingredients.Add(new StationRecipe.IngredientQuantity
			{
				Items = new List<ItemDefinition>
				{
					item
				},
				Quantity = 1
			});
			stationRecipe.Ingredients.Add(new StationRecipe.IngredientQuantity
			{
				Items = new List<ItemDefinition>
				{
					item2
				},
				Quantity = 1
			});
			ItemDefinition item3 = Registry.GetItem(output);
			if (item3 == null)
			{
				Console.LogError("Output item not found: " + output, null);
				return;
			}
			stationRecipe.Product = new StationRecipe.ItemQuantity
			{
				Item = item3,
				Quantity = 1
			};
			stationRecipe.RecipeTitle = stationRecipe.Product.Item.Name;
			stationRecipe.Unlocked = true;
			this.mixRecipes.Add(stationRecipe);
			if (this.onMixRecipeAdded != null)
			{
				this.onMixRecipeAdded(stationRecipe);
			}
			ProductDefinition productDefinition = stationRecipe.Product.Item as ProductDefinition;
			if (productDefinition != null)
			{
				productDefinition.AddRecipe(stationRecipe);
			}
			else
			{
				Console.LogError("Product is not a product definition: " + product, null);
			}
			this.HasChanged = true;
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x001077B8 File Offset: 0x001059B8
		private void RpcReader___Target_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
			string product = PooledReader0.ReadString();
			string mixer = PooledReader0.ReadString();
			string output = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___CreateMixRecipe_1410895574(base.LocalConnection, product, mixer, output);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00107814 File Offset: 0x00105A14
		private void RpcWriter___Observers_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(product);
			writer.WriteString(mixer);
			writer.WriteString(output);
			base.SendObserversRpc(22U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001078E4 File Offset: 0x00105AE4
		private void RpcReader___Observers_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
			string product = PooledReader0.ReadString();
			string mixer = PooledReader0.ReadString();
			string output = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateMixRecipe_1410895574(null, product, mixer, output);
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00107944 File Offset: 0x00105B44
		private void RpcWriter___Target_GiveItem_2971853958(NetworkConnection conn, string id)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(id);
			base.SendTargetRpc(23U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x001079F9 File Offset: 0x00105BF9
		private void RpcLogic___GiveItem_2971853958(NetworkConnection conn, string id)
		{
			PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(Registry.GetItem(id).GetDefaultInstance(1));
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00107A14 File Offset: 0x00105C14
		private void RpcReader___Target_GiveItem_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___GiveItem_2971853958(base.LocalConnection, id);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00107A4C File Offset: 0x00105C4C
		private void RpcWriter___Server_SendPrice_606697822(string productID, float value)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(24U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00107B05 File Offset: 0x00105D05
		public void RpcLogic___SendPrice_606697822(string productID, float value)
		{
			this.SetPrice(null, productID, value);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00107B10 File Offset: 0x00105D10
		private void RpcReader___Server_SendPrice_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPrice_606697822(productID, value);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00107B64 File Offset: 0x00105D64
		private void RpcWriter___Observers_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendObserversRpc(25U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00107C2C File Offset: 0x00105E2C
		public void RpcLogic___SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
			ProductDefinition item = Registry.GetItem<ProductDefinition>(productID);
			if (item == null)
			{
				Console.LogError("Product not found: " + productID, null);
				return;
			}
			value = (float)Mathf.RoundToInt(Mathf.Clamp(value, 1f, 999f));
			if (!this.ProductPrices.ContainsKey(item))
			{
				this.ProductPrices.Add(item, value);
				return;
			}
			this.ProductPrices[item] = value;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00107C9C File Offset: 0x00105E9C
		private void RpcReader___Observers_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetPrice_4077118173(null, productID, value);
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00107CF0 File Offset: 0x00105EF0
		private void RpcWriter___Target_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendTargetRpc(26U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00107DB8 File Offset: 0x00105FB8
		private void RpcReader___Target_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetPrice_4077118173(base.LocalConnection, productID, value);
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00107E08 File Offset: 0x00106008
		private void RpcWriter___Server_SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generated(operation);
			writer.WriteBoolean(complete);
			base.SendServerRpc(27U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00107EBC File Offset: 0x001060BC
		public void RpcLogic___SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
			this.SetMixOperation(operation, complete);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x00107EC8 File Offset: 0x001060C8
		private void RpcReader___Server_SendMixOperation_3670976965(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NewMixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generateds(PooledReader0);
			bool complete = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendMixOperation_3670976965(operation, complete);
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00107F18 File Offset: 0x00106118
		private void RpcWriter___Observers_SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generated(operation);
			writer.WriteBoolean(complete);
			base.SendObserversRpc(28U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00107FDB File Offset: 0x001061DB
		private void RpcLogic___SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
			this.CurrentMixOperation = operation;
			this.IsMixComplete = complete;
			if (this.CurrentMixOperation != null && this.IsMixComplete && this.onMixCompleted != null)
			{
				this.onMixCompleted(this.CurrentMixOperation);
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00108014 File Offset: 0x00106214
		private void RpcReader___Observers_SetMixOperation_3670976965(PooledReader PooledReader0, Channel channel)
		{
			NewMixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generateds(PooledReader0);
			bool complete = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetMixOperation_3670976965(operation, complete);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00108060 File Offset: 0x00106260
		private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteString(ingredientID);
			writer.WriteString(mixName);
			writer.WriteString(mixID);
			base.SendObserversRpc(29U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00108140 File Offset: 0x00106340
		private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
			if (this.AllProducts.Find((ProductDefinition p) => p.ID == mixID) != null)
			{
				return;
			}
			ProductDefinition productDefinition = Registry.GetItem(productID) as ProductDefinition;
			PropertyItemDefinition propertyItemDefinition = Registry.GetItem(ingredientID) as PropertyItemDefinition;
			if (productDefinition == null || propertyItemDefinition == null)
			{
				Debug.LogError("Product or mixer not found");
				return;
			}
			List<Property> list = PropertyMixCalculator.MixProperties(productDefinition.Properties, propertyItemDefinition.Properties[0], productDefinition.DrugType);
			List<string> list2 = new List<string>();
			foreach (Property property in list)
			{
				list2.Add(property.ID);
			}
			switch (productDefinition.DrugType)
			{
			case EDrugType.Marijuana:
				this.CreateWeed(null, mixName, mixID, EDrugType.Marijuana, list2, WeedDefinition.GetAppearanceSettings(list));
				return;
			case EDrugType.Methamphetamine:
				this.CreateMeth(null, mixName, mixID, EDrugType.Methamphetamine, list2, MethDefinition.GetAppearanceSettings(list));
				return;
			case EDrugType.Cocaine:
				this.CreateCocaine(null, mixName, mixID, EDrugType.Cocaine, list2, CocaineDefinition.GetAppearanceSettings(list));
				return;
			default:
				Console.LogError("Drug type not supported", null);
				return;
			}
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00108290 File Offset: 0x00106490
		private void RpcReader___Observers_FinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel)
		{
			string productID = PooledReader0.ReadString();
			string ingredientID = PooledReader0.ReadString();
			string mixName = PooledReader0.ReadString();
			string mixID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___FinishAndNameMix_4237212381(productID, ingredientID, mixName, mixID);
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00108300 File Offset: 0x00106500
		private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(productID);
			writer.WriteString(ingredientID);
			writer.WriteString(mixName);
			writer.WriteString(mixID);
			base.SendServerRpc(30U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x001083CE File Offset: 0x001065CE
		private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
			this.FinishAndNameMix(productID, ingredientID, mixName, mixID);
			this.CreateMixRecipe(null, productID, ingredientID, mixID);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x001083E8 File Offset: 0x001065E8
		private void RpcReader___Server_SendFinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			string ingredientID = PooledReader0.ReadString();
			string mixName = PooledReader0.ReadString();
			string mixID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendFinishAndNameMix_4237212381(productID, ingredientID, mixName, mixID);
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0010844C File Offset: 0x0010664C
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04002C9C RID: 11420
		public const int MIN_PRICE = 1;

		// Token: 0x04002C9D RID: 11421
		public const int MAX_PRICE = 999;

		// Token: 0x04002C9E RID: 11422
		public Action<ProductDefinition> onProductDiscovered;

		// Token: 0x04002C9F RID: 11423
		public static List<ProductDefinition> DiscoveredProducts = new List<ProductDefinition>();

		// Token: 0x04002CA0 RID: 11424
		public static List<ProductDefinition> ListedProducts = new List<ProductDefinition>();

		// Token: 0x04002CA1 RID: 11425
		public static List<ProductDefinition> FavouritedProducts = new List<ProductDefinition>();

		// Token: 0x04002CA3 RID: 11427
		public List<ProductDefinition> AllProducts = new List<ProductDefinition>();

		// Token: 0x04002CA4 RID: 11428
		public List<ProductDefinition> DefaultKnownProducts = new List<ProductDefinition>();

		// Token: 0x04002CA5 RID: 11429
		public List<PropertyItemDefinition> ValidMixIngredients = new List<PropertyItemDefinition>();

		// Token: 0x04002CA6 RID: 11430
		public AnimationCurve SampleSuccessCurve;

		// Token: 0x04002CA7 RID: 11431
		[Header("Default Products")]
		public WeedDefinition DefaultWeed;

		// Token: 0x04002CA8 RID: 11432
		public CocaineDefinition DefaultCocaine;

		// Token: 0x04002CA9 RID: 11433
		public MethDefinition DefaultMeth;

		// Token: 0x04002CAA RID: 11434
		[Header("Mix Maps")]
		public MixerMap WeedMixMap;

		// Token: 0x04002CAB RID: 11435
		public MixerMap MethMixMap;

		// Token: 0x04002CAC RID: 11436
		public MixerMap CokeMixMap;

		// Token: 0x04002CAD RID: 11437
		private List<ProductDefinition> createdProducts = new List<ProductDefinition>();

		// Token: 0x04002CB1 RID: 11441
		public Action<NewMixOperation> onMixCompleted;

		// Token: 0x04002CB2 RID: 11442
		public Action<ProductDefinition> onNewProductCreated;

		// Token: 0x04002CB3 RID: 11443
		public Action<ProductDefinition> onProductListed;

		// Token: 0x04002CB4 RID: 11444
		public Action<ProductDefinition> onProductDelisted;

		// Token: 0x04002CB5 RID: 11445
		public Action<ProductDefinition> onProductFavourited;

		// Token: 0x04002CB6 RID: 11446
		public Action<ProductDefinition> onProductUnfavourited;

		// Token: 0x04002CB7 RID: 11447
		public UnityEvent onFirstSampleRejection;

		// Token: 0x04002CB8 RID: 11448
		public UnityEvent onSecondUniqueProductCreated;

		// Token: 0x04002CB9 RID: 11449
		public List<string> ProductNames = new List<string>();

		// Token: 0x04002CBA RID: 11450
		private List<StationRecipe> mixRecipes = new List<StationRecipe>();

		// Token: 0x04002CBB RID: 11451
		public Action<StationRecipe> onMixRecipeAdded;

		// Token: 0x04002CBC RID: 11452
		private Dictionary<ProductDefinition, float> ProductPrices = new Dictionary<ProductDefinition, float>();

		// Token: 0x04002CBD RID: 11453
		private ProductDefinition highestValueProduct;

		// Token: 0x04002CBE RID: 11454
		private ProductManagerLoader loader = new ProductManagerLoader();

		// Token: 0x04002CC2 RID: 11458
		private bool dll_Excuted;

		// Token: 0x04002CC3 RID: 11459
		private bool dll_Excuted;
	}
}
