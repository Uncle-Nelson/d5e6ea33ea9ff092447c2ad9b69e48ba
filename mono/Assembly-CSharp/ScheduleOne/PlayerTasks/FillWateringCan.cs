using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property.Utilities.Water;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000346 RID: 838
	public class FillWateringCan : Task
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000529F2 File Offset: 0x00050BF2
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x000529FA File Offset: 0x00050BFA
		public new string TaskName { get; protected set; } = "Fill watering can";

		// Token: 0x060012D6 RID: 4822 RVA: 0x00052A04 File Offset: 0x00050C04
		public FillWateringCan(Tap _tap, WateringCanInstance _instance)
		{
			this.tap = _tap;
			this.instance = _instance;
			this.ClickDetectionEnabled = true;
			this.tap.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.tap.CameraPos.position, this.tap.CameraPos.rotation, 0.25f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.25f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			base.CurrentInstruction = "Click and hold tap to refill watering can";
			this.visuals = this.tap.CreateWateringCanModel_Local(this.instance.ID, true).GetComponent<WateringCanVisuals>();
			this.visuals.SetFillLevel(this.instance.CurrentFillAmount / 15f);
			this.visuals.FillSound.VolumeMultiplier = 0f;
			this.tap.SendWateringCanModel(this.instance.ID);
			this.tap.HandleClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.HandleClickStart));
			this.tap.HandleClickable.onClickEnd.AddListener(new UnityAction(this.HandleClickEnd));
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00052B68 File Offset: 0x00050D68
		public override void Update()
		{
			base.Update();
			if (this.tap.ActualFlowRate > 0f)
			{
				this.instance.ChangeFillAmount(this.tap.ActualFlowRate * Time.deltaTime);
				if (!this.visuals.FillSound.isPlaying && !this.audioPlayed)
				{
					this.visuals.FillSound.Play();
					this.audioPlayed = true;
				}
				this.visuals.FillSound.VolumeMultiplier = Mathf.MoveTowards(this.visuals.FillSound.VolumeMultiplier, 1f, Time.deltaTime * 4f);
			}
			else
			{
				this.audioPlayed = false;
				if (this.visuals.FillSound.isPlaying)
				{
					this.visuals.FillSound.VolumeMultiplier = Mathf.MoveTowards(this.visuals.FillSound.VolumeMultiplier, 0f, Time.deltaTime * 4f);
					if (this.visuals.FillSound.VolumeMultiplier <= 0f)
					{
						this.visuals.FillSound.Stop();
					}
				}
			}
			this.visuals.SetFillLevel(this.instance.CurrentFillAmount / 15f);
			if (this.instance.CurrentFillAmount >= 15f)
			{
				this.Success();
				return;
			}
			if (this.tap.ActualFlowRate > 0f && this.instance.CurrentFillAmount >= 15f)
			{
				this.visuals.SetOverflowParticles(true);
				return;
			}
			this.visuals.SetOverflowParticles(false);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00052CFC File Offset: 0x00050EFC
		public override void StopTask()
		{
			this.tap.SetHeldOpen(false);
			this.tap.SetPlayerUser(null);
			this.tap.SendClearWateringCanModelModel();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.25f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.25f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Object.Destroy(this.visuals.gameObject);
			base.StopTask();
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00052D82 File Offset: 0x00050F82
		private void HandleClickStart(RaycastHit hit)
		{
			this.tap.SetHeldOpen(true);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00052D90 File Offset: 0x00050F90
		private void HandleClickEnd()
		{
			this.tap.SetHeldOpen(false);
		}

		// Token: 0x04001231 RID: 4657
		protected Tap tap;

		// Token: 0x04001232 RID: 4658
		protected WateringCanInstance instance;

		// Token: 0x04001233 RID: 4659
		protected WateringCanVisuals visuals;

		// Token: 0x04001234 RID: 4660
		private bool audioPlayed;
	}
}
