using System;
using ScheduleOne.Employees;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0A RID: 2826
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x0013DBBB File Offset: 0x0013BDBB
		// (set) Token: 0x06004B88 RID: 19336 RVA: 0x0013DBC3 File Offset: 0x0013BDC3
		public Chemist AssignedChemist { get; protected set; }

		// Token: 0x06004B89 RID: 19337 RVA: 0x0013DBCC File Offset: 0x0013BDCC
		public void Initialize(Chemist chemist)
		{
			this.AssignedChemist = chemist;
			this.AssignedChemist.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.TitleLabel.text = chemist.fullName;
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0013DC28 File Offset: 0x0013BE28
		protected virtual void RefreshUI()
		{
			ChemistConfiguration chemistConfiguration = this.AssignedChemist.Configuration as ChemistConfiguration;
			for (int i = 0; i < this.StationsIcons.Length; i++)
			{
				if (chemistConfiguration.Stations.SelectedObjects.Count > i)
				{
					this.StationsIcons[i].sprite = chemistConfiguration.Stations.SelectedObjects[i].ItemInstance.Icon;
					this.StationsIcons[i].enabled = true;
				}
				else
				{
					this.StationsIcons[i].enabled = false;
				}
			}
		}

		// Token: 0x040038AB RID: 14507
		[Header("References")]
		public Image[] StationsIcons;
	}
}
