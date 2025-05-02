using System;
using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Building
{
	// Token: 0x02000781 RID: 1921
	public class BuildManager : Singleton<BuildManager>
	{
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x000DAF92 File Offset: 0x000D9192
		public Transform _tempContainer
		{
			get
			{
				return this.tempContainer;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x000DAF9A File Offset: 0x000D919A
		// (set) Token: 0x06003472 RID: 13426 RVA: 0x000DAFA2 File Offset: 0x000D91A2
		public bool isBuilding { get; protected set; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x000DAFAB File Offset: 0x000D91AB
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x000DAFB3 File Offset: 0x000D91B3
		public GameObject currentBuildHandler { get; protected set; }

		// Token: 0x06003475 RID: 13429 RVA: 0x000DAFBC File Offset: 0x000D91BC
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000DAFC4 File Offset: 0x000D91C4
		public void StartBuilding(ItemInstance item)
		{
			if (!(item.Definition is BuildableItemDefinition))
			{
				Console.LogError("StartBuilding called but not passed BuildableItemDefinition", null);
				return;
			}
			if (this.isBuilding)
			{
				Console.LogWarning("StartBuilding called but building is already happening!", null);
				this.StopBuilding();
			}
			BuildableItem builtItem = (item.Definition as BuildableItemDefinition).BuiltItem;
			if (builtItem == null)
			{
				Console.LogWarning("itemToBuild is null!", null);
				return;
			}
			this.isBuilding = true;
			this.currentBuildHandler = Object.Instantiate<GameObject>(builtItem.BuildHandler, this.tempContainer);
			this.currentBuildHandler.GetComponent<BuildStart_Base>().StartBuilding(item);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000DB058 File Offset: 0x000D9258
		public void StartBuildingStoredItem(ItemInstance item)
		{
			if (!(item.Definition is StorableItemDefinition))
			{
				Console.LogError("StartBuildingStoredItem called but not passed StorableItemDefinition", null);
				return;
			}
			if (this.isBuilding)
			{
				Console.LogWarning("StartBuildingStoredItem called but building is already happening!", null);
				this.StopBuilding();
			}
			this.isBuilding = true;
			this.currentBuildHandler = Object.Instantiate<GameObject>(this.storedItemBuildHandler, this.tempContainer);
			this.currentBuildHandler.GetComponent<BuildStart_Base>().StartBuilding(item);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x000DB0C8 File Offset: 0x000D92C8
		public void StartPlacingCash(ItemInstance item)
		{
			if (this.isBuilding)
			{
				Console.LogWarning("StartPlacingCash called but building is already happening!", null);
				this.StopBuilding();
			}
			this.isBuilding = true;
			this.currentBuildHandler = Object.Instantiate<GameObject>(this.cashBuildHandler, this.tempContainer);
			this.currentBuildHandler.GetComponent<BuildStart_Cash>().StartBuilding(item);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000DB11D File Offset: 0x000D931D
		public void StopBuilding()
		{
			this.isBuilding = false;
			this.currentBuildHandler.GetComponent<BuildStop_Base>().Stop_Building();
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x000DB138 File Offset: 0x000D9338
		public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
			BuildManager.BuildSound buildSound = this.PlaceSounds.Find((BuildManager.BuildSound s) => s.Type == type);
			if (buildSound != null)
			{
				buildSound.Sound.transform.position = point;
				buildSound.Sound.Play();
			}
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x000DB18C File Offset: 0x000D938C
		public void DisableColliders(GameObject obj)
		{
			Collider[] componentsInChildren = obj.GetComponentsInChildren<Collider>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x000DB1B8 File Offset: 0x000D93B8
		public void DisableLights(GameObject obj)
		{
			Light[] componentsInChildren = obj.GetComponentsInChildren<Light>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000DB1E4 File Offset: 0x000D93E4
		public void DisableNetworking(GameObject obj)
		{
			NetworkObject[] componentsInChildren = obj.GetComponentsInChildren<NetworkObject>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Object.Destroy(componentsInChildren[i]);
			}
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000DB210 File Offset: 0x000D9410
		public void DisableSpriteRenderers(GameObject obj)
		{
			SpriteRenderer[] componentsInChildren = obj.GetComponentsInChildren<SpriteRenderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000DB23C File Offset: 0x000D943C
		public void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
			MeshRenderer[] componentsInChildren = obj.GetComponentsInChildren<MeshRenderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (!componentsInChildren[i].gameObject.GetComponentInParent<OverrideGhostMaterial>())
				{
					if (allMaterials)
					{
						Material[] materials = componentsInChildren[i].materials;
						for (int j = 0; j < materials.Length; j++)
						{
							materials[j] = mat;
						}
						componentsInChildren[i].materials = materials;
					}
					else
					{
						componentsInChildren[i].material = mat;
					}
				}
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x000DB2A4 File Offset: 0x000D94A4
		public void DisableNavigation(GameObject obj)
		{
			NavMeshObstacle[] componentsInChildren = obj.GetComponentsInChildren<NavMeshObstacle>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
			NavMeshSurface[] componentsInChildren2 = obj.GetComponentsInChildren<NavMeshSurface>();
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				componentsInChildren2[j].enabled = false;
			}
			NavMeshLink[] componentsInChildren3 = obj.GetComponentsInChildren<NavMeshLink>();
			for (int k = 0; k < componentsInChildren3.Length; k++)
			{
				componentsInChildren3[k].enabled = false;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000DB318 File Offset: 0x000D9518
		public void DisableCanvases(GameObject obj)
		{
			Canvas[] componentsInChildren = obj.GetComponentsInChildren<Canvas>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x000DB344 File Offset: 0x000D9544
		public GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			BuildableItemDefinition buildableItemDefinition = item.Definition as BuildableItemDefinition;
			if (buildableItemDefinition == null)
			{
				Console.LogError("BuildGridItem called but could not find BuildableItemDefinition", null);
				return null;
			}
			if (grid == null)
			{
				Console.LogError("BuildGridItem called and passed null grid", null);
				return null;
			}
			string guid2 = string.IsNullOrEmpty(guid) ? GUIDManager.GenerateUniqueGUID().ToString() : guid;
			GridItem component = Object.Instantiate<GameObject>(buildableItemDefinition.BuiltItem.gameObject, null).GetComponent<GridItem>();
			component.SetLocallyBuilt();
			component.InitializeGridItem(item, grid, originCoordinate, rotation, guid2);
			this.networkObject.Spawn(component.gameObject, null, default(Scene));
			return component;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x000DB3F0 File Offset: 0x000D95F0
		public ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			BuildableItemDefinition buildableItemDefinition = item.Definition as BuildableItemDefinition;
			if (buildableItemDefinition == null)
			{
				Console.LogError("BuildProceduralGridItem called but could not find BuildableItemDefinition", null);
				return null;
			}
			string guid2 = string.IsNullOrEmpty(guid) ? GUIDManager.GenerateUniqueGUID().ToString() : guid;
			ProceduralGridItem component = Object.Instantiate<GameObject>(buildableItemDefinition.BuiltItem.gameObject, null).GetComponent<ProceduralGridItem>();
			component.SetLocallyBuilt();
			component.InitializeProceduralGridItem(item, rotationAngle, matches, guid2);
			this.networkObject.Spawn(component.gameObject, null, default(Scene));
			return component;
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000DB484 File Offset: 0x000D9684
		public SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			BuildableItemDefinition buildableItemDefinition = item.Definition as BuildableItemDefinition;
			if (buildableItemDefinition == null)
			{
				Console.LogError("CreateSurfaceItem called but could not find BuildableItemDefinition", null);
				return null;
			}
			string guid2 = string.IsNullOrEmpty(guid) ? GUIDManager.GenerateUniqueGUID().ToString() : guid;
			SurfaceItem component = Object.Instantiate<GameObject>(buildableItemDefinition.BuiltItem.gameObject, null).GetComponent<SurfaceItem>();
			component.SetLocallyBuilt();
			component.InitializeSurfaceItem(item, guid2, parentSurface.GUID.ToString(), relativePosition, relativeRotation);
			this.networkObject.Spawn(component.gameObject, null, default(Scene));
			return component;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x000DB52D File Offset: 0x000D972D
		public void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
			if (parentStorageEntity == null)
			{
				Console.LogWarning("CreateStoredItem: parentStorageEntity is null", null);
				return;
			}
			if (item.Quantity != 1)
			{
				Console.LogWarning("CreateStoredItem: item quantity is '" + item.Quantity.ToString() + "'. It should be 1!", null);
			}
		}

		// Token: 0x0400257E RID: 9598
		public List<BuildManager.BuildSound> PlaceSounds = new List<BuildManager.BuildSound>();

		// Token: 0x0400257F RID: 9599
		[Header("References")]
		[SerializeField]
		protected Transform tempContainer;

		// Token: 0x04002580 RID: 9600
		public NetworkObject networkObject;

		// Token: 0x04002581 RID: 9601
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject storedItemBuildHandler;

		// Token: 0x04002582 RID: 9602
		[SerializeField]
		protected GameObject cashBuildHandler;

		// Token: 0x04002583 RID: 9603
		[Header("Materials")]
		public Material ghostMaterial_White;

		// Token: 0x04002584 RID: 9604
		public Material ghostMaterial_Red;

		// Token: 0x02000782 RID: 1922
		[Serializable]
		public class BuildSound
		{
			// Token: 0x04002587 RID: 9607
			public BuildableItemDefinition.EBuildSoundType Type;

			// Token: 0x04002588 RID: 9608
			public AudioSourceController Sound;
		}
	}
}
