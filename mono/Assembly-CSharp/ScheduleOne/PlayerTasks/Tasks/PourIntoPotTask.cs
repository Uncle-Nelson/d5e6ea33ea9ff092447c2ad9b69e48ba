using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Trash;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000359 RID: 857
	public class PourIntoPotTask : Task
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00056394 File Offset: 0x00054594
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0005639C File Offset: 0x0005459C
		public override string TaskName { get; protected set; } = "Pour";

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x000563A5 File Offset: 0x000545A5
		protected virtual bool UseCoverage { get; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x000563AD File Offset: 0x000545AD
		protected virtual bool FailOnEmpty { get; } = 1;

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x000563B5 File Offset: 0x000545B5
		protected virtual Pot.ECameraPosition CameraPosition { get; } = 1;

		// Token: 0x06001361 RID: 4961 RVA: 0x000563C0 File Offset: 0x000545C0
		public PourIntoPotTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
			if (_pot == null)
			{
				Console.LogWarning("PourIntoPotTask: pot null", null);
				this.StopTask();
				return;
			}
			if (_pourablePrefab == null)
			{
				Console.LogWarning("PourIntoPotTask: pourablePrefab null", null);
				this.StopTask();
				return;
			}
			this.ClickDetectionEnabled = true;
			this.item = _itemInstance;
			this.pot = _pot;
			if (this.pot.Plant != null)
			{
				this.pot.Plant.SetVisible(false);
			}
			this.pot.SetPlayerUser(Player.Local.NetworkObject);
			this.pot.PositionCameraContainer();
			Transform cameraPosition = this.pot.GetCameraPosition(this.CameraPosition);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(cameraPosition.position, cameraPosition.rotation, 0.25f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.25f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			this.pourable = Object.Instantiate<GameObject>(_pourablePrefab.gameObject, NetworkSingleton<GameManager>.Instance.Temp).GetComponent<Pourable>();
			this.pourable.transform.position = this.pot.PourableStartPoint.position;
			this.pourable.Rb.position = this.pot.PourableStartPoint.position;
			this.pourable.Origin = this.pot.PourableStartPoint.position;
			this.pourable.MaxDistanceFromOrigin = 0.5f;
			this.pourable.LocationRestrictionEnabled = true;
			this.pourable.TargetPot = _pot;
			Pourable pourable = this.pourable;
			pourable.onInitialPour = (Action)Delegate.Combine(pourable.onInitialPour, new Action(this.OnInitialPour));
			Vector3 vector = PlayerSingleton<PlayerCamera>.Instance.transform.position - this.pourable.transform.position;
			this.pourable.transform.rotation = Quaternion.LookRotation(new Vector3(vector.x, 0f, vector.z), Vector3.up);
			this.pourable.Rb.rotation = Quaternion.LookRotation(new Vector3(vector.x, 0f, vector.z), Vector3.up);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("pourable");
			if (this.UseCoverage)
			{
				this.pot.SoilCover.Reset();
				this.pot.SoilCover.gameObject.SetActive(true);
				this.pot.SoilCover.onSufficientCoverage.AddListener(new UnityAction(this.FullyCovered));
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0005668B File Offset: 0x0005488B
		public override void Update()
		{
			base.Update();
			if (this.FailOnEmpty && this.pourable.currentQuantity <= 0f)
			{
				this.Fail();
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000566B4 File Offset: 0x000548B4
		public override void StopTask()
		{
			base.StopTask();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.15f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.15f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Object.Destroy(this.pourable.gameObject);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			if (this.UseCoverage)
			{
				this.pot.SoilCover.onSufficientCoverage.RemoveListener(new UnityAction(this.FullyCovered));
				this.pot.SoilCover.gameObject.SetActive(false);
			}
			if (this.pot.Plant != null)
			{
				this.pot.Plant.SetVisible(true);
			}
			this.pot.SetPlayerUser(null);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00056791 File Offset: 0x00054991
		private void OnInitialPour()
		{
			if (this.removeItemAfterInitialPour)
			{
				this.RemoveItem();
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000567A4 File Offset: 0x000549A4
		protected void RemoveItem()
		{
			PlayerSingleton<PlayerInventory>.Instance.RemoveAmountOfItem(this.item.ID, 1U);
			if (this.pourable.TrashItem != null)
			{
				NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.pourable.TrashItem.ID, Player.Local.Avatar.transform.position + Vector3.up * 0.3f, Random.rotation, default(Vector3), "", false);
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void FullyCovered()
		{
		}

		// Token: 0x04001296 RID: 4758
		protected Pot pot;

		// Token: 0x04001297 RID: 4759
		protected ItemInstance item;

		// Token: 0x04001298 RID: 4760
		protected Pourable pourable;

		// Token: 0x0400129C RID: 4764
		protected bool removeItemAfterInitialPour;
	}
}
