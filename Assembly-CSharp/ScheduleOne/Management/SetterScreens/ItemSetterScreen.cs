using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets.Options;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Management.SetterScreens
{
	// Token: 0x02000595 RID: 1429
	public class ItemSetterScreen : Singleton<ItemSetterScreen>
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x00090D82 File Offset: 0x0008EF82
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00090D8A File Offset: 0x0008EF8A
		public ItemList Option { get; private set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x00090D93 File Offset: 0x0008EF93
		public bool IsOpen
		{
			get
			{
				return this.Option != null;
			}
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00090DA0 File Offset: 0x0008EFA0
		protected override void Awake()
		{
			base.Awake();
			this.allEntry = this.CreateEntry(null, "All", new Action(this.AllClicked), "", false);
			this.noneEntry = this.CreateEntry(null, "None", new Action(this.NoneClicked), "", false);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
			this.Close();
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00090E14 File Offset: 0x0008F014
		public virtual void Open(ItemList option)
		{
			this.Option = option;
			this.TitleLabel.text = this.Option.Name;
			base.gameObject.SetActive(true);
			this.allEntry.gameObject.SetActive(option.CanBeAll);
			this.noneEntry.gameObject.SetActive(option.CanBeNone);
			this.CreateEntries();
			this.RefreshTicks();
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00090E82 File Offset: 0x0008F082
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00090EAC File Offset: 0x0008F0AC
		public virtual void Close()
		{
			this.Option = null;
			this.DestroyEntries();
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00090EC8 File Offset: 0x0008F0C8
		private RectTransform CreateEntry(Sprite icon, string label, Action onClick, string prefabID = "", bool createPair = false)
		{
			RectTransform component = Object.Instantiate<GameObject>(this.ListEntryPrefab, this.EntryContainer).GetComponent<RectTransform>();
			if (icon == null)
			{
				component.Find("Icon").gameObject.SetActive(false);
				component.Find("Title").GetComponent<RectTransform>().offsetMin = new Vector2(0.5f, 0f);
			}
			else
			{
				component.Find("Icon").GetComponent<Image>().sprite = icon;
			}
			component.Find("Title").GetComponent<TextMeshProUGUI>().text = label;
			component.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
			{
				onClick();
			}));
			if (createPair)
			{
				this.pairs.Add(new ItemSetterScreen.Pair
				{
					prefabID = prefabID,
					entry = component
				});
			}
			return component;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00090FAA File Offset: 0x0008F1AA
		private void AllClicked()
		{
			this.Option.All = true;
			this.Option.None = false;
			this.RefreshTicks();
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00090FCA File Offset: 0x0008F1CA
		private void NoneClicked()
		{
			this.Option.All = false;
			this.Option.None = true;
			this.Option.Selection.Clear();
			this.RefreshTicks();
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00090FFC File Offset: 0x0008F1FC
		private void EntryClicked(string prefabID)
		{
			if (this.Option.All)
			{
				this.Option.Selection.Clear();
				this.Option.Selection.AddRange(this.Option.OptionList);
				this.Option.Selection.Remove(prefabID);
			}
			else if (this.Option.Selection.Contains(prefabID))
			{
				this.Option.Selection.Remove(prefabID);
			}
			else
			{
				this.Option.Selection.Add(prefabID);
			}
			this.Option.All = false;
			this.Option.None = false;
			this.RefreshTicks();
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x000910AC File Offset: 0x0008F2AC
		private void RefreshTicks()
		{
			this.SetEntryTicked(this.allEntry, false);
			this.SetEntryTicked(this.noneEntry, false);
			for (int k = 0; k < this.pairs.Count; k++)
			{
				this.SetEntryTicked(this.pairs[k].entry, false);
			}
			if (this.Option.All)
			{
				this.SetEntryTicked(this.allEntry, true);
				for (int j = 0; j < this.pairs.Count; j++)
				{
					this.SetEntryTicked(this.pairs[j].entry, true);
				}
				return;
			}
			if (this.Option.None || this.Option.Selection.Count == 0)
			{
				this.SetEntryTicked(this.noneEntry, true);
				return;
			}
			int i;
			Predicate<ItemSetterScreen.Pair> <>9__0;
			int i2;
			for (i = 0; i < this.Option.Selection.Count; i = i2 + 1)
			{
				List<ItemSetterScreen.Pair> list = this.pairs;
				Predicate<ItemSetterScreen.Pair> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((ItemSetterScreen.Pair x) => x.prefabID == this.Option.Selection[i]));
				}
				this.SetEntryTicked(list.Find(match).entry, true);
				i2 = i;
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x000911ED File Offset: 0x0008F3ED
		private void SetEntryTicked(RectTransform entry, bool ticked)
		{
			entry.Find("Tick").gameObject.SetActive(ticked);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00091208 File Offset: 0x0008F408
		private void CreateEntries()
		{
			for (int i = 0; i < this.Option.OptionList.Count; i++)
			{
				Console.Log(this.Option.OptionList[i], null);
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00091248 File Offset: 0x0008F448
		private void DestroyEntries()
		{
			foreach (ItemSetterScreen.Pair pair in this.pairs)
			{
				Object.Destroy(pair.entry.gameObject);
			}
			this.pairs.Clear();
		}

		// Token: 0x04001A88 RID: 6792
		[Header("Prefabs")]
		public GameObject ListEntryPrefab;

		// Token: 0x04001A89 RID: 6793
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x04001A8A RID: 6794
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04001A8B RID: 6795
		private RectTransform allEntry;

		// Token: 0x04001A8C RID: 6796
		private RectTransform noneEntry;

		// Token: 0x04001A8D RID: 6797
		private List<ItemSetterScreen.Pair> pairs = new List<ItemSetterScreen.Pair>();

		// Token: 0x02000596 RID: 1430
		private class Pair
		{
			// Token: 0x04001A8E RID: 6798
			public string prefabID;

			// Token: 0x04001A8F RID: 6799
			public RectTransform entry;
		}
	}
}
