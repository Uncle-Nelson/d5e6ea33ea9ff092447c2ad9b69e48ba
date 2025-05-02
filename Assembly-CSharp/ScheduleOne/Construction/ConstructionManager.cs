using System;
using FishNet.Object;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.Construction.ConstructionMethods;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Construction;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Construction
{
	// Token: 0x02000722 RID: 1826
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000CD292 File Offset: 0x000CB492
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x000CD29A File Offset: 0x000CB49A
		public bool constructionModeEnabled { get; protected set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000CD2A3 File Offset: 0x000CB4A3
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x000CD2AB File Offset: 0x000CB4AB
		public bool isDeployingConstructable { get; protected set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000CD2B4 File Offset: 0x000CB4B4
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x000CD2BC File Offset: 0x000CB4BC
		public bool isMovingConstructable { get; protected set; }

		// Token: 0x06003173 RID: 12659 RVA: 0x000CD2C5 File Offset: 0x000CB4C5
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 0);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000CD2E0 File Offset: 0x000CB4E0
		public void EnterConstructionMode(Property prop)
		{
			this.currentProperty = prop;
			this.constructionModeEnabled = true;
			prop.SetBoundsVisible(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			if (this.onConstructionModeEnabled != null)
			{
				this.onConstructionModeEnabled();
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x000CD338 File Offset: 0x000CB538
		public void ExitConstructionMode()
		{
			this.currentProperty.SetBoundsVisible(false);
			this.constructionModeEnabled = false;
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<BirdsEyeView>.Instance.Disable(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			this.currentProperty = null;
			if (this.onConstructionModeDisabled != null)
			{
				this.onConstructionModeDisabled();
			}
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x000CD3A0 File Offset: 0x000CB5A0
		public void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
			this.isDeployingConstructable = true;
			if (Registry.GetConstructable(listing.ID)._constructionHandler_Asset != null)
			{
				this.constructHandler = Object.Instantiate<GameObject>(Registry.GetConstructable(listing.ID)._constructionHandler_Asset, base.transform);
				this.constructHandler.GetComponent<ConstructStart_Base>().StartConstruction(listing.ID, null);
				return;
			}
			Console.LogWarning("Constructable doesn't have a construction handler!", null);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x000CD410 File Offset: 0x000CB610
		public void StopConstructableDeploy()
		{
			this.isDeployingConstructable = false;
			this.constructHandler.GetComponent<ConstructStop_Base>().StopConstruction();
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000CD42C File Offset: 0x000CB62C
		public void MoveConstructable(Constructable_GridBased c)
		{
			this.isMovingConstructable = true;
			if (c._constructionHandler_Asset != null)
			{
				this.constructHandler = Object.Instantiate<GameObject>(c._constructionHandler_Asset, base.transform);
				this.constructHandler.GetComponent<ConstructStart_Base>().StartConstruction(c.PrefabID, c);
				return;
			}
			Console.LogWarning("Constructable doesn't have a construction handler!", null);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000CD488 File Offset: 0x000CB688
		public void StopMovingConstructable()
		{
			this.isMovingConstructable = false;
			this.constructHandler.GetComponent<ConstructStop_Base>().StopConstruction();
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000CD4A4 File Offset: 0x000CB6A4
		private void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (this.constructionModeEnabled)
			{
				if (this.isDeployingConstructable)
				{
					exit.used = true;
					Singleton<ConstructionMenu>.Instance.ClearSelectedListing();
					return;
				}
				if (this.isMovingConstructable)
				{
					exit.used = true;
					this.StopMovingConstructable();
					return;
				}
				if (exit.exitType == ExitType.Escape)
				{
					exit.used = true;
					this.ExitConstructionMode();
				}
			}
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000CD508 File Offset: 0x000CB708
		public Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			Constructable_GridBased component = Object.Instantiate<GameObject>(Registry.GetPrefab(ID), null).GetComponent<Constructable_GridBased>();
			component.InitializeConstructable_GridBased(grid, originCoordinate, rotation);
			this.networkObject.Spawn(component.gameObject, null, default(Scene));
			return component;
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000CD54D File Offset: 0x000CB74D
		public Constructable CreateConstructable(string prefabID)
		{
			return Object.Instantiate<GameObject>(Registry.GetPrefab(prefabID), null).GetComponent<Constructable>();
		}

		// Token: 0x04002335 RID: 9013
		public NetworkObject networkObject;

		// Token: 0x04002337 RID: 9015
		public Action onConstructionModeEnabled;

		// Token: 0x04002338 RID: 9016
		public Action onConstructionModeDisabled;

		// Token: 0x0400233A RID: 9018
		public GameObject constructHandler;

		// Token: 0x0400233C RID: 9020
		public ConstructionManager.ConstructableNotification onNewConstructableBuilt;

		// Token: 0x0400233D RID: 9021
		public ConstructionManager.ConstructableNotification onConstructableMoved;

		// Token: 0x0400233E RID: 9022
		public Property currentProperty;

		// Token: 0x02000723 RID: 1827
		public class WorldIntersection
		{
			// Token: 0x0400233F RID: 9023
			public FootprintTile footprint;

			// Token: 0x04002340 RID: 9024
			public Tile tile;
		}

		// Token: 0x02000724 RID: 1828
		// (Invoke) Token: 0x06003180 RID: 12672
		public delegate void ConstructableNotification(Constructable c);
	}
}
