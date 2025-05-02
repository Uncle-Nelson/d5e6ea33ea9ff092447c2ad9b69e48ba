using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tiles;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B4 RID: 2228
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x000FF2D5 File Offset: 0x000FD4D5
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x000FF2DD File Offset: 0x000FD4DD
		public StorableItemInstance item { get; protected set; }

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x000FF2E6 File Offset: 0x000FD4E6
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x000FF2EE File Offset: 0x000FD4EE
		public bool Destroyed { get; private set; }

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000FF2F7 File Offset: 0x000FD4F7
		public FootprintTile OriginFootprint
		{
			get
			{
				return this.CoordinateFootprintTilePairs[0].tile;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x000FF30C File Offset: 0x000FD50C
		public int FootprintX
		{
			get
			{
				if (this.footprintX == -1)
				{
					this.footprintX = (from c in this.CoordinateFootprintTilePairs
					orderby c.coord.x descending
					select c).FirstOrDefault<CoordinateStorageFootprintTilePair>().coord.x + 1;
				}
				return this.footprintX;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x000FF36C File Offset: 0x000FD56C
		public int FootprintY
		{
			get
			{
				if (this.footprintY == -1)
				{
					this.footprintY = (from c in this.CoordinateFootprintTilePairs
					orderby c.coord.y descending
					select c).FirstOrDefault<CoordinateStorageFootprintTilePair>().coord.y + 1;
				}
				return this.footprintY;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x000FF3C9 File Offset: 0x000FD5C9
		// (set) Token: 0x06003C93 RID: 15507 RVA: 0x000FF3D1 File Offset: 0x000FD5D1
		public IStorageEntity parentStorageEntity { get; protected set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x000FF3DA File Offset: 0x000FD5DA
		// (set) Token: 0x06003C95 RID: 15509 RVA: 0x000FF3E2 File Offset: 0x000FD5E2
		public StorageGrid parentGrid { get; protected set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003C96 RID: 15510 RVA: 0x000FF3EB File Offset: 0x000FD5EB
		public List<CoordinatePair> CoordinatePairs
		{
			get
			{
				return this.coordinatePairs;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x000FF3F3 File Offset: 0x000FD5F3
		public float Rotation
		{
			get
			{
				return this.rotation;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003C98 RID: 15512 RVA: 0x000FF3FB File Offset: 0x000FD5FB
		public int totalArea
		{
			get
			{
				return this.CoordinateFootprintTilePairs.Count;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x000FF408 File Offset: 0x000FD608
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x000FF410 File Offset: 0x000FD610
		public bool canBePickedUp { get; protected set; } = true;

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x000FF419 File Offset: 0x000FD619
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x000FF421 File Offset: 0x000FD621
		public string noPickupReason { get; protected set; } = string.Empty;

		// Token: 0x06003C9D RID: 15517 RVA: 0x000FF42C File Offset: 0x000FD62C
		protected virtual void Awake()
		{
			MeshRenderer[] componentsInChildren = base.GetComponentsInChildren<MeshRenderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].shadowCastingMode == ShadowCastingMode.ShadowsOnly)
				{
					componentsInChildren[i].enabled = false;
				}
				else
				{
					componentsInChildren[i].shadowCastingMode = ShadowCastingMode.Off;
				}
			}
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x000FF470 File Offset: 0x000FD670
		protected virtual void OnValidate()
		{
			if (base.gameObject.layer != LayerMask.NameToLayer("StoredItem"))
			{
				StoredItem.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("StoredItem"));
			}
			if (this.CoordinateFootprintTilePairs.Count == 0)
			{
				Debug.LogWarning("StoredItem (" + base.gameObject.name + ") has no CoordinateFootprintTilePairs!");
			}
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x000FF4D8 File Offset: 0x000FD6D8
		public virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			if (grid == null)
			{
				Console.LogError("InitializeStoredItem: grid is null!", null);
				this.DestroyStoredItem();
				return;
			}
			if (this == null || base.gameObject == null)
			{
				return;
			}
			this.item = _item;
			this.parentGrid = grid;
			this.rotation = _rotation;
			StoredItem.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("StoredItem"));
			this.coordinatePairs = Coordinate.BuildCoordinateMatches(new Coordinate(_originCoordinate), this.FootprintX, this.FootprintY, this.Rotation);
			this.RefreshTransform();
			for (int i = 0; i < this.coordinatePairs.Count; i++)
			{
				StorageTile tile = this.parentGrid.GetTile(this.coordinatePairs[i].coord2);
				if (tile == null)
				{
					string str = "Failed to find tile at ";
					Coordinate coord = this.coordinatePairs[i].coord2;
					Console.LogError(str + ((coord != null) ? coord.ToString() : null) + " when initializing stored item!", null);
					this.DestroyStoredItem();
					return;
				}
				if (tile.occupant != null)
				{
					this.DestroyStoredItem();
					return;
				}
				tile.SetOccupant(this);
				grid.freeTiles.Remove(tile);
			}
			this.intObj = base.GetComponentInChildren<InteractableObject>();
			if (this.intObj != null)
			{
				Object.Destroy(this.intObj);
			}
			this.SetFootprintTileVisiblity(false);
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x000FF63C File Offset: 0x000FD83C
		private void RefreshTransform()
		{
			FootprintTile tile = this.GetTile(this.coordinatePairs[0].coord1);
			StorageTile tile2 = this.parentGrid.GetTile(this.coordinatePairs[0].coord2);
			base.transform.rotation = this.parentGrid.transform.rotation * (Quaternion.Inverse(this.buildPoint.transform.rotation) * base.transform.rotation);
			base.transform.Rotate(this.buildPoint.up, this.rotation);
			base.transform.position = tile2.transform.position - (tile.transform.position - base.transform.position);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x000FF718 File Offset: 0x000FD918
		protected virtual void InitializeIntObj()
		{
			this.intObj = base.GetComponentInChildren<InteractableObject>();
			if (this.intObj == null)
			{
				this.intObj = base.gameObject.AddComponent<InteractableObject>();
			}
			this.intObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.intObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x000FF78C File Offset: 0x000FD98C
		public virtual void Destroy_Internal()
		{
			this.Destroyed = true;
			for (int i = 0; i < this.coordinatePairs.Count; i++)
			{
				this.parentGrid.GetTile(this.coordinatePairs[i].coord2).SetOccupant(null);
			}
			if (base.GetComponentInParent<IStorageEntity>() != null)
			{
				base.GetComponentInParent<IStorageEntity>().DereserveItem(this);
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x000FF7F7 File Offset: 0x000FD9F7
		public void DestroyStoredItem()
		{
			this.Destroyed = true;
			this.ClearFootprintOccupancy();
			if (this != null && base.gameObject != null)
			{
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x000FF828 File Offset: 0x000FDA28
		public void ClearFootprintOccupancy()
		{
			if (this.parentGrid == null)
			{
				return;
			}
			for (int i = 0; i < this.coordinatePairs.Count; i++)
			{
				StorageTile tile = this.parentGrid.GetTile(this.coordinatePairs[i].coord2);
				if (!(tile == null))
				{
					tile.SetOccupant(null);
					this.parentGrid.freeTiles.Add(tile);
				}
			}
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x000FF898 File Offset: 0x000FDA98
		public void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
			this.canBePickedUp = _canBePickedUp;
			this.noPickupReason = _noPickupReason;
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x000FF8A8 File Offset: 0x000FDAA8
		public static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			foreach (Transform transform in go.GetComponentsInChildren<Transform>(true))
			{
				if (transform.gameObject.layer != LayerMask.NameToLayer("Grid"))
				{
					transform.gameObject.layer = layerNumber;
				}
			}
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x000FF8F4 File Offset: 0x000FDAF4
		public static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			return (from x in itemList
			where x.parentStorageEntity.WhoIsReserving(x) == null || x.parentStorageEntity.WhoIsReserving(x) == allowedReservant
			select x).ToList<StoredItem>();
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x000FF925 File Offset: 0x000FDB25
		public virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			return Object.Instantiate<GameObject>(base.gameObject, parent);
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x000FF934 File Offset: 0x000FDB34
		public void SetFootprintTileVisiblity(bool visible)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].tile.tileAppearance.SetVisible(visible);
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x000FF974 File Offset: 0x000FDB74
		public void CalculateFootprintTileIntersections()
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				this.CoordinateFootprintTilePairs[i].tile.tileDetector.CheckIntersections(true);
			}
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x000FF9B4 File Offset: 0x000FDBB4
		public FootprintTile GetTile(Coordinate coord)
		{
			for (int i = 0; i < this.CoordinateFootprintTilePairs.Count; i++)
			{
				if (this.CoordinateFootprintTilePairs[i].coord.Equals(coord))
				{
					return this.CoordinateFootprintTilePairs[i].tile;
				}
			}
			return null;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x000FFA04 File Offset: 0x000FDC04
		public virtual void Hovered()
		{
			if (this.canBePickedUp)
			{
				if (PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(this.item, 1))
				{
					this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
					this.intObj.SetMessage(string.Concat(new string[]
					{
						"Pick up <color=#",
						ColorUtility.ToHtmlStringRGBA(this.item.LabelDisplayColor),
						">",
						this.item.Name,
						"</color>"
					}));
					return;
				}
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				this.intObj.SetMessage("Inventory full");
				return;
			}
			else
			{
				if (this.noPickupReason != "")
				{
					this.intObj.SetMessage(this.noPickupReason);
					this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
					return;
				}
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x000FFAE4 File Offset: 0x000FDCE4
		public virtual void Interacted()
		{
			if (!this.canBePickedUp)
			{
				return;
			}
			PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.item);
			this.DestroyStoredItem();
		}

		// Token: 0x04002B89 RID: 11145
		[Header("References")]
		public Transform buildPoint;

		// Token: 0x04002B8A RID: 11146
		public List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs = new List<CoordinateStorageFootprintTilePair>();

		// Token: 0x04002B8B RID: 11147
		private int footprintX = -1;

		// Token: 0x04002B8C RID: 11148
		private int footprintY = -1;

		// Token: 0x04002B8F RID: 11151
		protected InteractableObject intObj;

		// Token: 0x04002B90 RID: 11152
		protected List<CoordinatePair> coordinatePairs = new List<CoordinatePair>();

		// Token: 0x04002B91 RID: 11153
		protected float rotation;

		// Token: 0x04002B92 RID: 11154
		public int xSize;

		// Token: 0x04002B93 RID: 11155
		public int ySize;
	}
}
