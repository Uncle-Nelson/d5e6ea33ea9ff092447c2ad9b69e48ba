using System;
using ScheduleOne.Employees;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0B RID: 2827
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x0013DCB2 File Offset: 0x0013BEB2
		// (set) Token: 0x06004B8D RID: 19341 RVA: 0x0013DCBA File Offset: 0x0013BEBA
		public Cleaner AssignedCleaner { get; protected set; }

		// Token: 0x06004B8E RID: 19342 RVA: 0x0013DCC4 File Offset: 0x0013BEC4
		public void Initialize(Cleaner cleaner)
		{
			this.AssignedCleaner = cleaner;
			this.AssignedCleaner.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.TitleLabel.text = cleaner.fullName;
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x0013DD20 File Offset: 0x0013BF20
		protected virtual void RefreshUI()
		{
			CleanerConfiguration cleanerConfiguration = this.AssignedCleaner.Configuration as CleanerConfiguration;
			for (int i = 0; i < this.StationsIcons.Length; i++)
			{
				if (cleanerConfiguration.Bins.SelectedObjects.Count > i)
				{
					this.StationsIcons[i].sprite = cleanerConfiguration.Bins.SelectedObjects[i].ItemInstance.Icon;
					this.StationsIcons[i].enabled = true;
				}
				else
				{
					this.StationsIcons[i].enabled = false;
				}
			}
		}

		// Token: 0x040038AD RID: 14509
		[Header("References")]
		public Image[] StationsIcons;
	}
}
