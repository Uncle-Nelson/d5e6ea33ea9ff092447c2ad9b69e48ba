using System;
using ScheduleOne.Employees;
using ScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B0F RID: 2831
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06004BA0 RID: 19360 RVA: 0x0013DF43 File Offset: 0x0013C143
		// (set) Token: 0x06004BA1 RID: 19361 RVA: 0x0013DF4B File Offset: 0x0013C14B
		public Packager AssignedPackager { get; protected set; }

		// Token: 0x06004BA2 RID: 19362 RVA: 0x0013DF54 File Offset: 0x0013C154
		public void Initialize(Packager packager)
		{
			this.AssignedPackager = packager;
			this.AssignedPackager.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.TitleLabel.text = packager.fullName;
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x0013DFB0 File Offset: 0x0013C1B0
		protected virtual void RefreshUI()
		{
			PackagerConfiguration packagerConfiguration = this.AssignedPackager.Configuration as PackagerConfiguration;
			for (int i = 0; i < this.StationRects.Length; i++)
			{
				if (packagerConfiguration.Stations.SelectedObjects.Count > i)
				{
					this.StationRects[i].Find("Icon").GetComponent<Image>().sprite = packagerConfiguration.Stations.SelectedObjects[i].ItemInstance.Icon;
					this.StationRects[i].Find("Icon").gameObject.SetActive(true);
				}
				else
				{
					this.StationRects[i].Find("Icon").gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x040038B3 RID: 14515
		[Header("References")]
		public RectTransform[] StationRects;
	}
}
