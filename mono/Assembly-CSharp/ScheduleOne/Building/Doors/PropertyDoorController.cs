using System;
using ScheduleOne.Doors;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x0200079A RID: 1946
	public class PropertyDoorController : DoorController
	{
		// Token: 0x060034EA RID: 13546 RVA: 0x000DE828 File Offset: 0x000DCA28
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Building.Doors.PropertyDoorController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x000DE847 File Offset: 0x000DCA47
		public void Unlock()
		{
			this.PlayerAccess = EDoorAccess.Open;
			this.IsUnlocked = true;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000DE858 File Offset: 0x000DCA58
		private void CheckClose()
		{
			if (!base.IsOpen)
			{
				return;
			}
			if (!this.IsUnlocked)
			{
				return;
			}
			if (base.timeInCurrentState < 2f)
			{
				return;
			}
			Player nearestWantedPlayer = this.GetNearestWantedPlayer();
			if (nearestWantedPlayer == null)
			{
				return;
			}
			if (Vector3.Distance(base.transform.position, nearestWantedPlayer.Avatar.CenterPoint) < 20f)
			{
				base.SetIsOpen_Server(false, EDoorSide.Interior, false);
			}
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000DE8C4 File Offset: 0x000DCAC4
		protected override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			if (side == EDoorSide.Exterior)
			{
				Player nearestWantedPlayer = this.GetNearestWantedPlayer();
				if (nearestWantedPlayer != null && Vector3.Distance(nearestWantedPlayer.transform.position, base.transform.position) < 15f)
				{
					PoliceOfficer nearestOfficer = nearestWantedPlayer.CrimeData.NearestOfficer;
					float num = 100000f;
					if (nearestOfficer != null)
					{
						num = Vector3.Distance(nearestOfficer.Avatar.CenterPoint, nearestWantedPlayer.Avatar.CenterPoint);
					}
					if (nearestWantedPlayer.CrimeData.TimeSinceSighted < 5f || num < 15f)
					{
						reason = "Police are nearby!";
						return false;
					}
				}
			}
			return base.CanPlayerAccess(side, out reason);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000DE96C File Offset: 0x000DCB6C
		private Player GetNearestWantedPlayer()
		{
			Player player = null;
			for (int i = 0; i < Player.PlayerList.Count; i++)
			{
				if (Player.PlayerList[i].CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None && (player == null || Vector3.Distance(base.transform.position, Player.PlayerList[i].Avatar.CenterPoint) < Vector3.Distance(base.transform.position, player.Avatar.CenterPoint)))
				{
					player = Player.PlayerList[i];
				}
			}
			return player;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000DEA07 File Offset: 0x000DCC07
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000DEA20 File Offset: 0x000DCC20
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000DEA39 File Offset: 0x000DCC39
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000DEA48 File Offset: 0x000DCC48
		protected virtual void dll()
		{
			base.Awake();
			this.PlayerAccess = EDoorAccess.ExitOnly;
			if (this.Property != null)
			{
				this.Property.onThisPropertyAcquired.AddListener(new UnityAction(this.Unlock));
			}
			base.InvokeRepeating("CheckClose", 0f, 1f);
		}

		// Token: 0x040025D3 RID: 9683
		public const float WANTED_PLAYER_CLOSE_DISTANCE = 20f;

		// Token: 0x040025D4 RID: 9684
		public Property Property;

		// Token: 0x040025D5 RID: 9685
		private bool IsUnlocked;

		// Token: 0x040025D6 RID: 9686
		private bool dll_Excuted;

		// Token: 0x040025D7 RID: 9687
		private bool dll_Excuted;
	}
}
