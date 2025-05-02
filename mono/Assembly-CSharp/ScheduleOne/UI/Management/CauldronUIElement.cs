using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B08 RID: 2824
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x0013DA57 File Offset: 0x0013BC57
		// (set) Token: 0x06004B7E RID: 19326 RVA: 0x0013DA5F File Offset: 0x0013BC5F
		public Cauldron AssignedCauldron { get; protected set; }

		// Token: 0x06004B7F RID: 19327 RVA: 0x0013DA68 File Offset: 0x0013BC68
		public void Initialize(Cauldron cauldron)
		{
			this.AssignedCauldron = cauldron;
			this.AssignedCauldron.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x0013DAA8 File Offset: 0x0013BCA8
		protected virtual void RefreshUI()
		{
			CauldronConfiguration cauldronConfiguration = this.AssignedCauldron.Configuration as CauldronConfiguration;
			base.SetAssignedNPC(cauldronConfiguration.AssignedChemist.SelectedNPC);
		}
	}
}
