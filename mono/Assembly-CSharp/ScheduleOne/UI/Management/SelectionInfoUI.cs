using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B03 RID: 2819
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x06004B5C RID: 19292 RVA: 0x0013CF1C File Offset: 0x0013B11C
		private void Update()
		{
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.SelfUpdate)
			{
				List<IConfigurable> list = new List<IConfigurable>();
				list.AddRange(Singleton<ManagementWorldspaceCanvas>.Instance.SelectedConfigurables);
				if (Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable != null && !list.Contains(Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable))
				{
					list.Add(Singleton<ManagementWorldspaceCanvas>.Instance.HoveredConfigurable);
				}
				this.Set(list);
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0013CF8C File Offset: 0x0013B18C
		public void Set(List<IConfigurable> Configurables)
		{
			if (Configurables.Count == 0)
			{
				this.Icon.sprite = this.CrossSprite;
				this.Title.text = "Nothing selected";
				return;
			}
			bool flag = true;
			if (Configurables.Count > 1)
			{
				for (int i = 0; i < Configurables.Count - 1; i++)
				{
					if (Configurables[i].ConfigurableType != Configurables[i + 1].ConfigurableType)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				this.Icon.sprite = Configurables[0].TypeIcon;
				this.Title.text = Configurables.Count.ToString() + "x " + ConfigurableType.GetTypeName(Configurables[0].ConfigurableType);
				return;
			}
			this.Icon.sprite = this.NonUniformTypeSprite;
			this.Title.text = Configurables.Count.ToString() + "x Mixed types";
		}

		// Token: 0x0400388B RID: 14475
		[Header("References")]
		public Image Icon;

		// Token: 0x0400388C RID: 14476
		public TextMeshProUGUI Title;

		// Token: 0x0400388D RID: 14477
		[Header("Settings")]
		public bool SelfUpdate = true;

		// Token: 0x0400388E RID: 14478
		public Sprite NonUniformTypeSprite;

		// Token: 0x0400388F RID: 14479
		public Sprite CrossSprite;
	}
}
