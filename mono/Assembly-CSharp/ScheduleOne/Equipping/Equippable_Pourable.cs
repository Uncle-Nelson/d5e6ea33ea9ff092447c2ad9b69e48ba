using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.PlayerTasks.Tasks;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000924 RID: 2340
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06003F45 RID: 16197 RVA: 0x0010B0A9 File Offset: 0x001092A9
		// (set) Token: 0x06003F46 RID: 16198 RVA: 0x0010B0B1 File Offset: 0x001092B1
		public virtual string InteractionLabel { get; set; } = "Pour";

		// Token: 0x06003F47 RID: 16199 RVA: 0x0010B0BC File Offset: 0x001092BC
		protected override void Update()
		{
			base.Update();
			if (Singleton<TaskManager>.Instance.currentTask != null)
			{
				return;
			}
			if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
			{
				return;
			}
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.InteractionRange, out raycastHit, Singleton<InteractionManager>.Instance.Interaction_SearchMask, true, 0f))
			{
				Pot componentInParent = raycastHit.collider.GetComponentInParent<Pot>();
				if (componentInParent == null)
				{
					return;
				}
				string empty = string.Empty;
				if (this.CanPour(componentInParent, out empty))
				{
					if (componentInParent.PlayerUserObject != null)
					{
						componentInParent.ConfigureInteraction("In use by other player", InteractableObject.EInteractableState.Invalid, false);
						return;
					}
					if (componentInParent.NPCUserObject != null)
					{
						componentInParent.ConfigureInteraction("In use by workers", InteractableObject.EInteractableState.Invalid, false);
						return;
					}
					componentInParent.ConfigureInteraction(this.InteractionLabel, InteractableObject.EInteractableState.Default, false);
					if (GameInput.GetButtonDown(GameInput.ButtonCode.Interact))
					{
						this.StartPourTask(componentInParent);
						return;
					}
				}
				else
				{
					if (empty != string.Empty)
					{
						componentInParent.ConfigureInteraction(empty, InteractableObject.EInteractableState.Invalid, false);
						return;
					}
					componentInParent.ConfigureInteraction(string.Empty, InteractableObject.EInteractableState.Disabled, false);
				}
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x0010B1B4 File Offset: 0x001093B4
		protected virtual void StartPourTask(Pot pot)
		{
			new PourIntoPotTask(pot, this.itemInstance, this.PourablePrefab);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x0010B1C9 File Offset: 0x001093C9
		protected virtual bool CanPour(Pot pot, out string reason)
		{
			reason = string.Empty;
			return true;
		}

		// Token: 0x04002D75 RID: 11637
		[Header("Pourable settings")]
		public float InteractionRange = 2.5f;

		// Token: 0x04002D76 RID: 11638
		public Pourable PourablePrefab;
	}
}
