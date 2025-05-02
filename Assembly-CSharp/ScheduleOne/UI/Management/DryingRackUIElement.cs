using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0C RID: 2828
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x0013DDAA File Offset: 0x0013BFAA
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x0013DDB2 File Offset: 0x0013BFB2
		public DryingRack AssignedRack { get; protected set; }

		// Token: 0x06004B93 RID: 19347 RVA: 0x0013DDBB File Offset: 0x0013BFBB
		public void Initialize(DryingRack rack)
		{
			this.AssignedRack = rack;
			this.AssignedRack.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x0013DDF8 File Offset: 0x0013BFF8
		protected virtual void RefreshUI()
		{
			DryingRackConfiguration dryingRackConfiguration = this.AssignedRack.Configuration as DryingRackConfiguration;
			EQuality value = dryingRackConfiguration.TargetQuality.Value;
			this.TargetQualityIcon.color = ItemQuality.GetColor(value);
			base.SetAssignedNPC(dryingRackConfiguration.AssignedBotanist.SelectedNPC);
		}

		// Token: 0x040038B0 RID: 14512
		public Image TargetQualityIcon;
	}
}
