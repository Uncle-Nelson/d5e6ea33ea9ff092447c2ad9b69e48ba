using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.UI.Phone.Map;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x02000AD7 RID: 2775
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x001383EF File Offset: 0x001365EF
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x001383F7 File Offset: 0x001365F7
		public NPC SelectedNPC { get; protected set; }

		// Token: 0x06004A71 RID: 19057 RVA: 0x00138400 File Offset: 0x00136600
		public void Open(NPC npc)
		{
			this.SelectedNPC = npc;
			if (npc == null)
			{
				return;
			}
			bool unlocked = npc.RelationData.Unlocked;
			bool flag = unlocked;
			if (!npc.RelationData.Unlocked && npc.RelationData.IsMutuallyKnown() && NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("SelectedPotentialCustomer", true.ToString(), false);
			}
			this.poi = null;
			this.UnlockHintLabel.gameObject.SetActive(false);
			if (npc is Supplier)
			{
				this.TypeLabel.text = "Supplier";
				this.TypeLabel.color = Supplier.SupplierLabelColor;
				if (!unlocked)
				{
					this.UnlockHintLabel.text = "Unlock this supplier by reaching 'friendly' with one of their connections.";
					this.UnlockHintLabel.gameObject.SetActive(true);
				}
				if (unlocked)
				{
					this.poi = (npc as Supplier).Stash.StashPoI;
				}
			}
			else if (npc is Dealer)
			{
				this.TypeLabel.text = "Dealer";
				this.TypeLabel.color = Dealer.DealerLabelColor;
				Dealer dealer = npc as Dealer;
				if (!(npc as Dealer).HasBeenRecommended)
				{
					this.UnlockHintLabel.text = "Unlock this dealer by reaching 'friendly' with one of their connections.";
					this.UnlockHintLabel.gameObject.SetActive(true);
				}
				else if (!dealer.IsRecruited)
				{
					this.UnlockHintLabel.text = "This dealer is ready to be hired. Go to them and pay their signing free to recruit them.";
					this.UnlockHintLabel.gameObject.SetActive(true);
				}
				if (dealer.IsRecruited)
				{
					this.poi = dealer.dealerPoI;
				}
				else if (dealer.HasBeenRecommended)
				{
					this.poi = dealer.potentialDealerPoI;
				}
			}
			else
			{
				this.TypeLabel.text = "Customer";
				this.TypeLabel.color = Color.white;
				if (npc.RelationData.IsMutuallyKnown())
				{
					flag = true;
					if (!unlocked)
					{
						if (!GameManager.IS_TUTORIAL)
						{
							this.poi = npc.GetComponent<Customer>().potentialCustomerPoI;
						}
						this.UnlockHintLabel.text = "Unlock this customer by giving them a free sample. Use your map to see their approximate location.";
						this.UnlockHintLabel.gameObject.SetActive(true);
					}
				}
			}
			if (flag)
			{
				this.NameLabel.text = npc.fullName;
			}
			else
			{
				this.NameLabel.text = "???";
			}
			this.ShowOnMapButton.gameObject.SetActive(this.poi != null);
			if (npc.RelationData.Unlocked)
			{
				this.RelationshipScrollbar.value = npc.RelationData.RelationDelta / 5f;
				this.RelationshipLabel.text = string.Concat(new string[]
				{
					"<color=#",
					ColorUtility.ToHtmlStringRGB(RelationshipCategory.GetColor(RelationshipCategory.GetCategory(npc.RelationData.RelationDelta))),
					">",
					RelationshipCategory.GetCategory(npc.RelationData.RelationDelta).ToString(),
					"</color>"
				});
				this.RelationshipLabel.enabled = true;
				this.RelationshipContainer.gameObject.SetActive(true);
			}
			else
			{
				this.RelationshipContainer.gameObject.SetActive(false);
			}
			Customer component = npc.GetComponent<Customer>();
			this.StandardsContainer.gameObject.SetActive(false);
			if (component != null)
			{
				this.AddictionContainer.gameObject.SetActive(npc.RelationData.Unlocked);
				this.AddictionScrollbar.value = component.CurrentAddiction;
				this.AddictionLabel.text = Mathf.FloorToInt(component.CurrentAddiction * 100f).ToString() + "%";
				this.AddictionLabel.color = Color.Lerp(this.DependenceColor_Min, this.DependenceColor_Max, component.CurrentAddiction);
				EQuality correspondingQuality = component.CustomerData.Standards.GetCorrespondingQuality();
				this.StandardsStar.color = ItemQuality.GetColor(correspondingQuality);
				this.StandardsLabel.color = this.StandardsStar.color;
				this.StandardsLabel.text = component.CustomerData.Standards.GetName();
				this.StandardsContainer.gameObject.SetActive(true);
				this.PropertiesContainer.gameObject.SetActive(true);
				this.PropertiesLabel.text = string.Empty;
				for (int i = 0; i < component.CustomerData.PreferredProperties.Count; i++)
				{
					if (i > 0)
					{
						Text propertiesLabel = this.PropertiesLabel;
						propertiesLabel.text += "\n";
					}
					string str = string.Concat(new string[]
					{
						"<color=#",
						ColorUtility.ToHtmlStringRGBA(component.CustomerData.PreferredProperties[i].LabelColor),
						">•  ",
						component.CustomerData.PreferredProperties[i].Name,
						"</color>"
					});
					Text propertiesLabel2 = this.PropertiesLabel;
					propertiesLabel2.text += str;
				}
			}
			else
			{
				this.AddictionContainer.gameObject.SetActive(false);
				this.PropertiesContainer.gameObject.SetActive(false);
			}
			this.LayoutGroup.CalculateLayoutInputHorizontal();
			this.LayoutGroup.CalculateLayoutInputVertical();
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00138950 File Offset: 0x00136B50
		public void ShowOnMap()
		{
			if (this.poi == null || this.poi.UI == null)
			{
				return;
			}
			if (NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("PotentialCustomerShownOnMap", true.ToString(), false);
			}
			PlayerSingleton<ContactsApp>.Instance.SetOpen(false);
			PlayerSingleton<MapApp>.Instance.FocusPosition(this.poi.UI.anchoredPosition);
			PlayerSingleton<MapApp>.Instance.SkipFocusPlayer = true;
			PlayerSingleton<MapApp>.Instance.SetOpen(true);
		}

		// Token: 0x040037BA RID: 14266
		[Header("Settings")]
		public Color DependenceColor_Min;

		// Token: 0x040037BB RID: 14267
		public Color DependenceColor_Max;

		// Token: 0x040037BC RID: 14268
		[Header("References")]
		public VerticalLayoutGroup LayoutGroup;

		// Token: 0x040037BD RID: 14269
		public Text NameLabel;

		// Token: 0x040037BE RID: 14270
		public Text TypeLabel;

		// Token: 0x040037BF RID: 14271
		public Text UnlockHintLabel;

		// Token: 0x040037C0 RID: 14272
		public RectTransform RelationshipContainer;

		// Token: 0x040037C1 RID: 14273
		public Scrollbar RelationshipScrollbar;

		// Token: 0x040037C2 RID: 14274
		public Text RelationshipLabel;

		// Token: 0x040037C3 RID: 14275
		public RectTransform AddictionContainer;

		// Token: 0x040037C4 RID: 14276
		public Scrollbar AddictionScrollbar;

		// Token: 0x040037C5 RID: 14277
		public Text AddictionLabel;

		// Token: 0x040037C6 RID: 14278
		public RectTransform PropertiesContainer;

		// Token: 0x040037C7 RID: 14279
		public Text PropertiesLabel;

		// Token: 0x040037C8 RID: 14280
		public Button ShowOnMapButton;

		// Token: 0x040037C9 RID: 14281
		public RectTransform StandardsContainer;

		// Token: 0x040037CA RID: 14282
		public Image StandardsStar;

		// Token: 0x040037CB RID: 14283
		public Text StandardsLabel;

		// Token: 0x040037CC RID: 14284
		private POI poi;
	}
}
