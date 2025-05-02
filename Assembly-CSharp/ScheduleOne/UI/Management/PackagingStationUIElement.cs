using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B10 RID: 2832
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x0013E06D File Offset: 0x0013C26D
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x0013E075 File Offset: 0x0013C275
		public PackagingStation AssignedStation { get; protected set; }

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0013E07E File Offset: 0x0013C27E
		public void Initialize(PackagingStation pack)
		{
			this.AssignedStation = pack;
			this.AssignedStation.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0013E0BC File Offset: 0x0013C2BC
		protected virtual void RefreshUI()
		{
			PackagingStationConfiguration packagingStationConfiguration = this.AssignedStation.Configuration as PackagingStationConfiguration;
			base.SetAssignedNPC(packagingStationConfiguration.AssignedPackager.SelectedNPC);
		}
	}
}
