using System;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006BC RID: 1724
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		// Token: 0x06002F70 RID: 12144 RVA: 0x000C6263 File Offset: 0x000C4463
		protected override void Awake()
		{
			base.Awake();
			this.officer = (base.NPC as PoliceOfficer);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000C627C File Offset: 0x000C447C
		public override void Hovered()
		{
			base.Hovered();
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000C6284 File Offset: 0x000C4484
		public override void Interacted()
		{
			base.Interacted();
			if (this.CanTalk_Checkpoint())
			{
				this.officer.PlayVO(EVOLineType.Question);
				base.InitializeDialogue(this.CheckpointRequestDialogue.name, true, "ENTRY");
			}
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000C62B8 File Offset: 0x000C44B8
		private bool CanTalk_Checkpoint()
		{
			return this.officer.behaviour.activeBehaviour != null && this.officer.behaviour.activeBehaviour is CheckpointBehaviour && !(this.officer.behaviour.activeBehaviour as CheckpointBehaviour).IsSearching;
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000C6314 File Offset: 0x000C4514
		protected override int CheckBranch(string branchLabel)
		{
			if (!(branchLabel == "BRANCH_VEHICLE_EXISTS"))
			{
				return base.CheckBranch(branchLabel);
			}
			LandVehicle lastDrivenVehicle = Player.Local.LastDrivenVehicle;
			CheckpointBehaviour checkpointBehaviour = this.officer.CheckpointBehaviour;
			if (lastDrivenVehicle != null && (checkpointBehaviour.Checkpoint.SearchArea1.vehicles.Contains(lastDrivenVehicle) || checkpointBehaviour.Checkpoint.SearchArea2.vehicles.Contains(lastDrivenVehicle)))
			{
				checkpointBehaviour.StartSearch(lastDrivenVehicle.NetworkObject, Player.Local.NetworkObject);
				return 1;
			}
			return 0;
		}

		// Token: 0x0400219C RID: 8604
		[Header("References")]
		public DialogueContainer CheckpointRequestDialogue;

		// Token: 0x0400219D RID: 8605
		private PoliceOfficer officer;
	}
}
