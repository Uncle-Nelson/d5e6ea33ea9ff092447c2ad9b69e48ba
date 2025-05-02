using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A6 RID: 2470
	public abstract class ACSelection<T> : MonoBehaviour where T : Object
	{
		// Token: 0x060042D2 RID: 17106 RVA: 0x001183D4 File Offset: 0x001165D4
		protected virtual void Awake()
		{
			for (int i = 0; i < this.Options.Count; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.ButtonPrefab, base.transform);
				gameObject.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = this.GetOptionLabel(i);
				this.buttons.Add(gameObject);
				int index = i;
				gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.SelectOption(index, true);
				}));
			}
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x0011846C File Offset: 0x0011666C
		public void SelectOption(int index, bool notify = true)
		{
			int selectedOptionIndex = this.SelectedOptionIndex;
			if (index != this.SelectedOptionIndex)
			{
				if (this.SelectedOptionIndex != -1)
				{
					this.SetButtonHighlighted(this.SelectedOptionIndex, false);
				}
				this.SelectedOptionIndex = index;
				this.SetButtonHighlighted(this.SelectedOptionIndex, true);
			}
			else if (this.Nullable)
			{
				this.SetButtonHighlighted(this.SelectedOptionIndex, false);
				this.SelectedOptionIndex = -1;
			}
			if (selectedOptionIndex != this.SelectedOptionIndex && notify)
			{
				this.CallValueChange();
			}
		}

		// Token: 0x060042D4 RID: 17108
		public abstract void CallValueChange();

		// Token: 0x060042D5 RID: 17109
		public abstract string GetOptionLabel(int index);

		// Token: 0x060042D6 RID: 17110
		public abstract int GetAssetPathIndex(string path);

		// Token: 0x060042D7 RID: 17111 RVA: 0x001184E5 File Offset: 0x001166E5
		private void SetButtonHighlighted(int buttonIndex, bool h)
		{
			if (buttonIndex == -1)
			{
				return;
			}
			this.buttons[buttonIndex].transform.Find("Indicator").gameObject.SetActive(h);
		}

		// Token: 0x04003070 RID: 12400
		[Header("References")]
		public GameObject ButtonPrefab;

		// Token: 0x04003071 RID: 12401
		[Header("Settings")]
		public int PropertyIndex;

		// Token: 0x04003072 RID: 12402
		public List<T> Options = new List<T>();

		// Token: 0x04003073 RID: 12403
		public bool Nullable = true;

		// Token: 0x04003074 RID: 12404
		public int DefaultOptionIndex;

		// Token: 0x04003075 RID: 12405
		protected List<GameObject> buttons = new List<GameObject>();

		// Token: 0x04003076 RID: 12406
		protected int SelectedOptionIndex = -1;

		// Token: 0x04003077 RID: 12407
		public UnityEvent<T> onValueChange;

		// Token: 0x04003078 RID: 12408
		public UnityEvent<T, int> onValueChangeWithIndex;
	}
}
