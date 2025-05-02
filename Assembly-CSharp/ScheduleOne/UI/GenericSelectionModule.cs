using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009ED RID: 2541
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x0011F517 File Offset: 0x0011D717
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x0011F51F File Offset: 0x0011D71F
		public bool isOpen { get; protected set; }

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x0011F528 File Offset: 0x0011D728
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x0011F530 File Offset: 0x0011D730
		[HideInInspector]
		public int ChosenOptionIndex { get; protected set; } = -1;

		// Token: 0x0600448B RID: 17547 RVA: 0x0011F539 File Offset: 0x0011D739
		protected override void Awake()
		{
			base.Awake();
			this.Close();
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x0011F547 File Offset: 0x0011D747
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 50);
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x0011F562 File Offset: 0x0011D762
		private void Exit(ExitAction action)
		{
			if (!this.isOpen)
			{
				return;
			}
			if (action.used)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Cancel();
			}
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x0011F58C File Offset: 0x0011D78C
		public void Open(string title, List<string> options)
		{
			this.isOpen = true;
			this.OptionChosen = false;
			this.ChosenOptionIndex = -1;
			this.ClearOptions();
			this.TitleText.text = title;
			for (int i = 0; i < options.Count; i++)
			{
				RectTransform component = Object.Instantiate<GameObject>(this.ListOptionPrefab, this.OptionContainer).GetComponent<RectTransform>();
				component.Find("Label").GetComponent<TextMeshProUGUI>().text = options[i];
				component.anchoredPosition = new Vector2(0f, -((float)i + 0.5f) * component.sizeDelta.y);
				int index = i;
				component.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.ListOptionClicked(index);
				}));
			}
			this.canvas.enabled = true;
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x0011F66B File Offset: 0x0011D86B
		public void Close()
		{
			this.isOpen = false;
			this.canvas.enabled = false;
			this.ClearOptions();
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x0011F686 File Offset: 0x0011D886
		public void Cancel()
		{
			this.ChosenOptionIndex = -1;
			this.OptionChosen = true;
			this.Close();
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x0011F69C File Offset: 0x0011D89C
		private void ClearOptions()
		{
			int childCount = this.OptionContainer.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Object.Destroy(this.OptionContainer.GetChild(0).gameObject);
			}
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x0011F6D7 File Offset: 0x0011D8D7
		private void ListOptionClicked(int index)
		{
			this.ChosenOptionIndex = index;
			this.OptionChosen = true;
			this.Close();
		}

		// Token: 0x04003202 RID: 12802
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003203 RID: 12803
		public TextMeshProUGUI TitleText;

		// Token: 0x04003204 RID: 12804
		public RectTransform OptionContainer;

		// Token: 0x04003205 RID: 12805
		public Button CloseButton;

		// Token: 0x04003206 RID: 12806
		[Header("Prefabs")]
		public GameObject ListOptionPrefab;

		// Token: 0x04003207 RID: 12807
		[HideInInspector]
		public bool OptionChosen;
	}
}
