using System;
using FishNet.Connection;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005B5 RID: 1461
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x0600244D RID: 9293 RVA: 0x000933C4 File Offset: 0x000915C4
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.WesternCheckpoint.ActivationState == RoadCheckpoint.ECheckpointState.Enabled)
			{
				this.WesternCheckpoint.Enable(connection);
			}
			if (this.DocksCheckpoint.ActivationState == RoadCheckpoint.ECheckpointState.Enabled)
			{
				this.DocksCheckpoint.Enable(connection);
			}
			if (this.NorthResidentialCheckpoint.ActivationState == RoadCheckpoint.ECheckpointState.Enabled)
			{
				this.NorthResidentialCheckpoint.Enable(connection);
			}
			if (this.WestResidentialCheckpoint.ActivationState == RoadCheckpoint.ECheckpointState.Enabled)
			{
				this.WestResidentialCheckpoint.Enable(connection);
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00093440 File Offset: 0x00091640
		public void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
			if (enabled)
			{
				this.GetCheckpoint(checkpoint).Enable(null);
				for (int i = 0; i < requestedOfficers; i++)
				{
					if (Singleton<Map>.Instance.PoliceStation.OfficerPool.Count <= 0)
					{
						return;
					}
					Singleton<Map>.Instance.PoliceStation.PullOfficer().AssignToCheckpoint(checkpoint);
				}
				return;
			}
			this.GetCheckpoint(checkpoint).Disable();
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000934A2 File Offset: 0x000916A2
		public RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			switch (loc)
			{
			case CheckpointManager.ECheckpointLocation.Western:
				return this.WesternCheckpoint;
			case CheckpointManager.ECheckpointLocation.Docks:
				return this.DocksCheckpoint;
			case CheckpointManager.ECheckpointLocation.NorthResidential:
				return this.NorthResidentialCheckpoint;
			case CheckpointManager.ECheckpointLocation.WestResidential:
				return this.WestResidentialCheckpoint;
			default:
				return null;
			}
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000934E1 File Offset: 0x000916E1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x000934FA File Offset: 0x000916FA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00093513 File Offset: 0x00091713
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00093521 File Offset: 0x00091721
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001B0F RID: 6927
		[Header("References")]
		public RoadCheckpoint WesternCheckpoint;

		// Token: 0x04001B10 RID: 6928
		public RoadCheckpoint DocksCheckpoint;

		// Token: 0x04001B11 RID: 6929
		public RoadCheckpoint NorthResidentialCheckpoint;

		// Token: 0x04001B12 RID: 6930
		public RoadCheckpoint WestResidentialCheckpoint;

		// Token: 0x04001B13 RID: 6931
		private bool dll_Excuted;

		// Token: 0x04001B14 RID: 6932
		private bool dll_Excuted;

		// Token: 0x020005B6 RID: 1462
		public enum ECheckpointLocation
		{
			// Token: 0x04001B16 RID: 6934
			Western,
			// Token: 0x04001B17 RID: 6935
			Docks,
			// Token: 0x04001B18 RID: 6936
			NorthResidential,
			// Token: 0x04001B19 RID: 6937
			WestResidential
		}
	}
}
