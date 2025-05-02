using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034B RID: 843
	public class HarvestPlant : Task
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00053341 File Offset: 0x00051541
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00053349 File Offset: 0x00051549
		public override string TaskName { get; protected set; } = "Harvest plant";

		// Token: 0x060012F3 RID: 4851 RVA: 0x00053354 File Offset: 0x00051554
		public HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab)
		{
			if (_pot == null)
			{
				Console.LogWarning("HarvestPlant: pot null", null);
				this.StopTask();
				return;
			}
			if (_pot.Plant == null)
			{
				Console.LogWarning("HarvestPlant: pot has no plant in it", null);
			}
			this.ClickDetectionEnabled = true;
			HarvestPlant.CanDrag = canDrag;
			this.ClickDetectionRadius = 0.02f;
			this.pot = _pot;
			this.pot.SetPlayerUser(Player.Local.NetworkObject);
			this.pot.PositionCameraContainer();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.pot.FullshotPosition.position, this.pot.FullshotPosition.rotation, 0.25f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.25f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			this.pot.Plant.Collider.enabled = false;
			this.pot.IntObj.GetComponent<Collider>().enabled = false;
			if (this.pot.AlignLeafDropToPlayer)
			{
				this.pot.LeafDropPoint.transform.rotation = Quaternion.LookRotation(Player.Local.Avatar.CenterPoint - this.pot.LeafDropPoint.position, Vector3.up);
			}
			this.HarvestTotal = this.pot.Plant.ActiveHarvestables.Count;
			this.UpdateInstructionText();
			if (soundLoopPrefab != null)
			{
				this.SoundLoop = Object.Instantiate<AudioSourceController>(soundLoopPrefab, NetworkSingleton<GameManager>.Instance.Temp);
				this.SoundLoop.VolumeMultiplier = 0f;
				this.SoundLoop.transform.position = this.pot.transform.position + Vector3.up * 1f;
				this.SoundLoop.Play();
			}
			Singleton<InputPromptsCanvas>.Instance.LoadModule("harvestplant");
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00053564 File Offset: 0x00051764
		private void UpdateInstructionText()
		{
			if (this.pot == null || this.pot.Plant == null)
			{
				return;
			}
			if (HarvestPlant.CanDrag)
			{
				base.CurrentInstruction = string.Concat(new string[]
				{
					"Click and hold over ",
					this.pot.Plant.HarvestTarget,
					" to harvest (",
					this.HarvestCount.ToString(),
					"/",
					this.HarvestTotal.ToString(),
					")"
				});
				return;
			}
			base.CurrentInstruction = string.Concat(new string[]
			{
				"Click ",
				this.pot.Plant.HarvestTarget,
				" to harvest (",
				this.HarvestCount.ToString(),
				"/",
				this.HarvestTotal.ToString(),
				")"
			});
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005365C File Offset: 0x0005185C
		public override void StopTask()
		{
			base.StopTask();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.25f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.25f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			if (this.pot.Plant != null)
			{
				this.pot.Plant.Collider.enabled = true;
			}
			if (this.SoundLoop != null)
			{
				Object.Destroy(this.SoundLoop.gameObject);
			}
			this.pot.IntObj.GetComponent<Collider>().enabled = true;
			this.pot.SetPlayerUser(null);
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005372D File Offset: 0x0005192D
		protected override void UpdateCursor()
		{
			if (this.GetHoveredHarvestable() != null)
			{
				Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Scissors);
				return;
			}
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00053754 File Offset: 0x00051954
		public override void Update()
		{
			base.Update();
			if (this.pot == null || this.pot.Plant == null)
			{
				this.StopTask();
				return;
			}
			PlantHarvestable hoveredHarvestable = this.GetHoveredHarvestable();
			if (this.SoundLoop != null)
			{
				if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
				{
					this.SoundLoop.VolumeMultiplier = Mathf.MoveTowards(this.SoundLoop.VolumeMultiplier, 1f, Time.deltaTime * 4f);
				}
				else
				{
					this.SoundLoop.VolumeMultiplier = Mathf.MoveTowards(this.SoundLoop.VolumeMultiplier, 0f, Time.deltaTime * 4f);
				}
			}
			if (hoveredHarvestable != null)
			{
				if (!PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(this.pot.Plant.GetHarvestedProduct(1), hoveredHarvestable.ProductQuantity))
				{
					Singleton<MouseTooltip>.Instance.ShowIcon(Singleton<MouseTooltip>.Instance.Sprite_Cross, Singleton<MouseTooltip>.Instance.Color_Invalid);
					Singleton<MouseTooltip>.Instance.ShowTooltip("Inventory full", Singleton<MouseTooltip>.Instance.Color_Invalid);
				}
				else if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) || (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && HarvestPlant.CanDrag))
				{
					GameObject gameObject = Object.Instantiate<GameObject>(this.pot.Plant.SnipSound.gameObject);
					gameObject.transform.position = hoveredHarvestable.transform.position;
					gameObject.GetComponent<AudioSourceController>().PlayOneShot(false);
					Object.Destroy(gameObject, 1f);
					hoveredHarvestable.Harvest(true);
					this.HarvestCount++;
					this.UpdateInstructionText();
					if (this.pot.Plant == null)
					{
						this.Success();
					}
				}
			}
			if (GameInput.GetButton(GameInput.ButtonCode.Left))
			{
				this.rotation -= Time.deltaTime * 100f;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.Right))
			{
				this.rotation += Time.deltaTime * 100f;
			}
			this.pot.OverrideRotation(this.rotation);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00053954 File Offset: 0x00051B54
		private PlantHarvestable GetHoveredHarvestable()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(3f, out raycastHit, Singleton<InteractionManager>.Instance.Interaction_SearchMask, true, 0f))
			{
				return raycastHit.collider.gameObject.GetComponentInParent<PlantHarvestable>();
			}
			return null;
		}

		// Token: 0x04001244 RID: 4676
		protected Pot pot;

		// Token: 0x04001245 RID: 4677
		private int HarvestCount;

		// Token: 0x04001246 RID: 4678
		private int HarvestTotal;

		// Token: 0x04001247 RID: 4679
		private float rotation;

		// Token: 0x04001248 RID: 4680
		private static bool hintShown;

		// Token: 0x04001249 RID: 4681
		private static bool CanDrag;

		// Token: 0x0400124A RID: 4682
		private AudioSourceController SoundLoop;
	}
}
