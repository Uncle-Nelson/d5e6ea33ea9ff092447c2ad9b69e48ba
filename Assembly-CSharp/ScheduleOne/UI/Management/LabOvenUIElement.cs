using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0D RID: 2829
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x0013DE44 File Offset: 0x0013C044
		// (set) Token: 0x06004B97 RID: 19351 RVA: 0x0013DE4C File Offset: 0x0013C04C
		public LabOven AssignedOven { get; protected set; }

		// Token: 0x06004B98 RID: 19352 RVA: 0x0013DE55 File Offset: 0x0013C055
		public void Initialize(LabOven oven)
		{
			this.AssignedOven = oven;
			this.AssignedOven.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x0013DE94 File Offset: 0x0013C094
		protected virtual void RefreshUI()
		{
			LabOvenConfiguration labOvenConfiguration = this.AssignedOven.Configuration as LabOvenConfiguration;
			base.SetAssignedNPC(labOvenConfiguration.AssignedChemist.SelectedNPC);
		}
	}
}
