using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AF3 RID: 2803
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x0013AE64 File Offset: 0x00139064
		// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x0013AE6C File Offset: 0x0013906C
		public List<RouteListField> Fields { get; protected set; } = new List<RouteListField>();

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0013AE78 File Offset: 0x00139078
		private void Start()
		{
			this.FieldLabel.text = this.FieldText;
			for (int i = 0; i < this.RouteEntries.Length; i++)
			{
				RouteEntryUI entry = this.RouteEntries[i];
				this.RouteEntries[i].onDeleteClicked.AddListener(new UnityAction(delegate()
				{
					this.EntryDeleteClicked(entry);
				}));
			}
			this.AddButton.onClick.AddListener(new UnityAction(this.AddClicked));
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0013AF00 File Offset: 0x00139100
		public void Bind(List<RouteListField> field)
		{
			this.Fields = new List<RouteListField>();
			this.Fields.AddRange(field);
			this.Refresh(this.Fields[0].Routes);
			this.Fields[0].onListChanged.AddListener(new UnityAction<List<AdvancedTransitRoute>>(this.Refresh));
			this.MultiEditBlocker.gameObject.SetActive(this.Fields.Count > 1);
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0013AF7C File Offset: 0x0013917C
		private void Refresh(List<AdvancedTransitRoute> newVal)
		{
			int num = 0;
			for (int i = 0; i < this.RouteEntries.Length; i++)
			{
				if (newVal.Count > i)
				{
					num++;
					this.RouteEntries[i].AssignRoute(newVal[i]);
					this.RouteEntries[i].gameObject.SetActive(true);
				}
				else
				{
					this.RouteEntries[i].ClearRoute();
					this.RouteEntries[i].gameObject.SetActive(false);
				}
			}
			for (int j = 0; j < newVal.Count; j++)
			{
				AdvancedTransitRoute advancedTransitRoute = newVal[j];
				advancedTransitRoute.onSourceChange = (Action<ITransitEntity>)Delegate.Remove(advancedTransitRoute.onSourceChange, new Action<ITransitEntity>(this.RouteChanged));
				AdvancedTransitRoute advancedTransitRoute2 = newVal[j];
				advancedTransitRoute2.onDestinationChange = (Action<ITransitEntity>)Delegate.Remove(advancedTransitRoute2.onDestinationChange, new Action<ITransitEntity>(this.RouteChanged));
				AdvancedTransitRoute advancedTransitRoute3 = newVal[j];
				advancedTransitRoute3.onSourceChange = (Action<ITransitEntity>)Delegate.Combine(advancedTransitRoute3.onSourceChange, new Action<ITransitEntity>(this.RouteChanged));
				AdvancedTransitRoute advancedTransitRoute4 = newVal[j];
				advancedTransitRoute4.onDestinationChange = (Action<ITransitEntity>)Delegate.Combine(advancedTransitRoute4.onDestinationChange, new Action<ITransitEntity>(this.RouteChanged));
			}
			this.AddButton.gameObject.SetActive(num < this.Fields[0].MaxRoutes);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0013B0CF File Offset: 0x001392CF
		private void EntryDeleteClicked(RouteEntryUI entry)
		{
			this.Fields[0].RemoveItem(entry.AssignedRoute);
			entry.ClearRoute();
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0013B0EE File Offset: 0x001392EE
		private void AddClicked()
		{
			this.Fields[0].AddItem(new AdvancedTransitRoute(null, null));
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x0013B108 File Offset: 0x00139308
		private void RouteChanged(ITransitEntity newEntity)
		{
			this.Fields[0].Replicate();
		}

		// Token: 0x04003837 RID: 14391
		[Header("References")]
		public string FieldText = "Routes";

		// Token: 0x04003838 RID: 14392
		public TextMeshProUGUI FieldLabel;

		// Token: 0x04003839 RID: 14393
		public RouteEntryUI[] RouteEntries;

		// Token: 0x0400383A RID: 14394
		public RectTransform MultiEditBlocker;

		// Token: 0x0400383B RID: 14395
		public Button AddButton;
	}
}
