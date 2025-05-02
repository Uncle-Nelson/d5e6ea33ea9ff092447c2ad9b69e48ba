using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B07 RID: 2823
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0013D9D9 File Offset: 0x0013BBD9
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x0013D9E1 File Offset: 0x0013BBE1
		public BrickPress AssignedPress { get; protected set; }

		// Token: 0x06004B7A RID: 19322 RVA: 0x0013D9EA File Offset: 0x0013BBEA
		public void Initialize(BrickPress press)
		{
			this.AssignedPress = press;
			this.AssignedPress.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x0013DA28 File Offset: 0x0013BC28
		protected virtual void RefreshUI()
		{
			BrickPressConfiguration brickPressConfiguration = this.AssignedPress.Configuration as BrickPressConfiguration;
			base.SetAssignedNPC(brickPressConfiguration.AssignedPackager.SelectedNPC);
		}
	}
}
