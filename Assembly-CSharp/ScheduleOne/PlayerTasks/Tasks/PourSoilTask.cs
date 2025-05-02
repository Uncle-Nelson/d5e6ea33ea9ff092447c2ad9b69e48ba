using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.Soil;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200035B RID: 859
	public class PourSoilTask : PourIntoPotTask
	{
		// Token: 0x0600136B RID: 4971 RVA: 0x00056930 File Offset: 0x00054B30
		public PourSoilTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : base(_pot, _itemInstance, _pourablePrefab)
		{
			base.CurrentInstruction = "Click and drag to cut soil bag";
			this.soil = (this.pourable as PourableSoil);
			this.soil.onOpened.AddListener(new UnityAction(base.RemoveItem));
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00056980 File Offset: 0x00054B80
		public override void Update()
		{
			base.Update();
			if (this.soil.IsOpen)
			{
				base.CurrentInstruction = "Pour soil into pot (" + Mathf.FloorToInt(this.pot.SoilLevel / this.pot.SoilCapacity * 100f).ToString() + "%)";
			}
			this.UpdateHover();
			this.UpdateCursor();
			if (this.HoveredTopCollider != null && GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && this.soil.TopColliders.IndexOf(this.HoveredTopCollider) == this.soil.currentCut)
			{
				this.soil.Cut();
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00056A2F File Offset: 0x00054C2F
		public override void StopTask()
		{
			this.pot.PushSoilDataToServer();
			base.StopTask();
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00056A44 File Offset: 0x00054C44
		protected override void UpdateCursor()
		{
			if (this.soil.IsOpen)
			{
				base.UpdateCursor();
				return;
			}
			if (this.HoveredTopCollider != null && this.soil.TopColliders.IndexOf(this.HoveredTopCollider) == this.soil.currentCut)
			{
				Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Scissors);
				return;
			}
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00056AAD File Offset: 0x00054CAD
		private void UpdateHover()
		{
			this.HoveredTopCollider = this.GetHoveredTopCollider();
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00056ABC File Offset: 0x00054CBC
		private Collider GetHoveredTopCollider()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(3f, out raycastHit, Singleton<InteractionManager>.Instance.Interaction_SearchMask, true, 0f) && this.soil.TopColliders.Contains(raycastHit.collider))
			{
				return raycastHit.collider;
			}
			return null;
		}

		// Token: 0x040012A1 RID: 4769
		private PourableSoil soil;

		// Token: 0x040012A2 RID: 4770
		private Collider HoveredTopCollider;
	}
}
