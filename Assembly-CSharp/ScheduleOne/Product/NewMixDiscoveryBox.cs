using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Packaging;
using ScheduleOne.Properties;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x020008EA RID: 2282
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x06003D9B RID: 15771 RVA: 0x0010298C File Offset: 0x00100B8C
		public void Start()
		{
			this.closedLidPose = new Pose(this.Lid.localPosition, this.Lid.localRotation);
			this.CloseCase();
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			this.IntObj.gameObject.SetActive(false);
			bool isMixComplete = NetworkSingleton<ProductManager>.Instance.IsMixComplete;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x001029F8 File Offset: 0x00100BF8
		public void ShowProduct(ProductDefinition baseDefinition, List<Property> properties)
		{
			this.PropertiesText.text = string.Empty;
			foreach (Property property in properties)
			{
				if (this.PropertiesText.text.Length > 0)
				{
					TextMeshPro propertiesText = this.PropertiesText;
					propertiesText.text += "\n";
				}
				TextMeshPro propertiesText2 = this.PropertiesText;
				propertiesText2.text = string.Concat(new string[]
				{
					propertiesText2.text,
					"<color=#",
					ColorUtility.ToHtmlStringRGBA(property.LabelColor),
					">",
					property.Name,
					"</color>"
				});
			}
			for (int i = 0; i < this.Visuals.Length; i++)
			{
				this.Visuals[i].Visuals.gameObject.SetActive(false);
			}
			ProductDefinition productDefinition = Object.Instantiate<ProductDefinition>(baseDefinition);
			switch (baseDefinition.DrugType)
			{
			case EDrugType.Marijuana:
			{
				WeedDefinition weedDefinition = productDefinition as WeedDefinition;
				WeedAppearanceSettings appearanceSettings = WeedDefinition.GetAppearanceSettings(properties);
				weedDefinition.Initialize(properties, new List<EDrugType>
				{
					EDrugType.Marijuana
				}, appearanceSettings);
				(weedDefinition.GetDefaultInstance(1) as WeedInstance).SetupPackagingVisuals(this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Marijuana).Visuals);
				this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Marijuana).Visuals.gameObject.SetActive(true);
				break;
			}
			case EDrugType.Methamphetamine:
			{
				MethDefinition methDefinition = productDefinition as MethDefinition;
				MethAppearanceSettings appearanceSettings2 = MethDefinition.GetAppearanceSettings(properties);
				methDefinition.Initialize(properties, new List<EDrugType>
				{
					EDrugType.Methamphetamine
				}, appearanceSettings2);
				(methDefinition.GetDefaultInstance(1) as MethInstance).SetupPackagingVisuals(this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Methamphetamine).Visuals);
				this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Methamphetamine).Visuals.gameObject.SetActive(true);
				break;
			}
			case EDrugType.Cocaine:
			{
				CocaineDefinition cocaineDefinition = productDefinition as CocaineDefinition;
				CocaineAppearanceSettings appearanceSettings3 = CocaineDefinition.GetAppearanceSettings(properties);
				cocaineDefinition.Initialize(properties, new List<EDrugType>
				{
					EDrugType.Cocaine
				}, appearanceSettings3);
				(cocaineDefinition.GetDefaultInstance(1) as CocaineInstance).SetupPackagingVisuals(this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Cocaine).Visuals);
				this.Visuals.First((NewMixDiscoveryBox.DrugTypeVisuals x) => x.DrugType == EDrugType.Cocaine).Visuals.gameObject.SetActive(true);
				break;
			}
			default:
				Console.LogError("Drug type not supported", null);
				break;
			}
			base.gameObject.SetActive(true);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00102D24 File Offset: 0x00100F24
		private void CloseCase()
		{
			this.isOpen = false;
			this.Lid.localPosition = this.closedLidPose.position;
			this.Lid.localRotation = this.closedLidPose.rotation;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00102D59 File Offset: 0x00100F59
		private void OpenCase()
		{
			this.isOpen = true;
			this.Animation.Play("New mix box open");
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00102D73 File Offset: 0x00100F73
		private void Interacted()
		{
			if (!this.isOpen)
			{
				this.OpenCase();
			}
			Registry.GetItem(this.currentMix.ProductID);
		}

		// Token: 0x04002C66 RID: 11366
		private bool isOpen;

		// Token: 0x04002C67 RID: 11367
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04002C68 RID: 11368
		public TextMeshPro PropertiesText;

		// Token: 0x04002C69 RID: 11369
		public NewMixDiscoveryBox.DrugTypeVisuals[] Visuals;

		// Token: 0x04002C6A RID: 11370
		public Animation Animation;

		// Token: 0x04002C6B RID: 11371
		public InteractableObject IntObj;

		// Token: 0x04002C6C RID: 11372
		public Transform Lid;

		// Token: 0x04002C6D RID: 11373
		private Pose closedLidPose;

		// Token: 0x04002C6E RID: 11374
		private NewMixOperation currentMix;

		// Token: 0x020008EB RID: 2283
		[Serializable]
		public class DrugTypeVisuals
		{
			// Token: 0x04002C6F RID: 11375
			public EDrugType DrugType;

			// Token: 0x04002C70 RID: 11376
			public FilledPackagingVisuals Visuals;
		}
	}
}
