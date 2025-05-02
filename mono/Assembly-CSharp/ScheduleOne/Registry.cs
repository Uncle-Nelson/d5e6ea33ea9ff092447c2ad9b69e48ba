using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet.Object;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne
{
	// Token: 0x02000264 RID: 612
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x00039108 File Offset: 0x00037308
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<Registry>.Instance == null || Singleton<Registry>.Instance != this)
			{
				return;
			}
			foreach (Registry.ItemRegister itemRegister in this.ItemRegistry)
			{
				if (this.ItemDictionary.ContainsKey(Registry.GetHash(itemRegister.ID)))
				{
					Console.LogError("Duplicate item ID: " + itemRegister.ID, null);
				}
				else
				{
					this.AddToItemDictionary(itemRegister);
				}
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000391AC File Offset: 0x000373AC
		public static GameObject GetPrefab(string id)
		{
			Registry.ObjectRegister objectRegister = Singleton<Registry>.Instance.ObjectRegistry.Find((Registry.ObjectRegister x) => x.ID.ToLower() == id.ToString());
			if (objectRegister == null)
			{
				return null;
			}
			return objectRegister.Prefab.gameObject;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000391F2 File Offset: 0x000373F2
		public static ItemDefinition GetItem(string ID)
		{
			return Singleton<Registry>.Instance._GetItem(ID);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000391FF File Offset: 0x000373FF
		public static T GetItem<T>(string ID) where T : ItemDefinition
		{
			return Singleton<Registry>.Instance._GetItem(ID) as T;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00039218 File Offset: 0x00037418
		public ItemDefinition _GetItem(string ID)
		{
			if (string.IsNullOrEmpty(ID))
			{
				return null;
			}
			int hash = Registry.GetHash(ID);
			if (!this.ItemDictionary.ContainsKey(hash))
			{
				if (Singleton<LoadManager>.InstanceExists && !Singleton<LoadManager>.Instance.IsLoading)
				{
					Console.LogError("Item '" + ID + "' not found in registry!", null);
				}
				return null;
			}
			Registry.ItemRegister itemRegister = this.ItemDictionary[hash];
			if (itemRegister == null)
			{
				return null;
			}
			return itemRegister.Definition;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00039288 File Offset: 0x00037488
		public static Constructable GetConstructable(string id)
		{
			GameObject prefab = Registry.GetPrefab(id);
			if (!(prefab != null))
			{
				return null;
			}
			return prefab.GetComponent<Constructable>();
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000392AD File Offset: 0x000374AD
		private static int GetHash(string ID)
		{
			return ID.ToLower().GetHashCode();
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000392BC File Offset: 0x000374BC
		private static string RemoveAssetsAndPrefab(string originalString)
		{
			int num = originalString.IndexOf("Assets/");
			if (num != -1)
			{
				originalString = originalString.Substring(num + "Assets/".Length);
			}
			int num2 = originalString.LastIndexOf(".prefab");
			if (num2 != -1)
			{
				originalString = originalString.Substring(0, num2);
			}
			return originalString;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00039308 File Offset: 0x00037508
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.RemoveRuntimeItems));
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003932C File Offset: 0x0003752C
		public void AddToRegistry(ItemDefinition item)
		{
			Console.Log("Adding " + item.ID + " to registry: " + ((item != null) ? item.ToString() : null), null);
			Registry.ItemRegister itemRegister = new Registry.ItemRegister
			{
				Definition = item,
				ID = item.ID,
				AssetPath = string.Empty
			};
			this.ItemRegistry.Add(itemRegister);
			this.AddToItemDictionary(itemRegister);
			if (Application.isPlaying)
			{
				this.ItemsAddedAtRuntime.Add(new Registry.ItemRegister
				{
					Definition = item,
					ID = item.ID,
					AssetPath = string.Empty
				});
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000393D0 File Offset: 0x000375D0
		private void AddToItemDictionary(Registry.ItemRegister reg)
		{
			int hash = Registry.GetHash(reg.ID);
			if (this.ItemDictionary.ContainsKey(hash))
			{
				Console.LogError("Duplicate item ID: " + reg.ID, null);
				return;
			}
			this.ItemDictionary.Add(hash, reg);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003941C File Offset: 0x0003761C
		private void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
			int hash = Registry.GetHash(reg.ID);
			this.ItemDictionary.Remove(hash);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00039444 File Offset: 0x00037644
		public void RemoveRuntimeItems()
		{
			foreach (Registry.ItemRegister itemRegister in new List<Registry.ItemRegister>(this.ItemsAddedAtRuntime))
			{
				this.RemoveFromRegistry(itemRegister.Definition);
			}
			this.ItemsAddedAtRuntime.Clear();
			Console.Log("Removed runtime items from registry", null);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000394B8 File Offset: 0x000376B8
		public void RemoveFromRegistry(ItemDefinition item)
		{
			Registry.ItemRegister itemRegister = this.ItemRegistry.Find((Registry.ItemRegister x) => x.Definition == item);
			if (itemRegister != null)
			{
				this.ItemRegistry.Remove(itemRegister);
				this.RemoveItemFromDictionary(itemRegister);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00039504 File Offset: 0x00037704
		[Button]
		public void LogOrderedUnlocks()
		{
			List<ItemDefinition> list = new List<ItemDefinition>();
			for (int i = 0; i < this.ItemRegistry.Count; i++)
			{
				if ((this.ItemRegistry[i].Definition as StorableItemDefinition).RequiresLevelToPurchase)
				{
					list.Add(this.ItemRegistry[i].Definition);
				}
			}
			list.Sort((ItemDefinition x, ItemDefinition y) => (x as StorableItemDefinition).RequiredRank.CompareTo((y as StorableItemDefinition).RequiredRank));
			Console.Log("Ordered Unlocks:", null);
			foreach (ItemDefinition itemDefinition in list)
			{
				string id = itemDefinition.ID;
				string str = " - ";
				FullRank requiredRank = (itemDefinition as StorableItemDefinition).RequiredRank;
				Console.Log(id + str + requiredRank.ToString(), null);
			}
		}

		// Token: 0x04000D5C RID: 3420
		[SerializeField]
		private List<Registry.ObjectRegister> ObjectRegistry = new List<Registry.ObjectRegister>();

		// Token: 0x04000D5D RID: 3421
		[SerializeField]
		private List<Registry.ItemRegister> ItemRegistry = new List<Registry.ItemRegister>();

		// Token: 0x04000D5E RID: 3422
		[SerializeField]
		private List<Registry.ItemRegister> ItemsAddedAtRuntime = new List<Registry.ItemRegister>();

		// Token: 0x04000D5F RID: 3423
		private Dictionary<int, Registry.ItemRegister> ItemDictionary = new Dictionary<int, Registry.ItemRegister>();

		// Token: 0x04000D60 RID: 3424
		public List<SeedDefinition> Seeds = new List<SeedDefinition>();

		// Token: 0x02000265 RID: 613
		[Serializable]
		public class ObjectRegister
		{
			// Token: 0x04000D61 RID: 3425
			public string ID;

			// Token: 0x04000D62 RID: 3426
			public string AssetPath;

			// Token: 0x04000D63 RID: 3427
			public NetworkObject Prefab;
		}

		// Token: 0x02000266 RID: 614
		[Serializable]
		public class ItemRegister
		{
			// Token: 0x04000D64 RID: 3428
			public string ID;

			// Token: 0x04000D65 RID: 3429
			public string AssetPath;

			// Token: 0x04000D66 RID: 3430
			public ItemDefinition Definition;
		}
	}
}
