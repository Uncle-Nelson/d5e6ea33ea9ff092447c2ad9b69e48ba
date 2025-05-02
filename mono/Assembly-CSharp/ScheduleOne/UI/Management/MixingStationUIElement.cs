using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0E RID: 2830
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x0013DEC3 File Offset: 0x0013C0C3
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x0013DECB File Offset: 0x0013C0CB
		public MixingStation AssignedStation { get; protected set; }

		// Token: 0x06004B9D RID: 19357 RVA: 0x0013DED4 File Offset: 0x0013C0D4
		public void Initialize(MixingStation station)
		{
			this.AssignedStation = station;
			this.AssignedStation.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x0013DF14 File Offset: 0x0013C114
		protected virtual void RefreshUI()
		{
			MixingStationConfiguration mixingStationConfiguration = this.AssignedStation.Configuration as MixingStationConfiguration;
			base.SetAssignedNPC(mixingStationConfiguration.AssignedChemist.SelectedNPC);
		}
	}
}
