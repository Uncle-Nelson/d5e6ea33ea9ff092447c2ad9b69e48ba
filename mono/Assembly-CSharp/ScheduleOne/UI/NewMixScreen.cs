using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A0C RID: 2572
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x0012210C File Offset: 0x0012030C
		public bool IsOpen
		{
			get
			{
				return this.canvas.enabled;
			}
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x0012211C File Offset: 0x0012031C
		protected override void Awake()
		{
			base.Awake();
			this.nameInputField.onValueChanged.AddListener(new UnityAction<string>(this.OnNameValueChanged));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x0012217A File Offset: 0x0012037A
		protected virtual void Update()
		{
			if (this.IsOpen && this.confirmButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
			{
				this.ConfirmButtonClicked();
			}
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001221A0 File Offset: 0x001203A0
		public void Open(List<Property> properties, EDrugType drugType, float productMarketValue)
		{
			this.canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.nameInputField.text = this.GenerateUniqueName(properties.ToArray(), drugType);
			Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
			this.PropertiesLabel.text = string.Empty;
			for (int i = 0; i < properties.Count; i++)
			{
				Property property = properties[i];
				if (this.PropertiesLabel.text.Length > 0)
				{
					TextMeshProUGUI propertiesLabel = this.PropertiesLabel;
					propertiesLabel.text += "\n";
				}
				if (i == 4 && properties.Count > 5)
				{
					int num = properties.Count - 5 + 1;
					TextMeshProUGUI propertiesLabel2 = this.PropertiesLabel;
					propertiesLabel2.text = propertiesLabel2.text + "+ " + num.ToString() + " more...";
					break;
				}
				TextMeshProUGUI propertiesLabel3 = this.PropertiesLabel;
				propertiesLabel3.text = string.Concat(new string[]
				{
					propertiesLabel3.text,
					"<color=#",
					ColorUtility.ToHtmlStringRGBA(property.LabelColor),
					">• ",
					property.Name,
					"</color>"
				});
			}
			this.MarketValueLabel.text = "Market Value: <color=#54E717>" + MoneyManager.FormatAmount(productMarketValue, false, false) + "</color>";
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x0012230C File Offset: 0x0012050C
		public void Close()
		{
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x0012233B File Offset: 0x0012053B
		public void RandomizeButtonClicked()
		{
			this.nameInputField.text = this.GenerateUniqueName(null, EDrugType.Marijuana);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00122350 File Offset: 0x00120550
		public void ConfirmButtonClicked()
		{
			if (this.onMixNamed != null)
			{
				this.onMixNamed(this.nameInputField.text);
			}
			this.Sound.Play();
			this.RandomizeButtonClicked();
			this.Close();
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00122388 File Offset: 0x00120588
		public string GenerateUniqueName(Property[] properties = null, EDrugType drugType = EDrugType.Marijuana)
		{
			Random.InitState((int)(Time.timeSinceLevelLoad * 10f));
			string str = this.name1Library[Random.Range(0, this.name1Library.Count)];
			string str2 = this.name2Library[Random.Range(0, this.name2Library.Count)];
			if (properties != null)
			{
				int num = 0;
				foreach (Property property in properties)
				{
					num += property.Name.GetHashCode() / 2000;
				}
				num += drugType.GetHashCode() / 1000;
				int value = num % this.name1Library.Count;
				int value2 = num / 2 % this.name2Library.Count;
				str = this.name1Library[Mathf.Clamp(value, 0, this.name1Library.Count)];
				str2 = this.name2Library[Mathf.Clamp(value2, 0, this.name2Library.Count)];
			}
			while (NetworkSingleton<ProductManager>.Instance.ProductNames.Contains(str + " " + str2))
			{
				str = this.name1Library[Random.Range(0, this.name1Library.Count)];
				str2 = this.name2Library[Random.Range(0, this.name2Library.Count)];
			}
			return str + " " + str2;
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x001224F4 File Offset: 0x001206F4
		protected void RefreshNameButtons()
		{
			float num = this.nameInputField.textComponent.preferredWidth / 2f;
			float num2 = 20f;
			this.editIcon.anchoredPosition = new Vector2(num + num2, this.editIcon.anchoredPosition.y);
			this.randomizeNameButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-num - num2, this.randomizeNameButton.GetComponent<RectTransform>().anchoredPosition.y);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00122570 File Offset: 0x00120770
		public void OnNameValueChanged(string newVal)
		{
			if (NetworkSingleton<ProductManager>.Instance.ProductNames.Contains(this.nameInputField.text) || !ProductManager.IsMixNameValid(this.nameInputField.text))
			{
				this.mixAlreadyExistsText.gameObject.SetActive(true);
				this.confirmButton.interactable = false;
			}
			else
			{
				this.mixAlreadyExistsText.gameObject.SetActive(false);
				this.confirmButton.interactable = true;
			}
			this.RefreshNameButtons();
			base.Invoke("RefreshNameButtons", 0.016666668f);
		}

		// Token: 0x040032CC RID: 13004
		public const int MAX_PROPERTIES_DISPLAYED = 5;

		// Token: 0x040032CD RID: 13005
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x040032CE RID: 13006
		public RectTransform Container;

		// Token: 0x040032CF RID: 13007
		[SerializeField]
		protected TMP_InputField nameInputField;

		// Token: 0x040032D0 RID: 13008
		[SerializeField]
		protected GameObject mixAlreadyExistsText;

		// Token: 0x040032D1 RID: 13009
		[SerializeField]
		protected RectTransform editIcon;

		// Token: 0x040032D2 RID: 13010
		[SerializeField]
		protected Button randomizeNameButton;

		// Token: 0x040032D3 RID: 13011
		[SerializeField]
		protected Button confirmButton;

		// Token: 0x040032D4 RID: 13012
		[SerializeField]
		protected TextMeshProUGUI PropertiesLabel;

		// Token: 0x040032D5 RID: 13013
		[SerializeField]
		protected TextMeshProUGUI MarketValueLabel;

		// Token: 0x040032D6 RID: 13014
		public AudioSourceController Sound;

		// Token: 0x040032D7 RID: 13015
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject attributeEntryPrefab;

		// Token: 0x040032D8 RID: 13016
		[Header("Name Library")]
		[SerializeField]
		protected List<string> name1Library = new List<string>();

		// Token: 0x040032D9 RID: 13017
		[SerializeField]
		protected List<string> name2Library = new List<string>();

		// Token: 0x040032DA RID: 13018
		public Action<string> onMixNamed;
	}
}
